'
' Created by SharpDevelop.
' User: IP-PC
' Date: 5/11/2017
' Time: 9:32 AM
'
Imports System.IO 
Public Module Search
	Dim langfile As String 
	
	Sub FindLang(SearchWord As String)
		For Each c As Char In SearchWord 'Checking the language of input word.
			If AscW(c) > 3457 And AscW(c) < 3576 Then 
 				langfile="sn2en"
			Else
				langfile="en2sn"
				Exit For
			End If
		Next
		SearchMeaning(SearchWord)
	End Sub
	
	Sub SearchMeaning(Word As String)
		For Each Line As String In File.ReadLines(langfile)
			If Line.Split("-")(0) = Word Then
				AddtoOutputListBox(Line.Split("-")(1))
				Exit For
			End If
		Next
	End Sub
	
	Sub AddtoOutputListBox(ByVal wordlist As String) 'Remove | & add meanings to output list boxes.	
		MainForm.output.Items.Clear
		Dim zigiriadd() As String = wordlist.Split("|")
		For Each item As String In zigiriadd	
			MainForm.output.Items.Add(item.Trim())
		Next
	End Sub
	
End Module
