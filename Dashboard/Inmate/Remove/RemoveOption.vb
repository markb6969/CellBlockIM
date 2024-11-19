Public Class RemoveOption
    Private Sub RemoveOption_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.FormBorderStyle = FormBorderStyle.Sizable
    End Sub

    Private Sub btnMoveInmate_Click(sender As Object, e As EventArgs) Handles btnMoveInmate.Click
        MovepdlHome.Show()
        Me.Hide()

    End Sub

    Private Sub btnMainDB_Click(sender As Object, e As EventArgs) Handles btnMainDB.Click
        MainDashboard.Show()
        Me.Hide()

    End Sub

    Private Sub btnAddEntity_Click(sender As Object, e As EventArgs) Handles btnAddEntity.Click
        AddDashboard.Show()
        Me.Hide()

    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        ReportHome.Show()
        Me.Hide()

    End Sub

    Private Sub btnManageInmate_Click(sender As Object, e As EventArgs) Handles btnManageInmate.Click
        InmateHome.Show()
        Me.Hide()

    End Sub

    Private Sub btnAddInmate_Click(sender As Object, e As EventArgs) Handles btnAddInmate.Click
        AddInmate.Show()
        Me.Hide()

    End Sub

    Private Sub btnUpdateInmate_Click(sender As Object, e As EventArgs) Handles btnUpdateInmate.Click
        UpdateHome.Show()
        Me.Hide()

    End Sub

    Private Sub btnRemoveInmate_Click(sender As Object, e As EventArgs) Handles btnRemoveInmate.Click
        RemoveHome.Show()
        Me.Hide()

    End Sub

    Private Sub btnRelease_Click(sender As Object, e As EventArgs) Handles btnRelease.Click
        ReleaseInmate.Show()
        Me.Hide()

    End Sub

    Private Sub btnManageUser_Click(sender As Object, e As EventArgs) Handles btnManageUser.Click
        ManageHome.Show()
        Me.Hide()

    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        SettingsHome.Show()
        Me.Hide()
    End Sub
End Class