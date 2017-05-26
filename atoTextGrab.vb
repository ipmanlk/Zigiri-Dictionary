'
' Created by SharpDevelop.
' User: IP-Man
' Date: 5/26/2017
' Time: 2:17 PM
' 
'
Public Module atoTextGrab
	
	Sub atoGrabText()
		Dim clipText As String = Clipboard.GetText 
		Dim defText As String
		
		If (clipText<>defText And clipText<>"none") Then 
			clipText=clipText.Trim
			Call SearchMeaning(clipText)
			MainForm.input.Text=clipText
			defText=clipText
			clipText="none"
			Clipboard.SetText("none")
		End If
	End Sub
	
End Module
