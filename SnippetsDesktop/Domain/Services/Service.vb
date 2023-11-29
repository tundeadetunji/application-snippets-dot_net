'from iNovation
Imports iNovation.Code.General
Imports iNovation.Code.Desktop

Module Service
#Region "File Paths Variables"
    Private ReadOnly Property app_data_directory As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\iNovation Digital Works\Snippets"
    Private ReadOnly Property settings_sounds_file As String = app_data_directory & "\Sounds.txt"

#End Region

#Region "IO"
    Public ReadOnly Property SoundsOn As Boolean
        Get
            Return Boolean.Parse(ReadText(settings_sounds_file))
        End Get
    End Property

    Public Sub UpdateSoundsOn(state As Boolean)
        WriteText(settings_sounds_file, state, False, False)
    End Sub

#End Region

#Region "App Specific Fields"
    Public Property target_ As String

#End Region


#Region "Main"

    Public Function ReactText(s As String) As String
        If s.Length < 1 Then Return ""
        Return s.Replace("class", "className")
    End Function

#End Region


End Module
