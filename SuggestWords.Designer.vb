'
' Created by SharpDevelop.
' User: IP-Man
' Date: 3/12/2016
' Time: 10:35 AM
'
Partial Class Suggest
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Suggest))
		Me.suggestbox = New System.Windows.Forms.ListBox()
		Me.label1 = New System.Windows.Forms.Label()
		Me.yesbtn = New System.Windows.Forms.Button()
		Me.nobtn = New System.Windows.Forms.Button()
		Me.SuspendLayout
		'
		'suggestbox
		'
		Me.suggestbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.suggestbox.FormattingEnabled = true
		Me.suggestbox.ItemHeight = 20
		Me.suggestbox.Location = New System.Drawing.Point(11, 37)
		Me.suggestbox.Name = "suggestbox"
		Me.suggestbox.Size = New System.Drawing.Size(354, 244)
		Me.suggestbox.TabIndex = 0
		AddHandler Me.suggestbox.DoubleClick, AddressOf Me.SuggestboxDoubleClick
		'
		'label1
		'
		Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label1.ForeColor = System.Drawing.Color.Red
		Me.label1.Location = New System.Drawing.Point(11, 9)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(305, 20)
		Me.label1.TabIndex = 1
		Me.label1.Text = "Word not found!. Did you mean : "
		'
		'yesbtn
		'
		Me.yesbtn.Location = New System.Drawing.Point(11, 289)
		Me.yesbtn.Name = "yesbtn"
		Me.yesbtn.Size = New System.Drawing.Size(170, 23)
		Me.yesbtn.TabIndex = 2
		Me.yesbtn.Text = "Yes!"
		Me.yesbtn.UseVisualStyleBackColor = true
		AddHandler Me.yesbtn.Click, AddressOf Me.Button1Click
		'
		'nobtn
		'
		Me.nobtn.Location = New System.Drawing.Point(195, 289)
		Me.nobtn.Name = "nobtn"
		Me.nobtn.Size = New System.Drawing.Size(170, 23)
		Me.nobtn.TabIndex = 3
		Me.nobtn.Text = "No"
		Me.nobtn.UseVisualStyleBackColor = true
		AddHandler Me.nobtn.Click, AddressOf Me.NobtnClick
		'
		'Suggest
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(377, 321)
		Me.Controls.Add(Me.nobtn)
		Me.Controls.Add(Me.yesbtn)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.suggestbox)
		Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
		Me.Name = "Suggest"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Word Suggestion"
		Me.ResumeLayout(false)
	End Sub
	Private nobtn As System.Windows.Forms.Button
	Private yesbtn As System.Windows.Forms.Button
	Private label1 As System.Windows.Forms.Label
	Friend suggestbox As System.Windows.Forms.ListBox
End Class
