Imports System.Data.OleDb
Imports System.IO




Public Class AdminPortal

    Dim PicName As String
    Dim daImage As OleDbDataAdapter
    Dim dsImage As DataSet

    Private Sub ExecutiveTableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub TestPic_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SelectionPanel.Close()

        'TODO: This line of code loads data into the 'RegistrationDBDataSet.ExecutiveTable' table. You can move, or remove it, as needed.
        Me.ExecutiveTableTableAdapter.Fill(Me.RegistrationDBDataSet.ExecutiveTable)

        If IndexNumberTextBox.Text = "0000" Then
            IndexNumberTextBox.Enabled = False
            Button5.Enabled = False
        Else
            IndexNumberTextBox.Enabled = True
            Button5.Enabled = True
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Validate()
        Me.ExecutiveTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RegistrationDBDataSet)
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            ExecutiveTableBindingSource.AddNew()
            IndexNumberTextBox.Enabled = True
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            ExecutiveTableBindingSource.RemoveCurrent()
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ExecutiveTableBindingSource.MovePrevious()
        If IndexNumberTextBox.Text = "0000" Then
            IndexNumberTextBox.Enabled = False
            Button5.Enabled = False
        Else
            IndexNumberTextBox.Enabled = True
            Button5.Enabled = True
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ExecutiveTableBindingSource.MoveNext()
        If IndexNumberTextBox.Text = "0000" Then
            IndexNumberTextBox.Enabled = False
            Button5.Enabled = False
        Else
            IndexNumberTextBox.Enabled = True
            Button5.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Try
            Dim FBD As New FolderBrowserDialog
            If FBD.ShowDialog = vbOK Then
                File.Copy(Application.StartupPath & "\RegistrationDB.accdb", FBD.SelectedPath & "\Registration.backup")
                MsgBox("Backup successful", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "OK")
            End If
        Catch ex As Exception
            MsgBox("Backup Failed. Check destination folder and try again", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        Try
            Dim FBD As New FolderBrowserDialog

            If FBD.ShowDialog = vbOK Then
                If File.Exists(FBD.SelectedPath & "\Registration.backup") Then
                    File.Delete(Application.StartupPath & "\RegistrationDB.accdb")
                    File.Copy(FBD.SelectedPath & "\Registration.backup", Application.StartupPath & "\RegistrationDB.accdb")
                    MsgBox("Restore successful", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "OK")

                    Application.Restart()

                Else
                    MsgBox("Restore Failed - File not found in selected folder", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
                    Exit Sub
                End If
            End If
        Catch notfound As FileNotFoundException

            MsgBox(("Restore Failed - File not found in selected folder"), MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
            Exit Sub
        Catch ex As Exception
            MsgBox("Restore Failed", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
            Exit Sub
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class