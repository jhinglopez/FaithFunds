<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Data_Entry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Data_Entry))
        Me.Close_btn = New System.Windows.Forms.PictureBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.cbxChapType = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxTransType = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtRecNo = New System.Windows.Forms.TextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblRecNo = New System.Windows.Forms.Label()
        Me.txtPersonName = New System.Windows.Forms.TextBox()
        Me.txtTranDate = New System.Windows.Forms.TextBox()
        Me.txtTranTime = New System.Windows.Forms.TextBox()
        Me.txtRefTitle = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.gvEntryData = New System.Windows.Forms.DataGridView()
        Me.btnDeleteRec = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnExitDeletionMode = New System.Windows.Forms.Button()
        Me.btnExitEditMode = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.Close_btn,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.gvEntryData,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Close_btn
        '
        Me.Close_btn.BackColor = System.Drawing.Color.Transparent
        Me.Close_btn.Image = Global.WindowsApplication1.My.Resources.Resources.remove
        Me.Close_btn.Location = New System.Drawing.Point(1482, 18)
        Me.Close_btn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Close_btn.Name = "Close_btn"
        Me.Close_btn.Size = New System.Drawing.Size(32, 32)
        Me.Close_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Close_btn.TabIndex = 69
        Me.Close_btn.TabStop = false
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(58,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(32,Byte),Integer))
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Black", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(209,Byte),Integer), CType(CType(0,Byte),Integer))
        Me.btnSave.Location = New System.Drawing.Point(857, 701)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(602, 51)
        Me.btnSave.TabIndex = 154
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = false
        '
        'cbxChapType
        '
        Me.cbxChapType.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cbxChapType.ForeColor = System.Drawing.Color.Black
        Me.cbxChapType.FormattingEnabled = true
        Me.cbxChapType.Items.AddRange(New Object() {"Inmaculata", "Sagrado Corazon", "Sagrada Familia"})
        Me.cbxChapType.Location = New System.Drawing.Point(43, 456)
        Me.cbxChapType.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbxChapType.Name = "cbxChapType"
        Me.cbxChapType.Size = New System.Drawing.Size(289, 36)
        Me.cbxChapType.TabIndex = 157
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = true
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(400, 421)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(225, 32)
        Me.Label2.TabIndex = 172
        Me.Label2.Text = "Transaction Type*:"
        '
        'cbxTransType
        '
        Me.cbxTransType.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cbxTransType.ForeColor = System.Drawing.Color.Black
        Me.cbxTransType.FormattingEnabled = true
        Me.cbxTransType.Items.AddRange(New Object() {"--Inflows--", "Donation", "Mass Collection", "Second Collection", "Special Intentions", "Sponsorship", "Venture Revenue", "--OutFlows--", "Supplies", "Service", "Stipend", "Utility Bill", "--Forwardings--", "Assistance Funds", "Venture Allocation", "Parish Share"})
        Me.cbxTransType.Location = New System.Drawing.Point(406, 460)
        Me.cbxTransType.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbxTransType.Name = "cbxTransType"
        Me.cbxTransType.Size = New System.Drawing.Size(289, 36)
        Me.cbxTransType.TabIndex = 158
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = true
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(37, 418)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(183, 32)
        Me.Label13.TabIndex = 171
        Me.Label13.Text = "Chapel Name*:"
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label14.AutoSize = true
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(852, 591)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(125, 32)
        Me.Label14.TabIndex = 163
        Me.Label14.Text = "Amount*:"
        '
        'txtRecNo
        '
        Me.txtRecNo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtRecNo.BackColor = System.Drawing.Color.White
        Me.txtRecNo.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtRecNo.ForeColor = System.Drawing.Color.Black
        Me.txtRecNo.Location = New System.Drawing.Point(857, 541)
        Me.txtRecNo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtRecNo.Name = "txtRecNo"
        Me.txtRecNo.Size = New System.Drawing.Size(601, 39)
        Me.txtRecNo.TabIndex = 166
        '
        'txtAmount
        '
        Me.txtAmount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtAmount.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtAmount.Location = New System.Drawing.Point(857, 630)
        Me.txtAmount.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(601, 39)
        Me.txtAmount.TabIndex = 164
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label16.AutoSize = true
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(37, 499)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(229, 32)
        Me.Label16.TabIndex = 159
        Me.Label16.Text = "Associated Name*:"
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label18.AutoSize = true
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(852, 418)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(85, 32)
        Me.Label18.TabIndex = 167
        Me.Label18.Text = "Date*:"
        '
        'lblRecNo
        '
        Me.lblRecNo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblRecNo.AutoSize = true
        Me.lblRecNo.BackColor = System.Drawing.Color.Transparent
        Me.lblRecNo.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblRecNo.ForeColor = System.Drawing.Color.White
        Me.lblRecNo.Location = New System.Drawing.Point(852, 502)
        Me.lblRecNo.Name = "lblRecNo"
        Me.lblRecNo.Size = New System.Drawing.Size(236, 32)
        Me.lblRecNo.TabIndex = 165
        Me.lblRecNo.Text = "Reference Number:"
        '
        'txtPersonName
        '
        Me.txtPersonName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPersonName.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtPersonName.Location = New System.Drawing.Point(43, 538)
        Me.txtPersonName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPersonName.Name = "txtPersonName"
        Me.txtPersonName.Size = New System.Drawing.Size(652, 39)
        Me.txtPersonName.TabIndex = 160
        '
        'txtTranDate
        '
        Me.txtTranDate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtTranDate.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtTranDate.ForeColor = System.Drawing.Color.Black
        Me.txtTranDate.Location = New System.Drawing.Point(857, 456)
        Me.txtTranDate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTranDate.Name = "txtTranDate"
        Me.txtTranDate.Size = New System.Drawing.Size(289, 39)
        Me.txtTranDate.TabIndex = 168
        '
        'txtTranTime
        '
        Me.txtTranTime.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtTranTime.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtTranTime.ForeColor = System.Drawing.Color.Black
        Me.txtTranTime.Location = New System.Drawing.Point(1170, 456)
        Me.txtTranTime.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTranTime.Name = "txtTranTime"
        Me.txtTranTime.Size = New System.Drawing.Size(289, 39)
        Me.txtTranTime.TabIndex = 170
        '
        'txtRefTitle
        '
        Me.txtRefTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtRefTitle.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtRefTitle.Location = New System.Drawing.Point(43, 636)
        Me.txtRefTitle.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtRefTitle.Name = "txtRefTitle"
        Me.txtRefTitle.Size = New System.Drawing.Size(652, 39)
        Me.txtRefTitle.TabIndex = 162
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label15.AutoSize = true
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(37, 599)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(191, 32)
        Me.Label15.TabIndex = 161
        Me.Label15.Text = "Reference Title:"
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label17.AutoSize = true
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(1164, 418)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(88, 32)
        Me.Label17.TabIndex = 169
        Me.Label17.Text = "Time*:"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(58,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(32,Byte),Integer))
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI Black", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(209,Byte),Integer), CType(CType(0,Byte),Integer))
        Me.btnDelete.Location = New System.Drawing.Point(406, 708)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(289, 51)
        Me.btnDelete.TabIndex = 156
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = false
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(58,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(32,Byte),Integer))
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI Black", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(209,Byte),Integer), CType(CType(0,Byte),Integer))
        Me.btnEdit.Location = New System.Drawing.Point(43, 708)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(289, 51)
        Me.btnEdit.TabIndex = 155
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = false
        '
        'gvEntryData
        '
        Me.gvEntryData.AllowUserToDeleteRows = false
        Me.gvEntryData.BackgroundColor = System.Drawing.Color.White
        Me.gvEntryData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvEntryData.Location = New System.Drawing.Point(43, 90)
        Me.gvEntryData.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gvEntryData.Name = "gvEntryData"
        Me.gvEntryData.ReadOnly = true
        Me.gvEntryData.RowHeadersWidth = 62
        Me.gvEntryData.RowTemplate.Height = 24
        Me.gvEntryData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvEntryData.Size = New System.Drawing.Size(1416, 308)
        Me.gvEntryData.TabIndex = 153
        '
        'btnDeleteRec
        '
        Me.btnDeleteRec.BackColor = System.Drawing.Color.FromArgb(CType(CType(58,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(32,Byte),Integer))
        Me.btnDeleteRec.Font = New System.Drawing.Font("Segoe UI Black", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnDeleteRec.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(209,Byte),Integer), CType(CType(0,Byte),Integer))
        Me.btnDeleteRec.Location = New System.Drawing.Point(857, 701)
        Me.btnDeleteRec.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDeleteRec.Name = "btnDeleteRec"
        Me.btnDeleteRec.Size = New System.Drawing.Size(602, 51)
        Me.btnDeleteRec.TabIndex = 176
        Me.btnDeleteRec.Text = "Delete Record"
        Me.btnDeleteRec.UseVisualStyleBackColor = false
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(58,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(32,Byte),Integer))
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI Black", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(209,Byte),Integer), CType(CType(0,Byte),Integer))
        Me.btnUpdate.Location = New System.Drawing.Point(857, 701)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(602, 51)
        Me.btnUpdate.TabIndex = 174
        Me.btnUpdate.Text = "Update Record"
        Me.btnUpdate.UseVisualStyleBackColor = false
        '
        'btnExitDeletionMode
        '
        Me.btnExitDeletionMode.BackColor = System.Drawing.Color.FromArgb(CType(CType(58,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(32,Byte),Integer))
        Me.btnExitDeletionMode.Font = New System.Drawing.Font("Segoe UI Black", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnExitDeletionMode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(209,Byte),Integer), CType(CType(0,Byte),Integer))
        Me.btnExitDeletionMode.Location = New System.Drawing.Point(406, 708)
        Me.btnExitDeletionMode.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExitDeletionMode.Name = "btnExitDeletionMode"
        Me.btnExitDeletionMode.Size = New System.Drawing.Size(289, 51)
        Me.btnExitDeletionMode.TabIndex = 175
        Me.btnExitDeletionMode.Text = "Cancel"
        Me.btnExitDeletionMode.UseVisualStyleBackColor = false
        '
        'btnExitEditMode
        '
        Me.btnExitEditMode.BackColor = System.Drawing.Color.FromArgb(CType(CType(58,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(32,Byte),Integer))
        Me.btnExitEditMode.Font = New System.Drawing.Font("Segoe UI Black", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnExitEditMode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(209,Byte),Integer), CType(CType(0,Byte),Integer))
        Me.btnExitEditMode.Location = New System.Drawing.Point(43, 708)
        Me.btnExitEditMode.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExitEditMode.Name = "btnExitEditMode"
        Me.btnExitEditMode.Size = New System.Drawing.Size(289, 51)
        Me.btnExitEditMode.TabIndex = 173
        Me.btnExitEditMode.Text = "Cancel"
        Me.btnExitEditMode.UseVisualStyleBackColor = false
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = true
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(115,Byte),Integer), CType(CType(145,Byte),Integer), CType(CType(64,Byte),Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(205,Byte),Integer), CType(CType(0,Byte),Integer))
        Me.Label1.Location = New System.Drawing.Point(636, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 45)
        Me.Label1.TabIndex = 152
        Me.Label1.Text = "DATA ENTRY"
        '
        'Data_Entry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9!, 20!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(58,Byte),Integer), CType(CType(73,Byte),Integer), CType(CType(32,Byte),Integer))
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.pattern
        Me.ClientSize = New System.Drawing.Size(1531, 790)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cbxChapType)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbxTransType)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtRecNo)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.lblRecNo)
        Me.Controls.Add(Me.txtPersonName)
        Me.Controls.Add(Me.txtTranDate)
        Me.Controls.Add(Me.txtTranTime)
        Me.Controls.Add(Me.txtRefTitle)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.gvEntryData)
        Me.Controls.Add(Me.btnDeleteRec)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnExitDeletionMode)
        Me.Controls.Add(Me.btnExitEditMode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Close_btn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Data_Entry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "CASH IN & OUT & FORWARDINGS"
        CType(Me.Close_btn,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.gvEntryData,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents Close_btn As System.Windows.Forms.PictureBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents cbxChapType As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbxTransType As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtRecNo As System.Windows.Forms.TextBox
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lblRecNo As System.Windows.Forms.Label
    Friend WithEvents txtPersonName As System.Windows.Forms.TextBox
    Friend WithEvents txtTranDate As System.Windows.Forms.TextBox
    Friend WithEvents txtTranTime As System.Windows.Forms.TextBox
    Friend WithEvents txtRefTitle As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents gvEntryData As System.Windows.Forms.DataGridView
    Friend WithEvents btnDeleteRec As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnExitDeletionMode As System.Windows.Forms.Button
    Friend WithEvents btnExitEditMode As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
