<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GCP
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
        Me.dropSection = New System.Windows.Forms.ComboBox()
        Me.textSnippet = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'dropSection
        '
        Me.dropSection.BackColor = System.Drawing.Color.RosyBrown
        Me.dropSection.FormattingEnabled = True
        Me.dropSection.Location = New System.Drawing.Point(12, 12)
        Me.dropSection.Name = "dropSection"
        Me.dropSection.Size = New System.Drawing.Size(324, 27)
        Me.dropSection.TabIndex = 0
        '
        'textSnippet
        '
        Me.textSnippet.BackColor = System.Drawing.Color.RosyBrown
        Me.textSnippet.Location = New System.Drawing.Point(12, 45)
        Me.textSnippet.Multiline = True
        Me.textSnippet.Name = "textSnippet"
        Me.textSnippet.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.textSnippet.Size = New System.Drawing.Size(660, 334)
        Me.textSnippet.TabIndex = 18873
        '
        'GCP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RosyBrown
        Me.ClientSize = New System.Drawing.Size(684, 391)
        Me.Controls.Add(Me.textSnippet)
        Me.Controls.Add(Me.dropSection)
        Me.Font = New System.Drawing.Font("DejaVu Sans Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "GCP"
        Me.Text = "GCP"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dropSection As ComboBox
    Friend WithEvents textSnippet As TextBox
End Class
