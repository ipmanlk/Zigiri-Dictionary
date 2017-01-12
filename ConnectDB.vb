'
' Created by SharpDevelop.
' User: IP-Man
' Date: 3/4/2016
' Time: 8:28 AM
'
Imports System.Data.Oledb 
Imports System.IO 
Public Module ConnectDB
	Public ds As New System.Data.DataSet() 
	Dim DBProvider As String = "PROVIDER=Microsoft.Jet.OLEDB.4.0;"
	Dim DataSource As String = "Data Source=" & Path.GetTempPath & "\endbase.mdb;"
	Dim Pass As String = "Jet OLEDB:Database Password=nqq1fdst;"	
	Dim con As New OledbConnection 	
	Dim sql As String = "SELECT * FROM WORD" 
	Dim  da As New OleDbDataAdapter(sql,con)
	
	Public Sub ConnectDatabse() 'Connect with databases.
		con.ConnectionString = DBProvider & DataSource & Pass
		con.Open() 'Opening the Connection	
		da.Fill(ds,"endbase") 'adding english to sinhala table to dataset.	
		con.Close 'Closing the connection
		
		DataSource = "Data Source=" & Path.GetTempPath & "\sndbase.mdb;"
		sql =  "SELECT * FROM VACHANA"
		Dim da2 As New OleDbDataAdapter(sql,con)
		con.ConnectionString = DBProvider & DataSource & Pass
		con.Open() 
		da2.Fill(ds,"sndbase") 'adding sinhala to english table to dataset.
		con.Close 
	End Sub
	
	Public Sub ExtractDatabase
		Dim ms1 As New IO.MemoryStream(My.Resources.endbase)
		Dim fs1 As IO.FileStream = IO.File.OpenWrite(Path.GetTempPath & "\endbase.mdb")
		ms1.WriteTo(fs1)
		fs1.Close()
		ms1.Close()
		
		Dim ms2 As New IO.MemoryStream(My.Resources.sndbase)
		Dim fs2 As IO.FileStream = IO.File.OpenWrite(Path.GetTempPath & "\sndbase.mdb")
		ms2.WriteTo(fs2)
		fs2.Close()
		ms2.Close()
		
		ConnectDatabse()
	End Sub		
End Module
