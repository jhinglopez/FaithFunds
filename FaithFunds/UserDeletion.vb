Imports System.Data.OleDb
Public Class UserDeletion
    Dim dbcom As OleDbCommand
    Dim dbcon As OleDbConnection
    Dim dbrd As OleDbDataReader
    Dim dbda As OleDbDataAdapter

    Private Sub MyCon()
        dbcon = New OleDbConnection("provider=microsoft.jet.oledb.4.0;data source=" & Application.StartupPath & "\FaithFunds.mdb")
        dbcon.Open()
    End Sub


    Private Sub Search_Btn_Click(sender As Object, e As EventArgs) Handles Search_Btn.Click


        Try
            MyCon()
            Dim SqlSearch_btn As String = "SELECT * from UserParishAcc Where strComp([UserName], @uname,0) =0"
            dbcom = New OleDbCommand(SqlSearch_btn, dbcon)
            dbcom.Parameters.AddWithValue("@uname", Textbox_Username.Text)

            dbrd = dbcom.ExecuteReader()

            If dbrd.Read() Then
                MsgBox("The user '" & dbrd("UserName") & "' does exists.", MsgBoxStyle.Information)
            Else
                MsgBox("User '" & Textbox_Username.Text & "' does not exists!", MsgBoxStyle.Exclamation)
                Textbox_Username.Clear()
            End If

        Catch ex As Exception
            MsgBox("Error during search: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If dbcon IsNot Nothing AndAlso dbcon.State = ConnectionState.Open Then
                dbcon.Close()
            End If

        End Try
    End Sub

    Private Sub Delete_Btn_Click(sender As Object, e As EventArgs) Handles Delete_Btn.Click

        Try
            MyCon()
            Dim SqlSearch As New OleDbCommand("SELECT COUNT (*) from UserParishAcc Where strComp([UserName]= @uname,0)=0", dbcon)
            SqlSearch.Parameters.AddWithValue("@uname", Textbox_Username.Text)

            Dim exists As Integer = Convert.ToInt32(SqlSearch.ExecuteScalar())


            If exists = 0 Then
                MsgBox("No account found for '" & Textbox_Username.Text & "'.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If


            Dim confirm = MsgBox("Are you sure you want to permanently delete the account of '" & Textbox_Username.Text & "'?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "Confirm Deletion")

            If confirm = MsgBoxResult.Yes Then
                Dim SqlDelete As String = "DELETE from UserParishAcc Where StrComp([UserName], @username, 0) = 0"
                dbcom = New OleDbCommand(SqlDelete, dbcon)
                dbcom.Parameters.AddWithValue("@username", Textbox_Username.Text)
                dbcom.ExecuteNonQuery()

                MsgBox("The record of the" & Textbox_Username.Text & " is successfuly deleted.", MsgBoxStyle.Information)
                Textbox_Username.Clear()
            Else
                MsgBox("Deletion cancelled.", MsgBoxStyle.Information)
            End If

        Catch ex As Exception
            MsgBox("Error during deletion: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If dbcon IsNot Nothing AndAlso dbcon.State = ConnectionState.Open Then
                dbcon.Close()
            End If

        End Try

        

    End Sub
    Private Sub Close_btn_Click(sender As Object, e As EventArgs) Handles Close_btn.Click
        Me.Close()
    End Sub

    Private Sub UserDeletion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Textbox_Username_TextChanged(sender As Object, e As EventArgs) Handles Textbox_Username.TextChanged

    End Sub
End Class