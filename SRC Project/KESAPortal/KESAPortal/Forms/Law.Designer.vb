<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Law
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Law))
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
        Me.IndexNumberTextBox1 = New System.Windows.Forms.TextBox()
        Me.CivilBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegistrationDBDataSet = New SRCPortal.RegistrationDBDataSet()
        Me.LastNameTextBox1 = New System.Windows.Forms.TextBox()
        Me.EmailTextBox1 = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox1 = New System.Windows.Forms.TextBox()
        Me.DepartmentComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ContactTextBox1 = New System.Windows.Forms.TextBox()
        Me.Date_Of_BirthDateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ActivityTextBox1 = New System.Windows.Forms.TextBox()
        Me.GenderComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ResidenceTextBox1 = New System.Windows.Forms.TextBox()
        Me.NationalityTextBox1 = New System.Windows.Forms.TextBox()
        Me.LevelComboBox1 = New System.Windows.Forms.ComboBox()
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
        Me.CivilTableAdapter = New SRCPortal.RegistrationDBDataSetTableAdapters.CivilTableAdapter()
        Me.TableAdapterManager = New SRCPortal.RegistrationDBDataSetTableAdapters.TableAdapterManager()
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
        CType(Me.CivilBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistrationDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MechanicalDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ActivityLabel
        '
        ActivityLabel.AutoSize = True
        ActivityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ActivityLabel.Location = New System.Drawing.Point(12, 395)
        ActivityLabel.Name = "ActivityLabel"
        ActivityLabel.Size = New System.Drawing.Size(100, 40)
        ActivityLabel.TabIndex = 25
        ActivityLabel.Text = "Talent/Sport" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Discipline:"
        '
        'DepartmentLabel
        '
        DepartmentLabel.AutoSize = True
        DepartmentLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DepartmentLabel.Location = New System.Drawing.Point(12, 21)
        DepartmentLabel.Name = "DepartmentLabel"
        DepartmentLabel.Size = New System.Drawing.Size(102, 20)
        DepartmentLabel.TabIndex = 22
        DepartmentLabel.Text = "Department:"
        '
        'IndexNumberLabel
        '
        IndexNumberLabel.AutoSize = True
        IndexNumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IndexNumberLabel.Location = New System.Drawing.Point(12, 64)
        IndexNumberLabel.Name = "IndexNumberLabel"
        IndexNumberLabel.Size = New System.Drawing.Size(117, 20)
        IndexNumberLabel.TabIndex = 0
        IndexNumberLabel.Text = "Index Number:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LastNameLabel.Location = New System.Drawing.Point(12, 107)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(96, 20)
        LastNameLabel.TabIndex = 2
        LastNameLabel.Text = "Last Name:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FirstNameLabel.Location = New System.Drawing.Point(12, 149)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(114, 20)
        FirstNameLabel.TabIndex = 4
        FirstNameLabel.Text = "Other Names:"
        '
        'Date_Of_BirthLabel
        '
        Date_Of_BirthLabel.AutoSize = True
        Date_Of_BirthLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Date_Of_BirthLabel.Location = New System.Drawing.Point(12, 194)
        Date_Of_BirthLabel.Name = "Date_Of_BirthLabel"
        Date_Of_BirthLabel.Size = New System.Drawing.Size(114, 20)
        Date_Of_BirthLabel.TabIndex = 6
        Date_Of_BirthLabel.Text = "Date Of Birth:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GenderLabel.Location = New System.Drawing.Point(12, 236)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(69, 20)
        GenderLabel.TabIndex = 8
        GenderLabel.Text = "Gender:"
        '
        'NationalityLabel
        '
        NationalityLabel.AutoSize = True
        NationalityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NationalityLabel.Location = New System.Drawing.Point(12, 279)
        NationalityLabel.Name = "NationalityLabel"
        NationalityLabel.Size = New System.Drawing.Size(92, 20)
        NationalityLabel.TabIndex = 10
        NationalityLabel.Text = "Nationality:"
        '
        'LevelLabel
        '
        LevelLabel.AutoSize = True
        LevelLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LevelLabel.Location = New System.Drawing.Point(12, 324)
        LevelLabel.Name = "LevelLabel"
        LevelLabel.Size = New System.Drawing.Size(54, 20)
        LevelLabel.TabIndex = 12
        LevelLabel.Text = "Level:"
        '
        'ResidenceLabel
        '
        ResidenceLabel.AutoSize = True
        ResidenceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ResidenceLabel.Location = New System.Drawing.Point(12, 367)
        ResidenceLabel.Name = "ResidenceLabel"
        ResidenceLabel.Size = New System.Drawing.Size(93, 20)
        ResidenceLabel.TabIndex = 14
        ResidenceLabel.Text = "Residence:"
        '
        'ContactLabel
        '
        ContactLabel.AutoSize = True
        ContactLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ContactLabel.Location = New System.Drawing.Point(12, 453)
        ContactLabel.Name = "ContactLabel"
        ContactLabel.Size = New System.Drawing.Size(72, 20)
        ContactLabel.TabIndex = 18
        ContactLabel.Text = "Contact:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailLabel.Location = New System.Drawing.Point(12, 495)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(56, 20)
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.srchtxt0)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1924, 1055)
        Me.SplitContainer1.SplitterDistance = 166
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
        Me.Button1.Location = New System.Drawing.Point(1731, 119)
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
        Me.srchtxt0.Location = New System.Drawing.Point(1384, 125)
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
        Me.Panel1.Location = New System.Drawing.Point(711, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(957, 128)
        Me.Panel1.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Minion Pro", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(693, 87)
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
        Me.Label1.Font = New System.Drawing.Font("Minion Pro", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(154, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(416, 65)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FACULTY OF LAW"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Minion Pro", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(175, 87)
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.IndexNumberTextBox1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.LastNameTextBox1)
        Me.SplitContainer2.Panel1.Controls.Add(DepartmentLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.EmailTextBox1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.FirstNameTextBox1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.DepartmentComboBox1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Button4)
        Me.SplitContainer2.Panel1.Controls.Add(Me.ContactTextBox1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Date_Of_BirthDateTimePicker1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Button3)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Button2)
        Me.SplitContainer2.Panel1.Controls.Add(Me.ActivityTextBox1)
        Me.SplitContainer2.Panel1.Controls.Add(IndexNumberLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.GenderComboBox1)
        Me.SplitContainer2.Panel1.Controls.Add(LastNameLabel)
        Me.SplitContainer2.Panel1.Controls.Add(FirstNameLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.ResidenceTextBox1)
        Me.SplitContainer2.Panel1.Controls.Add(Date_Of_BirthLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.NationalityTextBox1)
        Me.SplitContainer2.Panel1.Controls.Add(GenderLabel)
        Me.SplitContainer2.Panel1.Controls.Add(NationalityLabel)
        Me.SplitContainer2.Panel1.Controls.Add(LevelLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.LevelComboBox1)
        Me.SplitContainer2.Panel1.Controls.Add(ResidenceLabel)
        Me.SplitContainer2.Panel1.Controls.Add(ContactLabel)
        Me.SplitContainer2.Panel1.Controls.Add(EmailLabel)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.MechanicalDataGridView)
        Me.SplitContainer2.Size = New System.Drawing.Size(1924, 885)
        Me.SplitContainer2.SplitterDistance = 410
        Me.SplitContainer2.TabIndex = 0
        '
        'IndexNumberTextBox1
        '
        Me.IndexNumberTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CivilBindingSource, "IndexNumber", True))
        Me.IndexNumberTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IndexNumberTextBox1.Location = New System.Drawing.Point(194, 61)
        Me.IndexNumberTextBox1.Name = "IndexNumberTextBox1"
        Me.IndexNumberTextBox1.Size = New System.Drawing.Size(324, 27)
        Me.IndexNumberTextBox1.TabIndex = 31
        '
        'CivilBindingSource
        '
        Me.CivilBindingSource.DataMember = "Civil"
        Me.CivilBindingSource.DataSource = Me.RegistrationDBDataSet
        '
        'RegistrationDBDataSet
        '
        Me.RegistrationDBDataSet.DataSetName = "RegistrationDBDataSet"
        Me.RegistrationDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LastNameTextBox1
        '
        Me.LastNameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CivilBindingSource, "LastName", True))
        Me.LastNameTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastNameTextBox1.Location = New System.Drawing.Point(194, 104)
        Me.LastNameTextBox1.Name = "LastNameTextBox1"
        Me.LastNameTextBox1.Size = New System.Drawing.Size(324, 27)
        Me.LastNameTextBox1.TabIndex = 33
        '
        'EmailTextBox1
        '
        Me.EmailTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CivilBindingSource, "Email", True))
        Me.EmailTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTextBox1.Location = New System.Drawing.Point(194, 492)
        Me.EmailTextBox1.Name = "EmailTextBox1"
        Me.EmailTextBox1.Size = New System.Drawing.Size(324, 27)
        Me.EmailTextBox1.TabIndex = 51
        '
        'FirstNameTextBox1
        '
        Me.FirstNameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CivilBindingSource, "FirstName", True))
        Me.FirstNameTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstNameTextBox1.Location = New System.Drawing.Point(194, 146)
        Me.FirstNameTextBox1.Name = "FirstNameTextBox1"
        Me.FirstNameTextBox1.Size = New System.Drawing.Size(324, 27)
        Me.FirstNameTextBox1.TabIndex = 35
        '
        'DepartmentComboBox1
        '
        Me.DepartmentComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CivilBindingSource, "Department", True))
        Me.DepartmentComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DepartmentComboBox1.FormattingEnabled = True
        Me.DepartmentComboBox1.Items.AddRange(New Object() {"Law"})
        Me.DepartmentComboBox1.Location = New System.Drawing.Point(194, 18)
        Me.DepartmentComboBox1.Name = "DepartmentComboBox1"
        Me.DepartmentComboBox1.Size = New System.Drawing.Size(324, 28)
        Me.DepartmentComboBox1.TabIndex = 53
        Me.DepartmentComboBox1.Text = "Law"
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
        Me.Button4.Location = New System.Drawing.Point(16, 667)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(502, 56)
        Me.Button4.TabIndex = 23
        Me.Button4.Text = "Delete"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'ContactTextBox1
        '
        Me.ContactTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CivilBindingSource, "Contact", True))
        Me.ContactTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactTextBox1.Location = New System.Drawing.Point(194, 450)
        Me.ContactTextBox1.Name = "ContactTextBox1"
        Me.ContactTextBox1.Size = New System.Drawing.Size(324, 27)
        Me.ContactTextBox1.TabIndex = 49
        '
        'Date_Of_BirthDateTimePicker1
        '
        Me.Date_Of_BirthDateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CivilBindingSource, "Date_Of_Birth", True))
        Me.Date_Of_BirthDateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_Of_BirthDateTimePicker1.Location = New System.Drawing.Point(194, 189)
        Me.Date_Of_BirthDateTimePicker1.Name = "Date_Of_BirthDateTimePicker1"
        Me.Date_Of_BirthDateTimePicker1.Size = New System.Drawing.Size(324, 27)
        Me.Date_Of_BirthDateTimePicker1.TabIndex = 37
        Me.Date_Of_BirthDateTimePicker1.Value = New Date(1998, 6, 11, 0, 0, 0, 0)
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
        Me.Button3.Location = New System.Drawing.Point(16, 605)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(502, 56)
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
        Me.Button2.Size = New System.Drawing.Size(502, 56)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "Add"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ActivityTextBox1
        '
        Me.ActivityTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CivilBindingSource, "Activity", True))
        Me.ActivityTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActivityTextBox1.Location = New System.Drawing.Point(194, 408)
        Me.ActivityTextBox1.Name = "ActivityTextBox1"
        Me.ActivityTextBox1.Size = New System.Drawing.Size(324, 27)
        Me.ActivityTextBox1.TabIndex = 47
        '
        'GenderComboBox1
        '
        Me.GenderComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CivilBindingSource, "Gender", True))
        Me.GenderComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenderComboBox1.FormattingEnabled = True
        Me.GenderComboBox1.Items.AddRange(New Object() {"Male", "Female"})
        Me.GenderComboBox1.Location = New System.Drawing.Point(194, 233)
        Me.GenderComboBox1.Name = "GenderComboBox1"
        Me.GenderComboBox1.Size = New System.Drawing.Size(133, 28)
        Me.GenderComboBox1.TabIndex = 39
        Me.GenderComboBox1.Text = "-Select-"
        '
        'ResidenceTextBox1
        '
        Me.ResidenceTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CivilBindingSource, "Residence", True))
        Me.ResidenceTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResidenceTextBox1.Location = New System.Drawing.Point(194, 364)
        Me.ResidenceTextBox1.Name = "ResidenceTextBox1"
        Me.ResidenceTextBox1.Size = New System.Drawing.Size(324, 27)
        Me.ResidenceTextBox1.TabIndex = 45
        '
        'NationalityTextBox1
        '
        Me.NationalityTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CivilBindingSource, "Nationality", True))
        Me.NationalityTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NationalityTextBox1.Location = New System.Drawing.Point(194, 276)
        Me.NationalityTextBox1.Name = "NationalityTextBox1"
        Me.NationalityTextBox1.Size = New System.Drawing.Size(324, 27)
        Me.NationalityTextBox1.TabIndex = 41
        '
        'LevelComboBox1
        '
        Me.LevelComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CivilBindingSource, "Level", True))
        Me.LevelComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LevelComboBox1.FormattingEnabled = True
        Me.LevelComboBox1.Items.AddRange(New Object() {"100", "200", "300", "400"})
        Me.LevelComboBox1.Location = New System.Drawing.Point(194, 321)
        Me.LevelComboBox1.Name = "LevelComboBox1"
        Me.LevelComboBox1.Size = New System.Drawing.Size(133, 28)
        Me.LevelComboBox1.TabIndex = 43
        Me.LevelComboBox1.Text = "-Select-"
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
        Me.MechanicalDataGridView.DataSource = Me.CivilBindingSource
        Me.MechanicalDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MechanicalDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.MechanicalDataGridView.Name = "MechanicalDataGridView"
        Me.MechanicalDataGridView.ReadOnly = True
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(11, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.MechanicalDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.MechanicalDataGridView.RowTemplate.Height = 24
        Me.MechanicalDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MechanicalDataGridView.Size = New System.Drawing.Size(1510, 885)
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
        Me.ActivityDataGridViewTextBoxColumn.HeaderText = "Activity"
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
        'CivilTableAdapter
        '
        Me.CivilTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdminsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CivilTableAdapter = Me.CivilTableAdapter
        Me.TableAdapterManager.ComputerTableAdapter = Nothing
        Me.TableAdapterManager.ConstructionTableAdapter = Nothing
        Me.TableAdapterManager.ElectricalTableAdapter = Nothing
        Me.TableAdapterManager.ExecutiveTableTableAdapter = Nothing
        Me.TableAdapterManager.GeomaticTableAdapter = Nothing
        Me.TableAdapterManager.MechanicalTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SRCPortal.RegistrationDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Law
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Law"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Law Portal"
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
        CType(Me.CivilBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents MechanicalDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents RegistrationDBDataSet As SRCPortal.RegistrationDBDataSet
    Friend WithEvents CivilBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CivilTableAdapter As SRCPortal.RegistrationDBDataSetTableAdapters.CivilTableAdapter
    Friend WithEvents IndexNumberTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents LastNameTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents FirstNameTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DepartmentComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ContactTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Date_Of_BirthDateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ActivityTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GenderComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ResidenceTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents NationalityTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents LevelComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TableAdapterManager As SRCPortal.RegistrationDBDataSetTableAdapters.TableAdapterManager
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
