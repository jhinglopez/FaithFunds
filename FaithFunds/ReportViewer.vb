Imports System.Text

Public Class ReportViewer

    Private Sub ReportViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim html As StringBuilder = New StringBuilder()


        html.Append("<html>")
        html.Append("<body>")
        html.Append("<div align='center'>")
        html.Append("<table>")

        'Header'
        html.Append("<thead>")
        html.Append("<tr>")
        html.Append("<th style='font-weight:bold; text-align:left; font-family:""Arial"", ""Helvetica"", sans-serif; font-size:13px; padding:3px 6px; white-space:nowrap; border-bottom:2px solid #000;'>Date</th>")
        html.Append("<th style='font-weight:bold; text-align:left; font-family:""Arial"", ""Helvetica"", sans-serif; font-size:13px; padding:3px 6px; white-space:nowrap; border-bottom:2px solid #000;'>Type</th>")
        html.Append("<th style='font-weight:bold; text-align:left; font-family:""Arial"", ""Helvetica"", sans-serif; font-size:13px; padding:3px 6px; white-space:nowrap; border-bottom:2px solid #000;'>Category</th>")
        html.Append("<th style='font-weight:bold; text-align:left; font-family:""Arial"", ""Helvetica"", sans-serif; font-size:13px; padding:3px 6px; white-space:nowrap; border-bottom:2px solid #000;'>Reference</th>")
        html.Append("<th style='font-weight:bold; text-align:left; font-family:""Arial"", ""Helvetica"", sans-serif; font-size:13px; padding:3px 6px; white-space:nowrap; border-bottom:2px solid #000;'>Amount</th>")
        html.Append("</tr>")
        html.Append("</thead>")

        'Detail"
        html.Append("<tbody>")
        '
        html.Append("<tr>")
        html.Append("<td style='text-align:left; font-family:""Arial"", ""Helvetica"", sans-serif; font-size:13px; padding:3px 6px; white-space:nowrap; border-bottom:1px dotted #000;'>11/29/2025</td>")
        html.Append("<td style='text-align:left; font-family:""Arial"", ""Helvetica"", sans-serif; font-size:13px; padding:3px 6px; white-space:nowrap; border-bottom:1px dotted #000;'>In-Flow</td>")
        html.Append("<td style='text-align:left; font-family:""Arial"", ""Helvetica"", sans-serif; font-size:13px; padding:3px 6px; white-space:nowrap; border-bottom:1px dotted #000;'>Mass Offering</td>")
        html.Append("<td style='text-align:left; font-family:""Arial"", ""Helvetica"", sans-serif; font-size:13px; padding:3px 6px; white-space:nowrap; border-bottom:1px dotted #000;'>123abc</td>")
        html.Append("<td style='text-align:right; font-family:""Arial"", ""Helvetica"", sans-serif; font-size:13px; padding:3px 6px; white-space:nowrap; border-bottom:1px dotted #000;'>100.00</td>")
        html.Append("</tr>")
        '
        html.Append("<tr>")
        html.Append("<td style='text-align:left; font-family:""Arial"", ""Helvetica"", sans-serif; font-size:13px; padding:3px 6px; white-space:nowrap; border-bottom:1px dotted #000;'>11/28/2025</td>")
        html.Append("<td style='text-align:left; font-family:""Arial"", ""Helvetica"", sans-serif; font-size:13px; padding:3px 6px; white-space:nowrap; border-bottom:1px dotted #000;'>Out-Flow</td>")
        html.Append("<td style='text-align:left; font-family:""Arial"", ""Helvetica"", sans-serif; font-size:13px; padding:3px 6px; white-space:nowrap; border-bottom:1px dotted #000;'>Electricity</td>")
        html.Append("<td style='text-align:left; font-family:""Arial"", ""Helvetica"", sans-serif; font-size:13px; padding:3px 6px; white-space:nowrap; border-bottom:1px dotted #000;'>423xyz</td>")
        html.Append("<td style='text-align:right; font-family:""Arial"", ""Helvetica"", sans-serif; font-size:13px; padding:3px 6px; white-space:nowrap; border-bottom:1px dotted #000;'>1,250.00</td>")
        html.Append("</tr>")
        '
        html.Append("<tr>")
        html.Append("<td style='text-align:left; font-family:""Arial"", ""Helvetica"", sans-serif; font-size:13px; padding:3px 6px; white-space:nowrap; border-bottom:1px dotted #000;'>11/27/2025</td>")
        html.Append("<td style='text-align:left; font-family:""Arial"", ""Helvetica"", sans-serif; font-size:13px; padding:3px 6px; white-space:nowrap; border-bottom:1px dotted #000;'>In-Flow</td>")
        html.Append("<td style='text-align:left; font-family:""Arial"", ""Helvetica"", sans-serif; font-size:13px; padding:3px 6px; white-space:nowrap; border-bottom:1px dotted #000;'>Donation</td>")
        html.Append("<td style='text-align:left; font-family:""Arial"", ""Helvetica"", sans-serif; font-size:13px; padding:3px 6px; white-space:nowrap; border-bottom:1px dotted #000;'>965bvc</td>")
        html.Append("<td style='text-align:right; font-family:""Arial"", ""Helvetica"", sans-serif; font-size:13px; padding:3px 6px; white-space:nowrap; border-bottom:1px dotted #000;'>575.00</td>")
        html.Append("</tr>")
        '
        html.Append("<tr>")
        html.Append("<td colspan='4' style='font-weight:bold; text-align:right; font-family:""Arial"", ""Helvetica"", sans-serif; font-size:13px; padding:10px 6px; white-space:nowrap; border-bottom:1px dotted #000;'>TOTAL:</td>")
        html.Append("<td style='font-weight:bold; text-align:right; font-family:""Arial"", ""Helvetica"", sans-serif; font-size:13px; padding:10px 6px; white-space:nowrap; border-bottom:1px dotted #000;'>1,925.00</td>")
        html.Append("</tr>")
        '
        html.Append("</tbody>")

        html.Append("</table>")
        html.Append("</div>")
        html.Append("</body>")
        html.Append("</html>")

        'WebBrowser1.ScriptErrorsSuppressed = True
        'WebBrowser1.DocumentText = html.ToString()


    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        'WebBrowser1.ShowPrintDialog()
    End Sub
End Class