Imports iNovation.Code.General
Imports iNovation.Code.Desktop

Imports iNCode.DotNetCore
Public Class WebSection

    Private s As New iNovation.iNCode.DotNetCore

    Private Property nuget_packages_batch As String

    Private Sub WebSection_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FileMinimumLevel.DataSource = s.FileLoggingLevel_List
        ConsoleMinimumLevel.DataSource = s.ConsoleLoggingLevel_List
        SeqMinimumLevel.DataSource = s.SeqLoggingLevel_List
        ConsoleOutputTemplate.DataSource = s.ConsoleOutputTemplate_List
        FileOutputTemplate.DataSource = s.FileOutputTemplate_List

    End Sub

    Private Sub buttonSnippet_Click(sender As Object, e As EventArgs) Handles buttonSnippet.Click
        'EnableControl(sender, False)
        If IsEmpty({Seq, File, Console}, ControlsToCheck.All) Then Return

        If IsEmpty(Console) = False Then
            If IsEmpty(ConsoleMinimumLevel) Or IsEmpty(ConsoleOutputTemplate) Then Return
        End If

        If IsEmpty(File) = False Then
            If IsEmpty(FileMinimumLevel) Or IsEmpty(FileOutputTemplate) Or IsEmpty(FileName) Then Return
        End If


        If IsEmpty(Seq) = False Then
            If IsEmpty(SeqMinimumLevel) Or IsEmpty(SeqServerURL) Then Return
        End If



        GetSnippets()

        Clear({FileName, SeqServerURL})
        'EnableControl(sender)

    End Sub

    Private Sub GetSnippets()
        Dim d As Dictionary(Of String, Object) = s.LoggingSnippets(Content(Console), Content(ConsoleMinimumLevel), Content(ConsoleOutputTemplate), Content(File), Content(FileName), Content(FileMinimumLevel), Content(FileOutputTemplate), Content(Seq), Content(SeqMinimumLevel), Content(SeqServerURL))
        PageModelField.Text = d.Item("page_model_field")
        Usage.Text = d.Item("usage")
        PageModelConstructor.Text = d.Item("page_model_constructor")
        AppSettings.Text = d.Item("app_settings")
        UsingStatement.Text = d.Item("using_statement")
        nuget_packages_batch = d.Item("nuget_packages_batch")
        ListsClearList(NugetPackages)
        If NugetPackages.Items.Count < 1 Then
            Clear(NugetPackages)
            NugetPackages.DataSource = d.Item("nuget_packages")
        End If
    End Sub


    'Private Sub MinimumLevel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FileMinimumLevel.KeyPress, ConsoleMinimumLevel.KeyPress, ConsoleOutputTemplate.KeyPress, FileOutputTemplate.KeyPress, SeqMinimumLevel.KeyPress, NugetPackages.KeyPress
    '    'AllowNothing(e)
    'End Sub

    Private Sub buttonCopyPageModelField_Click(sender As Object, e As EventArgs) Handles buttonCopyPageModelField.Click
        'EnableControl(sender, False)
        If IsEmpty(PageModelField) = False Then Clipboard.SetText(Content(PageModelField))
        'EnableControl(sender)
    End Sub

    Private Sub buttonCopyUsage_Click(sender As Object, e As EventArgs) Handles buttonCopyUsage.Click
        'EnableControl(sender, False)
        If IsEmpty(Usage) = False Then Clipboard.SetText(Content(Usage))
        'EnableControl(sender)
    End Sub

    Private Sub buttonCopyPageModelConstructor_Click(sender As Object, e As EventArgs) Handles buttonCopyPageModelConstructor.Click
        'EnableControl(sender, False)
        If IsEmpty(PageModelConstructor) = False Then Clipboard.SetText(Content(PageModelConstructor))
        'EnableControl(sender)
    End Sub

    Private Sub buttonCopyAppSettings_Click(sender As Object, e As EventArgs) Handles buttonCopyAppSettings.Click
        'EnableControl(sender, False)
        If IsEmpty(AppSettings) = False Then Clipboard.SetText(Content(AppSettings))
        'EnableControl(sender)
    End Sub

    Private Sub buttonCopyNugetPackages_Click(sender As Object, e As EventArgs) Handles buttonCopyNugetPackages.Click
        'EnableControl(sender, False)
        If IsEmpty(NugetPackages) = False Then Clipboard.SetText(Content(NugetPackages))
        'EnableControl(sender)
    End Sub

    Private Sub buttonCopyUsing_Click(sender As Object, e As EventArgs) Handles buttonCopyUsing.Click
        'EnableControl(sender, False)
        If IsEmpty(UsingStatement) = False Then Clipboard.SetText(Content(UsingStatement))
        'EnableControl(sender)
    End Sub

    Private Sub buttonCopyNugetPackage_Click(sender As Object, e As EventArgs) Handles buttonCopyNugetPackage.Click
        'EnableControl(sender, False)
        If nuget_packages_batch.Length > 0 Then Clipboard.SetText(nuget_packages_batch)
        'EnableControl(sender)
    End Sub

End Class