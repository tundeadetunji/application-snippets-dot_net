#Region "Imports"
Imports iNovation.Code.General
Imports iNovation.Code.Desktop
Imports iNovation.Code.Machine
Imports iNovation.Code.Sequel

Imports Snippets.SnippetsDesktopInternalTypes
Imports iNovation.iNCode.Converter
Imports iNovation.iNCode.Docs
Imports iNovation.iNCode.Snippets
Imports iNovation.iNCode.Startup
Imports Microsoft.VisualBasic.Devices
Imports System.Collections.ObjectModel
#End Region

Public Class Form2

#Region "Fields"
	Private s As New iNovation.iNCode.Snippets()
    Private ReadOnly Property con_string__ As String = "Data Source=" & Environment.MachineName & "\SQLEXPRESS;Initial Catalog=" & Environment.GetEnvironmentVariable(SnippetsDesktopEnvironmentVariableKey.InitialCatalog.ToString, EnvironmentVariableTarget.User) & ";Persist Security Info=True;User ID=" & Environment.GetEnvironmentVariable(SnippetsDesktopEnvironmentVariableKey.UserId.ToString, EnvironmentVariableTarget.User) & ";Password=" & Environment.GetEnvironmentVariable(SnippetsDesktopEnvironmentVariableKey.Password.ToString, EnvironmentVariableTarget.User)
    Private Property fields_ As Array
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

#Region "Helper Functions"
	Private Sub HideControls()
		DialogTitle.Hide()
		TopLine.Hide()
		BottomLine.Hide()
		'MinimizeButton.Hide()
		brand.BringToFront()
	End Sub

	Private Function SelectedLanguage()
		Select Case Content(dProgrammingLanguage)
			Case ProgrammingLanguage.CS.ToString
				Return ProgrammingLanguage.CS
			Case ProgrammingLanguage.VB.ToString
				Return ProgrammingLanguage.VB
		End Select
	End Function

#End Region
	Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        GetTables(Me.con_string__)
