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
            MyCon()

            Dim Sql As String = "Select Count(*) from UserParishAcc Where [UserName]='" & txtUsername.Text & "' "
            dbcom = New OleDbCommand(Sql, dbcon)

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

   
End Class