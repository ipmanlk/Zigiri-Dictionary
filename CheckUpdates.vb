'
' Created by SharpDevelop.
' User: IP-Man
' Date: 3/12/2016
' Time: 10:23 AM
'
Public Module CheckUpdates
	Public Sub CheckforUpdate()
		Try
            Using client = New System.Net.WebClient()
                Using stream = client.OpenRead("http://www.google.com")
                    Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://www.navinda.space/updates/zigiri_dictionary/latest_version.txt")
                    Dim response As System.Net.HttpWebResponse = request.GetResponse()
                    Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
                    Dim newestversion As String = sr.ReadToEnd()
                    Dim currentversion As String = "0.1.0"
                    If newestversion.Contains(currentversion) Then
                    	MessageBox.Show("You have the current version! (v" & currentversion & ")")
                    	MainForm.checking_updates.Visible=False
                    Else
                    	Dim choice As Integer = MessageBox.Show("Newer version available! " & "(v" & newestversion & ")" & ". Do you want to download it?", "Update Check", MessageBoxButtons.YesNo)
                    	
                    	If choice = DialogResult.Yes Then
                    		MainForm.checking_updates.Visible=False
                    		Process.Start("https://www.navinda.space/files/zigiri_dictionary/" & newestversion & "/zigiri_dictionary.7z")
                    	Else 
                    		MainForm.checking_updates.Visible=False
                    	End If
    
                    End If
                End Using
            End Using
		Catch
			MainForm.checking_updates.Visible=False
            MsgBox("Internet connection is not available or something went wrong!")
        End Try
	End Sub
End Module
