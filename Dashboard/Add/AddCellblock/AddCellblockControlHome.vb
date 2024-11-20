Public Class AddCellblockControlHome
    Private mainDashboard As MainDashboard
    Private Sub AddCellblockHomeControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Attach event handlers for AddEditDeleteControl events
        AddHandler AddEditDeleteControl1.AddButtonClick, AddressOf HandleAddButtonClick
        AddHandler AddEditDeleteControl1.EditButtonClick, AddressOf HandleEditButtonClick
        AddHandler AddEditDeleteControl1.DeleteButtonClick, AddressOf HandleDeleteButtonClick
    End Sub

    Private Sub HandleAddButtonClick()
        ' Get reference to MainDashboard
        Dim mainDashboard As MainDashboard = TryCast(Me.FindForm(), MainDashboard)
        If mainDashboard IsNot Nothing Then
            mainDashboard.SwitchToAddCellblockControl()
        End If
    End Sub

    Private Sub HandleEditButtonClick()
        ' Get reference to MainDashboard
        Dim mainDashboard As MainDashboard = TryCast(Me.FindForm(), MainDashboard)
        If mainDashboard IsNot Nothing Then
            mainDashboard.SwitchToEditCellblockControl()
        End If
    End Sub

    Private Sub HandleDeleteButtonClick()
        ' Get reference to MainDashboard
        Dim mainDashboard As MainDashboard = TryCast(Me.FindForm(), MainDashboard)
        If mainDashboard IsNot Nothing Then
            mainDashboard.SwitchToDeleteCellblockControl()
        End If
    End Sub

    Private Sub btnAddStaff_Click(sender As Object, e As EventArgs) Handles btnAddStaff.Click
        Dim mainForm As MainDashboard = TryCast(Me.ParentForm, MainDashboard)

        If mainForm IsNot Nothing Then
            mainForm.SwitchToAddStaffControlHome()
        End If
    End Sub
End Class
