Public Class Login

    Dim Position As String = My.Settings.Position

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try


            'TODO: This line of code loads data into the 'RegistrationDBDataSet.ExecutiveTable' table. You can move, or remove it, as needed.
            Me.ExecutiveTableTableAdapter.Fill(Me.RegistrationDBDataSet.ExecutiveTable)
            'TODO: This line of code loads data into the 'RegistrationDBDataSet.Executive' table. You can move, or remove it, as needed.

            Register.Close()
            SelectionPanel.Close()
            AdminPortal.Close()
            EditAccount.Close()

        Catch ae As System.InvalidOperationException

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        TextBox1.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles TextBox2.Click, TextBox2.GotFocus
        TextBox2.Text = ""
        TextBox2.PasswordChar = "*"
    End Sub

    Private Sub LineShape2_Click(sender As Object, e As EventArgs) Handles LineShape2.Click

    End Sub

    ' checks if the return key is pressed
    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress, TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Button1_Click_1(Nothing, Nothing)
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Position As String

        AdminsTableAdapter.DeleteQuery(Position)
        AdminsTableAdapter.Fill(RegistrationDBDataSet.Admins)

        ' Try


        ' validate the new password
        If TextBox1.Text = "" Then
            MsgBox("Enter your Index Number", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
            TextBox1.Focus()
            Exit Sub
        End If

        If TextBox1.Text = "Index Number" Then
            MsgBox("Enter your Index Number", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
            TextBox1.Focus()
            Exit Sub
        End If

        If TextBox2.Text = "Password" Then
            MsgBox("You should enter a password", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
            TextBox2.Focus()
            Exit Sub
        End If

        If TextBox2.Text = "" Then
            MsgBox("You should enter a password", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
            TextBox2.Focus()
            Exit Sub
        End If


        Dim user As String = TextBox1.Text


        Dim CMD As New OleDb.OleDbCommand

        Dim TmpDS As New RegistrationDBDataSet



        Dim DBPSW As String
        Dim d As Integer = 0

        Dim con As Integer = 5
        Dim records As Integer = 0
        Dim i As Integer

        Dim FirstName As String
        Dim LastName As String
        ' Dim Position As String
        Dim DBINX As String
        Dim Picture
        Dim IndexNumber As String
        Dim Pic

        ' Dim Trap As Object = PictureBox1.Image





        CMD.Dispose()

        For i = 0 To DataGridView1.RowCount - 1


            DBPSW = DataGridView1.Rows(d).Cells(4).Value
            DBINX = DataGridView1.Rows(d).Cells(0).Value


            If DBPSW = TextBox2.Text Then
                If DBINX = TextBox1.Text Then
                    IndexNumber = DataGridView1.Rows(d).Cells(0).Value
                    FirstName = DataGridView1.Rows(d).Cells(1).Value
                    LastName = DataGridView1.Rows(d).Cells(2).Value
                    Position = DataGridView1.Rows(d).Cells(3).Value
                    Picture = DataGridView1.Rows(d).Cells(5).Value
                    'Trap = DataGridView1.Rows(d).Cells(5).Value

                    con = 10
                    Exit For
                End If
            End If
            d = d + 1

        Next


        If con = 10 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
            ' SelectionPanel.PictureBox2 = (Trap)



            ' If Not Picture Is Nothing Then
            'Picture = My.Resources.KESA
            'End If



            ' create the adapter
            ' Dim TAS As New RegistrationDBDataSetTableAdapters.AdminsTableAdapter



            ' insert the item
            '  TAS.Insert(FirstName, LastName, Position, Picture, IndexNumber)

            ' close window and return ok
            ' Me.DialogResult = Windows.Forms.DialogResult.OK





            Dim CurrentUser As String = (FirstName & " " & LastName)
            My.Settings.Name = CurrentUser
            My.Settings.Position = Position
            My.Settings.Index = IndexNumber
            My.Settings.Save()
            MsgBox("Welcome " & CurrentUser, MsgBoxStyle.OkOnly Or MsgBoxStyle.OkOnly, "Login successful")
            Me.Hide()
            SelectionPanel.Show()


        Else
            MsgBox("Incorrect Index Number or password", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox1.Focus()
        End If


        'Catch none As System.InvalidOperationException

        ' Catch bold As InvalidCastException
        ' MsgBox("System could not gather user details. Contact Portal administrator", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Login Failed")
        ' Catch ex As Exception
        ' handle the error
        'MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        '  Exit Sub
        '  End Try

    End Sub

    
End Class