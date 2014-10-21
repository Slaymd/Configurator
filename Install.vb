Public Class Install
    Dim a As Integer = 0
    Dim b As Integer = -200
    Dim c As Integer = 200
    Dim d As Integer = -400
    Dim ee As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        a = a + 1
        Label1.Left = a
        If Label1.Location.X = 800 Then
            a = a - 1200
            Label1.Left = a
        End If
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        b = b + 1
        Label2.Left = b
        If Label2.Location.X = 800 Then
            b = b - 1200
            Label2.Left = b
        End If
    End Sub
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        c = c + 1
        Label3.Left = c
        If Label3.Location.X = 800 Then
            c = c - 1200
            Label3.Left = c
        End If
    End Sub
    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        d = d + 1
        Label4.Left = d
        If Label4.Location.X = 800 Then
            d = d - 1200
            Label4.Left = d
        End If
    End Sub
    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        ee = ee + 1
        Label7.Left = ee
        If Label7.Location.X = 800 Then
            ee = ee - 1200
            Label7.Left = ee
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
    Dim appdata As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
    Dim dossReception As String = appdata + "/$safeprojectname$/conflang.txt"
    Dim fr As String = "http://dadcraft.fr/configurator/lang/langFR.txt"
    Dim en As String = "http://dadcraft.fr/configurator/lang/langEN.txt"
    Dim ko As String = "http://dadcraft.fr/configurator/lang/langKO.txt"
    Dim es As String = "http://dadcraft.fr/configurator/lang/langES.txt"
    Dim de As String = "http://dadcraft.fr/configurator/lang/langDE.txt"
    Dim lang As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If français.Checked = True Then
            lang = fr
        ElseIf english.Checked = True Then
            lang = en
        ElseIf coréen.Checked = True Then
            lang = ko
        ElseIf espagnol.Checked = True Then
            lang = es
        ElseIf allemand.Checked = True Then
            lang = de
        End If
        If System.IO.Directory.Exists(appdata + "/$safeprojectname$") = False Then
            System.IO.Directory.CreateDirectory(appdata + "/$safeprojectname$")
            My.Computer.Network.DownloadFile(lang, dossReception)
            Install2.Show()
            Me.Hide()
        Else
            Try
                My.Computer.Network.DownloadFile(lang, dossReception)
                Install2.Show()
                Me.Hide()
            Catch ex As Exception
                If MessageBox.Show("Le fichier de langue existe déjà ! Nous allons le supprimer et en mettre un nouveau.", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Warning) = DialogResult.OK Then
                    My.Computer.FileSystem.DeleteFile(dossReception)
                    My.Computer.Network.DownloadFile(lang, dossReception)
                    Install2.Show()
                    Me.Hide()
                Else
                    My.Computer.FileSystem.DeleteFile(dossReception)
                    My.Computer.Network.DownloadFile(lang, dossReception)
                    Install2.Show()
                    Me.Hide()
                End If
            End Try

        End If

    End Sub
End Class