2:
        dProgrammingLanguage.DataSource = s.ProgrammingLanguage_List
		dCSS.DataSource = s.CSSFramework_List
		dConsole.DataSource = New iNovation.iNCode.Startup().OperationList_List
		dConfiguration.DataSource = New iNovation.iNCode.Startup().Web_List
		dMaterialize.DataSource = New iNovation.iNCode.Startup().Materialize_List
		dBootstrap.DataSource = New iNovation.iNCode.Startup().Bootstrap_List
		dSite.DataSource = New iNovation.iNCode.Startup().Site_List
		dCode.DataSource = New iNovation.iNCode.Startup().Code_List
		dEStore.DataSource = New iNovation.iNCode.Startup().EStore_List
		dShoppy.DataSource = New iNovation.iNCode.Startup().Shoppy_List
		Clear(dItems, 3)

		Try
			tSnippet.Clear()
		Catch ex As Exception

		End Try

		Clear(dOperation)
		With dOperation
			With .Items
				.Add("Files")
				.Add("SQL")
			End With
			.SelectedIndex = -1
		End With
		UIHasLoaded = True
	End Sub

    Private Sub GetTables(con_string As String)
        Try
            BindProperty(dTables, PropertyToBind.Items, BuildSelectString("sys.Tables", {"name"}, Nothing, "name"), If(con_string Is Nothing, Me.con_string__, con_string__), Nothing, "name")
        Catch
        End Try

    End Sub

    Private Sub dTables_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dTables.SelectedIndexChanged
        If Not UIHasLoaded Then Return
        On Error Resume Next

        Dim q__ As String = BuildSelectString(Content(dTables))
        Display(gData, q__, con_string__)

        Dim l As New List(Of String)
        With gData
            For i As Integer = 0 To .Columns.Count - 1
                l.Add(.Columns.Item(i).HeaderText)
            Next
        End With
        fields_ = l.ToArray
        dUpdateKey.DataSource = l

        If dUpdateKey.Text.Trim.Length < 1 Then dUpdateKey.Focus()
        'lfocus(sender, dUpdateKey)
    End Sub

    Private Function DataForNewInternal(con_string__ As String) As Array
		Dim q__ As String = BuildSelectString("sys.Tables", {"name"}, Nothing)
		Display(g1, q__, con_string__)

		If g1.Rows.Count < 1 Then Return Nothing

		Dim lTables As New List(Of String)
		Dim lColumns As New List(Of String)

		With g1
			For i As Integer = 0 To .Rows.Count - 1
				lTables.Add(g1.Rows(i).Cells(0).Value)
			Next
		End With

		lTables.Sort()
		With lTables
			For i As Integer = 0 To .Count - 1
				Display(g2, BuildSelectString(lTables(i)), con_string__)
				For j As Integer = 0 To g2.Columns.Count - 1
					If g2.Columns.Item(j).HeaderText.ToLower.Contains("password") Or
						g2.Columns.Item(j).HeaderText.ToLower.Contains("paystack") Or
						g2.Columns.Item(j).HeaderText.ToLower.Contains("mail") Then
						lColumns.Add("k_" & g2.Columns.Item(j).HeaderText & "_From_" & lTables(i))
					End If
				Next
			Next
		End With

		Return lColumns.ToArray
	End Function

	Private Sub dConsole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dConsole.SelectedIndexChanged
		If Not UIHasLoaded Then Return
		On Error Resume Next
		If IsEmpty(dUpdateKey) Then Return

        Dim groups_to_include As ImportGroupToInclude = New ImportGroupToInclude With {.Bank = True, .Desktop = True, .Email = True, .Encryption = True, .Log = True, .Standard = True, .Statistics = True, .Web = True, .Scanning = True}

        Clear(tSnippet)
		Dim r As String = ""
		Dim s As New iNovation.iNCode.Startup(fields_)
		Select Case Content(dConsole)
			Case OperationList.NewFile_dll.ToString
				Select Case Content(dProgrammingLanguage)
					Case ProgrammingLanguage.VB.ToString
						Select Case Content(hEncryption)
							Case True
                                r = s.NewFile_VB_Encryption(QDataTypes(BuildSelectString(Content(dTables)), con_string__), Content(dTables), Content(dUpdateKey), groups_to_include, Content(dProgrammingLanguage))
                            Case False
                                r = s.NewFile_VB(QDataTypes(BuildSelectString(Content(dTables)), con_string__), Content(dTables), Content(dUpdateKey), groups_to_include, Content(dProgrammingLanguage))
                        End Select
					Case ProgrammingLanguage.CS.ToString
				End Select
			'Case OperationList.NewInternal_dll.ToString
			'	Select Case Content(dProgrammingLanguage)
			'		Case ProgrammingLanguage.VB.ToString
			'			r = s.NewInternal_VB(DataForNewInternal(GetText("", con_string__)))
			'		Case ProgrammingLanguage.CS.ToString
			'	End Select
			Case OperationList.ProfileData_sql.ToString
				r = s.ProfileData
			Case OperationList.Profiles_sql.ToString
				r = s.Profiles
			Case OperationList.Validation_Before_Add_vb.ToString
				Select Case Content(dProgrammingLanguage)
					Case ProgrammingLanguage.VB.ToString
						r = s.Validation_Before_Add_VB
					Case ProgrammingLanguage.CS.ToString
				End Select
			Case OperationList.HTTP_js.ToString
				r = s.HTTP_JS
			Case OperationList.Validation_Before_Register_vb.ToString
				Select Case Content(dProgrammingLanguage)
					Case ProgrammingLanguage.VB.ToString
						r = s.Validation_Before_Register_VB
					Case ProgrammingLanguage.CS.ToString
				End Select
		End Select
		tSnippet.Text = r
		If r.Length > 0 Then Clipboard.SetText(r)
	End Sub

	Private Sub dTables_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dTables.KeyPress, dUpdateKey.KeyPress, dProgrammingLanguage.KeyPress, dConsole.KeyPress, dCode.KeyPress, dConfiguration.KeyPress, dSite.KeyPress, dMaterialize.KeyPress, dBootstrap.KeyPress, dShoppy.KeyPress, dOperation.KeyPress, dCSS.KeyPress
		AllowNothing(e)
	End Sub

	Private Sub dConfiguration_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dConfiguration.SelectedIndexChanged
		If Not UIHasLoaded Then Return
		On Error Resume Next
		Clear(tSnippet)
		Dim r As String = ""
		Dim s As New iNovation.iNCode.Startup()
		Select Case Content(dConfiguration)
			Case Web.Authentication.ToString
				r = s.Authentication()
			Case Web.ConnectionSrings.ToString
				r = s.ConnectionSrings
			Case Web.CustomErrors.ToString
				r = s.CustomErrors
			Case Web.Filter.ToString
				r = s.Filter
			Case Web.Rewrite.ToString
				r = s.Rewrite
			Case Web.Trace.ToString
				r = s.Trace
			Case Web.httpCookies.ToString
				r = s.httpCookies
			Case Web.Profile.ToString
				r = s.Profile
		End Select
		tSnippet.Text = r
		If r.Length > 0 Then Clipboard.SetText(r)
	End Sub

	Private Sub dMaterialize_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dMaterialize.SelectedIndexChanged
		If Not UIHasLoaded Then Return
		On Error Resume Next
		Clear(tSnippet)
		Dim r As String = ""
		Dim s As New iNovation.iNCode.Startup(fields_)
		s.control_is = Content(Form1.dControls)

		Select Case Content(dMaterialize)
			Case iNovation.iNCode.Startup.Materialize.Header.ToString
				r = s.Header_Materialize()
			Case iNovation.iNCode.Startup.Materialize.Main.ToString
                r = s.Main_Materialize
            Case iNovation.iNCode.Startup.Materialize.Header_NoLogin.ToString
				r = s.Header_NoLogin_Materialize
			Case iNovation.iNCode.Startup.Materialize.Activated_HTML.ToString
				r = s.Activated_HTML_Materialize
			Case iNovation.iNCode.Startup.Materialize.CustomErrorHTML.ToString
				r = s.CustomErrorHTML_Materialize
			Case iNovation.iNCode.Startup.Materialize.Forgot_HTML.ToString
				r = s.Forgot_HTML_Materialize
			Case iNovation.iNCode.Startup.Materialize.Welcome_ActivateAccount_HTML.ToString
				r = s.Welcome_ActivateAccount_HTML_Materialize
			Case iNovation.iNCode.Startup.Materialize.InputGroup.ToString
				r = s.InputGroup_Materialize
			Case iNovation.iNCode.Startup.Materialize.NewHTML.ToString
				r = s.NewHTML_Materialize
			Case iNovation.iNCode.Startup.Materialize.Header_Shop.ToString
				r = s.Header_Shop_Materialize
			Case iNovation.iNCode.Startup.Materialize.DeclareCSS.ToString
				r = s.DeclareCSS_Materialize
			Case iNovation.iNCode.Startup.Materialize.DeclareJS.ToString
				r = s.DeclareJS_Materialize
			Case iNovation.iNCode.Startup.Materialize.NewPage.ToString
				r = s.NewPage_Materialize
			Case iNovation.iNCode.Startup.Materialize.Privacy.ToString
				r = s.Privacy_Materialize
			Case iNovation.iNCode.Startup.Materialize.TermsAndConditions.ToString
                r = s.TermsAndConditions_Materialize
            Case iNovation.iNCode.Startup.Materialize.Footer.tostring
                r = s.Footer_Materialize
        End Select
		If checkReact.Checked = True Then r = ReactText(r)
		tSnippet.Text = r
		If r.Length > 0 Then Clipboard.SetText(r)
	End Sub
	Private Sub dShoppy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dShoppy.SelectedIndexChanged
		If Not UIHasLoaded Then Return
		On Error Resume Next
		Clear(tSnippet)
		Dim r As String
		Dim s As New iNovation.iNCode.Startup(fields_)
		Select Case Content(dShoppy)
			Case iNovation.iNCode.Startup.Shoppy.DeclareCSS.ToString
				r = s.DeclareCSS_Shoppy
			Case iNovation.iNCode.Startup.Shoppy.DeclareJS.ToString
				r = s.DeclareJS_Shoppy
		End Select
		If checkReact.Checked = True Then r = ReactText(r)
		tSnippet.Text = r
		If r.Length > 0 Then Clipboard.SetText(r)

	End Sub

	Private Sub dEStore_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dEStore.SelectedIndexChanged
		If Not UIHasLoaded Then Return
		On Error Resume Next
		Clear(tSnippet)
		Dim r As String
		Dim s As New iNovation.iNCode.Startup(fields_)
		s.control_is = Content(Form1.dControls)
		Select Case Content(dEStore)
			Case iNovation.iNCode.Startup.EStore.DeclareCSS.ToString
				r = s.DeclareCSS_EStore
			Case iNovation.iNCode.Startup.EStore.DeclareJS.ToString
				r = s.DeclareJS_EStore
			Case iNovation.iNCode.Startup.EStore.Header.ToString
				r = s.Header_EStore
			Case iNovation.iNCode.Startup.EStore.Main.ToString
				r = s.Main_EStore
			Case iNovation.iNCode.Startup.EStore.Preloader.ToString
				r = s.Preloader_EStore
			Case iNovation.iNCode.Startup.EStore.Footer.ToString
				r = s.Footer_EStore
			Case iNovation.iNCode.Startup.EStore.Default_.ToString
				r = s.Default_EStore(Val(Content(dItems)))
			Case iNovation.iNCode.Startup.EStore.Login.ToString
				r = s.Login_EStore
			Case iNovation.iNCode.Startup.EStore.NewHTML.ToString
				r = s.NewHTML_EStore
			Case iNovation.iNCode.Startup.EStore.Contact.ToString
				r = s.Contact_EStore
			Case iNovation.iNCode.Startup.EStore.Privacy.ToString
				r = s.Privacy_Materialize
			Case iNovation.iNCode.Startup.EStore.TermsAndConditions.ToString
				r = s.TermsAndConditions_EStore
		End Select
		If checkReact.Checked = True Then r = ReactText(r)
		tSnippet.Text = r
		If r.Length > 0 Then Clipboard.SetText(r)
	End Sub

	Private Sub dSite_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dSite.SelectedIndexChanged
		If Not UIHasLoaded Then Return
		On Error Resume Next
		Clear(tSnippet)
		Dim r As String
		Dim s As New iNovation.iNCode.Startup()
		Select Case Content(dSite)
			Case iNovation.iNCode.Startup.Site.SupportFunctions.ToString
				r = s.HelperFunctions_VB_EStore

				'If Content(dCSS) <> CSSFramework.EStore.ToString Then
				'	Select Case Content(dProgrammingLanguage)
				'		Case ProgrammingLanguage.VB.ToString
				'			r = s.HelperFunctions_VB
				'		Case ProgrammingLanguage.CS.ToString
				'			r = s.HelperFunctions_CS
				'	End Select
				'ElseIf Content(dCSS) = CSSFramework.EStore.ToString Then
				'	Select Case Content(dProgrammingLanguage)
				'		Case ProgrammingLanguage.VB.ToString
				'			r = s.HelperFunctions_VB_EStore
				'		Case ProgrammingLanguage.CS.ToString
				'	End Select

				'End If
			Case iNovation.iNCode.Startup.Site.Load.ToString
				Select Case Content(dProgrammingLanguage)
					Case ProgrammingLanguage.VB.ToString
						r = s.Load_Site_VB
					Case ProgrammingLanguage.CS.ToString
						r = s.Load_Site_CS
				End Select
			Case iNovation.iNCode.Startup.Site.PreRender.ToString
				If Content(dCSS) <> CSSFramework.EStore.ToString Then
					Select Case Content(dProgrammingLanguage)
						Case ProgrammingLanguage.VB.ToString
							r = s.PreRender_VB
						Case ProgrammingLanguage.CS.ToString
							r = s.PreRender_CS
					End Select
				ElseIf Content(dCSS) = CSSFramework.EStore.ToString Then
					Select Case Content(dProgrammingLanguage)
						Case ProgrammingLanguage.VB.ToString
							r = s.PreRender_VB_Estore
						Case ProgrammingLanguage.CS.ToString
					End Select

				End If

			Case iNovation.iNCode.Startup.Site.Title.ToString
				r = s.Title
			Case iNovation.iNCode.Startup.Site.Internal.ToString
				Select Case Content(dProgrammingLanguage)
					Case ProgrammingLanguage.VB.ToString
						r = s.Internal_VB
					Case ProgrammingLanguage.CS.ToString
						r = s.Internal_CS
				End Select
			Case iNovation.iNCode.Startup.Site.LogOut.ToString
				Select Case Content(dProgrammingLanguage)
					Case ProgrammingLanguage.VB.ToString
						r = s.LogOut_VB
					Case ProgrammingLanguage.CS.ToString
						r = s.LogOut_CS
				End Select

		End Select
		tSnippet.Text = r
		If r.Length > 0 Then Clipboard.SetText(r)
	End Sub

	Private Sub dCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dCode.SelectedIndexChanged
		If Not UIHasLoaded Then Return
		On Error Resume Next
		Clear(tSnippet)
		Dim r As String
		Dim s As New iNovation.iNCode.Startup()
		Select Case Content(dCode)
			Case Code.Activated_Load.ToString
				Select Case Content(dProgrammingLanguage)
					Case ProgrammingLanguage.VB.ToString
						r = s.Activated_Load_VB
					Case ProgrammingLanguage.CS.ToString
				End Select
			Case Code.Database.ToString
				Select Case Content(dProgrammingLanguage)
					Case ProgrammingLanguage.VB.ToString
						r = s.Database_VB()
					Case ProgrammingLanguage.CS.ToString
				End Select
			Case Code.Forgot_SendResetEmail.ToString
				Select Case Content(dProgrammingLanguage)
					Case ProgrammingLanguage.VB.ToString
						r = s.Forgot_SendResetEmail_VB()
					Case ProgrammingLanguage.CS.ToString
				End Select
			Case Code.ImageHandler.ToString
				Select Case Content(dProgrammingLanguage)
					Case ProgrammingLanguage.VB.ToString
						r = s.ImageHandler_VB
					Case ProgrammingLanguage.CS.ToString
				End Select
			Case Code.Load.ToString
				Select Case Content(dProgrammingLanguage)
					Case ProgrammingLanguage.VB.ToString
						r = s.Load_VB
					Case ProgrammingLanguage.CS.ToString
				End Select
			Case Code.Load_Anonymous.ToString
				Select Case Content(dProgrammingLanguage)
					Case ProgrammingLanguage.VB.ToString
						r = s.Load_Anonymous_VB
					Case ProgrammingLanguage.CS.ToString
				End Select
			Case Code.Load_Mobile.ToString
				Select Case Content(dProgrammingLanguage)
					Case ProgrammingLanguage.VB.ToString
						r = s.Load_Mobile_VB
					Case ProgrammingLanguage.CS.ToString
				End Select
			Case Code.Login.ToString
				Select Case Content(dProgrammingLanguage)
					Case ProgrammingLanguage.VB.ToString
						r = s.Login_VB
					Case ProgrammingLanguage.CS.ToString
				End Select
			Case Code.Login_Load.ToString
				Select Case Content(dProgrammingLanguage)
					Case ProgrammingLanguage.VB.ToString
						r = s.Login_Load_VB
					Case ProgrammingLanguage.CS.ToString
				End Select
			Case Code.PageIndexChanging.ToString
				Select Case Content(dProgrammingLanguage)
					Case ProgrammingLanguage.VB.ToString
						r = s.PageIndexChanging_VB
					Case ProgrammingLanguage.CS.ToString
				End Select
			Case Code.Web_Anonymous.ToString
				Select Case Content(dProgrammingLanguage)
					Case ProgrammingLanguage.VB.ToString
						r = s.Web_Anonymous
					Case ProgrammingLanguage.CS.ToString
				End Select
			Case Code.Welcome_ActivateAccount_Load.ToString
				Select Case Content(dProgrammingLanguage)
					Case ProgrammingLanguage.VB.ToString
						r = s.Welcome_ActivateAccount_Load_VB
					Case ProgrammingLanguage.CS.ToString
				End Select
			Case Code.Welcome_ActivateAccount_Resend_Link.ToString
				Select Case Content(dProgrammingLanguage)
					Case ProgrammingLanguage.VB.ToString
						r = s.Welcome_ActivateAccount_Resend_Link_VB
					Case ProgrammingLanguage.CS.ToString
				End Select
			Case Code.Shop_Pre_Load.ToString
				Select Case Content(dProgrammingLanguage)
					Case ProgrammingLanguage.VB.ToString
						r = s.Shop_Pre_Load_VB
					Case ProgrammingLanguage.CS.ToString
						r = s.Shop_Pre_Load_CS
				End Select
			Case Code.Login_Profile.ToString
				Select Case Content(dProgrammingLanguage)
					Case ProgrammingLanguage.VB.ToString
						r = s.Login_Profile_VB
					Case ProgrammingLanguage.CS.ToString
				End Select
			Case Code.Logout_Profile.ToString
				Select Case Content(dProgrammingLanguage)
					Case ProgrammingLanguage.VB.ToString
						r = s.Logout_Profile_VB
					Case ProgrammingLanguage.CS.ToString
				End Select
			Case Code.Reset_Load.ToString
				Select Case Content(dProgrammingLanguage)
					Case ProgrammingLanguage.VB.ToString
						r = s.Reset_Load_VB
					Case ProgrammingLanguage.CS.ToString
				End Select
			Case Code.Reset_UpdatePassword.ToString
				Select Case Content(dProgrammingLanguage)
					Case ProgrammingLanguage.VB.ToString
						r = s.Reset_UpdatePassword_VB
					Case ProgrammingLanguage.CS.ToString
				End Select
		End Select
		tSnippet.Text = r
		If r.Length > 0 Then Clipboard.SetText(r)
	End Sub

	Private Sub SQL()
		If IsEmpty(dFiles) Then Return


        'Dim con_ As String = GetText("", con_string__)
        'If con_.Length < 1 Then Return


        EnableControl(dOperation, False)

        f.say("Building Tables")
		Try
			Dim files_ As ReadOnlyCollection(Of String) = My.Computer.FileSystem.GetFiles(Content(dFiles), FileIO.SearchOption.SearchTopLevelOnly, "*.sql")

			For i = 0 To files_.Count - 1
                CommitSequel(ReadText(files_(i)), con_string__)
            Next
			If files_.Count = 1 Then
				f.say("1 table has been created")
			ElseIf files_.Count > 1 Then
				f.say("Tables have been created")
			End If
		Catch
			f.say("Error encountered while creating tables.")
		Finally
			EnableControl(dOperation)
		End Try
	End Sub

	Private Sub bFiles_Click(sender As Object, e As EventArgs) Handles bFiles.Click
		If Content(dFiles).Length < 1 Then
			'			StartFile(files_)
			Return
		End If
		With dFiles
			'If Not .Items.Contains(.Text.Trim) Then
			'	.Items.Add(.Text.Trim)
			'End If
			target_ = .Text.Trim
		End With
		EnableControl(dOperation, False)
		CopyFiles()
		EnableControl(dOperation)
		'thread_CopyFiles.Start()
	End Sub
	Private Sub CopyFiles()
		Dim files_ As String = My.Application.Info.DirectoryPath & "\Files"

        If target_ Is Nothing Then Return
		If files_.Length < 1 Then
			f.say("please set the location of resources files first.")
			Return
		End If
		Dim root_ As String = Content(dFiles)
		Dim anonymous_ As String = root_ & "\space"
		Dim account_ As String = root_ & "\account"

		f.say("Copying to root directory")
		Try
			My.Computer.FileSystem.CopyDirectory(files_, root_, FileIO.UIOption.AllDialogs, FileIO.UICancelOption.DoNothing)
		Catch 'ex As System.Threading.ThreadStateException
			'			Return
			'			MsgBox(ex.ToString)
		End Try

		f.say("Copying to space directory")
		Try
			My.Computer.FileSystem.CopyDirectory(files_, anonymous_, FileIO.UIOption.AllDialogs, FileIO.UICancelOption.DoNothing)
		Catch 'ex As System.Threading.ThreadStateException
			'			Return
			'			MsgBox(ex.ToString)
		End Try

		f.say("Copying to Account directory")
		Try
			My.Computer.FileSystem.CopyDirectory(files_, account_, FileIO.UIOption.AllDialogs, FileIO.UICancelOption.DoNothing)
		Catch 'ex As System.Threading.ThreadStateException
			'			Return
			'			MsgBox(ex.ToString)
		End Try

		f.say("Files have been copied")
	End Sub

	Private thread_CopyFiles As New System.Threading.Thread(AddressOf CopyFiles)

	Private Sub dBootstrap_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dBootstrap.SelectedIndexChanged
		If Not UIHasLoaded Then Return
		On Error Resume Next
		Clear(tSnippet)
		Dim r As String = ""
		Dim s As New iNovation.iNCode.Startup(fields_)
		s.control_is = Content(Form1.dControls)
		Select Case Content(dBootstrap)
			Case iNovation.iNCode.Startup.Bootstrap.Header.ToString
				r = s.Header_Bootstrap()
			Case iNovation.iNCode.Startup.Bootstrap.Main.ToString
				r = s.Main_Bootstrap
			Case iNovation.iNCode.Startup.Bootstrap.Header_NoLogin.ToString
				r = s.Header_NoLogin_Bootstrap
			Case iNovation.iNCode.Startup.Bootstrap.InputGroup.ToString
				r = s.InputGroup_Bootstrap
			Case iNovation.iNCode.Startup.Bootstrap.NewHTML.ToString
				r = s.NewHTML_Bootstrap
			Case iNovation.iNCode.Startup.Bootstrap.Header_Shop.ToString
				r = s.Header_Shop_Bootstrap
			Case iNovation.iNCode.Startup.Bootstrap.DeclareCSS.ToString
				r = s.DeclareCSS_Bootstrap
			Case iNovation.iNCode.Startup.Bootstrap.DeclareJS.ToString
				r = s.DeclareJS_Bootstrap
			Case iNovation.iNCode.Startup.Bootstrap.NewPage.ToString
				r = s.NewPage_Bootstrap
			Case iNovation.iNCode.Startup.Bootstrap.Privacy.ToString
				r = s.Privacy_Materialize
			Case iNovation.iNCode.Startup.Bootstrap.TermsAndConditions.ToString
				r = s.TermsAndConditions_Materialize
		End Select
		If checkReact.Checked = True Then r = ReactText(r)
		tSnippet.Text = r
		If r.Length > 0 Then Clipboard.SetText(r)
	End Sub

	Private Sub dOperation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dOperation.SelectedIndexChanged
		If Not UIHasLoaded Then Return
		With dOperation
			If .Text = "Files" Then
				bFiles_Click(sender, e)
			ElseIf .Text = "SQL" Then
				SQL()
			End If
		End With
	End Sub

	Private Sub bWebsite_Click(sender As Object, e As EventArgs) Handles bWebsite.Click
        'EnableControl(sender, False)
        Dim counter As Integer = 0
        For Each form As Form In My.Application.OpenForms
			If form Is Website Then counter += 1
		Next
        If counter < 1 Then
            f.say("Opening dashboard section")
        End If

        Website.Show() 'Dialog()
		Website.Focus()
        'EnableControl(sender)

    End Sub

	Private Sub CustomConStringButton_Click(sender As Object, e As EventArgs) Handles CustomConStringButton.Click
		Dim con_string As String = GetText("Connection String", "", "Custom Connection String")
        If con_string.Trim.Length > 0 Then GetTables(con_string)

    End Sub
End Class