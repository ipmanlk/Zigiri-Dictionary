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
		showed = 0
		SearchWord = input.Text
		Call SearchMeaning()
	End Sub
	
	Sub InputKeyPress(sender As Object, e As KeyPressEventArgs)
		If e.KeyChar = ChrW(Keys.Enter) Then
			showed = 0
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
		MsgBox("Version " & myversion & vbNewLine & "Developed By Navinda Dissanayake." & 
			vbNewLine & "Visit : www.navinda.space for more information.")	
	End Sub
	
	Sub OutputMouseDown(sender As Object, e As MouseEventArgs)
		If e.Button = MouseButtons.Right Then
			rightclickmenu.Show(MousePosition)
		End If 
	End Sub
	
	Sub CopyToolStripMenuItemClick(sender As Object, e As EventArgs)
		If String.IsNullOrEmpty(output.Text) Then 
			MsgBox("Please select an item to copy!")
		Else 
			Clipboard.SetText(output.Text)
		End If
	End Sub 
	
	Sub Autograb_checkboxCheckedChanged(sender As Object, e As EventArgs)
		If autograb_checkbox.Checked = True Then
			autograb.Enabled = True
		Else
			autograb.Enabled = False
		End If
	End Sub
	
	Sub AutograbTick(sender As Object, e As EventArgs)
		If String.IsNullOrEmpty(Clipboard.GetText)=False And String.IsNullOrEmpty(input.Text)=False Then 
			SearchWord = Clipboard.GetText
			originalsearchword = input.Text 
			If SearchWord <> input.Text Then
				input.Text = SearchWord
				showed=0
				Call SearchMeaning
			End If 
		End If 
	End Sub
	
	Sub TraymeaningCheckedChanged(sender As Object, e As EventArgs)
		If traymeaning.Checked = True Then 
			Me.Height = 144
		Else 
			Me.Height = 358
		End If
	End Sub
End Class
