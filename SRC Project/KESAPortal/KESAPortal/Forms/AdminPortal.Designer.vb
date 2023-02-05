<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminPortal
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
        Dim IndexNumberLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim PositionLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim PictureLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminPortal))
        Me.RegistrationDBDataSet = New SRCPortal.RegistrationDBDataSet()
        Me.ExecutiveTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExecutiveTableTableAdapter = New SRCPortal.RegistrationDBDataSetTableAdapters.ExecutiveTableTableAdapter()
        Me.TableAdapterManager = New SRCPortal.RegistrationDBDataSetTableAdapters.TableAdapterManager()
        Me.IndexNumberTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.PositionTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.PicturePictureBox = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        IndexNumberLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        PositionLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        PictureLabel = New System.Windows.Forms.Label()
        CType(Me.RegistrationDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExecutiveTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicturePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IndexNumberLabel
        '
        IndexNumberLabel.AutoSize = True
        IndexNumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IndexNumberLabel.ForeColor = System.Drawing.Color.White
        IndexNumberLabel.Location = New System.Drawing.Point(37, 167)
        IndexNumberLabel.Name = "IndexNumberLabel"
        IndexNumberLabel.Size = New System.Drawing.Size(117, 20)
        IndexNumberLabel.TabIndex = 1
        IndexNumberLabel.Text = "Index Number:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FirstNameLabel.ForeColor = System.Drawing.Color.White
        FirstNameLabel.Location = New System.Drawing.Point(37, 195)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(97, 20)
        FirstNameLabel.TabIndex = 3
        FirstNameLabel.Text = "First Name:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LastNameLabel.ForeColor = System.Drawing.Color.White
        LastNameLabel.Location = New System.Drawing.Point(37, 223)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(96, 20)
        LastNameLabel.TabIndex = 5
        LastNameLabel.Text = "Last Name:"
        '
        'PositionLabel
        '
        PositionLabel.AutoSize = True
        PositionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PositionLabel.ForeColor = System.Drawing.Color.White
        PositionLabel.Location = New System.Drawing.Point(37, 251)
        PositionLabel.Name = "PositionLabel"
        PositionLabel.Size = New System.Drawing.Size(74, 20)
        PositionLabel.TabIndex = 7
        PositionLabel.Text = "Position:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PasswordLabel.ForeColor = System.Drawing.Color.White
        PasswordLabel.Location = New System.Drawing.Point(37, 279)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(88, 20)
        PasswordLabel.TabIndex = 9
        PasswordLabel.Text = "Password:"
        '
        'PictureLabel
        '
        PictureLabel.AutoSize = True
        PictureLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PictureLabel.ForeColor = System.Drawing.Color.White
        PictureLabel.Location = New System.Drawing.Point(37, 307)
        PictureLabel.Name = "PictureLabel"
        PictureLabel.Size = New System.Drawing.Size(67, 20)
        PictureLabel.TabIndex = 11
        PictureLabel.Text = "Picture:"
        '
        'RegistrationDBDataSet
        '
        Me.RegistrationDBDataSet.DataSetName = "RegistrationDBDataSet"
        Me.RegistrationDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ExecutiveTableBindingSource
        '
        Me.ExecutiveTableBindingSource.DataMember = "ExecutiveTable"
        Me.ExecutiveTableBindingSource.DataSource = Me.RegistrationDBDataSet
        '
        'ExecutiveTableTableAdapter
        '
        Me.ExecutiveTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdminsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CivilTableAdapter = Nothing
        Me.TableAdapterManager.ComputerTableAdapter = Nothing
        Me.TableAdapterManager.ConstructionTableAdapter = Nothing
        Me.TableAdapterManager.ElectricalTableAdapter = Nothing
        Me.TableAdapterManager.ExecutiveTableTableAdapter = Me.ExecutiveTableTableAdapter
        Me.TableAdapterManager.GeomaticTableAdapter = Nothing
        Me.TableAdapterManager.MechanicalTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SRCPortal.RegistrationDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IndexNumberTextBox
        '
        Me.IndexNumberTextBox.BackColor = System.Drawing.Color.OrangeRed
        Me.IndexNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.IndexNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ExecutiveTableBindingSource, "IndexNumber", True))
        Me.IndexNumberTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IndexNumberTextBox.ForeColor = System.Drawing.Color.White
        Me.IndexNumberTextBox.Location = New System.Drawing.Point(232, 167)
        Me.IndexNumberTextBox.Name = "IndexNumberTextBox"
        Me.IndexNumberTextBox.Size = New System.Drawing.Size(514, 20)
        Me.IndexNumberTextBox.TabIndex = 2
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.BackColor = System.Drawing.Color.OrangeRed
        Me.FirstNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ExecutiveTableBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstNameTextBox.ForeColor = System.Drawing.Color.White
        Me.FirstNameTextBox.Location = New System.Drawing.Point(232, 195)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(514, 20)
        Me.FirstNameTextBox.TabIndex = 3
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.BackColor = System.Drawing.Color.OrangeRed
        Me.LastNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ExecutiveTableBindingSource, "LastName", True))
        Me.LastNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastNameTextBox.ForeColor = System.Drawing.Color.White
        Me.LastNameTextBox.Location = New System.Drawing.Point(232, 223)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(514, 20)
        Me.LastNameTextBox.TabIndex = 4
        '
        'PositionTextBox
        '
        Me.PositionTextBox.BackColor = System.Drawing.Color.OrangeRed
        Me.PositionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PositionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ExecutiveTableBindingSource, "Position", True))
        Me.PositionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PositionTextBox.ForeColor = System.Drawing.Color.White
        Me.PositionTextBox.Location = New System.Drawing.Point(232, 251)
        Me.PositionTextBox.Name = "PositionTextBox"
        Me.PositionTextBox.Size = New System.Drawing.Size(514, 20)
        Me.PositionTextBox.TabIndex = 5
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.BackColor = System.Drawing.Color.OrangeRed
        Me.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ExecutiveTableBindingSource, "Password", True))
        Me.PasswordTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTextBox.ForeColor = System.Drawing.Color.White
        Me.PasswordTextBox.Location = New System.Drawing.Point(232, 279)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(514, 20)
        Me.PasswordTextBox.TabIndex = 6
        '
        'PicturePictureBox
        '
        Me.PicturePictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.ExecutiveTableBindingSource, "Picture", True))
        Me.PicturePictureBox.Location = New System.Drawing.Point(232, 307)
        Me.PicturePictureBox.Name = "PicturePictureBox"
        Me.PicturePictureBox.Size = New System.Drawing.Size(514, 223)
        Me.PicturePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicturePictureBox.TabIndex = 12
        Me.PicturePictureBox.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.OrangeRed
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSalmon
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(580, 536)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(166, 62)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Load image"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.OrangeRed
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSalmon
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(808, 607)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(464, 76)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.OrangeRed
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSalmon
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(808, 158)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(464, 80)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Add"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.OrangeRed
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSalmon
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(808, 245)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(464, 80)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Save"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.OrangeRed
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSalmon
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(808, 331)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(464, 80)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "Delete"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Swis721 Hv BT", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(456, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(355, 92)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "ADMINISTRATIVE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PORTAL"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.OrangeRed
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSalmon
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(232, 616)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(166, 59)
        Me.Button6.TabIndex = 1
        Me.Button6.Text = "Previous"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.OrangeRed
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button7.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSalmon
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Location = New System.Drawing.Point(580, 616)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(166, 59)
        Me.Button7.TabIndex = 0
        Me.Button7.Text = "Next"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.OrangeRed
        Me.Button8.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSalmon
        Me.Button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.ForeColor = System.Drawing.Color.White
        Me.Button8.Location = New System.Drawing.Point(1033, 446)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(239, 62)
        Me.Button8.TabIndex = 11
        Me.Button8.Text = "Backup Database"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.OrangeRed
        Me.Button9.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSalmon
        Me.Button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.ForeColor = System.Drawing.Color.White
        Me.Button9.Location = New System.Drawing.Point(1033, 514)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(239, 62)
        Me.Button9.TabIndex = 12
        Me.Button9.Text = "Restore Database"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'AdminPortal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1322, 719)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(IndexNumberLabel)
        Me.Controls.Add(Me.IndexNumberTextBox)
        Me.Controls.Add(FirstNameLabel)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(LastNameLabel)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(PositionLabel)
        Me.Controls.Add(Me.PositionTextBox)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(PictureLabel)
        Me.Controls.Add(Me.PicturePictureBox)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AdminPortal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TestPic"
        CType(Me.RegistrationDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExecutiveTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicturePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RegistrationDBDataSet As SRCPortal.RegistrationDBDataSet
    Friend WithEvents ExecutiveTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ExecutiveTableTableAdapter As SRCPortal.RegistrationDBDataSetTableAdapters.ExecutiveTableTableAdapter
    Friend WithEvents TableAdapterManager As SRCPortal.RegistrationDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IndexNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FirstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PositionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PicturePictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
End Class
