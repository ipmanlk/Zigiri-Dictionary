'
' Created by SharpDevelop.
' User: IP-Man
' Date: 5/11/2017
' Time: 9:01 AM
' 
Public Partial Class MainForm
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	
	Sub MainFormLoad(sender As Object, e As EventArgs)
		
	End Sub
	
	Sub FindBtnClick(sender As Object, e As EventArgs)
		Call FindLang(input.Text)
	End Sub
End Class
