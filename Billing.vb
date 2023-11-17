Imports System.Data.SqlClient
Public Class Billing

    Private Sub UpdateItem()
        Dim newQty = Stock - Convert.ToInt32(txtQuantity.Text)
        Try
            Con.Open()
            Dim query = "Update ItemTbl set ItQTY = " & newQty & " where ItId = " & key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Item Updated Sucessfully")
            Con.Close()
            DisplayItem()
        Catch ex As Exception

        End Try
    End Sub
    Dim i = 0, GrdTotal = 0

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

    Private Sub Billing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayItem()
    End Sub

    Dim key = 0, Stock = 0

    Private Sub pbRefresh_Click(sender As Object, e As EventArgs) Handles pbRefresh.Click
        lblTotal.Text = "Total"
        BillDGV.Rows.Clear()
    End Sub

    Private Sub btnSavee_Click(sender As Object, e As EventArgs) Handles btnSavee.Click
        If txtPrice.Text = "" Or txtQuantity.Text = "" Then
            MessageBox.Show("Enter The Quantity")
        ElseIf txtQuantity.Text > Stock Then
            MessageBox.Show("Insufficient Quantity")
            txtQuantity.Text = ""
        ElseIf txtItemName.Text = "" Then
            MessageBox.Show("Select The Item")
        Else
            Dim rnum As Integer = BillDGV.Rows.Add()
            i = i + 1
            Dim total = Convert.ToInt32(txtQuantity.Text) * Convert.ToInt32(txtPrice.Text)
            Dim qty = Convert.ToInt32(txtQuantity.Text)
            Dim price = Convert.ToInt32(txtPrice.Text)
            BillDGV.Rows.Item(rnum).Cells("Column1").Value = i
            BillDGV.Rows.Item(rnum).Cells("Column2").Value = txtItemName.Text
            BillDGV.Rows.Item(rnum).Cells("Column3").Value = txtPrice.Text
            BillDGV.Rows.Item(rnum).Cells("Column4").Value = qty
            BillDGV.Rows.Item(rnum).Cells("Column5").Value = Val(price * qty)
            GrdTotal = GrdTotal + total
            Dim tot As String
            tot = "Total Fee: P" + Convert.ToString(GrdTotal)
            lblTotal.Text = tot
            UpdateItem()
            DisplayItem()
            Reset()
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Reset()
    End Sub

    Private Sub btnLogOutt_Click(sender As Object, e As EventArgs) Handles btnLogOutt.Click
        Dim obj = New Login
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub ItemDGV_CellMouseClick_1(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ItemDGV.CellMouseClick
        Dim row As DataGridViewRow = ItemDGV.Rows(e.RowIndex)
        txtItemName.Text = row.Cells(1).Value.ToString

        txtPrice.Text = row.Cells(3).Value.ToString
        If txtItemName.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
            Stock = Convert.ToInt32(row.Cells(2).Value.ToString)
        End If
    End Sub

    Private Sub Reset()
        txtItemName.Text = ""
        txtPrice.Text = ""
        txtQuantity.Text = ""
        key = 0
        Stock = 0
    End Sub
End Class