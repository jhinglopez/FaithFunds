Imports System.Data.OleDb
Public Class Register
    Dim dbcom As OleDbCommand
    Dim dbcon As OleDbConnection
    Dim dbrd As OleDbDataReader
    Dim dbda As OleDbDataAdapter

    Private Sub MyCon()
        dbcon = New OleDbConnection("provider=microsoft.jet.oledb.4.0;data source=" & Application.StartupPath & "\faithfunds.mdb")
        dbcon.Open()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If IsFieldsNotEmpty() = False Then
                MsgBox("Save failed. Please fill out the required fields.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            MyCon()

            ' Check for possible duplicate username
            Dim Sql As String = "SELECT UID FROM UserParishAcc WHERE (STRCONV([UserName],2)='" & txtUsername.Text.ToLower() & "') "
            dbcom = New OleDbCommand(Sql, dbcon)
            Dim da As New OleDbDataAdapter(dbcom)
            Dim dt As New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                MsgBox("Save failed. Username already exists.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            ' Insert record
            If txtUPass.Text = txtConfirmPass.Text Then
                Sql = "INSERT into UserParishAcc (UserName,FullName,UADD,Contc,UserPassword,URole) values ('" & txtUsername.Text & "', '" & txtFullname.Text & "', '" & txtAddress.Text & "', '" & txtContact.Text & "', '" & txtConfirmPass.Text & "','" & txtRole.Text & "')"
                dbcom = New OleDbCommand(Sql, dbcon)
                dbcom.ExecuteNonQuery()
                MsgBox("User is succesfully added.", MsgBoxStyle.Information)
                txtUsername.Clear()
                txtFullname.Clear()
                txtConfirmPass.Clear()
                txtUPass.Clear()
                txtAddress.Clear()
                txtContact.Clear()
                txtRole.Clear()
            Else
                MsgBox("incorrect Credentials.", MsgBoxStyle.Information)
                txtConfirmPass.Clear()
            End If
        Catch ex As Exception
            MsgBox("Error in proccess pf adding: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If dbcon IsNot Nothing AndAlso dbcon.State = ConnectionState.Open Then dbcon.Close()
        End Try

    End Sub
    Private Sub Close_btn_Click(sender As Object, e As EventArgs) Handles Close_btn.Click
        Me.Close()
    End Sub

   Private Function IsFieldsNotEmpty() As Boolean

        If txtUsername.Text.Trim() = "" Or _
            txtRole.Text.Trim() = "" Or _
            txtFullname.Text.Trim() = "" Or _
            txtUPass.Text.Trim() = "" Or _
            txtConfirmPass.Text.Trim() = "" Then
            Return False
        Else
            Return True
        End If

   End Function

End Class