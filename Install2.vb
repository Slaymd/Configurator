Imports System.IO
Public Class Install2
    Dim appdata As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
    Dim msgtxt As String
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show(msgtxt, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            My.Computer.FileSystem.DeleteFile(appdata + "/$safeprojectname$/conflang.txt")
            End
        Else
            e.Cancel = True
        End If
    End Sub
    Private Sub Install2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim trad As String() = File.ReadAllLines(appdata + "/$safeprojectname$/conflang.txt")
        Button1.Text = trad(1)
        Button2.Text = trad(2)
        msgtxt = trad(3)
        Label1.Text = trad(4)
        Label2.Text = trad(5)
        Label3.Text = trad(6)
        Label4.Text = trad(7)
        CheckBox1.Text = trad(8)
        Label5.Text = trad(9)

    End Sub
    Private Sub Panel2_MouseEnter(sender As Object, e As EventArgs) Handles Panel2.MouseEnter
        Panel2.BackColor = Color.OrangeRed
    End Sub
    Private Sub Label1_MouseEnter(sender As Object, e As EventArgs) Handles Label1.MouseEnter
        Panel2.BackColor = Color.OrangeRed
    End Sub
    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter
        Panel2.BackColor = Color.OrangeRed
    End Sub
    Private Sub Panel2_MouseLeave(sender As Object, e As EventArgs) Handles Panel2.MouseLeave
        Panel2.BackColor = Color.Red
    End Sub
    Private Sub Label1_MouseLeave(sender As Object, e As EventArgs) Handles Label1.MouseLeave
        Panel2.BackColor = Color.Red
    End Sub
    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        Panel2.BackColor = Color.Red
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Panel3.Location = New System.Drawing.Point(43, 114)
        If Panel3.Visible = False Then
            Panel3.Visible = True
        Else
            Panel3.Visible = False
        End If
    End Sub
    Private Sub Panel2_Click(sender As Object, e As EventArgs) Handles Panel2.Click
        Panel3.Location = New System.Drawing.Point(43, 114)
        If Panel3.Visible = False Then
            Panel3.Visible = True
        Else
            Panel3.Visible = False
        End If
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Panel3.Location = New System.Drawing.Point(43, 114)
        If Panel3.Visible = False Then
            Panel3.Visible = True
        Else
            Panel3.Visible = False
        End If
    End Sub

    Private Sub Panel4_MouseEnter(sender As Object, e As EventArgs) Handles Panel4.MouseEnter
        Panel4.BackColor = Color.CornflowerBlue
    End Sub
    Private Sub Label5_MouseEnter(sender As Object, e As EventArgs) Handles Label5.MouseEnter
        Panel4.BackColor = Color.CornflowerBlue
    End Sub
    Private Sub PictureBox2_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox2.MouseEnter
        Panel4.BackColor = Color.CornflowerBlue
    End Sub
    Private Sub Panel4_MouseLeave(sender As Object, e As EventArgs) Handles Panel4.MouseLeave
        Panel4.BackColor = Color.RoyalBlue
    End Sub
    Private Sub Label5_MouseLeave(sender As Object, e As EventArgs) Handles Label5.MouseLeave
        Panel4.BackColor = Color.RoyalBlue
    End Sub
    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        Panel4.BackColor = Color.RoyalBlue
    End Sub
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        'Panel3.Location = New System.Drawing.Point(43, 114)
        'If Panel3.Visible = False Then
        '    Panel3.Visible = True
        'Else
        '    Panel3.Visible = False
        'End If
    End Sub
    Private Sub Panel4_Click(sender As Object, e As EventArgs) Handles Panel4.Click
        'Panel3.Location = New System.Drawing.Point(43, 114)
        'If Panel3.Visible = False Then
        '    Panel3.Visible = True
        'Else
        '    Panel3.Visible = False
        'End If
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        'Panel3.Location = New System.Drawing.Point(43, 114)
        'If Panel3.Visible = False Then
        '    Panel3.Visible = True
        'Else
        '    Panel3.Visible = False
        'End If
    End Sub
End Class