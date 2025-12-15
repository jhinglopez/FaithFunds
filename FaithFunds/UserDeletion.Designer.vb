<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserDeletion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserDeletion))
        Me.Search_Btn = New System.Windows.Forms.Button()
        Me.Delete_Btn = New System.Windows.Forms.Button()
        Me.Textbox_Username = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Close_btn = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Close_btn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Search_Btn
        '
        Me.Search_Btn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Search_Btn.BackColor = System.Drawing.Color.White
        Me.Search_Btn.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search_Btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Search_Btn.Location = New System.Drawing.Point(87, 354)
        Me.Search_Btn.Name = "Search_Btn"
        Me.Search_Btn.Size = New System.Drawing.Size(355, 40)
        Me.Search_Btn.TabIndex = 19
        Me.Search_Btn.Text = "Search User"
        Me.Search_Btn.UseVisualStyleBackColor = False
        '
        'Delete_Btn
        '
        Me.Delete_Btn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Delete_Btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Delete_Btn.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete_Btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Delete_Btn.Location = New System.Drawing.Point(87, 428)
        Me.Delete_Btn.Name = "Delete_Btn"
        Me.Delete_Btn.Size = New System.Drawing.Size(355, 40)
        Me.Delete_Btn.TabIndex = 20
        Me.Delete_Btn.Text = "Delete"
        Me.Delete_Btn.UseVisualStyleBackColor = False
        '
        'Textbox_Username
        '
        Me.Textbox_Username.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Textbox_Username.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textbox_Username.Location = New System.Drawing.Point(87, 298)
        Me.Textbox_Username.Name = "Textbox_Username"
        Me.Textbox_Username.Size = New System.Drawing.Size(355, 27)
        Me.Textbox_Username.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(84, 277)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 17)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "UserName"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.Delete_gold
        Me.PictureBox1.Location = New System.Drawing.Point(6, -105)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(486, 442)
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'Close_btn
        '
        Me.Close_btn.Image = Global.WindowsApplication1.My.Resources.Resources.back_arrow34
        Me.Close_btn.Location = New System.Drawing.Point(490, 8)
        Me.Close_btn.Name = "Close_btn"
        Me.Close_btn.Size = New System.Drawing.Size(50, 50)
        Me.Close_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Close_btn.TabIndex = 24
        Me.Close_btn.TabStop = False
        '
        'UserDeletion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.pattern
        Me.ClientSize = New System.Drawing.Size(558, 595)
        Me.Controls.Add(Me.Close_btn)
        Me.Controls.Add(Me.Delete_Btn)
        Me.Controls.Add(Me.Search_Btn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Textbox_Username)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "UserDeletion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "UserDeletion"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Close_btn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Search_Btn As System.Windows.Forms.Button
    Friend WithEvents Delete_Btn As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Textbox_Username As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Close_btn As System.Windows.Forms.PictureBox
End Class
