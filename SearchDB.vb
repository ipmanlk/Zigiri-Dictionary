'
' Created by SharpDevelop.
' User: IP-Man
' Date: 3/12/2016
' Time: 10:22 AM
'
Public Module search
	
	Dim language As Boolean 	'0 = English 1= Sinhala
	Public SearchWord As String
	Dim count As Integer
	Dim sugWord,SearchWord1stLetter,sugWord1stLetter,DataBaseTable As String
	Public found As Boolean 
	'0 = Mainform output box
	'1=  Suggestion form output box
	
	Public Sub SearchMeaning() 'User input word goes here.
		SearchWord = SearchWord.Trim
		SearchWord = SearchWord.ToLower
		
		For Each c As Char In SearchWord 'Checking the language of input word.
            If AscW(c) > 3457 And AscW(c) < 3576 Then 
            	GetMeaning("sndbase") 'if word is in sinhala, search on sinhala to english database.
            	language = 1
            Else
            	GetMeaning("endbase") 'if word is in english, search on english to sinhala database.
            	language = 0
               Exit For
            End If
		Next
		
		If found = False  Then 'if word not found, try to suggest words.
			If language = 0 Then 
				Call SuggestWords("endbase")
			Else
				Call SuggestWords("sndbase")
			End If
				
			If found=False Then MsgBox("Word not found!") 'if suggestion failed, show not found msg.		
			
		End If
	End Sub
	
	Public Sub GetMeaning(dbtable As String) 'search input word through databases and show meanings.
		MainForm.output.Items.Clear 
		found = False 'Reset status of found variable
		For count = 0 To ((ds.Tables(dbtable).Rows.Count)-1)
			If ds.tables(dbtable).Rows(count).Item(0) = SearchWord Then
				AddtoOutputListBox(ds.tables(dbtable).Rows(count).Item(1),0)		
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
