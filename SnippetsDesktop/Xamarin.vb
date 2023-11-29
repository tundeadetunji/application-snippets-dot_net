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
Imports iNovation.iNCode.Xamarin
#End Region
Public Class Xamarin
#Region "Fields"
    Private s As New iNovation.iNCode.Xamarin()
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

#Region "Helper Functions"
	Private Sub HideControls()
		DialogTitle.Hide()
		TopLine.Hide()
		BottomLine.Hide()
		'MinimizeButton.Hide()
		brand.BringToFront()
	End Sub


#End Region
    Private Sub Xamarin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'language
        ''        MarkLanguage()

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
		dControls.DataSource = s.Controls_List
		dLayouts.DataSource = s.Layouts_List
        UIHasLoaded = True
    End Sub

    Private Sub dControls_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dControls.SelectedIndexChanged
        If Not UIHasLoaded Then Return
        'CHECK
        On Error Resume Next

		Dim r As String = ""
		Dim selected = Content(dControls)

		If selected = XamarinControls.Button.ToString Then
			r = s.Button()
		End If
		tSnippet.Text = r
		If r.Length > 1 Then Clipboard.SetText(r)

	End Sub
End Class