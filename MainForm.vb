Imports System.Net
Imports System.Text.RegularExpressions
Imports System.Diagnostics

Public Class MainForm

    Private apiKey As String = ""
    Private currentSearchToken As Integer = 0

    Private WithEvents Yt As New YtDlpWrapper()

    '----------------------------------------
    ' FORM LOAD
    '----------------------------------------

    Private Sub MainForm_Load(
    ByVal sender As Object,
    ByVal e As EventArgs) Handles MyBase.Load

        
        ' Root certificate bypass (XP fix)
        ServicePointManager.ServerCertificateValidationCallback =
        Function() True

        LoadApiKey()

        LoadTrending()

    End Sub

    '----------------------------------------
    ' API KEY
    '----------------------------------------

    Private Sub LoadApiKey()

        If IO.File.Exists("apikey.txt") Then

            apiKey = IO.File.ReadAllText("apikey.txt")

        Else

            apiKey = InputBox(
            "Enter YouTube API Key",
            "TubeXP First Run")

            IO.File.WriteAllText("apikey.txt", apiKey)

        End If

    End Sub

    '----------------------------------------
    ' TRENDING
    '----------------------------------------

    Private Sub LoadTrending()

        flpVideos.Controls.Clear()

        Dim url As String =
        "https://www.googleapis.com/youtube/v3/videos?part=snippet" &
        "&chart=mostPopular" &
        "&regionCode=IN" &
        "&maxResults=10" &
        "&key=" & apiKey

        Dim wc As New WebClient()

        Dim json As String = wc.DownloadString(url)

        ParseVideos(json)

    End Sub

    '----------------------------------------
    ' SEARCH BUTTON
    '----------------------------------------

    Private Sub btnSearch_Click(
    ByVal sender As Object,
    ByVal e As EventArgs) Handles btnSearch.Click

        SearchVideos(txtSearch.Text)

    End Sub

    '----------------------------------------
    ' SEARCH
    '----------------------------------------

    Private Sub SearchVideos(ByVal query As String)

        currentSearchToken += 1

        Dim token = currentSearchToken

        flpVideos.Controls.Clear()

        Dim url As String =
        "https://www.googleapis.com/youtube/v3/search" &
        "?part=snippet&type=video" &
        "&maxResults=10" &
        "&q=" & Uri.EscapeDataString(query) &
        "&key=" & apiKey

        Dim wc As New WebClient()

        Dim json As String = wc.DownloadString(url)

        If token <> currentSearchToken Then Exit Sub

        ParseVideos(json)

    End Sub

    '----------------------------------------
    ' JSON PARSER (REGEX)
    '----------------------------------------

    Private Sub ParseVideos(ByVal json As String)

        Dim idMatches =
        Regex.Matches(json, """videoId"":\s*""(.*?)""")

        Dim titleMatches =
        Regex.Matches(json, """title"":\s*""(.*?)""")

        Dim channelMatches =
        Regex.Matches(json, """channelTitle"":\s*""(.*?)""")

        Dim count As Integer =
        Math.Min(10, idMatches.Count)

        For i = 0 To count - 1

            Dim v As New VideoInfo()

            v.VideoId = idMatches(i).Groups(1).Value
            v.Title = titleMatches(i).Groups(1).Value
            v.Channel = channelMatches(i).Groups(1).Value

            v.VideoUrl =
            "https://youtube.com/watch?v=" & v.VideoId

            flpVideos.Controls.Add(CreateVideoItem(v))

        Next

    End Sub

    '----------------------------------------
    ' VIDEO ITEM UI
    '----------------------------------------

    Private Function CreateVideoItem(
    ByVal info As VideoInfo) As Panel

        Dim item As New Panel

        item.Width = flpVideos.Width - 25
        item.Height = 90
        item.BorderStyle = BorderStyle.FixedSingle

        Dim lblTitle As New Label

        lblTitle.Text = info.Title
        lblTitle.Location = New Point(10, 10)
        lblTitle.Width = 500
        lblTitle.Font = New Font("Tahoma", 9, FontStyle.Bold)

        Dim lblChannel As New Label

        lblChannel.Text = info.Channel
        lblChannel.Location = New Point(10, 35)
        lblChannel.Width = 400

        Dim btnPlay As New Button

        btnPlay.Text = "Play"
        btnPlay.Location = New Point(item.Width - 160, 10)

        AddHandler btnPlay.Click,
        Sub()

            PlayVideo(info.VideoUrl)

        End Sub

        Dim btnDownload As New Button

        btnDownload.Text = "Download"
        btnDownload.Location = New Point(item.Width - 160, 40)

        AddHandler btnDownload.Click,
        Sub()

            DownloadVideo(info.VideoUrl)

        End Sub

        item.Controls.Add(lblTitle)
        item.Controls.Add(lblChannel)
        item.Controls.Add(btnPlay)
        item.Controls.Add(btnDownload)

        Return item

    End Function

    '----------------------------------------
    ' PLAY VIDEO
    '----------------------------------------

    Private Sub PlayVideo(ByVal url As String)

        Yt.GetStream(url)

    End Sub

    '----------------------------------------
    ' WHEN STREAM READY
    '----------------------------------------

    Private Sub Yt_StreamReady(
    ByVal streamUrl As String) Handles Yt.StreamReady

        Process.Start("wmplayer.exe", streamUrl)

    End Sub

    '----------------------------------------
    ' DOWNLOAD
    '----------------------------------------

    Private Sub DownloadVideo(ByVal url As String)

        Dim psi As New ProcessStartInfo

        psi.FileName = "yt-dlp.exe"

        psi.Arguments =
        "--no-check-certificates -f best " & url

        psi.UseShellExecute = False

        Process.Start(psi)

    End Sub

End Class

