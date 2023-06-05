Public Class LOGI

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "usuario" And TextBox2.Text = "jasymj" Then
            INTERFAZ.Show()
        Else
            MsgBox("la contraseña es incorrecta")

        End If
    End Sub
End Class
