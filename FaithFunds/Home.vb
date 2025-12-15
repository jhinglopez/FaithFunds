Imports System.Data.OleDb
Imports System.Security.Cryptography
Imports System.Text

Public Class Home
    Dim dbcom As OleDbCommand
    Dim dbcon As OleDbConnection
    Dim dbrd As OleDbDataReader
    Dim dbda As OleDbDataAdapter

    Private Sub SignOutToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SignOutToolStripMenuItem.Click

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to sign out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Me.Close()
            Login.Show()
        End If

    End Sub

    Private Sub AddUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddUserToolStripMenuItem.Click
        Register.ShowDialog()
    End Sub

    Private Sub EditUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditUserToolStripMenuItem.Click
        UserEdit.ShowDialog()
    End Sub

    Private Sub DeleteUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteUserToolStripMenuItem.Click
        UserDeletion.ShowDialog()
    End Sub

    Private Sub DATAENTRYToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DATAENTRYToolStripMenuItem.Click
        Data_Entry.ShowDialog()
    End Sub

    Private Sub RequestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RequestToolStripMenuItem.Click
        Request_Management.ShowDialog()
    End Sub

    Private Sub REPORTGENERATIONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REPORTGENERATIONToolStripMenuItem.Click
        ReportGeneration.ShowDialog()
    End Sub


    Private Sub MyCon()
        dbcon = New OleDbConnection("provider=microsoft.jet.oledb.4.0;data source=" & Application.StartupPath & "\FaithFunds.mdb")
        dbcon.Open()
    End Sub

    'Responsiveness
    Private originalFormSize As Size
    Private originalControlBounds As New Dictionary(Of Control, Rectangle)

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            MyCon()

            ' Fetch the user's role based on their username
            Dim sql As String = "SELECT URole FROM UserParishAcc WHERE StrComp([UserName], @uname, 0) = 0"
            Using cmd As New OleDbCommand(sql, dbcon)
                cmd.Parameters.AddWithValue("@uname", Uname)
                Dim role As Object = cmd.ExecuteScalar()

                If role IsNot Nothing Then
                    Dim userRole As String = role.ToString().Trim()


                    USERMANAGEMENTToolStripMenuItem.Visible = True
                    REPORTGENERATIONToolStripMenuItem.Visible = True
                    RequestToolStripMenuItem.Visible = True


                    Select Case userRole
                        Case "Admin"

                        Case "CoAdmin"
                            USERMANAGEMENTToolStripMenuItem.Visible = False
                        Case "User"
                            USERMANAGEMENTToolStripMenuItem.Visible = False
                            RequestToolStripMenuItem.Visible = False
                        Case Else
                            MsgBox("Unknown role detected: " & userRole, MsgBoxStyle.Exclamation)
                    End Select

                Else
                    MsgBox("Unable to retrieve user role.", MsgBoxStyle.Critical)
                End If
            End Using

        Catch ex As Exception
            MsgBox("Error checking role: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If dbcon IsNot Nothing AndAlso dbcon.State = ConnectionState.Open Then dbcon.Close()
        End Try

        originalFormSize = Me.Size
        For Each ctrl As Control In Me.Controls
            originalControlBounds(ctrl) = ctrl.Bounds
        Next

    End Sub

    Private Sub Home_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Dim xRatio As Double = Me.Width / originalFormSize.Width
        Dim yRatio As Double = Me.Height / originalFormSize.Height

        If Me.WindowState = FormWindowState.Maximized Then

            PictureBox1.Visible = False
            Label1.Visible = False
            Label2.Visible = False
            Label3.Visible = False

            PictureBox2.Visible = True
            Label4.Visible = True
            Label5.Visible = True
            Label6.Visible = True
        Else
            PictureBox1.Visible = True
            Label1.Visible = True
            Label2.Visible = True
            Label3.Visible = True

            PictureBox2.Visible = False
            Label4.Visible = False
            Label5.Visible = False
            Label6.Visible = False
        End If


        ' Resize & Repostion
        For Each ctrl As Control In Me.Controls
            If originalControlBounds.ContainsKey(ctrl) Then
                Dim origBounds As Rectangle = originalControlBounds(ctrl)

                    ' Normal resizing
                    ctrl.Bounds = New Rectangle(
                        CInt(origBounds.X * xRatio),
                        CInt(origBounds.Y * yRatio),
                        CInt(origBounds.Width * xRatio),
                        CInt(origBounds.Height * yRatio)
                    )
                End If
        Next
    End Sub
  
End Class