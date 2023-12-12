Public Class Admin_form

    Sub pages()
        pnlYellowHome.Visible = False
        pnlYellowStock.Visible = False
        pnlYellowsCustomers.Visible = False
        pnlYellowEmployees.Visible = False
        pnlYellowSuppliers.Visible = False
        pnlYellowAboutUs.Visible = False
        pnlHome.Visible = False
        pnlStock.Visible = False
        pnlCustomers.Visible = False
        pnlEmployees.Visible = False
        pnlSuppliers.Visible = False
        pnlAboutUs.Visible = False
    End Sub

    Private Sub Admin_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlYellowHome.Visible = True
        Timer_DateAndTime.Enabled = True
    End Sub

    Private Sub Timer_DateAndTime_Tick(sender As Object, e As EventArgs) Handles Timer_DateAndTime.Tick
        lblDateAndTime.Text = Date.Now.ToString("dd/mm/yyyy  hh:mm:ss")
    End Sub

    'The form of (Home) site
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        pages()
        pnlYellowHome.Visible = True
        pnlHome.Visible = True
    End Sub

    Private Sub btnUpload_News_Click(sender As Object, e As EventArgs) Handles btnUpload_News.Click
        Form3.lblEmployees_News.Text = Me.txtNews.Text
        MsgBox("News added to all employees", , "News")
    End Sub

    Private Sub btnRemove_News_Click(sender As Object, e As EventArgs) Handles btnRemove_News.Click
        txtNews.Clear()
        Form3.lblEmployees_News.Text = Nothing
        MsgBox("News removed from all employees", , "News")
    End Sub

    Private Sub btnUpload_Reports_Click(sender As Object, e As EventArgs) Handles btnUpload_Reports.Click
        Form3.lblEmployees_Reports.Text = Me.txtReports.Text
        MsgBox("Reports added to all employees", , "Reports")

    End Sub

    Private Sub btnRemove_Reports_Click(sender As Object, e As EventArgs) Handles btnRemove_Reports.Click
        txtReports.Clear()
        Form3.lblEmployees_Reports.Text = Nothing
        MsgBox("Reports removed from all employees", , "Reports")
    End Sub

    'The form of (Stock) site
    Private Sub btnStock_Click(sender As Object, e As EventArgs) Handles btnStock.Click
        pages()
        pnlYellowStock.Visible = True
        pnlStock.Visible = True
    End Sub

    'The form of (Customers) site
    Private Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
        pages()
        pnlYellowsCustomers.Visible = True
        pnlCustomers.Visible = True
    End Sub

    'The form of (Employees) site
    Private Sub btnEmployees_Click(sender As Object, e As EventArgs) Handles btnEmployees.Click
        pages()
        pnlYellowEmployees.Visible = True
        pnlEmployees.Visible = True
    End Sub

    'The form of (Suppliers) site
    Private Sub btnSuppliers_Click(sender As Object, e As EventArgs) Handles btnSuppliers.Click
        pages()
        pnlYellowSuppliers.Visible = True
        pnlSuppliers.Visible = True
    End Sub

    'The form of (About us) site
    Private Sub btnAboutUs_Click(sender As Object, e As EventArgs) Handles btnAboutUs.Click
        pages()
        pnlYellowAboutUs.Visible = True
        pnlAboutUs.Visible = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If MessageBox.Show("Aru you sure?", "Loging out", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Form1.Show()
            Me.Hide()
        End If
    End Sub
End Class