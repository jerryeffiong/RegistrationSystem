<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report
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
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Report))
        Me.GeomaticBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegistrationDBDataSet = New SRCPortal.RegistrationDBDataSet()
        Me.MechanicalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CivilBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ElectricalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComputerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConstructionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IndexNumberTextBox = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RV4 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.RV3 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.RV6 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.RV5 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CivilTableAdapter = New SRCPortal.RegistrationDBDataSetTableAdapters.CivilTableAdapter()
        Me.MechanicalTableAdapter = New SRCPortal.RegistrationDBDataSetTableAdapters.MechanicalTableAdapter()
        Me.ElectricalTableAdapter = New SRCPortal.RegistrationDBDataSetTableAdapters.ElectricalTableAdapter()
        Me.GeomaticTableAdapter = New SRCPortal.RegistrationDBDataSetTableAdapters.GeomaticTableAdapter()
        Me.ComputerTableAdapter = New SRCPortal.RegistrationDBDataSetTableAdapters.ComputerTableAdapter()
        Me.ConstructionTableAdapter = New SRCPortal.RegistrationDBDataSetTableAdapters.ConstructionTableAdapter()
        CType(Me.GeomaticBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistrationDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MechanicalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CivilBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElectricalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComputerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConstructionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GeomaticBindingSource
        '
        Me.GeomaticBindingSource.DataMember = "Geomatic"
        Me.GeomaticBindingSource.DataSource = Me.RegistrationDBDataSet
        '
        'RegistrationDBDataSet
        '
        Me.RegistrationDBDataSet.DataSetName = "RegistrationDBDataSet"
        Me.RegistrationDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MechanicalBindingSource
        '
        Me.MechanicalBindingSource.DataMember = "Mechanical"
        Me.MechanicalBindingSource.DataSource = Me.RegistrationDBDataSet
        '
        'CivilBindingSource
        '
        Me.CivilBindingSource.DataMember = "Civil"
        Me.CivilBindingSource.DataSource = Me.RegistrationDBDataSet
        '
        'ElectricalBindingSource
        '
        Me.ElectricalBindingSource.DataMember = "Electrical"
        Me.ElectricalBindingSource.DataSource = Me.RegistrationDBDataSet
        '
        'ComputerBindingSource
        '
        Me.ComputerBindingSource.DataMember = "Computer"
        Me.ComputerBindingSource.DataSource = Me.RegistrationDBDataSet
        '
        'ConstructionBindingSource
        '
        Me.ConstructionBindingSource.DataMember = "Construction"
        Me.ConstructionBindingSource.DataSource = Me.RegistrationDBDataSet
        '
        'IndexNumberTextBox
        '
        Me.IndexNumberTextBox.BackColor = System.Drawing.Color.Chocolate
        Me.IndexNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.IndexNumberTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IndexNumberTextBox.ForeColor = System.Drawing.Color.White
        Me.IndexNumberTextBox.Location = New System.Drawing.Point(265, 191)
        Me.IndexNumberTextBox.Name = "IndexNumberTextBox"
        Me.IndexNumberTextBox.Size = New System.Drawing.Size(365, 20)
        Me.IndexNumberTextBox.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(261, 166)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(179, 20)
        Me.Label13.TabIndex = 68
        Me.Label13.Text = "Student Index Number:"
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Chocolate
        Me.Button8.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate
        Me.Button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown
        Me.Button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Peru
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.ForeColor = System.Drawing.Color.White
        Me.Button8.Location = New System.Drawing.Point(978, 184)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(365, 44)
        Me.Button8.TabIndex = 69
        Me.Button8.Text = "Report"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.RV6)
        Me.GroupBox1.Controls.Add(Me.RV5)
        Me.GroupBox1.Controls.Add(Me.RV4)
        Me.GroupBox1.Controls.Add(Me.RV3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 268)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1822, 601)
        Me.GroupBox1.TabIndex = 71
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Report"
        '
        'RV4
        '
        Me.RV4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RV4.DocumentMapWidth = 18
        ReportDataSource3.Name = "DataSet3"
        ReportDataSource3.Value = Me.CivilBindingSource
        Me.RV4.LocalReport.DataSources.Add(ReportDataSource3)
        Me.RV4.LocalReport.ReportEmbeddedResource = "SRCPortal.Report11.rdlc"
        Me.RV4.Location = New System.Drawing.Point(3, 18)
        Me.RV4.Name = "RV4"
        Me.RV4.Size = New System.Drawing.Size(1816, 580)
        Me.RV4.TabIndex = 3
        '
        'RV3
        '
        Me.RV3.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource4.Name = "DataSet4"
        ReportDataSource4.Value = Me.GeomaticBindingSource
        Me.RV3.LocalReport.DataSources.Add(ReportDataSource4)
        Me.RV3.LocalReport.ReportEmbeddedResource = "SRCPortal.Report12.rdlc"
        Me.RV3.Location = New System.Drawing.Point(3, 18)
        Me.RV3.Name = "RV3"
        Me.RV3.Size = New System.Drawing.Size(1816, 580)
        Me.RV3.TabIndex = 2
        '
        'RV6
        '
        Me.RV6.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.MechanicalBindingSource
        Me.RV6.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RV6.LocalReport.ReportEmbeddedResource = "SRCPortal.Report9.rdlc"
        Me.RV6.Location = New System.Drawing.Point(3, 18)
        Me.RV6.Name = "RV6"
        Me.RV6.Size = New System.Drawing.Size(1816, 580)
        Me.RV6.TabIndex = 5
        '
        'RV5
        '
        Me.RV5.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "DataSet2"
        ReportDataSource2.Value = Me.ElectricalBindingSource
        Me.RV5.LocalReport.DataSources.Add(ReportDataSource2)
        Me.RV5.LocalReport.ReportEmbeddedResource = "SRCPortal.Report10.rdlc"
        Me.RV5.Location = New System.Drawing.Point(3, 18)
        Me.RV5.Name = "RV5"
        Me.RV5.Size = New System.Drawing.Size(1816, 580)
        Me.RV5.TabIndex = 4
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.Chocolate
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.Color.White
        Me.ComboBox1.Location = New System.Drawing.Point(265, 113)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(365, 26)
        Me.ComboBox1.TabIndex = 72
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(261, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 20)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Department:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.RadioButton3)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Button8)
        Me.GroupBox2.Controls.Add(Me.ComboBox2)
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.IndexNumberTextBox)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1816, 258)
        Me.GroupBox2.TabIndex = 73
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Report Type"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(55, 49)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(74, 21)
        Me.RadioButton2.TabIndex = 73
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Faculty"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(55, 118)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(103, 21)
        Me.RadioButton3.TabIndex = 73
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Department"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(55, 191)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(78, 21)
        Me.RadioButton1.TabIndex = 73
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Student"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Chocolate
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Peru
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(978, 37)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(365, 44)
        Me.Button1.TabIndex = 69
        Me.Button1.Text = "Back to Portal"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ComboBox2
        '
        Me.ComboBox2.BackColor = System.Drawing.Color.Chocolate
        Me.ComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.ForeColor = System.Drawing.Color.White
        Me.ComboBox2.Items.AddRange(New Object() {"Engineering", "Business", "Law", "Nursing"})
        Me.ComboBox2.Location = New System.Drawing.Point(265, 44)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(365, 26)
        Me.ComboBox2.TabIndex = 72
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(261, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 20)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Faculty:"
        '
        'CivilTableAdapter
        '
        Me.CivilTableAdapter.ClearBeforeFill = True
        '
        'MechanicalTableAdapter
        '
        Me.MechanicalTableAdapter.ClearBeforeFill = True
        '
        'ElectricalTableAdapter
        '
        Me.ElectricalTableAdapter.ClearBeforeFill = True
        '
        'GeomaticTableAdapter
        '
        Me.GeomaticTableAdapter.ClearBeforeFill = True
        '
        'ComputerTableAdapter
        '
        Me.ComputerTableAdapter.ClearBeforeFill = True
        '
        'ConstructionTableAdapter
        '
        Me.ConstructionTableAdapter.ClearBeforeFill = True
        '
        'Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1846, 881)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report Viewer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GeomaticBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistrationDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MechanicalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CivilBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElectricalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComputerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConstructionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents IndexNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents CivilBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RegistrationDBDataSet As SRCPortal.RegistrationDBDataSet
    Friend WithEvents CivilTableAdapter As SRCPortal.RegistrationDBDataSetTableAdapters.CivilTableAdapter
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents MechanicalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MechanicalTableAdapter As SRCPortal.RegistrationDBDataSetTableAdapters.MechanicalTableAdapter
    Friend WithEvents ElectricalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ElectricalTableAdapter As SRCPortal.RegistrationDBDataSetTableAdapters.ElectricalTableAdapter
    Friend WithEvents RV3 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents RV4 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents GeomaticBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GeomaticTableAdapter As SRCPortal.RegistrationDBDataSetTableAdapters.GeomaticTableAdapter
    Friend WithEvents RV5 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ComputerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ComputerTableAdapter As SRCPortal.RegistrationDBDataSetTableAdapters.ComputerTableAdapter
    Friend WithEvents RV6 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ConstructionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConstructionTableAdapter As SRCPortal.RegistrationDBDataSetTableAdapters.ConstructionTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
