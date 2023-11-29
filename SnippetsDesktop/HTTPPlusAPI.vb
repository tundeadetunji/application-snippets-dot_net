#Region "Imports"
'from iNovation
Imports iNovation.Code.General
Imports iNovation.Code.Desktop

Imports Feedback.Feedback
Imports iNCode.Converter
Imports iNCode.Docs
Imports iNCode.Snippets
Imports iNCode.Startup
Imports Microsoft.VisualBasic.Devices
Imports System.Collections.ObjectModel
#End Region
Public Class HTTPPlusAPI
#Region "Fields"
    Private s As New iNovation.iNCode.Web()
    Private Property UIHasLoaded As Boolean = False
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
#Region "Helper Functions"
	Private Sub HideControls()
		DialogTitle.Hide()
		TopLine.Hide()
		BottomLine.Hide()
		'MinimizeButton.Hide()
		brand.BringToFront()
	End Sub


#End Region
    Private Sub HTTPPlusAPI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'language
        'MarkLanguage()

        'theme
        ''MarkTheme(selected_theme, GreenTheme, TurqoiseTheme, VelvetTheme, PurpleTheme, WhiteTheme, BrownTheme, YellowTheme, Me)

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
		dCode.DataSource = s.Methods_List
        dComponent.DataSource = s.Components_List
        UIHasLoaded = True
    End Sub

	Private Sub bSnippet_Click(sender As Object, e As EventArgs) Handles bSnippet.Click
        'EnableControl(sender, False)
        On Error Resume Next

        If dCode.Text.Trim.Length < 1 Or IsEmpty(textURL) Then Return

		Dim r As String = ""

		r = s.StringRequest(Content(textURL), Content(dCode))
		tSnippet.Text = r
		If r.Length > 1 Then Clipboard.SetText(r)
        'EnableControl(sender)
    End Sub

    Private Sub dComponent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dComponent.SelectedIndexChanged
        If Not UIHasLoaded Then Return
        On Error Resume Next
        Clear(tSnippet)
		Dim r As String = ""
		Dim s As New iNovation.iNCode.Web

		Select Case Content(dComponent)
			Case iNovation.iNCode.Web.Components.Proxy_Quota.ToString
				r = s.Proxy_Quota
		End Select
		tSnippet.Text = r
		If r.Length > 0 Then Clipboard.SetText(r)

	End Sub

    Private Sub bAdd_Click(sender As Object, e As EventArgs) Handles bAdd.Click

    End Sub
End Class