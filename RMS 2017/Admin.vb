Public Class Admin

    Private Sub AdminLogoutBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdminLogoutBtn.Click
        If MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim login As New Form1
            login.Show()
            Me.Close()
        Else
            Return
        End If
    End Sub

    Private Sub Admin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MainDS.Houses' table. You can move, or remove it, as needed.
        Me.HousesTableAdapter.Fill(Me.MainDS.Houses)
        'TODO: This line of code loads data into the 'MainDS.Login' table. You can move, or remove it, as needed.
        Me.LoginTableAdapter.Fill(Me.MainDS.Login)

    End Sub
End Class