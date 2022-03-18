Public Class Notes
    Dim int As Integer = 0

    Private Sub Notes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Dim rtb As New RichTextBox
        rtb.Font = New Font("Courier New", "10")
        rtb.Dock = DockStyle.Fill
        TabControl1.TabPages.Add("Untitled " & int + 1)
        TabControl1.SelectTab(int)
        TabControl1.SelectedTab.Controls.Add(rtb)
        int = int + 1
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        If TabControl1.TabCount = 1 Then
            Me.Close()
        Else
            TabControl1.TabPages.RemoveAt(TabControl1.SelectedIndex)
        End If
    End Sub

    Private Sub NewTabToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewTabToolStripMenuItem.Click
        Dim rtb As New RichTextBox
        rtb.Font = New Font("Courier New", "10")
        rtb.Dock = DockStyle.Fill
        TabControl1.TabPages.Add("Untitled " & int + 1)
        TabControl1.SelectTab(int)
        TabControl1.SelectedTab.Controls.Add(rtb)
        int = int + 1
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), RichTextBox).SaveFile("C:\")
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), RichTextBox).LoadFile("C:\")
    End Sub
End Class