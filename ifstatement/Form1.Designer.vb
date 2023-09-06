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
        Me.btnGreeting = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCountry = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnGreeting
        '
        Me.btnGreeting.Location = New System.Drawing.Point(366, 293)
        Me.btnGreeting.Name = "btnGreeting"
        Me.btnGreeting.Size = New System.Drawing.Size(110, 33)
        Me.btnGreeting.TabIndex = 0
        Me.btnGreeting.Text = "greetings"
        Me.btnGreeting.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(263, 141)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "name of country"
        '
        'txtCountry
        '
        Me.txtCountry.Location = New System.Drawing.Point(410, 135)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(100, 26)
        Me.txtCountry.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtCountry)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnGreeting)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGreeting As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCountry As TextBox
End Class
