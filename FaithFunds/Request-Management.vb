Imports System.Data.OleDb
Imports System.Data
Public Class Request_Management

    Dim dbcom As OleDbCommand
    Dim dbcon As OleDbConnection
    Dim dbrd As OleDbDataReader
    Dim dbda As OleDbDataAdapter


    Private Sub MyCon()
        dbcon = New OleDbConnection("provider = microsoft.jet.oledb.4.0; data source = " & Application.StartupPath & "\FaithFunds.mdb")
        dbcon.Open()
    End Sub
   
    Private Function GetSelectedRequestID() As String
        If gvRequestData.SelectedRows.Count = 0 Then
            Return ""
        End If

        Return gvRequestData.SelectedRows(0).Cells("ID").Value.ToString()
    End Function

    Private Sub LoadRequestToFields(requestID As String)
        Try
            MyCon()

            Dim sql As String = "SELECT * FROM Request_Table WHERE Request_ID = ?"
            Dim cmd As New OleDbCommand(sql, dbcon)
            cmd.Parameters.AddWithValue("@p1", requestID)

            Dim da As New OleDbDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                txtSearch.Text = dt.Rows(0)("Request_ID").ToString()
            End If

        Catch ex As Exception
            MsgBox("Error loading request: " & ex.Message)
        Finally
            If dbcon.State = ConnectionState.Open Then dbcon.Close()
        End Try
    End Sub

   Private Sub btnApproved_Click(sender As Object, e As EventArgs) Handles btnApproved.Click
        Try
            Dim requestID As String = GetSelectedRequestID()

            If requestID = "" Then
                MsgBox("Please select a request from the table.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            MyCon()

            Dim sqlCheck As New OleDbCommand("SELECT Request_Status FROM Request_Table WHERE Request_ID=@id", dbcon)
            sqlCheck.Parameters.AddWithValue("@id", requestID)

            Dim status As Object = sqlCheck.ExecuteScalar()

            If status Is Nothing Then
                MsgBox("Request not found!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If status.ToString() <> "Pending" Then
                MsgBox("Only PENDING requests can be approved.", MsgBoxStyle.Information)
                Exit Sub
            End If


            If MsgBox("Approve request '" & requestID & "'?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) <> MsgBoxResult.Yes Then
                Exit Sub
            End If


            Dim sqlUpdate As String = "UPDATE Request_Table SET Request_Status='Approved' WHERE Request_ID=@id"

            Dim cmdUpdate As New OleDbCommand(sqlUpdate, dbcon)
            cmdUpdate.Parameters.AddWithValue("@id", requestID)
            cmdUpdate.ExecuteNonQuery()


            Dim sqlInsert As String = "INSERT INTO Transaction_Table (Trans_Type, Chapel_ID, Trans_Date, Persons_Name, Ref_Title, Amount, Entry, Request_Status)  SELECT Trans_Type, Chapel_ID, Request_Date, Persons_Name, Ref_Title, Amount, Entry, Request_Status FROM Request_Table WHERE Request_ID=@id"

            Dim cmdInsert As New OleDbCommand(sqlInsert, dbcon)
            cmdInsert.Parameters.AddWithValue("@id", requestID)
            cmdInsert.ExecuteNonQuery()

            MsgBox("Request has been approved", MsgBoxStyle.Information)

            AllRec()

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If dbcon.State = ConnectionState.Open Then dbcon.Close()
        End Try
    End Sub

    Private Sub btnDenied_Click(sender As Object, e As EventArgs) Handles btnDenied.Click
        Try
            Dim requestID As String = GetSelectedRequestID()

            If requestID = "" Then
                MsgBox("Please select a request from the table.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            MyCon()

            Dim sqlCheck As New OleDbCommand("SELECT COUNT(*) FROM Request_Table WHERE StrComp([Request_ID], @id, 0) = 0", dbcon)
            sqlCheck.Parameters.AddWithValue("@id", requestID)

            Dim exists As Integer = Convert.ToInt32(sqlCheck.ExecuteScalar())

            If exists = 0 Then
                MsgBox("No request found for '" & requestID & "'.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If MsgBox("Do you want to deny '" & requestID & "'?",
                      MsgBoxStyle.YesNo + MsgBoxStyle.Question) <> MsgBoxResult.Yes Then

                MsgBox("Disapproval cancelled.", MsgBoxStyle.Information)
                Exit Sub
            End If


            Dim SqlUpdate As String = "UPDATE Request_Table SET Request_Status='Denied' WHERE Request_ID=@id"

            Dim cmdUpdate As New OleDbCommand(SqlUpdate, dbcon)
            cmdUpdate.Parameters.AddWithValue("@id", requestID)
            cmdUpdate.ExecuteNonQuery()


            Dim SqlTrans As String ="INSERT INTO Transaction_Table (Trans_Type, Chapel_ID, Trans_Date, Persons_Name, Ref_Title, Amount, Entry, Request_Status) SELECT Trans_Type, Chapel_ID, Request_Date, Persons_Name, Ref_Title, Amount, Entry, Request_Status FROM Request_Table WHERE StrComp([Request_ID], @id, 0) = 0"

            Dim cmdInsert As New OleDbCommand(SqlTrans, dbcon)
            cmdInsert.Parameters.AddWithValue("@id", requestID)
            cmdInsert.ExecuteNonQuery()

            MsgBox("The request has been denied", MsgBoxStyle.Information)

            AllRec()

        Catch ex As Exception
            MsgBox("Error during process: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If dbcon IsNot Nothing AndAlso dbcon.State = ConnectionState.Open Then dbcon.Close()
        End Try
    End Sub



    'Fillers Database

    Private Sub LoadFilteredData(Optional filter As String = "")
        Try
            MyCon()

            Dim sql As String = "SELECT Request_Status AS [Status],Chapel_ID AS [Chapel],Trans_Type AS [Transaction Type], Entry AS [Entry Type],Persons_Name AS [Name],Request_Date AS [Date],Ref_Title AS [Reference Title],Request_ID AS [ID], Request_Time AS [Request Time] FROM Request_Table"

            If filter <> "" Then
                sql &= " WHERE Request_Status LIKE ? OR Chapel_ID LIKE ? OR Trans_Type LIKE ? OR Entry LIKE ?"
                ' OR Persons_Name ? OR Request_Date LIKE ? OR Ref_Title LIKE ? OR Request_ID LIKE ? OR Request_Time LIKE ?"
            End If

            Dim cmd As New OleDbCommand(sql, dbcon)

            If filter <> "" Then
                Dim FilSearch = "%" & filter & "%"
                cmd.Parameters.AddWithValue("?", FilSearch)
                cmd.Parameters.AddWithValue("?", FilSearch)
                cmd.Parameters.AddWithValue("?", FilSearch)
                cmd.Parameters.AddWithValue("?", FilSearch)
                cmd.Parameters.AddWithValue("?", FilSearch)
                cmd.Parameters.AddWithValue("?", FilSearch)
                cmd.Parameters.AddWithValue("?", FilSearch)
                cmd.Parameters.AddWithValue("?", FilSearch)
                cmd.Parameters.AddWithValue("?", FilSearch)
            End If

            Dim da As New OleDbDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)

            gvRequestData.DataSource = dt

        Catch ex As Exception
            MsgBox("Error loading data: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If dbcon.State = ConnectionState.Open Then dbcon.Close()
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadFilteredData(txtSearch.Text.Trim())
    End Sub

    'Filter Table
    Private Sub AllRec()
        MyCon()
        Dim sqlShow As String = "SELECT Request_ID AS [ID], Request_Status AS [Status],Chapel_ID AS [Chapel],Trans_Type AS [Transaction Type], Entry AS [Entry Type],Persons_Name AS [Name],Request_Date AS [Date],Ref_Title AS [Reference Title], Request_Time AS [Request Time] FROM Request_Table WHERE Request_Status = 'Pending' ORDER BY ID DESC"
        Dim cmdShow As New OleDbCommand(sqlShow, dbcon)
        cmdShow.Parameters.AddWithValue("@tdate", Date.Now.ToString("MM/dd/yyyy"))
        Dim dbdaShow As New OleDbDataAdapter(cmdShow)
        Dim dtShow As New DataTable
        dbdaShow.Fill(dtShow)
        gvRequestData.DataSource = dtShow
    End Sub
    Private Sub Close_btn_Click(sender As Object, e As EventArgs) Handles Close_btn.Click
        Me.Close()

    End Sub

    Private Sub Request_Management_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AllRec()
    End Sub

 
End Class