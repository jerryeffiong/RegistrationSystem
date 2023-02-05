Public Class Business

    Private Sub SplitContainer1_Panel1_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub

    Private Sub Business_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RegistrationDBDataSet.Electrical' table. You can move, or remove it, as needed.
        Me.ElectricalTableAdapter.Fill(Me.RegistrationDBDataSet.Electrical)
        SelectionPanel.Close()

        Dim MechanicalTotal As Integer = MechanicalDataGridView.RowCount
        Label3.Text = MechanicalTotal
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        SelectionPanel.Show()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Hide()
        SelectionPanel.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            ElectricalBindingSource.AddNew()
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Me.Validate()
            Me.ElectricalBindingSource.EndEdit()
            Me.ElectricalTableAdapter.Update(Me.RegistrationDBDataSet)

            Dim MechanicalTotal As Integer = MechanicalDataGridView.RowCount
            Label3.Text = MechanicalTotal
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            ElectricalBindingSource.RemoveCurrent()
            Me.ElectricalBindingSource.EndEdit()
            Me.ElectricalTableAdapter.Update(Me.RegistrationDBDataSet)

            Dim MechanicalTotal As Integer = MechanicalDataGridView.RowCount
            Label3.Text = MechanicalTotal
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim srch As String = srchtxt0.Text
            Dim irowindex As String
            Dim strl As Integer
            MechanicalDataGridView.ClearSelection()
            For i As Integer = 0 To MechanicalDataGridView.RowCount - 1
                Dim SrcLN As String = ""
                If Not IsDBNull(MechanicalDataGridView.Rows(i).Cells(1).Value) Then
                    SrcLN = MechanicalDataGridView.Rows(i).Cells(1).Value
                End If

                Dim SrcIND As String = ""
                If Not IsDBNull(MechanicalDataGridView.Rows(i).Cells(0).Value) Then
                    SrcIND = MechanicalDataGridView.Rows(i).Cells(0).Value
                End If

                Dim SrcON As String = ""
                If Not IsDBNull(MechanicalDataGridView.Rows(i).Cells(2).Value) Then
                    SrcON = MechanicalDataGridView.Rows(i).Cells(2).Value
                End If


                If SrcIND IsNot Nothing Then

                    'For LastName
                    If SrcLN.ToString.ToUpper.StartsWith(srch.ToUpper) Then

                        MechanicalDataGridView.Rows(i).Cells(1).Selected = True
                        irowindex = CStr(MechanicalDataGridView.SelectedCells.Item(0).Value)
                        MessageBox.Show(irowindex, "Index Number")
                        Exit For

                        'For Index Number

                    ElseIf SrcIND.ToString.StartsWith(srch) Then
                        MechanicalDataGridView.Rows(i).Cells(0).Selected = True
                        irowindex = MechanicalDataGridView.SelectedCells.Item(0).Value
                        MessageBox.Show(SrcON + " " + SrcLN, "Name")
                        Exit For

                        'For Other names
                    ElseIf SrcON.ToString.ToUpper.StartsWith(srch.ToUpper) Then
                        MechanicalDataGridView.Rows(i).Cells(2).Selected = True
                        irowindex = CStr(MechanicalDataGridView.SelectedCells.Item(0).Value)
                        MessageBox.Show(irowindex, "Index Number")
                        Exit For

                    End If

                ElseIf srchtxt0.Text = "" Or srchtxt0.Text = "Enter a Name or an Index number" Then
                    MsgBox("Enter a Name", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Invalid entry")
                    srchtxt0.Focus()
                    Exit For
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Sub srchtxt0_TextChanged(sender As Object, e As EventArgs) Handles srchtxt0.TextChanged
        Try
            Dim d As Integer = 0
            Dim srch As String = srchtxt0.Text
            Dim irowindex As String
            Dim strl As Integer
            MechanicalDataGridView.ClearSelection()
            For i = 0 To MechanicalDataGridView.RowCount - 1
                Dim SrcLN As String = ""
                If Not IsDBNull(MechanicalDataGridView.Rows(i).Cells(1).Value) Then
                    SrcLN = MechanicalDataGridView.Rows(i).Cells(1).Value
                End If

                Dim SrcIND As String = ""
                If Not IsDBNull(MechanicalDataGridView.Rows(i).Cells(0).Value) Then
                    SrcIND = MechanicalDataGridView.Rows(i).Cells(0).Value
                End If

                Dim SrcON As String = ""
                If Not IsDBNull(MechanicalDataGridView.Rows(i).Cells(2).Value) Then
                    SrcON = MechanicalDataGridView.Rows(i).Cells(2).Value
                End If



                If SrcIND IsNot Nothing Then
                    If SrcLN.ToString.ToUpper.StartsWith(srch.ToUpper) Then

                        MechanicalDataGridView.Rows(i).Cells(1).Selected = True
                        irowindex = MechanicalDataGridView.SelectedCells.Item(0).Value

                        Exit For

                        'For Index Number
                    ElseIf SrcIND.ToString.StartsWith(srch) Then

                        MechanicalDataGridView.Rows(i).Cells(0).Selected = True
                        irowindex = CStr(MechanicalDataGridView.SelectedCells.Item(1).Value + " " + MechanicalDataGridView.SelectedCells.Item(2).Value)

                        Exit For

                        'For Other names
                    ElseIf SrcON.ToString.ToUpper.StartsWith(srch.ToUpper) Then

                        MechanicalDataGridView.Rows(i).Cells(3).Selected = True
                        irowindex = CStr(MechanicalDataGridView.SelectedCells.Item(0).Value)

                        Exit For

                    End If
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub
    Private Sub srchtxt0_Placeholder(sender As Object, e As EventArgs) Handles srchtxt0.Click, srchtxt0.GotFocus
        srchtxt0.Clear()
    End Sub
    Private Sub srchtxt0_Placeholder2(sender As Object, e As EventArgs) Handles srchtxt0.LostFocus
        If srchtxt0.Text = "" Then
            srchtxt0.Text = "Enter a Name or an Index number"
        End If
    End Sub

    Private Sub srchtxt0_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles srchtxt0.KeyPress
        If e.KeyChar = Chr(13) Then
            Button1_Click(Nothing, Nothing)
            e.Handled = True
        End If
    End Sub

    
End Class