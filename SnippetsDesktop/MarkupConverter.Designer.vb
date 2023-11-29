<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MarkupConverter
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
        Me.dFrom = New System.Windows.Forms.ComboBox()
        Me.dTo = New System.Windows.Forms.ComboBox()
        Me.tFrom = New System.Windows.Forms.TextBox()
        Me.tTo = New System.Windows.Forms.TextBox()
        Me.bTo = New System.Windows.Forms.Button()
        Me.bFrom = New System.Windows.Forms.Button()
        Me.brand = New System.Windows.Forms.PictureBox()
        CType(Me.brand, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dFrom
        '
        Me.dFrom.FormattingEnabled = True
        Me.dFrom.Location = New System.Drawing.Point(263, 13)
        Me.dFrom.Name = "dFrom"
        Me.dFrom.Size = New System.Drawing.Size(124, 27)
        Me.dFrom.TabIndex = 18914
        Me.dFrom.TabStop = False
        '
        'dTo
        '
        Me.dTo.FormattingEnabled = True
        Me.dTo.Location = New System.Drawing.Point(431, 13)
        Me.dTo.Name = "dTo"
        Me.dTo.Size = New System.Drawing.Size(124, 27)
        Me.dTo.TabIndex = 18915
        Me.dTo.TabStop = False
        '
        'tFrom
        '
        Me.tFrom.Location = New System.Drawing.Point(16, 49)
        Me.tFrom.Multiline = True
        Me.tFrom.Name = "tFrom"
        Me.tFrom.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tFrom.Size = New System.Drawing.Size(786, 110)
        Me.tFrom.TabIndex = 18916
        Me.tFrom.WordWrap = False
        '
        'tTo
        '
        Me.tTo.Location = New System.Drawing.Point(16, 211)
        Me.tTo.Multiline = True
        Me.tTo.Name = "tTo"
        Me.tTo.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tTo.Size = New System.Drawing.Size(786, 110)
        Me.tTo.TabIndex = 18918
        Me.tTo.WordWrap = False
        '
        'bTo
        '
        Me.bTo.Image = Global.Snippets.My.Resources.Resources.html_5_icon_32
        Me.bTo.Location = New System.Drawing.Point(725, 165)
        Me.bTo.Name = "bTo"
        Me.bTo.Size = New System.Drawing.Size(77, 40)
        Me.bTo.TabIndex = 18919
        Me.bTo.UseVisualStyleBackColor = True
        '
        'bFrom
        '
        Me.bFrom.Image = Global.Snippets.My.Resources.Resources.Android_32
        Me.bFrom.Location = New System.Drawing.Point(16, 165)
        Me.bFrom.Name = "bFrom"
        Me.bFrom.Size = New System.Drawing.Size(77, 40)
        Me.bFrom.TabIndex = 18917
        Me.bFrom.UseVisualStyleBackColor = True
        '
        'brand
        '
        Me.brand.BackgroundImage = Global.Snippets.My.Resources.Resources.css_3_icon_128
        Me.brand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.brand.Location = New System.Drawing.Point(393, 11)
        Me.brand.Name = "brand"
        Me.brand.Size = New System.Drawing.Size(32, 32)
        Me.brand.TabIndex = 18912
        Me.brand.TabStop = False
        '
        'MarkupConverter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(818, 391)
        Me.Controls.Add(Me.bTo)
        Me.Controls.Add(Me.tTo)
        Me.Controls.Add(Me.bFrom)
        Me.Controls.Add(Me.tFrom)
        Me.Controls.Add(Me.dTo)
        Me.Controls.Add(Me.dFrom)
        Me.Controls.Add(Me.brand)
        Me.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MarkupConverter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Markup Converter"
        CType(Me.brand, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents brand As PictureBox
	Friend WithEvents dFrom As ComboBox
	Friend WithEvents dTo As ComboBox
	Friend WithEvents tFrom As TextBox
	Friend WithEvents bFrom As Button
	Friend WithEvents tTo As TextBox
	Friend WithEvents bTo As Button
End Class
