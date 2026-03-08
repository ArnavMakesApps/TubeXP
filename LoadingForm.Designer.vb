<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoadingForm
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
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.progressBar1 = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(20, 20)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(50, 15)
        Me.lblStatus.TabIndex = 0
        Me.lblStatus.Text = "Loading"
        '
        'progressBar1
        '
        Me.progressBar1.Location = New System.Drawing.Point(20, 55)
        Me.progressBar1.MarqueeAnimationSpeed = 30
        Me.progressBar1.Name = "progressBar1"
        Me.progressBar1.Size = New System.Drawing.Size(250, 18)
        Me.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.progressBar1.TabIndex = 1
        '
        'LoadingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 88)
        Me.ControlBox = False
        Me.Controls.Add(Me.progressBar1)
        Me.Controls.Add(Me.lblStatus)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "LoadingForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Loading"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents progressBar1 As System.Windows.Forms.ProgressBar
End Class
