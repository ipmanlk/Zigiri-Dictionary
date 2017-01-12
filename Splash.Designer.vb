'
' Created by SharpDevelop.
' User: IP-Man
' Date: 3/4/2016
' Time: 10:26 AM
'
Partial Class Splash
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Splash))
		Me.label1 = New System.Windows.Forms.Label()
		Me.SuspendLayout
		'
		'label1
		'
		Me.label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(204,Byte),Integer), CType(CType(0,Byte),Integer))
		Me.label1.Location = New System.Drawing.Point(306, 69)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(66, 15)
		Me.label1.TabIndex = 0
		Me.label1.Text = "       v0.1.0"
		'
		'Splash
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"),System.Drawing.Image)
		Me.ClientSize = New System.Drawing.Size(364, 84)
		Me.Controls.Add(Me.label1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
		Me.Name = "Splash"
		Me.ShowInTaskbar = false
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Loading..."
		AddHandler Load, AddressOf Me.SplashLoad
		Me.ResumeLayout(false)
	End Sub
	Private label1 As System.Windows.Forms.Label
End Class
