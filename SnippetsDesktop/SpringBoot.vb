#Region "Imports"

'from iNovation

Imports iNovation.iNCode.Converter
Imports iNovation.iNCode.Docs
Imports iNovation.iNCode.Snippets
Imports iNovation.iNCode.Startup
Imports Microsoft.VisualBasic.Devices
Imports System.Collections.ObjectModel
Imports iNovation.iNCode.AndroidUIComposition
Imports iNovation.Code.General
Imports iNovation.Code.Desktop
Imports iNovation.iNCode.Spring
#End Region
Public Class SpringBoot
    Private f As New iNovation.Code.Feedback
    Private Property UIHasLoaded As Boolean = False

    Private Sub SpringBoot_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Values()
    End Sub
    Private Sub Values()
        BindProperty(dropSection, SpringBootFileIs_List)
        BindProperty(dropType, TypeIs_List)

        textResourcesFolder.Text = My.Application.Info.DirectoryPath & "\Files"

        UIHasLoaded = True
    End Sub
    Private Sub dropSection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dropSection.SelectedIndexChanged
        If Not UIHasLoaded Then Return
        If ListsIsEmpty(sender) Then Return
        Dim s As New iNovation.iNCode.Spring(Content(textPackage), Content(textEntity), DropToList(dropFields), DropToList(dropTypes))
        Dim result As String = ""
        textSnippet.Text = ""
        Dim selection = Content(dropSection)
        Try
            If selection = SpringBootFileIs.ApplicationProperties.ToString Then
                If IsEmpty({textUsername, textPassword}, ControlsToCheck.Any) Then
                    f.say("username and password fields are required")
                    If IsEmpty(textUsername) Then
                        textUsername.Focus()
                    Else
                        textPassword.Focus()
                    End If
                    Return
                End If
                result = s.applicationProperties(Content(textUsername), Content(textPassword))
            ElseIf selection = SpringBootFileIs.APIController.ToString Then
                result = s.apiController
            ElseIf selection = SpringBootFileIs.ErrorController.ToString Then
                result = s.errorController
            ElseIf selection = SpringBootFileIs.UIController.ToString Then
                result = s.uiController
            ElseIf selection = SpringBootFileIs.Contracts.ToString Then
                result = s.contracts
            ElseIf selection = SpringBootFileIs.Application.ToString Then
                result = s.application
            ElseIf selection = SpringBootFileIs.ErrorPage.ToString Then
                result = s.errorPage
            ElseIf selection = SpringBootFileIs.IncludesBTT.ToString Then
                result = s.includesBTT
            ElseIf selection = SpringBootFileIs.IncludesFooter.ToString Then
                result = s.includesFooter
            ElseIf selection = SpringBootFileIs.IncludesJS.ToString Then
                result = s.includesJS
            ElseIf selection = SpringBootFileIs.IncludesNav.ToString Then
                result = s.includesNav
            ElseIf selection = SpringBootFileIs.Index.ToString Then
                result = s.index
            ElseIf selection = SpringBootFileIs.Models.ToString Then
                If ListsContain(dropFields, "id") Then
                    f.say("ID field cannot be included because it is already part of the default fields. please remove the id field")
                    Return
                End If
                If dropFields.Items.Count <> dropTypes.Items.Count Then
                    f.say("some fields appear not to have their types selected. ensure every field has its type selected")
                    Return
                End If
                If ListsIsEmpty({dropFields, dropTypes}) Then
                    f.say("fields weren't included. using default feilds")
                End If
                result = s.model
            ElseIf selection = SpringBootFileIs.NewHTMLPage.ToString Then
                If IsEmpty(textTitle) Then f.say("title of the page wasn't specified. using empty string as title")
                result = s.newHTMLPage(Content(textTitle))
            ElseIf selection = SpringBootFileIs.Repositories.ToString Then
                result = s.repositories
            ElseIf selection = SpringBootFileIs.Services.ToString Then
                result = s.services
            ElseIf selection = SpringBootFileIs.UIController.ToString Then
                result = s.uiController
            ElseIf selection = SpringBootFileIs.Resources.ToString Then
                If IsEmpty({textMainFolder}) Then
                    f.say("please set location for main folder")
                    textMainFolder.Focus()
                    Return
                End If
                If IsEmpty({textResourcesFolder}) Then
                    f.say("please set location for resources folder")
                    textResourcesFolder.Focus()
                    Return
                End If
                f.say(s.setupResources(Content(textMainFolder), Content(textResourcesFolder)).Result)
            ElseIf selection = SpringBootFileIs.CodeFiles.ToString Then
                If IsEmpty({textMainFolder}) Then
                    f.say("please set location for main folder")
                    textMainFolder.Focus()
                    Return
                End If
                If IsEmpty({textUsername, textPassword}, ControlsToCheck.Any) Then
                    f.say("username and password fields are required")
                    If IsEmpty(textUsername) Then
                        textUsername.Focus()
                    Else
                        textPassword.Focus()
                    End If
                    Return
                End If
                f.say(s.setupCodeFiles(Content(textMainFolder), Content(textUsername), Content(textPassword)).Result)
            ElseIf selection = SpringBootFileIs.all.ToString Then
                If IsEmpty({textMainFolder}) Then
                    f.say("please set location for main folder")
                    textMainFolder.Focus()
                    Return
                End If
                If IsEmpty({textResourcesFolder}) Then
                    f.say("please set location for resources folder")
                    textResourcesFolder.Focus()
                    Return
                End If
                If IsEmpty({textMainFolder}) Then
                    f.say("please set location for main folder")
                    textMainFolder.Focus()
                    Return
                End If
                If IsEmpty({textUsername, textPassword}, ControlsToCheck.Any) Then
                    f.say("username and password fields are required")
                    If IsEmpty(textUsername) Then
                        textUsername.Focus()
                    Else
                        textPassword.Focus()
                    End If
                    Return
                End If
                f.say(s.setupCodeFiles(Content(textMainFolder), Content(textUsername), Content(textPassword)).Result)
                f.say(s.setupResources(Content(textMainFolder), Content(textResourcesFolder)).Result)
            End If

            If result.Length > 0 Then
                textSnippet.Text = result
                Clipboard.SetText(result)
            End If

            ListsClearLists({dropFields, dropTypes})
        Catch ex As Exception

        End Try


    End Sub

    Private Sub buttonCopy_Click(sender As Object, e As EventArgs) Handles buttonCopy.Click
        'EnableControl(sender, False)
        If textSnippet.Text.Trim.Length > 0 Then Clipboard.SetText(textSnippet.Text)
        'EnableControl(sender)
    End Sub

    Private Sub buttonAdd_Click(sender As Object, e As EventArgs) Handles buttonAdd.Click
        'EnableControl(sender, False)
        If IsEmpty(textField) Or IsEmpty(dropType) Then Return
        If ListsContain(dropFields, Content(textField)) Then
            Beep()
            Return
        End If
        ListsAddItem(dropFields, Content(textField), True)
        ListsAddItem(dropTypes, Content(dropType), True)
        Clear(textField)
        textField.Focus()
        'EnableControl(sender)
    End Sub

    Private Sub buttonClear_Click(sender As Object, e As EventArgs) Handles buttonClear.Click
        'EnableControl(sender, False)
        ListsClearList(dropTypes)
        ListsClearList(dropFields)
        'EnableControl(sender)

    End Sub

    Private Sub buttonRemove_Click(sender As Object, e As EventArgs) Handles buttonRemove.Click
        'EnableControl(sender, False)
        dropTypes.SelectedIndex = dropFields.SelectedIndex
        ListsRemoveItem(dropTypes)
        ListsRemoveItem(dropFields)
        'EnableControl(sender)
    End Sub

    Private Sub textField_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textField.KeyPress
        If e.KeyChar = ChrW(13) Then buttonAdd_Click(Me, New EventArgs)
    End Sub
End Class