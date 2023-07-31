Imports System.Net
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports CLPMS.Validation1
Imports MetroFramework.Controls

Public Class LESSEE
    Private MetroTextBox As MetroFramework.Controls.MetroTextBox
    Private DataGridView As Guna.UI2.WinForms.Guna2DataGridView
    Private data As List(Of MetroTextBox)
    Private columnsName As List(Of String)
    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        ValidateFieldsNotEmpty(data)
    End Sub

    Private Sub LESSEE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        data = New List(Of MetroTextBox) From {txtid, txtname, txtage, txtemail, txtcontact, txtaddress, txtbusiness, txtusername, txtpassword}
        columnsName = New List(Of String) From {"ID", "Name", "Age", "Email", "Contact", "Address", "Business", "Username", "Password"}

        Try
            SetupDataGridViewColumns(Guna2DataGridView1, columnsName)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Guna2DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles Guna2DataGridView1.SelectionChanged
        Try
            ViewDataToTextBox(Guna2DataGridView1, data, columnsName)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click
        DeleteData(txtid, data)
    End Sub
End Class