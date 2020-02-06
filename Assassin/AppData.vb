Imports System.IO

Public Class AppData

    Public Shared Location As String = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "PF Software", "Assassin")

End Class