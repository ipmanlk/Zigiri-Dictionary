'
' Created by SharpDevelop.
' User: IP-PC
' Date: 5/11/2017
' Time: 9:32 AM
'
Imports System.IO 
Public Module Search
	Dim langfile As String 
	Dim found As Boolean
	Public suggest As Boolean
	Public errorshow As Boolean
	
	Sub SearchMeaning(SearchWord As String)
		MainForm.output.Items.Clear	
		MainForm.meaningGrp.Text="Meaning"
		
		For Each c As Char In SearchWord 'Checking the language of input word.
			If AscW(c) > 3457 And AscW(c) < 3576 Then 
 				langfile="sn2en"
			Else
				langfile="en2sn"
			End If
		Exit For
		Next
		
		For Each Line As String In File.ReadLines(langfile)
		If (Line.Split("-")(0))=SearchWord Then
			AddtoOutputListBox(Line.Split("-")(1))
			found=True
			suggest=False
			Exit For
		Else 
			found=False
		End If	
		Next
		
		If langfile="sn2en" Then 
			For Each Line As String In File.ReadLines("en2sn")
				If (Line.Split("-")(1)).Contains(SearchWord) Then
					AddtoOutputListBox(Line.Split("-")(0))
					found=True
					suggest=False
					Exit For
				End If
			Next	
		End If
		
		If (found=False And errorshow=True) Then 
			MsgBox("Word not found!. Please check for word suggestions.",vbOKOnly,"Sorry!")
			suggest=True
			Call Suggestions(SearchWord)
		End If
		
	End Sub
	
	
	Sub Suggestions(SearchWord As String)
		MainForm.meaningGrp.Text="Word Suggestions"
		For Each Line As String In File.ReadLines(langfile)
			If (Line.Split("-")(0)).Contains(SearchWord) Or SearchWord.Contains(Line.Split("-")(0)) And (Line.Split("-")(0)).Substring(0,1)=SearchWord.Substring(0,1) Then
				AddtoOutputListBox(Line.Split("-")(0))
			End If	
		Next
		
	End Sub
	
	Sub AddtoOutputListBox(ByVal wordlist As String) 'Remove | & add meanings to output list boxes.	
		Dim zigiriadd() As String = wordlist.Split("|")
		For Each item As String In zigiriadd
			If Not(String.IsNullOrEmpty(item.Trim)) Then 
				MainForm.output.Items.Add(item.Trim())
			End If
		Next
	End Sub
	
End Module
