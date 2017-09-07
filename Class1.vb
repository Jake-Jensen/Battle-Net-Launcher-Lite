Imports System.IO
Imports System.Net
Imports System.Text
Class Web_update
    Dim version As String
    Public Shared Downuri As String
    Public Shared Sub Main()
        Dim URI As String
        '
        'REPLACE Program WITH YOUR APPLICATIONS NAME.
        '
        'REMEMBER TO EDIT FILEVERSION IN ASSEMBLY INFORMATION
        '
        '
        'Edit URI to your version.html-file. 
        URI = "https://raw.githubusercontent.com/SapphireExile/Battle-Net-Launcher-Lite/master/CurrentVersion"
        'Edit URI to your programs zip-file
        Downuri = "https://github.com/SapphireExile/Battle-Net-Launcher-Lite/archive/master.zip"

        Dim wr As HttpWebRequest = CType(WebRequest.Create(URI.ToString), HttpWebRequest)
        Dim ws As HttpWebResponse = CType(wr.GetResponse(), HttpWebResponse)
        Dim str As Stream = ws.GetResponseStream()
        Dim inBuf(100000) As Byte
        Dim bytesToRead As Integer = CInt(inBuf.Length)
        Dim bytesRead As Integer = 0
        While bytesToRead > 0
            Dim n As Integer = str.Read(inBuf, bytesRead, bytesToRead)
            If n = 0 Then
                Exit While
            End If
            bytesRead += n
            bytesToRead -= n
        End While
        Dim fstr As New FileStream("version.txt", FileMode.OpenOrCreate, FileAccess.Write)
        fstr.Write(inBuf, 0, bytesRead)
        str.Close()
        fstr.Close()
        Dim sr As StreamReader = New System.IO.StreamReader("version.txt")
        Dim version As Integer = CInt(sr.ReadToEnd.Replace(".", "").Substring(0, 4))
        sr.Close()
        MessageBox.Show("Testing.", "Update test",
MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
    End Sub 'Main
End Class 'Web_update