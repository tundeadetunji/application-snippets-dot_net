<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WebSection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WebSection))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FileName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.File = New System.Windows.Forms.CheckBox()
        Me.Console = New System.Windows.Forms.CheckBox()
        Me.Seq = New System.Windows.Forms.CheckBox()
        Me.SeqServerURL = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PageModelField = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Usage = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PageModelConstructor = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.AppSettings = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.buttonCopyPageModelField = New System.Windows.Forms.Button()
        Me.buttonCopyPageModelConstructor = New System.Windows.Forms.Button()
        Me.buttonCopyNugetPackages = New System.Windows.Forms.Button()
        Me.buttonCopyUsage = New System.Windows.Forms.Button()
        Me.buttonCopyAppSettings = New System.Windows.Forms.Button()
        Me.buttonCopyUsing = New System.Windows.Forms.Button()
        Me.buttonSnippet = New System.Windows.Forms.Button()
        Me.NugetPackages = New System.Windows.Forms.ComboBox()
        Me.ConsoleOutputTemplate = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FileOutputTemplate = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.UsingStatement = New System.Windows.Forms.TextBox()
        Me.buttonCopyNugetPackage = New System.Windows.Forms.Button()
        Me.ConsoleMinimumLevel = New System.Windows.Forms.ComboBox()
        Me.FileMinimumLevel = New System.Windows.Forms.ComboBox()
        Me.SeqMinimumLevel = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Full File Path"
        '
        'FileName
        '
        Me.FileName.Location = New System.Drawing.Point(139, 96)
        Me.FileName.Name = "FileName"
        Me.FileName.Size = New System.Drawing.Size(162, 25)
        Me.FileName.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Minimum Level"
        '
        'File
        '
        Me.File.AutoSize = True
        Me.File.Checked = True
        Me.File.CheckState = System.Windows.Forms.CheckState.Checked
        Me.File.Location = New System.Drawing.Point(306, 98)
        Me.File.Name = "File"
        Me.File.Size = New System.Drawing.Size(48, 22)
        Me.File.TabIndex = 14
        Me.File.Text = "file"
        Me.File.UseVisualStyleBackColor = True
        '
        'Console
        '
        Me.Console.AutoSize = True
        Me.Console.Checked = True
        Me.Console.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Console.Location = New System.Drawing.Point(307, 22)
        Me.Console.Name = "Console"
        Me.Console.Size = New System.Drawing.Size(78, 22)
        Me.Console.TabIndex = 15
        Me.Console.Text = "console"
        Me.Console.UseVisualStyleBackColor = True
        '
        'Seq
        '
        Me.Seq.AutoSize = True
        Me.Seq.Checked = True
        Me.Seq.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Seq.Location = New System.Drawing.Point(306, 205)
        Me.Seq.Name = "Seq"
        Me.Seq.Size = New System.Drawing.Size(51, 22)
        Me.Seq.TabIndex = 16
        Me.Seq.Text = "seq"
        Me.Seq.UseVisualStyleBackColor = True
        '
        'SeqServerURL
        '
        Me.SeqServerURL.Location = New System.Drawing.Point(139, 235)
        Me.SeqServerURL.Name = "SeqServerURL"
        Me.SeqServerURL.Size = New System.Drawing.Size(162, 25)
        Me.SeqServerURL.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(56, 238)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 18)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Server URL"
        '
        'PageModelField
        '
        Me.PageModelField.Location = New System.Drawing.Point(539, 22)
        Me.PageModelField.Multiline = True
        Me.PageModelField.Name = "PageModelField"
        Me.PageModelField.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.PageModelField.Size = New System.Drawing.Size(140, 94)
        Me.PageModelField.TabIndex = 21
        Me.PageModelField.WordWrap = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(412, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(121, 18)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Page Model Field"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Usage
        '
        Me.Usage.Location = New System.Drawing.Point(832, 22)
        Me.Usage.Multiline = True
        Me.Usage.Name = "Usage"
        Me.Usage.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Usage.Size = New System.Drawing.Size(140, 94)
        Me.Usage.TabIndex = 23
        Me.Usage.WordWrap = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(776, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 18)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Usage"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PageModelConstructor
        '
        Me.PageModelConstructor.Location = New System.Drawing.Point(539, 122)
        Me.PageModelConstructor.Multiline = True
        Me.PageModelConstructor.Name = "PageModelConstructor"
        Me.PageModelConstructor.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.PageModelConstructor.Size = New System.Drawing.Size(140, 94)
        Me.PageModelConstructor.TabIndex = 25
        Me.PageModelConstructor.WordWrap = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(365, 125)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(168, 18)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Page Model Constructor"
        '
        'AppSettings
        '
        Me.AppSettings.Location = New System.Drawing.Point(832, 122)
        Me.AppSettings.Multiline = True
        Me.AppSettings.Name = "AppSettings"
        Me.AppSettings.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.AppSettings.Size = New System.Drawing.Size(140, 94)
        Me.AppSettings.TabIndex = 27
        Me.AppSettings.WordWrap = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(703, 125)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(123, 18)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "AppSettings.json"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(779, 225)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(47, 18)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Using"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(418, 225)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(115, 18)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "Nuget Packages"
        '
        'buttonCopyPageModelField
        '
        Me.buttonCopyPageModelField.BackColor = System.Drawing.Color.Maroon
        Me.buttonCopyPageModelField.Image = Global.Snippets.My.Resources.Resources.Alarm_Arrow_Up_icon_16
        Me.buttonCopyPageModelField.Location = New System.Drawing.Point(486, 91)
        Me.buttonCopyPageModelField.Name = "buttonCopyPageModelField"
        Me.buttonCopyPageModelField.Size = New System.Drawing.Size(47, 25)
        Me.buttonCopyPageModelField.TabIndex = 36
        Me.buttonCopyPageModelField.UseVisualStyleBackColor = False
        '
        'buttonCopyPageModelConstructor
        '
        Me.buttonCopyPageModelConstructor.BackColor = System.Drawing.Color.Maroon
        Me.buttonCopyPageModelConstructor.Image = CType(resources.GetObject("buttonCopyPageModelConstructor.Image"), System.Drawing.Image)
        Me.buttonCopyPageModelConstructor.Location = New System.Drawing.Point(486, 191)
        Me.buttonCopyPageModelConstructor.Name = "buttonCopyPageModelConstructor"
        Me.buttonCopyPageModelConstructor.Size = New System.Drawing.Size(47, 25)
        Me.buttonCopyPageModelConstructor.TabIndex = 37
        Me.buttonCopyPageModelConstructor.UseVisualStyleBackColor = False
        '
        'buttonCopyNugetPackages
        '
        Me.buttonCopyNugetPackages.BackColor = System.Drawing.Color.Maroon
        Me.buttonCopyNugetPackages.Image = CType(resources.GetObject("buttonCopyNugetPackages.Image"), System.Drawing.Image)
        Me.buttonCopyNugetPackages.Location = New System.Drawing.Point(632, 254)
        Me.buttonCopyNugetPackages.Name = "buttonCopyNugetPackages"
        Me.buttonCopyNugetPackages.Size = New System.Drawing.Size(47, 25)
        Me.buttonCopyNugetPackages.TabIndex = 38
        Me.buttonCopyNugetPackages.UseVisualStyleBackColor = False
        '
        'buttonCopyUsage
        '
        Me.buttonCopyUsage.BackColor = System.Drawing.Color.Maroon
        Me.buttonCopyUsage.Image = CType(resources.GetObject("buttonCopyUsage.Image"), System.Drawing.Image)
        Me.buttonCopyUsage.Location = New System.Drawing.Point(779, 91)
        Me.buttonCopyUsage.Name = "buttonCopyUsage"
        Me.buttonCopyUsage.Size = New System.Drawing.Size(47, 25)
        Me.buttonCopyUsage.TabIndex = 39
        Me.buttonCopyUsage.UseVisualStyleBackColor = False
        '
        'buttonCopyAppSettings
        '
        Me.buttonCopyAppSettings.BackColor = System.Drawing.Color.Maroon
        Me.buttonCopyAppSettings.Image = CType(resources.GetObject("buttonCopyAppSettings.Image"), System.Drawing.Image)
        Me.buttonCopyAppSettings.Location = New System.Drawing.Point(779, 191)
        Me.buttonCopyAppSettings.Name = "buttonCopyAppSettings"
        Me.buttonCopyAppSettings.Size = New System.Drawing.Size(47, 25)
        Me.buttonCopyAppSettings.TabIndex = 40
        Me.buttonCopyAppSettings.UseVisualStyleBackColor = False
        '
        'buttonCopyUsing
        '
        Me.buttonCopyUsing.BackColor = System.Drawing.Color.Maroon
        Me.buttonCopyUsing.Image = CType(resources.GetObject("buttonCopyUsing.Image"), System.Drawing.Image)
        Me.buttonCopyUsing.Location = New System.Drawing.Point(925, 322)
        Me.buttonCopyUsing.Name = "buttonCopyUsing"
        Me.buttonCopyUsing.Size = New System.Drawing.Size(47, 25)
        Me.buttonCopyUsing.TabIndex = 41
        Me.buttonCopyUsing.UseVisualStyleBackColor = False
        '
        'buttonSnippet
        '
        Me.buttonSnippet.BackColor = System.Drawing.Color.Maroon
        Me.buttonSnippet.Image = Global.Snippets.My.Resources.Resources.Alarm_Tick_icon_32
        Me.buttonSnippet.Location = New System.Drawing.Point(229, 266)
        Me.buttonSnippet.Name = "buttonSnippet"
        Me.buttonSnippet.Size = New System.Drawing.Size(71, 40)
        Me.buttonSnippet.TabIndex = 42
        Me.buttonSnippet.UseVisualStyleBackColor = False
        '
        'NugetPackages
        '
        Me.NugetPackages.FormattingEnabled = True
        Me.NugetPackages.Location = New System.Drawing.Point(539, 222)
        Me.NugetPackages.Name = "NugetPackages"
        Me.NugetPackages.Size = New System.Drawing.Size(140, 26)
        Me.NugetPackages.TabIndex = 44
        '
        'ConsoleOutputTemplate
        '
        Me.ConsoleOutputTemplate.FormattingEnabled = True
        Me.ConsoleOutputTemplate.Location = New System.Drawing.Point(139, 52)
        Me.ConsoleOutputTemplate.Name = "ConsoleOutputTemplate"
        Me.ConsoleOutputTemplate.Size = New System.Drawing.Size(162, 26)
        Me.ConsoleOutputTemplate.TabIndex = 46
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 18)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Output Template"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 18)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Minimum Level"
        '
        'FileOutputTemplate
        '
        Me.FileOutputTemplate.FormattingEnabled = True
        Me.FileOutputTemplate.Location = New System.Drawing.Point(139, 159)
        Me.FileOutputTemplate.Name = "FileOutputTemplate"
        Me.FileOutputTemplate.Size = New System.Drawing.Size(162, 26)
        Me.FileOutputTemplate.TabIndex = 50
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 18)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Output Template"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(21, 206)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(112, 18)
        Me.Label15.TabIndex = 51
        Me.Label15.Text = "Minimum Level"
        '
        'UsingStatement
        '
        Me.UsingStatement.Location = New System.Drawing.Point(831, 222)
        Me.UsingStatement.Multiline = True
        Me.UsingStatement.Name = "UsingStatement"
        Me.UsingStatement.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.UsingStatement.Size = New System.Drawing.Size(140, 94)
        Me.UsingStatement.TabIndex = 53
        Me.UsingStatement.WordWrap = False
        '
        'buttonCopyNugetPackage
        '
        Me.buttonCopyNugetPackage.BackColor = System.Drawing.Color.Maroon
        Me.buttonCopyNugetPackage.Image = Global.Snippets.My.Resources.Resources.Alarm_Plus_icon_16
        Me.buttonCopyNugetPackage.Location = New System.Drawing.Point(579, 254)
        Me.buttonCopyNugetPackage.Name = "buttonCopyNugetPackage"
        Me.buttonCopyNugetPackage.Size = New System.Drawing.Size(47, 25)
        Me.buttonCopyNugetPackage.TabIndex = 54
        Me.buttonCopyNugetPackage.UseVisualStyleBackColor = False
        '
        'ConsoleMinimumLevel
        '
        Me.ConsoleMinimumLevel.FormattingEnabled = True
        Me.ConsoleMinimumLevel.Location = New System.Drawing.Point(139, 20)
        Me.ConsoleMinimumLevel.Name = "ConsoleMinimumLevel"
        Me.ConsoleMinimumLevel.Size = New System.Drawing.Size(162, 26)
        Me.ConsoleMinimumLevel.TabIndex = 55
        '
        'FileMinimumLevel
        '
        Me.FileMinimumLevel.FormattingEnabled = True
        Me.FileMinimumLevel.Location = New System.Drawing.Point(139, 127)
        Me.FileMinimumLevel.Name = "FileMinimumLevel"
        Me.FileMinimumLevel.Size = New System.Drawing.Size(162, 26)
        Me.FileMinimumLevel.TabIndex = 56
        '
        'SeqMinimumLevel
        '
        Me.SeqMinimumLevel.FormattingEnabled = True
        Me.SeqMinimumLevel.Location = New System.Drawing.Point(139, 203)
        Me.SeqMinimumLevel.Name = "SeqMinimumLevel"
        Me.SeqMinimumLevel.Size = New System.Drawing.Size(162, 26)
        Me.SeqMinimumLevel.TabIndex = 57
        '
        'WebSection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Crimson
        Me.ClientSize = New System.Drawing.Size(984, 367)
        Me.Controls.Add(Me.SeqMinimumLevel)
        Me.Controls.Add(Me.FileMinimumLevel)
        Me.Controls.Add(Me.ConsoleMinimumLevel)
        Me.Controls.Add(Me.buttonCopyNugetPackage)
        Me.Controls.Add(Me.UsingStatement)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.FileOutputTemplate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ConsoleOutputTemplate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NugetPackages)
        Me.Controls.Add(Me.buttonSnippet)
        Me.Controls.Add(Me.buttonCopyUsing)
        Me.Controls.Add(Me.buttonCopyAppSettings)
        Me.Controls.Add(Me.buttonCopyUsage)
        Me.Controls.Add(Me.buttonCopyNugetPackages)
        Me.Controls.Add(Me.buttonCopyPageModelConstructor)
        Me.Controls.Add(Me.buttonCopyPageModelField)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.AppSettings)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.PageModelConstructor)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Usage)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PageModelField)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.SeqServerURL)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Seq)
        Me.Controls.Add(Me.Console)
        Me.Controls.Add(Me.File)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.FileName)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("DejaVu Sans Condensed", 11.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "WebSection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Logging (Net Core)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents FileName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents File As CheckBox
    Friend WithEvents Console As CheckBox
    Friend WithEvents Seq As CheckBox
    Friend WithEvents SeqServerURL As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PageModelField As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Usage As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents PageModelConstructor As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents AppSettings As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents buttonCopyPageModelField As Button
    Friend WithEvents buttonCopyPageModelConstructor As Button
    Friend WithEvents buttonCopyNugetPackages As Button
    Friend WithEvents buttonCopyUsage As Button
    Friend WithEvents buttonCopyAppSettings As Button
    Friend WithEvents buttonCopyUsing As Button
    Friend WithEvents buttonSnippet As Button
    Friend WithEvents NugetPackages As ComboBox
    Friend WithEvents ConsoleOutputTemplate As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents FileOutputTemplate As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents UsingStatement As TextBox
    Friend WithEvents buttonCopyNugetPackage As Button
    Friend WithEvents ConsoleMinimumLevel As ComboBox
    Friend WithEvents FileMinimumLevel As ComboBox
    Friend WithEvents SeqMinimumLevel As ComboBox
End Class
