#Region "Imports"

'from iNovation
Imports iNovation.Code.General
Imports iNovation.Code.Desktop
Imports iNovation.Code.Feedback

Imports iNovation.iNCode.Converter
Imports iNovation.iNCode.Docs
Imports iNovation.iNCode.Snippets
Imports iNovation.iNCode.Startup
Imports Microsoft.VisualBasic.Devices
Imports System.Collections.ObjectModel
#End Region
Public Class Android
#Region "Fields"
    Private s As New iNovation.iNCode.Android()
    Private Property UIHasLoaded As Boolean = False
    Private ReadOnly Property factory As New Factory
    Private ReadOnly Property f As SoundsAdapter = factory.SoundAdapter

#End Region

#Region "In/Out Timer"
    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
        '		Bye(Me, OutTimer, log_out_sound, "")
    End Sub
    Private Sub InTimer_Tick(sender As Object, e As EventArgs) 'Handles InTimer.Tick
        If Me.Opacity >= 1 Then
            InTimer.Enabled = False
            Exit Sub
        End If
        Me.Opacity += 0.2
    End Sub

#End Region

    '#Region "Controls"
    '	Private Sub MarkLanguage()

    '		Select Case selected_language.ToString.ToLower
    '			Case "english"
    '				l.MarkLanguage(EnglishLanguage, EnglishLanguage, FrenchLanguage, ThaiLanguage, YorubaLanguage, ChineseLanguage, HausaLanguage, IgboLanguage)
    '			Case "french"
    '				l.MarkLanguage(FrenchLanguage, EnglishLanguage, FrenchLanguage, ThaiLanguage, YorubaLanguage, ChineseLanguage, HausaLanguage, IgboLanguage)
    '			Case "thai"
    '				l.MarkLanguage(ThaiLanguage, EnglishLanguage, FrenchLanguage, ThaiLanguage, YorubaLanguage, ChineseLanguage, HausaLanguage, IgboLanguage)
    '			Case "yoruba"
    '				l.MarkLanguage(YorubaLanguage, EnglishLanguage, FrenchLanguage, ThaiLanguage, YorubaLanguage, ChineseLanguage, HausaLanguage, IgboLanguage)
    '			Case "chinese"
    '				l.MarkLanguage(ChineseLanguage, EnglishLanguage, FrenchLanguage, ThaiLanguage, YorubaLanguage, ChineseLanguage, HausaLanguage, IgboLanguage)
    '			Case "hausa"
    '				l.MarkLanguage(HausaLanguage, EnglishLanguage, FrenchLanguage, ThaiLanguage, YorubaLanguage, ChineseLanguage, HausaLanguage, IgboLanguage)
    '			Case "igbo"
    '				l.MarkLanguage(IgboLanguage, EnglishLanguage, FrenchLanguage, ThaiLanguage, YorubaLanguage, ChineseLanguage, HausaLanguage, IgboLanguage)
    '		End Select
    '	End Sub

    '	Private Sub EnglishLanguage_Click(sender As Object, e As EventArgs) Handles EnglishLanguage.Click, FrenchLanguage.Click, ThaiLanguage.Click, YorubaLanguage.Click, ChineseLanguage.Click, HausaLanguage.Click, IgboLanguage.Click
    '		Dim s As ToolStripMenuItem = sender
    '		saveSelected_Language(s.Text)
    '		l.MarkLanguage(sender, EnglishLanguage, FrenchLanguage, ThaiLanguage, YorubaLanguage, ChineseLanguage, HausaLanguage, IgboLanguage)
    '	End Sub

    '#End Region

    '#Region "Feedback"
    '	Private Sub Sound_Click(sender As Object, e As EventArgs) Handles SoundTool.Click
    '		Try
    '			Process.Start("Control", "/name Microsoft.Sound")
    '		Catch ex As Exception
    '		End Try
    '	End Sub

    '	Private Sub VoiceOnly_Click(sender As Object, e As EventArgs) Handles VoiceOnly.Click
    '		Dim u As ToolStripMenuItem = sender
    '		Select Case u.Checked
    '			Case False
    '				u.Checked = True
    '				If MessagePromptWithVoice.Checked = True Then
    '					f.setting_accompany_prompt_with_voice_feedback = False
    '					MessagePromptWithVoice.Checked = False
    '				End If
    '				If MessagePromptOnly.Checked = True Then
    '					f.setting_use_prompt = False
    '					MessagePromptOnly.Checked = False
    '				End If
    '			Case True
    '				If MessagePromptWithVoice.Checked = False And MessagePromptOnly.Checked = False Then
    '					u.Checked = True
    '				ElseIf MessagePromptWithVoice.Checked = True Or MessagePromptOnly.Checked = True Then
    '					u.Checked = False
    '				End If
    '		End Select
    '		MarkUseVoiceFeedback(u.Checked, sender, MessagePromptWithVoice, MessagePromptWithVoice)

    '	End Sub

    '	Private Sub MessagePromptWithVoice_Click(sender As Object, e As EventArgs) Handles MessagePromptWithVoice.Click
    '		Dim ampwvf As ToolStripMenuItem = sender
    '		Select Case ampwvf.Checked
    '			Case False
    '				ampwvf.Checked = True
    '				If VoiceOnly.Checked = True Then
    '					f.setting_use_voice_feedback = False
    '					VoiceOnly.Checked = False
    '				End If
    '				If MessagePromptOnly.Checked = True Then
    '					f.setting_use_prompt = False
    '					MessagePromptOnly.Checked = False
    '				End If
    '			Case True
    '				If VoiceOnly.Checked = False And MessagePromptOnly.Checked = False Then
    '					ampwvf.Checked = True
    '				ElseIf VoiceOnly.Checked = True Or MessagePromptOnly.Checked = True Then
    '					ampwvf.Checked = False
    '				End If
    '		End Select
    '		MarkAccompanyPromptWithVoiceFeedback(ampwvf.Checked, sender, VoiceOnly, MessagePromptOnly)

    '	End Sub

    '	Private Sub MessagePromptOnly_Click(sender As Object, e As EventArgs) Handles MessagePromptOnly.Click
    '		Dim mp As ToolStripMenuItem = sender
    '		Select Case mp.Checked
    '			Case False
    '				mp.Checked = True
    '				If VoiceOnly.Checked = True Then
    '					f.setting_use_voice_feedback = False
    '					VoiceOnly.Checked = False
    '				End If
    '				If MessagePromptWithVoice.Checked = True Then
    '					f.setting_accompany_prompt_with_voice_feedback = False
    '					MessagePromptWithVoice.Checked = False
    '				End If
    '			Case True
    '				If VoiceOnly.Checked = False And MessagePromptWithVoice.Checked = False Then
    '					mp.Checked = True
    '				ElseIf VoiceOnly.Checked = True Or MessagePromptWithVoice.Checked = True Then
    '					mp.Checked = False
    '				End If
    '		End Select
    '		MarkUsePrompt(mp.Checked, sender, MessagePromptWithVoice, VoiceOnly)

    '	End Sub
    '#End Region

