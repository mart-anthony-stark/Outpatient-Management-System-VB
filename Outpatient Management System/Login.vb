Public Class Login
    Dim uname, pass As String
    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        RoundCornerButton(loginBtn)
    End Sub

    Private Sub RoundCornerButton(ByVal btn As Button)
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.Cursor = Cursors.Hand

        Dim rad As New Drawing2D.GraphicsPath
        rad.StartFigure()
        rad.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        rad.AddLine(10, 0, btn.Width - 20, 0)
        rad.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        rad.AddLine(loginBtn.Width, 20, btn.Width, btn.Height - 10)
        rad.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        rad.AddLine(loginBtn.Width - 10, btn.Width, 20, btn.Height)
        rad.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        loginBtn.Region = New Region(rad)
    End Sub

    Private Sub loginBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loginBtn.Click
        uname = username.Text
        pass = password.Text
        MsgBox("Username: " + uname + "   Password: " + pass)
        Me.Hide()
        dashboard.Show()
    End Sub
End Class
