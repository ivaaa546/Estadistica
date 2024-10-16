Imports System.Runtime.InteropServices.JavaScript.JSType
Imports System.Windows.Forms.Design.AxImporter
Imports Datos

Public Class frmMeddidas2
    Private tipoDistribucion As String = String.Empty
    Private Sub btnRregresar_Click(sender As Object, e As EventArgs) Handles btnRregresar.Click
        Dim menuPrincipal As New Form1()
        menuPrincipal.Show()

        ' Cerrar el formulario actual
        Me.Close()
    End Sub

    Private Sub frmMeddidas2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        btnSimple.Visible = True
        btnInvervalos.Visible = True
        btnCancelar.Visible = True
    End Sub

    Private Sub btnSimple_Click(sender As Object, e As EventArgs) Handles btnSimple.Click
        ' Verificar si el TextBox está vacío
        If txtClase.Text.Trim() = "" Then
            MessageBox.Show("Por favor, ingresar Clase(X).", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return ' Salir del método si el TextBox está vacío
        End If

        If txtFrecuencia.Text.Trim() = "" Then
            MessageBox.Show("Por favor, ingresar Frecuencia(F).", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return ' Salir del método si el TextBox está vacío
        End If
        Dim datosX As String = txtClase.Text.Trim()
        Dim datosF As String = txtFrecuencia.Text.Trim()

        ' Validar que no se ingresen datos en forma de intervalos en "X"
        If datosX.Contains("-") Then
            MessageBox.Show("Por favor, ingrese los datos de una distribución de frecuencia simple, no en forma de intervalos en X.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Separar los datos y las frecuencias
        Dim valores() As String = datosX.Split(" "c)
        Dim frecuencias() As String = datosF.Split(" "c)

        If valores.Length <> frecuencias.Length Then
            MessageBox.Show("El número de intervalos no coincide con el número de frecuencias.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return

        End If



        tipoDistribucion = "SerieSimple"
        MessageBox.Show("Has seleccionado Distribuciones de Serie Simple")
        dtTabla.Visible = True
        btnInvervalos.Enabled = False
        btnCentral.Visible = True
        btnNuevo.Visible = True
        Panel1.Visible = True
        lbGrafica.Visible = True
        btnGrafica1.Visible = True


        btnCentral.Visible = True
        btnComentarioCentral.Visible = True
        txtMedia.Visible = True
        txtMediana.Visible = True
        txtModa.Visible = True

        txtComentario1.Visible = True
        txtComentario2.Visible = True
        txtComentario3.Visible = True

        Label1.Visible = True
        Label2.Visible = True
        Label3.Visible = True


        btnPosicion.Visible = True
        btnDispersion.Visible = True
        Label4.Visible = True
        Label5.Visible = True
        Label6.Visible = True
        Label9.Visible = True
        Label10.Visible = True
        Label11.Visible = True
        Label7.Visible = True
        Label8.Visible = True

        txtDecil.Visible = True
        txtCuartil.Visible = True
        txtPercentil.Visible = True
        txtDesviacionEstantar.Visible = True
        txtDesviacionMedia.Visible = True
        txtCuartilCalcular.Visible = True
        txtPersintilCalcular.Visible = True
        txtDecilCalcular.Visible = True

        btnComentarioDispersion.Visible = True
        btnComentarioPosicion.Visible = True



        Try
            ' Obtener los datos ingresados en los TextBox
            Dim clasesX As String = txtClase.Text
            Dim frecuenciasF As String = txtFrecuencia.Text

            ' Llamar al método de la capa lógica para agregar los datos
            Dim distribucion As List(Of TendenciaCentral) = TendenciaCentral.AgregarDatosSeriesSimples(clasesX, frecuenciasF)

            ' Llenar el DataGridView
            dtTabla.DataSource = distribucion

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'dtTabla.Columns("ClaseX").Visible = False
        dtTabla.Columns("X_").Visible = False
        'dtTabla.Columns("FA").Visible = False
        dtTabla.Columns("FX").Visible = False
        dtTabla.Columns("Intervalo").Visible = False
    End Sub

    Private Sub btnInvervalos_Click(sender As Object, e As EventArgs) Handles btnInvervalos.Click
        ' Verificar si el TextBox está vacío
        If txtClase.Text.Trim() = "" Then
            MessageBox.Show("Por favor, ingresar Clase(X).", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return ' Salir del método si el TextBox está vacío
        End If

        ' Verificar si el TextBox está vacío
        If txtFrecuencia.Text.Trim() = "" Then
            MessageBox.Show("Por favor, ingresar Frecuencia(F).", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return ' Salir del método si el TextBox está vacío
        End If
        Dim datosX As String = txtClase.Text.Trim()
        Dim datosF As String = txtFrecuencia.Text.Trim()
        ' Validar que se ingresen datos en forma de intervalos en "X"
        If Not datosX.Contains("-") Then
            MessageBox.Show("Por favor, ingrese los datos de una distribución de datos agrupados por intervalos en X.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        ' Separar los intervalos y las frecuencias
        Dim intervalos() As String = datosX.Split(","c)
        Dim frecuencias() As String = datosF.Split(","c)

        ' Validar que la cantidad de intervalos coincida con la cantidad de frecuencias
        If intervalos.Length <> frecuencias.Length Then
            MessageBox.Show("El número de intervalos no coincide con el número de frecuencias. Asegúrese de ingresar una frecuencia para cada intervalo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        tipoDistribucion = "DatosAgrupados"
        MessageBox.Show("Has seleccionado Distribuciones de Datos Agrupados")
        btnSimple.Enabled = False
        btnCentral.Visible = True
        dtTabla.Visible = True
        btnNuevo.Visible = True
        Panel1.Visible = True
        lbGrafica.Visible = True
        btnGrafica2.Visible = True

        btnCentral.Visible = True
        btnComentarioCentral.Visible = True
        txtMedia.Visible = True
        txtMediana.Visible = True
        txtModa.Visible = True

        txtComentario1.Visible = True
        txtComentario2.Visible = True
        txtComentario3.Visible = True

        Label1.Visible = True
        Label2.Visible = True
        Label3.Visible = True



        '''
        btnPosicion.Visible = True
        btnDispersion.Visible = True
        Label4.Visible = True
        Label5.Visible = True
        Label6.Visible = True
        Label9.Visible = True
        Label10.Visible = True
        Label11.Visible = True
        Label7.Visible = True
        Label8.Visible = True

        txtDecil.Visible = True
        txtCuartil.Visible = True
        txtPercentil.Visible = True
        txtDesviacionEstantar.Visible = True
        txtDesviacionMedia.Visible = True
        txtCuartilCalcular.Visible = True
        txtPersintilCalcular.Visible = True
        txtDecilCalcular.Visible = True

        btnComentarioDispersion.Visible = True
        btnComentarioPosicion.Visible = True

        Try
            ' Obtener los datos ingresados en los TextBox
            Dim limites As String = txtClase.Text
            Dim frecuenciasF As String = txtFrecuencia.Text

            ' Llamar al método de la capa lógica para agregar los datos
            Dim distribucion As List(Of TendenciaCentral) = TendenciaCentral.AgregarDatosAgrupadosPorIntervalos(limites, frecuenciasF)

            ' Llenar el DataGridView
            dtTabla.DataSource = distribucion

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        dtTabla.Columns(0).Visible = False
        dtTabla.Columns("Intervalo").Visible = False
        'dtTabla.Columns("FA").Visible = False
        dtTabla.Columns("FX").Visible = False

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        btnSimple.Enabled = True
        btnInvervalos.Enabled = True
        dtTabla.Visible = False
        btnNuevo.Visible = False
        btnCentral.Visible = False
        Panel1.Visible = False
        lbGrafica.Visible = False
        btnGrafica2.Visible = False
        btnGrafica1.Visible = False


        btnCentral.Visible = False
        btnComentarioCentral.Visible = False
        txtMedia.Visible = False
        txtMediana.Visible = False
        txtModa.Visible = False

        txtComentario1.Visible = False
        txtComentario2.Visible = False
        txtComentario3.Visible = False

        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False


        btnPosicion.Visible = False
        btnDispersion.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label9.Visible = False
        Label10.Visible = False
        Label11.Visible = False
        Label7.Visible = False
        Label8.Visible = False

        txtDecil.Visible = False
        txtCuartil.Visible = False
        txtPercentil.Visible = False
        txtDesviacionEstantar.Visible = False
        txtDesviacionMedia.Visible = False
        txtCuartilCalcular.Visible = False
        txtPersintilCalcular.Visible = False
        txtDecilCalcular.Visible = False

        btnComentarioDispersion.Visible = False
        btnComentarioPosicion.Visible = False

        Limpiar()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Limpiar()
    End Sub

    Private Sub btnCentral_Click(sender As Object, e As EventArgs) Handles btnCentral.Click

        Try

            ' Verificar qué tipo de distribución se ha seleccionado
            If String.IsNullOrEmpty(tipoDistribucion) Then
                MessageBox.Show("Por favor, selecciona un tipo de distribución antes de calcular las medidas de tendencia central", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            ' Verificar si el TextBox está vacío
            If txtCantidadDatos.Text.Trim() = "" Then
                MessageBox.Show("Por favor, ingrese el numero de la cantidad de datos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return ' Salir del método si el TextBox está vacío
            End If

            ' Crear una instancia de la clase TendenciaCentral
            Dim tc As New TendenciaCentral()

            Dim resultado As Double

            ' Calcular la mediana o la media dependiendo del tipo de distribución seleccionada
            If tipoDistribucion = "SerieSimple" Then

                ' Inicializar listas para almacenar los intervalos y frecuencias
                Dim intervalos As New List(Of String)
                Dim claseX As New List(Of Integer)
                Dim frecuencias As New List(Of Integer)

                ' Recorre todas las filas del DataGridView para obtener los datos
                For Each row As DataGridViewRow In dtTabla.Rows
                    ' Asegurarse de que la fila no esté vacía
                    If Not row.IsNewRow Then
                        ' Obtener el intervalo de la primera columna
                        Dim intervalo As Integer = Convert.ToInt32(row.Cells("X").Value)
                        claseX.Add(intervalo)

                        ' Obtener la frecuencia de la segunda columna
                        Dim frecuencia As Integer = Convert.ToInt32(row.Cells("F").Value)
                        frecuencias.Add(frecuencia)
                    End If
                Next


                ' Verificar si se encontraron datos en el DataGridView
                If claseX.Count = 0 Or frecuencias.Count = 0 Then
                    MessageBox.Show("No hay datos suficientes para calcular el cuartil.")
                    Exit Sub
                End If


                Dim intervalosArray As Integer() = claseX.ToArray()
                Dim frecuenciasArray As Integer() = frecuencias.ToArray()
                ' Capturar el cuartil que desea calcular el usuario desde un TextBox
                Dim cantidadDatos As Integer = Integer.Parse(txtCantidadDatos.Text)

                ' Calcular media para series simples
                resultado = tc.MediaParaConsolodidado(cantidadDatos, intervalosArray, frecuenciasArray)

                txtMedia.Text = resultado.ToString("F2") ' Mostrar en TextBox correspondiente
                resultado = tc.MedianaParaconsolidado(intervalosArray, frecuenciasArray, cantidadDatos)
                txtMediana.Text = resultado.ToString("F2") ' Mostrar en TextBox correspondiente

                resultado = tc.MedianaParaconsolidado(intervalosArray, frecuenciasArray, cantidadDatos)
                txtMediana.Text = resultado.ToString("F2") ' Mostrar en TextBox correspondiente

                Dim resultados() As Double = tc.ModaParaconsolidado(intervalosArray, frecuenciasArray)
                If resultados.Length > 0 Then
                    txtModa.Text = String.Join(", ", resultados.Select(Function(d) d.ToString("F2")))
                Else
                    txtModa.Text = "No se encontró moda"
                End If
            ElseIf tipoDistribucion = "DatosAgrupados" Then
                Try
                    ' Inicializar listas para almacenar los intervalos y frecuencias
                    Dim intervalos As New List(Of String)
                    Dim claseX As New List(Of Integer)
                    Dim frecuencias As New List(Of Integer)
                    ' Recorre todas las filas del DataGridView para obtener los datos
                    For Each row As DataGridViewRow In dtTabla.Rows
                        ' Asegurarse de que la fila no esté vacía
                        If Not row.IsNewRow Then
                            ' Obtener el intervalo de la primera columna
                            Dim intervalo As String = row.Cells("X_").Value.ToString()
                            intervalos.Add(intervalo)

                            ' Obtener la frecuencia de la segunda columna
                            Dim frecuencia As Integer = Convert.ToInt32(row.Cells("F").Value)
                            frecuencias.Add(frecuencia)
                        End If
                    Next

                    ' Verificar si se encontraron datos en el DataGridView
                    If intervalos.Count = 0 Or frecuencias.Count = 0 Then
                        MessageBox.Show("No hay datos suficientes para calcular la media.")
                        Exit Sub
                    End If

                    ' Convertir las listas en arreglos para pasarlos a la función
                    Dim intervalosArray As String() = intervalos.ToArray()
                    Dim frecuenciasArray As Integer() = frecuencias.ToArray()

                    ' Obtener la cantidad de datos (sumatoria de las frecuencias)
                    Dim cantidadDatos2 As Integer = frecuencias.Sum()

                    'txtMediana.Text = resultado.ToString("F2")


                    resultado = tc.CalcularMediaAritmeticaI(intervalosArray, frecuenciasArray, cantidadDatos2)
                    txtMedia.Text = resultado.ToString("F2") ' Mostrar en TextBox correspondiente

                    resultado = tc.CalcularMedianaI(intervalosArray, frecuenciasArray, cantidadDatos2)
                    txtMediana.Text = resultado.ToString("F2")

                    resultado = tc.CalcularModaI(intervalosArray, frecuenciasArray)
                    txtModa.Text = resultado.ToString("F2")

                Catch ex As Exception
                    MessageBox.Show("Ocurrió un error al calcular la media: " & ex.Message)
                End Try ' 


            End If
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Limpiar()
        txtMedia.Text = ""
        txtMediana.Text = ""
        txtModa.Text = ""
        txtDecil.Text = ""
        txtCuartil.Text = ""
        txtPercentil.Text = ""
        txtDesviacionEstantar.Text = ""
        txtDesviacionMedia.Text = ""
        txtCuartilCalcular.Text = ""
        txtPersintilCalcular.Text = ""
        txtDecilCalcular.Text = ""
        txtCuartilCalcular.Text = ""
        txtDecilCalcular.Text = ""
        txtPersintilCalcular.Text = ""
        txtComentario1.Text = ""
        txtComentario2.Text = ""
        txtComentario3.Text = ""
        'txtClase.Text = ""
        'txtFrecuencia.Text = ""
        'txtCantidadDatos.Text = ""
        btnSiguiente.Visible = False
        dtTabla.Columns.Clear()
        PictureBox1.Image = Nothing
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnPosicion_Click(sender As Object, e As EventArgs) Handles btnPosicion.Click
        Try
            ' Verificar qué tipo de distribución se ha seleccionado
            If String.IsNullOrEmpty(tipoDistribucion) Then
                MessageBox.Show("Por favor, selecciona un tipo de distribución antes de calcular las medidas de tendencia central", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Verificar si el TextBox está vacío
            If txtCuartilCalcular.Text.Trim() = "" Then
                MessageBox.Show("Por favor, ingrese el cuartil a calcular.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return ' Salir del método si el TextBox está vacío
            End If

            ' Verificar si el TextBox está vacío
            If txtDecilCalcular.Text.Trim() = "" Then
                MessageBox.Show("Por favor, ingrese el decil a calcular.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return ' Salir del método si el TextBox está vacío
            End If

            ' Verificar si el TextBox está vacío
            If txtPersintilCalcular.Text.Trim() = "" Then
                MessageBox.Show("Por favor, ingrese el persentil a calcular.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return ' Salir del método si el TextBox está vacío
            End If



            ' Crear una instancia de la clase TendenciaCentral
            Dim tc As New TendenciaCentral()
            Dim resultado As Double

            ' Calcular la medidas de posición del tipo de distribución seleccionada
            If tipoDistribucion = "SerieSimple" Then

                Dim datosCantidad As Integer = Integer.Parse(txtCantidadDatos.Text)

                ' Capturar el decil a calcular (1-9) desde un TextBox o ComboBox
                Dim cuartil As Integer = Integer.Parse(txtCuartilCalcular.Text)
                ' Verificar que el cuartil sea válido (entre 1 y 3)
                If cuartil < 1 Or cuartil > 3 Then
                    MessageBox.Show("Por favor ingresa un cuartil válido (1, 2 o 3).")
                    Exit Sub
                End If

                ' Capturar el decil a calcular (1-9) desde un TextBox o ComboBox
                Dim decil As Integer = Integer.Parse(txtDecilCalcular.Text)
                ' Verificar que el decil sea válido (entre 1 y 9)
                If decil < 1 Or decil > 9 Then
                    MessageBox.Show("Por favor ingresa un decil válido (1 a 9).")
                    Exit Sub
                End If

                ' Capturar el percentil a calcular (1-99) desde un TextBox o ComboBox
                Dim percentil As Integer = Integer.Parse(txtPersintilCalcular.Text)
                ' Verificar que el percentil sea válido (entre 1 y 99)
                If percentil < 1 Or percentil > 99 Then
                    MessageBox.Show("Por favor ingresa un percentil válido (1 a 99).")
                    Exit Sub
                End If


                resultado = tc.CalculoCuartil(datosCantidad, cuartil)
                txtCuartil.Text = resultado.ToString("F2") ' Mostrar en TextBox correspondiente

                resultado = tc.CalcularDecil(datosCantidad, decil)
                txtDecil.Text = resultado.ToString("F2")

                resultado = tc.CalcularPercentil(datosCantidad, percentil)
                txtPercentil.Text = resultado.ToString("F2")


            ElseIf tipoDistribucion = "DatosAgrupados" Then
                Try
                    ' Inicializar listas para almacenar los intervalos y frecuencias
                    Dim intervalos As New List(Of String)
                    Dim frecuencias As New List(Of Integer)

                    ' Recorre todas las filas del DataGridView para obtener los datos
                    For Each row As DataGridViewRow In dtTabla.Rows
                        ' Asegurarse de que la fila no esté vacía
                        If Not row.IsNewRow Then
                            ' Obtener el intervalo de la primera columna
                            Dim intervalo As String = row.Cells("X_").Value.ToString()
                            intervalos.Add(intervalo)

                            ' Obtener la frecuencia de la segunda columna
                            Dim frecuencia As Integer = Convert.ToInt32(row.Cells("F").Value)
                            frecuencias.Add(frecuencia)
                        End If
                    Next

                    ' Verificar si se encontraron datos en el DataGridView
                    If intervalos.Count = 0 Or frecuencias.Count = 0 Then
                        MessageBox.Show("No hay datos suficientes para calcular el cuartil.")
                        Exit Sub
                    End If

                    ' Capturar el cuartil que desea calcular el usuario desde un TextBox
                    Dim cuartil As Integer = Integer.Parse(txtCuartilCalcular.Text)
                    ' Verificar que el cuartil sea válido (entre 1 y 3)
                    If cuartil < 1 Or cuartil > 3 Then
                        MessageBox.Show("Por favor ingresa un cuartil válido (1, 2 o 3).")
                        Exit Sub
                    End If

                    ' Capturar el decil que desea calcular el usuario desde un TextBox
                    Dim decil As Integer = Integer.Parse(txtDecilCalcular.Text)
                    ' Verificar que el decil sea válido (entre 1 y 9)
                    If decil < 1 Or decil > 9 Then
                        MessageBox.Show("Por favor ingresa un decil válido (1 a 9).")
                        Exit Sub
                    End If

                    ' Capturar el percentil que desea calcular el usuario desde un TextBox
                    Dim percentil As Integer = Integer.Parse(txtPersintilCalcular.Text)

                    ' Verificar que el percentil sea válido (entre 1 y 99)
                    If percentil < 1 Or percentil > 99 Then
                        MessageBox.Show("Por favor ingresa un percentil válido (1 a 99).")
                        Exit Sub
                    End If



                    ' Convertir las listas en arreglos para pasarlos a la función
                    Dim intervalosArray As String() = intervalos.ToArray()
                    Dim frecuenciasArray As Integer() = frecuencias.ToArray()


                    ' Muestra el resultado 

                    resultado = tc.CalcularCuartilI(intervalosArray, frecuenciasArray, cuartil)
                    txtCuartil.Text = resultado.ToString("F2") ' Mostrar en TextBox correspondiente

                    resultado = tc.CalcularDecilI(intervalosArray, frecuenciasArray, decil)
                    txtDecil.Text = resultado.ToString("F2") ' Mostrar en TextBox correspondiente

                    resultado = tc.CalcularPercentilI(intervalosArray, frecuenciasArray, percentil)
                    txtPercentil.Text = resultado.ToString("F2") ' Mostrar en TextBox correspondiente

                Catch ex As Exception
                    MessageBox.Show("Ocurrió un error al calcular la media: " & ex.Message)
                End Try ' 

            End If
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDispersion_Click(sender As Object, e As EventArgs) Handles btnDispersion.Click
        Try
            ' Verificar qué tipo de distribución se ha seleccionado
            If String.IsNullOrEmpty(tipoDistribucion) Then
                MessageBox.Show("Por favor, selecciona un tipo de distribución antes de calcular las medidas de tendencia central", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Verificar si el TextBox está vacío
            If txtMedia.Text.Trim() = "" Then
                MessageBox.Show("Por favor, ingrese el promedio (media artimetica).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return ' Salir del método si el TextBox está vacío
            End If

            ' Crear una instancia de la clase TendenciaCentral
            Dim tc As New TendenciaCentral()

            Dim resultado As Double

            ' Calcular la mediana o la media dependiendo del tipo de distribución seleccionada
            If tipoDistribucion = "SerieSimple" Then

                ' Inicializar listas para almacenar los intervalos y frecuencias
                Dim intervalos As New List(Of Integer)
                Dim frecuencias As New List(Of Integer)

                ' Recorre todas las filas del DataGridView para obtener los datos
                For Each row As DataGridViewRow In dtTabla.Rows
                    ' Asegurarse de que la fila no esté vacía
                    If Not row.IsNewRow Then
                        ' Obtener el intervalo de la primera columna
                        Dim intervalo As String = row.Cells("X").Value.ToString()
                        intervalos.Add(intervalo)

                        ' Obtener la frecuencia de la segunda columna
                        Dim frecuencia As Integer = Convert.ToInt32(row.Cells("F").Value)
                        frecuencias.Add(frecuencia)
                    End If
                Next

                ' Verificar si se encontraron datos en el DataGridView
                If intervalos.Count = 0 Or frecuencias.Count = 0 Then
                    MessageBox.Show("No hay datos suficientes para calcular la desviación media.")
                    Exit Sub
                End If

                ' Capturar la media aritmética previamente calculada desde un TextBox
                Dim media As Double = Double.Parse(txtMedia.Text)
                Dim estandar As Double = Double.Parse(txtMedia.Text)
                ' Convertir las listas en arreglos para pasarlos a la función
                Dim intervalosArray As Integer() = intervalos.ToArray()
                Dim frecuenciasArray As Integer() = frecuencias.ToArray()

                ' Obtener la cantidad de datos (sumatoria de las frecuencias)
                Dim cantidadDatos2 As Integer = frecuencias.Sum()


                ' Muestra el resultado 
                resultado = tc.CalcularDesviacionMedia(intervalosArray, frecuenciasArray, media)
                txtDesviacionMedia.Text = resultado.ToString("F2") ' Mostrar en TextBox correspondiente
                resultado = tc.CalcularDesviacionEstandar(intervalosArray, frecuenciasArray, estandar)
                txtDesviacionEstantar.Text = resultado.ToString("F2") ' Mostrar en TextBox correspondiente




            ElseIf tipoDistribucion = "DatosAgrupados" Then
                Try
                    ' Inicializar listas para almacenar los intervalos y frecuencias
                    Dim intervalos As New List(Of String)
                    Dim frecuencias As New List(Of Integer)

                    ' Recorre todas las filas del DataGridView para obtener los datos
                    For Each row As DataGridViewRow In dtTabla.Rows
                        ' Asegurarse de que la fila no esté vacía
                        If Not row.IsNewRow Then
                            ' Obtener el intervalo de la primera columna
                            Dim intervalo As String = row.Cells("X_").Value.ToString()
                            intervalos.Add(intervalo)

                            ' Obtener la frecuencia de la segunda columna
                            Dim frecuencia As Integer = Convert.ToInt32(row.Cells("F").Value)
                            frecuencias.Add(frecuencia)
                        End If
                    Next

                    ' Verificar si se encontraron datos en el DataGridView
                    If intervalos.Count = 0 Or frecuencias.Count = 0 Then
                        MessageBox.Show("No hay datos suficientes para calcular la desviación media.")
                        Exit Sub
                    End If

                    ' Capturar la media aritmética previamente calculada desde un TextBox
                    Dim media As Double = Double.Parse(txtMedia.Text)
                    Dim estandar As Double = Double.Parse(txtMedia.Text)
                    ' Convertir las listas en arreglos para pasarlos a la función
                    Dim intervalosArray As String() = intervalos.ToArray()
                    Dim frecuenciasArray As Integer() = frecuencias.ToArray()

                    ' Obtener la cantidad de datos (sumatoria de las frecuencias)
                    Dim cantidadDatos2 As Integer = frecuencias.Sum()


                    ' Muestra el resultado 
                    resultado = tc.CalcularDesviacionMediaI(intervalosArray, frecuenciasArray, media)
                    txtDesviacionMedia.Text = resultado.ToString("F2") ' Mostrar en TextBox correspondiente
                    resultado = tc.CalcularDesviacionEstandarI(intervalosArray, frecuenciasArray, estandar)
                    txtDesviacionEstantar.Text = resultado.ToString("F2") ' Mostrar en TextBox correspondiente
                Catch ex As Exception
                    MessageBox.Show("Ocurrió un error al calcular la media: " & ex.Message)
                End Try ' 

            End If
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnComentarioCentral_Click(sender As Object, e As EventArgs) Handles btnComentarioCentral.Click
        ' Verificar si el TextBox está vacío
        If txtMedia.Text.Trim() = "" Then
            MessageBox.Show("Por favor, calcule los resultados para generar comentario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return ' Salir del método si el TextBox está vacío
        End If


        Dim medida As String = txtMedia.Text
        Dim mediana As String = txtMediana.Text
        Dim moda As String = txtModa.Text

        txtComentario1.Text = "El promedio de los datos calculados es de " + medida
        txtComentario2.Text = "La miad de los datos ingreso es menor a " + mediana
        txtComentario3.Text = "El dato más frecuente es de " + moda
    End Sub

    Private Sub btnComentarioPosicion_Click(sender As Object, e As EventArgs) Handles btnComentarioPosicion.Click

        ' Verificar si el TextBox está vacío
        If txtCuartil.Text.Trim() = "" Then
            MessageBox.Show("Por favor, calcule los resultados para generar comentario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return ' Salir del método si el TextBox está vacío
        End If

        If txtDecil.Text.Trim() = "" Then
            MessageBox.Show("Por favor, calcule los resultados para generar comentario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return ' Salir del método si el TextBox está vacío
        End If

        If txtPercentil.Text.Trim() = "" Then
            MessageBox.Show("Por favor, calcule los resultados para generar comentario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return ' Salir del método si el TextBox está vacío
        End If



        Dim cuartil As String = txtCuartil.Text
        Dim cuartilCalcular As Integer

        Dim decil As String = txtDecil.Text
        Dim decilCalcular As String = txtDecilCalcular.Text

        Dim persentil As String = txtPercentil.Text
        Dim persentilCalcular As String = txtPersintilCalcular.Text


        'Comentario Cuartiles
        ' Validación para asegurarse de que el valor en txtCuartilCalcular es un número
        If Integer.TryParse(txtCuartilCalcular.Text, cuartilCalcular) Then
            Select Case cuartilCalcular
                Case 1
                    txtComentario1.Text = "El 25% de los datos es menor o igual a " + cuartil
                Case 2
                    txtComentario1.Text = "El 50% de los datos es menor o igual a " + cuartil
                Case 3
                    txtComentario1.Text = "El 75% de los datos es menor o igual a " + cuartil
                Case Else
                    MessageBox.Show("Opción no válida.")
            End Select
        Else
            MessageBox.Show("Por favor, ingrese un número válido en 'Cuartil Calcular'.")
        End If

        'Comentario deciles
        Dim porcentaje As String = decilCalcular * 10
        txtComentario2.Text = "El " + porcentaje + "% " + "de los datos es menor o igual a " + decil
        'Comentario persentiles

        txtComentario3.Text = "El " + persentilCalcular + "% " + "de los datos es menor o igual a " + persentil

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtClase.Text = ""
        txtFrecuencia.Text = ""
        txtCantidadDatos.Text = ""
    End Sub

    Private Sub btnComentarioDispersion_Click(sender As Object, e As EventArgs) Handles btnComentarioDispersion.Click
        ' Verificar si el TextBox está vacío
        If txtDesviacionMedia.Text.Trim() = "" Then
            MessageBox.Show("Por favor, calcule los resultados para generar comentario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return ' Salir del método si el TextBox está vacío
        End If

        If txtDesviacionEstantar.Text.Trim() = "" Then
            MessageBox.Show("Por favor, calcule los resultados para generar comentario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return ' Salir del método si el TextBox está vacío
        End If


        Dim desviacionMedia As String = txtDesviacionMedia.Text
        Dim desviacionEstandar As String = txtDesviacionEstantar.Text
        txtComentario1.Text = "El promedio de la desviación media es de " + desviacionMedia
        txtComentario2.Text = "El promedio de las desviación estandar es de " + desviacionEstandar
        txtComentario3.Text = ""
    End Sub

    Private Sub btnGrafica1_Click(sender As Object, e As EventArgs) Handles btnGrafica1.Click
        If dtTabla.Rows.Count = 0 Then
            MessageBox.Show("La tabla esta vacía.")
            Return
        End If

        ' Crear un objeto Bitmap para dibujar el gráfico de barras
        Dim bmp As New Bitmap(PictureBox1.Width, PictureBox1.Height)

        ' Crear un objeto Graphics a partir del Bitmap
        Using g As Graphics = Graphics.FromImage(bmp)
            ' Limpiar el gráfico
            g.Clear(Color.White)

            ' Definir las dimensiones del gráfico
            Dim anchoGrafico As Integer = PictureBox1.Width
            Dim altoGrafico As Integer = PictureBox1.Height

            ' Dibujar los ejes X e Y
            g.DrawLine(Pens.Black, 50, 50, 50, altoGrafico - 50) ' Eje Y
            g.DrawLine(Pens.Black, 50, altoGrafico - 50, anchoGrafico - 10, altoGrafico - 50) ' Eje X

            ' Obtener la cantidad de filas del DataGridView (número de datos)
            Dim numDatos As Integer = dtTabla.Rows.Count

            ' Si la última fila es vacía, restar una fila
            If dtTabla.Rows(numDatos - 1).IsNewRow Then
                numDatos -= 1
            End If

            ' Encontrar la frecuencia máxima para ajustar la escala
            Dim frecuenciaMaxima As Integer = 0
            For i As Integer = 0 To numDatos - 1
                Dim frecuencia As Integer = CInt(dtTabla.Rows(i).Cells("F").Value)
                If frecuencia > frecuenciaMaxima Then
                    frecuenciaMaxima = frecuencia
                End If
            Next

            ' Calcular el ancho total del gráfico
            Dim anchoTotal As Integer = anchoGrafico - 60 ' Resto para márgenes
            Dim espacioEntreBarras As Integer = 30

            Dim anchoBarra As Integer = 41 - espacioEntreBarras

            ' Dibujar líneas horizontales de guía
            For j As Integer = 0 To frecuenciaMaxima Step CInt(Math.Ceiling(frecuenciaMaxima / 10))
                Dim yPos As Integer = altoGrafico - 50 - CInt((j / frecuenciaMaxima) * (altoGrafico - 100))
                g.DrawLine(Pens.LightGray, 50, yPos, anchoGrafico - 10, yPos) ' Línea horizontal
                g.DrawString(j.ToString(), Me.Font, Brushes.Black, 10, yPos - 10) ' Etiqueta de frecuencia
            Next

            ' Dibujar las barras del gráfico de barras
            For i As Integer = 0 To numDatos - 1
                ' Obtener el valor y la frecuencia
                Dim valor As String = dtTabla.Rows(i).Cells("X").Value.ToString() ' Valor (X)
                Dim frecuencia As Integer = CInt(dtTabla.Rows(i).Cells("F").Value) ' Frecuencia (F)

                ' Calcular la altura de la barra según la escala
                Dim alturaBarra As Integer = CInt((frecuencia / frecuenciaMaxima) * (altoGrafico - 100)) ' Escala la altura de la barra

                ' Asegúrate de que la altura no sea menor que 0
                If alturaBarra < 0 Then
                    alturaBarra = 0
                End If

                ' Dibujar la barra
                g.FillRectangle(Brushes.Orange, 50 + i * (anchoBarra + 10), altoGrafico - 50 - alturaBarra, anchoBarra, alturaBarra)

                ' Dibujar el valor debajo de cada barra
                g.DrawString(valor, Me.Font, Brushes.Black, 50 + i * (anchoBarra + 10), altoGrafico - 40)

                ' Dibujar la frecuencia sobre cada barra
                'g.DrawString(frecuencia.ToString(), Me.Font, Brushes.Black, 50 + i * (anchoBarra + 10), altoGrafico - 50 - alturaBarra - 20)
            Next
        End Using

        ' Asignar el bitmap al PictureBox
        PictureBox1.Image = bmp
    End Sub

    Private Sub btnGrafica2_Click(sender As Object, e As EventArgs) Handles btnGrafica2.Click
        If dtTabla.Rows.Count = 0 Then
            MessageBox.Show("La tabla esta vacía.")
            Return
        End If


        ' Crear un objeto Bitmap para dibujar el histograma
        Dim bmp As New Bitmap(PictureBox1.Width, PictureBox1.Height)

        ' Crear un objeto Graphics a partir del Bitmap
        Using g As Graphics = Graphics.FromImage(bmp)
            ' Limpiar el gráfico
            g.Clear(Color.White)

            ' Definir las dimensiones del gráfico
            Dim anchoGrafico As Integer = PictureBox1.Width
            Dim altoGrafico As Integer = PictureBox1.Height

            ' Dibujar los ejes X e Y
            g.DrawLine(Pens.Black, 50, 50, 50, altoGrafico - 50) ' Eje Y
            g.DrawLine(Pens.Black, 50, altoGrafico - 50, anchoGrafico - 10, altoGrafico - 50) ' Eje X

            ' Establecer el espacio entre barras (intervalos)
            Dim espacioEntreBarras As Integer = 1

            ' Obtener la cantidad de filas del DataGridView (número de datos)
            Dim numDatos As Integer = dtTabla.Rows.Count

            ' Si la última fila es vacía, restar una fila
            If dtTabla.Rows(numDatos - 1).IsNewRow Then
                numDatos -= 1
            End If

            ' Encontrar la frecuencia máxima para ajustar la escala
            Dim frecuenciaMaxima As Integer = 0
            For i As Integer = 0 To numDatos - 1
                Dim frecuencia As Integer = CInt(dtTabla.Rows(i).Cells("F").Value)
                If frecuencia > frecuenciaMaxima Then
                    frecuenciaMaxima = frecuencia
                End If
            Next

            ' Calcular el ancho total del histograma
            Dim anchoTotal As Integer = anchoGrafico - 60 ' Resto para márgenes
            Dim anchoBarra As Integer = 50

            ' Dividir el espacio en 5 secciones para la escala del eje Y
            Dim numDivisionesY As Integer = 5
            Dim incrementoY As Integer = frecuenciaMaxima / numDivisionesY ' Incremento de frecuencia
            Dim alturaPorDivision As Integer = CInt((altoGrafico - 100) / numDivisionesY) ' Espacio entre divisiones en el gráfico

            ' Dibujar las etiquetas del eje Y (frecuencias)
            For i As Integer = 0 To numDivisionesY
                ' Calcular la posición Y para la etiqueta
                Dim posicionY As Integer = altoGrafico - 50 - i * alturaPorDivision

                ' Calcular la frecuencia correspondiente a esta posición
                Dim frecuenciaLabel As Integer = CInt(i * incrementoY)

                ' Dibujar la frecuencia al lado izquierdo del eje Y
                g.DrawString(frecuenciaLabel.ToString(), Me.Font, Brushes.Black, 10, posicionY - 10)

                ' Opcional: Dibujar líneas horizontales como guías para cada división
                g.DrawLine(Pens.LightGray, 50, posicionY, anchoGrafico - 10, posicionY)
            Next

            ' Dibujar las barras del histograma
            For i As Integer = 0 To numDatos - 1
                ' Obtener el intervalo y la frecuencia
                Dim intervalo As String = dtTabla.Rows(i).Cells("X_").Value.ToString() ' Intervalo (X)
                Dim frecuencia As Integer = CInt(dtTabla.Rows(i).Cells("F").Value) ' Frecuencia (F)

                ' Calcular la altura de la barra según la escala
                Dim alturaBarra As Integer = CInt((frecuencia / frecuenciaMaxima) * (altoGrafico - 100)) ' Escala la altura de la barra

                ' Asegúrate de que la altura no sea menor que 0
                If alturaBarra < 0 Then
                    alturaBarra = 0
                End If

                ' Dibujar la barra
                g.FillRectangle(Brushes.Orange, 50 + i * (anchoBarra + espacioEntreBarras), altoGrafico - 50 - alturaBarra, anchoBarra, alturaBarra)

                ' Dibujar el intervalo debajo de cada barra
                g.DrawString(intervalo, Me.Font, Brushes.Black, 50 + i * (anchoBarra + espacioEntreBarras), altoGrafico - 40)
            Next
        End Using

        ' Asignar el bitmap al PictureBox
        PictureBox1.Image = bmp
    End Sub
End Class