#Region "Imports"

'from iNovation
Imports iNovation.Code.General
Imports iNovation.Code.Desktop

Imports Feedback.Feedback
Imports iNovation.iNCode.Converter
Imports iNovation.iNCode.Docs
Imports iNovation.iNCode.Snippets
Imports iNovation.iNCode.Startup
Imports Microsoft.VisualBasic.Devices
Imports System.Collections.ObjectModel
Imports iNovation.iNCode.AndroidUIComposition
Imports MachineModule.WindowsSystem
#End Region
Public Class AndroidHTTP
#Region "Fields"
	'Private g As New General_Module.FormatWindow
	Private s As New iNovation.iNCode.AndroidHTTP
	'	Private ReadOnly Property con_string__ As String = "Data Source=" & Environment.MachineName & "\SQLEXPRESS;Initial Catalog=Stock2008;Persist Security Info=True;User ID=sa;Password=Sequel_123"
	'	Private Property fields_ As Array
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
	End Sub


#End Region
    Private Sub AndroidHTTP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        BindProperty(dropTreatAs, s.TreatAs_List)
        BindProperty(dropHTTPMethod, s.HTTPMethodList)
	End Sub

	Private Sub buttonCopyInterface_Click(sender As Object, e As EventArgs) Handles buttonCopyInterface.Click
        'EnableControl(sender, False)
        Clipboard.SetText(Content(textInterface))
        'EnableControl(sender)
    End Sub

    Private Sub buttonCopyActivityMemberVariables_Click(sender As Object, e As EventArgs) Handles buttonCopyActivityMemberVariables.Click
        'EnableControl(sender, False)
        Clipboard.SetText(Content(textActivityMemberVariables))
        'EnableControl(sender)
    End Sub

    Private Sub buttonCopyModelClass_Click(sender As Object, e As EventArgs) Handles buttonCopyModelClass.Click
        'EnableControl(sender, False)
        Clipboard.SetText(Content(textModelClass))
        'EnableControl(sender)
    End Sub

    Private Sub buttonCopyActivityOnCreate_Click(sender As Object, e As EventArgs) Handles buttonCopyActivityOnCreate.Click
        'EnableControl(sender, False)
        Clipboard.SetText(Content(textActivityOnCreate))
        'EnableControl(sender)
    End Sub

    Private Sub buttonCopyStringValues_Click(sender As Object, e As EventArgs) Handles buttonCopyStringValues.Click
        'EnableControl(sender, False)
        Clipboard.SetText(Content(textStringValues))
        'EnableControl(sender)
    End Sub

    Private Sub bClearParams_Click(sender As Object, e As EventArgs) Handles bClearParams.Click
        'EnableControl(sender, False)
        ListsClearList(dropParams)
        'EnableControl(sender)
    End Sub

    Private Sub bRemoveParam_Click(sender As Object, e As EventArgs) Handles bRemoveParam.Click
        'EnableControl(sender, False)
        ListsRemoveItem(dropParams)
        'EnableControl(sender)

    End Sub

	Private Sub bAddParam_Click(sender As Object, e As EventArgs) Handles bAddParam.Click
        'EnableControl(sender, False)
        ListsAddItem(dropParams, Content(dropParams))
        dropParams.Focus()
        'EnableControl(sender)
    End Sub

    Private Sub textBaseURL_TextChanged(sender As Object, e As EventArgs) Handles textBaseURL.TextChanged
		ToLowerCase(sender)
	End Sub

	Private Sub textRawURL_TextChanged(sender As Object, e As EventArgs) Handles textRawURL.TextChanged
		ToLowerCase(sender)
	End Sub

	Private Sub textPackageName_TextChanged(sender As Object, e As EventArgs) Handles textPackageName.TextChanged
		ToLowerCase(sender)
	End Sub

	Private Sub buttonSnippet_Click(sender As Object, e As EventArgs) Handles buttonSnippet.Click
        'EnableControl(sender, False)
        If IsEmpty({textBaseURL, textPackageName, textSampleJSON, textModelClassName}, ControlsToCheck.Any) Then Return

        Clear({textInterface, textModelClass, textStringValues, textActivityMemberVariables, textActivityOnCreate})

		''		Dim model_class_name As String = TransformText(Content(textModelClassName))
		Dim model_class_name As String = Content(textModelClassName)
		If model_class_name.EndsWith("model", True, Nothing) = False Then
			model_class_name = model_class_name & "Model"
		End If
		Dim snippets As Array = s.AndroidHTTPSnippets(Content(dropTreatAs), Content(textPackageName), Content(textSampleJSON), model_class_name, Content(dropHTTPMethod), CreateRawURL, CreateBaseURL, DropToList(dropParams))
		textInterface.Text = snippets(0)
		textModelClass.Text = snippets(1)
		textStringValues.Text = snippets(2)
		textActivityMemberVariables.Text = snippets(3)
		textActivityOnCreate.Text = snippets(4)

        'EnableControl(sender)

    End Sub

	Private Function CreateRawURL() As String
		If IsEmpty(textRawURL) Then
			Return ""
		Else
			Dim base As String = Content(textRawURL)
			If base.StartsWith("/", True, Nothing) Then base = Mid(base, 2)

			If dropParams.Items.Count > 0 Then
				base &= "?"
				With dropParams
					.SelectedIndex = 0
					For i = 0 To .Items.Count - 1
						If i <> 0 Then
							base &= "&"
						End If
						base &= .SelectedItem.ToString
						If .SelectedIndex <> .Items.Count - 1 Then .SelectedIndex += 1
					Next
				End With
			End If
			Return base.Replace("??", "?")
		End If
	End Function

	Private Function CreateBaseURL() As String
		Dim base As String = Content(textBaseURL)
		If base.EndsWith("/", True, Nothing) = False Then base &= "/"
		Return base
	End Function

End Class