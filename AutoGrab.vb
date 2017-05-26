'
' Created by SharpDevelop.
' User: IP-Man
' Date: 5/26/2017
' Time: 2:17 PM
' 
'
Public Module AutoGrab
	
	Sub atoGrabText()
		Clipboard.SetText((Clipboard.GetText.Trim).ToLower)
		Dim clipText As String = Clipboard.GetText 
		Dim defText As String
		
		If (MainForm.input.Text<>clipText) Then 
			clipText=clipText.Trim
			defText=clipText
			Call SearchMeaning(clipText)
			MainForm.input.Text=clipText
		End If
	End Sub
	
End Module
