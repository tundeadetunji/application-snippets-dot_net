'from iNovation
Imports iNovation.Code.General
Imports iNovation.Code.Desktop

Public Class Website
    Private s As New iNovation.iNCode.WebsiteSnippets()
    Private Sub Website_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Values
        dropComponents.DataSource = s.DashboardComponents_List
    End Sub

    Private Sub dropComponents_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dropComponents.KeyPress
        AllowNothing(e)
    End Sub

    Private Sub buttonSnippet_Click(sender As Object, e As EventArgs) Handles buttonSnippet.Click
        'EnableControl(sender, False)
        If dropComponents.Text.Trim = "" Then Return
        Dim str As String() = {s.DashboardECommerceMarkup, s.DashboardECommerceMethods, s.DashboardECommercePageLoad}
        textPageLoad.Text = str(2)
        textMethods.Text = str(1)
        textMarkup.Text = str(0)

        buttonCopyPageLoad_Click(sender, e)
        'EnableControl(sender)
    End Sub

    Private Sub buttonCopyPageLoad_Click(sender As Object, e As EventArgs) Handles buttonCopyPageLoad.Click
        'EnableControl(sender, False)
        Clipboard.SetText(textPageLoad.Text)
        'EnableControl(sender)
    End Sub

    Private Sub buttonCopyMethods_Click(sender As Object, e As EventArgs) Handles buttonCopyMethods.Click
        'EnableControl(sender, False)
        Clipboard.SetText(textMethods.Text)
        'EnableControl(sender)
    End Sub

    Private Sub buttonCopyMarkup_Click(sender As Object, e As EventArgs) Handles buttonCopyMarkup.Click
        'EnableControl(sender, False)
        Clipboard.SetText(textMarkup.Text)
        'EnableControl(sender)

    End Sub
End Class