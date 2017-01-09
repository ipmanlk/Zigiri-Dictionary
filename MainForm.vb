'
' Created by SharpDevelop.
' User: IP-Man
' Date: 3/3/2016
' Time: 9:53 PM
'
Imports System.IO 
Public Partial Class MainForm
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
		
	Sub MainFormLoad(sender As Object, e As EventArgs)
		Call ExtractDatabase()
	End Sub
	
	Sub FindClick(sender As Object, e As EventArgs)
		word = input.Text
		Call SearchMeaning(word)
	End Sub
	
	
	Sub MainFormFormClosed(sender As Object, e As FormClosedEventArgs)
		My.Computer.FileSystem.DeleteFile(Path.GetTempPath & "\endbase.mdb")
		My.Computer.FileSystem.DeleteFile(Path.GetTempPath & "\sndbase.mdb")
	End Sub
	
	Sub InputKeyPress(sender As Object, e As KeyPressEventArgs)
	 	If e.KeyChar = ChrW(Keys.Enter) Then
        	word = input.Text
			Call SearchMeaning(word)
        End If
	End Sub
	
	Sub CheckForUpdatesToolStripMenuItemClick(sender As Object, e As EventArgs)
		CheckforUpdate()
	End Sub
	
	Sub MainFormResize(sender As Object, e As EventArgs)
		  If Me.WindowState = FormWindowState.Minimized Then
		  
        	Me.Visible = False
       		trayicon.ShowBalloonTip(1000, "", "Zigiri Dictionary is here!", ToolTipIcon.Info)
    	  End If
	End Sub
	
	
	Sub TrayiconMouseClick(sender As Object, e As MouseEventArgs)
		Me.Show
		Me.WindowState = FormWindowState.Normal 
	End Sub
	
	
End Class
