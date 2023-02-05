Imports System.Data.OleDb
Imports System.IO





Public Class EditAccount

    Dim PicName As String
    Dim daImage As OleDbDataAdapter
    Dim dsImage As DataSet


    Private Sub AdminsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AdminsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RegistrationDBDataSet)

    End Sub

    Private Sub AdminPicTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim AdminIndex As String = My.Settings.Index
        If AdminIndex = "0000" Then
            TextBox7.Enabled = False
        Else
            TextBox7.Enabled = True
        End If

        Dim Index = My.Settings.Index


        'TODO: This line of code loads data into the 'RegistrationDBDataSet.ExecutiveTable' table. You can move, or remove it, as needed.
        Me.ExecutiveTableTableAdapter.FillByIndex(RegistrationDBDataSet.ExecutiveTable, Index)
        SelectionPanel.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim Exepics As FileDialog = New OpenFileDialog()
            Exepics.Filter = "Image File (*.jpg;*.bmp;*.gif;*.png)|*.jpg;*.bmp;*.gif;*.png"

            If Exepics.ShowDialog() = Windows.Forms.DialogResult.OK Then
                PicName = Exepics.FileName

                Dim newimg As New Bitmap(PicName)

                PicturePictureBox.SizeMode = PictureBoxSizeMode.Zoom
                PicturePictureBox.Image = DirectCast(newimg, Image)
            End If

            PicName = Nothing

        Catch ae As System.ArgumentException
            PicName = " "
            MessageBox.Show(ae.Message.ToString())
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If TextBox7.Text = "Index Number" Then
                MsgBox("Enter all required fields", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
                TextBox7.Focus()
                Exit Sub
            End If
            If TextBox7.Text.Trim = "" Then
                MsgBox("Enter an index number", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
                TextBox7.Focus()
                Exit Sub
            End If
            If Not IsNumeric(TextBox7.Text) Then
                MsgBox("The index number should include digits only", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
                TextBox7.Focus()
                Exit Sub
            End If
            If TextBox7.Text.Contains(".") Or TextBox7.Text.Contains("-") Then
                MsgBox("The index number should include digits only", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
                TextBox7.Focus()
                Exit Sub
            End If


            If TextBox4.Text.Trim = "" Then
                MsgBox("Enter your First name", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
                TextBox4.Focus()
                Exit Sub
            End If

            If TextBox5.Text.Trim = "" Then
                MsgBox("Enter your Last name", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
                TextBox5.Focus()
                Exit Sub
            End If

            If TextBox3.Text.Trim = "" Then
                MsgBox("Enter your Executive Position", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
                TextBox3.Focus()
                Exit Sub
            End If

            If TextBox2.Text.Trim = "" Then
                MsgBox("Enter your a password", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
                TextBox2.Focus()
                Exit Sub
            End If

            If TextBox6.Text <> TextBox2.Text Then
                MsgBox("The password does not match its confirmation", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
                TextBox2.Clear()
                TextBox6.Clear()
                TextBox2.Focus()
                Exit Sub
            End If

            ExecutiveTableBindingSource.EndEdit()
            ExecutiveTableTableAdapter.Update(RegistrationDBDataSet.ExecutiveTable)

            Me.Hide()
            MsgBox("Please re-enter login details", MsgBoxStyle.OkOnly Or MsgBoxStyle.OkOnly, "Update successful")
            Login.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub
End Class