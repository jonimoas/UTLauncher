Option Strict Off
Option Explicit On
Friend Class Form1
	Inherits System.Windows.Forms.Form
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		Dim nfile As Object
		Kill("batch.bat")
		'UPGRADE_WARNING: Couldn't resolve default property of object nfile. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		nfile = FreeFile
		'UPGRADE_WARNING: Couldn't resolve default property of object nfile. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FileOpen(nfile, CurDir() & "\batch.BAT", OpenMode.Append)
		'UPGRADE_WARNING: Couldn't resolve default property of object nfile. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		PrintLine(nfile, "system\unreal.exe " & File1.FileName & "?spectatoronly=false?numbots=" & botnum.Text & "?quickstart=true")
		'UPGRADE_WARNING: Couldn't resolve default property of object nfile. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FileClose(nfile)
		Shell("batch.bat")
	End Sub
	Private Sub Form1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		File1.Path = CurDir() & "\maps"
	End Sub
End Class