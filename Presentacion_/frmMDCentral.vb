Imports Datos
Imports Datos.TendenciaCentral

Public Class frmMDCentral
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnNominal_Click(sender As Object, e As EventArgs) Handles btnNominal.Click
        txtNominal.Visible = True
        btnConsolidado.Enabled = False
        btnSiguiente.Visible = True
        Label18.Visible = True
        Label19.Visible = True
        txtCantidadDatos.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnConsolidado.Click
        txtClase.Visible = True
        btnNominal.Enabled = False
        btnSiguiente2.Visible = False
        btnSerieSimple2.Visible = True
        btnDatosInvertalos2.Visible = True
        btnSerieSimple2.Visible = True
        btnDatosInvertalos2.Visible = True
        txtFrecuencia.Visible = True
        Label16.Visible = True
        Label17.Visible = True
        Label20.Visible = True
        txtCantidadDatos2.Visible = True





    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtNominal.Visible = False
        btnConsolidado.Enabled = True
        txtClase.Visible = False
        btnNominal.Enabled = True
        btnSimple.Visible = False
        btnInvervalos.Visible = False
        btnSiguiente.Visible = False
        btnInvervalos.Enabled = True
        btnSimple.Enabled = True
        btnNuevo.Visible = False
        btnCentral.Visible = False
        btnPosicion.Visible = False
        btnDispersion.Visible = False
        btnSiguiente2.Visible = False
        btnCentral2.Visible = False
        btnDispersion2.Visible = False
        btnPosicion2.Visible = False
        btnComentarioCentral.Visible = False
        btnComentarioDispersion.Visible = False
        btnComentarioPosicion.Visible = False
        txtComentario1.Visible = False
        txtComentario3.Visible = False
        txtComentario2.Visible = False
        btnSerieSimple2.Visible = False
        btnDatosInvertalos2.Visible = False
        btnDatosInvertalos2.Enabled = True
        btnSerieSimple2.Enabled = True
        btnNuevo2.Visible = False

        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label10.Visible = False
        Label11.Visible = False
        Label12.Visible = False
        Label13.Visible = False
        Label14.Visible = False
        Label15.Visible = False
        Label16.Visible = False
        Label17.Visible = False
        txtMedia.Visible = False
        txtMediana.Visible = False
        txtModa.Visible = False
        txtDecil.Visible = False
        txtPercentil.Visible = False
        txtCuartil.Visible = False
        txtDesviacionMedia.Visible = False
        txtDesviacionEstantar.Visible = False
        btnGrafica.Visible = False
        txtCuartilCalcular.Visible = False
        txtDecilCalcular.Visible = False
        txtPersintilCalcular.Visible = False
        txtFrecuencia.Visible = False
        dtTabla.Visible = False

        Label18.Visible = False
        Label19.Visible = False
        txtCantidadDatos.Visible = False

        Label20.Visible = False
        txtCantidadDatos2.Visible = False

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        btnSimple.Visible = True
        btnInvervalos.Visible = True
        btnNuevo.Visible = True
        dtTabla.Visible = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnInvervalos.Click
        btnSimple.Enabled = False
        btnCentral.Visible = True
        btnPosicion.Visible = True
        btnDispersion.Visible = True
        Label1.Visible = True
        Label2.Visible = True
        Label3.Visible = True
        Label4.Visible = True
        Label5.Visible = True
        Label6.Visible = True
        Label7.Visible = True
        Label8.Visible = True
        Label9.Visible = True
        Label10.Visible = True
        Label11.Visible = True
        Label12.Visible = True
        Label13.Visible = True
        Label14.Visible = True
        Label15.Visible = True
        txtMedia.Visible = True
        txtMediana.Visible = True
        txtModa.Visible = True
        txtDecil.Visible = True
        txtPercentil.Visible = True
        txtCuartil.Visible = True
        txtDesviacionMedia.Visible = True
        txtDesviacionEstantar.Visible = True
        txtComentario1.Visible = True
        txtComentario3.Visible = True
        txtComentario2.Visible = True
        btnComentarioCentral.Visible = True
        btnComentarioDispersion.Visible = True
        btnComentarioPosicion.Visible = True
        btnGrafica.Visible = True

        txtCuartilCalcular.Visible = True
        txtDecilCalcular.Visible = True
        txtPersintilCalcular.Visible = True



        ' Extraer los datos del TextBox (separados por espacios o comas)
        Dim datos As List(Of Double) = txtNominal.Text.Split(New Char() {" "c, ","c}, StringSplitOptions.RemoveEmptyEntries).
                                          Select(Function(x) Double.Parse(x)).ToList()
        Dim cantidadDatos As Integer = datos.Count
        ' Generar la distribución agrupada desde la capa lógica
        Dim distribucion As List(Of TendenciaCentral) = TendenciaCentral.CalcularDistribucionI(datos, cantidadDatos)

        ' Llenar el DataGridView
        dtTabla.DataSource = distribucion


        dtTabla.Columns("X").Visible = False
        dtTabla.Columns(4).Visible = False
    End Sub

    Private Sub frmMDCentral_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSimple_Click(sender As Object, e As EventArgs) Handles btnSimple.Click
        btnInvervalos.Enabled = False
        btnCentral.Visible = True
        btnPosicion.Visible = True
        btnDispersion.Visible = True
        Label1.Visible = True
        Label2.Visible = True
        Label3.Visible = True
        Label4.Visible = True
        Label5.Visible = True
        Label6.Visible = True
        Label7.Visible = True
        Label8.Visible = True
        Label12.Visible = True
        Label13.Visible = True
        Label14.Visible = True
        Label15.Visible = True

        Label9.Visible = True
        Label10.Visible = True
        Label11.Visible = True

        txtMedia.Visible = True
        txtMediana.Visible = True
        txtModa.Visible = True
        txtDecil.Visible = True
        txtPercentil.Visible = True
        txtCuartil.Visible = True
        txtDesviacionMedia.Visible = True
        txtDesviacionEstantar.Visible = True
        txtComentario1.Visible = True
        txtComentario3.Visible = True
        txtComentario2.Visible = True
        btnGrafica.Visible = True

        btnComentarioCentral.Visible = True
        btnComentarioDispersion.Visible = True
        btnComentarioPosicion.Visible = True

        txtCuartilCalcular.Visible = True
        txtDecilCalcular.Visible = True
        txtPersintilCalcular.Visible = True


        ' Extraer los datos del TextBox (separados por espacios o comas)
        Dim datos As List(Of Double) = txtNominal.Text.Split(New Char() {" "c, ","c}, StringSplitOptions.RemoveEmptyEntries).
                                          Select(Function(x) Double.Parse(x)).ToList()

        ' Generar la distribución desde la capa lógica
        Dim distribucion As List(Of TendenciaCentral) = TendenciaCentral.GenerarDistribucion(datos)

        ' Llenar el DataGridView
        dtTabla.DataSource = distribucion

        dtTabla.Columns("ClaseX").Visible = False
        dtTabla.Columns(4).Visible = False
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        btnInvervalos.Enabled = True
        btnSimple.Enabled = True
        btnCentral.Visible = False
        btnPosicion.Visible = False
        btnDispersion.Visible = False
        btnComentarioCentral.Visible = False
        btnComentarioDispersion.Visible = False
        btnComentarioPosicion.Visible = False



        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label10.Visible = False
        Label11.Visible = False
        Label12.Visible = False
        Label13.Visible = False
        Label14.Visible = False
        Label15.Visible = False
        txtMedia.Visible = False
        txtMediana.Visible = False
        txtModa.Visible = False
        txtDecil.Visible = False
        txtPercentil.Visible = False
        txtCuartil.Visible = False
        txtDesviacionMedia.Visible = False
        txtDesviacionEstantar.Visible = False
        btnGrafica.Visible = False
        txtCuartilCalcular.Visible = False
        txtDecilCalcular.Visible = False
        txtPersintilCalcular.Visible = False
        txtComentario1.Visible = False
        txtComentario3.Visible = False
        txtComentario2.Visible = False


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnSiguiente2.Click
        btnCentral2.Visible = True
        btnDispersion2.Visible = True
        btnPosicion2.Visible = True
        dtTabla.Visible = True

        Label1.Visible = True
        Label2.Visible = True
        Label3.Visible = True
        Label4.Visible = True
        Label5.Visible = True
        Label6.Visible = True
        Label7.Visible = True
        Label8.Visible = True

        Label9.Visible = True
        Label10.Visible = True
        Label11.Visible = True
        Label12.Visible = True
        Label13.Visible = True
        Label14.Visible = True
        Label15.Visible = True

        txtMedia.Visible = True
        txtMediana.Visible = True
        txtModa.Visible = True
        txtDecil.Visible = True
        txtPercentil.Visible = True
        txtCuartil.Visible = True
        txtDesviacionMedia.Visible = True
        txtDesviacionEstantar.Visible = True
        txtComentario1.Visible = True
        txtComentario3.Visible = True
        txtComentario2.Visible = True
        btnGrafica.Visible = True
        btnComentarioCentral.Visible = True
        btnComentarioDispersion.Visible = True
        btnComentarioPosicion.Visible = True

        txtCuartilCalcular.Visible = True
        txtDecilCalcular.Visible = True
        txtPersintilCalcular.Visible = True
    End Sub

    Private Sub btnCentral2_Click(sender As Object, e As EventArgs) Handles btnCentral2.Click

    End Sub

    Private Sub btnCentral_Click(sender As Object, e As EventArgs) Handles btnCentral.Click

        Dim datosString As String = txtNominal.Text
        Dim datos() As String = datosString.Split(" "c) ' Separar los datos en un array
        Dim cantidadDatos As Integer = datos.Length
        Dim datosNumericos(cantidadDatos - 1) As Double ' Crear un array para los datos en formato Double

        ' Convertir los datos a Double
        For i As Integer = 0 To cantidadDatos - 1
            datosNumericos(i) = Convert.ToDouble(datos(i).Trim())
        Next

        ' Crear una instancia de la clase TendenciaCentral
        Dim tc As New TendenciaCentral()
        'Dim media As Double = tc.CalcularMediaArmonica(cantidadDatos)
        'txtMedia.Text = media.ToString("F2") ' 
        ' Calcular la media y mostrar el resultado en txtMedia
        ' Dim mediana As Double = tc.CalcularMediana(cantidadDatos)
        ' txtMediana.Text = mediana.ToString("F2")

        Dim modas() As Double = tc.CalcularModa(datosNumericos)

        ' Mostrar la moda en txtModa
        If modas.Length > 0 Then
            txtModa.Text = String.Join(", ", modas.Select(Function(m) m.ToString("F2")))
        Else
            txtModa.Text = "No hay moda"
        End If


    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles btnDatosInvertalos2.Click
        btnSiguiente2.Visible = False
        btnSerieSimple2.Enabled = False
        btnNuevo2.Visible = True

        btnCentral2.Visible = True
        btnDispersion2.Visible = True
        btnPosicion2.Visible = True
        dtTabla.Visible = True

        Label1.Visible = True
        Label2.Visible = True
        Label3.Visible = True
        Label4.Visible = True
        Label5.Visible = True
        Label6.Visible = True
        Label7.Visible = True
        Label8.Visible = True

        Label9.Visible = True
        Label10.Visible = True
        Label11.Visible = True
        Label12.Visible = True
        Label13.Visible = True
        Label14.Visible = True
        Label15.Visible = True

        txtMedia.Visible = True
        txtMediana.Visible = True
        txtModa.Visible = True
        txtDecil.Visible = True
        txtPercentil.Visible = True
        txtCuartil.Visible = True
        txtDesviacionMedia.Visible = True
        txtDesviacionEstantar.Visible = True
        txtComentario1.Visible = True
        txtComentario3.Visible = True
        txtComentario2.Visible = True
        btnGrafica.Visible = True
        btnComentarioCentral.Visible = True
        btnComentarioDispersion.Visible = True
        btnComentarioPosicion.Visible = True

        txtCuartilCalcular.Visible = True
        txtDecilCalcular.Visible = True
        txtPersintilCalcular.Visible = True
    End Sub

    Private Sub btnSerieSimple2_Click(sender As Object, e As EventArgs) Handles btnSerieSimple2.Click
        btnSiguiente2.Visible = False
        btnDatosInvertalos2.Enabled = False
        btnNuevo2.Visible = True



        btnCentral2.Visible = True
        btnDispersion2.Visible = True
        btnPosicion2.Visible = True
        dtTabla.Visible = True

        Label1.Visible = True
        Label2.Visible = True
        Label3.Visible = True
        Label4.Visible = True
        Label5.Visible = True
        Label6.Visible = True
        Label7.Visible = True
        Label8.Visible = True

        Label9.Visible = True
        Label10.Visible = True
        Label11.Visible = True
        Label12.Visible = True
        Label13.Visible = True
        Label14.Visible = True
        Label15.Visible = True

        txtMedia.Visible = True
        txtMediana.Visible = True
        txtModa.Visible = True
        txtDecil.Visible = True
        txtPercentil.Visible = True
        txtCuartil.Visible = True
        txtDesviacionMedia.Visible = True
        txtDesviacionEstantar.Visible = True
        txtComentario1.Visible = True
        txtComentario3.Visible = True
        txtComentario2.Visible = True
        btnGrafica.Visible = True
        btnComentarioCentral.Visible = True
        btnComentarioDispersion.Visible = True
        btnComentarioPosicion.Visible = True

        txtCuartilCalcular.Visible = True
        txtDecilCalcular.Visible = True
        txtPersintilCalcular.Visible = True

    End Sub

    Private Sub Button1_Click_3(sender As Object, e As EventArgs) Handles btnNuevo2.Click
        btnSerieSimple2.Enabled = True
        btnDatosInvertalos2.Enabled = True



        btnComentarioCentral.Visible = False
        btnComentarioDispersion.Visible = False
        btnComentarioPosicion.Visible = False

        btnCentral2.Visible = False
        btnPosicion2.Visible = False
        btnDispersion2.Visible = False


        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label10.Visible = False
        Label11.Visible = False
        Label12.Visible = False
        Label13.Visible = False
        Label14.Visible = False
        Label15.Visible = False
        txtMedia.Visible = False
        txtMediana.Visible = False
        txtModa.Visible = False
        txtDecil.Visible = False
        txtPercentil.Visible = False
        txtCuartil.Visible = False
        txtDesviacionMedia.Visible = False
        txtDesviacionEstantar.Visible = False
        btnGrafica.Visible = False
        txtCuartilCalcular.Visible = False
        txtDecilCalcular.Visible = False
        txtPersintilCalcular.Visible = False
        txtComentario1.Visible = False
        txtComentario3.Visible = False
        txtComentario2.Visible = False
    End Sub

    Private Sub Button1_Click_4(sender As Object, e As EventArgs) Handles Button1.Click
        Dim datos As New List(Of Double)
        Dim Lri As Double = 0 ' Límite inferior del intervalo de la mediana
        Dim N As Integer ' Total de datos
        Dim Faa As Double = 0 ' Frecuencia acumulada anterior
        Dim fm As Double = 0 ' Frecuencia del intervalo de la mediana
        Dim c As Double = 0 ' Amplitud del intervalo

        ' Leer los datos ingresados por el usuario desde el TextBox
        Dim datosIngresados As String = txtNominal.Text

        ' Separar los datos, pueden estar separados por comas o espacios
        Dim datosArray() As String = datosIngresados.Split({",", " "}, StringSplitOptions.RemoveEmptyEntries)

        ' Convertir los datos a tipo Double y agregarlos a la lista
        For Each dato In datosArray
            Dim datoConvertido As Double
            If Double.TryParse(dato, datoConvertido) Then
                datos.Add(datoConvertido)
            Else
                MessageBox.Show("El dato '" & dato & "' no es válido.")
                Return
            End If
        Next

        ' Ordenar los datos para encontrar la mediana
        datos.Sort()

        ' Calcular N
        N = datos.Count

        ' Calcular Lri, Faa, fm y c
        ' Aquí debes definir el intervalo y las frecuencias según tus datos
        ' Ejemplo simple: asumiendo que son datos agrupados por intervalos de 10
        Dim intervalo As Integer = 10
        Dim frecuencia As New Dictionary(Of Integer, Integer) ' Usaremos un diccionario para las frecuencias

        For Each dato In datos
            Dim rango As Integer = Math.Floor(dato / intervalo) * intervalo
            If Not frecuencia.ContainsKey(rango) Then
                frecuencia(rango) = 0
            End If
            frecuencia(rango) += 1
        Next

        Dim acumulado As Integer = 0
        Dim limiteInferior As Integer = 0

        ' Calcular Faa y fm
        For Each key In frecuencia.Keys
            If frecuencia(key) > 0 Then
                fm = frecuencia(key)
                If acumulado + fm >= N / 2 Then
                    limiteInferior = key
                    Faa = acumulado
                    Exit For
                End If
                acumulado += fm
            End If
        Next

        ' Calcular la amplitud del intervalo
        c = intervalo

        ' Calcular la mediana usando la fórmula
        Dim mediana As Double = limiteInferior + ((N / 2 - Faa) / fm) * c

        ' Mostrar el resultado
        Label21.Text = "La mediana es: " & mediana.ToString("F2")
    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub btnPosicion_Click(sender As Object, e As EventArgs) Handles btnPosicion.Click

    End Sub
End Class