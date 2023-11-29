'from iNovation
Imports iNovation.Code.General
Imports iNovation.Code.Desktop

Imports iNovation.Code.Feedback
Imports iNovation.iNCode.Converter
Imports iNovation.iNCode.Docs
Imports iNovation.iNCode.Snippets
Imports System.ComponentModel

Public Class Form1
#Region "Fields"
    'Private g As New General_Module.FormatWindow
    Private s As New iNovation.iNCode.Snippets()
    Private Property UIHasLoaded As Boolean = False
    Private ReadOnly Property factory As New Factory
    Private ReadOnly Property f As SoundsAdapter = factory.SoundAdapter

    '	Private selected
    '	Private control_
#End Region

#Region "In/Out Timer"
    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        f.bye(Me, "Closing Snippets")
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

    '#Region "theme"
    '	Private Sub GreenTheme_Click(sender As Object, e As EventArgs) Handles GreenTheme.Click, TurqoiseTheme.Click, BrownTheme.Click, YellowTheme.Click, VelvetTheme.Click, PurpleTheme.Click, WhiteTheme.Click
    '		Dim mark_ As ToolStripMenuItem = sender
    '		MarkTheme(mark_.Text, GreenTheme, TurqoiseTheme, VelvetTheme, PurpleTheme, WhiteTheme, BrownTheme, YellowTheme, Me)
    '		'g.FormatMe(Me, Nothing, LeftBorder, RightBorder, TopBorder, BottomBorder, TopLine, BottomLine, DialogTitle, SystemCloseButton, MinimizeButton, CloseButton, HelpButton, MenuStrip, SystemCloseButton, SystemCloseButton, TitleBar, FooterBar, MaximizeButton, True, False, False, True, mark_.Text, Feedback, TimeTimer, TimeLabel, False, False)
    '		HideControls()
    '	End Sub

    '	Private Sub ThemeSelectBackground_Click(sender As Object, e As EventArgs) Handles ThemeSelectBackground.Click
    '		DialogBackground(Me)
    '	End Sub

    '	Private Sub ThemeClearBackground_Click(sender As Object, e As EventArgs) Handles ThemeClearBackground.Click
    '		ClearDialogBackground(Me)
    '	End Sub
    '#End Region

