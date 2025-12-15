Imports System.Data.OleDb
Imports System.Data

Public Class Data_Entry
    Dim dbcom As OleDbCommand
    Dim dbcon As OleDbConnection
    Dim dbrd As OleDbDataReader
    Dim dbda As OleDbDataAdapter
    Dim SelectedRecordID As String = ""
    Dim ChapelAbrevation As String = ""
    Dim Transaction As String = ""
    Dim EntryType As String = ""
    Dim ReqStatus As String = ""
    Dim editMode As String = "0"
    Dim deletionMode As String = "0"



    Private Sub MyCon()
        dbcon = New OleDbConnection("provider = microsoft.jet.oledb.4.0; data source = " & Application.StartupPath & "\FaithFunds.mdb")
        dbcon.Open()

    End Sub


    Private Sub btnSave_btn_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try

            If IsFieldsNotEmpty() = False Then
                MsgBox("Save failed. Please fill out the required fields.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            MyCon()
            Dim chapID As String = cbxChapType.Text

            Dim SqlInsert As String = "Insert into Transaction_Table (Trans_Type,Chapel_ID,Trans_Date,Trans_Time,Persons_Name,Ref_Title,Amount,Entry,Receipt_Num) values('" & Transaction & "','" & ChapelAbrevation & "','" & txtTranDate.Text & "','" & txtTranTime.Text & " ','" & txtPersonName.Text & "','" & txtRefTitle.Text & "','" & txtAmount.Text & "','" & EntryType & "','" & txtRecNo.Text & "')"
            Dim SqlReqInsert As String = "Insert into Request_Table (Trans_Type,Chapel_ID,Request_Date,Persons_Name,Ref_Title,Amount,Entry,Request_Status,Request_Time) values('" & Transaction & "','" & ChapelAbrevation & "','" & txtTranDate.Text & "','" & txtPersonName.Text & "','" & txtRefTitle.Text & "','" & txtAmount.Text & "','" & EntryType & "','" & ReqStatus & "','" & txtTranTime.Text & "')"

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to submit?", "Confirm Process", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                If cbxTransType.Text = "Mass Collection" Then

                    dbcom = New OleDbCommand(SqlInsert, dbcon)
                    dbcom.ExecuteNonQuery()
                    MsgBox("Transaction Record is succesfully added.", MsgBoxStyle.Information)

                ElseIf cbxTransType.Text = "Second Collection" Then

                    dbcom = New OleDbCommand(SqlInsert, dbcon)
                    dbcom.ExecuteNonQuery()
                    MsgBox("Transaction Record is succesfully added.", MsgBoxStyle.Information)

                ElseIf cbxTransType.Text = "Sponsorship" Then

                    dbcom = New OleDbCommand(SqlInsert, dbcon)
                    dbcom.ExecuteNonQuery()
                    MsgBox("Transaction Record is succesfully added.", MsgBoxStyle.Information)

                ElseIf cbxTransType.Text = "Special Intentions" Then

                    dbcom = New OleDbCommand(SqlInsert, dbcon)
                    dbcom.ExecuteNonQuery()
                    MsgBox("Transaction Record is succesfully added.", MsgBoxStyle.Information)

                ElseIf cbxTransType.Text = "Donation" Then

                    dbcom = New OleDbCommand(SqlInsert, dbcon)
                    dbcom.ExecuteNonQuery()
                    MsgBox("Transaction Record is succesfully added.", MsgBoxStyle.Information)

                ElseIf cbxTransType.Text = "Venture Revenue" Then

                    dbcom = New OleDbCommand(SqlInsert, dbcon)
                    dbcom.ExecuteNonQuery()
                    MsgBox("Transaction Record is succesfully added.", MsgBoxStyle.Information)

                ElseIf cbxTransType.Text = "Utility Bill" Then

                    dbcom = New OleDbCommand(SqlReqInsert, dbcon)
                    dbcom.ExecuteNonQuery()
                    MsgBox("Transaction Record is succesfully added.", MsgBoxStyle.Information)


                ElseIf cbxTransType.Text = "Stipend" Then

                    dbcom = New OleDbCommand(SqlReqInsert, dbcon)
                    dbcom.ExecuteNonQuery()
                    MsgBox("Transaction Record is succesfully added.", MsgBoxStyle.Information)


                ElseIf cbxTransType.Text = "Service" Then


                    dbcom = New OleDbCommand(SqlReqInsert, dbcon)
                    dbcom.ExecuteNonQuery()
                    MsgBox("Transaction Record is succesfully added.", MsgBoxStyle.Information)


                ElseIf cbxTransType.Text = "Supplies" Then

                    dbcom = New OleDbCommand(SqlReqInsert, dbcon)
                    dbcom.ExecuteNonQuery()
                    dbcon.Close()
                    MsgBox("Transaction Record is succesfully added.", MsgBoxStyle.Information)


                ElseIf cbxTransType.Text = "Assistance Funds" Then

                    dbcom = New OleDbCommand(SqlReqInsert, dbcon)
                    dbcom.ExecuteNonQuery()
                    dbcon.Close()
                    MsgBox("Transaction Record is succesfully added.", MsgBoxStyle.Information)


                ElseIf cbxTransType.Text = "Parish Share" Then

                    dbcom = New OleDbCommand(SqlReqInsert, dbcon)
                    dbcom.ExecuteNonQuery()
                    dbcon.Close()

                    MsgBox("Transaction Record is succesfully added.", MsgBoxStyle.Information)


                ElseIf cbxTransType.Text = "Venture Allocation" Then


                    dbcom = New OleDbCommand(SqlReqInsert, dbcon)
                    dbcom.ExecuteNonQuery()
                    dbcon.Close()
                    MsgBox("Transaction Record is succesfully added.", MsgBoxStyle.Information)

                End If
                txtAmount.Clear()
                txtRecNo.Clear()
                txtRefTitle.Clear()
                txtPersonName.Clear()
                txtTranDate.Clear()
                txtTranTime.Clear()
                cbxChapType.SelectedIndex = -1
                cbxTransType.SelectedIndex = -1

                RecentRec()


            Else
                MsgBox("Transaction Cancel", MsgBoxStyle.Information)

            End If
        Catch ex As Exception
            MsgBox("Error during Proccess: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If dbcon IsNot Nothing AndAlso dbcon.State = ConnectionState.Open Then
                dbcon.Close()
            End If

        End Try
    End Sub

    'Filter ComboBox'
    Private Sub cbxChapType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxChapType.SelectedIndexChanged

        If cbxChapType.Text = "Inmaculata" Then
            ChapelAbrevation = "IC"

        ElseIf cbxChapType.Text = "Sagrada Familia" Then
            ChapelAbrevation = "SF"

        Else
            ChapelAbrevation = "SC"

        End If
    End Sub

    Private Sub cbxTransType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxTransType.SelectedIndexChanged
        If cbxTransType.Text = "Mass Collection" Then
            Transaction = "MC"
            EntryType = "IN"
            txtRecNo.Enabled = False
            txtRecNo.BackColor = Color.LightGray
            lblRecNo.ForeColor = Color.LightGray
        ElseIf cbxTransType.Text = "Second Collection" Then
            Transaction = "SC"
            EntryType = "IN"
            txtRecNo.Enabled = False
            txtRecNo.BackColor = Color.LightGray
            lblRecNo.ForeColor = Color.LightGray
        ElseIf cbxTransType.Text = "Sponsorship" Then
            Transaction = "SP"
            EntryType = "IN"
            txtRecNo.Enabled = True
            txtRecNo.BackColor = Color.White
            lblRecNo.ForeColor = Color.White
        ElseIf cbxTransType.Text = "Special Intentions" Then
            Transaction = "SI"
            EntryType = "IN"
            txtRecNo.Enabled = True
            txtRecNo.BackColor = Color.White
            lblRecNo.ForeColor = Color.White
        ElseIf cbxTransType.Text = "Donation" Then
            Transaction = "DN"
            EntryType = "IN"
            txtRecNo.Enabled = True
            txtRecNo.BackColor = Color.White
            lblRecNo.ForeColor = Color.White
        ElseIf cbxTransType.Text = "Venture Revenue" Then
            Transaction = "VR"
            EntryType = "IN"
            txtRecNo.Enabled = True
            txtRecNo.BackColor = Color.White
            lblRecNo.ForeColor = Color.White
        ElseIf cbxTransType.Text = "Utility Bill" Then
            Transaction = "UB"
            EntryType = "OUT"
            ReqStatus = "Pending"
            txtRecNo.Enabled = False
            txtRecNo.BackColor = Color.LightGray
            lblRecNo.ForeColor = Color.LightGray
        ElseIf cbxTransType.Text = "Supplies" Then
            Transaction = "SU"
            EntryType = "OUT"
            ReqStatus = "Pending"
            txtRecNo.Enabled = False
            txtRecNo.BackColor = Color.LightGray
            lblRecNo.ForeColor = Color.LightGray
        ElseIf cbxTransType.Text = "Service" Then
            Transaction = "SE"
            EntryType = "OUT"
            ReqStatus = "Pending"
            txtRecNo.Enabled = False
            txtRecNo.BackColor = Color.LightGray
            lblRecNo.ForeColor = Color.LightGray
        ElseIf cbxTransType.Text = "Stipend" Then
            Transaction = "ST"
            EntryType = "OUT"
            ReqStatus = "Pending"
            txtRecNo.Enabled = False
            txtRecNo.BackColor = Color.LightGray
            lblRecNo.ForeColor = Color.LightGray
        ElseIf cbxTransType.Text = "Assistance Funds" Then
            Transaction = "AF"
            EntryType = "FOR"
            ReqStatus = "Pending"
            txtRecNo.Enabled = False
            txtRecNo.BackColor = Color.LightGray
            lblRecNo.ForeColor = Color.LightGray
        ElseIf cbxTransType.Text = "Venture Allocation" Then
            Transaction = "VA"
            EntryType = "FOR"
            ReqStatus = "Pending"
            txtRecNo.Enabled = False
            txtRecNo.BackColor = Color.LightGray
            lblRecNo.ForeColor = Color.LightGray
        ElseIf cbxTransType.Text = "Parish Share" Then
            Transaction = "PS"
            EntryType = "FOR"
            ReqStatus = "Pending"
            txtRecNo.Enabled = False
            txtRecNo.BackColor = Color.LightGray
            lblRecNo.ForeColor = Color.LightGray
        End If
    End Sub


    Private Sub Close_btn_Click(sender As Object, e As EventArgs) Handles Close_btn.Click
        Me.Close()
    End Sub

    Private Sub Data_Entry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RecentRec()
        btnSave.Visible = True
        btnEdit.Visible = True
        btnDelete.Visible = True
        btnUpdate.Visible = False
        btnExitEditMode.Visible = False
        btnExitDeletionMode.Visible = False
    End Sub

    Private Sub RecentRec()
        MyCon()
        Dim sqlShow As String = "SELECT top 10 Trans_ID AS [ID], Chapel_ID AS [Chapel], Trans_type AS [Transaction Type], Trans_Date AS [Transaction Date], Trans_Time AS [Time], Persons_Name AS [Name], Ref_Title AS [Reference], Amount, Receipt_Num AS [Receipt No] FROM Transaction_Table WHERE Trans_Date = @tdate  Order by Trans_ID desc"
        Dim cmdShow As New OleDbCommand(sqlShow, dbcon)
        cmdShow.Parameters.AddWithValue("@tdate", Date.Now.ToString("MM/dd/yyyy"))
        Dim dbdaShow As New OleDbDataAdapter(cmdShow)
        Dim dtShow As New DataTable
        dbdaShow.Fill(dtShow)
        gvEntryData.DataSource = dtShow
        gvEntryData.Select()
    End Sub


    Private Sub LoadRecordToFields(transID As String)
        Try
            MyCon()

            Dim sqlShow As String = "SELECT * FROM Transaction_Table WHERE Trans_ID = ?"
            Dim cmdShow As New OleDbCommand(sqlShow, dbcon)
            cmdShow.Parameters.AddWithValue("@p1", transID)

            Dim da As New OleDbDataAdapter(cmdShow)
            Dim dt As New DataTable
            da.Fill(dt)

            cbxChapType.Text = dt.Rows(0)("Chapel_ID").ToString()
            cbxTransType.Text = dt.Rows(0)("Trans_Type").ToString()
            txtTranDate.Text = dt.Rows(0)("Trans_Date").ToString()
            txtTranTime.Text = dt.Rows(0)("Trans_Time").ToString()
            txtPersonName.Text = dt.Rows(0)("Persons_Name").ToString()
            txtRefTitle.Text = dt.Rows(0)("Ref_Title").ToString()
            txtAmount.Text = Convert.ToDecimal(dt.Rows(0)("Amount")).ToString("N")
            txtRecNo.Text = dt.Rows(0)("Receipt_Num").ToString()

        Catch ex As Exception
            MsgBox("Error loading record: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If dbcon IsNot Nothing AndAlso dbcon.State = ConnectionState.Open Then dbcon.Close()
        End Try
    End Sub

    Private Sub ClearFields()
        cbxChapType.Text = ""
        cbxTransType.Text = ""
        txtTranDate.Text = ""
        txtTranTime.Text = ""
        txtPersonName.Text = ""
        txtRefTitle.Text = ""
        txtAmount.Text = ""
        txtRecNo.Text = ""
    End Sub


    Private Sub ExitEditMode()
        editMode = "0"
        btnExitEditMode.Visible = False
        btnEdit.Visible = True

        btnSave.Visible = True
        btnUpdate.Visible = False
        btnDelete.Enabled = True
        btnDelete.BackColor = Color.FromArgb(58, 73, 32)
        btnDelete.ForeColor = Color.FromArgb(255, 209, 0)

        ClearFields()
    End Sub

    Private Sub btnExitEditMode_Click(sender As Object, e As EventArgs) Handles btnExitEditMode.Click
        Dim result = MsgBox("Do you want to exit edit mode?", MsgBoxStyle.YesNo + MsgBoxStyle.Question)

        If result = MsgBoxResult.Yes Then
            ExitEditMode()
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            '' validate if there's no record in the gridview
            If gvEntryData.SelectedRows(0).Cells("ID").Value Is Nothing
                MsgBox("Edit failed. There's no record to edit.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If gvEntryData.SelectedRows.Count = 0 Then
                MsgBox("Please select a record first.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            editMode = "1"

            btnDelete.Enabled = False
            btnDelete.BackColor = Color.LightGray


            btnEdit.Visible = False
            btnExitEditMode.Visible = True
            btnDeleteRec.Visible = False
            btnSave.Visible = False
            btnUpdate.Visible = True

            SelectedRecordID = gvEntryData.SelectedRows(0).Cells("ID").Value.ToString()

            LoadRecordToFields(SelectedRecordID)


        Catch ex As Exception
            MsgBox("Error during Process: " & ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Try
            MyCon()
            Dim result = MsgBox("Do you want to UPDATE the record?", MsgBoxStyle.YesNo + MsgBoxStyle.Question)

            If result = MsgBoxResult.Yes Then
                Dim sqlUpdate As String = "UPDATE Transaction_Table SET Chapel_ID=@chap,Trans_Type=@type,Trans_Date=@date,Trans_Time=@time,Persons_Name=@name,Ref_Title=@ref,Amount=@amt,Receipt_Num=@rec WHERE Trans_ID=@id"

                Dim UpdatedData As New OleDbCommand(sqlUpdate, dbcon)
                UpdatedData.Parameters.AddWithValue("@chap", cbxChapType.Text)
                UpdatedData.Parameters.AddWithValue("@type", cbxTransType.Text)
                UpdatedData.Parameters.AddWithValue("@date", txtTranDate.Text)
                UpdatedData.Parameters.AddWithValue("@time", txtTranTime.Text)
                UpdatedData.Parameters.AddWithValue("@name", txtPersonName.Text)
                UpdatedData.Parameters.AddWithValue("@ref", txtRefTitle.Text)
                UpdatedData.Parameters.AddWithValue("@amt", txtAmount.Text)
                UpdatedData.Parameters.AddWithValue("@rec", txtRecNo.Text)
                UpdatedData.Parameters.AddWithValue("@id", SelectedRecordID)
                UpdatedData.ExecuteNonQuery()

                MsgBox("Record updated successfully!", MsgBoxStyle.Information)
            End If
            ExitEditMode()
            RecentRec()
        Catch ex As Exception
            MsgBox("Error during update: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub




    'DELETION MODE
    Private Sub AllRec()
        MyCon()
        Dim sqlShow As String = "SELECT Trans_ID AS [ID],Chapel_ID AS [Chapel],Trans_Type AS [Transaction Type],Trans_Date AS [Transaction Date],Trans_Time AS [Time],Persons_Name AS [Name],Ref_Title AS [Reference],Amount,Receipt_Num AS [Receipt No] FROM Transaction_Table ORDER BY Trans_ID DESC"

        Dim cmdShow As New OleDbCommand(sqlShow, dbcon)
        Dim dbdaShow As New OleDbDataAdapter(cmdShow)
        Dim dtShow As New DataTable
        dbdaShow.Fill(dtShow)
        gvEntryData.DataSource = dtShow
    End Sub

   

    Private Sub exitDeleteMode()
        deletionMode = "0"
        btnExitDeletionMode.Visible = False
        btnDelete.Visible = True

        btnSave.Visible = True
        btnDelete.Visible = True

        btnEdit.Enabled = True
        btnEdit.BackColor = Color.FromArgb(58, 73, 32)
        btnEdit.ForeColor = Color.FromArgb(255, 209, 0)
        
        ClearFields()
        RecentRec()


    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            deletionMode = "1"

            If gvEntryData.SelectedRows.Count = 0 Then
                MsgBox("Please select a record first.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            btnEdit.Enabled = False
            btnEdit.BackColor = Color.LightGray


            btnDelete.Visible = False
            btnExitDeletionMode.Visible = True
            btnDeleteRec.Visible = True
            btnSave.Visible = False
            btnUpdate.Visible = False

            MyCon()
            AllRec()

            SelectedRecordID = gvEntryData.SelectedRows(0).Cells("ID").Value.ToString()

            LoadRecordToFields(SelectedRecordID)


        Catch ex As Exception
            MsgBox("Error during Process: " & ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub


    Private Sub btnExitDeletionMode_Click(sender As Object, e As EventArgs) Handles btnExitDeletionMode.Click
        Dim result = MsgBox("Do you want to exit DELETE mode?", MsgBoxStyle.YesNo + MsgBoxStyle.Question)

        If result = MsgBoxResult.Yes Then
            exitDeleteMode()
        End If
    End Sub

    Private Sub btnDeleteRec_Click(sender As Object, e As EventArgs) Handles btnDeleteRec.Click
        Try
            MyCon()
            Dim result = MsgBox("Do you want to DELETE the transaction record?", MsgBoxStyle.YesNo + MsgBoxStyle.Question)

            If result = MsgBoxResult.Yes Then
                Dim sqlDelete As String = "DELETE FROM Transaction_Table WHERE Trans_ID=@id"

                Dim cmdDelete As New OleDbCommand(sqlDelete, dbcon)
                cmdDelete.Parameters.AddWithValue("@id", SelectedRecordID)
                cmdDelete.ExecuteNonQuery()

                MsgBox("Record deleted successfully!", MsgBoxStyle.Information)
            End If
            exitDeleteMode()


        Catch ex As Exception
            MsgBox("Error during delete: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub gvEntryData_SelectionChanged(sender As Object, e As EventArgs) Handles gvEntryData.SelectionChanged

        If deletionMode = "1" Then
            If gvEntryData.SelectedRows.Count > 0 Then
                SelectedRecordID = gvEntryData.SelectedRows(0).Cells("ID").Value.ToString()
                LoadRecordToFields(SelectedRecordID)
            End If
        End If

        If editMode = "1" Then
            If gvEntryData.SelectedRows.Count > 0 Then
                SelectedRecordID = gvEntryData.SelectedRows(0).Cells("ID").Value.ToString()
                LoadRecordToFields(SelectedRecordID)
            End If
        End If
    End Sub

    Private Function IsFieldsNotEmpty() As Boolean

        If Transaction.Trim() = "" Or _
                ChapelAbrevation.Trim() = "" Or _
                txtTranDate.Text.Trim() = "" Or _
                txtTranTime.Text.Trim() = "" Or _
                txtPersonName.Text.Trim() = "" Or _
                txtAmount.Text.Trim() = "" Or _
                EntryType.Trim() = "" Then 
            Return False
        Else
            Return True
        End If


    End Function


End Class



