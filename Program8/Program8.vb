Public Class Program8
    Structure Employee

        Dim firstName As String
        Dim lastName As String
        Dim id As Double

    End Structure

    Dim Employees(43) As Employee
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        'insert file into the array.
        Dim line As String
        Dim data(3) As String
        Dim employeeArray() As String = IO.File.ReadAllLines("Employees.txt")

        'split
        For i As Integer = 0 To 43
            line = employeeArray(i)
            data = line.Split(","c)
            Employees(i).lastName = data(0)
            Employees(i).firstName = data(1)
            Employees(i).id = CDbl(data(2))

        Next


        'user enters id 
        Dim userInput As Double = CDbl(txtID.Text)

        'output
        Dim query = From workers In Employees
                    Order By workers.id
                    Select workers


        'The User will enter an employee ID number. if the employee exists, show First And Last Name
        'If Not, show a message displaying program Not found.

        Dim b As Boolean = False
        For i As Integer = 0 To 43
            If userInput = Employees(i).id Then
                grpName.Visible = True
                b = True
                'output
                lstFirstName.Items.Add(Employees(i).firstName)
                lstLastName.Items.Add(Employees(i).lastName)

                Exit For
            End If
        Next
        If b = False Then
            MessageBox.Show("not found")
            txtID.Clear()
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close Program
        Me.Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        '
        grpName.Visible = False
        grpId.Visible = True
        lstFirstName.Items.Clear()
        lstLastName.Items.Clear()
        txtID.Clear()


    End Sub
End Class
