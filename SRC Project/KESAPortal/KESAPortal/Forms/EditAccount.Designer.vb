<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditAccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditAccount))
        Me.RegistrationDBDataSet = New SRCPortal.RegistrationDBDataSet()
        Me.AdminsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdminsTableAdapter = New SRCPortal.RegistrationDBDataSetTableAdapters.AdminsTableAdapter()
        Me.TableAdapterManager = New SRCPortal.RegistrationDBDataSetTableAdapters.TableAdapterManager()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.ExecutiveTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ExecutiveTableTableAdapter = New SRCPortal.RegistrationDBDataSetTableAdapters.ExecutiveTableTableAdapter()
        Me.PicturePictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.RegistrationDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdminsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExecutiveTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicturePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RegistrationDBDataSet
        '
        Me.RegistrationDBDataSet.DataSetName = "RegistrationDBDataSet"
        Me.RegistrationDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AdminsBindingSource
        '
        Me.AdminsBindingSource.DataMember = "Admins"
        Me.AdminsBindingSource.DataSource = Me.RegistrationDBDataSet
        '
        'AdminsTableAdapter
        '
        Me.AdminsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdminsTableAdapter = Me.AdminsTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CivilTableAdapter = Nothing
        Me.TableAdapterManager.ComputerTableAdapter = Nothing
        Me.TableAdapterManager.ConstructionTableAdapter = Nothing
        Me.TableAdapterManager.ElectricalTableAdapter = Nothing
        Me.TableAdapterManager.ExecutiveTableTableAdapter = Nothing
        Me.TableAdapterManager.GeomaticTableAdapter = Nothing
        Me.TableAdapterManager.MechanicalTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SRCPortal.RegistrationDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Humanst521 BT", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(375, 249)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 20)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Last Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Humanst521 BT", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(40, 249)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 20)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "First Name:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Humanst521 BT", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(699, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 20)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Profile Picture:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Humanst521 BT", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(375, 323)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 20)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Re-Enter Password:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Humanst521 BT", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(40, 323)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 20)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Password:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Humanst521 BT", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(375, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 20)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Executive Position:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Humanst521 BT", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(38, 192)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 20)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Index Number:"
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.OrangeRed
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox6.Font = New System.Drawing.Font("Arial Unicode MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.ForeColor = System.Drawing.Color.White
        Me.TextBox6.Location = New System.Drawing.Point(379, 356)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox6.Size = New System.Drawing.Size(276, 23)
        Me.TextBox6.TabIndex = 7
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.OrangeRed
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ExecutiveTableBindingSource, "LastName", True))
        Me.TextBox5.Font = New System.Drawing.Font("Arial Unicode MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.ForeColor = System.Drawing.Color.White
        Me.TextBox5.Location = New System.Drawing.Point(379, 286)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(276, 23)
        Me.TextBox5.TabIndex = 5
        '
        'ExecutiveTableBindingSource
        '
        Me.ExecutiveTableBindingSource.DataMember = "ExecutiveTable"
        Me.ExecutiveTableBindingSource.DataSource = Me.RegistrationDBDataSet
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.OrangeRed
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Salmon
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial Unicode MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(991, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 41)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "X"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.OrangeRed
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ExecutiveTableBindingSource, "Password", True))
        Me.TextBox2.Font = New System.Drawing.Font("Arial Unicode MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(42, 356)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox2.Size = New System.Drawing.Size(290, 23)
        Me.TextBox2.TabIndex = 6
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.OrangeRed
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Salmon
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Arial Unicode MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(703, 192)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(231, 77)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "Load Image"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.OrangeRed
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Salmon
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial Unicode MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(703, 304)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(231, 77)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Change"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.OrangeRed
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ExecutiveTableBindingSource, "IndexNumber", True))
        Me.TextBox7.Enabled = False
        Me.TextBox7.Font = New System.Drawing.Font("Arial Unicode MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.ForeColor = System.Drawing.Color.White
        Me.TextBox7.Location = New System.Drawing.Point(42, 219)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(290, 23)
        Me.TextBox7.TabIndex = 2
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.OrangeRed
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ExecutiveTableBindingSource, "FirstName", True))
        Me.TextBox4.Font = New System.Drawing.Font("Arial Unicode MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.ForeColor = System.Drawing.Color.White
        Me.TextBox4.Location = New System.Drawing.Point(42, 286)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(290, 23)
        Me.TextBox4.TabIndex = 4
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.OrangeRed
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ExecutiveTableBindingSource, "Position", True))
        Me.TextBox3.Font = New System.Drawing.Font("Arial Unicode MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.Color.White
        Me.TextBox3.Location = New System.Drawing.Point(379, 219)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(276, 23)
        Me.TextBox3.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SRCPortal.My.Resources.Resources.src_logo2
        Me.PictureBox1.Location = New System.Drawing.Point(28, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(138, 113)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'ExecutiveTableTableAdapter
        '
        Me.ExecutiveTableTableAdapter.ClearBeforeFill = True
        '
        'PicturePictureBox
        '
        Me.PicturePictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.ExecutiveTableBindingSource, "Picture", True))
        Me.PicturePictureBox.Location = New System.Drawing.Point(703, 43)
        Me.PicturePictureBox.Name = "PicturePictureBox"
        Me.PicturePictureBox.Size = New System.Drawing.Size(231, 138)
        Me.PicturePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicturePictureBox.TabIndex = 35
        Me.PicturePictureBox.TabStop = False
        '
        'EditAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1069, 455)
        Me.Controls.Add(Me.PicturePictureBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EditAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminPicTest"
        CType(Me.RegistrationDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdminsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExecutiveTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicturePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RegistrationDBDataSet As SRCPortal.RegistrationDBDataSet
    Friend WithEvents AdminsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AdminsTableAdapter As SRCPortal.RegistrationDBDataSetTableAdapters.AdminsTableAdapter
    Friend WithEvents TableAdapterManager As SRCPortal.RegistrationDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ExecutiveTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ExecutiveTableTableAdapter As SRCPortal.RegistrationDBDataSetTableAdapters.ExecutiveTableTableAdapter
    Friend WithEvents PicturePictureBox As System.Windows.Forms.PictureBox
End Class
