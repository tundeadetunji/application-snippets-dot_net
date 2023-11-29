<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Website
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Website))
        Me.dropComponents = New System.Windows.Forms.ComboBox()
        Me.buttonSnippet = New System.Windows.Forms.Button()
        Me.buttonCopyPageLoad = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.textPageLoad = New System.Windows.Forms.TextBox()
        Me.buttonCopyMethods = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.textMethods = New System.Windows.Forms.TextBox()
        Me.buttonCopyMarkup = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.textMarkup = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'dropComponents
        '
        Me.dropComponents.FormattingEnabled = True
        Me.dropComponents.Location = New System.Drawing.Point(59, 41)
        Me.dropComponents.Name = "dropComponents"
        Me.dropComponents.Size = New System.Drawing.Size(263, 26)
        Me.dropComponents.TabIndex = 0
        '
        'buttonSnippet
        '
        Me.buttonSnippet.Image = Global.Snippets.My.Resources.Resources.Alarm_Tick_icon_48
        Me.buttonSnippet.Location = New System.Drawing.Point(328, 25)
        Me.buttonSnippet.Name = "buttonSnippet"
        Me.buttonSnippet.Size = New System.Drawing.Size(58, 57)
        Me.buttonSnippet.TabIndex = 18972
        Me.buttonSnippet.UseVisualStyleBackColor = True
        '
        'buttonCopyPageLoad
        '
        Me.buttonCopyPageLoad.Image = Global.Snippets.My.Resources.Resources.Alarm_Arrow_Up_icon_16
        Me.buttonCopyPageLoad.Location = New System.Drawing.Point(201, 321)
        Me.buttonCopyPageLoad.Name = "buttonCopyPageLoad"
        Me.buttonCopyPageLoad.Size = New System.Drawing.Size(185, 28)
        Me.buttonCopyPageLoad.TabIndex = 18975
        Me.buttonCopyPageLoad.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(56, 318)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 18)
        Me.Label5.TabIndex = 18974
        Me.Label5.Text = "Page_Load"
        '
        'textPageLoad
        '
        Me.textPageLoad.Location = New System.Drawing.Point(59, 88)
        Me.textPageLoad.Multiline = True
        Me.textPageLoad.Name = "textPageLoad"
        Me.textPageLoad.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.textPageLoad.Size = New System.Drawing.Size(327, 227)
        Me.textPageLoad.TabIndex = 18973
        Me.textPageLoad.WordWrap = False
        '
        'buttonCopyMethods
        '
        Me.buttonCopyMethods.Image = Global.Snippets.My.Resources.Resources.Alarm_Arrow_Up_icon_16
        Me.buttonCopyMethods.Location = New System.Drawing.Point(534, 258)
        Me.buttonCopyMethods.Name = "buttonCopyMethods"
        Me.buttonCopyMethods.Size = New System.Drawing.Size(185, 28)
        Me.buttonCopyMethods.TabIndex = 18978
        Me.buttonCopyMethods.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(389, 255)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 18)
        Me.Label1.TabIndex = 18977
        Me.Label1.Text = "Methods"
        '
        'textMethods
        '
        Me.textMethods.Location = New System.Drawing.Point(392, 25)
        Me.textMethods.Multiline = True
        Me.textMethods.Name = "textMethods"
        Me.textMethods.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.textMethods.Size = New System.Drawing.Size(327, 227)
        Me.textMethods.TabIndex = 18976
        Me.textMethods.WordWrap = False
        '
        'buttonCopyMarkup
        '
        Me.buttonCopyMarkup.Image = Global.Snippets.My.Resources.Resources.Alarm_Arrow_Up_icon_16
        Me.buttonCopyMarkup.Location = New System.Drawing.Point(534, 525)
        Me.buttonCopyMarkup.Name = "buttonCopyMarkup"
        Me.buttonCopyMarkup.Size = New System.Drawing.Size(185, 28)
        Me.buttonCopyMarkup.TabIndex = 18981
        Me.buttonCopyMarkup.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(389, 522)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 18)
        Me.Label2.TabIndex = 18980
        Me.Label2.Text = "Markup"
        '
        'textMarkup
        '
        Me.textMarkup.Location = New System.Drawing.Point(392, 292)
        Me.textMarkup.Multiline = True
        Me.textMarkup.Name = "textMarkup"
        Me.textMarkup.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.textMarkup.Size = New System.Drawing.Size(327, 227)
        Me.textMarkup.TabIndex = 18979
        Me.textMarkup.WordWrap = False
        '
        'Website
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(775, 578)
        Me.Controls.Add(Me.buttonCopyMarkup)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.textMarkup)
        Me.Controls.Add(Me.buttonCopyMethods)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.textMethods)
        Me.Controls.Add(Me.buttonCopyPageLoad)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.textPageLoad)
        Me.Controls.Add(Me.buttonSnippet)
        Me.Controls.Add(Me.dropComponents)
        Me.Font = New System.Drawing.Font("DejaVu Sans Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Website"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Website"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dropComponents As ComboBox
    Friend WithEvents buttonSnippet As Button
    Friend WithEvents buttonCopyPageLoad As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents textPageLoad As TextBox
    Friend WithEvents buttonCopyMethods As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents textMethods As TextBox
    Friend WithEvents buttonCopyMarkup As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents textMarkup As TextBox
End Class
