<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.AdminTabControl = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.AdminLogoutBtn = New System.Windows.Forms.Button()
        Me.FinancialsTabPage = New System.Windows.Forms.TabPage()
        Me.TenantsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoginBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MainDS = New Login.MainDS()
        Me.IDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HouseNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HousesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LoginTableAdapter = New Login.MainDSTableAdapters.LoginTableAdapter()
        Me.HousesTableAdapter = New Login.MainDSTableAdapters.HousesTableAdapter()
        Me.AdminTabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.TenantsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HousesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AdminTabControl
        '
        Me.AdminTabControl.Controls.Add(Me.TabPage1)
        Me.AdminTabControl.Controls.Add(Me.TabPage2)
        Me.AdminTabControl.Controls.Add(Me.FinancialsTabPage)
        Me.AdminTabControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminTabControl.Location = New System.Drawing.Point(33, 77)
        Me.AdminTabControl.Name = "AdminTabControl"
        Me.AdminTabControl.SelectedIndex = 0
        Me.AdminTabControl.Size = New System.Drawing.Size(516, 301)
        Me.AdminTabControl.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TenantsDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(508, 275)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Tenants"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DataGridView2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(508, 275)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Houses"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'AdminLogoutBtn
        '
        Me.AdminLogoutBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminLogoutBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AdminLogoutBtn.Location = New System.Drawing.Point(464, 25)
        Me.AdminLogoutBtn.Name = "AdminLogoutBtn"
        Me.AdminLogoutBtn.Size = New System.Drawing.Size(100, 32)
        Me.AdminLogoutBtn.TabIndex = 1
        Me.AdminLogoutBtn.Text = "Logout"
        Me.AdminLogoutBtn.UseVisualStyleBackColor = True
        '
        'FinancialsTabPage
        '
        Me.FinancialsTabPage.Location = New System.Drawing.Point(4, 25)
        Me.FinancialsTabPage.Name = "FinancialsTabPage"
        Me.FinancialsTabPage.Size = New System.Drawing.Size(508, 272)
        Me.FinancialsTabPage.TabIndex = 2
        Me.FinancialsTabPage.Text = "Financials"
        Me.FinancialsTabPage.UseVisualStyleBackColor = True
        '
        'TenantsDataGridView
        '
        Me.TenantsDataGridView.AutoGenerateColumns = False
        Me.TenantsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TenantsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn, Me.PasswdDataGridViewTextBoxColumn})
        Me.TenantsDataGridView.DataSource = Me.LoginBindingSource
        Me.TenantsDataGridView.Location = New System.Drawing.Point(29, 39)
        Me.TenantsDataGridView.Name = "TenantsDataGridView"
        Me.TenantsDataGridView.Size = New System.Drawing.Size(340, 162)
        Me.TenantsDataGridView.TabIndex = 0
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn1, Me.HouseNoDataGridViewTextBoxColumn, Me.RoomsDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.HousesBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(26, 36)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(341, 195)
        Me.DataGridView2.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "Username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "Username"
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        '
        'PasswdDataGridViewTextBoxColumn
        '
        Me.PasswdDataGridViewTextBoxColumn.DataPropertyName = "Passwd"
        Me.PasswdDataGridViewTextBoxColumn.HeaderText = "Passwd"
        Me.PasswdDataGridViewTextBoxColumn.Name = "PasswdDataGridViewTextBoxColumn"
        '
        'LoginBindingSource
        '
        Me.LoginBindingSource.DataMember = "Login"
        Me.LoginBindingSource.DataSource = Me.MainDS
        '
        'MainDS
        '
        Me.MainDS.DataSetName = "MainDS"
        Me.MainDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IDDataGridViewTextBoxColumn1
        '
        Me.IDDataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn1.Name = "IDDataGridViewTextBoxColumn1"
        '
        'HouseNoDataGridViewTextBoxColumn
        '
        Me.HouseNoDataGridViewTextBoxColumn.DataPropertyName = "HouseNo"
        Me.HouseNoDataGridViewTextBoxColumn.HeaderText = "HouseNo"
        Me.HouseNoDataGridViewTextBoxColumn.Name = "HouseNoDataGridViewTextBoxColumn"
        '
        'RoomsDataGridViewTextBoxColumn
        '
        Me.RoomsDataGridViewTextBoxColumn.DataPropertyName = "Rooms"
        Me.RoomsDataGridViewTextBoxColumn.HeaderText = "Rooms"
        Me.RoomsDataGridViewTextBoxColumn.Name = "RoomsDataGridViewTextBoxColumn"
        '
        'HousesBindingSource
        '
        Me.HousesBindingSource.DataMember = "Houses"
        Me.HousesBindingSource.DataSource = Me.MainDS
        '
        'LoginTableAdapter
        '
        Me.LoginTableAdapter.ClearBeforeFill = True
        '
        'HousesTableAdapter
        '
        Me.HousesTableAdapter.ClearBeforeFill = True
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(578, 483)
        Me.Controls.Add(Me.AdminLogoutBtn)
        Me.Controls.Add(Me.AdminTabControl)
        Me.Name = "Admin"
        Me.Text = "Admin"
        Me.AdminTabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.TenantsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HousesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AdminTabControl As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents AdminLogoutBtn As System.Windows.Forms.Button
    Friend WithEvents TenantsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents FinancialsTabPage As System.Windows.Forms.TabPage
    Friend WithEvents MainDS As Login.MainDS
    Friend WithEvents LoginBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LoginTableAdapter As Login.MainDSTableAdapters.LoginTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PasswdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents HousesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HousesTableAdapter As Login.MainDSTableAdapters.HousesTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HouseNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RoomsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
