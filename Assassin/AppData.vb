Imports System.IO

Public Class AppData

    Public Shared Location As String = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Assassin")

End Class