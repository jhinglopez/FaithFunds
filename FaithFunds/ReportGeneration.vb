Imports System.Data.OleDb
Imports System.Data
Imports System.Text
Public Class ReportGeneration

    Dim dbcom As OleDbCommand
    Dim dbcon As OleDbConnection
    Dim dbrd As OleDbDataReader
    Dim dbda As OleDbDataAdapter


    Private Sub MyCon()
        dbcon = New OleDbConnection("provider = microsoft.jet.oledb.4.0; data source = " & Application.StartupPath & "\FaithFunds.mdb")
        dbcon.Open()

    End Sub


    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click

        Try
            MyCon()
            Dim chapelText As String = comboboxChapel.Text.Trim
            Dim transText As String = comboxTranstype.Text.Trim
            Dim entryText As String = comboxEntry.Text.Trim

            Dim chapID As String = If(chapelText = "All", "All", chapelText.Substring(0, 2))
            Dim transID As String = If(transText = "All", "All", transText.Substring(0, 2))
            Dim entryID As String = entryText

            Dim transDate1 As String = textboxFrom.Text
            Dim transDate2 As String = textboxDateTo.Text


            Dim sqlgo As String = "Select Trans_ID AS [Transaction ID], Chapel_ID AS [Chapel], Trans_type AS [Transaction Type], Entry, Trans_Date AS [Transaction Date], Trans_Time AS [Time], Persons_Name AS [Name], Ref_Title AS [Reference], Amount, Receipt_Num AS [Receipt No] from Transaction_Table  "
            Dim sqlwhere As String = "Where Trans_Date >='" & transDate1 & "' and Trans_Date <= '" & transDate2 & "' "

            If chapID <> "All" Then
                sqlwhere += " and Chapel_ID ='" & chapID & "' "


            ElseIf transID <> "All" Then
                sqlwhere += " and Trans_Type = '" & transID & "'"

            End If

            If entryID <> "All" Then
                sqlwhere += " and Entry = '" & entryID & "'"
            End If


            dbda = New OleDbDataAdapter(sqlgo & sqlwhere, dbcon)
            Dim dt As New DataTable
            dbda.Fill(dt)
            TotalAmount(dt)
            gvTransData.DataSource = dt


        Catch ex As Exception
            MsgBox("Error during Viewing: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If dbcon IsNot Nothing AndAlso dbcon.State = ConnectionState.Open Then
                dbcon.Close()
            End If

        End Try
    End Sub

    Private Sub TotalAmount(dt As DataTable)
        Dim totalamount As Decimal
        For Each row As DataRow In dt.AsEnumerable()

            totalamount += row("Amount")

        Next
        lblTotal.Text = "Total Amount: " & totalamount.ToString

    End Sub


    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Try
            If gvTransData.Rows.Count = 0 Then
                MsgBox("No data to print!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            Dim save As New SaveFileDialog()
            save.Filter = "HTML File|*.html"
            save.FileName = "Financial_Report_" & Date.Now.ToString("yyyyMMdd")

            If save.ShowDialog() <> DialogResult.OK Then Exit Sub

            Dim html As New System.Text.StringBuilder()

            'html structure
            html.Append("<html><head>")

            'css style script
            html.Append("<style>")
            html.Append("body{font-family:Arial; margin:20px;}")
            html.Append("table{width:100%; border-collapse:collapse; margin-top:20px;}")
            html.Append("th,td{border:1px solid black; padding:8px; font-size:12px;}")
            html.Append("th{background:#f0f0f0;}")
            html.Append(".title{text-align:center; font-size:22px; font-weight:bold; margin-top:10px;}")
            html.Append(".total{text-align:right; font-size:18px; font-weight:bold; margin-top:20px;}")
            html.Append("@media print { button { display: none; }}")
            html.Append("</style>")

            'javascript script
            html.Append("<script>")
            html.Append("function downloadPDF() { window.print(); }")
            html.Append("</script>")

            html.Append("</head><body>")

            'Html buttons with css for styling script and javascript button functionality
            html.Append("<div>")
            html.Append("<button onclick='window.print()' style='padding:10px 20px; font-size:14px; margin-right:10px;'>Print Report</button>")
            html.Append("<button onclick='downloadPDF()' style='padding:10px 20px; font-size:14px;'>Download PDF</button>")
            html.Append("</div><br>")

            'note: title page of printed document

            html.Append("<div class='title'>Buen Pastor Parish Chapel Fininancial Report</div>")
            html.Append("<p>Documented on: " & Date.Now.ToString("MMMM dd, yyyy hh:mm tt") & "</p>")

            'note: starting of the table
            html.Append("<table><tr>")

            'note: table headers or the columns also prints exact number of rows in gvTransdata
            For Each col As DataGridViewColumn In gvTransData.Columns
                html.Append("<th>" & col.HeaderText & "</th>")
            Next
            html.Append("</tr>")

            ' note: print the exact number of rows in gvTransdata
            For Each row As DataGridViewRow In gvTransData.Rows
                If Not row.IsNewRow Then
                    html.Append("<tr>")
                    For Each cell As DataGridViewCell In row.Cells
                        html.Append("<td>" & If(cell.Value, "").ToString() & "</td>")
                    Next
                    html.Append("</tr>")
                End If
            Next

            html.Append("</table>")

            'print the total amount of the table displayed
            html.Append("<div class='total'>" & lblTotal.Text & "</div>")

            'END BODY + HTML
            html.Append("</body></html>")

            'converting htmlfile into pdf
            System.IO.File.WriteAllText(save.FileName, html.ToString())

            ' Open in browser
            Process.Start(save.FileName)

            MsgBox("Financial report generated!", MsgBoxStyle.Information)

        Catch ex As Exception
            MsgBox("Error generating HTML: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub


    Private Sub Close_btn_Click(sender As Object, e As EventArgs) Handles Close_btn.Click
        Me.Close()
    End Sub

  
    Private Sub ReportGeneration_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class