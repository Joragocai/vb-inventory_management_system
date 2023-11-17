Imports System.Data.SqlClient
Public Class Items
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\johnr\OneDrive\Mga Dokumento\ClothingStore.mdf;Integrated Security=True;Connect Timeout=30")

    Private Sub DisplayItem()
        Con.Open()
        Dim query = "select * from ItemTbl"
        Dim cmd = New SqlCommand(query, Con)
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(cmd)
        Dim builder As New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        ItemDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub

    Private Sub Clear()
        txtItemName.Clear()
        txtQuantity.Clear()
        txtPrice.Clear()
        cboCategories.SelectedIndex = -1
    End Sub

    Private Sub FilterByCat()
        Con.Open()
        Dim query = "select * from ItemTbl where ItCat = '" & cboSearch.SelectedItem.ToString() & "'"
        Dim cmd = New SqlCommand(query, Con)
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(cmd)
        Dim builder As New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        ItemDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Dim key = 0

    Private Sub Items_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayItem()
    End Sub

    Private Sub cboSearch_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboSearch.SelectionChangeCommitted
        FilterByCat()
    End Sub

    Private Sub pbRefresh_Click(sender As Object, e As EventArgs) Handles pbRefresh.Click
        DisplayItem()
        cboSearch.SelectedIndex = -1
    End Sub

    Private Sub ItemDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ItemDGV.CellMouseClick
        Dim row As DataGridViewRow = ItemDGV.Rows(e.RowIndex)
        txtItemName.Text = row.Cells(1).Value.ToString
        txtQuantity.Text = row.Cells(2).Value.ToString
        txtPrice.Text = row.Cells(3).Value.ToString
        cboCategories.SelectedItem = row.Cells(4).Value.ToString
        If txtItemName.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub btnSavee_Click(sender As Object, e As EventArgs) Handles btnSavee.Click
        If txtItemName.Text = "" Or txtQuantity.Text = "" Or txtPrice.Text = "" Or cboCategories.SelectedIndex = -1 Then
            MessageBox.Show("Missing Information")
        Else
            Try
                Con.Open()
                Dim query = "insert into ItemTbl values('" & txtItemName.Text & "'," & txtQuantity.Text & "," & txtPrice.Text & ",'" & cboCategories.SelectedItem.ToString() & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Item Saved Sucessfully")
                Con.Close()
                DisplayItem()
                Clear()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btnEditt_Click(sender As Object, e As EventArgs) Handles btnEditt.Click
        If txtItemName.Text = "" Or txtQuantity.Text = "" Or txtPrice.Text = "" Or cboCategories.SelectedIndex = -1 Then
            MessageBox.Show("Missing Information")
        Else
            Try
                Con.Open()
                Dim query = "Update ItemTbl set ItName = '" & txtItemName.Text & "', ItQTY = " & txtQuantity.Text & ",ItPrice = " & txtPrice.Text & ", ItCat = '" & cboCategories.SelectedItem.ToString() & "' where ItId = " & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Item Updated Sucessfully")
                Con.Close()
                DisplayItem()
                Clear()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btnDeletee_Click(sender As Object, e As EventArgs) Handles btnDeletee.Click
        If key = 0 Then
            MessageBox.Show("Select Item To Delete")
        Else
            Try
                Con.Open()
                Dim queryDelete = "delete from ItemTbl where ItId = " & key & ""
                Dim cmdDelete As SqlCommand = New SqlCommand(queryDelete, Con)
                cmdDelete.ExecuteNonQuery()
                Dim queryResetIdentity As String = "DBCC CHECKIDENT ('ItemTbl', RESEED, 0);"
                Dim cmdResetIdentity As SqlCommand = New SqlCommand(queryResetIdentity, Con)
                cmdResetIdentity.ExecuteNonQuery()


                MessageBox.Show("Item Deleted Sucessfully")
                Con.Close()
                DisplayItem()
                Clear()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btnClearr_Click(sender As Object, e As EventArgs) Handles btnClearr.Click
        Clear()
    End Sub

    Private Sub btnLogOutt_Click(sender As Object, e As EventArgs) Handles btnLogOutt.Click
        Dim obj = New Login
        obj.Show()
        Me.Hide()
    End Sub
End Class