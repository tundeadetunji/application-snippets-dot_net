#Region "Imports"
'from iNovation
Imports iNovation.Code.General
Imports iNovation.Code.Desktop

Imports iNovation.iNCode.Converter
Imports iNovation.iNCode.Docs
Imports iNovation.iNCode.Snippets
Imports iNovation.iNCode.Startup
Imports Microsoft.VisualBasic.Devices
Imports System.Collections.ObjectModel
Imports iNovation.iNCode.AndroidUIComposition
#End Region
Public Class AndroidUI
#Region "Fields"
    Private s As New iNovation.iNCode.AndroidUIComposition()
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

    Private Sub AndroidUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		'Left = (Screen.PrimaryScreen.Bounds.Width - Width) / 2
		'Top = (Screen.PrimaryScreen.Bounds.Height - Height) / 2

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
        BindProperty(dText, AndroidText_List, False)
        BindProperty(dComponent, AndroidComponent_List, False)
        BindProperty(dCode, AndroidCode_List, False)
        BindProperty(dTrailingIcon, AndroidTrailingIcon_List, False)
        BindProperty(dStyle, AndroidStyle_List, False)
        BindProperty(dCardOption, AndroidCardOption_List, False)
        BindProperty(dDialogType, AndroidDialogType_List, False)
        BindProperty(dDialogOption, AndroidDialogOption_List, False)
        BindProperty(dProgressIndicatorType, AndroidProgressIndicatorType_List, False)
        BindProperty(dProgressIndicatorOption, AndroidProgressIndicatorOption_List, False)
        BindProperty(dLayout, AndroidLayout_List, False)
        BindProperty(dLeadingIcon, AndroidLeadingIcon_List, False)
    End Sub
	Private Sub buttonClear_Click(sender As Object, e As EventArgs) Handles buttonClear.Click
        'EnableControl(sender, False)
        ListsClearList(listUI)
        ListsClearList(listText)
		ListsClearList(listComponent)
		ListsClearList(listCode)
		ListsClearList(listTrailingIcon)
		ListsClearList(listLeadingIcon)
		ListsClearList(listStyle)
		ListsClearList(listCardOption)
		ListsClearList(listDialogType)
		ListsClearList(listDialogOption)
		ListsClearList(listProgressIndicatorType)
		ListsClearList(listProgressIndicatorOption)
		ListsClearList(listLayout)
		ListsClearList(listWhichComponent)

		EnableControls({buttonAddText, buttonAddComponent})
        'EnableControl(sender)

    End Sub

	Private Sub buttonMoveUp_Click(sender As Object, e As EventArgs) Handles buttonMoveUp.Click
        'EnableControl(sender, False)
        ListsMoveItemUp(listUI)
        ListsMoveItemUp(listText)
		ListsMoveItemUp(listComponent)
		ListsMoveItemUp(listCode)
		ListsMoveItemUp(listTrailingIcon)
		ListsMoveItemUp(listStyle)
		ListsMoveItemUp(listCardOption)
		ListsMoveItemUp(listDialogType)
		ListsMoveItemUp(listDialogOption)
		ListsMoveItemUp(listProgressIndicatorType)
		ListsMoveItemUp(listProgressIndicatorOption)
		ListsMoveItemUp(listLayout)
		ListsMoveItemUp(listWhichComponent)
        'EnableControl(sender)
    End Sub

    Private Sub buttonRemove_Click(sender As Object, e As EventArgs) Handles buttonRemove.Click
        'EnableControl(sender, False)
        ListsRemoveItem(listUI)
        ListsRemoveItem(listText)
		ListsRemoveItem(listComponent)
		ListsRemoveItem(listCode)
		ListsRemoveItem(listTrailingIcon)
		ListsRemoveItem(listStyle)
		ListsRemoveItem(listCardOption)
		ListsRemoveItem(listDialogType)
		ListsRemoveItem(listDialogOption)
		ListsRemoveItem(listProgressIndicatorType)
		ListsRemoveItem(listProgressIndicatorOption)
		ListsRemoveItem(listLayout)
		ListsRemoveItem(listWhichComponent)


		If listUI.Items.Count < 1 Then EnableControls({buttonAddText, buttonAddComponent})
        'EnableControl(sender)

    End Sub
	Private Sub buttonAddText_Click(sender As Object, e As EventArgs) Handles buttonAddText.Click
        'EnableControl(sender, False)
        If IsEmpty(dText) Then
            Return
        End If

        ListsAddItem(listText, Content(dText), True)
		ListsAddItem(listComponent, Content(dComponent), True)
		ListsAddItem(listCode, Content(dCode), True)
		ListsAddItem(listLeadingIcon, Content(dLeadingIcon), True)
		ListsAddItem(listTrailingIcon, Content(dTrailingIcon), True)
		ListsAddItem(listStyle, Content(dStyle), True)
		ListsAddItem(listCardOption, Content(dCardOption), True)
		ListsAddItem(listDialogType, Content(dDialogType), True)
		ListsAddItem(listDialogOption, Content(dDialogOption), True)
		ListsAddItem(listProgressIndicatorType, Content(dProgressIndicatorType), True)
		ListsAddItem(listProgressIndicatorOption, Content(dProgressIndicatorOption), True)
		ListsAddItem(listLayout, Content(dLayout), True)

		ListsAddItem(listUI, nameOfComponent(Content(dText), listUI), True)
		ListsAddItem(listWhichComponent, Content(dText), True)
        'EnableControl(sender)

    End Sub

	Private Sub buttonAddComponent_Click(sender As Object, e As EventArgs) Handles buttonAddComponent.Click
        'EnableControl(sender, False)
        If IsEmpty(dComponent) Then
            Return
        End If

        ListsAddItem(listText, Content(dText), True)
		ListsAddItem(listComponent, Content(dComponent), True)
		ListsAddItem(listCode, Content(dCode), True)
		ListsAddItem(listTrailingIcon, Content(dTrailingIcon), True)
		ListsAddItem(listLeadingIcon, Content(dLeadingIcon), True)
		ListsAddItem(listStyle, Content(dStyle), True)
		ListsAddItem(listCardOption, Content(dCardOption), True)
		ListsAddItem(listDialogType, Content(dDialogType), True)
		ListsAddItem(listDialogOption, Content(dDialogOption), True)
		ListsAddItem(listProgressIndicatorType, Content(dProgressIndicatorType), True)
		ListsAddItem(listProgressIndicatorOption, Content(dProgressIndicatorOption), True)
		ListsAddItem(listLayout, Content(dLayout), True)

		ListsAddItem(listUI, nameOfComponent(Content(dComponent), listUI), True)
		ListsAddItem(listWhichComponent, Content(dComponent), True)
        'EnableControl(sender)

    End Sub

	Private Sub buttonAddCode_Click(sender As Object, e As EventArgs) Handles buttonAddCode.Click
        'EnableControl(sender, False)
        If IsEmpty(dCode) Then
            dCode.Focus()
            Return
        End If

        If IsEmpty(textPackage) Then
			textPackage.Focus()
			Return
		End If

		If IsEmpty(textActivity) Then
			textActivity.Focus()
			Return
		End If

		If IsEmpty(listUI) = False Then Return

		If listUI.Items.Count > 0 Then Return

		If Content(dCode) = AndroidCode.NavigationDrawer.ToString And dCustomItems.Items.Count < 1 Then
			dCustomItems.Focus()
			Return
		End If

		buttonRemove_Click(sender, e)
		EnableControls({buttonAddText, buttonAddComponent}, False)

		'ListsAddItem(listText, Content(dText), True)
		'ListsAddItem(listComponent, Content(dComponent), True)
		'ListsAddItem(listCode, Content(dCode), True)
		'ListsAddItem(listTrailingIcon, Content(dTrailingIcon), True)
		'ListsAddItem(listLeadingIcon, Content(dLeadingIcon), True)
		'ListsAddItem(listStyle, Content(dStyle), True)
		'ListsAddItem(listCardOption, Content(dCardOption), True)
		'ListsAddItem(listDialogType, Content(dDialogType), True)
		'ListsAddItem(listDialogOption, Content(dDialogOption), True)
		'ListsAddItem(listProgressIndicatorType, Content(dProgressIndicatorType), True)
		'ListsAddItem(listProgressIndicatorOption, Content(dProgressIndicatorOption), True)
		'ListsAddItem(listLayout, Content(dLayout), True)

		ListsAddItem(listUI, nameOfComponent(Content(dCode), listUI), True)
        'EnableControl(sender)
        'EnableControls({buttonAddText, buttonAddComponent}, True)

    End Sub

	'Private Sub buttonAdd_Click(sender As Object, e As EventArgs) Handles buttonAdd.Click

	'	Dim c As String
	'	If Content(dText) IsNot AndroidText.None.ToString Then
	'		c = Content(dText)
	'	ElseIf Content(dComponent) IsNot AndroidComponent.None.ToString Then
	'		c = Content(dComponent)
	'	ElseIf Content(dCode) IsNot AndroidCode.None.ToString Then
	'		c = Content(dCode)
	'	End If

	'	ListsAddItem(listText, Content(dText))
	'	ListsAddItem(listComponent, Content(dComponent))
	'	ListsAddItem(listTrailingIcon, Content(dTrailingIcon))
	'	ListsAddItem(listStyle, Content(dStyle))
	'	ListsAddItem(listCardOption, Content(dCardOption))
	'	ListsAddItem(listDialogType, Content(dDialogType))
	'	ListsAddItem(listDialogOption, Content(dDialogOption))
	'	ListsAddItem(listProgressIndicatorType, Content(dProgressIndicatorType))
	'	ListsAddItem(listProgressIndicatorOption, Content(dProgressIndicatorOption))
	'	ListsAddItem(listLayout, Content(dLayout))

	'	ListsAddItem(listUI, nameOfComponent(c))
	'	ListsAddItem(listWhichComponent, c)
	'End Sub

	Private Function nameOfComponent(component As String, list As ListBox) As String
		Dim Index As String = NewGUID(IDPattern.Short_).Replace("-", "")
		Dim id As String = Index

		Select Case component
			''text
			Case AndroidText.EditText.ToString
				Return "AutoCompleteEditText" & id
			Case AndroidText.Email.ToString
				Return "AutoCompleteEmail"
			Case AndroidText.Label.ToString
				Return "label" & id
			Case AndroidText.MultilineText.ToString
				Return "AutoCompleteMultiline" & id
			Case AndroidText.Number.ToString
				Return "AutoCompleteNumber" & id
			Case AndroidText.Password.ToString
				Return "AutoCompletePassword"
			Case AndroidText.Phone.ToString
				Return "AutoCompletePhone"
			Case AndroidText.PostalAddress.ToString
				Return "AutoCompleteAddress"
			Case AndroidText.DropDown.ToString
				Return "AutoCompleteItems" & Index
			Case AndroidText.Username.ToString
				Return "AutoCompleteUsername"
			Case AndroidText.RegularEditText.ToString
				Return "text" & Index

				''component
			Case AndroidComponent.Button.ToString
				Return "button" & Index
			Case AndroidComponent.FAB.ToString
				Return "button" & Index
			Case AndroidComponent.Card.ToString
				Return "card" & id
			Case AndroidComponent.DatePicker.ToString
				Return "datePicker" & Index
			Case AndroidComponent.ProgressIndicator.ToString
				Return "ProgressIndicator"
			Case AndroidComponent.TimePicker.ToString
				Return "timePicker" & Index
			Case AndroidComponent.ImageView.ToString
				Return "image" & Index
			Case AndroidComponent.WebView.ToString
				Return "web"

				''code
			Case AndroidCode.ContextMenu.ToString
				Return "contextMenu"
			Case AndroidCode.OverflowMenu.ToString
				Return "menu" & Content(textActivity)
			Case AndroidCode.BottomSheet.ToString
				Return "bottomSheet" & Content(textActivity)
			Case AndroidCode.RecyclerView.ToString
				Return "recyclerView"
			Case AndroidCode.Dialog.ToString
				Return "dialog" & id
			Case AndroidCode.NavigationDrawer.ToString
				Return "navigationDrawer"
		End Select
	End Function

	Private Sub textName_TextChanged(sender As Object, e As EventArgs)
		ToTitleCase(sender)
	End Sub

	Private Sub dText_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dText.KeyPress, dComponent.KeyPress, dCode.KeyPress, dTrailingIcon.KeyPress, dStyle.KeyPress, dCardOption.KeyPress, dDialogType.KeyPress, dDialogOption.KeyPress, dProgressIndicatorType.KeyPress, dProgressIndicatorOption.KeyPress, dLayout.KeyPress
		AllowNothing(e)
	End Sub

	Private Sub dText_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dText.SelectedIndexChanged
		'Try
		'	Clear(dCode, "None")
		'Catch ex As Exception

		'End Try
		'Try
		'	Clear(dComponent, "None")
		'Catch ex As Exception

		'End Try
	End Sub

	Private Sub dComponent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dComponent.SelectedIndexChanged
		'Try
		'	Clear(dText, "None")
		'Catch ex As Exception

		'End Try
		'Try
		'	Clear(dCode, "None")
		'Catch ex As Exception

		'End Try

	End Sub

	Private Sub dCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dCode.SelectedIndexChanged
		'Try
		'	Clear(dText, "None")
		'Catch ex As Exception

		'End Try
		'Try
		'	Clear(dComponent, "None")
		'Catch ex As Exception

		'End Try

	End Sub

	Private Sub buttonSnippet_Click(sender As Object, e As EventArgs) Handles buttonSnippet.Click
        'EnableControl(sender, False)
        ''if item from dCode is already in dWhichComponent, ignore the rest
        If listUI.Items.Count < 1 Then Return

		Dim snippet As Dictionary(Of String, String)
		If buttonAddText.Enabled = False Or buttonAddComponent.Enabled = False Then
			snippet = AndroidSnippetCode(listUI.Items(0), Content(textActivity), dCustomItems, Content(dCode), Content(textPackage))
		Else
			snippet = AndroidSnippetComponent(listText, listComponent, listCode, listTrailingIcon, listStyle, listCardOption, listDialogType, listDialogOption, listProgressIndicatorType, listProgressIndicatorOption, listLayout, listUI, listWhichComponent, Content(textActivity), listLeadingIcon)
		End If
		Try
			textMainActivityXML.Text = snippet.Item("ActivityXML")
		Catch ex As Exception
		End Try
		Try
			textMainActivityInstanceVariables.Text = snippet.Item("ActivityInstanceVariables")
		Catch ex As Exception

		End Try
		Try
			textActivityOnCreate.Text = snippet.Item("ActivityOnCreate")
		Catch ex As Exception

		End Try
		Try
			textActivityMethods.Text = snippet.Item("ActivityMethods")
		Catch ex As Exception

		End Try
		Try
			textActivityClasses.Text = snippet.Item("ActivityClasses")
		Catch ex As Exception

		End Try
		Try
			textFragmentXML.Text = snippet.Item("FragmentXML")
		Catch ex As Exception

		End Try
		Try
			textFragmentJava.Text = snippet.Item("FragmentJava")
		Catch ex As Exception

		End Try
		Try
			textMenuXML.Text = snippet.Item("MenuXML")
		Catch ex As Exception

		End Try
		Try
			textNavigationXML.Text = snippet.Item("NavigationXML")
		Catch ex As Exception

		End Try
		buttonCopyMainActivityXML_Click(sender, e)
		buttonClear_Click(sender, e)
		bClear_Click(sender, e)
        'EnableControl(sender)
    End Sub

    Private Sub buttonCopyMainActivityXML_Click(sender As Object, e As EventArgs) Handles buttonCopyMainActivityXML.Click
        'EnableControl(sender, False)
        Try
            Clipboard.SetText(Content(textMainActivityXML))
        Catch
        End Try
        'EnableControl(sender)
    End Sub

    Private Sub buttonCopyMainActivityInstanceVariables_Click(sender As Object, e As EventArgs) Handles buttonCopyMainActivityInstanceVariables.Click
        'EnableControl(sender, False)
        Try
            Clipboard.SetText(Content(textMainActivityInstanceVariables))
        Catch
        End Try
        'EnableControl(sender)

    End Sub

	Private Sub buttonCopyMainActivityOnCreate_Click(sender As Object, e As EventArgs) Handles buttonCopyActivityOnCreate.Click
        'EnableControl(sender, False)
        Try
            Clipboard.SetText(Content(textActivityOnCreate))
        Catch
        End Try
        'EnableControl(sender)

    End Sub

	Private Sub buttonCopyMainActivity_Click(sender As Object, e As EventArgs) Handles buttonCopyActivityMethods.Click
        'EnableControl(sender, False)
        Try
            Clipboard.SetText(Content(textActivityMethods))
        Catch
        End Try
        'EnableControl(sender)

    End Sub

	Private Sub buttonCopyFragmentXML_Click(sender As Object, e As EventArgs) Handles buttonCopyFragmentXML.Click
        'EnableControl(sender, False)
        Try
            Clipboard.SetText(Content(textFragmentXML))
        Catch
        End Try
        'EnableControl(sender)

    End Sub

	Private Sub buttonCopyFragmentJava_Click(sender As Object, e As EventArgs) Handles buttonCopyFragmentJava.Click
        'EnableControl(sender, False)
        Try
            Clipboard.SetText(Content(textFragmentJava))
        Catch
        End Try
        'EnableControl(sender)

    End Sub

	Private Sub bClear_Click(sender As Object, e As EventArgs) Handles bClear.Click
        'EnableControl(sender, False)
        ListsClearList(dCustomItems)
        'EnableControl(sender)
    End Sub

    Private Sub bRemove_Click(sender As Object, e As EventArgs) Handles bRemove.Click
        'EnableControl(sender, False)
        ListsRemoveItem(dCustomItems)
        'EnableControl(sender)
    End Sub

    Private Sub bAdd_Click(sender As Object, e As EventArgs) Handles bAdd.Click
        'EnableControl(sender, False)
        ListsAddItem(dCustomItems, Content(dCustomItems))
        dCustomItems.Focus()
        'EnableControl(sender)
    End Sub

    Private Sub buttonCopyMenuXML_Click(sender As Object, e As EventArgs) Handles buttonCopyMenuXML.Click
        'EnableControl(sender, False)
        Try
            Clipboard.SetText(Content(textMenuXML))
        Catch
        End Try
        'EnableControl(sender)

    End Sub

	Private Sub buttonCopyNavigationXML_Click(sender As Object, e As EventArgs) Handles buttonCopyNavigationXML.Click
        'EnableControl(sender, False)
        Try
            Clipboard.SetText(Content(textNavigationXML))
        Catch
        End Try
        'EnableControl(sender)

    End Sub

	Private Sub buttonCopyActivityClasses_Click(sender As Object, e As EventArgs) Handles buttonCopyActivityClasses.Click
        'EnableControl(sender, False)
        Try
            Clipboard.SetText(Content(textActivityClasses))
        Catch
        End Try
        'EnableControl(sender)
    End Sub

    Private Sub buttonMoveDown_Click(sender As Object, e As EventArgs) Handles buttonMoveDown.Click

    End Sub
End Class