#Region "theme"
    'Private Sub GreenTheme_Click(sender As Object, e As EventArgs) Handles GreenTheme.Click, TurqoiseTheme.Click, BrownTheme.Click, YellowTheme.Click, VelvetTheme.Click, PurpleTheme.Click, WhiteTheme.Click
    '	Dim mark_ As ToolStripMenuItem = sender
    '	MarkTheme(mark_.Text, GreenTheme, TurqoiseTheme, VelvetTheme, PurpleTheme, WhiteTheme, BrownTheme, YellowTheme, Me)
    '	g.FormatMe(Me, Nothing, LeftBorder, RightBorder, TopBorder, BottomBorder, TopLine, BottomLine, DialogTitle, SystemCloseButton, MinimizeButton, CloseButton, HelpButton, MenuStrip, SystemCloseButton, SystemCloseButton, TitleBar, FooterBar, MaximizeButton, True, False, False, True, selected_theme, Feedback, TimeTimer, TimeLabel, False, False)
    '	HideControls()
    'End Sub

    'Private Sub ThemeSelectBackground_Click(sender As Object, e As EventArgs) Handles ThemeSelectBackground.Click
    '	DialogBackground(Me)
    'End Sub

    'Private Sub ThemeClearBackground_Click(sender As Object, e As EventArgs) Handles ThemeClearBackground.Click
    '	ClearDialogBackground(Me)
    'End Sub
