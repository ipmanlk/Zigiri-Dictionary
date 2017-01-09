'
' Created by SharpDevelop.
' User: IP-Man
' Date: 3/12/2016
' Time: 10:22 AM
'
Public Module search
	Dim language As Boolean 
	Dim word2 As String
	Public word As String
	Dim wordsub As String 
	Dim word2sub As String 
	Dim databasetable As String 
	Dim countrows As Integer 
	'0 = English
	'1= Sinhala
	
	Public Sub SearchEnglish(word As String )
		MainForm.output.Items.Clear 
		found = False 
		For count = 0 To (MaxRows -1) 
			If ds.tables("endbase").Rows(count).Item(0) = word Then
				AddtoListbox(ds.tables("endbase").Rows(count).Item(1))
				count = (MaxRows -1)
			End If 
		Next 					
	End Sub
	
	Public Sub SearchSinhala(word As String)
		MainForm.output.Items.Clear 
		found = False 
		For count = 0 To (MaxRows2 -1) 
			If ds.tables("sndbase").Rows(count).Item(0) = word Then
				AddtoListbox(ds.tables("sndbase").Rows(count).Item(1))
				count = (MaxRows2 -1)			
			End If 
		Next 			
	End Sub
	
	Public Sub SearchMeaning(newword As String)
		newword = word.Trim
		newword = newword.ToLower
		
		For Each c As Char In newword
            If AscW(c) > 3457 And AscW(c) < 3576 Then 'Detectiong language
            	SearchSinhala(word)
            	language = 1
            Else
            	SearchEnglish(word)    
            	language = 0
               Exit For
            End If
		Next
		
		If found = False  Then 'Word suggestion 		
			If language = 0 Then
				databasetable = "endbase"
				countrows = MaxRows -1
			Else
				databasetable = "sndbase"
				countrows = MaxRows2-1
			End If
			
			For count = 0 To (countrows)
				word2 = ds.tables(databasetable).Rows(count).Item(0)	
				word2sub = word2.Substring(0,1)
				wordsub = word.Substring(0,1)
				
				If word2.Contains(word) Then
					If word2sub = wordsub Then 
						AddtoSuggestions(word2)
						Suggest.show
					End If 

				End If 
			Next 
			
			If found=False Then MsgBox("Word not found!") 'If suggestion failed, not found.		
			
		End If
	End Sub
	
	Sub AddtoListbox(ByVal str As String)	
		found = True 
		Dim zigiriadd() As String = str.Split("|")
        For Each item As String In zigiriadd
            MainForm.output.Items.Add(item.Trim)
        Next
	End Sub
	
	 Sub AddtoSuggestions(ByVal str As String)	
		found = True 
		Dim zigiriadd() As String = str.Split("|")
        For Each item As String In zigiriadd
           Suggest.suggestbox.Items.Add(item.Trim)
        Next
        
	End Sub
	
End Module
