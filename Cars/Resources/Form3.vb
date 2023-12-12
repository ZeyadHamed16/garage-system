Public Class Form3

    Sub pages()
        pnlYellowHome.Visible = False
        pnlYellowCustomers.Visible = False
        pnlYellowStock.Visible = False
        pnlYellowMercedes.Visible = False
        pnlYellowToyota.Visible = False
        pnlYellowHyundai.Visible = False
        pnlYellowAboutUs.Visible = False
        pnlHome.Visible = False
        pnlCustomers.Visible = False
        pnlStock.Visible = False
        pnlMercedes.Visible = False
        pnlToyota.Visible = False
        pnlHyundai.Visible = False
        pnlAboutUs.Visible = False
    End Sub

    Private Sub form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlYellowHome.Visible = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form2.Show()
        Me.Hide()
    End Sub

    'The form of (Home) site
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        pages()
        pnlYellowHome.Visible = True
        pnlHome.Visible = True
    End Sub

    'The form of (Customers) site
    Private Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
        pages()
        pnlYellowCustomers.Visible = True
        pnlCustomers.Visible = True
    End Sub

    'The form of (Stock) site
    Private Sub btnStock_Click(sender As Object, e As EventArgs) Handles btnStock.Click
        pages()
        pnlYellowStock.Visible = True
        pnlStock.Visible = True
    End Sub

    'The form of (Mercedes) site
    Private Sub btnMercedes_Click(sender As Object, e As EventArgs) Handles btnMercedes.Click
        pages()
        pnlYellowMercedes.Visible = True
        pnlMercedes.Visible = True
    End Sub

    'The form of (Toyota) site
    Private Sub btnToyota_Click(sender As Object, e As EventArgs) Handles btnToyota.Click
        pages()
        pnlYellowToyota.Visible = True
        pnlToyota.Visible = True
    End Sub

    'The form of (Hyundai) site
    Private Sub btnHyundai_Click(sender As Object, e As EventArgs) Handles btnHyundai.Click
        pages()
        pnlYellowHyundai.Visible = True
        pnlHyundai.Visible = True
    End Sub

    'The form of (About us) site
    Private Sub btnAboutUs_Click(sender As Object, e As EventArgs) Handles btnAboutUs.Click
        pages()
        pnlYellowAboutUs.Visible = True
        pnlAboutUs.Visible = True
    End Sub
End Class
