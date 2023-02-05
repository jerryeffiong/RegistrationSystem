Imports System.Data.OleDb
Imports System.IO



Public Class Form1

    Dim PicName As String
    Dim daImage As OleDbDataAdapter
    Dim dsImage As DataSet

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label57.Text = My.Settings.Name
        Label58.Text = My.Settings.Position

        'TODO: This line of code loads data into the 'RegistrationDBDataSet.Admins' table. You can move, or remove it, as needed.
        Me.AdminsTableAdapter.Fill(Me.RegistrationDBDataSet.Admins)

        Login.Close()
        SelectionPanel.Close()
        If My.Settings.Tabpageload = "0" Then
            TabControl1.SelectedTab = TabPage1
        ElseIf My.Settings.Tabpageload = "1" Then
            TabControl1.SelectedTab = TabPage2
        ElseIf My.Settings.Tabpageload = "2" Then
            TabControl1.SelectedTab = TabPage3
        ElseIf My.Settings.Tabpageload = "3" Then
            TabControl1.SelectedTab = TabPage4
        ElseIf My.Settings.Tabpageload = "4" Then
            TabControl1.SelectedTab = TabPage5
        ElseIf My.Settings.Tabpageload = "5" Then
            TabControl1.SelectedTab = TabPage6
        End If
        Try
            'TODO: This line of code loads data into the 'RegistrationDBDataSet.Construction' table. You can move, or remove it, as needed.
            Me.ConstructionTableAdapter.Fill(Me.RegistrationDBDataSet.Construction)
            'TODO: This line of code loads data into the 'RegistrationDBDataSet.Computer' table. You can move, or remove it, as needed.
            Me.ComputerTableAdapter.Fill(Me.RegistrationDBDataSet.Computer)
            'TODO: This line of code loads data into the 'RegistrationDBDataSet.Geomatic' table. You can move, or remove it, as needed.
            Me.GeomaticTableAdapter.Fill(Me.RegistrationDBDataSet.Geomatic)
            'TODO: This line of code loads data into the 'RegistrationDBDataSet.Civil' table. You can move, or remove it, as needed.
            Me.CivilTableAdapter.Fill(Me.RegistrationDBDataSet.Civil)
            'TODO: This line of code loads data into the 'RegistrationDBDataSet.Electrical' table. You can move, or remove it, as needed.
            Me.ElectricalTableAdapter.Fill(Me.RegistrationDBDataSet.Electrical)
            'TODO: This line of code loads data into the 'RegistrationDBDataSet.Mechanical' table. You can move, or remove it, as needed.
            Me.MechanicalTableAdapter.Fill(Me.RegistrationDBDataSet.Mechanical)
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        End Try

        Dim MechanicalTotal As Integer = DataGridView1.RowCount
        Dim ElectricallTotal As Integer = DataGridView2.RowCount
        Dim CivilTotal As Integer = DataGridView3.RowCount
        Dim GeomaticTotal As Integer = DataGridView4.RowCount
        Dim ComputerTotal As Integer = DataGridView5.RowCount
        Dim ConstructionTotal As Integer = DataGridView6.RowCount

        Dim TotalReg As Integer = (MechanicalTotal + ElectricallTotal + CivilTotal + GeomaticTotal + ComputerTotal + ConstructionTotal)
        Label69.Text = TotalReg

        Label001.Text = MechanicalTotal
        Label002.Text = ElectricallTotal
        Label003.Text = CivilTotal
        Label004.Text = GeomaticTotal
        Label005.Text = ComputerTotal
        Label006.Text = ConstructionTotal





    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            MechanicalBindingSource.AddNew()
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            MechanicalBindingSource.RemoveCurrent()
            Me.MechanicalBindingSource.EndEdit()
            Me.MechanicalTableAdapter.Update(Me.RegistrationDBDataSet)
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Me.Validate()
            Me.MechanicalBindingSource.EndEdit()
            Me.MechanicalTableAdapter.Update(Me.RegistrationDBDataSet)
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Application.Exit()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Try
            ElectricalBindingSource.AddNew()
        Catch ae As NoNullAllowedException

        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Me.Validate()
            Me.ElectricalBindingSource.EndEdit()
            Me.ElectricalTableAdapter.Update(Me.RegistrationDBDataSet)
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            ElectricalBindingSource.RemoveCurrent()
            Me.ElectricalBindingSource.EndEdit()
            Me.ElectricalTableAdapter.Update(Me.RegistrationDBDataSet)
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button26.Click
        Me.Close()
    End Sub
    Private Sub TabPage1_Load(sender As Object, e As EventArgs) Handles TextBox2.GotFocus
        Dpt.Text = TabPage1.Text & " Enginerring"

    End Sub
    Private Sub TabPage2_Load(sender As Object, e As EventArgs) Handles TextBox11.GotFocus
        Dpt.Text = TabPage2.Text & " Enginerring"

    End Sub


    Private Sub TabPage3_Load(sender As Object, e As EventArgs) Handles TextBox17.GotFocus
        Dpt.Text = TabPage3.Text & " Enginerring"

    End Sub

    Private Sub TabPage4_Load(sender As Object, e As EventArgs) Handles TextBox23.GotFocus
        Dpt.Text = TabPage4.Text & " Enginerring"

    End Sub

    Private Sub TabPage5_Load(sender As Object, e As EventArgs) Handles TextBox29.GotFocus
        Dpt.Text = TabPage5.Text

    End Sub
    Private Sub TabPage6_Load(sender As Object, e As EventArgs) Handles TextBox35.GotFocus
        Dpt.Text = TabPage6.Text & " Technology"

    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click
        Try
            ElectricalBindingSource.AddNew()
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub



    Private Sub Button16_Click(sender As Object, e As EventArgs)
        Try
            GeomaticBindingSource.AddNew()
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs)
        Try
            ComputerBindingSource.AddNew()
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs)
        Try
            ConstructionBindingSource.AddNew()
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    'Private Sub Button25_Click_1(sender As Object, e As EventArgs) Handles Button25.Click
    '    Try
    '        Dim Exepics As FileDialog = New OpenFileDialog()
    '        Exepics.Filter = "Image File (*.jpg;*.bmp;*.gif;*.png)|*.jpg;*.bmp;*.gif;*.png"

    '        If Exepics.ShowDialog() = Windows.Forms.DialogResult.OK Then
    '            PicName = Exepics.FileName

    '            Dim newimg As New Bitmap(PicName)

    '            PicturePictureBox.SizeMode = PictureBoxSizeMode.Zoom
    '            PicturePictureBox.Image = DirectCast(newimg, Image)
    '        End If

    '        PicName = Nothing

    '    Catch ae As System.ArgumentException
    '        PicName = " "
    '        MessageBox.Show(ae.Message.ToString())
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message.ToString())
    '    End Try
    'End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            Dim Exepics As FileDialog = New OpenFileDialog()
            Exepics.Filter = "Image File (*.jpg;*.bmp;*.gif;*.png)|*.jpg;*.bmp;*.gif;*.png"

            If Exepics.ShowDialog() = Windows.Forms.DialogResult.OK Then
                PicName = Exepics.FileName

                Dim newimg As New Bitmap(PicName)

                PicturePictureBox1.SizeMode = PictureBoxSizeMode.Zoom
                PicturePictureBox1.Image = DirectCast(newimg, Image)
            End If

            PicName = Nothing

        Catch ae As System.ArgumentException
            PicName = " "
            MessageBox.Show(ae.Message.ToString())
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub

    'Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
    '    Try
    '        Dim Exepics As FileDialog = New OpenFileDialog()
    '        Exepics.Filter = "Image File (*.jpg;*.bmp;*.gif;*.png)|*.jpg;*.bmp;*.gif;*.png"

    '        If Exepics.ShowDialog() = Windows.Forms.DialogResult.OK Then
    '            PicName = Exepics.FileName

    '            Dim newimg As New Bitmap(PicName)

    '            PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
    '            PictureBox3.Image = DirectCast(newimg, Image)
    '        End If

    '        PicName = Nothing

    '    Catch ae As System.ArgumentException
    '        PicName = " "
    '        MessageBox.Show(ae.Message.ToString())
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message.ToString())
    '    End Try
    'End Sub

    Private Sub Button12_Click_1(sender As Object, e As EventArgs) Handles Button12.Click
        Try
            CivilBindingSource.AddNew()
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Try
            Me.Validate()
            Me.CivilBindingSource.EndEdit()
            Me.CivilTableAdapter.Update(Me.RegistrationDBDataSet)
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Try
            CivilBindingSource.RemoveCurrent()
            Me.CivilBindingSource.EndEdit()
            Me.CivilTableAdapter.Update(Me.RegistrationDBDataSet)
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        Application.Exit()
    End Sub

    Private Sub Button16_Click_1(sender As Object, e As EventArgs) Handles Button16.Click
        Try
            GeomaticBindingSource.AddNew()
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Try
            Dim Exepics As FileDialog = New OpenFileDialog()
            Exepics.Filter = "Image File (*.jpg;*.bmp;*.gif;*.png)|*.jpg;*.bmp;*.gif;*.png"

            If Exepics.ShowDialog() = Windows.Forms.DialogResult.OK Then
                PicName = Exepics.FileName

                Dim newimg As New Bitmap(PicName)

                PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
                PictureBox4.Image = DirectCast(newimg, Image)
            End If

            PicName = Nothing

        Catch ae As System.ArgumentException
            PicName = " "
            MessageBox.Show(ae.Message.ToString())
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Try
            Me.Validate()
            Me.GeomaticBindingSource.EndEdit()
            Me.GeomaticTableAdapter.Update(Me.RegistrationDBDataSet)
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Try
            GeomaticBindingSource.RemoveCurrent()
            Me.GeomaticBindingSource.EndEdit()
            Me.GeomaticTableAdapter.Update(Me.RegistrationDBDataSet)
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        Application.Exit()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Try
            Dim Exepics As FileDialog = New OpenFileDialog()
            Exepics.Filter = "Image File (*.jpg;*.bmp;*.gif;*.png)|*.jpg;*.bmp;*.gif;*.png"

            If Exepics.ShowDialog() = Windows.Forms.DialogResult.OK Then
                PicName = Exepics.FileName

                Dim newimg As New Bitmap(PicName)

                PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
                PictureBox5.Image = DirectCast(newimg, Image)
            End If

            PicName = Nothing

        Catch ae As System.ArgumentException
            PicName = " "
            MessageBox.Show(ae.Message.ToString())
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub

    Private Sub Button20_Click_1(sender As Object, e As EventArgs) Handles Button20.Click
        Try
            ComputerBindingSource.AddNew()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Try
            Me.Validate()
            Me.ComputerBindingSource.EndEdit()
            Me.ComputerTableAdapter.Update(Me.RegistrationDBDataSet)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Try
            Me.ComputerBindingSource.RemoveCurrent()
            Me.ComputerBindingSource.EndEdit()
            Me.ComputerTableAdapter.Update(Me.RegistrationDBDataSet)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        Application.Exit()
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Try
            Dim Exepics As FileDialog = New OpenFileDialog()
            Exepics.Filter = "Image File (*.jpg;*.bmp;*.gif;*.png)|*.jpg;*.bmp;*.gif;*.png"

            If Exepics.ShowDialog() = Windows.Forms.DialogResult.OK Then
                PicName = Exepics.FileName

                Dim newimg As New Bitmap(PicName)

                PictureBox6.SizeMode = PictureBoxSizeMode.Zoom
                PictureBox6.Image = DirectCast(newimg, Image)
            End If

            PicName = Nothing

        Catch ae As System.ArgumentException
            PicName = " "
            MessageBox.Show(ae.Message.ToString())
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub

    Private Sub Button24_Click_1(sender As Object, e As EventArgs) Handles Button24.Click
        Try
            Me.ConstructionBindingSource.AddNew()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Try
            Me.Validate()
            Me.ConstructionBindingSource.EndEdit()
            Me.ConstructionTableAdapter.Update(Me.RegistrationDBDataSet)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Try
            Me.ConstructionBindingSource.RemoveCurrent()
            Me.ConstructionBindingSource.EndEdit()
            Me.ConstructionTableAdapter.Update(Me.RegistrationDBDataSet)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        Application.Exit()
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        Me.Hide()
        SelectionPanel.Show()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Me.Hide()
        SelectionPanel.Show()
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click

        Dim srch As String = srchtxt0.Text
        Dim irowindex As String
        Dim strl As Integer
        DataGridView1.ClearSelection()
        For i As Integer = 0 To DataGridView1.RowCount - 1
            Dim SrcLN = DataGridView1.Rows(i).Cells(1).Value
            Dim SrcIND = DataGridView1.Rows(i).Cells(0).Value
            Dim SrcON = DataGridView1.Rows(i).Cells(2).Value
            If SrcIND IsNot Nothing Then

                'For LastName
                If SrcLN.ToString.ToUpper.StartsWith(srch.ToUpper) Then

                    DataGridView1.Rows(i).Cells(1).Selected = True
                    irowindex = CStr(DataGridView1.SelectedCells.Item(0).Value)
                    MessageBox.Show(irowindex, "Index Number")
                    Exit For

                    'For Index Number
                ElseIf DataGridView1.Rows(i).Cells(0).Value.ToString.ToUpper.StartsWith(srch.ToUpper) Then
                    DataGridView1.Rows(i).Selected = True
                    irowindex = DataGridView1.SelectedCells.Item(0).Value
                    MessageBox.Show(SrcON + " " + SrcLN, "Name")
                    Exit For

                    'For Other names
                ElseIf SrcON.ToString.ToUpper.StartsWith(srch.ToUpper) Then
                    DataGridView1.Rows(i).Cells(3).Selected = True
                    irowindex = CStr(DataGridView1.SelectedCells.Item(0).Value)
                    MessageBox.Show(irowindex, "Index Number")
                    Exit For

                End If

            ElseIf srchtxt0.Text = "" Or srchtxt0.Text = "Enter a Name or an Index number" Then
                MsgBox("Enter a Name", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Invalid entry")
                srchtxt0.Focus()
                Exit For
            End If
        Next



    End Sub

    Private Sub Panel3_Hover(sender As Object, e As EventArgs) Handles Label70.MouseHover, Label69.MouseHover
        Panel1.Visible = True
    End Sub

    Private Sub Panel3_MouseLeave(sender As Object, e As EventArgs) Handles Label70.MouseLeave, Label69.MouseLeave
        Panel1.Visible = False
    End Sub

    Private Sub TextBox43_Click(sender As Object, e As EventArgs) Handles srchtxt0.GotFocus
        srchtxt0.Clear()
    End Sub

    Private Sub TextBox43_Clic(sender As Object, e As EventArgs) Handles srchtxt0.LostFocus
        If srchtxt0.Text = "" Then
            srchtxt0.Text = "Enter a Name or an Index number"
        End If
    End Sub



    Private Sub TextBox43_TextChanged(sender As Object, e As EventArgs) Handles srchtxt0.TextChanged
        Dim d As Integer = 0
        Dim srch As String = srchtxt0.Text
        Dim irowindex As String
        Dim strl As Integer
        DataGridView1.ClearSelection()
        For i = 0 To DataGridView1.RowCount - 1
            Dim SrcLN As String = DataGridView1.Rows(i).Cells(1).Value
            Dim SrcIND As String = DataGridView1.Rows(i).Cells(0).Value
            Dim SrcON As String = DataGridView1.Rows(i).Cells(2).Value

            If SrcIND IsNot Nothing Then
                If SrcLN.ToString.ToUpper.StartsWith(srch.ToUpper) Then

                    DataGridView1.Rows(i).Cells(1).Selected = True
                    irowindex = DataGridView1.SelectedCells.Item(0).Value

                    Exit For

                    'For Index Number
                ElseIf SrcIND.ToString.StartsWith(srch) Then

                    DataGridView1.Rows(i).Cells(0).Selected = True
                    irowindex = CStr(DataGridView1.SelectedCells.Item(1).Value + " " + DataGridView1.SelectedCells.Item(2).Value)

                    Exit For

                    'For Other names
                ElseIf SrcON.ToString.ToUpper.StartsWith(srch.ToUpper) Then

                    DataGridView1.Rows(i).Cells(3).Selected = True
                    irowindex = CStr(DataGridView1.SelectedCells.Item(0).Value)

                    Exit For

                End If
            End If
        Next
    End Sub

    Private Sub TextBox001_Click(sender As Object, e As EventArgs) Handles srchtxt1.GotFocus
        srchtxt1.Clear()
    End Sub

    Private Sub TextBox002_Click(sender As Object, e As EventArgs) Handles srchtxt2.GotFocus
        srchtxt2.Clear()
    End Sub

    Private Sub TextBox003_Click(sender As Object, e As EventArgs) Handles srchtxt3.GotFocus
        srchtxt3.Clear()
    End Sub

    Private Sub TextBox004_Click(sender As Object, e As EventArgs) Handles srchtxt4.GotFocus
        srchtxt4.Clear()
    End Sub

    Private Sub TextBox005_Click(sender As Object, e As EventArgs) Handles srchtxt5.GotFocus
        srchtxt5.Clear()
    End Sub

    Private Sub TextBox001_Clic(sender As Object, e As EventArgs) Handles srchtxt1.LostFocus
        If srchtxt1.Text = "" Then
            srchtxt1.Text = "Enter a Name or an Index number"
        End If
    End Sub

    Private Sub TextBox002_Clic(sender As Object, e As EventArgs) Handles srchtxt2.LostFocus
        If srchtxt2.Text = "" Then
            srchtxt2.Text = "Enter a Name or an Index number"
        End If
    End Sub

    Private Sub TextBox003_Clic(sender As Object, e As EventArgs) Handles srchtxt3.LostFocus
        If srchtxt3.Text = "" Then
            srchtxt3.Text = "Enter a Name or an Index number"
        End If
    End Sub

    Private Sub TextBox004_Clic(sender As Object, e As EventArgs) Handles srchtxt4.LostFocus
        If srchtxt4.Text = "" Then
            srchtxt4.Text = "Enter a Name or an Index number"
        End If
    End Sub

    Private Sub TextBox005_Clic(sender As Object, e As EventArgs) Handles srchtxt5.LostFocus
        If srchtxt5.Text = "" Then
            srchtxt5.Text = "Enter a Name or an Index number"
        End If
    End Sub

    Private Sub TextBox44_TextChanged(sender As Object, e As EventArgs) Handles srchtxt1.TextChanged
        Dim d As Integer = 0
        Dim srch As String = srchtxt1.Text
        Dim irowindex As String
        Dim strl As Integer
        DataGridView2.ClearSelection()
        For i = 0 To DataGridView2.RowCount - 1
            Dim SrcLN As String = DataGridView2.Rows(i).Cells(1).Value
            Dim SrcIND As String = DataGridView2.Rows(i).Cells(0).Value
            Dim SrcON As String = DataGridView2.Rows(i).Cells(2).Value

            If SrcLN IsNot Nothing Then
                If SrcLN.ToString.ToUpper.StartsWith(srch.ToUpper) Then

                    DataGridView2.Rows(i).Cells(1).Selected = True
                    irowindex = DataGridView2.SelectedCells.Item(0).Value

                    Exit For

                    'For Index Number
                ElseIf SrcIND.ToString.StartsWith(srch) Then

                    DataGridView2.Rows(i).Cells(0).Selected = True
                    irowindex = CStr(DataGridView2.SelectedCells.Item(1).Value + " " + DataGridView2.SelectedCells.Item(2).Value)

                    Exit For

                    'For Other names
                ElseIf SrcON.ToString.ToUpper.StartsWith(srch.ToUpper) Then

                    DataGridView2.Rows(i).Cells(3).Selected = True
                    irowindex = CStr(DataGridView2.SelectedCells.Item(0).Value)

                    Exit For

                End If
            End If
        Next
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click

        Dim srch As String = srchtxt1.Text
        Dim irowindex As String
        Dim strl As Integer
        DataGridView2.ClearSelection()
        For i = 0 To DataGridView2.RowCount - 1
            Dim SrcLN As String = DataGridView2.Rows(i).Cells(1).Value
            Dim SrcIND As String = DataGridView2.Rows(i).Cells(0).Value
            Dim SrcON As String = DataGridView2.Rows(i).Cells(2).Value
            If SrcLN IsNot Nothing Then

                'For LastName
                If SrcLN.ToString.ToUpper.StartsWith(srch.ToUpper) Then

                    DataGridView2.Rows(i).Cells(1).Selected = True
                    irowindex = CStr(DataGridView2.SelectedCells.Item(0).Value)
                    MessageBox.Show(irowindex, "Index Number")
                    Exit For

                    'For Index Number
                ElseIf DataGridView2.Rows(i).Cells(0).Value.ToString.ToUpper.StartsWith(srch.ToUpper) Then
                    DataGridView2.Rows(i).Selected = True
                    irowindex = DataGridView2.SelectedCells.Item(0).Value
                    MessageBox.Show(SrcON + " " + SrcLN, "Name")
                    Exit For

                    'For Other names
                ElseIf SrcON.ToString.ToUpper.StartsWith(srch.ToUpper) Then
                    DataGridView2.Rows(i).Cells(3).Selected = True
                    irowindex = CStr(DataGridView2.SelectedCells.Item(0).Value)
                    MessageBox.Show(irowindex, "Index Number")
                    Exit For


                End If

            ElseIf srchtxt1.Text = "" Or srchtxt1.Text = "Enter a Name or an Index number" Then
                MsgBox("Enter a Name", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Invalid entry")
                srchtxt1.Focus()
                Exit For
            End If
        Next
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        Dim d As Integer = 0
        Dim srch As String = srchtxt2.Text
        Dim irowindex As Integer
        Dim strl As Integer
        DataGridView3.ClearSelection()
        For i = 0 To DataGridView3.RowCount - 1
            Dim SrcLN As String = DataGridView3.Rows(i).Cells(1).Value
            Dim SrcIND As String = DataGridView3.Rows(i).Cells(0).Value
            Dim SrcON As String = DataGridView3.Rows(i).Cells(2).Value
            If SrcLN IsNot Nothing Then

                'For LastName
                If SrcLN.ToString.ToUpper.StartsWith(srch.ToUpper) Then

                    DataGridView3.Rows(i).Cells(1).Selected = True
                    irowindex = CStr(DataGridView3.SelectedCells.Item(0).Value)
                    MessageBox.Show(irowindex, "Index Number")
                    Exit For

                    'For Index Number
                ElseIf DataGridView2.Rows(i).Cells(0).Value.ToString.ToUpper.StartsWith(srch.ToUpper) Then
                    DataGridView2.Rows(i).Selected = True
                    irowindex = DataGridView2.SelectedCells.Item(0).Value
                    MessageBox.Show(SrcON + " " + SrcLN, "Name")
                    Exit For

                    'For Other names
                ElseIf SrcON.ToString.ToUpper.StartsWith(srch.ToUpper) Then
                    DataGridView3.Rows(i).Cells(3).Selected = True
                    irowindex = CStr(DataGridView3.SelectedCells.Item(0).Value)
                    MessageBox.Show(irowindex, "Index Number")
                    Exit For

                Else
                    MsgBox("Name NOT found", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Invalid entry")
                    Exit For
                End If

            ElseIf srchtxt2.Text = "" Or srchtxt2.Text = "Enter a Name or an Index number" Then
                MsgBox("Enter a Name", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Invalid entry")
                srchtxt0.Focus()
                Exit For
            End If
        Next
    End Sub

    Private Sub srchtxt2_TextChanged(sender As Object, e As EventArgs) Handles srchtxt2.TextChanged
        Dim d As Integer = 0
        Dim srch As String = srchtxt2.Text
        Dim irowindex As String
        Dim strl As Integer
        DataGridView3.ClearSelection()
        For i = 0 To DataGridView3.RowCount - 1
            Dim SrcLN As String = DataGridView3.Rows(i).Cells(1).Value
            Dim SrcIND As String = DataGridView3.Rows(i).Cells(0).Value
            Dim SrcON As String = DataGridView3.Rows(i).Cells(2).Value

            If SrcLN IsNot Nothing Then
                If SrcLN.ToString.ToUpper.StartsWith(srch.ToUpper) Then

                    DataGridView3.Rows(i).Cells(1).Selected = True
                    irowindex = DataGridView3.SelectedCells.Item(0).Value

                    Exit For

                    'For Index Number
                ElseIf SrcIND.ToString.StartsWith(srch) Then

                    DataGridView3.Rows(i).Cells(0).Selected = True
                    irowindex = CStr(DataGridView3.SelectedCells.Item(1).Value + " " + DataGridView3.SelectedCells.Item(2).Value)

                    Exit For

                    'For Other names
                ElseIf SrcON.ToString.ToUpper.StartsWith(srch.ToUpper) Then

                    DataGridView3.Rows(i).Cells(3).Selected = True
                    irowindex = CStr(DataGridView3.SelectedCells.Item(0).Value)

                    Exit For

                End If
            End If
        Next
    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        Dim srch As String = srchtxt3.Text
        Dim irowindex As String
        Dim strl As Integer
        DataGridView4.ClearSelection()
        For i = 0 To DataGridView4.RowCount - 1
            Dim SrcLN As String = DataGridView4.Rows(i).Cells(1).Value
            Dim SrcIND As String = DataGridView4.Rows(i).Cells(0).Value
            Dim SrcON As String = DataGridView4.Rows(i).Cells(2).Value
            If SrcLN IsNot Nothing Then

                'For LastName
                If SrcLN.ToString.ToUpper.StartsWith(srch.ToUpper) Then

                    DataGridView4.Rows(i).Cells(1).Selected = True
                    irowindex = CStr(DataGridView4.SelectedCells.Item(0).Value)
                    MessageBox.Show(irowindex, "Index Number")
                    Exit For

                    'For Index Number
                ElseIf DataGridView4.Rows(i).Cells(0).Value.ToString.ToUpper.StartsWith(srch.ToUpper) Then
                    DataGridView4.Rows(i).Selected = True
                    irowindex = DataGridView4.SelectedCells.Item(0).Value
                    MessageBox.Show(SrcON + " " + SrcLN, "Name")
                    Exit For

                    'For Other names
                ElseIf SrcON.ToString.ToUpper.StartsWith(srch.ToUpper) Then
                    DataGridView4.Rows(i).Cells(3).Selected = True
                    irowindex = CStr(DataGridView4.SelectedCells.Item(0).Value)
                    MessageBox.Show(irowindex, "Index Number")
                    Exit For


                End If

            ElseIf srchtxt3.Text = "" Or srchtxt3.Text = "Enter a Name or an Index number" Then
                MsgBox("Enter a Name", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Invalid entry")
                srchtxt3.Focus()
                Exit For
            End If
        Next
    End Sub


    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click

        Dim srch As String = srchtxt4.Text
        Dim irowindex As String
        Dim strl As Integer
        DataGridView5.ClearSelection()
        For i = 0 To DataGridView5.RowCount - 1
            Dim SrcLN As String = DataGridView5.Rows(i).Cells(1).Value
            Dim SrcIND As String = DataGridView5.Rows(i).Cells(0).Value
            Dim SrcON As String = DataGridView5.Rows(i).Cells(2).Value
            If SrcLN IsNot Nothing Then

                'For LastName
                If SrcLN.ToString.ToUpper.StartsWith(srch.ToUpper) Then

                    DataGridView5.Rows(i).Cells(1).Selected = True
                    irowindex = CStr(DataGridView5.SelectedCells.Item(0).Value)
                    MessageBox.Show(irowindex, "Index Number")
                    Exit For

                    'For Index Number
                ElseIf DataGridView5.Rows(i).Cells(0).Value.ToString.ToUpper.StartsWith(srch.ToUpper) Then
                    DataGridView5.Rows(i).Selected = True
                    irowindex = DataGridView5.SelectedCells.Item(0).Value
                    MessageBox.Show(SrcON + " " + SrcLN, "Name")
                    Exit For

                    'For Other names
                ElseIf SrcON.ToString.ToUpper.StartsWith(srch.ToUpper) Then
                    DataGridView5.Rows(i).Cells(3).Selected = True
                    irowindex = CStr(DataGridView5.SelectedCells.Item(0).Value)
                    MessageBox.Show(irowindex, "Index Number")
                    Exit For


                End If

            ElseIf srchtxt4.Text = "" Or srchtxt4.Text = "Enter a Name or an Index number" Then
                MsgBox("Enter a Name", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Invalid entry")
                srchtxt4.Focus()
                Exit For
            End If
        Next
    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click

        Dim srch As String = srchtxt5.Text
        Dim irowindex As String
        Dim strl As Integer
        DataGridView6.ClearSelection()
        For i = 0 To DataGridView6.RowCount - 1
            Dim SrcLN As String = DataGridView6.Rows(i).Cells(1).Value
            Dim SrcIND As String = DataGridView6.Rows(i).Cells(0).Value
            Dim SrcON As String = DataGridView6.Rows(i).Cells(2).Value
            If SrcLN IsNot Nothing Then

                'For LastName
                If SrcLN.ToString.ToUpper.StartsWith(srch.ToUpper) Then

                    DataGridView6.Rows(i).Cells(1).Selected = True
                    irowindex = CStr(DataGridView6.SelectedCells.Item(0).Value)
                    MessageBox.Show(irowindex, "Index Number")
                    Exit For

                    'For Index Number
                ElseIf DataGridView6.Rows(i).Cells(0).Value.ToString.ToUpper.StartsWith(srch.ToUpper) Then
                    DataGridView6.Rows(i).Selected = True
                    irowindex = DataGridView6.SelectedCells.Item(0).Value
                    MessageBox.Show(SrcON + " " + SrcLN, "Name")
                    Exit For

                    'For Other names
                ElseIf SrcON.ToString.ToUpper.StartsWith(srch.ToUpper) Then
                    DataGridView6.Rows(i).Cells(3).Selected = True
                    irowindex = CStr(DataGridView6.SelectedCells.Item(0).Value)
                    MessageBox.Show(irowindex, "Index Number")
                    Exit For


                End If

            ElseIf srchtxt5.Text = "" Or srchtxt5.Text = "Enter a Name or an Index number" Then
                MsgBox("Enter a Name", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Invalid entry")
                srchtxt5.Focus()
                Exit For
            End If
        Next
    End Sub

    Private Sub srchtxt4_TextChanged(sender As Object, e As EventArgs) Handles srchtxt4.TextChanged

        Dim d As Integer = 0
        Dim srch As String = srchtxt4.Text
        Dim irowindex As String
        Dim strl As Integer
        DataGridView5.ClearSelection()
        For i = 0 To DataGridView5.RowCount - 1
            Dim SrcLN As String = DataGridView5.Rows(i).Cells(1).Value
            Dim SrcIND As String = DataGridView5.Rows(i).Cells(0).Value
            Dim SrcON As String = DataGridView5.Rows(i).Cells(2).Value

            If SrcLN IsNot Nothing Then
                If SrcLN.ToString.ToUpper.StartsWith(srch.ToUpper) Then

                    DataGridView5.Rows(i).Cells(1).Selected = True
                    irowindex = DataGridView5.SelectedCells.Item(0).Value

                    Exit For

                    'For Index Number
                ElseIf SrcIND.ToString.StartsWith(srch) Then

                    DataGridView5.Rows(i).Cells(0).Selected = True
                    irowindex = CStr(DataGridView5.SelectedCells.Item(1).Value + " " + DataGridView5.SelectedCells.Item(2).Value)

                    Exit For

                    'For Other names
                ElseIf SrcON.ToString.ToUpper.StartsWith(srch.ToUpper) Then

                    DataGridView5.Rows(i).Cells(3).Selected = True
                    irowindex = CStr(DataGridView5.SelectedCells.Item(0).Value)

                    Exit For

                End If
            End If
        Next
    End Sub

    Private Sub srchtxt5_TextChanged(sender As Object, e As EventArgs) Handles srchtxt5.TextChanged

        Dim d As Integer = 0
        Dim srch As String = srchtxt5.Text
        Dim irowindex As String
        Dim strl As Integer
        DataGridView6.ClearSelection()
        For i = 0 To DataGridView6.RowCount - 1
            Dim SrcLN As String = DataGridView6.Rows(i).Cells(1).Value
            Dim SrcIND As String = DataGridView6.Rows(i).Cells(0).Value
            Dim SrcON As String = DataGridView6.Rows(i).Cells(2).Value

            If SrcLN IsNot Nothing Then
                If SrcLN.ToString.ToUpper.StartsWith(srch.ToUpper) Then

                    DataGridView6.Rows(i).Cells(1).Selected = True
                    irowindex = DataGridView6.SelectedCells.Item(0).Value

                    Exit For

                    'For Index Number
                ElseIf SrcIND.ToString.StartsWith(srch) Then

                    DataGridView6.Rows(i).Cells(0).Selected = True
                    irowindex = CStr(DataGridView6.SelectedCells.Item(1).Value + " " + DataGridView6.SelectedCells.Item(2).Value)

                    Exit For

                    'For Other names
                ElseIf SrcON.ToString.ToUpper.StartsWith(srch.ToUpper) Then

                    DataGridView6.Rows(i).Cells(3).Selected = True
                    irowindex = CStr(DataGridView6.SelectedCells.Item(0).Value)

                    Exit For

                End If
            End If
        Next
    End Sub



    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label69_Click(sender As Object, e As EventArgs) Handles Label69.Click

    End Sub

    
End Class


