Imports System.IO

Public Class SettingsForm

    'File paths
    Dim apiFile As String = Application.StartupPath & "\apikey.txt"
    Dim playerFile As String = Application.StartupPath & "\player.txt"


    Private Sub SettingsForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        'Load API key
        If File.Exists(apiFile) Then
            txtApiKey.Text = File.ReadAllText(apiFile).Trim
        Else
            txtApiKey.Text = ""
        End If

        'Load player preference
        If File.Exists(playerFile) Then

            Dim player As String = File.ReadAllText(playerFile).ToLower.Trim

            If player = "wmp" Then
                rbWMP.Checked = True
            Else
                rbVLC.Checked = True
            End If

        Else
            'Default player
            rbVLC.Checked = True
        End If

    End Sub


    Private Sub btnSaveApi_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSaveApi.Click

        Try
            File.WriteAllText(apiFile, txtApiKey.Text.Trim)
            MessageBox.Show("API Key saved successfully.", "Settings")

        Catch ex As Exception
            MessageBox.Show("Error saving API Key.")
        End Try

    End Sub


    Private Sub SettingsForm_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing

        Try

            If rbWMP.Checked Then
                File.WriteAllText(playerFile, "wmp")
            Else
                File.WriteAllText(playerFile, "vlc")
            End If

        Catch ex As Exception
            MessageBox.Show("Error saving player setting.")
        End Try

    End Sub


    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
