
Imports System.Data
Imports System.Math


Public Class TendenciaCentral
    Public Property X As Double
    Public Property X_ As String

    'Public Property ClaseX As String
    Public Property F As Integer
    Public Property FA As Integer

    Public Property FX As Integer

    Public Property Intervalo As String



    'metodo para crear distribuciones de serie simple'

    Public Shared Function GenerarDistribucion(datos As List(Of Double)) As List(Of TendenciaCentral)

        Dim distribucion As New List(Of TendenciaCentral)
        Dim frecuenciaAcumulada As Integer = 0

        Dim grupos = datos.GroupBy(Function(x) x).Select(Function(g) New With {
                .Valor = g.Key,
                .Frecuencia = g.Count()
            }).OrderBy(Function(g) g.Valor).ToList()

        For Each grupo In grupos
            frecuenciaAcumulada += grupo.Frecuencia
            ' Calcular FX como F * X
            Dim FX As Double = grupo.Frecuencia * grupo.Valor

            distribucion.Add(New TendenciaCentral With {
                    .X = grupo.Valor,
                    .F = grupo.Frecuencia,
                    .FA = frecuenciaAcumulada,
                    .FX = FX
                })
        Next

        Return distribucion
    End Function


    'Ordenar los datos de forma consolidad para distribuciones de frecuencia simple
    ' Método para agregar las clases X y F
    Public Shared Function AgregarDatosSeriesSimples(clasesX As String, frecuenciasF As String) As List(Of TendenciaCentral)
        Dim distribucion As New List(Of TendenciaCentral)

        ' Separar los valores de las clases X y las frecuencias F
        Dim clases As List(Of String) = clasesX.Split(New Char() {" "c, ","c}, StringSplitOptions.RemoveEmptyEntries).ToList()
        Dim frecuencias As List(Of Integer) = frecuenciasF.Split(New Char() {" "c, ","c}, StringSplitOptions.RemoveEmptyEntries).
                                                        Select(Function(f) Integer.Parse(f)).ToList()

        ' Verificar si ambas listas tienen la misma cantidad de elementos
        If clases.Count <> frecuencias.Count Then
            Throw New Exception("El número de clases X no coincide con el número de frecuencias F.")
        End If

        ' Calcular frecuencia acumulada (FA)
        Dim frecuenciaAcumulada As Integer = 0
        ' Agregar los datos a la lista
        For i As Integer = 0 To clases.Count - 1
            frecuenciaAcumulada += frecuencias(i)
            distribucion.Add(New TendenciaCentral With {
                .X = clases(i),
                .F = frecuencias(i),
                .FA = frecuenciaAcumulada
            })
        Next

        Return distribucion
    End Function
    'Ordenar los datos de forma consolidad para para datos agrupados en intervalo
    Public Shared Function AgregarDatosAgrupadosPorIntervalos(limites As String, frecuenciasF As String) As List(Of TendenciaCentral)
        Dim distribucion As New List(Of TendenciaCentral)

        ' Separar los límites de los intervalos y las frecuencias
        Dim intervalos As List(Of String) = limites.Split(New Char() {" "c, ","c}, StringSplitOptions.RemoveEmptyEntries).ToList()
        Dim frecuencias As List(Of Integer) = frecuenciasF.Split(New Char() {" "c, ","c}, StringSplitOptions.RemoveEmptyEntries).
                                                        Select(Function(f) Integer.Parse(f)).ToList()

        ' Verificar que la cantidad de intervalos y frecuencias coincida
        If intervalos.Count <> frecuencias.Count Then
            Throw New Exception("El número de intervalos no coincide con el número de frecuencias.")

        End If

        ' Calcular frecuencia acumulada (FA)
        Dim frecuenciaAcumulada As Integer = 0
        For i As Integer = 0 To intervalos.Count - 1
            frecuenciaAcumulada += frecuencias(i)
            distribucion.Add(New TendenciaCentral With {
                .X_ = intervalos(i),
                .F = frecuencias(i),
                .FA = frecuenciaAcumulada
            })
        Next

        Return distribucion
    End Function





    'distribuciones de datos agrupados en intervalos'

    Public Shared Function CalcularDistribucionI(datos As List(Of Double), cantidadDatos As Integer) As List(Of TendenciaCentral)
        Dim distribucion As New List(Of TendenciaCentral)()
        If datos.Count = 0 Then Return distribucion
        Dim rango As Double = datos.Max() - datos.Min()
        Dim ni As Integer = Math.Ceiling(CInt(1 + 3.322 * Log10(cantidadDatos)))
        ' Si el entero es par, suma 1 para hacerlo impar
        If ni Mod 2 = 0 Then
            ni += 1
        End If
        Dim intervalo As Double = Math.Ceiling(rango / ni)
        'intervalo -= 1


        ' Agrupar datos en intervalos
        Dim limitesInferiores As New List(Of Double)()
        For i As Integer = 0 To ni
            limitesInferiores.Add(datos.Min() + i  * intervalo)
        Next

        ' Asegurarse de que el último intervalo incluya el valor máximo
        If limitesInferiores.Last() < datos.Max() Then
            limitesInferiores.Add(datos.Max())
        End If

        'Contar frecuencias
        For i As Integer = 0 To limitesInferiores.Count - 2
            Dim limiteInferior As Double = limitesInferiores(i)
            Dim limiteSuperior As Double = limitesInferiores(i + 1)
            Dim frecuencia As Integer = datos.Where(Function(d) d >= limiteInferior AndAlso d < limiteSuperior).Count()
            If i = limitesInferiores.Count - 2 Then
                frecuencia = datos.Where(Function(d) d >= limiteInferior AndAlso d <= limiteSuperior).Count()
            End If
            Dim fa As Integer = If(i = 0, frecuencia, distribucion.Sum(Function(d) d.F) + frecuencia)
            distribucion.Add(New TendenciaCentral With {
        .X_ = $"{limiteInferior} - {limiteSuperior - 1}",
        .F = frecuencia,
        .FA = fa
    })
        Next

        Return distribucion
    End Function


    ' Método para calcular el promedio
    Public Function Promedio(cantidadDatos As Integer, datos() As Double) As Double
        Dim suma As Double = 0.0

        ' Sumar todos los datos
        For Each numero As Double In datos
            suma += numero
        Next

        ' Calcular la media aritmética
        Dim media As Double = suma / cantidadDatos

        Return media
    End Function
    ' Método para calcular la media aritmética
    Public Function MediaAritmetica(cantidadDatos As Integer, datos() As Double) As Double

        Return Promedio(cantidadDatos, datos)
    End Function

    ' Método para calcular la media aritmética
    Public Function MediaParaConsolodidado(cantidadDatos As Integer, clase() As Integer, frecuencia() As Integer) As Double

        Dim suma As Double = 0

        ' Recorrer todas las clases y frecuencias para hacer el producto y sumarlo
        For i As Integer = 0 To clase.Length - 1
            suma += clase(i) * frecuencia(i)
        Next

        ' Calcular la media dividiendo la suma entre la cantidad total de datos
        Return suma / cantidadDatos

    End Function
    Public Function CalcularMediana(cantidadDatos As Integer, datos() As Double) As Double
        ' Ordenar los datos
        Array.Sort(datos)

        Dim mediana As Double

        If cantidadDatos Mod 2 = 0 Then
            ' Si la cantidad de datos es par, calcular la media de los dos valores centrales
            Dim medio1 As Double = datos(cantidadDatos \ 2 - 1) ' Valor inferior
            Dim medio2 As Double = datos(cantidadDatos \ 2)     ' Valor superior
            mediana = (medio1 + medio2) / 2
        Else
            ' Si la cantidad de datos es impar, tomar el valor del medio
            mediana = datos(cantidadDatos \ 2)
        End If

        Return mediana
    End Function

    'Calcular Medianada Datos agrupados
    Public Function MedianaParaconsolidado(clase() As Integer, frecuencias() As Integer, cantidadDatos As Integer) As Double

        Dim frecuenciaAcumulada As Integer = 0
        Dim frecuenciaAcumuladaAnterior As Integer = 0
        Dim L As Double = 0 ' Límite inferior de la clase mediana
        Dim f As Integer = 0 ' Frecuencia de la clase mediana
        Dim i As Double = 0 ' Tamaño del intervalo
        Dim N_2 As Integer = cantidadDatos / 2 ' La mitad de la frecuencia total

        ' Recorre los intervalos y frecuencias
        For index As Integer = 0 To clase.Length - 1
            frecuenciaAcumuladaAnterior = frecuenciaAcumulada
            frecuenciaAcumulada += frecuencias(index)

            Dim limiteInferior As Double = clase(index)

            ' Si la frecuencia acumulada supera o iguala N/2, hemos encontrado la clase mediana
            If frecuenciaAcumulada >= N_2 Then

                ' Establece el límite inferior de la clase mediana
                L = limiteInferior

                ' Establece la frecuencia de la clase mediana
                f = frecuencias(index)

                ' Calcula la mediana utilizando la fórmula
                Return L + ((N_2 - frecuenciaAcumuladaAnterior) / f) * 1
            End If
        Next
        ' Si no se encuentra la clase mediana, devolver 0 (esto no debería ocurrir si los datos son válidos)
        Return 0
    End Function


    Public Function CalcularModa(datos() As Double) As Double()
        Dim frecuencia As New Dictionary(Of Double, Integer)()

        ' Contar la frecuencia de cada número
        For Each numero As Double In datos
            If frecuencia.ContainsKey(numero) Then
                frecuencia(numero) += 1
            Else
                frecuencia(numero) = 1
            End If
        Next

        ' Determinar la frecuencia máxima
        Dim maxFrecuencia As Integer = frecuencia.Values.Max()
        Dim modas As New List(Of Double)()

        ' Recoger los números que tienen la máxima frecuencia
        For Each par In frecuencia
            If par.Value = maxFrecuencia Then
                modas.Add(par.Key)
            End If
        Next

        ' Retornar la moda como un array
        Return modas.ToArray()
    End Function

    Public Function ModaParaconsolidado(clase() As Integer, frecuencias() As Integer) As Double()

        ' Determinar la frecuencia máxima
        Dim maxFrecuencia As Integer = frecuencias.Max()
        Dim modas As New List(Of Double)()

        ' Recoger las clases que tienen la máxima frecuencia
        For index As Integer = 0 To frecuencias.Length - 1
            If frecuencias(index) = maxFrecuencia Then
                modas.Add(clase(index))
            End If
        Next

        ' Retornar la moda como un array (puede haber más de una moda)
        Return modas.ToArray()
    End Function






    ' Método para capturar los datos de una columna de una lista de filas y retornarlos en un string
    Public Function CapturarColumna(datos As List(Of List(Of String)), columnaIndex As Integer) As String
            Dim resultado As String = String.Empty

            ' Recorrer todas las filas de la lista de datos
            For Each fila As List(Of String) In datos
                ' Verificar que la fila tenga suficientes columnas
                If fila.Count > columnaIndex Then
                    ' Concatenar el valor de la columna indicada
                    resultado &= fila(columnaIndex) & Environment.NewLine
                End If
            Next

            ' Retornar el resultado concatenado
            Return resultado
        End Function

    'Medidas de posición para distribuciones de serie simple


    Public Function CalculoCuartil(cantidadDatos As Integer, cuartil As Integer) As Double
        ' Validar el cuartil (debe estar entre 1 y 3)
        If cuartil < 1 Or cuartil > 3 Then
            Throw New ArgumentException("El cuartil debe estar entre 1 y 3")
        End If

        Return cuartil * (cantidadDatos + 1) / 4
    End Function

    Public Function CalcularDecil(cantidadDatos As Integer, decil As Integer) As Double


        ' Validar que el decil esté entre 1 y 9
        If decil < 1 Or decil > 9 Then
            Throw New ArgumentException("El decil debe estar entre 1 y 9")
        End If

        ' Calcular la posición del decil usando la fórmula
        Return decil * (cantidadDatos + 1) / 10
    End Function

    Public Function CalcularPercentil(cantidadDatos As Integer, percentil As Integer) As Double

        If percentil < 1 Or percentil > 99 Then
            Throw New ArgumentException("El percentil debe estar entre 1 y 99")
        End If

        ' Calcular la posición del percentil usando la fórmula
        Return percentil * (cantidadDatos + 1) / 100
    End Function


    ' Método para capturar la Media aritmetica datos por frecuencia de datos agrupador por intevarlos
    Public Function CalcularMediaAritmeticaI(intervalos() As String, frecuencias() As Integer, cantidadDatos As Integer) As Double
        Dim sumaXF As Double = 0 ' Para almacenar la sumatoria de (X * F)
        Dim sumaF As Double = 0 ' Para almacenar la sumatoria de F
        Dim puntoMedio As Double ' Variable para el punto medio de cada intervalo

        ' Recorre todos los intervalos
        For i As Integer = 0 To intervalos.Length - 1
            ' Separa el límite inferior y superior del intervalo
            Dim limites() As String = intervalos(i).Split("-"c)
            Dim limiteInferior As Double = Convert.ToDouble(limites(0))
            Dim limiteSuperior As Double = Convert.ToDouble(limites(1))

            ' Calcula el punto medio del intervalo XS
            puntoMedio = (limiteInferior + limiteSuperior) / 2

            ' Calcula X * F y lo suma FXS
            sumaXF += puntoMedio * frecuencias(i)

            ' Suma las frecuencias
            sumaF += frecuencias(i)

        Next


        ' Calcula la media aritmética
        If sumaF = 0 Then
            Return 0 ' Para evitar la división por cero
        Else
            Return sumaXF / cantidadDatos

        End If
    End Function

    'medidas de variabilidad frecuencia simple

    Public Function CalcularDesviacionMedia(Clase() As Integer, frecuencias() As Integer, media As Double) As Double
        Dim sumaDesviaciones As Double = 0 ' Sumatoria de (X - Media)^2 * F
        Dim sumaF As Integer = 0 ' Sumatoria de frecuencias
        Dim puntoMedio As Double ' Variable para el punto medio de cada intervalo

        ' Recorre todos los intervalos
        For i As Integer = 0 To Clase.Length - 1

            ' Suma |X - Media| * F
            sumaDesviaciones += Math.Abs(Clase(i) - media) * frecuencias(i)

            ' Suma las frecuencias
            sumaF += frecuencias(i)
        Next

        ' Calcula la desviación estándar
        If sumaF = 0 Then
            Return 0 ' Evita la división por cero
        Else
            Return sumaDesviaciones / sumaF
        End If
    End Function


    Public Function CalcularDesviacionEstandar(Clase() As Integer, frecuencias() As Integer, media As Double) As Double
        Dim sumaDesviaciones As Double = 0 ' Sumatoria de (X - Media)^2 * F
        Dim sumaF As Integer = 0 ' Sumatoria de frecuencias
        Dim puntoMedio As Double ' Variable para el punto medio de cada intervalo

        ' Recorre todos los intervalos
        For i As Integer = 0 To Clase.Length - 1


            ' Calcula el punto medio del intervalo
            'puntoMedio = (limiteInferior + limiteSuperior) / 2

            ' Calcula (X - Media)^2 * F y lo suma a la sumatoria
            sumaDesviaciones += Math.Pow(Clase(i) - media, 2) * frecuencias(i)

            ' Suma las frecuencias
            sumaF += frecuencias(i)
        Next

        ' Calcula la desviación estándar
        If sumaF = 0 Then
            Return 0 ' Evita la división por cero
        Else
            Return Math.Sqrt(sumaDesviaciones / sumaF)
        End If
    End Function



    'Calcular Medianada Datos agrupados
    Public Function CalcularMedianaI(intervalos() As String, frecuencias() As Integer, cantidadDatos As Integer) As Double
        Dim N As Integer = cantidadDatos ' Total de frecuencias
        Dim frecuenciaAcumulada As Integer = 0
        Dim frecuenciaAcumuladaAnterior As Integer = 0
        Dim L As Double = 0 ' Límite inferior de la clase mediana
        Dim f As Integer = 0 ' Frecuencia de la clase mediana
        Dim i As Double = 0 ' Tamaño del intervalo
        Dim N_2 As Integer = N / 2 ' La mitad de la frecuencia total

        ' Recorre los intervalos y frecuencias
        For index As Integer = 0 To intervalos.Length - 1
            frecuenciaAcumuladaAnterior = frecuenciaAcumulada
            frecuenciaAcumulada += frecuencias(index)

            ' Si la frecuencia acumulada supera o iguala N/2, hemos encontrado la clase mediana
            If frecuenciaAcumulada >= N_2 Then
                ' Obtener los límites del intervalo de la clase mediana
                Dim limites() As String = intervalos(index).Split("-"c)
                Dim limiteInferior As Double = Convert.ToDouble(limites(0))
                Dim limiteSuperior As Double = Convert.ToDouble(limites(1))

                ' Establece el límite inferior de la clase mediana
                L = limiteInferior

                ' Establece la frecuencia de la clase mediana
                f = frecuencias(index)

                ' Calcula el tamaño del intervalo
                i = limiteSuperior - limiteInferior

                ' Calcula la mediana utilizando la fórmula
                Return L + ((N_2 - frecuenciaAcumuladaAnterior) / f) * i
            End If
        Next

        ' Si no se encuentra la clase mediana, devolver 0 (esto no debería ocurrir si los datos son válidos)
        Return 0
    End Function

    'Moda intervalos
    Public Function CalcularModaI(intervalos() As String, frecuencias() As Integer) As Double
        Dim L As Double = 0 ' Límite inferior de la clase modal
        Dim f_m As Integer = 0 ' Frecuencia de la clase modal
        Dim f_a As Integer = 0 ' Frecuencia de la clase anterior a la clase modal
        Dim f_b As Integer = 0 ' Frecuencia de la clase posterior a la clase modal
        Dim i As Double = 0 ' Tamaño del intervalo

        ' Buscar el índice de la clase con la mayor frecuencia (clase modal)
        Dim indiceModa As Integer = Array.IndexOf(frecuencias, frecuencias.Max())

        ' Obtener los límites de la clase modal
        Dim limites() As String = intervalos(indiceModa).Split("-"c)
        Dim limiteInferior As Double = Convert.ToDouble(limites(0))
        Dim limiteSuperior As Double = Convert.ToDouble(limites(1))

        ' Establece el límite inferior de la clase modal
        L = limiteInferior

        ' Establece la frecuencia de la clase modal
        f_m = frecuencias(indiceModa)

        ' Establece las frecuencias de las clases anterior y posterior, si existen
        If indiceModa > 0 Then
            f_a = frecuencias(indiceModa - 1) ' Frecuencia de la clase anterior
        End If

        If indiceModa < frecuencias.Length - 1 Then
            f_b = frecuencias(indiceModa + 1) ' Frecuencia de la clase posterior
        End If

        ' Calcula el tamaño del intervalo
        i = limiteSuperior - limiteInferior

        ' Calcular la moda utilizando la fórmula
        Return L + ((f_m - f_a) / ((f_m - f_a) + (f_m - f_b))) * i
    End Function

    'Cuartit intervalos
    Public Function CalcularCuartilI(intervalos() As String, frecuencias() As Integer, cuartil As Integer) As Double
        Dim L As Double = 0 ' Límite inferior de la clase cuartílica
        Dim F_a As Integer = 0 ' Frecuencia acumulada antes de la clase cuartílica
        Dim f As Integer = 0 ' Frecuencia de la clase cuartílica
        Dim i As Double = 0 ' Tamaño del intervalo
        Dim N As Integer = frecuencias.Sum() ' Total de frecuencias

        ' Calcular la posición del cuartil
        Dim posicionCuartil As Double = (cuartil / 4) * N

        ' Variable para la frecuencia acumulada
        Dim frecuenciaAcumulada As Integer = 0

        ' Buscar la clase cuartílica
        Dim indiceCuartil As Integer = -1
        For j As Integer = 0 To frecuencias.Length - 1
            frecuenciaAcumulada += frecuencias(j)

            If frecuenciaAcumulada >= posicionCuartil Then
                indiceCuartil = j
                Exit For
            End If
        Next

        ' Si no se encuentra el cuartil
        If indiceCuartil = -1 Then
            Return -1 ' Error: Cuartil fuera de rango
        End If

        ' Obtener los límites de la clase cuartílica
        Dim limites() As String = intervalos(indiceCuartil).Split("-"c)
        Dim limiteInferior As Double = Convert.ToDouble(limites(0))
        Dim limiteSuperior As Double = Convert.ToDouble(limites(1))

        ' Establece el límite inferior de la clase cuartílica
        L = limiteInferior

        ' Establece la frecuencia de la clase cuartílica
        f = frecuencias(indiceCuartil)

        ' Calcular la frecuencia acumulada anterior a la clase cuartílica
        If indiceCuartil > 0 Then
            For k As Integer = 0 To indiceCuartil - 1
                F_a += frecuencias(k)
            Next
        End If

        ' Calcula el tamaño del intervalo
        i = limiteSuperior - limiteInferior

        ' Calcular el cuartil utilizando la fórmula
        Return L + (((posicionCuartil - F_a) / f) * i)
    End Function


    'Decil intervalos
    Public Function CalcularDecilI(intervalos() As String, frecuencias() As Integer, decil As Integer) As Double
        Dim L As Double = 0 ' Límite inferior de la clase del decil
        Dim F_a As Integer = 0 ' Frecuencia acumulada antes de la clase del decil
        Dim f As Integer = 0 ' Frecuencia de la clase del decil
        Dim i As Double = 0 ' Tamaño del intervalo
        Dim N As Integer = frecuencias.Sum() ' Total de frecuencias

        ' Calcular la posición del decil
        Dim posicionDecil As Double = (decil / 10) * N

        ' Variable para la frecuencia acumulada
        Dim frecuenciaAcumulada As Integer = 0

        ' Buscar la clase del decil
        Dim indiceDecil As Integer = -1
        For j As Integer = 0 To frecuencias.Length - 1
            frecuenciaAcumulada += frecuencias(j)

            If frecuenciaAcumulada >= posicionDecil Then
                indiceDecil = j
                Exit For
            End If
        Next

        ' Si no se encuentra el decil
        If indiceDecil = -1 Then
            Return -1 ' Error: Decil fuera de rango
        End If

        ' Obtener los límites de la clase del decil
        Dim limites() As String = intervalos(indiceDecil).Split("-"c)
        Dim limiteInferior As Double = Convert.ToDouble(limites(0))
        Dim limiteSuperior As Double = Convert.ToDouble(limites(1))

        ' Establece el límite inferior de la clase del decil
        L = limiteInferior

        ' Establece la frecuencia de la clase del decil
        f = frecuencias(indiceDecil)

        ' Calcular la frecuencia acumulada anterior a la clase del decil
        If indiceDecil > 0 Then
            For k As Integer = 0 To indiceDecil - 1
                F_a += frecuencias(k)
            Next
        End If

        ' Calcula el tamaño del intervalo
        i = limiteSuperior - limiteInferior

        ' Calcular el decil utilizando la fórmula
        Return L + (((posicionDecil - F_a) / f) * i)
    End Function

    'deciles intervalos
    Public Function CalcularPercentilI(intervalos() As String, frecuencias() As Integer, percentil As Integer) As Double
        Dim L As Double = 0 ' Límite inferior de la clase del percentil
        Dim F_a As Integer = 0 ' Frecuencia acumulada antes de la clase del percentil
        Dim f As Integer = 0 ' Frecuencia de la clase del percentil
        Dim i As Double = 0 ' Tamaño del intervalo
        Dim N As Integer = frecuencias.Sum() ' Total de frecuencias

        ' Calcular la posición del percentil
        Dim posicionPercentil As Double = (percentil / 100) * N

        ' Variable para la frecuencia acumulada
        Dim frecuenciaAcumulada As Integer = 0

        ' Buscar la clase del percentil
        Dim indicePercentil As Integer = -1
        For j As Integer = 0 To frecuencias.Length - 1
            frecuenciaAcumulada += frecuencias(j)

            If frecuenciaAcumulada >= posicionPercentil Then
                indicePercentil = j
                Exit For
            End If
        Next

        ' Si no se encuentra el percentil
        If indicePercentil = -1 Then
            Return -1 ' Error: Percentil fuera de rango
        End If

        ' Obtener los límites de la clase del percentil
        Dim limites() As String = intervalos(indicePercentil).Split("-"c)
        Dim limiteInferior As Double = Convert.ToDouble(limites(0))
        Dim limiteSuperior As Double = Convert.ToDouble(limites(1))

        ' Establece el límite inferior de la clase del percentil
        L = limiteInferior

        ' Establece la frecuencia de la clase del percentil
        f = frecuencias(indicePercentil)

        ' Calcular la frecuencia acumulada anterior a la clase del percentil
        If indicePercentil > 0 Then
            For k As Integer = 0 To indicePercentil - 1
                F_a += frecuencias(k)
            Next
        End If

        ' Calcula el tamaño del intervalo
        i = limiteSuperior - limiteInferior

        ' Calcular el percentil utilizando la fórmula
        Return L + (((posicionPercentil - F_a) / f) * i)
    End Function

    Public Function CalcularDesviacionMediaI(intervalos() As String, frecuencias() As Integer, media As Double) As Double
        Dim sumaDesviaciones As Double = 0 ' Sumatoria de |X - Media| * F
        Dim sumaF As Integer = 0 ' Sumatoria de frecuencias
        Dim puntoMedio As Double ' Variable para el punto medio de cada intervalo

        ' Recorre todos los intervalos
        For i As Integer = 0 To intervalos.Length - 1
            ' Separa el límite inferior y superior del intervalo
            Dim limites() As String = intervalos(i).Split("-"c)
            Dim limiteInferior As Double = Convert.ToDouble(limites(0))
            Dim limiteSuperior As Double = Convert.ToDouble(limites(1))

            ' Calcula el punto medio del intervalo
            puntoMedio = (limiteInferior + limiteSuperior) / 2

            ' Suma |X - Media| * F
            sumaDesviaciones += Math.Abs(puntoMedio - media) * frecuencias(i)

            ' Suma las frecuencias
            sumaF += frecuencias(i)
        Next

        ' Calcula la desviación media
        If sumaF = 0 Then
            Return 0 ' Evita la división por cero
        Else
            Return sumaDesviaciones / sumaF
        End If
    End Function
    Public Function CalcularDesviacionEstandarI(intervalos() As String, frecuencias() As Integer, media As Double) As Double
        Dim sumaCuadrados As Double = 0 ' Sumatoria de (X - Media)^2 * F
        Dim sumaF As Integer = 0 ' Sumatoria de frecuencias
        Dim puntoMedio As Double ' Variable para el punto medio de cada intervalo

        ' Recorre todos los intervalos
        For i As Integer = 0 To intervalos.Length - 1
            ' Separa el límite inferior y superior del intervalo
            Dim limites() As String = intervalos(i).Split("-"c)
            Dim limiteInferior As Double = Convert.ToDouble(limites(0))
            Dim limiteSuperior As Double = Convert.ToDouble(limites(1))

            ' Calcula el punto medio del intervalo
            puntoMedio = (limiteInferior + limiteSuperior) / 2

            ' Calcula (X - Media)^2 * F y lo suma a la sumatoria
            sumaCuadrados += Math.Pow(puntoMedio - media, 2) * frecuencias(i)

            ' Suma las frecuencias
            sumaF += frecuencias(i)
        Next

        ' Calcula la desviación estándar
        If sumaF = 0 Then
            Return 0 ' Evita la división por cero
        Else
            Return Math.Sqrt(sumaCuadrados / sumaF)
        End If
    End Function




End Class