#Region "Helper Functions"
    Private Sub HideControls()
        DialogTitle.Hide()
        TopLine.Hide()
        BottomLine.Hide()
    End Sub

    Private Function ContentOf(d As ComboBox)
        If d Is dControls Then
            Select Case Content(dControls)
                Case ControlsFrom.ASP.ToString
                    Return ControlsFrom.ASP
                Case ControlsFrom.HTML.ToString
                    Return ControlsFrom.HTML
            End Select
            Return True
        End If

        If d Is dAll Then
            Select Case Content(dAll)
                Case All.Image.ToString
                    Return All.Image
                Case All.UpdatePanel.ToString
                    Return All.UpdatePanel
            End Select
            Return True
        End If

        'If d Is dShoppy Then
        '	Select Case Content(dShoppy)
        '		Case Shoppy.DeclareCSS.ToString
        '			Return Shoppy.DeclareCSS
        '		Case Shoppy.DeclareJS.ToString
        '			Return Shoppy.DeclareJS
        '	End Select
        '	Return True
        'End If

        If d Is dMaterialize Then
            Select Case Content(dMaterialize)
                Case Materialize.Button.ToString
                    Return Materialize.Button
                Case Materialize.Card.ToString
                    Return Materialize.Card
                Case Materialize.Card_Reveal.ToString
                    Return Materialize.Card_Reveal
                Case Materialize.Carousel.ToString
                    Return Materialize.Carousel
                Case Materialize.Collapsible.ToString
                    Return Materialize.Collapsible
                Case Materialize.Collection.ToString
                    Return Materialize.Collection
                Case Materialize.Collection_With_Title_Secondary_Content.ToString
                    Return Materialize.Collection_With_Title_Secondary_Content
                'Case Materialize.DeclareCSS.ToString
                '	Return Materialize.DeclareCSS
                'Case Materialize.DeclareJS.ToString
                '	Return Materialize.DeclareJS
                Case Materialize.DropDownList.ToString
                    Return Materialize.DropDownList
                Case Materialize.GridView.ToString
                    Return Materialize.GridView
                Case Materialize.MaterialBox.ToString
                    Return Materialize.MaterialBox
                Case Materialize.Modal.ToString
                    Return Materialize.Modal
                'Case Materialize.NewPage.ToString
                '	Return Materialize.NewPage
                Case Materialize.Parallax.ToString
                    Return Materialize.Parallax
                Case Materialize.TextBox.ToString
                    Return Materialize.TextBox
                Case Materialize.Tooltip.ToString
                    Return Materialize.Tooltip
            End Select
            Return True
        End If

        If d Is dBootstrap Then
            Select Case Content(dBootstrap)
                Case Bootstrap.Button.ToString
                    Return Bootstrap.Button
                Case Bootstrap.Card.ToString
                    Return Bootstrap.Card
                Case Bootstrap.Carousel.ToString
                    Return Bootstrap.Carousel
                Case Bootstrap.Collapsible.ToString
                    Return Bootstrap.Collapsible
                Case Bootstrap.Collection.ToString
                    Return Bootstrap.Collection
                'Case Bootstrap.DeclareCSS.ToString
                '	Return Bootstrap.DeclareCSS
                'Case Bootstrap.DeclareJS.ToString
                '	Return Bootstrap.DeclareJS
                Case Bootstrap.DropDownList.ToString
                    Return Bootstrap.DropDownList
                Case Bootstrap.FormGroup.ToString
                    Return Bootstrap.FormGroup
                Case Bootstrap.GridView.ToString
                    Return Bootstrap.GridView
                Case Bootstrap.Modal.ToString
                    Return Bootstrap.Modal
                'Case Bootstrap.NewPage.ToString
                '	Return Bootstrap.NewPage
                Case Bootstrap.TextBox.ToString
                    Return Bootstrap.TextBox
            End Select
            Return True
        End If

        If d Is dCarouselSize Then
            Select Case Content(dCarouselSize)
                Case CarouselSize.FullPage.ToString
                    Return CarouselSize.FullPage
                Case CarouselSize.Medium.ToString
                    Return CarouselSize.Medium
                Case CarouselSize.Mini.ToString
                    Return CarouselSize.Mini
            End Select
            Return True
        End If

        If d Is dButtonSize Then
            Select Case Content(dButtonSize)
                Case ButtonSize.Block.ToString
                    Return ButtonSize.Block
                Case ButtonSize.Flat.ToString
                    Return ButtonSize.Flat
                Case ButtonSize.Large.ToString
                    Return ButtonSize.Large
                Case ButtonSize.Small.ToString
                    Return ButtonSize.Small
            End Select
            Return True
        End If

        If d Is dDefaultColor Then
            Select Case Content(dDefaultColor)
                Case DefaultColor.Danger.ToString
                    Return DefaultColor.Danger
                Case DefaultColor.Dark.ToString
                    Return DefaultColor.Dark
                Case DefaultColor.Info.ToString
                    Return DefaultColor.Info
                Case DefaultColor.Light.ToString
                    Return DefaultColor.Light
                Case DefaultColor.Primary.ToString
                    Return DefaultColor.Primary
                Case DefaultColor.Secondary.ToString
                    Return DefaultColor.Secondary
                Case DefaultColor.Success.ToString
                    Return DefaultColor.Success
                Case DefaultColor.Warning.ToString
                    Return DefaultColor.Warning
            End Select
            Return True
        End If

        If d Is dImageStyle Then
            Select Case Content(dImageStyle)
                Case Border.Arched.ToString
                    Return Border.Arched
                Case Border.Circular.ToString
                    Return Border.Circular
                Case Border.Flat.ToString
                    Return Border.Flat
                    Return True
            End Select

            If d Is dListStyle Then
                Dim ic As New iNovation.iNCode.Snippets()
                Select Case Content(dListStyle)
                    Case ic.DropDownListStyle.Custom.ToString
                        Return ic.DropDownListStyle.Custom
                    Case ic.DropDownListStyle.Standard.ToString
                        Return ic.DropDownListStyle.Standard
                    Case ic.DropDownListStyle.None.ToString
                        Return ic.DropDownListStyle.None
                End Select
            End If
            Return True
        End If


    End Function
