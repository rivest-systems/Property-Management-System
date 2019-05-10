Imports System.Data.OleDb
Imports Login

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub clearFields()
        'Clear all fields
        PasswdTextBox.Text = String.Empty
        UsernameTextBox.Text = String.Empty

        'Focus on Username field
        UsernameTextBox.Focus()
    End Sub


    Private Sub LoginBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginBtn.Click
        'Check if username or password is empty
        If PasswdTextBox.Text = "" Or UsernameTextBox.Text = "" Then
            MessageBox.Show("Please complete the required fields..", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            'Both fields was supplied
            'Check if user exist in database
            'Connect to DB
            Dim ConString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=RMS.accdb"
            Dim conn As New System.Data.OleDb.OleDbConnection(ConString)
            conn.Open()

            'If conn.State = ConnectionState.Open Then
            '    MessageBox.Show("Success Connecting")
            'End If

            Dim Username As String = UsernameTextBox.Text
            Dim Passwd As String = PasswdTextBox.Text

            Dim sql As String = "SELECT * FROM Login WHERE Username='" & Username & "' AND Passwd = '" & Passwd & "'"

            Dim adapter As New OleDbDataAdapter(sql, conn)
            Dim DS As New DataSet
            DS.Tables.Add("Tbl")
            adapter.Fill(DS, "Tbl")
            If (conn.State = ConnectionState.Open) Then
                conn.Close()
            End If
            ' Dim testTbl  As DS.Tables("Tbl")


            ' If user enter wrong username and password combination
            If DS.Tables("Tbl").Rows.Count < 1 Then
                ' Throw an error message
                MessageBox.Show("Username and Password do not match..", "Authentication Failure", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Dim User As New UserProfile
                UserProfile.Show()
                clearFields()
                Me.Hide()
            End If
        End If
    End Sub

    Private Sub AdminBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdminBtn.Click
        'Check if username or password is empty
        If PasswdTextBox.Text = "" Or UsernameTextBox.Text = "" Then
            MessageBox.Show("Please complete the required fields..", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            'Both fields was supplied
            'Check if user exist in database
            'Connect to DB
            Dim ConString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= RMS.accdb"
            Dim conn As New System.Data.OleDb.OleDbConnection(ConString)

            Dim Username As String = UsernameTextBox.Text
            Dim Password As String = PasswdTextBox.Text

            Dim sql As String = "SELECT * FROM Login WHERE Username='" & Username & "' AND Passwd = '" & Password & "'"
            conn.Open()

            Dim adapter As New OleDbDataAdapter(sql, conn)
            Dim dt As New DataTable
            adapter.Fill(dt)
            If (conn.State = ConnectionState.Open) Then
                conn.Close()
            End If


            'For i As Integer = 0 To dt.Columns.Count - 1
            '    MsgBox(dt.Rows(0)(i).ToString)
            'Next

            ' If user enter wrong username and password combination
            If dt.Rows.Count < 1 Then
                ' Throw an error message
                MessageBox.Show("Username and Password do not match..", "Authentication Failure", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else

                Dim Admin As New Admin
                Admin.Show()
                Me.Hide()
            End If
        End If
    End Sub

    Private Sub RegisterLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles RegisterLinkLabel.LinkClicked
        Dim register As New Register
        register.Show()
        Me.Hide()
    End Sub
End Class

