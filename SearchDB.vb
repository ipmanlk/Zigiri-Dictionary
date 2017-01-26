'
' Created by SharpDevelop.
' User: IP-Man
' Date: 3/12/2016
' Time: 10:22 AM
'
Public Module search
	
	Dim language As Boolean 	'0 = English 1= Sinhala
	Public SearchWord As String
	Dim meaninglang As String 
	Dim count As Integer
	Dim sugWord,SearchWord1stLetter,sugWord1stLetter,DataBaseTable As String
	Public found As Boolean 
	Dim originaldbtext As String
	Public originalsearchword As String 
	Public showed As Boolean
	'0 = Mainform output box
	'1=  Suggestion form output box
	
	Public Sub SearchMeaning() 'User input word goes here.
		MainForm.input.Text = MainForm.input.Text.Trim
		SearchWord = SearchWord.Trim
		SearchWord = SearchWord.ToLower
		
		For Each c As Char In SearchWord 'Checking the language of input word.
			If AscW(c) > 3457 And AscW(c) < 3576 Then 
				GetMeaning("sndbase") 'if word is in sinhala, search on sinhala to english database.
				language = 1
				meaninglang="English"
			Else
				GetMeaning("endbase") 'if word is in english, search on english to sinhala database.
				language = 0
				meaninglang="Sinhala"
				Exit For
			End If
		Next
		
		If showed = 0 And MainForm.traymeaning.Checked = True Then 
			If found = False Then
				MainForm.trayicon.ShowBalloonTip(1000, "", "Word not found!", ToolTipIcon.Info)	
			Else 
				MainForm.trayicon.ShowBalloonTip(1000,meaninglang & " meaning for " & SearchWord , originaldbtext, ToolTipIcon.Info)
			End If
			showed = 1
		End If 
		
		If MainForm.autograb_checkbox.Checked = False Then
			If found = False  Then 'if word not found, try to suggest words.
				If language = 0 Then 
					Call SuggestWords("endbase")
				Else
					Call SuggestWords("sndbase")
				End If
				If found=False Then MsgBox("Word not found!") 'if suggestion failed, show not found msg.
			End If
		End If 
		
	End Sub
	
	Public Sub GetMeaning(dbtable As String) 'search input word through databases and show meanings.
		MainForm.output.Items.Clear 
		found = False 'Reset status of found variable
		For count = 0 To ((ds.Tables(dbtable).Rows.Count)-1)
			If ds.tables(dbtable).Rows(count).Item(0) = SearchWord Then
				originaldbtext = ds.tables(dbtable).Rows(count).Item(1)
				AddtoOutputListBox(ds.tables(dbtable).Rows(count).Item(1),0)	
				count = ((ds.Tables(dbtable).Rows.Count)-1)
			End If 
		Next 					
	End Sub
	
	Public Sub SuggestWords(dbtable As String) 'suggest words if word not found.
		For count = 0 To ((ds.Tables(dbtable).Rows.Count)-1) 'loop through words.
			sugWord = ds.tables(dbtable).Rows(count).Item(0) 'get current looping word.
			sugWord1stLetter = sugWord.Substring(0,1) 'get the first character from sugWord.
			SearchWord1stLetter = SearchWord.Substring(0,1) 'get the character letter from input word.
			
			If sugWord.Contains(SearchWord) Then 'if sugWord inclue input word
				If sugWord.Substring(0,1) = SearchWord1stLetter Then  'if it's starting from the same character
					AddtoOutputListBox(sugWord,1) 'add meanings to suggestion box
					Suggest.show
					count = ((ds.Tables(dbtable).Rows.Count)-1)
				End If
			End If 
		Next 
	End Sub
	
	Sub AddtoOutputListBox(ByVal wordlist As String, whereto As Boolean) 'Remove | & add meanings to output list boxes.	
		found = True 
		Dim zigiriadd() As String = wordlist.Split("|")
		For Each item As String In zigiriadd
			If whereto = 0 Then 'add to mainform list box.
				MainForm.output.Items.Add(item.Trim)
			Else 'add to suggestion form list box.
				Suggest.suggestbox.Items.Add(item.Trim)
			End If
		Next
	End Sub
	
End Module
