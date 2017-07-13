<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Form1
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents botnum As System.Windows.Forms.TextBox
	Public WithEvents File1 As Microsoft.VisualBasic.Compatibility.VB6.FileListBox
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.Command1 = New System.Windows.Forms.Button
		Me.botnum = New System.Windows.Forms.TextBox
		Me.File1 = New Microsoft.VisualBasic.Compatibility.VB6.FileListBox
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.BackColor = System.Drawing.Color.Blue
		Me.Text = "Ureal Gold launcher by echo_03"
		Me.ClientSize = New System.Drawing.Size(511, 385)
		Me.Location = New System.Drawing.Point(4, 23)
		Me.Icon = CType(resources.GetObject("Form1.Icon"), System.Drawing.Icon)
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.BackgroundImage = CType(resources.GetObject("Form1.BackgroundImage"), System.Drawing.Image)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.MaximizeBox = True
		Me.MinimizeBox = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "Form1"
		Me.Command1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command1.BackColor = System.Drawing.SystemColors.Control
		Me.Command1.Text = "PLAY!!!"
		Me.Command1.Size = New System.Drawing.Size(121, 41)
		Me.Command1.Location = New System.Drawing.Point(360, 96)
		Me.Command1.TabIndex = 4
		Me.Command1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command1.CausesValidation = True
		Me.Command1.Enabled = True
		Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command1.TabStop = True
		Me.Command1.Name = "Command1"
		Me.botnum.AutoSize = False
		Me.botnum.Size = New System.Drawing.Size(65, 25)
		Me.botnum.Location = New System.Drawing.Point(72, 120)
		Me.botnum.TabIndex = 2
		Me.botnum.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.botnum.AcceptsReturn = True
		Me.botnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.botnum.BackColor = System.Drawing.SystemColors.Window
		Me.botnum.CausesValidation = True
		Me.botnum.Enabled = True
		Me.botnum.ForeColor = System.Drawing.SystemColors.WindowText
		Me.botnum.HideSelection = True
		Me.botnum.ReadOnly = False
		Me.botnum.Maxlength = 0
		Me.botnum.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.botnum.MultiLine = False
		Me.botnum.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.botnum.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.botnum.TabStop = True
		Me.botnum.Visible = True
		Me.botnum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.botnum.Name = "botnum"
		Me.File1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.File1.ForeColor = System.Drawing.SystemColors.MenuText
		Me.File1.Size = New System.Drawing.Size(345, 54)
		Me.File1.Location = New System.Drawing.Point(120, 328)
		Me.File1.TabIndex = 0
		Me.File1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.File1.Archive = True
		Me.File1.BackColor = System.Drawing.SystemColors.Window
		Me.File1.CausesValidation = True
		Me.File1.Enabled = True
		Me.File1.Hidden = False
		Me.File1.Cursor = System.Windows.Forms.Cursors.Default
		Me.File1.SelectionMode = System.Windows.Forms.SelectionMode.One
		Me.File1.Normal = True
		Me.File1.Pattern = "*.*"
		Me.File1.ReadOnly = True
		Me.File1.System = False
		Me.File1.TabStop = True
		Me.File1.TopIndex = 0
		Me.File1.Visible = True
		Me.File1.Name = "File1"
		Me.Label2.BackColor = System.Drawing.Color.FromARGB(128, 128, 128)
		Me.Label2.Text = "bot number"
		Me.Label2.Font = New System.Drawing.Font("Arial", 13.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Size = New System.Drawing.Size(113, 25)
		Me.Label2.Location = New System.Drawing.Point(48, 80)
		Me.Label2.TabIndex = 3
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label2.Enabled = True
		Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label2.UseMnemonic = True
		Me.Label2.Visible = True
		Me.Label2.AutoSize = False
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label2.Name = "Label2"
		Me.Label1.BackColor = System.Drawing.Color.FromARGB(128, 128, 128)
		Me.Label1.Text = "choose map"
		Me.Label1.Font = New System.Drawing.Font("Arial", 13.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Size = New System.Drawing.Size(81, 57)
		Me.Label1.Location = New System.Drawing.Point(40, 328)
		Me.Label1.TabIndex = 1
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label1.Enabled = True
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.UseMnemonic = True
		Me.Label1.Visible = True
		Me.Label1.AutoSize = False
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.Name = "Label1"
		Me.Controls.Add(Command1)
		Me.Controls.Add(botnum)
		Me.Controls.Add(File1)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label1)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class