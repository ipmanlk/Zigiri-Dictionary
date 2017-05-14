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
		Call SearchMeaning(input.Text.Trim)
	End Sub
	
	Sub OutputDoubleClick(sender As Object, e As EventArgs)
		If suggest=True Then 
			input.Text=output.SelectedItem.ToString
			suggest=False
			Call SearchMeaning(output.SelectedItem.ToString)
		End If 
	End Sub
End Class
