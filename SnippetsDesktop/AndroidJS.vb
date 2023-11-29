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
Imports iNovation.iNCode.AndroidJS
#End Region
Public Class AndroidJS
    Private Sub buttonSnippet_Click(sender As Object, e As EventArgs) Handles buttonSnippet.Click
        'EnableControl(sender, False)
        If IsEmpty({textPackage, textInterfaceClassName, textInterfaceMethod, textURL}) Then Return

        Dim s As New iNovation.iNCode.AndroidJS(Content(textPackage), Content(textInterfaceClassName), Content(textInterfaceMethod), Content(textURL))
        Dim snippets As Dictionary(Of String, String) = s.JSSnippets
        textInterfaceClassSnippet.Text = snippets.Item(JSSnippetsComponent.InterfaceClass.ToString)
        textStringsXMLSnippet.Text = snippets.Item(JSSnippetsComponent.StringsXML.ToString)
        textActivityOnCreateSnippet.Text = snippets.Item(JSSnippetsComponent.ActivityOnCreate.ToString)
        textSampleJSSnippet.Text = snippets.Item(JSSnippetsComponent.SampleJS.ToString)
        'EnableControl(sender)

    End Sub

    Private Sub buttonCopyInterfaceClassSnippet_Click(sender As Object, e As EventArgs) Handles buttonCopyInterfaceClassSnippet.Click
        'EnableControl(sender, False)
        If IsEmpty(textInterfaceClassSnippet) = False Then
            Clipboard.SetText(Content(textInterfaceClassSnippet))
        End If
        'EnableControl(sender)
    End Sub

    Private Sub buttonCopyStringsXML_Click(sender As Object, e As EventArgs) Handles buttonCopyStringsXML.Click
        'EnableControl(sender, False)
        If IsEmpty(textStringsXMLSnippet) = False Then
            Clipboard.SetText(Content(textStringsXMLSnippet))
        End If
        'EnableControl(sender)

    End Sub

    Private Sub buttonCopyActivityOnCreate_Click(sender As Object, e As EventArgs) Handles buttonCopyActivityOnCreate.Click
        'EnableControl(sender, False)
        If IsEmpty(textActivityOnCreateSnippet) = False Then
            Clipboard.SetText(Content(textActivityOnCreateSnippet))
        End If
        'EnableControl(sender)

    End Sub

    Private Sub buttonCopySampleJS_Click(sender As Object, e As EventArgs) Handles buttonCopySampleJS.Click
        'EnableControl(sender, False)
        If IsEmpty(textSampleJSSnippet) = False Then
            Clipboard.SetText(Content(textSampleJSSnippet))
        End If
        'EnableControl(sender)

    End Sub

    Private Sub AndroidJS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class