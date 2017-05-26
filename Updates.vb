'
' Created by SharpDevelop.
' User: IP-Man
' Date: 5/26/2017
' Time: 3:30 PM
' 
'
Public Module Updates
	Public myversion As String = "0.3.0"
	Public Sub CheckforUpdates()
		Try
			Using client = New System.Net.WebClient()
				Using stream = client.OpenRead("http://www.google.com")
					Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://www.navinda.space/updates/zigiri_dictionary/latest_version.txt")
					Dim response As System.Net.HttpWebResponse = request.GetResponse()
					Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
					Dim newestversion As String = sr.ReadToEnd()
					If newestversion.Contains(myversion) Then
						MessageBox.Show("You have the current version! (v" & myversion & ")")
					Else
						Dim choice As Integer = MessageBox.Show("Newer version available! " & "(v" & newestversion & ")" & ". Do you want to download it?", "Update Check", MessageBoxButtons.YesNo)
						
						If choice = DialogResult.Yes Then
							Process.Start("http://www.navinda.space/files/zigiri_dictionary/" & newestversion & "/zigiri_dictionary.7z")
						End If
						
					End If
				End Using
			End Using
		Catch
			MsgBox("Internet connection is not available or something went wrong!")
		End Try
	End Sub
End Module
