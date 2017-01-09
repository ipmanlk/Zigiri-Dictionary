'
' Created by SharpDevelop.
' User: IP-Man
' Date: 3/12/2016
' Time: 10:35 AM
'
Public Partial Class Suggest
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	
	
	Sub Button1Click(sender As Object, e As EventArgs)
		word = suggestbox.Text
		MainForm.input.Text = word 
		SearchMeaning(word)
		Me.Close
	End Sub
	
	Sub NobtnClick(sender As Object, e As EventArgs)
		Me.Close
	End Sub
End Class
