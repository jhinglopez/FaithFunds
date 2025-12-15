<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.DATAENTRYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REPORTGENERATIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.USERMANAGEMENTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RequestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip3 = New System.Windows.Forms.MenuStrip()
        Me.SignOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MenuStrip3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DATAENTRYToolStripMenuItem
        '
        Me.DATAENTRYToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DATAENTRYToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.DATAENTRYToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.data_input
        Me.DATAENTRYToolStripMenuItem.Margin = New System.Windows.Forms.Padding(25, 0, 25, 0)
        Me.DATAENTRYToolStripMenuItem.Name = "DATAENTRYToolStripMenuItem"
        Me.DATAENTRYToolStripMenuItem.Size = New System.Drawing.Size(134, 32)
        Me.DATAENTRYToolStripMenuItem.Text = "Data Entry"
        '
        'REPORTGENERATIONToolStripMenuItem
        '
        Me.REPORTGENERATIONToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REPORTGENERATIONToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.REPORTGENERATIONToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.report
        Me.REPORTGENERATIONToolStripMenuItem.Margin = New System.Windows.Forms.Padding(25, 0, 25, 0)
        Me.REPORTGENERATIONToolStripMenuItem.Name = "REPORTGENERATIONToolStripMenuItem"
        Me.REPORTGENERATIONToolStripMenuItem.Size = New System.Drawing.Size(208, 32)
        Me.REPORTGENERATIONToolStripMenuItem.Text = "Report Generation"
        '
        'USERMANAGEMENTToolStripMenuItem
        '
        Me.USERMANAGEMENTToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddUserToolStripMenuItem, Me.EditUserToolStripMenuItem, Me.DeleteUserToolStripMenuItem})
        Me.USERMANAGEMENTToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.USERMANAGEMENTToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.USERMANAGEMENTToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.user_icon
        Me.USERMANAGEMENTToolStripMenuItem.Margin = New System.Windows.Forms.Padding(25, 0, 25, 0)
        Me.USERMANAGEMENTToolStripMenuItem.Name = "USERMANAGEMENTToolStripMenuItem"
        Me.USERMANAGEMENTToolStripMenuItem.Size = New System.Drawing.Size(197, 32)
        Me.USERMANAGEMENTToolStripMenuItem.Text = "User Managment"
        '
        'AddUserToolStripMenuItem
        '
        Me.AddUserToolStripMenuItem.Name = "AddUserToolStripMenuItem"
        Me.AddUserToolStripMenuItem.Size = New System.Drawing.Size(188, 32)
        Me.AddUserToolStripMenuItem.Text = "Add user"
        '
        'EditUserToolStripMenuItem
        '
        Me.EditUserToolStripMenuItem.Name = "EditUserToolStripMenuItem"
        Me.EditUserToolStripMenuItem.Size = New System.Drawing.Size(188, 32)
        Me.EditUserToolStripMenuItem.Text = "Edit user"
        '
        'DeleteUserToolStripMenuItem
        '
        Me.DeleteUserToolStripMenuItem.Name = "DeleteUserToolStripMenuItem"
        Me.DeleteUserToolStripMenuItem.Size = New System.Drawing.Size(188, 32)
        Me.DeleteUserToolStripMenuItem.Text = "Delete user"
        '
        'RequestToolStripMenuItem
        '
        Me.RequestToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RequestToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.RequestToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.request_icon
        Me.RequestToolStripMenuItem.Margin = New System.Windows.Forms.Padding(25, 0, 100, 0)
        Me.RequestToolStripMenuItem.Name = "RequestToolStripMenuItem"
        Me.RequestToolStripMenuItem.Size = New System.Drawing.Size(208, 32)
        Me.RequestToolStripMenuItem.Text = "Request Management"
        '
        'MenuStrip3
        '
        Me.MenuStrip3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MenuStrip3.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip3.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip3.GripMargin = New System.Windows.Forms.Padding(2)
        Me.MenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DATAENTRYToolStripMenuItem, Me.REPORTGENERATIONToolStripMenuItem, Me.USERMANAGEMENTToolStripMenuItem, Me.RequestToolStripMenuItem, Me.SignOutToolStripMenuItem})
        Me.MenuStrip3.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip3.Name = "MenuStrip3"
        Me.MenuStrip3.Padding = New System.Windows.Forms.Padding(10, 20, 10, 20)
        Me.MenuStrip3.Size = New System.Drawing.Size(1133, 72)
        Me.MenuStrip3.Stretch = False
        Me.MenuStrip3.TabIndex = 5
        Me.MenuStrip3.Text = "MenuStrip3"
        '
        'SignOutToolStripMenuItem
        '
        Me.SignOutToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.SignOutToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SignOutToolStripMenuItem.Name = "SignOutToolStripMenuItem"
        Me.SignOutToolStripMenuItem.Size = New System.Drawing.Size(89, 32)
        Me.SignOutToolStripMenuItem.Text = "Sign Out"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.BuenPastor_Green_Colorway_home2
        Me.PictureBox1.Location = New System.Drawing.Point(129, 83)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(413, 446)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(594, 460)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(552, 69)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Empowering faith through trust and care, Committed to " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "support the Church’s miss" & _
    "ion and strengthening our " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "community with purpose."
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 79.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(560, 146)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(586, 314)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Faith " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   Funds." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(591, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 38)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Welcome to"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.WindowsApplication1.My.Resources.Resources.BuenPator_Green_Colorway_homeMax
        Me.PictureBox2.Location = New System.Drawing.Point(-31, 83)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(582, 696)
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 130.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(458, 159)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(956, 528)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Faith " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   Funds." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(487, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(281, 65)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Welcome to"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(487, 500)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(786, 87)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Empowering faith through trust and care, Committed to support " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the Church’s miss" & _
    "ion and strengthening our community " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "with purpose."
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.pattern
        Me.ClientSize = New System.Drawing.Size(1343, 595)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MenuStrip3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Home"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.MenuStrip3.ResumeLayout(False)
        Me.MenuStrip3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DATAENTRYToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REPORTGENERATIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents USERMANAGEMENTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RequestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip3 As System.Windows.Forms.MenuStrip
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SignOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
