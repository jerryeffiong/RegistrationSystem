Public Class Report

    Private Sub Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RegistrationDBDataSet.Geomatic' table. You can move, or remove it, as needed.
        Me.GeomaticTableAdapter.Fill(Me.RegistrationDBDataSet.Geomatic)
        'TODO: This line of code loads data into the 'RegistrationDBDataSet.Construction' table. You can move, or remove it, as needed.
        Me.ConstructionTableAdapter.Fill(Me.RegistrationDBDataSet.Construction)
        'TODO: This line of code loads data into the 'RegistrationDBDataSet.Mechanical' table. You can move, or remove it, as needed.
        Me.MechanicalTableAdapter.Fill(Me.RegistrationDBDataSet.Mechanical)
        'TODO: This line of code loads data into the 'RegistrationDBDataSet.Electrical' table. You can move, or remove it, as needed.
        Me.ElectricalTableAdapter.Fill(Me.RegistrationDBDataSet.Electrical)
        'TODO: This line of code loads data into the 'RegistrationDBDataSet.Civil' table. You can move, or remove it, as needed.
        Me.CivilTableAdapter.Fill(Me.RegistrationDBDataSet.Civil)
        'TODO: This line of code loads data into the 'RegistrationDBDataSet.Computer' table. You can move, or remove it, as needed.
        Me.ComputerTableAdapter.Fill(Me.RegistrationDBDataSet.Computer)


       
        RV3.Visible = False
        RV4.Visible = False
        RV5.Visible = False
        RV6.Visible = False

        IndexNumberTextBox.Enabled = False
        RadioButton2.Checked = True


        RV6.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)

        RV3.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        RV4.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        RV5.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
       

        

        SelectionPanel.Close()

        
       
        Me.RV3.RefreshReport()
        Me.RV4.RefreshReport()
        Me.RV5.RefreshReport()
        Me.RV6.RefreshReport()






    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        If RadioButton2.Checked = True Then


            'TODO: This line of code loads data into the 'RegistrationDBDataSet.Construction' table. You can move, or remove it, as needed.
            Me.ConstructionTableAdapter.Fill(Me.RegistrationDBDataSet.Construction)
            'TODO: This line of code loads data into the 'RegistrationDBDataSet.Computer' table. You can move, or remove it, as needed.
            Me.ComputerTableAdapter.Fill(Me.RegistrationDBDataSet.Computer)
            'TODO: This line of code loads data into the 'RegistrationDBDataSet.Geomatic' table. You can move, or remove it, as needed.
            Me.GeomaticTableAdapter.Fill(Me.RegistrationDBDataSet.Geomatic)
            'TODO: This line of code loads data into the 'RegistrationDBDataSet.Electrical' table. You can move, or remove it, as needed.
            Me.ElectricalTableAdapter.Fill(Me.RegistrationDBDataSet.Electrical)
            'TODO: This line of code loads data into the 'RegistrationDBDataSet.Mechanical' table. You can move, or remove it, as needed.
            Me.MechanicalTableAdapter.Fill(Me.RegistrationDBDataSet.Mechanical)
            'TODO: This line of code loads data into the 'RegistrationDBDataSet.Civil' table. You can move, or remove it, as needed.
            Me.CivilTableAdapter.Fill(Me.RegistrationDBDataSet.Civil)







            ' remove previous report
            ' Me.Controls.Remove(RV)
            ' RV.Dispose()

            'RV = New Microsoft.Reporting.WinForms.ReportViewer
            ' RV.Parent = GroupBox1
            ' RV.Dock = DockStyle.Fill
            ' RV.Visible = True


            ' check the first report
            If ComboBox2.Text = "Law" Then



                ' '' fill the information for that report
                'Dim TA As New RegistrationDBDataSetTableAdapters.CivilTableAdapter
                'Dim TmpDS As New RegistrationDBDataSet
                'TA.Fill(TmpDS.Civil)

                '' clear previous DS
                'RV.LocalReport.DataSources.Clear()

                '' create new DS
                'Dim RDS As New Microsoft.Reporting.WinForms.ReportDataSource("RegistrationDBDataSet_Civil", CType(TmpDS.Civil, DataTable))

                '' tell the report control to use the DS, and 
                '' use the report template created by us.
                'RV.LocalReport.DataSources.Add(RDS)
                'RV.LocalReport.ReportEmbeddedResource = "KESAPortal.Report1.rdlc"
                'RV.RefreshReport()

                'RV.LocalReport.DataSources.Clear()
                'RV.LocalReport.ReportPath = "C:\Users\jerrysdsantos\Desktop\Brave\KESAPortal\KESAPortal\Report1.rdlc"
                'RV.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("RegistrationDBDataSet_Civil", CType(TmpDS.Civil, DataTable)))
                'RV.Visible = True
                'Me.RV.RefreshReport()

                
                RV3.Visible = False
                RV4.Visible = True
                RV5.Visible = False
                RV6.Visible = False


            ElseIf ComboBox2.Text = "Engineering" Then

                
                RV3.Visible = False
                RV4.Visible = False
                RV5.Visible = False
                RV6.Visible = True


            ElseIf ComboBox2.Text = "Business" Then

               
                RV3.Visible = False
                RV4.Visible = False
                RV5.Visible = True
                RV6.Visible = False

            ElseIf ComboBox2.Text = "Nursing" Then

               
                RV3.Visible = True
                RV4.Visible = False
                RV5.Visible = False
                RV6.Visible = False

           
            End If

        ElseIf RadioButton1.Checked = True Then

            Dim Index = CStr(IndexNumberTextBox.Text)

            'TODO: This line of code loads data into the 'RegistrationDBDataSet.Construction' table. You can move, or remove it, as needed.
            Me.ConstructionTableAdapter.FillByIndex(Me.RegistrationDBDataSet.Construction, Index)
            'TODO: This line of code loads data into the 'RegistrationDBDataSet.Computer' table. You can move, or remove it, as needed.
            Me.ComputerTableAdapter.FillByIndex(Me.RegistrationDBDataSet.Computer, Index)
            'TODO: This line of code loads data into the 'RegistrationDBDataSet.Geomatic' table. You can move, or remove it, as needed.
            Me.GeomaticTableAdapter.FillByIndex(Me.RegistrationDBDataSet.Geomatic, Index)
            'TODO: This line of code loads data into the 'RegistrationDBDataSet.Electrical' table. You can move, or remove it, as needed.
            Me.ElectricalTableAdapter.FillByIndex(Me.RegistrationDBDataSet.Electrical, Index)
            'TODO: This line of code loads data into the 'RegistrationDBDataSet.Mechanical' table. You can move, or remove it, as needed.
            Me.MechanicalTableAdapter.FillByIndex(Me.RegistrationDBDataSet.Mechanical, Index)
            'TODO: This line of code loads data into the 'RegistrationDBDataSet.Civil' table. You can move, or remove it, as needed.
            Me.CivilTableAdapter.FillByIndex(Me.RegistrationDBDataSet.Civil, Index)

           If ComboBox2.Text = "Nursing" Then



                RV3.Visible = True
                RV4.Visible = False
                RV5.Visible = False
                RV6.Visible = False

            ElseIf ComboBox2.Text = "Law" Then

                
                RV3.Visible = False
                RV4.Visible = True
                RV5.Visible = False
                RV6.Visible = False

            ElseIf ComboBox2.Text = "Business" Then

                
                RV3.Visible = False
                RV4.Visible = False
                RV5.Visible = True
                RV6.Visible = False

            ElseIf ComboBox2.Text = "Engineering" Then

               
                RV3.Visible = False
                RV4.Visible = False
                RV5.Visible = False
                RV6.Visible = True

            End If
        ElseIf RadioButton3.Checked = True Then

            Dim Department = CStr(ComboBox1.Text)


           
            Me.GeomaticTableAdapter.FillByDept(Me.RegistrationDBDataSet.Geomatic, Department)
            'TODO: This line of code loads data into the 'RegistrationDBDataSet.Electrical' table. You can move, or remove it, as needed.
            Me.ElectricalTableAdapter.FillByDept(Me.RegistrationDBDataSet.Electrical, Department)
            'TODO: This line of code loads data into the 'RegistrationDBDataSet.Mechanical' table. You can move, or remove it, as needed.
            Me.MechanicalTableAdapter.FillByDept(Me.RegistrationDBDataSet.Mechanical, Department)
            'TODO: This line of code loads data into the 'RegistrationDBDataSet.Civil' table. You can move, or remove it, as needed.
            Me.CivilTableAdapter.FillByDept(Me.RegistrationDBDataSet.Civil, Department)



            If ComboBox2.Text = "Law" Then

                
                RV3.Visible = False
                RV4.Visible = True
                RV5.Visible = False
                RV6.Visible = False


            ElseIf ComboBox2.Text = "Engineering" Then

               
                RV3.Visible = False
                RV4.Visible = False
                RV5.Visible = False
                RV6.Visible = True


            ElseIf ComboBox2.Text = "Business" Then

                
                RV3.Visible = False
                RV4.Visible = False
                RV5.Visible = True
                RV6.Visible = False

            ElseIf ComboBox2.Text = "Nursing" Then

                
                RV3.Visible = True
                RV4.Visible = False
                RV5.Visible = False
                RV6.Visible = False
            End If

        End If
        
        Me.RV3.RefreshReport()
        Me.RV4.RefreshReport()
        Me.RV5.RefreshReport()
        Me.RV6.RefreshReport()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            IndexNumberTextBox.Enabled = False
            ComboBox1.Enabled = False
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            IndexNumberTextBox.Enabled = True
            ComboBox1.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        SelectionPanel.Show()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.Text = "Engineering" Then

            
            ComboBox1.Items.Remove("Law")
            ComboBox1.Items.Remove("Business Administration")
            ComboBox1.Items.Remove("Accounting")
            ComboBox1.Items.Remove("Marketing")
            ComboBox1.Items.Remove("Banking and Finance")
            ComboBox1.Items.Remove("Human Resource Management")
            ComboBox1.Items.Remove("Nursing")

            ComboBox1.Items.Add("Mechanical Engneering")
            ComboBox1.Items.Add("Electrical Engineering")
            ComboBox1.Items.Add("Civil Engineering")
            ComboBox1.Items.Add("Geomatic Engineering")
            ComboBox1.Items.Add("Computer Science")
            ComboBox1.Items.Add("Construction Technology")

        ElseIf ComboBox2.Text = "Business" Then

            ComboBox1.Items.Remove("Mechanical Engneering")
            ComboBox1.Items.Remove("Electrical Engneering")
            ComboBox1.Items.Remove("Civil Engneering")
            ComboBox1.Items.Remove("Geomatic Engneering")
            ComboBox1.Items.Remove("Computer Science")
            ComboBox1.Items.Remove("Construction technology")
            ComboBox1.Items.Remove("Law")
            ComboBox1.Items.Remove("Nursing")

            ComboBox1.Items.Add("Business Administration")
            ComboBox1.Items.Add("Accounting")
            ComboBox1.Items.Add("Marketing")
            ComboBox1.Items.Add("Banking and Finance")
            ComboBox1.Items.Add("Human Resource Management")

        ElseIf ComboBox2.Text = "Law" Then

            ComboBox1.Items.Remove("Mechanical Engneering")
            ComboBox1.Items.Remove("Electrical Engneering")
            ComboBox1.Items.Remove("Civil Engneering")
            ComboBox1.Items.Remove("Geomatic Engneering")
            ComboBox1.Items.Remove("Computer Science")
            ComboBox1.Items.Remove("Construction technology")
            ComboBox1.Items.Remove("Business Administration")
            ComboBox1.Items.Remove("Accounting")
            ComboBox1.Items.Remove("Marketing")
            ComboBox1.Items.Remove("Banking and Finance")
            ComboBox1.Items.Remove("Human Resource Management")
            ComboBox1.Items.Remove("Nursing")

            ComboBox1.Items.Add("Law")

        ElseIf ComboBox2.Text = "Nursing" Then

            ComboBox1.Items.Remove("Mechanical Engneering")
            ComboBox1.Items.Remove("Electrical Engneering")
            ComboBox1.Items.Remove("Civil Engneering")
            ComboBox1.Items.Remove("Geomatic Engneering")
            ComboBox1.Items.Remove("Computer Science")
            ComboBox1.Items.Remove("Construction technology")
            ComboBox1.Items.Remove("Business Administration")
            ComboBox1.Items.Remove("Accounting")
            ComboBox1.Items.Remove("Marketing")
            ComboBox1.Items.Remove("Banking and Finance")
            ComboBox1.Items.Remove("Human Resource Management")
            ComboBox1.Items.Remove("Law")

            ComboBox1.Items.Add("Nursing")
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            IndexNumberTextBox.Enabled = False
            ComboBox1.Enabled = True
        End If
    End Sub

    
End Class