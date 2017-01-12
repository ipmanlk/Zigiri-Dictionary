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
		If My.Computer.FileSystem.FileExists(Path.GetTempPath & "\endbase.mdb") Then
			Call ConnectDatabse()
		Else 
			Call ExtractDatabase()
		End If
	End Sub
	
	Sub FindClick(sender As Object, e As EventArgs)
		SearchWord = input.Text
		Call SearchMeaning()
	End Sub
	
	Sub InputKeyPress(sender As Object, e As KeyPressEventArgs)
		If e.KeyChar = ChrW(Keys.Enter) Then
			SearchWord = input.Text
			Call SearchMeaning()
		End If
	End Sub
	
	Sub CheckForUpdatesToolStripMenuItemClick(sender As Object, e As EventArgs)
		checking_updates.Visible=True
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
	
	Sub AboutToolStripMenuItemClick(sender As Object, e As EventArgs)
		MsgBox("Version " & myversion & vbNewLine & "Created By Navinda Dissanayake." & 
			vbNewLine & "Visit : www.navinda.space for more information.")	
	End Sub
End Class
