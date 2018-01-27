'
' Created by SharpDevelop.
' User: IP-PC
' Date: 5/11/2017
' Time: 9:32 AM
'
Imports System.IO 
Public Module Search
	Dim langfile,meaninglang,sWord As String 
	Dim found As Boolean
	Public suggest As Boolean
	Public errorshow As Boolean=True
	Public tm As Boolean=False
	
	Sub SearchMeaning(SearchWord As String)
		MainForm.output.Items.Clear	
		MainForm.meaningGrp.Text="Meaning"
		sWord=SearchWord
		SearchWord=SearchWord.Replace(" ","-")
		
		For Each c As Char In SearchWord 'Checking the language of input word.
			If AscW(c) > 3457 And AscW(c) < 3576 Then 
				langfile="db/sn2en.txt"
				My.Forms.MainForm.Text="ZD-Sinhala to English"
				meaninglang="English"
			Else
				langfile="db/en2sn.txt"
				My.Forms.MainForm.Text="ZD-English to Sinhala"
				meaninglang="Sinhala"
			End If
			Exit For
		Next
		
		'Search the meaning
		For Each Line As String In File.ReadLines(langfile)
			If ((Line.Split("#")(0)).ToLower)=SearchWord Then
				found=True
				AddtoOutputListBox(Line.Split("#")(1))
				suggest=False
				Exit For
			Else 
				found=False
			End If	
		Next
		
		'If word is not found
		If (found=False And errorshow=True) Then 
			If tm=False Then 
				MsgBox("Word not found!. Please check for word suggestions.",vbOKOnly,"Sorry!")
				suggest=True
				Call Suggestions(SearchWord) 'Show suggestions
			Else 
				MainForm.notifyIcon.ShowBalloonTip(1000, "Zigiri Dictionary", "Word not found!", ToolTipIcon.Info)	
			End If 
		End If
	End Sub
	
	'Suggestions if input word is not found
	Sub Suggestions(SearchWord As String)
		MainForm.meaningGrp.Text="Word Suggestions"
		Dim current_word As String
		Dim current_word_char As Char 'first character of current word
		Dim search_word_char As Char=SearchWord(0) 'first character of search word
		
		For Each Line As String In File.ReadLines(langfile)
			current_word=Line.Split("#")(0)
			If (current_word.Contains(SearchWord)) Then
				current_word_char=current_word(0)
				If (current_word_char=search_word_char) Then
					AddtoOutputListBox(Line.Split("#")(0))
				End If
			End If
		Next
		
	End Sub
	
	Sub AddtoOutputListBox(ByVal wordlist As String) 'Remove | & add meanings to output list boxes.			
		'if tray meaning is enabled
		If tm=True Then
			MainForm.notifyIcon.ShowBalloonTip(1000,meaninglang & " meaning for " & sWord , wordlist, ToolTipIcon.Info)
			
			'if tray meaning is disabled
		Else
			Dim zigiriadd() As String = wordlist.Split("|")
			For Each item As String In zigiriadd
				If Not(String.IsNullOrEmpty(item.Trim)) Then 
					MainForm.output.Items.Add(item.Trim())
				End If
			Next
		End If
	End Sub
	
End Module
