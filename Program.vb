'
' Created by SharpDevelop.
' User: IP-Man
' Date: 3/3/2016
' Time: 9:53 PM
'
Imports Microsoft.VisualBasic.ApplicationServices

Namespace My
	' This file controls the behaviour of the application.
	Partial Class MyApplication
		Public Sub New()
			MyBase.New(AuthenticationMode.Windows)
			Me.IsSingleInstance = False
			Me.EnableVisualStyles = True
			Me.SaveMySettingsOnExit = True
			Me.ShutDownStyle = ShutdownMode.AfterMainFormCloses
		End Sub
		
		Protected Overrides Sub OnCreateMainForm()
			Me.MainForm = My.Forms.MainForm
		End Sub
		
	    Protected Overrides Sub OnCreateSplashScreen()
            Me.SplashScreen = My.Forms.Splash
        End Sub
	End Class
End Namespace
