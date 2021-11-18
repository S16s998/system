<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container
        Me.StudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudDataSet = New student_management_application.studDataSet
        Me.StudentTableAdapter = New student_management_application.studDataSetTableAdapters.studentTableAdapter
        Me.StudDataSet1 = New student_management_application.studDataSet1
        Me.StudentBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentTableAdapter1 = New student_management_application.studDataSet1TableAdapters.studentTableAdapter
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.StudDataSet2 = New student_management_application.studDataSet2
        Me.StudentBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentTableAdapter2 = New student_management_application.studDataSet2TableAdapters.studentTableAdapter
        Me.RegnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DobDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EmailidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PhonenumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StudentBindingSource
        '
        Me.StudentBindingSource.DataMember = "student"
        Me.StudentBindingSource.DataSource = Me.StudDataSet
        '
        'StudDataSet
        '
        Me.StudDataSet.DataSetName = "studDataSet"
        Me.StudDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentTableAdapter
        '
        Me.StudentTableAdapter.ClearBeforeFill = True
        '
        'StudDataSet1
        '
        Me.StudDataSet1.DataSetName = "studDataSet1"
        Me.StudDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentBindingSource1
        '
        Me.StudentBindingSource1.DataMember = "student"
        Me.StudentBindingSource1.DataSource = Me.StudDataSet1
        '
        'StudentTableAdapter1
        '
        Me.StudentTableAdapter1.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RegnoDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.DobDataGridViewTextBoxColumn, Me.EmailidDataGridViewTextBoxColumn, Me.PhonenumberDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StudentBindingSource2
        Me.DataGridView1.Location = New System.Drawing.Point(37, 40)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(660, 253)
        Me.DataGridView1.TabIndex = 0
        '
        'StudDataSet2
        '
        Me.StudDataSet2.DataSetName = "studDataSet2"
        Me.StudDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentBindingSource2
        '
        Me.StudentBindingSource2.DataMember = "student"
        Me.StudentBindingSource2.DataSource = Me.StudDataSet2
        '
        'StudentTableAdapter2
        '
        Me.StudentTableAdapter2.ClearBeforeFill = True
        '
        'RegnoDataGridViewTextBoxColumn
        '
        Me.RegnoDataGridViewTextBoxColumn.DataPropertyName = "regno"
        Me.RegnoDataGridViewTextBoxColumn.HeaderText = "regno"
        Me.RegnoDataGridViewTextBoxColumn.Name = "RegnoDataGridViewTextBoxColumn"
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'DobDataGridViewTextBoxColumn
        '
        Me.DobDataGridViewTextBoxColumn.DataPropertyName = "dob"
        Me.DobDataGridViewTextBoxColumn.HeaderText = "dob"
        Me.DobDataGridViewTextBoxColumn.Name = "DobDataGridViewTextBoxColumn"
        '
        'EmailidDataGridViewTextBoxColumn
        '
        Me.EmailidDataGridViewTextBoxColumn.DataPropertyName = "emailid"
        Me.EmailidDataGridViewTextBoxColumn.HeaderText = "emailid"
        Me.EmailidDataGridViewTextBoxColumn.Name = "EmailidDataGridViewTextBoxColumn"
        '
        'PhonenumberDataGridViewTextBoxColumn
        '
        Me.PhonenumberDataGridViewTextBoxColumn.DataPropertyName = "phonenumber"
        Me.PhonenumberDataGridViewTextBoxColumn.HeaderText = "phonenumber"
        Me.PhonenumberDataGridViewTextBoxColumn.Name = "PhonenumberDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(888, 466)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents StudDataSet As student_management_application.studDataSet
    Friend WithEvents StudentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudentTableAdapter As student_management_application.studDataSetTableAdapters.studentTableAdapter
    Friend WithEvents StudDataSet1 As student_management_application.studDataSet1
    Friend WithEvents StudentBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents StudentTableAdapter1 As student_management_application.studDataSet1TableAdapters.studentTableAdapter
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents StudDataSet2 As student_management_application.studDataSet2
    Friend WithEvents StudentBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents StudentTableAdapter2 As student_management_application.studDataSet2TableAdapters.studentTableAdapter
    Friend WithEvents RegnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DobDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhonenumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
