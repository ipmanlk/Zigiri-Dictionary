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
		SearchWord = suggestbox.Text
		MainForm.input.Text = SearchWord
		SearchMeaning()
		Me.Close
	End Sub
	
	Sub NobtnClick(sender As Object, e As EventArgs)
		Me.Close
	End Sub
End Class
