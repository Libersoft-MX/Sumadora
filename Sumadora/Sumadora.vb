Public Class Sumadora

#Region "Variables Globales"

    Private Total As Decimal = 0            'Especifica el total de la las operaciones hasta el ommento
    'Private Cantidad As String              'Especifica el valor de la primera cantidad ingresada antes de la operación
    'Private CantidadAct As Boolean = False  'Especifica si ya esta almacenada la primera cantidad de la operación
    Private Punto As Boolean = False        'Especifica si ya se ha precionado la tecla punto
    'Private Operacion As Char = ""          'Especifica que operación se ha seleccionado
    Private OpeAct As Boolean = False       'Especifica si ya se ha seleccionado una operacion
    'Private OpeStart As Boolean = False     'Especifica si se inicio arbol de operaciones
    'Private OpeEnd As Boolean = False       'Especifica si ya se realizó el calculo

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

        If Asc(Valor.KeyChar) = 8 Then          'Tecla de retroceso
            Return Valor
        ElseIf Asc(Valor.KeyChar) = 13 Then     'Tecla Enter
            If Not tbResultado.Text = "" And Not tbResultado.Text = "." And Not OpeAct Then         'Antes de operacion que no sea vacio o solo punto
                Total = Total + Val(tbResultado.Text)                                               'Realizar calculo
                tbResultado.Text = Total
                OpeAct = True
                Total = 0
            End If
            Valor.KeyChar = ""
        ElseIf (Asc(Valor.KeyChar) < 42 Or Asc(Valor.KeyChar) > 57 Or Asc(Valor.KeyChar) = 44) Then
            Valor.KeyChar = ""
            '//////////////////////////////////////////////////////////////////////////////////////////////
        ElseIf Asc(Valor.KeyChar) = 42 Then     'Operación "x"
            If Not tbResultado.Text = "" And Not tbResultado.Text = "." And Not OpeAct Then         'Antes de operacion que no sea vacio o solo punto
                If Total = 0 Then
                    Total = Val(tbResultado.Text)
                Else
                    Total = Total * Val(tbResultado.Text)                                               'Realizar calculo
                    tbResultado.Text = Total
                End If
                OpeAct = True
            End If
            Valor.KeyChar = ""
        ElseIf Asc(Valor.KeyChar) = 43 Then     'Operación "+"
            If Not tbResultado.Text = "" And Not tbResultado.Text = "." And Not OpeAct Then         'Antes de operacion que no sea vacio o solo punto
                If Total = 0 Then
                    Total = Val(tbResultado.Text)
                Else
                    Total = Total + Val(tbResultado.Text)                                               'Realizar calculo
                    tbResultado.Text = Total
                End If
                OpeAct = True
            End If
            Valor.KeyChar = ""
        ElseIf Asc(Valor.KeyChar) = 45 Then     'Operación "-"
            If Not tbResultado.Text = "" And Not tbResultado.Text = "." And Not OpeAct Then         'Antes de operacion que no sea vacio o solo punto
                If Total = 0 Then
                    Total = Val(tbResultado.Text)
                Else
                    Total = Total - Val(tbResultado.Text)                                               'Realizar calculo
                    tbResultado.Text = Total
                End If
                OpeAct = True
            End If
            Valor.KeyChar = ""
        ElseIf Asc(Valor.KeyChar) = 47 Then     'Operación "/"
            If Not tbResultado.Text = "" And Not tbResultado.Text = "." And Not OpeAct Then         'Antes de operacion que no sea vacio o solo punto
                If Total = 0 Then
                    Total = Val(tbResultado.Text)
                Else
                    Total = Total / Val(tbResultado.Text)                                               'Realizar calculo
                    tbResultado.Text = Total
                End If
                OpeAct = True
            End If
            Valor.KeyChar = ""
        ElseIf Asc(Valor.KeyChar) = 46 Then     'Punto
            If Not Punto Then
                Punto = True
                If OpeAct Then
                    tbResultado.Text = ""
                    OpeAct = False
                End If
            Else
                Valor.KeyChar = ""
            End If
        ElseIf OpeAct Then
            tbResultado.Text = ""
            OpeAct = False
        End If
        '//////////////////////////////////////////////////////////////////////////////////////////////////
        'MsgBox(Total & " Valor textB: " & Val(tbResultado.Text))
        Return Valor
    End Function

    Private Sub NewOperation()
        Punto = False
        OpeAct = False
        Total = 0
        tbResultado.Text = ""
        tbResultado.Focus()
        'CantidadAct = False

    End Sub

    Private Sub RealizarCalculo()
        MsgBox("Calculo realizado!")
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        NewOperation()
    End Sub
End Class