#End Region

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        f.welcome("Opening Snippets")

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
        dControls.DataSource = s.Controls_List
        dAll.DataSource = s.All_List
        dShoppy.DataSource = s.Input_List
        dMaterialize.DataSource = s.Materialize_List
        dBootstrap.DataSource = s.Bootstrap_List
        dCarouselSize.DataSource = s.CarouselSize_List
        dButtonSize.DataSource = s.ButtonSize_List
        dDefaultColor.DataSource = s.DefaultColors_List
        dImageStyle.DataSource = s.Border_List
        dListStyle.DataSource = s.DropDownListStyle_List
        dEStore.DataSource = s.EStore_List
        dEStoreProgressBarColor.DataSource = s.EStoreProgressBarColorIsList
        dEStoreCSSClass.DataSource = s.EStoreTableCSSClassList

        SoundsMenuItem.Checked = SoundsOn

        UIHasLoaded = True
    End Sub

    Private Sub dControls_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dControls.KeyPress, dAll.KeyPress, dMaterialize.KeyPress, dShoppy.KeyPress, dBootstrap.KeyPress, dCarouselSize.KeyPress, dButtonSize.KeyPress, dDefaultColor.KeyPress, dImageStyle.KeyPress, dListStyle.KeyPress, dEStoreProgressBarColor.KeyPress
        AllowNothing(e)
    End Sub

    Private Sub dControls_SelectedIndexChanged(sender As Object, e As EventArgs) 'Handles dControls.SelectedIndexChanged, dAll.SelectedIndexChanged, dShoppy.SelectedIndexChanged, dMaterialize.SelectedIndexChanged, dBootstrap.SelectedIndexChanged, dCarouselSize.SelectedIndexChanged, dButtonSize.SelectedIndexChanged, dDefaultColor.SelectedIndexChanged, dImageStyle.SelectedIndexChanged, dListStyle.SelectedIndexChanged, dVB.SelectedIndexChanged, dCS.SelectedIndexChanged
        Dim selected, control_
        selected = ContentOf(sender)
        control_ = sender
        '		Generate_Snippet(ContentOf(sender), sender)
        '		bGenerate_Click(sender, e)

        'Try
        '	tSnippetWeb.Text = ContentOf(sender).ToString
        '	tSnippetDesktop.Text = CType(sender, Control).Name
        'Catch
        'End Try
    End Sub

    '	Private Sub Generate_Snippet(selected, control_) '(sender As Object, e As EventArgs) 'Handles bGenerate.Click
    '		If control_ IsNot dVB And control_ IsNot dCS Then
    '			Clear(tSnippetWeb)
    '		ElseIf control_ Is dVB Or control_ Is dCS Then
    '			Clear(tSnippetDesktop)
    '		End If
    '		Dim control_is As ControlsFrom = ContentOf(dControls)
    '		Dim size As ButtonSize = ContentOf(dButtonSize)
    '		Dim color As DefaultColor = ContentOf(dDefaultColor)

    '		If control_ Is dShoppy Then
    '			s.css_framework__ = CSSFramework.Shoppy
    '		ElseIf control_ Is dMaterialize Then
    '			s.css_framework__ = CSSFramework.Materialize
    '		ElseIf control_ Is dBootstrap Then
    '			s.css_framework__ = CSSFramework.Bootstrap
    '		End If

    '		Dim r As String
    '		'all
    '		If selected = All.Image Then
    '			r = s.Image(ContentOf(dImageStyle), ContentOf(dControls))
    '			GoTo 3
    '		End If
    '		If selected = All.UpdatePanel Then
    '			r = s.UpdatePanel()
    '			GoTo 3
    '		End If
    '		'shoppy
    '		If selected = Shoppy.DeclareCSS Then
    '			r = s.DeclareCSS_Shoppy
    '			GoTo 3
    '		End If
    '		If selected = Shoppy.DeclareJS Then
    '			r = s.DeclareJS_Shoppy
    '			GoTo 3
    '		End If
    '		'materialize
    '		If selected = Materialize.Button Then
    '			r = s.Button_Materialize(Content(dButtonSize))
    '			GoTo 3
    '		End If
    '		If selected = Materialize.Card Then
    '			r = s.Card_Materialize()
    '			GoTo 3
    '		End If
    '		If selected = Materialize.Card_Reveal Then
    '			r = s.Card_Reveal_Materialize(ContentOf(dControls))
    '			GoTo 3
    '		End If
    '		If selected = Materialize.Carousel Then
    '			If ContentOf(dCarouselSize) = CarouselSize.FullPage Then
    '			ElseIf ContentOf(dCarouselSize) = CarouselSize.Medium Then
    '				r = s.Carousel_Medium_Materialize(Content(dItems), control_is)
    '			ElseIf ContentOf(dCarouselSize) = CarouselSize.Mini Then
    '				r = s.Carousel_Mini_Materialize(Content(dItems), control_is)
    '			End If
    '			GoTo 3
    '		End If
    '		If selected = Materialize.Collapsible Then
    '			r = s.Collapsible_Materialize(Content(dItems))
    '			GoTo 3
    '		End If
    '		If selected = Materialize.Collection Then
    '			r = s.Collection_Materialize(Content(dItems))
    '			GoTo 3
    '		End If
    '		If selected = Materialize.Collection_With_Title_Secondary_Content Then
    '			r = s.Collection_With_Title_Secondary_Content_Materialize(Content(dItems))
    '			GoTo 3
    '		End If
    '		If selected = Materialize.DeclareCSS Then
    '			r = s.DeclareCSS_Materialize()
    '			GoTo 3
    '		End If
    '		If selected = Materialize.DeclareJS Then
    '			r = s.DeclareJS_Materialize()
    '			GoTo 3
    '		End If
    '		If selected = Materialize.DropDownList Then
    '			r = s.DropDownList_Materialize()
    '			GoTo 3
    '		End If
    '		If selected = Materialize.GridView Then
    '			r = s.GridView_Materialize()
    '			GoTo 3
    '		End If
    '		If selected = Materialize.MaterialBox Then
    '			r = s.MaterialBox()
    '			GoTo 3
    '		End If
    '		If selected = Materialize.Modal Then
    '			r = s.Modal_Materialize()
    '			GoTo 3
    '		End If
    '		If selected = Materialize.NewPage Then
    '			r = s.NewPage_Materialize()
    '			GoTo 3
    '		End If
    '		If selected = Materialize.Parallax Then
    '			r = s.Parallax(Content(dItems), control_is)
    '			GoTo 3
    '		End If
    '		If selected = Materialize.TextBox Then
    '			r = s.TextBox_Materialize()
    '			GoTo 3
    '		End If
    '		If selected = Materialize.Tooltip Then
    '			r = s.Tooltip_Materialize()
    '			GoTo 3
    '		End If
    '		'bootstrap
    '		If selected = Bootstrap.Button Then
    '			r = s.Button_Bootstrap(size, color)
    '			GoTo 3
    '		End If
    '		If selected = Bootstrap.Card Then
    '			GoTo 3

    '		End If
    '		If selected = Bootstrap.Carousel Then
    '			GoTo 3

    '		End If
    '		If selected = Bootstrap.Collapsible Then
    '			GoTo 3

    '		End If
    '		If selected = Bootstrap.Collection Then
    '			GoTo 3

    '		End If
    '		If selected = Bootstrap.DeclareCSS Then
    '			r = s.DeclareCSS_Bootstrap()
    '			GoTo 3
    '		End If
    '		If selected = Bootstrap.DeclareJS Then
    '			r = s.DeclareJS_Bootstrap
    '			GoTo 3
    '		End If
    '		If selected = Bootstrap.DropDownList Then
    '			r = s.DropDownList_Bootstrap(Content(dListStyle))
    '			GoTo 3
    '		End If
    '		If selected = Bootstrap.FormGroup Then
    '			r = s.FormGroup_Bootstrap()
    '			GoTo 3
    '		End If
    '		If selected = Bootstrap.GridView Then
    '			r = s.GridView_Bootstrap()
    '			GoTo 3
    '		End If
    '		If selected = Bootstrap.Modal Then
    '			r = s.Modal_Bootstrap()
    '			GoTo 3
    '		End If
    '		If selected = Bootstrap.NewPage Then
    '			r = s.NewPage_Bootstrap()
    '			GoTo 3
    '		End If
    '		If selected = Bootstrap.TextBox Then
    '			r = s.TextBox_Bootstrap()
    '			GoTo 3
    '		End If
    '		'vb
    '		If selected = VB.Import Then
    '			r = s.Imports_VB(New ImportGroupToInclude With {.Bank = hBank.Checked, .Desktop = hDesktop.Checked, .Email = hEmail.Checked, .Encryption = hEncryption.Checked, .Log = hLog.Checked, .NetApps = hNetApps.Checked, .Standard = hStandard.Checked, .Statistics = hStatistics.Checked, .Web = hWeb.Checked})
    '			GoTo 3
    '		End If
    '		If selected = VB.NewFile Then
    '			r = s.NewFile_VB()
    '			GoTo 3
    '		End If
    '		'cs
    '		If selected = CS.Import Then
    '			r = s.Imports_CS(New ImportGroupToInclude With {.Bank = hBank.Checked, .Desktop = hDesktop.Checked, .Email = hEmail.Checked, .Encryption = hEncryption.Checked, .Log = hLog.Checked, .NetApps = hNetApps.Checked, .Standard = hStandard.Checked, .Statistics = hStatistics.Checked, .Web = hWeb.Checked})
    '			GoTo 3
    '		End If
    '		If selected = CS.NewFile Then
    '			r = s.NewFile_CS()
    '			GoTo 3
    '		End If

    '3:
    '		If control_ IsNot dVB And control_ IsNot dCS Then
    '			tSnippetWeb.Text = r
    '		ElseIf control_ Is dVB Or control_ Is dCS Then
    '			tSnippetDesktop.Text = r
    '		End If
    '		If r.Length > 1 Then Clipboard.SetText(r)
    '	End Sub

    Private Sub dAll_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dAll.SelectedIndexChanged
        If Not UIHasLoaded Then Return
        On Error Resume Next
        'all
        Dim r As String = ""
        If Content(dAll) = All.Image.ToString Then
            r = s.Image(ContentOf(dImageStyle), ContentOf(dControls))
            'GoTo 3
        ElseIf Content(dAll) = All.UpdatePanel.ToString Then
            r = s.UpdatePanel()
            'GoTo 3
        End If
        tSnippetWeb.Text = r
        If r.Length > 1 Then Clipboard.SetText(r)
    End Sub

    Private Sub dEStore_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dEStore.SelectedIndexChanged
        If Not UIHasLoaded Then Return

        On Error Resume Next
        'EStore
        Dim r As String = ""
        If Content(dEStore) = EStore.Blockquote.ToString Then
            r = s.Blockquote_EStore
        ElseIf Content(dEStore) = EStore.ProgressBar.ToString Then
            r = s.ProgressBar_EStore(Content(dEStoreProgressBarColor))
        ElseIf Content(dEStore) = EStore.Table.ToString Then
            r = s.Table_EStore(Val(Content(dEStoreRows)), Val(Content(dEStoreColumns)))
        ElseIf Content(dEStore) = EStore.Carousel.ToString Then
            r = s.Carousel_EStore(Val(Content(dItems)))
        End If
        tSnippetWeb.Text = r
        If r.Length > 1 Then Clipboard.SetText(r)
    End Sub

    Private Sub dShoppy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dShoppy.SelectedIndexChanged
        If Not UIHasLoaded Then Return
        On Error Resume Next
        'shoppy
        Dim r As String = s.html(Content(dShoppy))
        tSnippetWeb.Text = r
        If r.Length > 1 Then Clipboard.SetText(r)
    End Sub

    Private Sub dMaterialize_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dMaterialize.SelectedIndexChanged
        If Not UIHasLoaded Then Return
        On Error Resume Next
        'materialize
        Dim r As String = ""
        Dim selected = Content(dMaterialize)
        Dim control_is As ControlsFrom = ContentOf(dControls)

        If selected = Materialize.Button.ToString Then
            r = s.Button_Materialize(ContentOf(dButtonSize))

        ElseIf selected = Materialize.Card.ToString Then
            r = s.Card_Materialize()

        ElseIf selected = Materialize.Card_Reveal.ToString Then
            r = s.Card_Reveal_Materialize(ContentOf(dControls))

        ElseIf selected = Materialize.Carousel.ToString Then
            If ContentOf(dCarouselSize) = CarouselSize.FullPage Then
            ElseIf ContentOf(dCarouselSize) = CarouselSize.Medium Then
                r = s.Carousel_Medium_Materialize(Content(dItems), control_is)
            ElseIf ContentOf(dCarouselSize) = CarouselSize.Mini Then
                r = s.Carousel_Mini_Materialize(Content(dItems), control_is)
            End If

        ElseIf selected = Materialize.Carousel_Full_Width.ToString Then
            r = s.Carousel_Full_Width_Materialize(Content(dItems))

        ElseIf selected = Materialize.Collapsible.ToString Then
            r = s.Collapsible_Materialize(Content(dItems))

        ElseIf selected = Materialize.Collection.ToString Then
            r = s.Collection_Materialize(Content(dItems))

        ElseIf selected = Materialize.Collection_With_Title_Secondary_Content.ToString Then
            r = s.Collection_With_Title_Secondary_Content_Materialize(Content(dItems))
            'ElseIf selected = Materialize.DeclareCSS.ToString Then
            '	r = s.DeclareCSS_Materialize()
            'ElseIf selected = Materialize.DeclareJS.ToString Then
            '	r = s.DeclareJS_Materialize()

        ElseIf selected = Materialize.DropDownList.ToString Then
            r = s.DropDownList_Materialize(Content(dItems), control_is)

        ElseIf selected = Materialize.GridView.ToString Then
            r = s.GridView_Materialize()

        ElseIf selected = Materialize.GridView_Cart.ToString Then
            r = s.GridView_Cart_Materialize()

        ElseIf selected = Materialize.MaterialBox.ToString Then
            r = s.MaterialBox(control_is)

        ElseIf selected = Materialize.Modal.ToString Then
            r = s.Modal_Materialize()
            'ElseIf selected = Materialize.NewPage.ToString Then
            '	r = s.NewPage_Materialize()

        ElseIf selected = Materialize.Parallax.ToString Then
            r = s.Parallax(Content(dItems), control_is)

        ElseIf selected = Materialize.TextBox.ToString Then
            r = s.TextBox_Materialize()

        ElseIf selected = Materialize.Tooltip.ToString Then
            r = s.Tooltip_Materialize()

        ElseIf selected = Materialize.TextArea.ToString Then
            r = s.TextArea_Materialize()

        ElseIf selected = Materialize.Checkbox.ToString Then
            r = s.Checkbox_Materialize

        End If
        If checkReact.Checked = True Then r = ReactText(r)
        tSnippetWeb.Text = r
        If r.Length > 1 Then Clipboard.SetText(r)
    End Sub

    Private Sub dBootstrap_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dBootstrap.SelectedIndexChanged
        If Not UIHasLoaded Then Return
        On Error Resume Next
        'bootstrap
        Dim r As String = ""
        Dim selected = Content(dBootstrap)
        Dim control_is As ControlsFrom = ContentOf(dControls)
        Dim size As ButtonSize = ContentOf(dButtonSize)
        Dim color As DefaultColor = ContentOf(dDefaultColor)

        If selected = Bootstrap.Button.ToString Then
            r = s.Button_Bootstrap(size, color)
        ElseIf selected = Bootstrap.Card.ToString Then
            r = s.Card_Bootstrap
        ElseIf selected = Bootstrap.Carousel.ToString Then
            r = s.Carousel(Content(dCarouselSize), Content(dItems))
        ElseIf selected = Bootstrap.Collapsible.ToString Then
            r = s.Collapsible_Bootstrap(Content(dItems))
        ElseIf selected = Bootstrap.Collection.ToString Then
            'ElseIf selected = Bootstrap.DeclareCSS.ToString Then
            '	r = s.DeclareCSS_Bootstrap()
            'ElseIf selected = Bootstrap.DeclareJS.ToString Then
            '	r = s.DeclareJS_Bootstrap
        ElseIf selected = Bootstrap.DropDownList.ToString Then
            '			r = s.DropDownList_Bootstrap(Content(dListStyle))
            '			r = s.DropDownList_Bootstrap()
            Dim style_ As String = ""
            If Content(dListStyle).ToLower = "custom" Then
                style_ = " class=""custom-select"""
            ElseIf Content(dListStyle).ToLower = "standard" Then
                style_ = " class=""form-control"""
            End If
            r = s.DropDownList_Materialize(Content(dItems), control_is, style_)

        ElseIf selected = Bootstrap.FormGroup.ToString Then
            r = s.FormGroup_Bootstrap()
        ElseIf selected = Bootstrap.GridView.ToString Then
            r = s.GridView_Bootstrap()
        ElseIf selected = Bootstrap.GridView_Cart.ToString Then
            r = s.GridView_Cart_Bootstrap()
        ElseIf selected = Bootstrap.Modal.ToString Then
            r = s.Modal_Bootstrap()
            'ElseIf selected = Bootstrap.NewPage.ToString Then
            '	r = s.NewPage_Bootstrap()
        ElseIf selected = Bootstrap.TextBox.ToString Then
            r = s.TextBox_Bootstrap()
        ElseIf selected = Bootstrap.Checkbox.ToString Then
            r = s.Checkbox_Bootstrap
        ElseIf selected = Bootstrap.Badge.ToString Then
            r = s.Badge_Bootstrap(ContentOf(dDefaultColor))
        ElseIf selected = Bootstrap.Jumbotron.ToString Then
            r = s.Jumbotron_Bootstrap

        End If
        If checkReact.Checked = True Then r = ReactText(r)
        tSnippetWeb.Text = r
        If r.Length > 1 Then Clipboard.SetText(r)
    End Sub

    Private Sub bGenerate_Click(sender As Object, e As EventArgs) Handles bGenerate.Click
        EnableControl(sender, False)
        Dim counter As Integer = 0
        For Each form As Form In My.Application.OpenForms
            If form Is Form2 Then counter += 1
        Next
        If counter < 1 Then
            f.say("Opening dot net framework section")
        End If

        Form2.Show() 'Dialog()
        Form2.Focus()
        EnableControl(sender)
    End Sub

    Private Sub bAndroid_Click(sender As Object, e As EventArgs) Handles bAndroid.Click
        'EnableControl(sender, False)
        Dim counter As Integer = 0
        For Each form As Form In My.Application.OpenForms
            If form Is Android Then counter += 1
        Next
        If counter < 1 Then
            f.say("Opening android section")
        End If
        Android.Show()
        Android.Focus()
        'EnableControl(sender)
    End Sub

    Private Sub DefaultActionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefaultActionsToolStripMenuItem.Click
        CloseButton_Click(sender, e)
    End Sub

    Private Sub dEStoreCSSClass_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dEStoreCSSClass.SelectedIndexChanged
        If Not UIHasLoaded Then Return
        On Error Resume Next
        'EStore Table CSS Class
        Dim r As String = s.Table_EStore_CSSClass(Content(dEStoreCSSClass))
        tSnippetWeb.Text = r
        If r.Length > 1 Then Clipboard.SetText(r)
    End Sub

    Private Sub bReact_Click(sender As Object, e As EventArgs) Handles bReact.Click

        EnableControl(sender, False)
        f.say("The React section is not available yet.")
        EnableControl(sender)
        Return




        Dim counter As Integer = 0
        For Each form As Form In My.Application.OpenForms
            If form Is React Then counter += 1
        Next
        If counter < 1 Then
            f.say("Opening React section")
        End If
        React.Show()
        React.Focus()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Return

    End Sub

    Private Sub bXamarin_Click(sender As Object, e As EventArgs) Handles bXamarin.Click
        EnableControl(sender, False)
        Dim counter As Integer = 0
        For Each form As Form In My.Application.OpenForms
            If form Is Xamarin Then counter += 1
        Next
        If counter < 1 Then
            f.say("Opening Xamarin section")
        End If

        Xamarin.Show() 'Dialog()
        Xamarin.Focus()
        EnableControl(sender)

    End Sub

    Private Sub buttonPythonPlusAI_Click(sender As Object, e As EventArgs) Handles buttonPythonPlusAI.Click
        'EnableControl(sender, False)
        Dim counter As Integer = 0
        For Each form As Form In My.Application.OpenForms
            If form Is PythonPlusAI Then counter += 1
        Next
        If counter < 1 Then
            f.say("Opening Python and AI section")
        End If
        PythonPlusAI.Show()
        PythonPlusAI.Focus()
        'EnableControl(sender)
    End Sub


    Private Sub buttonWeb_Click(sender As Object, e As EventArgs) Handles buttonWeb.Click
        'EnableControl(sender, False)
        Dim counter As Integer = 0
        For Each form As Form In My.Application.OpenForms
            If form Is WebSection Then counter += 1
        Next
        If counter < 1 Then
            f.say("Opening dot net core section")
        End If
        WebSection.Show()
        WebSection.Focus()
        'EnableControl(sender)

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        CloseButton_Click(sender, e)
    End Sub

    Private Sub buttonSpringBoot_Click(sender As Object, e As EventArgs) Handles buttonSpringBoot.Click
        'EnableControl(sender, False)
        Dim counter As Integer = 0
        For Each form As Form In My.Application.OpenForms
            If form Is SpringBoot Then counter += 1
        Next
        If counter < 1 Then
            f.say("Opening spring boot section")
        End If
        SpringBoot.Show()
        SpringBoot.Focus()
        'EnableControl(sender)

    End Sub

    Private Sub SoundsMenuItem_Click(sender As Object, e As EventArgs) Handles SoundsMenuItem.Click
        Dim state As Boolean = If(SoundsMenuItem.Checked, False, True)
        UpdateSoundsOn(state)
        SoundsMenuItem.Checked = state
    End Sub
End Class
