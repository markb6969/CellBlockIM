Public Class UpdateCriminalCase
    Private Sub UpdateCriminalCase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.FormBorderStyle = FormBorderStyle.Sizable
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        UpdateMedicalinfo.Show()
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
End Class