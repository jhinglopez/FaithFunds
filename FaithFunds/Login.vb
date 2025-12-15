Imports System.Data.OleDb
Imports System.Security.Cryptography
Imports System.Text

Module GlobalVariables
    Public Uname As String
    Public Upass As String
End Module

Public Class Login
    Private dbcon As OleDbConnection
    Dim dbcom As OleDbCommand
    Private Sub MyCon()
        dbcon = New OleDbConnection("provider=microsoft.jet.oledb.4.0;data source=" & Application.StartupPath & "\FaithFunds.mdb")
        dbcon.Open()
    End Sub


    Private Sub InsertAuditLog(user As String, desc As String)
        Try
            MyCon()
            Dim sql As String = "INSERT INTO Audit_Login (UserName, Description, DateAndTime) VALUES (?, ?, ?)"

            Using cmd As New OleDbCommand(sql, dbcon)
                cmd.Parameters.AddWithValue("?", user)
                cmd.Parameters.AddWithValue("?", desc)
                cmd.Parameters.AddWithValue("?", DateTime.Now)
                cmd.ExecuteNonQuery()
            End Using

        Catch ex As Exception
            MsgBox("Audit Error: " & ex.Message)
        Finally
            If dbcon IsNot Nothing AndAlso dbcon.State = ConnectionState.Open Then dbcon.Close()
        End Try
    End Sub



    Private Sub login_btn_Click(sender As Object, e As EventArgs) Handles login_btn.Click
        Try
            MyCon()
            Dim sql As String = "Select URole  FROM UserParishAcc WHERE StrComp([UserName], @uname, 0) = 0 and StrComp([UserPassword], @upass, 0) = 0 "
            Uname = txtUsername.Text
            Upass = txtUPass.Text

            If Uname = "" OrElse Uname = "Enter username" Then
                MsgBox("Please enter your username.", MsgBoxStyle.Exclamation)
                txtUsername.Focus()
                Return
            End If

            If Upass = "" OrElse Upass = "Enter password" Then
                MsgBox("Please enter your password.", MsgBoxStyle.Exclamation)
                txtUPass.Focus()
                Return
            End If


            Using dbcom As New OleDbCommand(sql, dbcon)

                dbcom.Parameters.AddWithValue("@uname", txtUsername.Text.Trim())
                dbcom.Parameters.AddWithValue("@upass", txtUPass.Text.Trim())

                Dim role As Object = dbcom.ExecuteScalar()

                If role Is Nothing Then

                    Dim checkUserSql As String = "SELECT COUNT(*) FROM UserParishAcc WHERE StrComp([UserName], @uname, 0) = 0"

                    Using checker As New OleDbCommand(checkUserSql, dbcon)
                        checker.Parameters.AddWithValue("@uname", Uname)
                        Dim userExists As Integer = Convert.ToInt32(checker.ExecuteScalar())

                        If userExists = 0 Then
                            InsertAuditLog(Uname, "Login failed: Username not found")
                            MsgBox("Incorrect Credentials!", MsgBoxStyle.Exclamation)
                            txtUsername.Clear()
                        Else
                            InsertAuditLog(Uname, "Login failed: Incorrect password")
                            MsgBox("Incorrect Credentials!", MsgBoxStyle.Exclamation)
                            txtUPass.Clear()
                        End If
                    End Using

                Else
                    InsertAuditLog(Uname, "Login success")

                    Select Case role.ToString()
                        Case "Admin", "CoAdmin", "User"
                            MsgBox("Welcome back, " & Uname & "!", MsgBoxStyle.Information)
                            Me.Hide()
                            txtUPass.Clear()
                            txtUsername.Clear()
                            Home.ShowDialog()
                        Case Else
                            MsgBox("Unknown Access Level.", MsgBoxStyle.Critical)
                    End Select
                End If
            End Using

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If dbcon IsNot Nothing AndAlso dbcon.State = ConnectionState.Open Then dbcon.Close()
        End Try


    End Sub


 
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

