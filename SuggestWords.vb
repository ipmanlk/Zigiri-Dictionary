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
		Call WordSuggested
	End Sub
	
	Sub NobtnClick(sender As Object, e As EventArgs)
		Me.Close
	End Sub
	
	
	Sub SuggestboxDoubleClick(sender As Object, e As EventArgs)
		Call WordSuggested
	End Sub
	
	Sub WordSuggested()
		SearchWord = suggestbox.Text
		If String.IsNullOrEmpty(suggestbox.Text) Then
			MsgBox("Please select your word first!")
		Else
			MainForm.input.Text = SearchWord
			SearchMeaning()
			Me.Close
		End If
	End Sub
End Class
