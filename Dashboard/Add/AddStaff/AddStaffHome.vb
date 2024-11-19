Public Class AddStaffHome
    Private Sub AddStaffHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.FormBorderStyle = FormBorderStyle.Sizable

        AddHandler AddEditDeleteControl1.AddButtonClick, AddressOf HandleAddButtonClick
        AddHandler AddEditDeleteControl1.EditButtonClick, AddressOf HandleEditButtonClick
        AddHandler AddEditDeleteControl1.DeleteButtonClick, AddressOf HandleDeleteButtonClick
    End Sub


    Private Sub HandleAddButtonClick()
        Dim addCellblockForm As New AddCellblock()
        addCellblockForm.Show()
        Me.Hide()
    End Sub

    ' Handle EditButtonClick event
    Private Sub HandleEditButtonClick()
        Dim editCellblockForm As New EditCellblock()
        editCellblockForm.Show()
        Me.Hide()
    End Sub

    ' Handle DeleteButtonClick event
    Private Sub HandleDeleteButtonClick()
        Dim deleteCellblockForm As New DeleteCellblock()
        deleteCellblockForm.Show()
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




    'Horizontal nav
    Private Sub btnAddCellblock_Click(sender As Object, e As EventArgs) Handles btnAddCellblock.Click
        AddCellblockHome.Show()
        Me.Hide()

    End Sub

    Private Sub btnMovePDL_Click(sender As Object, e As EventArgs) Handles btnMovePDL.Click
        MovepdlHome.Show()
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

    Private Sub btnManageUser_Click(sender As Object, e As EventArgs) Handles btnManageUser.Click
        ManageHome.Show()
        Me.Hide()

    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        SettingsHome.Show()
        Me.Hide()

    End Sub
End Class