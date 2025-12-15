Imports System.Data.OleDb
Public Class UserEdit
    Dim dbcom As OleDbCommand
    Dim dbcon As OleDbConnection
    Dim dbrd As OleDbDataReader
    Dim dbda As OleDbDataAdapter

    Private Sub MyCon()
        dbcon = New OleDbConnection("provider=microsoft.jet.oledb.4.0;data source=" & Application.StartupPath & "\faithfunds.mdb")
        dbcon.Open()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            MyCon()
            Dim SqlSearch_btn As String = "SELECT * from UserParishAcc Where strComp([UserName], @uname,0) =0"
            dbcom = New OleDbCommand(SqlSearch_btn, dbcon)
            dbcom.Parameters.AddWithValue("@uname", txtUsername.Text)

            dbrd = dbcom.ExecuteReader()

            If dbrd.Read() Then

                txtFullname.Text = dbrd("FullName")
                txtAddress.Text = dbrd("UADD")
                txtContact.Text = dbrd("Contc")
                txtRole.Text = dbrd("URole")
                txtOldPass.Text = dbrd("UserPassword")
            Else
                MsgBox("User '" & txtUsername.Text & "' does not exits!", MsgBoxStyle.Exclamation)
                txtUsername.Clear()
            End If
        Catch ex As Exception
            MsgBox("Error during search: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If dbcon IsNot Nothing AndAlso dbcon.State = ConnectionState.Open Then
                dbcon.Close()
            End If

        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            If IsFieldsNotEmpty() = False Then
                MsgBox("Save failed. Please fill out the required fields.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            MyCon()
            Dim SqlUpdateWithPassChange As String = "UPDATE UserParishAcc SET [FullName]=@fname, [UADD]=@uadd, [Contc]=@contc,[URole]=@urole, [UserPassword]=@upass WHERE [UserName]=@uname"
            Dim SqlUpdateNoPassChange As String = "UPDATE UserParishAcc SET [FullName]=@fname,[UserPassword]=[UserPassword],[UADD]=@uadd, [Contc]=@contc,[URole]=@urole WHERE [UserName]=@uname"

            Dim finalChange As String

            If txtOldPass.Text <> "" AndAlso txtConfirmPass.Text <> "" Then
                Dim verifyAcc As New OleDbCommand("SELECT COUNT(*) FROM UserParishAcc WHERE [UserName]=@uname AND [UserPassword]=@oldpass", dbcon)
                verifyAcc.Parameters.AddWithValue("@uname", txtUsername.Text)
                verifyAcc.Parameters.AddWithValue("@oldpass", txtOldPass.Text)
                Dim validOldPass As Integer = Convert.ToInt32(verifyAcc.ExecuteScalar())

                If validOldPass = 0 Then
                    MsgBox("Old password is incorrect.", MsgBoxStyle.Critical)
                    Exit Sub
                End If

                If txtConfirmPass.Text.Trim() <> txtNewPass.Text.Trim() Then
                    MsgBox("Password confirmation does not match.", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If

                finalChange = SqlUpdateWithPassChange
            Else
                finalChange = SqlUpdateNoPassChange
            End If


            dbcom = New OleDbCommand(finalChange, dbcon)
            dbcom.Parameters.AddWithValue("@fname", txtFullname.Text)
            dbcom.Parameters.AddWithValue("@uadd", txtAddress.Text)
            dbcom.Parameters.AddWithValue("@contc", txtContact.Text)
            dbcom.Parameters.AddWithValue("@urole", txtRole.Text)

            If finalChange.Contains("@upass") Then
                dbcom.Parameters.AddWithValue("@upass", txtConfirmPass.Text)
            End If

            dbcom.Parameters.AddWithValue("@uname", txtUsername.Text)

            dbcom.ExecuteNonQuery()
            MsgBox("User information successfully updated.", MsgBoxStyle.Information)

            For Each tb As TextBox In {txtOldPass, txtNewPass, txtConfirmPass, txtAddress, txtContact, txtFullname, txtRole}
                tb.Clear()
            Next
            txtUsername.Focus()

        Catch ex As Exception
            MsgBox("Error during update: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If dbcon IsNot Nothing AndAlso dbcon.State = ConnectionState.Open Then
                dbcon.Close()
            End If
        End Try
    End Sub

    Private Sub SeePass_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnShowPass.LinkClicked
        If txtOldPass.UseSystemPasswordChar Then
            txtOldPass.UseSystemPasswordChar = False
            btnShowPass.Text = "Hide"
        Else
            txtOldPass.UseSystemPasswordChar = True
            btnShowPass.Text = "Show"
        End If
    End Sub


    Private Sub Close_btn_Click(sender As Object, e As EventArgs) Handles Close_btn.Click
        Me.Close()
        txtUsername.Clear
    End Sub

 
    Private Function IsFieldsNotEmpty() As Boolean

        If txtUsername.Text.Trim() = "" Or _
            txtRole.Text.Trim() = "" Or _
            txtFullname.Text.Trim() = "" Or _
            txtConfirmPass.Text.Trim() = "" Then
            Return False
        Else
            Return True
        End If

   End Function

End Class