Public Class Register

    Private Sub SubmitBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubmitBtn.Click
        Dim ConString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=RMS.accdb"
        Dim conn As New System.Data.OleDb.OleDbConnection(ConString)
        conn.Open()

        If UsernameTextBox2.Text = "" Or IDNoTextBox.Text = "" Or PhoneNoTextBox.Text = "" Or EmailTextBox.Text = "" Or GenderComboBox.Text = "" Then
            MessageBox.Show("Please complete the required fields..", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Dim sqlStr = "INSERT INTO "
            Catch ex As Exception

            End Try
            MsgBox("Submit successful.", MsgBoxStyle.Information)
            Form1.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub CancelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBtn.Click
        'User clicking on cancel button only clears field
        ' and refocus to first field
        UsernameTextBox2.Text = ""
        EmailTextBox.Text = ""
        PhoneNoTextBox.Text = ""
        UsernameTextBox2.Focus()
    End Sub

End Class