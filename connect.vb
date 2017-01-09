'
' Created by SharpDevelop.
' User: IP-Man
' Date: 3/4/2016
' Time: 8:28 AM
'
Imports System.Data.Oledb 
Imports System.IO 
Public Module Comp	
    Public found As Boolean 
	Public count As Integer
	Public ds As New System.Data.DataSet() 'Dataset
	Public MaxRows As Integer 'Maximum Number of Rows in the table 
	Public MaxRows2 As Integer 'Maximum Number of Rows in the table2 
	Dim DBProvider As String = "PROVIDER=Microsoft.Jet.OLEDB.4.0;"
	Dim DataSource As String = "Data Source=" & Path.GetTempPath & "\endbase.mdb;"
	Dim Pass As String = "Jet OLEDB:Database Password=nqq1fdst;"	
	Dim con As New OledbConnection 'Connection		
	Dim sql As String = "SELECT * FROM WORD" 'SQL CODE
	Dim  da As New OleDbDataAdapter(sql,con)
	
	Public Sub ConnectDatabse()
		con.ConnectionString = DBProvider & DataSource & Pass
		con.Open() 'Opening the Connection	
		da.Fill(ds,"endbase") 'Filling the dataset	
		MaxRows = ds.Tables("endbase").Rows.Count
		con.Close 'Closing the connection
		
		DataSource = "Data Source=" & Path.GetTempPath & "\sndbase.mdb;"
		sql =  "SELECT * FROM VACHANA"
		Dim da2 As New OleDbDataAdapter(sql,con)
		con.ConnectionString = DBProvider & DataSource & Pass
		con.Open() 'Opening the Connection
		da2.Fill(ds,"sndbase") 'Filling the dataset	
		MaxRows2 = ds.Tables("sndbase").Rows.Count
		con.Close 'Closing the connection
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
