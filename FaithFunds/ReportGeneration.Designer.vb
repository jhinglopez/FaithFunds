<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportGeneration
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportGeneration))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.gvTransData = New System.Windows.Forms.DataGridView()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.comboboxChapel = New System.Windows.Forms.ComboBox()
        Me.comboxEntry = New System.Windows.Forms.ComboBox()
        Me.textboxDateTo = New System.Windows.Forms.TextBox()
        Me.textboxFrom = New System.Windows.Forms.TextBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.comboxTranstype = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Close_btn = New System.Windows.Forms.PictureBox()
        CType(Me.gvTransData,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Close_btn,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(25, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Chapel:"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(282, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Entry Type:"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(811, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 32)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Date From:"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(992, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 32)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Date to:"
        '
        'btnGo
        '
        Me.btnGo.BackColor = System.Drawing.Color.FromArgb(CType(CType(58,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(32,Byte),Integer))
        Me.btnGo.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnGo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(209,Byte),Integer), CType(CType(0,Byte),Integer))
        Me.btnGo.Location = New System.Drawing.Point(1176, 129)
        Me.btnGo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(309, 60)
        Me.btnGo.TabIndex = 4
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = false
        '
        'gvTransData
        '
        Me.gvTransData.BackgroundColor = System.Drawing.Color.White
        Me.gvTransData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvTransData.Location = New System.Drawing.Point(25, 292)
        Me.gvTransData.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gvTransData.Name = "gvTransData"
        Me.gvTransData.RowHeadersWidth = 62
        Me.gvTransData.RowTemplate.Height = 24
        Me.gvTransData.Size = New System.Drawing.Size(1460, 416)
        Me.gvTransData.TabIndex = 5
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = true
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(209,Byte),Integer), CType(CType(0,Byte),Integer))
        Me.lblTotal.Location = New System.Drawing.Point(35, 196)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(39, 61)
        Me.lblTotal.TabIndex = 6
        Me.lblTotal.Text = " "
        '
        'comboboxChapel
        '
        Me.comboboxChapel.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.comboboxChapel.FormattingEnabled = true
        Me.comboboxChapel.Items.AddRange(New Object() {"  All", "IC Inmaculata", "SF Sagrada Familia", "SC Sagrado Corazon"})
        Me.comboboxChapel.Location = New System.Drawing.Point(30, 128)
        Me.comboboxChapel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.comboboxChapel.Name = "comboboxChapel"
        Me.comboboxChapel.Size = New System.Drawing.Size(242, 40)
        Me.comboboxChapel.TabIndex = 7
        '
        'comboxEntry
        '
        Me.comboxEntry.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.comboxEntry.FormattingEnabled = true
        Me.comboxEntry.Items.AddRange(New Object() {"  All", "IN", "OUT", "FOR"})
        Me.comboxEntry.Location = New System.Drawing.Point(287, 129)
        Me.comboxEntry.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.comboxEntry.Name = "comboxEntry"
        Me.comboxEntry.Size = New System.Drawing.Size(242, 40)
        Me.comboxEntry.TabIndex = 8
        '
        'textboxDateTo
        '
        Me.textboxDateTo.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.textboxDateTo.Location = New System.Drawing.Point(998, 132)
        Me.textboxDateTo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.textboxDateTo.Name = "textboxDateTo"
        Me.textboxDateTo.Size = New System.Drawing.Size(163, 39)
        Me.textboxDateTo.TabIndex = 10
        '
        'textboxFrom
        '
        Me.textboxFrom.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.textboxFrom.Location = New System.Drawing.Point(817, 132)
        Me.textboxFrom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.textboxFrom.Name = "textboxFrom"
        Me.textboxFrom.Size = New System.Drawing.Size(163, 39)
        Me.textboxFrom.TabIndex = 9
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(58,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(32,Byte),Integer))
        Me.btnPrint.Font = New System.Drawing.Font("Segoe UI Black", 12!, System.Drawing.FontStyle.Bold)
        Me.btnPrint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(209,Byte),Integer), CType(CType(0,Byte),Integer))
        Me.btnPrint.Location = New System.Drawing.Point(1176, 210)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(309, 68)
        Me.btnPrint.TabIndex = 11
        Me.btnPrint.Text = "Print Document"
        Me.btnPrint.UseVisualStyleBackColor = false
        '
        'comboxTranstype
        '
        Me.comboxTranstype.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.comboxTranstype.FormattingEnabled = true
        Me.comboxTranstype.Items.AddRange(New Object() {"   All", "--Inflows--", "DN Donation", "MC Mass Collection", "S2 Second Collection", "SI Special Intentions", "SP Sponsorship", "VR Venture Revenue", "--OutFlows--", "SU Supplies", "SE Service", "ST Stipend", "Utility Bill", "--Forwardings--", "AF Assistance Funds", "VA Venture Allocation", "PS Parish Share"})
        Me.comboxTranstype.Location = New System.Drawing.Point(543, 130)
        Me.comboxTranstype.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.comboxTranstype.Name = "comboxTranstype"
        Me.comboxTranstype.Size = New System.Drawing.Size(242, 40)
        Me.comboxTranstype.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(538, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(164, 32)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Transactions:"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = true
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(115,Byte),Integer), CType(CType(145,Byte),Integer), CType(CType(64,Byte),Integer))
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(205,Byte),Integer), CType(CType(0,Byte),Integer))
        Me.Label6.Location = New System.Drawing.Point(579, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(367, 45)
        Me.Label6.TabIndex = 153
        Me.Label6.Text = "REPORT GENARATION"
        '
        'Close_btn
        '
        Me.Close_btn.BackColor = System.Drawing.Color.Transparent
        Me.Close_btn.Image = Global.WindowsApplication1.My.Resources.Resources.remove
        Me.Close_btn.Location = New System.Drawing.Point(1456, 21)
        Me.Close_btn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Close_btn.Name = "Close_btn"
        Me.Close_btn.Size = New System.Drawing.Size(32, 32)
        Me.Close_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Close_btn.TabIndex = 154
        Me.Close_btn.TabStop = false
        '
        'ReportGeneration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9!, 20!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(58,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(32,Byte),Integer))
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.pattern
        Me.ClientSize = New System.Drawing.Size(1511, 731)
        Me.Controls.Add(Me.Close_btn)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.comboxTranstype)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.textboxDateTo)
        Me.Controls.Add(Me.textboxFrom)
        Me.Controls.Add(Me.comboxEntry)
        Me.Controls.Add(Me.comboboxChapel)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.gvTransData)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ReportGeneration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ReportGeneration"
        CType(Me.gvTransData,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Close_btn,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents gvTransData As System.Windows.Forms.DataGridView
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents comboboxChapel As System.Windows.Forms.ComboBox
    Friend WithEvents comboxEntry As System.Windows.Forms.ComboBox
    Friend WithEvents textboxDateTo As System.Windows.Forms.TextBox
    Friend WithEvents textboxFrom As System.Windows.Forms.TextBox
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents comboxTranstype As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Close_btn As System.Windows.Forms.PictureBox
End Class