#End Region

#Region "Support Functions"
    Private Sub HideControls()
        DialogTitle.Hide()
        TopLine.Hide()
        BottomLine.Hide()
        'MinimizeButton.Hide()
        brand.BringToFront()
    End Sub


#End Region
    Private Sub Android_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'language
        'MarkLanguage()

        'theme
        'MarkTheme(selected_theme, GreenTheme, TurqoiseTheme, VelvetTheme, PurpleTheme, WhiteTheme, BrownTheme, YellowTheme, Me)

        'application feedback
        'InitialMarkVoiceFeedback(MessagePromptOnly, MessagePromptWithVoice, VoiceOnly)

        '		g.item_f = font_

        'dialog
        'g.FormatMe(Me, Nothing, LeftBorder, RightBorder, TopBorder, BottomBorder, TopLine, BottomLine, DialogTitle, SystemCloseButton, MinimizeButton, CloseButton, HelpButton, MenuStrip, SystemCloseButton, SystemCloseButton, TitleBar, FooterBar, MaximizeButton, True, False, False, True, selected_theme, Feedback, TimeTimer, TimeLabel, False, False)
        'SetDialogBackground(Me, themeBackgroundFile)
        'HideControls()

        Values()

    End Sub

    Private Sub Values()
        dCode.DataSource = s.Components_List
        With dSection
            .DataSource = Nothing
            .Items.Clear()
        End With
        'dApp.DataSource = s.Java_List
        dAPI.DataSource = s.API_List
        UIHasLoaded = True
    End Sub

    Private Sub dCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dCode.SelectedIndexChanged
        If Not UIHasLoaded Then Return
        On Error Resume Next
        Clear(tSnippet)
        Dim d As ComboBox = sender
        Dim r As String = ""
        Select Case Content(d)
            'Case iNCode.Android.Components.MakeCall.ToString
            '	r = s.MakeCall
            'Case iNCode.Android.Components.StartActivity.ToString
            '	r = s.StartActivity
            'Case iNCode.Android.Components.Toast.ToString
            '	r = s.Toast
            'Case iNCode.Android.Components.OpenAppPageOnGooglePlaystore.ToString
            '	r = s.OpenAppPageOnGooglePlaystore
            'Case iNCode.Android.Components.ShareAppURL.ToString
            '	r = s.ShareAppURL
            'Case iNCode.Android.Components.ClipboardGetSetText.ToString
            '	r = s.ClipboardText

            'Case iNCode.Android.Components.Import.ToString
            '	r = s.Import
            'Case iNCode.Android.Components.MainActivity.ToString
            '	r = s.MainActivity
            Case iNovation.iNCode.Android.Components.Permissions.ToString
                r = s.Permissions
            'Case iNCode.Android.Components.WebView.ToString
            '	r = s.WebView
            'Case iNCode.Android.Components.DeviceID.ToString
            '	r = s.DeviceID
            'Case iNCode.Android.Components.IfConnectionIsMetered.ToString
            '	r = s.IfConnectionIsMetered
            'Case iNCode.Android.Components.IfThereIsInternet.ToString
            '	r = s.IfThereIsInternet
            'Case iNCode.Android.Components.Notification.ToString
            '	r = s.notification
            'Case iNCode.Android.Components.sendsms.ToString
            '	r = s.sendsms
            'Case iNCode.Android.Components.texttospeech.ToString
            '	r = s.TextToSpeech
            Case iNovation.iNCode.Android.Components.Dependencies.ToString
                r = s.Dependencies
            Case iNovation.iNCode.Android.Components.ProjectGradle.ToString
                r = s.ProjectGradle
            Case iNovation.iNCode.Android.Components.ReleaseAPKAppGradle.ToString
                r = s.ReleaseAPKAppGradle
        End Select
        tSnippet.Text = r
        If r.Length > 0 Then Clipboard.SetText(r)

    End Sub

    Private Sub dApp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dApp.SelectedIndexChanged
        If Not UIHasLoaded Then Return
        'On Error Resume Next
        Clear(tSnippet)
        Dim d As ComboBox = sender
        Dim r As String = ""
        Select Case Content(d)
            'Case iNCode.Android.Java.NewFile.ToString
            '	If dSection.Items.Count > 0 Then
            '		r = s.NewFile(GetText("Enter name of file..."), ComboToList(dSection))
            '	End If
        End Select
        tSnippet.Text = r
        Try
            If r.Length > 0 Then Clipboard.SetText(r)
        Catch
        End Try

    End Sub

    Private Sub bAdd_Click(sender As Object, e As EventArgs) Handles bAdd.Click
        EnableControl(sender, False)
        With dSection
            If .Items.Contains(Content(dSection)) = False Then
                .Items.Add(Content(dSection))
                .Text = ""
            End If
        End With
        EnableControl(sender)
    End Sub

    Private Sub bRemove_Click(sender As Object, e As EventArgs) Handles bRemove.Click
        EnableControl(sender, False)

        With dSection
            If .Items.Count < 1 Or .Text.Trim = "" Then Return
            Try
                .Items.Remove(.Items.Item(.Items.IndexOf(Content(dSection))))
            Catch
            End Try
            If .Items.Count > 0 Then
                .SelectedIndex = .Items.Count - 1
            Else
                .Text = ""
            End If
            '				.SelectedItem = .Items(.SelectedIndex)
        End With
        EnableControl(sender)

    End Sub

    Private Sub bClear_Click(sender As Object, e As EventArgs) Handles bClear.Click
        EnableControl(sender, False)
        Clear(dSection)
        EnableControl(sender)
    End Sub

    Private Sub dAPI_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dAPI.SelectedIndexChanged
        If Not UIHasLoaded Then Return
        On Error Resume Next
        Clear(tSnippet)
        Dim d As ComboBox = sender
        Dim r As String = ""
        Select Case Content(d)
            Case iNovation.iNCode.Android.API.GoogleSheets.ToString
                r = s.GoogleSheets
        End Select
        tSnippet.Text = r
        If r.Length > 0 Then Clipboard.SetText(r)

    End Sub


    Private Sub buttonAndroidUI_Click(sender As Object, e As EventArgs) Handles buttonAndroidUI.Click
        'EnableControl(sender, False)

        Dim counter As Integer = 0
        For Each form As Form In My.Application.OpenForms
            If form Is AndroidUI Then counter += 1
        Next
        If counter < 1 Then
            f.say("Opening android ui section")
        End If

        AndroidUI.Show()
        AndroidUI.Focus()
        'EnableControl(sender)

    End Sub

    Private Sub buttonAndroidHTTP_Click(sender As Object, e As EventArgs) Handles buttonAndroidHTTP.Click
        'EnableControl(sender, False)
        Dim counter As Integer = 0
        For Each form As Form In My.Application.OpenForms
            If form Is AndroidHTTP Then counter += 1
        Next
        If counter < 1 Then
            f.say("Opening retrofit section")
        End If

        AndroidHTTP.Show()
        AndroidHTTP.Focus()
        'EnableControl(sender)
    End Sub

    Private Sub buttonWebViewJS_Click(sender As Object, e As EventArgs) Handles buttonWebViewJS.Click
        'EnableControl(sender, False)
        Dim counter As Integer = 0
        For Each form As Form In My.Application.OpenForms
            If form Is AndroidJS Then counter += 1
        Next
        If counter < 1 Then
            f.say("Opening android JavaScript section")
        End If

        AndroidJS.Show()
        AndroidJS.Focus()
        'EnableControl(sender)

    End Sub

    Private Sub HTTPByVolleyButton_Click(sender As Object, e As EventArgs) Handles HTTPByVolleyButton.Click
        'EnableControl(sender, False)
        Dim counter As Integer = 0
        For Each form As Form In My.Application.OpenForms
            If form Is HTTPPlusAPI Then counter += 1
        Next
        If counter < 1 Then
            f.say("Opening Volley section")
        End If
        HTTPPlusAPI.Show()
        HTTPPlusAPI.Focus()
        'EnableControl(sender)
    End Sub
End Class