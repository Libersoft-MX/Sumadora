Public Class Sumadora

#Region "Variables Globales"

    '// Variables para calculo de operaciones //////////////////////////////////////////////////////////|
    Private Total As Decimal = 0            'Especifica el total de la las operaciones hasta el ommento |
    Private Punto As Boolean = False        'Especifica si ya se ha precionado la tecla punto           |
    Private Operacion As Char = "0"         'Especifica que operación se ha seleccionado                |
    Private OpeAct As Boolean = False       'Especifica si ya se ha seleccionado una operacion          |
    Private OpeEnd As Boolean = True        'Especifica si ya se realizó el calculo                     |
    '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\|

    '// Variables usados en manipulación de tabla //////////////////////////////////////////////////////|
    Private NumFilas As Integer = 3         'Especifica el número de filas actuales de la tabla         |
    '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\|
#End Region



#Region "Motor KeyPress"
    Private Function ValidadorNumero(ByVal Valor As KeyPressEventArgs) As KeyPressEventArgs

        If Asc(Valor.KeyChar) = 8 Then          'Tecla de retroceso
            If OpeEnd Then
                tbResultado.Text = ""
            End If
            Return Valor
        ElseIf Asc(Valor.KeyChar) = 13 Then     'Tecla Enter
            If Operacion = "0" Then
                Valor.KeyChar = ""
            ElseIf Not tbResultado.Text = "" And Not tbResultado.Text = "." And Not OpeAct Then
                Valor = RealizarCalculo(Valor)
                Nueva_operación()
            Else
                Valor.KeyChar = ""
            End If
        ElseIf (Asc(Valor.KeyChar) < 42 Or Asc(Valor.KeyChar) > 57 Or Asc(Valor.KeyChar) = 44) Then
            Valor.KeyChar = ""
        ElseIf Asc(Valor.KeyChar) = 42 Then     'Operación "x"
            Valor = RealizarCalculo(Valor)
            Operacion = "x"
        ElseIf Asc(Valor.KeyChar) = 43 Then     'Operación "+"
            Valor = RealizarCalculo(Valor)
            Operacion = "+"
        ElseIf Asc(Valor.KeyChar) = 45 Then     'Operación "-"
            Valor = RealizarCalculo(Valor)
            Operacion = "-"
        ElseIf Asc(Valor.KeyChar) = 47 Then     'Operación "/"
            Valor = RealizarCalculo(Valor)
            Operacion = "/"
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
            If Total = 0 And dgvHistorial.Rows.Count > 3 Then
                Tabla_Limpiar()
            End If
            OpeAct = False
        Else
            OpeEnd = False
            OpeAct = False
        End If
        'tbResultado.Text = Format(Val(tbResultado.Text), “##,##0.00”).ToString
        Return Valor
    End Function

    Private Function RealizarCalculo(ByVal Valor As KeyPressEventArgs) As KeyPressEventArgs
        If Not tbResultado.Text = "" And Not tbResultado.Text = "." And Not OpeAct Then         'Antes de operacion que no sea vacio o solo punto
            If Total = 0 Then
                Total = Val(tbResultado.Text)
                Tabla_Agregar(tbResultado.Text)
            Else
                Select Case Operacion
                    Case "+"
                        Total = Total + Val(tbResultado.Text)
                    Case "-"
                        Total = Total - Val(tbResultado.Text)
                    Case "x"
                        Total = Total * Val(tbResultado.Text)
                    Case "/"
                        Total = Total / Val(tbResultado.Text)
                End Select
                Tabla_Agregar(tbResultado.Text)
                tbResultado.Text = Format(Total, “##,##0.00”)
            End If
            OpeAct = True
        End If
        Valor.KeyChar = ""
        Return Valor
    End Function

    Private Sub Nueva_operación()
        OpeEnd = True
        OpeAct = True
        Operacion = "0"
        Total = 0
    End Sub
#End Region
#Region "Motor Button"

#End Region
#Region "Operaciones con la Tabla"
    Private Sub Tabla()
        Static Valor As Integer = 0
        dgvHistorial.Rows.Add()
        dgvHistorial(0, Valor).Value = "456.00"
        dgvHistorial.FirstDisplayedCell = dgvHistorial(0, Valor)
        Valor += 1
    End Sub

    Private Sub Tabla_Agregar(ByVal Valor As Decimal)
        NumFilas += 1
        dgvHistorial.Rows.Add()
        dgvHistorial(0, NumFilas - 1).Value = Format(Total, “##,##0.00”)
        dgvHistorial(0, NumFilas - 2).Value = "--------------------"
        dgvHistorial(0, NumFilas - 3).Value = Format(Valor, “##,##0.00”)
        dgvHistorial.FirstDisplayedCell = dgvHistorial(0, NumFilas - 1)
    End Sub

    Private Sub Tabla_Limpiar()
        dgvHistorial.Rows.Clear()
        NumFilas = 3
        dgvHistorial.Rows.Add(3)
        dgvHistorial(0, 0).Value = "0.00"
        dgvHistorial(0, 1).Value = "--------------------"
        dgvHistorial(0, 2).Value = "0.00"
        dgvHistorial.ClearSelection()
        tbResultado.Focus()

    End Sub
#End Region
#Region "Botones de Operaciones"
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
        'dgvHistorial.Rows(0).Selected = False
        'dgvHistorial.Rows(3).Selected = True
        dgvHistorial.ClearSelection()
        MsgBox(dgvHistorial.RowCount.ToString)
    End Sub

    Private Sub cbMas_Click(sender As Object, e As EventArgs) Handles cbMas.Click

    End Sub
#End Region
#Region "Botones de Números"
    Private Sub cb0_Click(sender As Object, e As EventArgs) Handles cb0.Click
        tbResultado.Text = tbResultado.Text + "0"
    End Sub

    Private Sub cbPunto_Click(sender As Object, e As EventArgs) Handles cbPunto.Click
        tbResultado.Text = tbResultado.Text + "."
    End Sub

    Private Sub cb1_Click(sender As Object, e As EventArgs) Handles cb1.Click
        tbResultado.Text = tbResultado.Text + "1"

    End Sub

    Private Sub cb2_Click(sender As Object, e As EventArgs) Handles cb2.Click
        tbResultado.Text = tbResultado.Text + "2"
    End Sub

    Private Sub cb3_Click(sender As Object, e As EventArgs) Handles cb3.Click
        tbResultado.Text = tbResultado.Text + "3"
    End Sub

    Private Sub cb4_Click(sender As Object, e As EventArgs) Handles cb4.Click
        tbResultado.Text = tbResultado.Text + "4"
    End Sub

    Private Sub cb5_Click(sender As Object, e As EventArgs) Handles cb5.Click
        tbResultado.Text = tbResultado.Text + "5"
    End Sub

    Private Sub cb6_Click(sender As Object, e As EventArgs) Handles cb6.Click
        tbResultado.Text = tbResultado.Text + "6"
    End Sub

    Private Sub cb7_Click(sender As Object, e As EventArgs) Handles cb7.Click
        tbResultado.Text = tbResultado.Text + "7"
    End Sub

    Private Sub cb8_Click(sender As Object, e As EventArgs) Handles cb8.Click
        tbResultado.Text = tbResultado.Text + "8"
    End Sub

    Private Sub cb9_Click(sender As Object, e As EventArgs) Handles cb9.Click
        tbResultado.Text = tbResultado.Text + "9"
    End Sub

#End Region
#Region "Elementos de Formulario Eventos"
    Private Sub tbResultado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbResultado.KeyPress  'Tecla pulsada
        ValidadorNumero(e)
    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        dgvHistorial.Rows.Add(2)
        dgvHistorial(0, 0).Value = "0.00"
        dgvHistorial(0, 1).Value = "--------------------"
        dgvHistorial(0, 2).Value = "0.00"
        dgvHistorial.ClearSelection()
        tbResultado.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Nueva_operación()
        Tabla_Limpiar()
        tbResultado.Text = ""
        tbResultado.Focus()
    End Sub
#End Region

End Class
