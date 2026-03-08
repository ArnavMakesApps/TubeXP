<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsForm
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
        Me.lblApi = New System.Windows.Forms.Label()
        Me.txtApiKey = New System.Windows.Forms.TextBox()
        Me.btnSaveApi = New System.Windows.Forms.Button()
        Me.lblPlayer = New System.Windows.Forms.Label()
        Me.rbVLC = New System.Windows.Forms.RadioButton()
        Me.rbWMP = New System.Windows.Forms.RadioButton()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblApi
        '
        Me.lblApi.AutoSize = True
        Me.lblApi.Location = New System.Drawing.Point(20, 20)
        Me.lblApi.Name = "lblApi"
        Me.lblApi.Size = New System.Drawing.Size(88, 13)
        Me.lblApi.TabIndex = 0
        Me.lblApi.Text = "Youtube API Key"
        '
        'txtApiKey
        '
        Me.txtApiKey.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApiKey.Location = New System.Drawing.Point(20, 45)
        Me.txtApiKey.Name = "txtApiKey"
        Me.txtApiKey.Size = New System.Drawing.Size(340, 21)
        Me.txtApiKey.TabIndex = 1
        '
        'btnSaveApi
        '
        Me.btnSaveApi.Location = New System.Drawing.Point(20, 75)
        Me.btnSaveApi.Name = "btnSaveApi"
        Me.btnSaveApi.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveApi.TabIndex = 2
        Me.btnSaveApi.Text = "Save"
        Me.btnSaveApi.UseVisualStyleBackColor = True
        '
        'lblPlayer
        '
        Me.lblPlayer.AutoSize = True
        Me.lblPlayer.Location = New System.Drawing.Point(20, 115)
        Me.lblPlayer.Name = "lblPlayer"
        Me.lblPlayer.Size = New System.Drawing.Size(68, 13)
        Me.lblPlayer.TabIndex = 3
        Me.lblPlayer.Text = "Media Player"
        '
        'rbVLC
        '
        Me.rbVLC.AutoSize = True
        Me.rbVLC.Checked = True
        Me.rbVLC.Location = New System.Drawing.Point(20, 140)
        Me.rbVLC.Name = "rbVLC"
        Me.rbVLC.Size = New System.Drawing.Size(121, 17)
        Me.rbVLC.TabIndex = 4
        Me.rbVLC.TabStop = True
        Me.rbVLC.Text = "VLC (recommended)"
        Me.rbVLC.UseVisualStyleBackColor = True
        '
        'rbWMP
        '
        Me.rbWMP.AutoSize = True
        Me.rbWMP.Location = New System.Drawing.Point(170, 140)
        Me.rbWMP.Name = "rbWMP"
        Me.rbWMP.Size = New System.Drawing.Size(133, 17)
        Me.rbWMP.TabIndex = 5
        Me.rbWMP.Text = "Windows Media Player"
        Me.rbWMP.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(280, 170)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 23)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'SettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 198)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.rbWMP)
        Me.Controls.Add(Me.rbVLC)
        Me.Controls.Add(Me.lblPlayer)
        Me.Controls.Add(Me.btnSaveApi)
        Me.Controls.Add(Me.txtApiKey)
        Me.Controls.Add(Me.lblApi)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SettingsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblApi As System.Windows.Forms.Label
    Friend WithEvents txtApiKey As System.Windows.Forms.TextBox
    Friend WithEvents btnSaveApi As System.Windows.Forms.Button
    Friend WithEvents lblPlayer As System.Windows.Forms.Label
    Friend WithEvents rbVLC As System.Windows.Forms.RadioButton
    Friend WithEvents rbWMP As System.Windows.Forms.RadioButton
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
