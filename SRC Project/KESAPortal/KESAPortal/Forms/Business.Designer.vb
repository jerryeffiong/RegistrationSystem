<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Business
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
        Dim ActivityLabel As System.Windows.Forms.Label
        Dim DepartmentLabel As System.Windows.Forms.Label
        Dim IndexNumberLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim Date_Of_BirthLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim NationalityLabel As System.Windows.Forms.Label
        Dim LevelLabel As System.Windows.Forms.Label
        Dim ResidenceLabel As System.Windows.Forms.Label
        Dim ContactLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Business))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.srchtxt0 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.ActivityTextBox = New System.Windows.Forms.TextBox()
        Me.ElectricalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegistrationDBDataSet = New SRCPortal.RegistrationDBDataSet()
        Me.DepartmentComboBox = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.LevelComboBox = New System.Windows.Forms.ComboBox()
        Me.IndexNumberTextBox = New System.Windows.Forms.TextBox()
        Me.GenderComboBox = New System.Windows.Forms.ComboBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.Date_Of_BirthDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.NationalityTextBox = New System.Windows.Forms.TextBox()
        Me.ResidenceTextBox = New System.Windows.Forms.TextBox()
        Me.ContactTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.MechanicalDataGridView = New System.Windows.Forms.DataGridView()
        Me.IndexNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfBirthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NationalityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartmentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LevelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResidenceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActivityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ElectricalTableAdapter = New SRCPortal.RegistrationDBDataSetTableAdapters.ElectricalTableAdapter()
        ActivityLabel = New System.Windows.Forms.Label()
        DepartmentLabel = New System.Windows.Forms.Label()
        IndexNumberLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        Date_Of_BirthLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        NationalityLabel = New System.Windows.Forms.Label()
        LevelLabel = New System.Windows.Forms.Label()
        ResidenceLabel = New System.Windows.Forms.Label()
        ContactLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.ElectricalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistrationDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MechanicalDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ActivityLabel
        '
        ActivityLabel.AutoSize = True
        ActivityLabel.Font = New System.Drawing.Font("Minion Pro", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ActivityLabel.Location = New System.Drawing.Point(12, 395)
        ActivityLabel.Name = "ActivityLabel"
        ActivityLabel.Size = New System.Drawing.Size(86, 40)
        ActivityLabel.TabIndex = 25
        ActivityLabel.Text = "Talent/Sport" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Discipline:"
        '
        'DepartmentLabel
        '
        DepartmentLabel.AutoSize = True
        DepartmentLabel.Font = New System.Drawing.Font("Minion Pro", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DepartmentLabel.Location = New System.Drawing.Point(12, 21)
        DepartmentLabel.Name = "DepartmentLabel"
        DepartmentLabel.Size = New System.Drawing.Size(86, 20)
        DepartmentLabel.TabIndex = 22
        DepartmentLabel.Text = "Department:"
        '
        'IndexNumberLabel
        '
        IndexNumberLabel.AutoSize = True
        IndexNumberLabel.Font = New System.Drawing.Font("Minion Pro", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IndexNumberLabel.Location = New System.Drawing.Point(12, 64)
        IndexNumberLabel.Name = "IndexNumberLabel"
        IndexNumberLabel.Size = New System.Drawing.Size(99, 20)
        IndexNumberLabel.TabIndex = 0
        IndexNumberLabel.Text = "Index Number:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Font = New System.Drawing.Font("Minion Pro", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LastNameLabel.Location = New System.Drawing.Point(12, 107)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(77, 20)
        LastNameLabel.TabIndex = 2
        LastNameLabel.Text = "Last Name:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Font = New System.Drawing.Font("Minion Pro", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FirstNameLabel.Location = New System.Drawing.Point(12, 149)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(93, 20)
        FirstNameLabel.TabIndex = 4
        FirstNameLabel.Text = "Other Names:"
        '
        'Date_Of_BirthLabel
        '
        Date_Of_BirthLabel.AutoSize = True
        Date_Of_BirthLabel.Font = New System.Drawing.Font("Minion Pro", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Date_Of_BirthLabel.Location = New System.Drawing.Point(12, 194)
        Date_Of_BirthLabel.Name = "Date_Of_BirthLabel"
        Date_Of_BirthLabel.Size = New System.Drawing.Size(94, 20)
        Date_Of_BirthLabel.TabIndex = 6
        Date_Of_BirthLabel.Text = "Date Of Birth:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Font = New System.Drawing.Font("Minion Pro", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GenderLabel.Location = New System.Drawing.Point(12, 236)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(57, 20)
        GenderLabel.TabIndex = 8
        GenderLabel.Text = "Gender:"
        '
        'NationalityLabel
        '
        NationalityLabel.AutoSize = True
        NationalityLabel.Font = New System.Drawing.Font("Minion Pro", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NationalityLabel.Location = New System.Drawing.Point(12, 279)
        NationalityLabel.Name = "NationalityLabel"
        NationalityLabel.Size = New System.Drawing.Size(82, 20)
        NationalityLabel.TabIndex = 10
        NationalityLabel.Text = "Nationality:"
        '
        'LevelLabel
        '
        LevelLabel.AutoSize = True
        LevelLabel.Font = New System.Drawing.Font("Minion Pro", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LevelLabel.Location = New System.Drawing.Point(12, 324)
        LevelLabel.Name = "LevelLabel"
        LevelLabel.Size = New System.Drawing.Size(43, 20)
        LevelLabel.TabIndex = 12
        LevelLabel.Text = "Level:"
        '
        'ResidenceLabel
        '
        ResidenceLabel.AutoSize = True
        ResidenceLabel.Font = New System.Drawing.Font("Minion Pro", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ResidenceLabel.Location = New System.Drawing.Point(12, 367)
        ResidenceLabel.Name = "ResidenceLabel"
        ResidenceLabel.Size = New System.Drawing.Size(71, 20)
        ResidenceLabel.TabIndex = 14
        ResidenceLabel.Text = "Residence:"
        '
        'ContactLabel
        '
        ContactLabel.AutoSize = True
        ContactLabel.Font = New System.Drawing.Font("Minion Pro", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ContactLabel.Location = New System.Drawing.Point(12, 453)
        ContactLabel.Name = "ContactLabel"
        ContactLabel.Size = New System.Drawing.Size(61, 20)
        ContactLabel.TabIndex = 18
        ContactLabel.Text = "Contact:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Font = New System.Drawing.Font("Minion Pro", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailLabel.Location = New System.Drawing.Point(12, 495)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(48, 20)
        EmailLabel.TabIndex = 20
        EmailLabel.Text = "Email:"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1924, 1020)
        Me.SplitContainer1.SplitterDistance = 161
        Me.SplitContainer1.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.Font = New System.Drawing.Font("Minion Pro Cond", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(49, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 33)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Back"
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.SRCPortal.My.Resources.Resources.back1
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(45, 46)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Minion Pro SmBd", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(1167, 64)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 36)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'srchtxt0
        '
        Me.srchtxt0.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.srchtxt0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.srchtxt0.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.srchtxt0.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.srchtxt0.Location = New System.Drawing.Point(820, 68)
        Me.srchtxt0.Name = "srchtxt0"
        Me.srchtxt0.Size = New System.Drawing.Size(341, 28)
        Me.srchtxt0.TabIndex = 30
        Me.srchtxt0.Text = "Enter a Name or an Index number"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.srchtxt0)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(468, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1312, 113)
        Me.Panel1.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Minion Pro", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(683, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 32)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "0"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Minion Pro", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(57, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(791, 54)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FACULTY OF BUSINESS ADMINISTRATION"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Minion Pro", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(175, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(365, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total number of registered students :"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.AutoScroll = True
        Me.SplitContainer2.Panel1.Controls.Add(ActivityLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.ActivityTextBox)
        Me.SplitContainer2.Panel1.Controls.Add(Me.DepartmentComboBox)
        Me.SplitContainer2.Panel1.Controls.Add(DepartmentLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Button4)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Button3)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Button2)
        Me.SplitContainer2.Panel1.Controls.Add(IndexNumberLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.LevelComboBox)
        Me.SplitContainer2.Panel1.Controls.Add(Me.IndexNumberTextBox)
        Me.SplitContainer2.Panel1.Controls.Add(Me.GenderComboBox)
        Me.SplitContainer2.Panel1.Controls.Add(LastNameLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.LastNameTextBox)
        Me.SplitContainer2.Panel1.Controls.Add(FirstNameLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.FirstNameTextBox)
        Me.SplitContainer2.Panel1.Controls.Add(Date_Of_BirthLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Date_Of_BirthDateTimePicker)
        Me.SplitContainer2.Panel1.Controls.Add(GenderLabel)
        Me.SplitContainer2.Panel1.Controls.Add(NationalityLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.NationalityTextBox)
        Me.SplitContainer2.Panel1.Controls.Add(LevelLabel)
        Me.SplitContainer2.Panel1.Controls.Add(ResidenceLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.ResidenceTextBox)
        Me.SplitContainer2.Panel1.Controls.Add(ContactLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.ContactTextBox)
        Me.SplitContainer2.Panel1.Controls.Add(EmailLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.EmailTextBox)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.MechanicalDataGridView)
        Me.SplitContainer2.Size = New System.Drawing.Size(1924, 855)
        Me.SplitContainer2.SplitterDistance = 421
        Me.SplitContainer2.TabIndex = 0
        '
        'ActivityTextBox
        '
        Me.ActivityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ElectricalBindingSource, "Activity", True))
        Me.ActivityTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActivityTextBox.Location = New System.Drawing.Point(140, 408)
        Me.ActivityTextBox.Name = "ActivityTextBox"
        Me.ActivityTextBox.Size = New System.Drawing.Size(251, 24)
        Me.ActivityTextBox.TabIndex = 26
        '
        'ElectricalBindingSource
        '
        Me.ElectricalBindingSource.DataMember = "Electrical"
        Me.ElectricalBindingSource.DataSource = Me.RegistrationDBDataSet
        '
        'RegistrationDBDataSet
        '
        Me.RegistrationDBDataSet.DataSetName = "RegistrationDBDataSet"
        Me.RegistrationDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DepartmentComboBox
        '
        Me.DepartmentComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ElectricalBindingSource, "Department", True))
        Me.DepartmentComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DepartmentComboBox.FormattingEnabled = True
        Me.DepartmentComboBox.Items.AddRange(New Object() {"Business Administration", "Accounting", "Marketing", "Human Resource", "Banking and Finance"})
        Me.DepartmentComboBox.Location = New System.Drawing.Point(140, 18)
        Me.DepartmentComboBox.Name = "DepartmentComboBox"
        Me.DepartmentComboBox.Size = New System.Drawing.Size(251, 26)
        Me.DepartmentComboBox.TabIndex = 6
        Me.DepartmentComboBox.Text = "-Select-"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(16, 647)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(375, 46)
        Me.Button4.TabIndex = 23
        Me.Button4.Text = "Delete"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(16, 595)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(375, 46)
        Me.Button3.TabIndex = 23
        Me.Button3.Text = "Save"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(16, 543)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(375, 46)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "Add"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'LevelComboBox
        '
        Me.LevelComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ElectricalBindingSource, "Level", True))
        Me.LevelComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LevelComboBox.FormattingEnabled = True
        Me.LevelComboBox.Items.AddRange(New Object() {"100", "200", "300", "400"})
        Me.LevelComboBox.Location = New System.Drawing.Point(140, 321)
        Me.LevelComboBox.Name = "LevelComboBox"
        Me.LevelComboBox.Size = New System.Drawing.Size(169, 26)
        Me.LevelComboBox.TabIndex = 8
        Me.LevelComboBox.Text = "-Select-"
        '
        'IndexNumberTextBox
        '
        Me.IndexNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ElectricalBindingSource, "IndexNumber", True))
        Me.IndexNumberTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IndexNumberTextBox.Location = New System.Drawing.Point(140, 61)
        Me.IndexNumberTextBox.Name = "IndexNumberTextBox"
        Me.IndexNumberTextBox.Size = New System.Drawing.Size(251, 24)
        Me.IndexNumberTextBox.TabIndex = 1
        '
        'GenderComboBox
        '
        Me.GenderComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ElectricalBindingSource, "Gender", True))
        Me.GenderComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenderComboBox.FormattingEnabled = True
        Me.GenderComboBox.Items.AddRange(New Object() {"Male", "Female"})
        Me.GenderComboBox.Location = New System.Drawing.Point(140, 233)
        Me.GenderComboBox.Name = "GenderComboBox"
        Me.GenderComboBox.Size = New System.Drawing.Size(169, 26)
        Me.GenderComboBox.TabIndex = 7
        Me.GenderComboBox.Text = "-Select-"
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ElectricalBindingSource, "LastName", True))
        Me.LastNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastNameTextBox.Location = New System.Drawing.Point(140, 104)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(251, 24)
        Me.LastNameTextBox.TabIndex = 3
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ElectricalBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(140, 146)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(251, 24)
        Me.FirstNameTextBox.TabIndex = 5
        '
        'Date_Of_BirthDateTimePicker
        '
        Me.Date_Of_BirthDateTimePicker.CalendarForeColor = System.Drawing.Color.White
        Me.Date_Of_BirthDateTimePicker.CalendarMonthBackground = System.Drawing.Color.OrangeRed
        Me.Date_Of_BirthDateTimePicker.CustomFormat = "DD/MM/YYYY"
        Me.Date_Of_BirthDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ElectricalBindingSource, "Date_Of_Birth", True))
        Me.Date_Of_BirthDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_Of_BirthDateTimePicker.Location = New System.Drawing.Point(140, 190)
        Me.Date_Of_BirthDateTimePicker.Name = "Date_Of_BirthDateTimePicker"
        Me.Date_Of_BirthDateTimePicker.Size = New System.Drawing.Size(251, 24)
        Me.Date_Of_BirthDateTimePicker.TabIndex = 7
        Me.Date_Of_BirthDateTimePicker.Value = New Date(1998, 6, 11, 0, 0, 0, 0)
        '
        'NationalityTextBox
        '
        Me.NationalityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ElectricalBindingSource, "Nationality", True))
        Me.NationalityTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NationalityTextBox.Location = New System.Drawing.Point(140, 276)
        Me.NationalityTextBox.Name = "NationalityTextBox"
        Me.NationalityTextBox.Size = New System.Drawing.Size(251, 24)
        Me.NationalityTextBox.TabIndex = 11
        '
        'ResidenceTextBox
        '
        Me.ResidenceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ElectricalBindingSource, "Residence", True))
        Me.ResidenceTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResidenceTextBox.Location = New System.Drawing.Point(140, 364)
        Me.ResidenceTextBox.Name = "ResidenceTextBox"
        Me.ResidenceTextBox.Size = New System.Drawing.Size(251, 24)
        Me.ResidenceTextBox.TabIndex = 15
        '
        'ContactTextBox
        '
        Me.ContactTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ElectricalBindingSource, "Contact", True))
        Me.ContactTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactTextBox.Location = New System.Drawing.Point(140, 450)
        Me.ContactTextBox.Name = "ContactTextBox"
        Me.ContactTextBox.Size = New System.Drawing.Size(251, 24)
        Me.ContactTextBox.TabIndex = 19
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ElectricalBindingSource, "Email", True))
        Me.EmailTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTextBox.Location = New System.Drawing.Point(140, 492)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(251, 24)
        Me.EmailTextBox.TabIndex = 21
        '
        'MechanicalDataGridView
        '
        Me.MechanicalDataGridView.AllowUserToAddRows = False
        Me.MechanicalDataGridView.AllowUserToDeleteRows = False
        Me.MechanicalDataGridView.AutoGenerateColumns = False
        Me.MechanicalDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MechanicalDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.MechanicalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MechanicalDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IndexNumberDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.DateOfBirthDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.NationalityDataGridViewTextBoxColumn, Me.DepartmentDataGridViewTextBoxColumn, Me.LevelDataGridViewTextBoxColumn, Me.ResidenceDataGridViewTextBoxColumn, Me.ActivityDataGridViewTextBoxColumn, Me.ContactDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn})
        Me.MechanicalDataGridView.DataSource = Me.ElectricalBindingSource
        Me.MechanicalDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MechanicalDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.MechanicalDataGridView.Name = "MechanicalDataGridView"
        Me.MechanicalDataGridView.ReadOnly = True
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(11, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.MechanicalDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.MechanicalDataGridView.RowTemplate.Height = 24
        Me.MechanicalDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MechanicalDataGridView.Size = New System.Drawing.Size(1499, 855)
        Me.MechanicalDataGridView.TabIndex = 0
        '
        'IndexNumberDataGridViewTextBoxColumn
        '
        Me.IndexNumberDataGridViewTextBoxColumn.DataPropertyName = "IndexNumber"
        Me.IndexNumberDataGridViewTextBoxColumn.HeaderText = "Index Number"
        Me.IndexNumberDataGridViewTextBoxColumn.Name = "IndexNumberDataGridViewTextBoxColumn"
        Me.IndexNumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        Me.LastNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "Other Names"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateOfBirthDataGridViewTextBoxColumn
        '
        Me.DateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "Date_Of_Birth"
        Me.DateOfBirthDataGridViewTextBoxColumn.HeaderText = "DOB"
        Me.DateOfBirthDataGridViewTextBoxColumn.Name = "DateOfBirthDataGridViewTextBoxColumn"
        Me.DateOfBirthDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        Me.GenderDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NationalityDataGridViewTextBoxColumn
        '
        Me.NationalityDataGridViewTextBoxColumn.DataPropertyName = "Nationality"
        Me.NationalityDataGridViewTextBoxColumn.HeaderText = "Nationality"
        Me.NationalityDataGridViewTextBoxColumn.Name = "NationalityDataGridViewTextBoxColumn"
        Me.NationalityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DepartmentDataGridViewTextBoxColumn
        '
        Me.DepartmentDataGridViewTextBoxColumn.DataPropertyName = "Department"
        Me.DepartmentDataGridViewTextBoxColumn.HeaderText = "Department"
        Me.DepartmentDataGridViewTextBoxColumn.Name = "DepartmentDataGridViewTextBoxColumn"
        Me.DepartmentDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LevelDataGridViewTextBoxColumn
        '
        Me.LevelDataGridViewTextBoxColumn.DataPropertyName = "Level"
        Me.LevelDataGridViewTextBoxColumn.HeaderText = "Level"
        Me.LevelDataGridViewTextBoxColumn.Name = "LevelDataGridViewTextBoxColumn"
        Me.LevelDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ResidenceDataGridViewTextBoxColumn
        '
        Me.ResidenceDataGridViewTextBoxColumn.DataPropertyName = "Residence"
        Me.ResidenceDataGridViewTextBoxColumn.HeaderText = "Residence"
        Me.ResidenceDataGridViewTextBoxColumn.Name = "ResidenceDataGridViewTextBoxColumn"
        Me.ResidenceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ActivityDataGridViewTextBoxColumn
        '
        Me.ActivityDataGridViewTextBoxColumn.DataPropertyName = "Activity"
        Me.ActivityDataGridViewTextBoxColumn.HeaderText = "Talent/Sport Discipline"
        Me.ActivityDataGridViewTextBoxColumn.Name = "ActivityDataGridViewTextBoxColumn"
        Me.ActivityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ContactDataGridViewTextBoxColumn
        '
        Me.ContactDataGridViewTextBoxColumn.DataPropertyName = "Contact"
        Me.ContactDataGridViewTextBoxColumn.HeaderText = "Contact"
        Me.ContactDataGridViewTextBoxColumn.Name = "ContactDataGridViewTextBoxColumn"
        Me.ContactDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ElectricalTableAdapter
        '
        Me.ElectricalTableAdapter.ClearBeforeFill = True
        '
        'Business
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1924, 1020)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Business"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Business Portal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.ElectricalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistrationDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MechanicalDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents srchtxt0 As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents ActivityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DepartmentComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents LevelComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents IndexNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GenderComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents LastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FirstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Date_Of_BirthDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents NationalityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ResidenceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContactTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MechanicalDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents RegistrationDBDataSet As SRCPortal.RegistrationDBDataSet
    Friend WithEvents ElectricalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ElectricalTableAdapter As SRCPortal.RegistrationDBDataSetTableAdapters.ElectricalTableAdapter
    Friend WithEvents IndexNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateOfBirthDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NationalityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DepartmentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LevelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ResidenceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ActivityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContactDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
