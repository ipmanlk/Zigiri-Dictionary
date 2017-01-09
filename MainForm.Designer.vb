﻿'
' Created by SharpDevelop.
' User: IP-Man
' Date: 3/3/2016
' Time: 9:53 PM
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
		Me.groupBox1 = New System.Windows.Forms.GroupBox()
		Me.input = New System.Windows.Forms.TextBox()
		Me.find = New System.Windows.Forms.Button()
		Me.groupBox2 = New System.Windows.Forms.GroupBox()
		Me.output = New System.Windows.Forms.ListBox()
		Me.statusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.toolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
		Me.checkForUpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.aboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.trayicon = New System.Windows.Forms.NotifyIcon(Me.components)
		Me.rightclickmenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.copyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.groupBox1.SuspendLayout
		Me.groupBox2.SuspendLayout
		Me.statusStrip1.SuspendLayout
		Me.rightclickmenu.SuspendLayout
		Me.SuspendLayout
		'
		'groupBox1
		'
		Me.groupBox1.Controls.Add(Me.input)
		Me.groupBox1.Controls.Add(Me.find)
		Me.groupBox1.Location = New System.Drawing.Point(7, 7)
		Me.groupBox1.Name = "groupBox1"
		Me.groupBox1.Size = New System.Drawing.Size(288, 79)
		Me.groupBox1.TabIndex = 2
		Me.groupBox1.TabStop = false
		Me.groupBox1.Text = "Word"
		'
		'input
		'
		Me.input.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.input.Location = New System.Drawing.Point(11, 29)
		Me.input.Name = "input"
		Me.input.Size = New System.Drawing.Size(206, 26)
		Me.input.TabIndex = 3
		AddHandler Me.input.KeyPress, AddressOf Me.InputKeyPress
		'
		'find
		'
		Me.find.Location = New System.Drawing.Point(223, 28)
		Me.find.Name = "find"
		Me.find.Size = New System.Drawing.Size(56, 28)
		Me.find.TabIndex = 2
		Me.find.Text = "Find"
		Me.find.UseVisualStyleBackColor = true
		AddHandler Me.find.Click, AddressOf Me.FindClick
		'
		'groupBox2
		'
		Me.groupBox2.Controls.Add(Me.output)
		Me.groupBox2.Location = New System.Drawing.Point(7, 93)
		Me.groupBox2.Name = "groupBox2"
		Me.groupBox2.Size = New System.Drawing.Size(288, 205)
		Me.groupBox2.TabIndex = 3
		Me.groupBox2.TabStop = false
		Me.groupBox2.Text = "Meaning"
		'
		'output
		'
		Me.output.Font = New System.Drawing.Font("Iskoola Pota", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.output.FormattingEnabled = true
		Me.output.ItemHeight = 22
		Me.output.Location = New System.Drawing.Point(3, 16)
		Me.output.Name = "output"
		Me.output.Size = New System.Drawing.Size(282, 180)
		Me.output.TabIndex = 0
		AddHandler Me.output.MouseDown, AddressOf Me.OutputMouseDown
		'
		'statusStrip1
		'
		Me.statusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripDropDownButton1})
		Me.statusStrip1.Location = New System.Drawing.Point(0, 307)
		Me.statusStrip1.Name = "statusStrip1"
		Me.statusStrip1.Size = New System.Drawing.Size(303, 22)
		Me.statusStrip1.TabIndex = 4
		Me.statusStrip1.Text = "statusStrip1"
		'
		'toolStripDropDownButton1
		'
		Me.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.toolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.checkForUpdatesToolStripMenuItem, Me.aboutToolStripMenuItem})
		Me.toolStripDropDownButton1.Enabled = false
		Me.toolStripDropDownButton1.Image = CType(resources.GetObject("toolStripDropDownButton1.Image"),System.Drawing.Image)
		Me.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.toolStripDropDownButton1.Name = "toolStripDropDownButton1"
		Me.toolStripDropDownButton1.Size = New System.Drawing.Size(29, 20)
		Me.toolStripDropDownButton1.Text = "toolStripDropDownButton1"
		'
		'checkForUpdatesToolStripMenuItem
		'
		Me.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem"
		Me.checkForUpdatesToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
		Me.checkForUpdatesToolStripMenuItem.Text = "Check For Updates"
		AddHandler Me.checkForUpdatesToolStripMenuItem.Click, AddressOf Me.CheckForUpdatesToolStripMenuItemClick
		'
		'aboutToolStripMenuItem
		'
		Me.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem"
		Me.aboutToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
		Me.aboutToolStripMenuItem.Text = "About"
		'
		'trayicon
		'
		Me.trayicon.Icon = CType(resources.GetObject("trayicon.Icon"),System.Drawing.Icon)
		Me.trayicon.Text = "notifyIcon1"
		Me.trayicon.Visible = true
		AddHandler Me.trayicon.MouseClick, AddressOf Me.TrayiconMouseClick
		'
		'rightclickmenu
		'
		Me.rightclickmenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.copyToolStripMenuItem})
		Me.rightclickmenu.Name = "rightclickmenu"
		Me.rightclickmenu.Size = New System.Drawing.Size(103, 26)
		'
		'copyToolStripMenuItem
		'
		Me.copyToolStripMenuItem.Name = "copyToolStripMenuItem"
		Me.copyToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
		Me.copyToolStripMenuItem.Text = "Copy"
		AddHandler Me.copyToolStripMenuItem.Click, AddressOf Me.CopyToolStripMenuItemClick
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(303, 329)
		Me.Controls.Add(Me.statusStrip1)
		Me.Controls.Add(Me.groupBox2)
		Me.Controls.Add(Me.groupBox1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
		Me.Location = New System.Drawing.Point(-3, 0)
		Me.Name = "MainForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Zigiri Dictionary"
		AddHandler FormClosed, AddressOf Me.MainFormFormClosed
		AddHandler Load, AddressOf Me.MainFormLoad
		AddHandler Resize, AddressOf Me.MainFormResize
		Me.groupBox1.ResumeLayout(false)
		Me.groupBox1.PerformLayout
		Me.groupBox2.ResumeLayout(false)
		Me.statusStrip1.ResumeLayout(false)
		Me.statusStrip1.PerformLayout
		Me.rightclickmenu.ResumeLayout(false)
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private copyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private rightclickmenu As System.Windows.Forms.ContextMenuStrip
	Private trayicon As System.Windows.Forms.NotifyIcon
	Private aboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private checkForUpdatesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
	Private statusStrip1 As System.Windows.Forms.StatusStrip
	Public output As System.Windows.Forms.ListBox
	Private groupBox2 As System.Windows.Forms.GroupBox
	Private groupBox1 As System.Windows.Forms.GroupBox
	Public input As System.Windows.Forms.TextBox
	Private find As System.Windows.Forms.Button
	
	
	Sub OutputMouseDown(sender As Object, e As MouseEventArgs)
		If e.Button = Windows.Forms.MouseButtons.Right Then
			rightclickmenu.Show(MousePosition)
		End If 
	End Sub
	
	Sub CopyToolStripMenuItemClick(sender As Object, e As EventArgs)
		If String.IsNullOrEmpty(output.Text) Then 
			MsgBox("Please select an item to copy!")
		Else 
			Clipboard.SetText(output.Text)
		End If
		
	End Sub
End Class