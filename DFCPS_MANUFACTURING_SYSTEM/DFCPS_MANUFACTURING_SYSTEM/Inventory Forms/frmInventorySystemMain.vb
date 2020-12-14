﻿Public Class frmInventorySystemMain

    Private Sub InventoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InventoryToolStripMenuItem.Click
        Dim frm As New frmInventory
        frm.MdiParent = Me
        frm.StartPosition = FormStartPosition.CenterParent
        frm.ComboBox1.SelectedIndex = 0
        frm.Show()
    End Sub

    Private Sub AddEmployeesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddEmployeesToolStripMenuItem.Click
        frmAddItemsInventory.btnAdd.Text = "Add Item"
        frmAddItemsInventory.ShowDialog()
    End Sub

    Private Sub WidthrawItemsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmItemsIssuance.ShowDialog()
    End Sub

    Private Sub PendingRequisitionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PendingRequisitionToolStripMenuItem.Click
        TransactionViewer.MODE = "GET_REQUISITION"
        TransactionViewer.ShowDialog()
    End Sub

    Private Sub WithrawRawMaterialToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WithrawRawMaterialToolStripMenuItem.Click
        frmMaterialWidthrawal.ShowDialog()
    End Sub

    Private Sub RawMaterialsStockInToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RawMaterialsStockInToolStripMenuItem.Click
        frmRawMaterialProduced.ShowDialog()
    End Sub

    Private Sub PurchasesReceivingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchasesReceivingToolStripMenuItem.Click
        Dim frm As New frmPurchasedReceiving
        frm.MdiParent = Me
        frmPurchasedReceiving.Show()
    End Sub
End Class