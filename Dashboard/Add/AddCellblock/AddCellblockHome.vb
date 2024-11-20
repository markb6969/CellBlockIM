Public Class AddCellblockHome
    Private Sub AddCellblockHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AddHandler AddEditDeleteControl1.AddButtonClick, AddressOf HandleAddButtonClick
        AddHandler AddEditDeleteControl1.EditButtonClick, AddressOf HandleEditButtonClick
        AddHandler AddEditDeleteControl1.DeleteButtonClick, AddressOf HandleDeleteButtonClick
    End Sub


    Private Sub HandleAddButtonClick()
        Dim addCellblockForm As New AddCellblock()
        addCellblockForm.Show()
        Me.Hide()
    End Sub

    Private Sub HandleEditButtonClick()
        Dim editCellblockForm As New EditCellblock()
        editCellblockForm.Show()
        Me.Hide()
    End Sub

    Private Sub HandleDeleteButtonClick()
        Dim deleteCellblockForm As New DeleteCellblock()
        deleteCellblockForm.Show()
        Me.Hide()
    End Sub


End Class
