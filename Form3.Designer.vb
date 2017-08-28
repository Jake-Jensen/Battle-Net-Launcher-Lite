<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.OneZeroZero = New System.Windows.Forms.Label()
        Me.OneZeroOne = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxChangelog = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'OneZeroZero
        '
        Me.OneZeroZero.BackColor = System.Drawing.Color.Black
        Me.OneZeroZero.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.OneZeroZero.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OneZeroZero.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.OneZeroZero.ForeColor = System.Drawing.Color.White
        Me.OneZeroZero.Location = New System.Drawing.Point(12, 9)
        Me.OneZeroZero.Name = "OneZeroZero"
        Me.OneZeroZero.Size = New System.Drawing.Size(100, 23)
        Me.OneZeroZero.TabIndex = 0
        Me.OneZeroZero.Text = "1.00"
        Me.OneZeroZero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OneZeroOne
        '
        Me.OneZeroOne.BackColor = System.Drawing.Color.Black
        Me.OneZeroOne.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.OneZeroOne.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OneZeroOne.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.OneZeroOne.ForeColor = System.Drawing.Color.White
        Me.OneZeroOne.Location = New System.Drawing.Point(12, 42)
        Me.OneZeroOne.Name = "OneZeroOne"
        Me.OneZeroOne.Size = New System.Drawing.Size(100, 23)
        Me.OneZeroOne.TabIndex = 1
        Me.OneZeroOne.Text = "1.01"
        Me.OneZeroOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "TBD"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "TBD"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "TBD"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(12, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "TBD"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBoxChangelog
        '
        Me.TextBoxChangelog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxChangelog.ForeColor = System.Drawing.Color.White
        Me.TextBoxChangelog.Location = New System.Drawing.Point(119, 9)
        Me.TextBoxChangelog.Name = "TextBoxChangelog"
        Me.TextBoxChangelog.Size = New System.Drawing.Size(524, 663)
        Me.TextBoxChangelog.TabIndex = 6
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(655, 681)
        Me.Controls.Add(Me.TextBoxChangelog)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.OneZeroOne)
        Me.Controls.Add(Me.OneZeroZero)
        Me.MaximumSize = New System.Drawing.Size(671, 720)
        Me.MinimumSize = New System.Drawing.Size(671, 720)
        Me.Name = "Form3"
        Me.Text = "Changelog"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents OneZeroZero As Label
    Friend WithEvents OneZeroOne As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxChangelog As Label
End Class
