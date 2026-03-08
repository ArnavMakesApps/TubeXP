 Imports System.Net
Imports System.Diagnostics
Imports System.IO

Public Class MainForm

    Dim playerFile As String = Application.StartupPath & "\player.txt"

    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        YouTubeApi.GetApiKey()

        LoadHome()

    End Sub


    Private Sub LoadHome()

        Dim videos = YouTubeApi.SearchVideos("popular")

        DisplayVideos(videos)

    End Sub



    Private Sub btnSearch_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSearch.Click

        Dim q As String = txtSearch.Text.Trim

        If q = "" Then Exit Sub

        Dim loader As New LoadingForm
        loader.SetText("Searching...")
        loader.Show()

        Application.DoEvents()

        Dim vids = YouTubeApi.SearchVideos(q)

        loader.Close()

        DisplayVideos(vids)

    End Sub



    Private Sub DisplayVideos(ByVal videos As List(Of YouTubeVideo))

        flpVideos.Controls.Clear()

        For Each v In videos

            Dim tile As Panel = CreateTile(v)

            flpVideos.Controls.Add(tile)

        Next

    End Sub



    Private Function CreateTile(ByVal v As YouTubeVideo) As Panel

        Dim panel As New Panel
        panel.Width = 180
        panel.Height = 150
        panel.Margin = New Padding(8)
        panel.Cursor = Cursors.Hand


        Dim thumb As New PictureBox
        thumb.Width = 180
        thumb.Height = 100
        thumb.SizeMode = PictureBoxSizeMode.StretchImage
        thumb.Cursor = Cursors.Hand


        Dim lblTitle As New Label
        lblTitle.Top = 105
        lblTitle.Width = 180
        lblTitle.Text = v.Title
        lblTitle.AutoEllipsis = True
        lblTitle.Cursor = Cursors.Hand


        Dim lblChannel As New Label
        lblChannel.Top = 125
        lblChannel.Width = 180
        lblChannel.Text = v.Channel
        lblChannel.Cursor = Cursors.Hand


        panel.Controls.Add(thumb)
        panel.Controls.Add(lblTitle)
        panel.Controls.Add(lblChannel)

        LoadThumbnail(thumb, v.Thumbnail)


        Dim clickHandler As EventHandler =
        Sub(sender As Object, e As EventArgs)
            Dim loading As New LoadingForm
            loading.Show()
            Application.DoEvents()
            PlayVideo(v)
            loading.Close()
        End Sub


        AddHandler panel.Click, clickHandler
        AddHandler thumb.Click, clickHandler
        AddHandler lblTitle.Click, clickHandler
        AddHandler lblChannel.Click, clickHandler

        Return panel

    End Function




    Private Sub LoadThumbnail(ByVal pic As PictureBox, ByVal url As String)

        Try

            AddHandler pic.LoadCompleted,
            Sub(sender As Object, e As System.ComponentModel.AsyncCompletedEventArgs)

                If e.Error IsNot Nothing Then
                    Debug.WriteLine("Thumbnail failed: " & e.Error.Message)
                End If

            End Sub

            pic.LoadAsync(url)

        Catch ex As Exception

            Debug.WriteLine("Thumbnail error: " & ex.Message)

        End Try

    End Sub




    Private Sub PlayVideo(ByVal video As YouTubeVideo)

        Dim streamUrl As String = GetStreamUrl(video.VideoId)

        If streamUrl = "" Then
            MessageBox.Show("Could not get video stream.")
            Exit Sub
        End If


        Dim player As String = GetPlayerSetting()

        If player = "wmp" Then

            Process.Start("wmplayer.exe", streamUrl)

        Else
            Dim vlc As String

            If IO.File.Exists("C:\Program Files\VideoLAN\VLC\vlc.exe") Then
                vlc = "C:\Program Files\VideoLAN\VLC\vlc.exe"

            Else
                vlc = "C:\Program Files (x86)\VideoLAN\VLC\vlc.exe"

            End If

            Dim p As New ProcessStartInfo
            p.FileName = vlc
            p.Arguments = streamUrl

            Process.Start(p)

        End If


        ShowMetadataBar(video)

    End Sub

    Private Function GetStreamUrl(ByVal videoId As String) As String

        Try

            Dim psi As New ProcessStartInfo
            psi.FileName = "yt-dlp.exe"
            psi.Arguments = "-f best -g https://www.youtube.com/watch?v=" & videoId
            psi.UseShellExecute = False
            psi.RedirectStandardOutput = True
            psi.CreateNoWindow = True

            Dim p As Process = Process.Start(psi)

            Dim url As String = p.StandardOutput.ReadLine()

            p.WaitForExit()

            Return url

        Catch ex As Exception

            MessageBox.Show("yt-dlp error: " & ex.Message)

            Return ""

        End Try

    End Function




    Private Function GetPlayerSetting() As String

        Try

            If File.Exists(playerFile) Then

                Return File.ReadAllText(playerFile).ToLower.Trim

            End If

        Catch
        End Try

        Return "vlc"

    End Function




    Private Sub ShowMetadataBar(ByVal v As YouTubeVideo)

        Dim f As New Form

        f.Width = 600
        f.Height = 80
        f.Text = "Now Playing"
        f.StartPosition = FormStartPosition.CenterScreen
        f.FormBorderStyle = FormBorderStyle.FixedToolWindow


        Dim lblTitle As New Label
        lblTitle.Left = 10
        lblTitle.Top = 10
        lblTitle.Width = 560
        lblTitle.Text = v.Title


        Dim lblChannel As New Label
        lblChannel.Left = 10
        lblChannel.Top = 30
        lblChannel.Width = 560
        lblChannel.Text = "Channel: " & v.Channel


        f.Controls.Add(lblTitle)
        f.Controls.Add(lblChannel)

        f.Show()

    End Sub




    '-------------------------
    ' Sidebar actions
    '-------------------------
    Private Sub ResetSidebar()
        lblHome.BackColor = Color.Transparent
        lblTrending.BackColor = Color.Transparent
        lblMusic.BackColor = Color.Transparent
        lblGaming.BackColor = Color.Transparent
    End Sub

    Private Sub lblHome_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lblHome.Click
        ResetSidebar()
        lblHome.BackColor = Color.FromArgb(63, 63, 63)
        LoadHome()
    End Sub

    Private Sub lblTrending_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lblTrending.Click
        ResetSidebar()
        lblTrending.BackColor = Color.FromArgb(63, 63, 63)
        LoadTrending()
    End Sub

    Private Sub lblMusic_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lblMusic.Click
        ResetSidebar()
        lblMusic.BackColor = Color.FromArgb(63, 63, 63)
        LoadMusic()
    End Sub

    Private Sub lblGaming_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lblGaming.Click
        ResetSidebar()
        lblGaming.BackColor = Color.FromArgb(63, 63, 63)
        LoadGaming()
    End Sub

    Private Sub LoadTrending()
        Dim vids = YouTubeApi.SearchVideos("trending")

        DisplayVideos(vids)
    End Sub

    Private Sub LoadMusic()
        Dim vids = YouTubeApi.SearchVideos("top music videos")

        DisplayVideos(vids)
    End Sub

    Private Sub LoadGaming()
        Dim vids = YouTubeApi.SearchVideos("gaming")

        DisplayVideos(vids)
    End Sub


    Private Sub lblSettings_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lblSettings.Click

        Dim f As New SettingsForm
        f.ShowDialog()

    End Sub


End Class