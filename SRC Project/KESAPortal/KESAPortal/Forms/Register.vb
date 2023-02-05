Imports System.Data.OleDb
Imports System.IO


Public Class Register

    Dim PicName As String
    Dim daImage As OleDbDataAdapter
    Dim dsImage As DataSet



    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        

        
        SelectionPanel.Close()

        Try
            ExecutiveTableBindingSource.AddNew()
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        End Try

        
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

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



        ' insert the item
        Try
            Me.Validate()
            Me.ExecutiveTableBindingSource.EndEdit()
            Me.ExecutiveTableTableAdapter.Update(Me.RegistrationDBDataSet)

            Me.Hide()
            Login.Show()

        Catch ex As Exception

            ' display error message
            MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.Click
        TextBox4.Text = ""
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.Click
        TextBox7.Text = ""
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.Click
        TextBox5.Text = ""
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.Click
        TextBox3.Text = ""
    End Sub


    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.Click
        TextBox2.Text = ""
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.Click
        TextBox6.Text = ""
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

    Private Sub Button31_Click(sender As Object, e As EventArgs)
        SelectionPanel.Show()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Me.Hide()
        SelectionPanel.Show()
    End Sub
End Class