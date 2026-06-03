<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.pnlRoot = New System.Windows.Forms.Panel()
        Me.pnlPage = New System.Windows.Forms.Panel()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.pnlContent = New System.Windows.Forms.Panel()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.flpVideos = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlSidebarMenu = New System.Windows.Forms.Panel()
        Me.lblSettings = New System.Windows.Forms.Label()
        Me.lblDownloads = New System.Windows.Forms.Label()
        Me.lblHistory = New System.Windows.Forms.Label()
        Me.lblGaming = New System.Windows.Forms.Label()
        Me.lblMusic = New System.Windows.Forms.Label()
        Me.lblTrending = New System.Windows.Forms.Label()
        Me.lblHome = New System.Windows.Forms.Label()
        Me.pnlSidebarHeader = New System.Windows.Forms.Panel()
        Me.lblSidebarHeader = New System.Windows.Forms.Label()
        Me.pnlSidebarTopSpacer = New System.Windows.Forms.Panel()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.pnlHeaderDivider = New System.Windows.Forms.Panel()
        Me.lblSignIn = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlRoot.SuspendLayout()
        Me.pnlPage.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.pnlContent.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlSidebarMenu.SuspendLayout()
        Me.pnlSidebarHeader.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlRoot
        '
        Me.pnlRoot.Controls.Add(Me.pnlPage)
        Me.pnlRoot.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlRoot.Location = New System.Drawing.Point(0, 0)
        Me.pnlRoot.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlRoot.Name = "pnlRoot"
        Me.pnlRoot.Size = New System.Drawing.Size(972, 606)
        Me.pnlRoot.TabIndex = 0
        '
        'pnlPage
        '
        Me.pnlPage.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnlPage.BackColor = System.Drawing.Color.White
        Me.pnlPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPage.Controls.Add(Me.pnlMain)
        Me.pnlPage.Controls.Add(Me.pnlHeader)
        Me.pnlPage.Location = New System.Drawing.Point(0, 0)
        Me.pnlPage.Name = "pnlPage"
        Me.pnlPage.Size = New System.Drawing.Size(960, 580)
        Me.pnlPage.TabIndex = 0
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.White
        Me.pnlMain.Controls.Add(Me.pnlContent)
        Me.pnlMain.Controls.Add(Me.Panel1)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 70)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(958, 508)
        Me.pnlMain.TabIndex = 1
        '
        'pnlContent
        '
        Me.pnlContent.AutoScroll = True
        Me.pnlContent.Controls.Add(Me.lblStatus)
        Me.pnlContent.Controls.Add(Me.flpVideos)
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(0, 0)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(958, 508)
        Me.pnlContent.TabIndex = 1
        '
        'lblStatus
        '
        Me.lblStatus.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblStatus.Location = New System.Drawing.Point(0, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(958, 13)
        Me.lblStatus.TabIndex = 1
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'flpVideos
        '
        Me.flpVideos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpVideos.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpVideos.Location = New System.Drawing.Point(0, 0)
        Me.flpVideos.Name = "flpVideos"
        Me.flpVideos.Size = New System.Drawing.Size(958, 508)
        Me.flpVideos.TabIndex = 0
        Me.flpVideos.WrapContents = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Panel1.Controls.Add(Me.pnlSidebarMenu)
        Me.Panel1.Controls.Add(Me.pnlSidebarHeader)
        Me.Panel1.Controls.Add(Me.pnlSidebarTopSpacer)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(0, 508)
        Me.Panel1.TabIndex = 0
        '
        'pnlSidebarMenu
        '
        Me.pnlSidebarMenu.Controls.Add(Me.lblSettings)
        Me.pnlSidebarMenu.Controls.Add(Me.lblDownloads)
        Me.pnlSidebarMenu.Controls.Add(Me.lblHistory)
        Me.pnlSidebarMenu.Controls.Add(Me.lblGaming)
        Me.pnlSidebarMenu.Controls.Add(Me.lblMusic)
        Me.pnlSidebarMenu.Controls.Add(Me.lblTrending)
        Me.pnlSidebarMenu.Controls.Add(Me.lblHome)
        Me.pnlSidebarMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSidebarMenu.Location = New System.Drawing.Point(0, 46)
        Me.pnlSidebarMenu.Name = "pnlSidebarMenu"
        Me.pnlSidebarMenu.Size = New System.Drawing.Size(0, 260)
        Me.pnlSidebarMenu.TabIndex = 2
        '
        'lblSettings
        '
        Me.lblSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSettings.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblSettings.ForeColor = System.Drawing.Color.White
        Me.lblSettings.Location = New System.Drawing.Point(0, 192)
        Me.lblSettings.Name = "lblSettings"
        Me.lblSettings.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.lblSettings.Size = New System.Drawing.Size(0, 32)
        Me.lblSettings.TabIndex = 6
        Me.lblSettings.Text = "Settings"
        Me.lblSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDownloads
        '
        Me.lblDownloads.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblDownloads.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblDownloads.ForeColor = System.Drawing.Color.White
        Me.lblDownloads.Location = New System.Drawing.Point(0, 160)
        Me.lblDownloads.Name = "lblDownloads"
        Me.lblDownloads.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.lblDownloads.Size = New System.Drawing.Size(0, 32)
        Me.lblDownloads.TabIndex = 5
        Me.lblDownloads.Text = "Downloads"
        Me.lblDownloads.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblHistory
        '
        Me.lblHistory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblHistory.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHistory.ForeColor = System.Drawing.Color.White
        Me.lblHistory.Location = New System.Drawing.Point(0, 128)
        Me.lblHistory.Name = "lblHistory"
        Me.lblHistory.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.lblHistory.Size = New System.Drawing.Size(0, 32)
        Me.lblHistory.TabIndex = 4
        Me.lblHistory.Text = "History"
        Me.lblHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblGaming
        '
        Me.lblGaming.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblGaming.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblGaming.ForeColor = System.Drawing.Color.White
        Me.lblGaming.Location = New System.Drawing.Point(0, 96)
        Me.lblGaming.Name = "lblGaming"
        Me.lblGaming.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.lblGaming.Size = New System.Drawing.Size(0, 32)
        Me.lblGaming.TabIndex = 3
        Me.lblGaming.Text = "Gaming"
        Me.lblGaming.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMusic
        '
        Me.lblMusic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMusic.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblMusic.ForeColor = System.Drawing.Color.White
        Me.lblMusic.Location = New System.Drawing.Point(0, 64)
        Me.lblMusic.Name = "lblMusic"
        Me.lblMusic.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.lblMusic.Size = New System.Drawing.Size(0, 32)
        Me.lblMusic.TabIndex = 2
        Me.lblMusic.Text = "Music"
        Me.lblMusic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTrending
        '
        Me.lblTrending.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblTrending.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTrending.ForeColor = System.Drawing.Color.White
        Me.lblTrending.Location = New System.Drawing.Point(0, 32)
        Me.lblTrending.Name = "lblTrending"
        Me.lblTrending.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.lblTrending.Size = New System.Drawing.Size(0, 32)
        Me.lblTrending.TabIndex = 1
        Me.lblTrending.Text = "Trending"
        Me.lblTrending.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblHome
        '
        Me.lblHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.lblHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblHome.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHome.ForeColor = System.Drawing.Color.White
        Me.lblHome.Location = New System.Drawing.Point(0, 0)
        Me.lblHome.Name = "lblHome"
        Me.lblHome.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.lblHome.Size = New System.Drawing.Size(0, 32)
        Me.lblHome.TabIndex = 0
        Me.lblHome.Text = "Home"
        Me.lblHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlSidebarHeader
        '
        Me.pnlSidebarHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.pnlSidebarHeader.Controls.Add(Me.lblSidebarHeader)
        Me.pnlSidebarHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSidebarHeader.Location = New System.Drawing.Point(0, 10)
        Me.pnlSidebarHeader.Name = "pnlSidebarHeader"
        Me.pnlSidebarHeader.Size = New System.Drawing.Size(0, 36)
        Me.pnlSidebarHeader.TabIndex = 1
        '
        'lblSidebarHeader
        '
        Me.lblSidebarHeader.AutoSize = True
        Me.lblSidebarHeader.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblSidebarHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSidebarHeader.ForeColor = System.Drawing.Color.White
        Me.lblSidebarHeader.Location = New System.Drawing.Point(0, 0)
        Me.lblSidebarHeader.Name = "lblSidebarHeader"
        Me.lblSidebarHeader.Padding = New System.Windows.Forms.Padding(12, 9, 0, 0)
        Me.lblSidebarHeader.Size = New System.Drawing.Size(99, 23)
        Me.lblSidebarHeader.TabIndex = 0
        Me.lblSidebarHeader.Text = "From TubeXP"
        Me.lblSidebarHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlSidebarTopSpacer
        '
        Me.pnlSidebarTopSpacer.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSidebarTopSpacer.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebarTopSpacer.Name = "pnlSidebarTopSpacer"
        Me.pnlSidebarTopSpacer.Size = New System.Drawing.Size(0, 10)
        Me.pnlSidebarTopSpacer.TabIndex = 0
        '
        'pnlHeader
        '
        Me.pnlHeader.Controls.Add(Me.pnlHeaderDivider)
        Me.pnlHeader.Controls.Add(Me.lblSignIn)
        Me.pnlHeader.Controls.Add(Me.btnSearch)
        Me.pnlHeader.Controls.Add(Me.txtSearch)
        Me.pnlHeader.Controls.Add(Me.PictureBox1)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Padding = New System.Windows.Forms.Padding(10, 12, 10, 8)
        Me.pnlHeader.Size = New System.Drawing.Size(958, 70)
        Me.pnlHeader.TabIndex = 0
        '
        'pnlHeaderDivider
        '
        Me.pnlHeaderDivider.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.pnlHeaderDivider.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlHeaderDivider.Location = New System.Drawing.Point(10, 61)
        Me.pnlHeaderDivider.Name = "pnlHeaderDivider"
        Me.pnlHeaderDivider.Size = New System.Drawing.Size(938, 1)
        Me.pnlHeaderDivider.TabIndex = 4
        '
        'lblSignIn
        '
        Me.lblSignIn.AutoSize = True
        Me.lblSignIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSignIn.Location = New System.Drawing.Point(830, 25)
        Me.lblSignIn.Name = "lblSignIn"
        Me.lblSignIn.Size = New System.Drawing.Size(40, 13)
        Me.lblSignIn.TabIndex = 3
        Me.lblSignIn.Text = "Sign In"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(505, 21)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(65, 24)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(140, 22)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(360, 22)
        Me.txtSearch.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.TubeXP.My.Resources.Resources.img
        Me.PictureBox1.Location = New System.Drawing.Point(10, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(110, 45)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(972, 606)
        Me.Controls.Add(Me.pnlRoot)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.MinimumSize = New System.Drawing.Size(980, 640)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TubeXP"
        Me.pnlRoot.ResumeLayout(False)
        Me.pnlPage.ResumeLayout(False)
        Me.pnlMain.ResumeLayout(False)
        Me.pnlContent.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.pnlSidebarMenu.ResumeLayout(False)
        Me.pnlSidebarHeader.ResumeLayout(False)
        Me.pnlSidebarHeader.PerformLayout()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlRoot As System.Windows.Forms.Panel
    Friend WithEvents pnlPage As System.Windows.Forms.Panel
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents pnlHeaderDivider As System.Windows.Forms.Panel
    Friend WithEvents lblSignIn As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pnlSidebarMenu As System.Windows.Forms.Panel
    Friend WithEvents lblSettings As System.Windows.Forms.Label
    Friend WithEvents lblDownloads As System.Windows.Forms.Label
    Friend WithEvents lblHistory As System.Windows.Forms.Label
    Friend WithEvents lblGaming As System.Windows.Forms.Label
    Friend WithEvents lblMusic As System.Windows.Forms.Label
    Friend WithEvents lblTrending As System.Windows.Forms.Label
    Friend WithEvents lblHome As System.Windows.Forms.Label
    Friend WithEvents pnlSidebarHeader As System.Windows.Forms.Panel
    Friend WithEvents lblSidebarHeader As System.Windows.Forms.Label
    Friend WithEvents pnlSidebarTopSpacer As System.Windows.Forms.Panel
    Friend WithEvents pnlContent As System.Windows.Forms.Panel
    Friend WithEvents flpVideos As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents lblStatus As System.Windows.Forms.Label

End Class
