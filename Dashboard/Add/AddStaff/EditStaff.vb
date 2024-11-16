Public Class EditStaff
    Private Sub EditStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.FormBorderStyle = FormBorderStyle.Sizable
    End Sub


    'Horizontal nav
    Private Sub btnAddCellblock_Click(sender As Object, e As EventArgs) Handles btnAddCellblock.Click
        AddCellblockHome.Show()
        Me.Hide()

    End Sub

    Private Sub btnAddStaff_Click(sender As Object, e As EventArgs) Handles btnAddStaff.Click
        AddStaffHome.Show()
        Me.Hide()

    End Sub

    Private Sub btnMovePDL_Click(sender As Object, e As EventArgs) Handles btnMovePDL.Click
        MovepdlHome.Show()
        Me.Hide()
    End Sub

    'Vertical nav

    Private Sub btnMainDB_Click(sender As Object, e As EventArgs) Handles btnMainDB.Click
        MainDashboard.Show()
        Me.Hide()

    End Sub

    Private Sub btnAddEntity_Click(sender As Object, e As EventArgs) Handles btnAddEntity.Click
        AddDashboard.Show()
        Me.Hide()

    End Sub
End Class