'
' Created by SharpDevelop.
' User: IP-PC
' Date: 5/11/2017
' Time: 9:01 AM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class MainForm
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
		Me.meaningGrp = New System.Windows.Forms.GroupBox()
		Me.output = New System.Windows.Forms.ListBox()
		Me.smMode = New System.Windows.Forms.CheckBox()
		Me.input = New System.Windows.Forms.TextBox()
		Me.atoGrab = New System.Windows.Forms.CheckBox()
		Me.findBtn = New System.Windows.Forms.Button()
		Me.statusStrip = New System.Windows.Forms.StatusStrip()
		Me.infoBtn = New System.Windows.Forms.ToolStripSplitButton()
		Me.AboutBtn = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
		Me.grabText = New System.Windows.Forms.Timer(Me.components)
		Me.notifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
		Me.contextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.copyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.trayMeaning = New System.Windows.Forms.CheckBox()
		Me.meaningGrp.SuspendLayout
		Me.statusStrip.SuspendLayout
		Me.contextMenu.SuspendLayout
		Me.SuspendLayout
		'
		'meaningGrp
		'
		Me.meaningGrp.Controls.Add(Me.output)
		Me.meaningGrp.Location = New System.Drawing.Point(7, 82)
		Me.meaningGrp.Name = "meaningGrp"
		Me.meaningGrp.Size = New System.Drawing.Size(273, 208)
		Me.meaningGrp.TabIndex = 3
		Me.meaningGrp.TabStop = false
		Me.meaningGrp.Text = "Meaning"
		'
		'output
		'
		Me.output.Dock = System.Windows.Forms.DockStyle.Fill
		Me.output.Font = New System.Drawing.Font("Malithi Web", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.output.FormattingEnabled = true
		Me.output.ItemHeight = 20
		Me.output.Location = New System.Drawing.Point(3, 16)
		Me.output.Name = "output"
		Me.output.Size = New System.Drawing.Size(267, 189)
		Me.output.Sorted = true
		Me.output.TabIndex = 0
		AddHandler Me.output.DoubleClick, AddressOf Me.OutputDoubleClick
		AddHandler Me.output.MouseDown, AddressOf Me.OutputMouseDown
		'
		'smMode
		'
		Me.smMode.Location = New System.Drawing.Point(90, 51)
		Me.smMode.Name = "smMode"
		Me.smMode.Size = New System.Drawing.Size(104, 24)
		Me.smMode.TabIndex = 10
		Me.smMode.Text = "SM Mode"
		Me.smMode.UseVisualStyleBackColor = true
		AddHandler Me.smMode.CheckedChanged, AddressOf Me.SmModeCheckedChanged
		'
		'input
		'
		Me.input.Font = New System.Drawing.Font("Malithi Web", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.input.Location = New System.Drawing.Point(7, 18)
		Me.input.Name = "input"
		Me.input.Size = New System.Drawing.Size(203, 27)
		Me.input.TabIndex = 9
		AddHandler Me.input.KeyPress, AddressOf Me.InputKeyPress
		'
		'atoGrab
		'
		Me.atoGrab.Location = New System.Drawing.Point(7, 51)
		Me.atoGrab.Name = "atoGrab"
		Me.atoGrab.Size = New System.Drawing.Size(104, 24)
		Me.atoGrab.TabIndex = 8
		Me.atoGrab.Text = "Auto Grab"
		Me.atoGrab.UseVisualStyleBackColor = true
		AddHandler Me.atoGrab.CheckedChanged, AddressOf Me.AtoGrabCheckedChanged
		'
		'findBtn
		'
		Me.findBtn.Location = New System.Drawing.Point(216, 18)
		Me.findBtn.Name = "findBtn"
		Me.findBtn.Size = New System.Drawing.Size(64, 27)
		Me.findBtn.TabIndex = 7
		Me.findBtn.Text = "Search"
		Me.findBtn.UseVisualStyleBackColor = true
		AddHandler Me.findBtn.Click, AddressOf Me.FindBtnClick
		'
		'statusStrip
		'
		Me.statusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.infoBtn})
		Me.statusStrip.Location = New System.Drawing.Point(0, 297)
		Me.statusStrip.Name = "statusStrip"
		Me.statusStrip.Size = New System.Drawing.Size(289, 22)
		Me.statusStrip.TabIndex = 11
		Me.statusStrip.Text = "statusStrip"
		'
		'infoBtn
		'
		Me.infoBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.infoBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutBtn})
		Me.infoBtn.Image = CType(resources.GetObject("infoBtn.Image"),System.Drawing.Image)
		Me.infoBtn.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.infoBtn.Name = "infoBtn"
		Me.infoBtn.Size = New System.Drawing.Size(32, 20)
		Me.infoBtn.Text = "infoButton"
		AddHandler Me.infoBtn.ButtonClick, AddressOf Me.InfoBtnButtonClick
		'
		'AboutBtn
		'
		Me.AboutBtn.Name = "AboutBtn"
		Me.AboutBtn.Size = New System.Drawing.Size(152, 22)
		Me.AboutBtn.Text = "About"
		AddHandler Me.AboutBtn.Click, AddressOf Me.AboutBtnClick
		'
		'grabText
		'
		AddHandler Me.grabText.Tick, AddressOf Me.GrabTextTick
		'
		'notifyIcon
		'
		Me.notifyIcon.Icon = CType(resources.GetObject("notifyIcon.Icon"),System.Drawing.Icon)
		Me.notifyIcon.Text = "Zigiri Dictionary"
		Me.notifyIcon.Visible = true
		AddHandler Me.notifyIcon.Click, AddressOf Me.NotifyIconClick
		'
		'contextMenu
		'
		Me.contextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.copyToolStripMenuItem})
		Me.contextMenu.Name = "contextMenu"
		Me.contextMenu.Size = New System.Drawing.Size(103, 26)
		'
		'copyToolStripMenuItem
		'
		Me.copyToolStripMenuItem.Name = "copyToolStripMenuItem"
		Me.copyToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
		Me.copyToolStripMenuItem.Text = "Copy"
		AddHandler Me.copyToolStripMenuItem.Click, AddressOf Me.CopyToolStripMenuItemClick
		'
		'trayMeaning
		'
		Me.trayMeaning.Location = New System.Drawing.Point(172, 51)
		Me.trayMeaning.Name = "trayMeaning"
		Me.trayMeaning.Size = New System.Drawing.Size(104, 24)
		Me.trayMeaning.TabIndex = 12
		Me.trayMeaning.Text = "Tray Meaning"
		Me.trayMeaning.UseVisualStyleBackColor = true
		AddHandler Me.trayMeaning.CheckedChanged, AddressOf Me.TrayMeaningCheckedChanged
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(289, 319)
		Me.Controls.Add(Me.trayMeaning)
		Me.Controls.Add(Me.statusStrip)
		Me.Controls.Add(Me.smMode)
		Me.Controls.Add(Me.input)
		Me.Controls.Add(Me.atoGrab)
		Me.Controls.Add(Me.findBtn)
		Me.Controls.Add(Me.meaningGrp)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
		Me.Name = "MainForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "ZD-Zigiri Dictionary"
		AddHandler Load, AddressOf Me.MainFormLoad
		AddHandler Resize, AddressOf Me.MainFormResize
		Me.meaningGrp.ResumeLayout(false)
		Me.statusStrip.ResumeLayout(false)
		Me.statusStrip.PerformLayout
		Me.contextMenu.ResumeLayout(false)
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private trayMeaning As System.Windows.Forms.CheckBox
	Private AboutBtn As System.Windows.Forms.ToolStripMenuItem
	Private infoBtn As System.Windows.Forms.ToolStripSplitButton
	Private copyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private contextMenu As System.Windows.Forms.ContextMenuStrip
	Friend notifyIcon As System.Windows.Forms.NotifyIcon
	Private grabText As System.Windows.Forms.Timer
	Private toolTip1 As System.Windows.Forms.ToolTip
	Private statusStrip As System.Windows.Forms.StatusStrip
	Friend output As System.Windows.Forms.ListBox
	Friend meaningGrp As System.Windows.Forms.GroupBox
	Private atoGrab As System.Windows.Forms.CheckBox
	Friend input As System.Windows.Forms.TextBox
	Private smMode As System.Windows.Forms.CheckBox
	Private findBtn As System.Windows.Forms.Button
End Class
