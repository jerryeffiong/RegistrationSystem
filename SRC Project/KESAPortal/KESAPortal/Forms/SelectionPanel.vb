Public Class SelectionPanel

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.Tabpageload = "0"
        My.Settings.Save()
        Me.Hide()
        Main.Show()
    End Sub


    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Application.Exit()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Settings.Tabpageload = "1"
        My.Settings.Save()
        Me.Hide()
        Business.Show()

    End Sub

    Private Sub SelectionPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RegistrationDBDataSet.ExecutiveTable' table. You can move, or remove it, as needed.
        Me.ExecutiveTableTableAdapter.Fill(Me.RegistrationDBDataSet.ExecutiveTable)
        Try

            'TODO: This line of code loads data into the 'RegistrationDBDataSet1.Admins' table. You can move, or remove it, as needed.
            ' Me.AdminsTableAdapter.Fill(Me.RegistrationDBDataSet.Admins)
            Form1.Close()
            Login.Close()
            Report.Close()
            Register.Close()
            Main.Close()
            Business.Close()
            Law.Close()
            Nursing.Close()

            Dim AdminIndex As String = My.Settings.Index
            ' Dim AdminIndex As String = Label8.Text
            If AdminIndex = "0000" Then
                Button9.Enabled = True
            Else
                Button9.Enabled = False
            End If

            'Dim FN As String = DataGridView1.Rows(0).Cells(0).Value
            'Dim LN As String = DataGridView1.Rows(0).Cells(1).Value
            'Label1.Text = (N)

            ' Dim MyByteArray As Byte
            ' MyByteArray = My.Settings.Pic
            ' Dim Stream As System.IO.MemoryStream
            'Dim Picture As Image
            'Stream = New System.IO.MemoryStream(MyByteArray)

            'Picture = Image.FromStream(Stream)

            Label1.Text = My.Settings.Name
            Label2.Text = My.Settings.Position

            'PictureBox2.Image = Picture

            ' Dim name As String = Label6.Text + " " + Label7.Text
            'Label1.Text = Name


            'TODO: This line of code loads data into the 'RegistrationDBDataSet.Executive' table. You can move, or remove it, as needed.

            Dim Time As Integer = TimeOfDay.Hour

            Dim Greet As String
            If (Time >= 12 And Time < 16) Then
                Greet = "Good Afternoon"
            ElseIf Time >= 16 Then
                Greet = "Good Evening"
            Else
                Greet = "Good Morning"
            End If

            Label5.Text = Greet

        Catch ae As System.InvalidOperationException

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        My.Settings.Tabpageload = "2"
        My.Settings.Save()
        My.Settings.Save()
        Me.Hide()
        Law.Show()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Register.Show()
        Me.Hide()

    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        My.Settings.Save()
        Me.Hide()
        EditAccount.Show()
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        My.Settings.Tabpageload = "3"
        My.Settings.Save()
        Me.Hide()
        Nursing.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Register.Show()
        Me.Hide()

    End Sub




    Private Sub Button9_Click(sender As Object, e As EventArgs)
        Me.Hide()
        AdminPortal.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)
        Me.Hide()
        EditAccount.Show()
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        EditAccount.Show()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Login.Show()
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Report.Show()
        Me.Hide()
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button10_Click_1(sender As Object, e As EventArgs) Handles Button10.Click
        Report.Show()
        Me.Hide()
    End Sub

    Private Sub Button9_Click_1(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Hide()
        AdminPortal.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Login.Show()
    End Sub

    Private Sub ExecutiveTableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ExecutiveTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RegistrationDBDataSet)

    End Sub
End Class