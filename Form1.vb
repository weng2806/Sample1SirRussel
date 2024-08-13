Imports System.Data.SqlClient

Public Class Form1
    Private Sub btnChecking(sender As Object, e As EventArgs) Handles btnCheckingaa.Click

        Dim enteredRFID As String = user.Text.Trim()
        Dim connectionString As String = "Server=PAMARAN\SQLEXPRESS;Database=weng;Integrated Security=True;"
        Dim query As String = "SELECT RFID, Name, Section FROM hello WHERE RFID = @RFID"
        Dim updateQuery As String = "INSERT INTO Attendance (RFID, AttendanceDate, Status) VALUES (@RFID, @Date, 'Present')"

        Try
            Using conn As New SqlConnection(connectionString)
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@RFID", enteredRFID)
                    conn.Open()

                    Dim reader As SqlDataReader = cmd.ExecuteReader()

                    If reader.HasRows Then
                        reader.Read()

                        ' FOR CHECKING
                        checker.Text = reader("RFID").ToString() ' rfdi to
                        named.Text = reader("Name").ToString() ' ito name
                        section.Text = reader("Section").ToString() ' ito section
                        reader.Close()

                        MessageBox.Show("Present ka, yey ^^ ")

                    Else
                        MessageBox.Show("not on the list!")
                    End If

                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub user_TextChanged(sender As Object, e As EventArgs) Handles user.TextChanged

    End Sub
End Class
