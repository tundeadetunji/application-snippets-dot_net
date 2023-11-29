<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SpringBoot
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SpringBoot))
        Me.dropSection = New System.Windows.Forms.ComboBox()
        Me.textSnippet = New System.Windows.Forms.TextBox()
        Me.buttonCopy = New System.Windows.Forms.Button()
        Me.textPackage = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.textEntity = New System.Windows.Forms.TextBox()
        Me.dropType = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.textField = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.buttonAdd = New System.Windows.Forms.Button()
        Me.dropTypes = New System.Windows.Forms.ComboBox()
        Me.dropFields = New System.Windows.Forms.ComboBox()
        Me.buttonRemove = New System.Windows.Forms.Button()
        Me.buttonClear = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.textMainFolder = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.textUsername = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.textPassword = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.textResourcesFolder = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.textTitle = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'dropSection
        '
        Me.dropSection.FormattingEnabled = True
        Me.dropSection.Location = New System.Drawing.Point(432, 281)
        Me.dropSection.Margin = New System.Windows.Forms.Padding(4)
        Me.dropSection.Name = "dropSection"
        Me.dropSection.Size = New System.Drawing.Size(403, 26)
        Me.dropSection.TabIndex = 0
        '
        'textSnippet
        '
        Me.textSnippet.Location = New System.Drawing.Point(20, 315)
        Me.textSnippet.Margin = New System.Windows.Forms.Padding(4)
        Me.textSnippet.Multiline = True
        Me.textSnippet.Name = "textSnippet"
        Me.textSnippet.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.textSnippet.Size = New System.Drawing.Size(815, 142)
        Me.textSnippet.TabIndex = 2
        Me.textSnippet.WordWrap = False
        '
        'buttonCopy
        '
        Me.buttonCopy.Location = New System.Drawing.Point(656, 465)
        Me.buttonCopy.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonCopy.Name = "buttonCopy"
        Me.buttonCopy.Size = New System.Drawing.Size(179, 32)
        Me.buttonCopy.TabIndex = 3
        Me.buttonCopy.Text = "Copy To Clipboard"
        Me.buttonCopy.UseVisualStyleBackColor = True
        '
        'textPackage
        '
        Me.textPackage.Location = New System.Drawing.Point(20, 37)
        Me.textPackage.Name = "textPackage"
        Me.textPackage.Size = New System.Drawing.Size(403, 27)
        Me.textPackage.TabIndex = 5
        Me.textPackage.Text = "com.user.id"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 18)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Package"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 18)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Entity"
        '
        'textEntity
        '
        Me.textEntity.Location = New System.Drawing.Point(20, 88)
        Me.textEntity.Name = "textEntity"
        Me.textEntity.Size = New System.Drawing.Size(403, 27)
        Me.textEntity.TabIndex = 7
        Me.textEntity.Text = "DB"
        '
        'dropType
        '
        Me.dropType.FormattingEnabled = True
        Me.dropType.Location = New System.Drawing.Point(605, 88)
        Me.dropType.Margin = New System.Windows.Forms.Padding(4)
        Me.dropType.Name = "dropType"
        Me.dropType.Size = New System.Drawing.Size(168, 26)
        Me.dropType.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(429, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 18)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Field"
        '
        'textField
        '
        Me.textField.Location = New System.Drawing.Point(430, 88)
        Me.textField.Name = "textField"
        Me.textField.Size = New System.Drawing.Size(168, 27)
        Me.textField.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(602, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 18)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Type"
        '
        'buttonAdd
        '
        Me.buttonAdd.Location = New System.Drawing.Point(781, 84)
        Me.buttonAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonAdd.Name = "buttonAdd"
        Me.buttonAdd.Size = New System.Drawing.Size(54, 32)
        Me.buttonAdd.TabIndex = 13
        Me.buttonAdd.Text = "Add"
        Me.buttonAdd.UseVisualStyleBackColor = True
        '
        'dropTypes
        '
        Me.dropTypes.FormattingEnabled = True
        Me.dropTypes.Location = New System.Drawing.Point(667, 158)
        Me.dropTypes.Margin = New System.Windows.Forms.Padding(4)
        Me.dropTypes.Name = "dropTypes"
        Me.dropTypes.Size = New System.Drawing.Size(168, 26)
        Me.dropTypes.TabIndex = 14
        '
        'dropFields
        '
        Me.dropFields.FormattingEnabled = True
        Me.dropFields.Location = New System.Drawing.Point(667, 124)
        Me.dropFields.Margin = New System.Windows.Forms.Padding(4)
        Me.dropFields.Name = "dropFields"
        Me.dropFields.Size = New System.Drawing.Size(168, 26)
        Me.dropFields.TabIndex = 15
        '
        'buttonRemove
        '
        Me.buttonRemove.Location = New System.Drawing.Point(555, 138)
        Me.buttonRemove.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonRemove.Name = "buttonRemove"
        Me.buttonRemove.Size = New System.Drawing.Size(104, 32)
        Me.buttonRemove.TabIndex = 16
        Me.buttonRemove.Text = "Remove"
        Me.buttonRemove.UseVisualStyleBackColor = True
        '
        'buttonClear
        '
        Me.buttonClear.Location = New System.Drawing.Point(739, 192)
        Me.buttonClear.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonClear.Name = "buttonClear"
        Me.buttonClear.Size = New System.Drawing.Size(96, 32)
        Me.buttonClear.TabIndex = 17
        Me.buttonClear.Text = "Clear"
        Me.buttonClear.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(169, 18)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Path To Main Folder"
        '
        'textMainFolder
        '
        Me.textMainFolder.Location = New System.Drawing.Point(20, 139)
        Me.textMainFolder.Name = "textMainFolder"
        Me.textMainFolder.Size = New System.Drawing.Size(527, 27)
        Me.textMainFolder.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(428, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 18)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "DB Username"
        '
        'textUsername
        '
        Me.textUsername.Location = New System.Drawing.Point(429, 37)
        Me.textUsername.Name = "textUsername"
        Me.textUsername.Size = New System.Drawing.Size(168, 27)
        Me.textUsername.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(602, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 18)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "DB Password"
        '
        'textPassword
        '
        Me.textPassword.Location = New System.Drawing.Point(603, 36)
        Me.textPassword.Name = "textPassword"
        Me.textPassword.Size = New System.Drawing.Size(168, 27)
        Me.textPassword.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 169)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(214, 18)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Path To Resources Folder"
        '
        'textResourcesFolder
        '
        Me.textResourcesFolder.Location = New System.Drawing.Point(20, 190)
        Me.textResourcesFolder.Name = "textResourcesFolder"
        Me.textResourcesFolder.Size = New System.Drawing.Size(527, 27)
        Me.textResourcesFolder.TabIndex = 24
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(552, 226)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(132, 18)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "New Page Title"
        '
        'textTitle
        '
        Me.textTitle.Location = New System.Drawing.Point(555, 247)
        Me.textTitle.Name = "textTitle"
        Me.textTitle.Size = New System.Drawing.Size(280, 27)
        Me.textTitle.TabIndex = 26
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(431, 259)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 18)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Section"
        '
        'SpringBoot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 513)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.textTitle)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.textResourcesFolder)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.textPassword)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.textUsername)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.textMainFolder)
        Me.Controls.Add(Me.buttonClear)
        Me.Controls.Add(Me.buttonRemove)
        Me.Controls.Add(Me.dropFields)
        Me.Controls.Add(Me.dropTypes)
        Me.Controls.Add(Me.buttonAdd)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.textField)
        Me.Controls.Add(Me.dropType)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.textEntity)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.textPackage)
        Me.Controls.Add(Me.buttonCopy)
        Me.Controls.Add(Me.textSnippet)
        Me.Controls.Add(Me.dropSection)
        Me.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.MaximizeBox = False
        Me.Name = "SpringBoot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Spring Boot"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dropSection As ComboBox
    Friend WithEvents textSnippet As TextBox
    Friend WithEvents buttonCopy As Button
    Friend WithEvents textPackage As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents textEntity As TextBox
    Friend WithEvents dropType As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents textField As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents buttonAdd As Button
    Friend WithEvents dropTypes As ComboBox
    Friend WithEvents dropFields As ComboBox
    Friend WithEvents buttonRemove As Button
    Friend WithEvents buttonClear As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents textMainFolder As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents textUsername As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents textPassword As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents textResourcesFolder As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents textTitle As TextBox
    Friend WithEvents Label10 As Label
End Class
