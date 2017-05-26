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
		Me.statusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
		Me.grabText = New System.Windows.Forms.Timer(Me.components)
		Me.meaningGrp.SuspendLayout
		Me.SuspendLayout
		'
		'meaningGrp
		'
		Me.meaningGrp.Controls.Add(Me.output)
		Me.meaningGrp.Location = New System.Drawing.Point(9, 82)
		Me.meaningGrp.Name = "meaningGrp"
		Me.meaningGrp.Size = New System.Drawing.Size(252, 186)
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
		Me.output.Size = New System.Drawing.Size(246, 167)
		Me.output.Sorted = true
		Me.output.TabIndex = 0
		AddHandler Me.output.DoubleClick, AddressOf Me.OutputDoubleClick
		'
		'smMode
		'
		Me.smMode.Location = New System.Drawing.Point(87, 51)
		Me.smMode.Name = "smMode"
		Me.smMode.Size = New System.Drawing.Size(104, 24)
		Me.smMode.TabIndex = 10
		Me.smMode.Text = "SM Mode"
		Me.smMode.UseVisualStyleBackColor = true
		'
		'input
		'
		Me.input.Font = New System.Drawing.Font("Malithi Web", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.input.Location = New System.Drawing.Point(9, 18)
		Me.input.Name = "input"
		Me.input.Size = New System.Drawing.Size(182, 27)
		Me.input.TabIndex = 9
		'
		'atoGrab
		'
		Me.atoGrab.Location = New System.Drawing.Point(9, 51)
		Me.atoGrab.Name = "atoGrab"
		Me.atoGrab.Size = New System.Drawing.Size(104, 24)
		Me.atoGrab.TabIndex = 8
		Me.atoGrab.Text = "Auto Grab"
		Me.atoGrab.UseVisualStyleBackColor = true
		AddHandler Me.atoGrab.CheckedChanged, AddressOf Me.AtoGrabCheckedChanged
		'
		'findBtn
		'
		Me.findBtn.Location = New System.Drawing.Point(197, 18)
		Me.findBtn.Name = "findBtn"
		Me.findBtn.Size = New System.Drawing.Size(64, 27)
		Me.findBtn.TabIndex = 7
		Me.findBtn.Text = "Search"
		Me.findBtn.UseVisualStyleBackColor = true
		AddHandler Me.findBtn.Click, AddressOf Me.FindBtnClick
		'
		'statusStrip1
		'
		Me.statusStrip1.Location = New System.Drawing.Point(0, 271)
		Me.statusStrip1.Name = "statusStrip1"
		Me.statusStrip1.Size = New System.Drawing.Size(271, 22)
		Me.statusStrip1.TabIndex = 11
		Me.statusStrip1.Text = "statusStrip1"
		'
		'grabText
		'
		AddHandler Me.grabText.Tick, AddressOf Me.GrabTextTick
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(271, 293)
		Me.Controls.Add(Me.statusStrip1)
		Me.Controls.Add(Me.smMode)
		Me.Controls.Add(Me.input)
		Me.Controls.Add(Me.atoGrab)
		Me.Controls.Add(Me.findBtn)
		Me.Controls.Add(Me.meaningGrp)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
		Me.Name = "MainForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Zigiri Dictionary"
		AddHandler Load, AddressOf Me.MainFormLoad
		Me.meaningGrp.ResumeLayout(false)
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private grabText As System.Windows.Forms.Timer
	Private toolTip1 As System.Windows.Forms.ToolTip
	Private statusStrip1 As System.Windows.Forms.StatusStrip
	Friend output As System.Windows.Forms.ListBox
	Friend meaningGrp As System.Windows.Forms.GroupBox
	Private atoGrab As System.Windows.Forms.CheckBox
	Friend input As System.Windows.Forms.TextBox
	Private smMode As System.Windows.Forms.CheckBox
	Private findBtn As System.Windows.Forms.Button
End Class
