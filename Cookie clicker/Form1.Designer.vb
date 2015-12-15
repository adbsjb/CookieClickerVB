<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnClick = New System.Windows.Forms.Button()
        Me.lblCookies = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnClick
        '
        Me.btnClick.Image = Global.Cookie_clicker.My.Resources.Resources.Cookie
        Me.btnClick.Location = New System.Drawing.Point(125, 113)
        Me.btnClick.Name = "btnClick"
        Me.btnClick.Size = New System.Drawing.Size(121, 121)
        Me.btnClick.TabIndex = 0
        Me.btnClick.UseVisualStyleBackColor = True
        '
        'lblCookies
        '
        Me.lblCookies.AutoSize = True
        Me.lblCookies.Location = New System.Drawing.Point(108, 31)
        Me.lblCookies.Name = "lblCookies"
        Me.lblCookies.Size = New System.Drawing.Size(39, 13)
        Me.lblCookies.TabIndex = 1
        Me.lblCookies.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 281)
        Me.Controls.Add(Me.lblCookies)
        Me.Controls.Add(Me.btnClick)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClick As System.Windows.Forms.Button
    Friend WithEvents lblCookies As System.Windows.Forms.Label

End Class
