<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Request_Management
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
        Me.btnApproved = New System.Windows.Forms.Button()
        Me.btnDenied = New System.Windows.Forms.Button()
        Me.Close_btn = New System.Windows.Forms.PictureBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gvRequestData = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.Close_btn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvRequestData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnApproved
        '
        Me.btnApproved.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnApproved.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApproved.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnApproved.Location = New System.Drawing.Point(50, 522)
        Me.btnApproved.Name = "btnApproved"
        Me.btnApproved.Size = New System.Drawing.Size(550, 64)
        Me.btnApproved.TabIndex = 2
        Me.btnApproved.Text = "APPROVE"
        Me.btnApproved.UseVisualStyleBackColor = False
        '
        'btnDenied
        '
        Me.btnDenied.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnDenied.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDenied.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDenied.Location = New System.Drawing.Point(760, 522)
        Me.btnDenied.Name = "btnDenied"
        Me.btnDenied.Size = New System.Drawing.Size(550, 64)
        Me.btnDenied.TabIndex = 3
        Me.btnDenied.Text = "DENY"
        Me.btnDenied.UseVisualStyleBackColor = False
        '
        'Close_btn
        '
        Me.Close_btn.BackColor = System.Drawing.Color.Transparent
        Me.Close_btn.Image = Global.WindowsApplication1.My.Resources.Resources.back_arrow32
        Me.Close_btn.Location = New System.Drawing.Point(1299, 5)
        Me.Close_btn.Name = "Close_btn"
        Me.Close_btn.Size = New System.Drawing.Size(50, 50)
        Me.Close_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Close_btn.TabIndex = 68
        Me.Close_btn.TabStop = False
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.txtSearch.Location = New System.Drawing.Point(50, 456)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(1260, 39)
        Me.txtSearch.TabIndex = 69
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(494, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(350, 38)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "REQUEST MANAGEMENT"
        '
        'gvRequestData
        '
        Me.gvRequestData.BackgroundColor = System.Drawing.Color.White
        Me.gvRequestData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvRequestData.Location = New System.Drawing.Point(50, 73)
        Me.gvRequestData.Name = "gvRequestData"
        Me.gvRequestData.RowTemplate.Height = 24
        Me.gvRequestData.Size = New System.Drawing.Size(1260, 339)
        Me.gvRequestData.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(47, 430)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(557, 19)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "SEARCH FOR: (REQUEST STATUS, CHAPEL TYPE, TRANSACTION TYPE, ENTRY TYPE)"
        '
        'Request_Management
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.pattern
        Me.ClientSize = New System.Drawing.Size(1361, 632)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Close_btn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnDenied)
        Me.Controls.Add(Me.btnApproved)
        Me.Controls.Add(Me.gvRequestData)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Request_Management"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Request_Management"
        CType(Me.Close_btn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvRequestData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnApproved As System.Windows.Forms.Button
    Friend WithEvents btnDenied As System.Windows.Forms.Button
    Friend WithEvents Close_btn As System.Windows.Forms.PictureBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gvRequestData As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
