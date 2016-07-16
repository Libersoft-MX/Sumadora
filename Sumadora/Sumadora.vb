Public Class Sumadora

#Region "Variables Globales"

    Private Total As Decimal = 0
    Private Cantidad As String
    Private Punto As Boolean = False
    Private Operacion As Char = ""

#End Region

#Region "Elementos de Formulario Eventos"
    Private Sub tbResultado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbResultado.KeyPress

        Analizador(ValidadorNumero(e).KeyChar)
    End Sub
#End Region

#Region "Motor"

    Private Sub Analizador(ByVal Valor As String)

    End Sub

    Private Function ValidadorNumero(ByVal Valor As KeyPressEventArgs) As KeyPressEventArgs


        If (Asc(Valor.KeyChar) < 42 Or Asc(Valor.KeyChar) > 57) Then
            Valor.KeyChar = ""
        End If


        Return Valor
    End Function

    Private Sub NewOperation(Optional ByVal Valor As String = "")
        Operacion = Valor
        Punto = False
    End Sub

#End Region

#Region "Carga"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        tbResultado.Focus()
        'tbResultado.Text = "0"
    End Sub

#End Region

#Region "Operaciones"
    Private Sub cbDividir_Click(sender As Object, e As EventArgs) Handles cbDividir.Click
        Static Valor As Integer = 0
        dgvHistorial.Rows.Add()
        dgvHistorial(0, Valor).Value = "456.00"
        dgvHistorial.FirstDisplayedCell = dgvHistorial(0, Valor)

        Valor += 1

        NewOperation("/")
    End Sub

    Private Sub cbPor_Click(sender As Object, e As EventArgs) Handles cbPor.Click
        NewOperation("X")
    End Sub

    Private Sub cbMenos_Click(sender As Object, e As EventArgs) Handles cbMenos.Click
        NewOperation("-")
    End Sub

    Private Sub cbIgual_Click(sender As Object, e As EventArgs) Handles cbIgual.Click
        NewOperation("=")
    End Sub

    Private Sub cbMas_Click(sender As Object, e As EventArgs) Handles cbMas.Click
        NewOperation("+")
    End Sub
#End Region

#Region "Números"
    Private Sub cb0_Click(sender As Object, e As EventArgs) Handles cb0.Click
        Analizador("0")
    End Sub

    Private Sub cbPunto_Click(sender As Object, e As EventArgs) Handles cbPunto.Click
        Analizador(".")
    End Sub

    Private Sub cb1_Click(sender As Object, e As EventArgs) Handles cb1.Click
        Analizador("1")
    End Sub

    Private Sub cb2_Click(sender As Object, e As EventArgs) Handles cb2.Click
        Analizador("2")
    End Sub

    Private Sub cb3_Click(sender As Object, e As EventArgs) Handles cb3.Click
        Analizador("3")
    End Sub

    Private Sub cb4_Click(sender As Object, e As EventArgs) Handles cb4.Click
        Analizador("4")
    End Sub

    Private Sub cb5_Click(sender As Object, e As EventArgs) Handles cb5.Click
        Analizador("5")
    End Sub

    Private Sub cb6_Click(sender As Object, e As EventArgs) Handles cb6.Click
        Analizador("6")
    End Sub

    Private Sub cb7_Click(sender As Object, e As EventArgs) Handles cb7.Click
        Analizador("7")
    End Sub

    Private Sub cb8_Click(sender As Object, e As EventArgs) Handles cb8.Click
        Analizador("8")
    End Sub

    Private Sub cb9_Click(sender As Object, e As EventArgs) Handles cb9.Click
        Analizador("9")
    End Sub

#End Region

End Class
