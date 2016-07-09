Public Class Sumadora

#Region "Variables Globales"

    Public Total As Decimal = 0
    Public Antes As Decimal = 0
    Public Operación As String = ""

#End Region
    
#Region "Motor"

    Private Sub Analizador(ByVal Valor As String)

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

    End Sub

    Private Sub cbPor_Click(sender As Object, e As EventArgs) Handles cbPor.Click

    End Sub

    Private Sub cbMenos_Click(sender As Object, e As EventArgs) Handles cbMenos.Click

    End Sub

    Private Sub cbIgual_Click(sender As Object, e As EventArgs) Handles cbIgual.Click

    End Sub

    Private Sub cbMas_Click(sender As Object, e As EventArgs) Handles cbMas.Click

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
