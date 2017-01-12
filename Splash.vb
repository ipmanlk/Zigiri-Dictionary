'
' Created by SharpDevelop.
' User: IP-Man
' Date: 3/4/2016
' Time: 10:26 AM
'
Public Partial Class Splash
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub SplashLoad(sender As Object, e As EventArgs)
		label1.Text = "       v" & myversion
	End Sub
End Class
