Public Class MainDashboard

    Public Sub switchTableLayoutPanel(tlp As TableLayoutPanel, newControl As UserControl)
        tlp.Controls.Clear()
        newControl.Dock = DockStyle.Fill
        tlp.Controls.Add(newControl, 0, 0)
    End Sub

    Public Sub SwitchToAddCellblockControlHome()
        Dim addCellblockControl As New AddCellblockControlHome()
        tlpMain.Controls.Clear()

        addCellblockControl.Dock = DockStyle.Fill
        tlpMain.Controls.Add(addCellblockControl, 0, 0)
    End Sub

    ' Switch to AddCellblockControl
    Public Sub SwitchToAddCellblockControl()
        Dim addCellblockControl As New AddCellblockControl()
        switchTableLayoutPanel(tlpMain, addCellblockControl)
    End Sub

    ' Switch to EditCellblockControl
    Public Sub SwitchToEditCellblockControl()
        Dim editCellblockControl As New EditCellblockControl()
        switchTableLayoutPanel(tlpMain, editCellblockControl)
    End Sub

    ' Switch to DeleteCellblockControl
    Public Sub SwitchToDeleteCellblockControl()
        Dim deleteCellblockControl As New DeleteCellblockControl()
        switchTableLayoutPanel(tlpMain, deleteCellblockControl)
    End Sub



    ' Switch to AddStaffControl
    Public Sub SwitchToAddStaffControl()
        Dim addCellblockControl As New AddStaffControl()
        switchTableLayoutPanel(tlpMain, addCellblockControl)
    End Sub

    ' Switch to EditStaffControl
    Public Sub SwitchToEditStaffControl()
        Dim editCellblockControl As New EditStaffControl()
        switchTableLayoutPanel(tlpMain, editCellblockControl)
    End Sub

    ' Switch to DeleteStaffControl
    Public Sub SwitchToDeleteStaffControl()
        Dim deleteCellblockControl As New DeleteStaffControl()
        switchTableLayoutPanel(tlpMain, deleteCellblockControl)
    End Sub

    Public Sub SwitchToAddStaffControlHome()
        Dim addStaffHomeControl As New AddStaffHomeControl()
        tlpMain.Controls.Clear()

        addStaffHomeControl.Dock = DockStyle.Fill
        tlpMain.Controls.Add(addStaffHomeControl, 0, 0)
    End Sub




    ' OLD CODE
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

    Private Sub btnAddEntity_Click(sender As Object, e As EventArgs) Handles btnAddEntity.Click
        Dim addEntityControl As New AddEntityControl()
        switchTableLayoutPanel(tlpMain, addEntityControl)
    End Sub


End Class