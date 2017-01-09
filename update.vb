'
' Created by SharpDevelop.
' User: IP-Man
' Date: 3/12/2016
' Time: 10:23 AM
'
Public Module update
	Public Sub CheckforUpdate()
		Try
            Using client = New System.Net.WebClient()
                Using stream = client.OpenRead("http://www.google.com")
                    Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("https://svn.code.sf.net/p/zigiri-dictionary/code/update/version.txt")
                    Dim response As System.Net.HttpWebResponse = request.GetResponse()

                    Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())

                    Dim newestversion As String = sr.ReadToEnd()
                    Dim currentversion As String = "0.3c"

                    If newestversion.Contains(currentversion) Then
                        MessageBox.Show("You have the current version!")
                    Else
                        MessageBox.Show("Newer version available! Visit https://sourceforge.net/projects/zigiri-dictionary/ to download it.")
                    End If
                End Using
            End Using
        Catch
            MsgBox("Internet connection is not available!")
        End Try
	End Sub
End Module
