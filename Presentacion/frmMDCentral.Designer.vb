<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMDCentral
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
            End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btnNominal = New Button()
        btnConsolidado = New Button()
        txtNominal = New TextBox()
        txtClase = New TextBox()
        btnCancelar = New Button()
        btnSiguiente = New Button()
        btnSimple = New Button()
        btnInvervalos = New Button()
        btnSiguiente2 = New Button()
        btnNuevo = New Button()
        dtTabla = New DataGridView()
        btnPosicion = New Button()
        btnDispersion = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        btnDispersion2 = New Button()
        btnPosicion2 = New Button()
        btnCentral2 = New Button()
        txtPercentil = New TextBox()
        btnGrafica = New Button()
        txtMedia = New TextBox()
        txtMediana = New TextBox()
        txtModa = New TextBox()
        txtDecil = New TextBox()
        txtCuartil = New TextBox()
        txtDesviacionMedia = New TextBox()
        txtDesviacionEstantar = New TextBox()
        btnCentral = New Button()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        txtCuartilCalcular = New TextBox()
        txtDecilCalcular = New TextBox()
        txtPersintilCalcular = New TextBox()
        txtComentario1 = New TextBox()
        txtComentario2 = New TextBox()
        txtComentario3 = New TextBox()
        Label12 = New Label()
        btnComentarioCentral = New Button()
        btnComentarioPosicion = New Button()
        btnComentarioDispersion = New Button()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        btnSerieSimple2 = New Button()
        btnDatosInvertalos2 = New Button()
        txtFrecuencia = New TextBox()
        Label16 = New Label()
        Label17 = New Label()
        btnNuevo2 = New Button()
        Button1 = New Button()
        Label18 = New Label()
        Label19 = New Label()
        txtCantidadDatos = New TextBox()
        Label20 = New Label()
        txtCantidadDatos2 = New TextBox()
        Label21 = New Label()
        CType(dtTabla, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnNominal
        ' 
        btnNominal.Anchor = AnchorStyles.Top
        btnNominal.FlatAppearance.BorderSize = 0
        btnNominal.FlatStyle = FlatStyle.Flat
        btnNominal.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnNominal.ForeColor = Color.Black
        btnNominal.ImageAlign = ContentAlignment.MiddleLeft
        btnNominal.Location = New Point(304, 17)
        btnNominal.Name = "btnNominal"
        btnNominal.Size = New Size(250, 50)
        btnNominal.TabIndex = 3
        btnNominal.Text = "Ingreso Datos Forma" & vbCrLf & " Nominal"
        btnNominal.UseVisualStyleBackColor = True
        ' 
        ' btnConsolidado
        ' 
        btnConsolidado.Anchor = AnchorStyles.Top
        btnConsolidado.FlatAppearance.BorderSize = 0
        btnConsolidado.FlatStyle = FlatStyle.Flat
        btnConsolidado.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnConsolidado.ForeColor = Color.Black
        btnConsolidado.ImageAlign = ContentAlignment.MiddleLeft
        btnConsolidado.Location = New Point(776, 6)
        btnConsolidado.Name = "btnConsolidado"
        btnConsolidado.Size = New Size(250, 50)
        btnConsolidado.TabIndex = 4
        btnConsolidado.Text = "Ingreso Datos Forma Consolidada"
        btnConsolidado.UseVisualStyleBackColor = True
        ' 
        ' txtNominal
        ' 
        txtNominal.Anchor = AnchorStyles.Top
        txtNominal.Location = New Point(252, 94)
        txtNominal.Multiline = True
        txtNominal.Name = "txtNominal"
        txtNominal.ScrollBars = ScrollBars.Vertical
        txtNominal.Size = New Size(325, 69)
        txtNominal.TabIndex = 5
        txtNominal.Visible = False
        ' 
        ' txtClase
        ' 
        txtClase.Anchor = AnchorStyles.Top
        txtClase.Location = New Point(736, 79)
        txtClase.Multiline = True
        txtClase.Name = "txtClase"
        txtClase.ScrollBars = ScrollBars.Vertical
        txtClase.Size = New Size(325, 64)
        txtClase.TabIndex = 6
        txtClase.Visible = False
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Anchor = AnchorStyles.Top
        btnCancelar.FlatAppearance.BorderSize = 0
        btnCancelar.FlatStyle = FlatStyle.Flat
        btnCancelar.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCancelar.ForeColor = Color.Black
        btnCancelar.ImageAlign = ContentAlignment.MiddleLeft
        btnCancelar.Location = New Point(627, 17)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(83, 40)
        btnCancelar.TabIndex = 7
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' btnSiguiente
        ' 
        btnSiguiente.AccessibleRole = AccessibleRole.None
        btnSiguiente.Anchor = AnchorStyles.Top
        btnSiguiente.FlatAppearance.BorderSize = 0
        btnSiguiente.FlatStyle = FlatStyle.Flat
        btnSiguiente.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSiguiente.ForeColor = Color.Black
        btnSiguiente.ImageAlign = ContentAlignment.MiddleLeft
        btnSiguiente.Location = New Point(373, 202)
        btnSiguiente.Name = "btnSiguiente"
        btnSiguiente.Size = New Size(88, 27)
        btnSiguiente.TabIndex = 8
        btnSiguiente.Text = "Siguiente"
        btnSiguiente.UseVisualStyleBackColor = True
        btnSiguiente.Visible = False
        ' 
        ' btnSimple
        ' 
        btnSimple.Anchor = AnchorStyles.Top
        btnSimple.FlatAppearance.BorderSize = 0
        btnSimple.FlatStyle = FlatStyle.Flat
        btnSimple.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSimple.ForeColor = Color.Black
        btnSimple.ImageAlign = ContentAlignment.MiddleLeft
        btnSimple.Location = New Point(233, 235)
        btnSimple.Name = "btnSimple"
        btnSimple.Size = New Size(158, 44)
        btnSimple.TabIndex = 9
        btnSimple.Text = "Distribucion Serie Simple"
        btnSimple.UseVisualStyleBackColor = True
        btnSimple.Visible = False
        ' 
        ' btnInvervalos
        ' 
        btnInvervalos.Anchor = AnchorStyles.Top
        btnInvervalos.FlatAppearance.BorderSize = 0
        btnInvervalos.FlatStyle = FlatStyle.Flat
        btnInvervalos.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnInvervalos.ForeColor = Color.Black
        btnInvervalos.ImageAlign = ContentAlignment.MiddleLeft
        btnInvervalos.Location = New Point(373, 235)
        btnInvervalos.Name = "btnInvervalos"
        btnInvervalos.Size = New Size(158, 44)
        btnInvervalos.TabIndex = 10
        btnInvervalos.Text = "Datos Agrupados Intervalos"
        btnInvervalos.UseVisualStyleBackColor = True
        btnInvervalos.Visible = False
        ' 
        ' btnSiguiente2
        ' 
        btnSiguiente2.AccessibleRole = AccessibleRole.None
        btnSiguiente2.Anchor = AnchorStyles.Top
        btnSiguiente2.FlatAppearance.BorderSize = 0
        btnSiguiente2.FlatStyle = FlatStyle.Flat
        btnSiguiente2.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSiguiente2.ForeColor = Color.Black
        btnSiguiente2.ImageAlign = ContentAlignment.MiddleLeft
        btnSiguiente2.Location = New Point(897, 265)
        btnSiguiente2.Name = "btnSiguiente2"
        btnSiguiente2.Size = New Size(88, 27)
        btnSiguiente2.TabIndex = 11
        btnSiguiente2.Text = "Siguiente"
        btnSiguiente2.UseVisualStyleBackColor = True
        btnSiguiente2.Visible = False
        ' 
        ' btnNuevo
        ' 
        btnNuevo.AccessibleRole = AccessibleRole.None
        btnNuevo.Anchor = AnchorStyles.Top
        btnNuevo.FlatAppearance.BorderSize = 0
        btnNuevo.FlatStyle = FlatStyle.Flat
        btnNuevo.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnNuevo.ForeColor = Color.Black
        btnNuevo.ImageAlign = ContentAlignment.MiddleLeft
        btnNuevo.Location = New Point(537, 243)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(74, 29)
        btnNuevo.TabIndex = 12
        btnNuevo.Text = "Nuevo "
        btnNuevo.UseVisualStyleBackColor = True
        btnNuevo.Visible = False
        ' 
        ' dtTabla
        ' 
        dtTabla.Anchor = AnchorStyles.Top
        dtTabla.BackgroundColor = Color.White
        dtTabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtTabla.Location = New Point(402, 353)
        dtTabla.Name = "dtTabla"
        dtTabla.Size = New Size(370, 202)
        dtTabla.TabIndex = 13
        dtTabla.Visible = False
        ' 
        ' btnPosicion
        ' 
        btnPosicion.AccessibleRole = AccessibleRole.None
        btnPosicion.Anchor = AnchorStyles.Top
        btnPosicion.FlatAppearance.BorderSize = 0
        btnPosicion.FlatStyle = FlatStyle.Flat
        btnPosicion.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnPosicion.ForeColor = Color.Black
        btnPosicion.ImageAlign = ContentAlignment.MiddleLeft
        btnPosicion.Location = New Point(325, 298)
        btnPosicion.Name = "btnPosicion"
        btnPosicion.Size = New Size(168, 49)
        btnPosicion.TabIndex = 15
        btnPosicion.Text = "Medidas de Posición"
        btnPosicion.UseVisualStyleBackColor = True
        btnPosicion.Visible = False
        ' 
        ' btnDispersion
        ' 
        btnDispersion.AccessibleRole = AccessibleRole.None
        btnDispersion.Anchor = AnchorStyles.Top
        btnDispersion.FlatAppearance.BorderSize = 0
        btnDispersion.FlatStyle = FlatStyle.Flat
        btnDispersion.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnDispersion.ForeColor = Color.Black
        btnDispersion.ImageAlign = ContentAlignment.MiddleLeft
        btnDispersion.Location = New Point(499, 298)
        btnDispersion.Name = "btnDispersion"
        btnDispersion.Size = New Size(185, 49)
        btnDispersion.TabIndex = 16
        btnDispersion.Text = "Medidas de Dispersión"
        btnDispersion.UseVisualStyleBackColor = True
        btnDispersion.Visible = False
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(215, 627)
        Label1.Name = "Label1"
        Label1.Size = New Size(50, 17)
        Label1.TabIndex = 25
        Label1.Text = "Media:"
        Label1.Visible = False
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(215, 676)
        Label2.Name = "Label2"
        Label2.Size = New Size(66, 17)
        Label2.TabIndex = 26
        Label2.Text = "Mediana:"
        Label2.Visible = False
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(218, 726)
        Label3.Name = "Label3"
        Label3.Size = New Size(47, 17)
        Label3.TabIndex = 27
        Label3.Text = "Moda:"
        Label3.Visible = False
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(422, 628)
        Label4.Name = "Label4"
        Label4.Size = New Size(54, 17)
        Label4.TabIndex = 28
        Label4.Text = "Cuartil:"
        Label4.Visible = False
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(431, 671)
        Label5.Name = "Label5"
        Label5.Size = New Size(45, 17)
        Label5.TabIndex = 29
        Label5.Text = "Decil:"
        Label5.Visible = False
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top
        Label6.AutoSize = True
        Label6.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(399, 720)
        Label6.Name = "Label6"
        Label6.Size = New Size(77, 17)
        Label6.TabIndex = 30
        Label6.Text = "Percenctil:"
        Label6.Visible = False
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top
        Label7.AutoSize = True
        Label7.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(850, 613)
        Label7.Name = "Label7"
        Label7.Size = New Size(126, 17)
        Label7.TabIndex = 31
        Label7.Text = "Desviación Media:"
        Label7.Visible = False
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top
        Label8.AutoSize = True
        Label8.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(838, 665)
        Label8.Name = "Label8"
        Label8.Size = New Size(147, 17)
        Label8.TabIndex = 32
        Label8.Text = "Desviación Estandar:"
        Label8.Visible = False
        ' 
        ' btnDispersion2
        ' 
        btnDispersion2.AccessibleRole = AccessibleRole.None
        btnDispersion2.Anchor = AnchorStyles.Top
        btnDispersion2.FlatAppearance.BorderSize = 0
        btnDispersion2.FlatStyle = FlatStyle.Flat
        btnDispersion2.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnDispersion2.ForeColor = Color.Black
        btnDispersion2.ImageAlign = ContentAlignment.MiddleLeft
        btnDispersion2.Location = New Point(1056, 298)
        btnDispersion2.Name = "btnDispersion2"
        btnDispersion2.Size = New Size(194, 49)
        btnDispersion2.TabIndex = 35
        btnDispersion2.Text = "Medidas de Dispersión"
        btnDispersion2.UseVisualStyleBackColor = True
        btnDispersion2.Visible = False
        ' 
        ' btnPosicion2
        ' 
        btnPosicion2.AccessibleRole = AccessibleRole.None
        btnPosicion2.Anchor = AnchorStyles.Top
        btnPosicion2.FlatAppearance.BorderSize = 0
        btnPosicion2.FlatStyle = FlatStyle.Flat
        btnPosicion2.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnPosicion2.ForeColor = Color.Black
        btnPosicion2.ImageAlign = ContentAlignment.MiddleLeft
        btnPosicion2.Location = New Point(873, 298)
        btnPosicion2.Name = "btnPosicion2"
        btnPosicion2.Size = New Size(177, 49)
        btnPosicion2.TabIndex = 34
        btnPosicion2.Text = "Medidas de Posición"
        btnPosicion2.UseVisualStyleBackColor = True
        btnPosicion2.Visible = False
        ' 
        ' btnCentral2
        ' 
        btnCentral2.AccessibleRole = AccessibleRole.None
        btnCentral2.Anchor = AnchorStyles.Top
        btnCentral2.FlatAppearance.BorderSize = 0
        btnCentral2.FlatStyle = FlatStyle.Flat
        btnCentral2.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCentral2.ForeColor = Color.Black
        btnCentral2.ImageAlign = ContentAlignment.MiddleLeft
        btnCentral2.Location = New Point(699, 298)
        btnCentral2.Name = "btnCentral2"
        btnCentral2.Size = New Size(170, 49)
        btnCentral2.TabIndex = 33
        btnCentral2.Text = "Tendencia Central"
        btnCentral2.UseVisualStyleBackColor = True
        btnCentral2.Visible = False
        ' 
        ' txtPercentil
        ' 
        txtPercentil.Anchor = AnchorStyles.Top
        txtPercentil.Enabled = False
        txtPercentil.Location = New Point(499, 714)
        txtPercentil.Multiline = True
        txtPercentil.Name = "txtPercentil"
        txtPercentil.Size = New Size(88, 23)
        txtPercentil.TabIndex = 40
        txtPercentil.Visible = False
        ' 
        ' btnGrafica
        ' 
        btnGrafica.AccessibleRole = AccessibleRole.None
        btnGrafica.Anchor = AnchorStyles.Top
        btnGrafica.FlatAppearance.BorderSize = 0
        btnGrafica.FlatStyle = FlatStyle.Flat
        btnGrafica.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnGrafica.ForeColor = Color.Black
        btnGrafica.ImageAlign = ContentAlignment.MiddleLeft
        btnGrafica.Location = New Point(964, 540)
        btnGrafica.Name = "btnGrafica"
        btnGrafica.Size = New Size(72, 29)
        btnGrafica.TabIndex = 43
        btnGrafica.Text = "Grafica"
        btnGrafica.UseVisualStyleBackColor = True
        btnGrafica.Visible = False
        ' 
        ' txtMedia
        ' 
        txtMedia.Anchor = AnchorStyles.Top
        txtMedia.Enabled = False
        txtMedia.Location = New Point(277, 626)
        txtMedia.Multiline = True
        txtMedia.Name = "txtMedia"
        txtMedia.Size = New Size(88, 23)
        txtMedia.TabIndex = 44
        txtMedia.Visible = False
        txtMedia.WordWrap = False
        ' 
        ' txtMediana
        ' 
        txtMediana.Anchor = AnchorStyles.Top
        txtMediana.Enabled = False
        txtMediana.Location = New Point(277, 676)
        txtMediana.Multiline = True
        txtMediana.Name = "txtMediana"
        txtMediana.Size = New Size(88, 23)
        txtMediana.TabIndex = 45
        txtMediana.Visible = False
        ' 
        ' txtModa
        ' 
        txtModa.Anchor = AnchorStyles.Top
        txtModa.Enabled = False
        txtModa.Location = New Point(277, 724)
        txtModa.Multiline = True
        txtModa.Name = "txtModa"
        txtModa.Size = New Size(88, 23)
        txtModa.TabIndex = 46
        txtModa.Visible = False
        ' 
        ' txtDecil
        ' 
        txtDecil.Anchor = AnchorStyles.Top
        txtDecil.Enabled = False
        txtDecil.Location = New Point(499, 671)
        txtDecil.Multiline = True
        txtDecil.Name = "txtDecil"
        txtDecil.Size = New Size(88, 23)
        txtDecil.TabIndex = 47
        txtDecil.Visible = False
        ' 
        ' txtCuartil
        ' 
        txtCuartil.Anchor = AnchorStyles.Top
        txtCuartil.Enabled = False
        txtCuartil.Location = New Point(499, 621)
        txtCuartil.Multiline = True
        txtCuartil.Name = "txtCuartil"
        txtCuartil.Size = New Size(88, 23)
        txtCuartil.TabIndex = 48
        txtCuartil.Visible = False
        ' 
        ' txtDesviacionMedia
        ' 
        txtDesviacionMedia.Anchor = AnchorStyles.Top
        txtDesviacionMedia.Enabled = False
        txtDesviacionMedia.Location = New Point(996, 612)
        txtDesviacionMedia.Multiline = True
        txtDesviacionMedia.Name = "txtDesviacionMedia"
        txtDesviacionMedia.Size = New Size(88, 23)
        txtDesviacionMedia.TabIndex = 49
        txtDesviacionMedia.Visible = False
        ' 
        ' txtDesviacionEstantar
        ' 
        txtDesviacionEstantar.Anchor = AnchorStyles.Top
        txtDesviacionEstantar.Enabled = False
        txtDesviacionEstantar.Location = New Point(996, 659)
        txtDesviacionEstantar.Multiline = True
        txtDesviacionEstantar.Name = "txtDesviacionEstantar"
        txtDesviacionEstantar.Size = New Size(88, 23)
        txtDesviacionEstantar.TabIndex = 50
        txtDesviacionEstantar.Visible = False
        ' 
        ' btnCentral
        ' 
        btnCentral.AccessibleRole = AccessibleRole.None
        btnCentral.Anchor = AnchorStyles.Top
        btnCentral.FlatAppearance.BorderSize = 0
        btnCentral.FlatStyle = FlatStyle.Flat
        btnCentral.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCentral.ForeColor = Color.Black
        btnCentral.ImageAlign = ContentAlignment.MiddleLeft
        btnCentral.Location = New Point(151, 298)
        btnCentral.Name = "btnCentral"
        btnCentral.Size = New Size(168, 49)
        btnCentral.TabIndex = 51
        btnCentral.Text = "Tendecia Central"
        btnCentral.UseVisualStyleBackColor = True
        btnCentral.Visible = False
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top
        Label9.AutoSize = True
        Label9.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(608, 618)
        Label9.Name = "Label9"
        Label9.Size = New Size(124, 17)
        Label9.TabIndex = 52
        Label9.Text = "Cuartil a Calcular:"
        Label9.Visible = False
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Top
        Label10.AutoSize = True
        Label10.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(595, 714)
        Label10.Name = "Label10"
        Label10.Size = New Size(139, 17)
        Label10.TabIndex = 53
        Label10.Text = "Persentil a Calcular:"
        Label10.Visible = False
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.Top
        Label11.AutoSize = True
        Label11.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(617, 671)
        Label11.Name = "Label11"
        Label11.Size = New Size(115, 17)
        Label11.TabIndex = 54
        Label11.Text = "Decil a Calcular:"
        Label11.Visible = False
        ' 
        ' txtCuartilCalcular
        ' 
        txtCuartilCalcular.Anchor = AnchorStyles.Top
        txtCuartilCalcular.Location = New Point(734, 613)
        txtCuartilCalcular.Multiline = True
        txtCuartilCalcular.Name = "txtCuartilCalcular"
        txtCuartilCalcular.Size = New Size(88, 23)
        txtCuartilCalcular.TabIndex = 55
        txtCuartilCalcular.Visible = False
        ' 
        ' txtDecilCalcular
        ' 
        txtDecilCalcular.Anchor = AnchorStyles.Top
        txtDecilCalcular.Location = New Point(734, 665)
        txtDecilCalcular.Multiline = True
        txtDecilCalcular.Name = "txtDecilCalcular"
        txtDecilCalcular.Size = New Size(88, 23)
        txtDecilCalcular.TabIndex = 56
        txtDecilCalcular.Visible = False
        ' 
        ' txtPersintilCalcular
        ' 
        txtPersintilCalcular.Anchor = AnchorStyles.Top
        txtPersintilCalcular.Location = New Point(736, 709)
        txtPersintilCalcular.Multiline = True
        txtPersintilCalcular.Name = "txtPersintilCalcular"
        txtPersintilCalcular.Size = New Size(88, 23)
        txtPersintilCalcular.TabIndex = 57
        txtPersintilCalcular.Visible = False
        ' 
        ' txtComentario1
        ' 
        txtComentario1.Anchor = AnchorStyles.Top
        txtComentario1.Enabled = False
        txtComentario1.Location = New Point(218, 841)
        txtComentario1.Multiline = True
        txtComentario1.Name = "txtComentario1"
        txtComentario1.Size = New Size(583, 35)
        txtComentario1.TabIndex = 58
        txtComentario1.Visible = False
        ' 
        ' txtComentario2
        ' 
        txtComentario2.Anchor = AnchorStyles.Top
        txtComentario2.Enabled = False
        txtComentario2.Location = New Point(218, 895)
        txtComentario2.Multiline = True
        txtComentario2.Name = "txtComentario2"
        txtComentario2.Size = New Size(583, 35)
        txtComentario2.TabIndex = 59
        txtComentario2.Visible = False
        ' 
        ' txtComentario3
        ' 
        txtComentario3.Anchor = AnchorStyles.Top
        txtComentario3.Enabled = False
        txtComentario3.Location = New Point(218, 958)
        txtComentario3.Multiline = True
        txtComentario3.Name = "txtComentario3"
        txtComentario3.Size = New Size(583, 35)
        txtComentario3.TabIndex = 60
        txtComentario3.Visible = False
        ' 
        ' Label12
        ' 
        Label12.Anchor = AnchorStyles.Top
        Label12.AutoSize = True
        Label12.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(215, 807)
        Label12.Name = "Label12"
        Label12.Size = New Size(172, 17)
        Label12.TabIndex = 61
        Label12.Text = "Interpretación resultados:"
        Label12.Visible = False
        ' 
        ' btnComentarioCentral
        ' 
        btnComentarioCentral.AccessibleRole = AccessibleRole.None
        btnComentarioCentral.Anchor = AnchorStyles.Top
        btnComentarioCentral.FlatAppearance.BorderSize = 0
        btnComentarioCentral.FlatStyle = FlatStyle.Flat
        btnComentarioCentral.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnComentarioCentral.ForeColor = Color.Black
        btnComentarioCentral.ImageAlign = ContentAlignment.MiddleLeft
        btnComentarioCentral.Location = New Point(218, 763)
        btnComentarioCentral.Name = "btnComentarioCentral"
        btnComentarioCentral.Size = New Size(169, 29)
        btnComentarioCentral.TabIndex = 62
        btnComentarioCentral.Text = "Generar Comentario "
        btnComentarioCentral.UseVisualStyleBackColor = True
        btnComentarioCentral.Visible = False
        ' 
        ' btnComentarioPosicion
        ' 
        btnComentarioPosicion.AccessibleRole = AccessibleRole.None
        btnComentarioPosicion.Anchor = AnchorStyles.Top
        btnComentarioPosicion.FlatAppearance.BorderSize = 0
        btnComentarioPosicion.FlatStyle = FlatStyle.Flat
        btnComentarioPosicion.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnComentarioPosicion.ForeColor = Color.Black
        btnComentarioPosicion.ImageAlign = ContentAlignment.MiddleLeft
        btnComentarioPosicion.Location = New Point(537, 754)
        btnComentarioPosicion.Name = "btnComentarioPosicion"
        btnComentarioPosicion.Size = New Size(185, 29)
        btnComentarioPosicion.TabIndex = 63
        btnComentarioPosicion.Text = "Generar Comentario"
        btnComentarioPosicion.UseVisualStyleBackColor = True
        btnComentarioPosicion.Visible = False
        ' 
        ' btnComentarioDispersion
        ' 
        btnComentarioDispersion.AccessibleRole = AccessibleRole.None
        btnComentarioDispersion.Anchor = AnchorStyles.Top
        btnComentarioDispersion.FlatAppearance.BorderSize = 0
        btnComentarioDispersion.FlatStyle = FlatStyle.Flat
        btnComentarioDispersion.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnComentarioDispersion.ForeColor = Color.Black
        btnComentarioDispersion.ImageAlign = ContentAlignment.MiddleLeft
        btnComentarioDispersion.Location = New Point(884, 744)
        btnComentarioDispersion.Name = "btnComentarioDispersion"
        btnComentarioDispersion.Size = New Size(200, 29)
        btnComentarioDispersion.TabIndex = 64
        btnComentarioDispersion.Text = "Generar Comentario"
        btnComentarioDispersion.UseVisualStyleBackColor = True
        btnComentarioDispersion.Visible = False
        ' 
        ' Label13
        ' 
        Label13.Anchor = AnchorStyles.Top
        Label13.AutoSize = True
        Label13.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(218, 581)
        Label13.Name = "Label13"
        Label13.Size = New Size(203, 17)
        Label13.TabIndex = 65
        Label13.Text = "Medidas de Tendencia Central"
        Label13.Visible = False
        ' 
        ' Label14
        ' 
        Label14.Anchor = AnchorStyles.Top
        Label14.AutoSize = True
        Label14.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(481, 581)
        Label14.Name = "Label14"
        Label14.Size = New Size(142, 17)
        Label14.TabIndex = 66
        Label14.Text = "Medidas de Posición"
        Label14.Visible = False
        ' 
        ' Label15
        ' 
        Label15.Anchor = AnchorStyles.Top
        Label15.AutoSize = True
        Label15.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(852, 581)
        Label15.Name = "Label15"
        Label15.Size = New Size(156, 17)
        Label15.TabIndex = 67
        Label15.Text = "Medidas de Dispersion"
        Label15.Visible = False
        ' 
        ' btnSerieSimple2
        ' 
        btnSerieSimple2.AccessibleRole = AccessibleRole.None
        btnSerieSimple2.Anchor = AnchorStyles.Top
        btnSerieSimple2.FlatAppearance.BorderSize = 0
        btnSerieSimple2.FlatStyle = FlatStyle.Flat
        btnSerieSimple2.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSerieSimple2.ForeColor = Color.Black
        btnSerieSimple2.ImageAlign = ContentAlignment.MiddleLeft
        btnSerieSimple2.Location = New Point(1067, 79)
        btnSerieSimple2.Name = "btnSerieSimple2"
        btnSerieSimple2.Size = New Size(144, 49)
        btnSerieSimple2.TabIndex = 68
        btnSerieSimple2.Text = "Distrbución Serie simple"
        btnSerieSimple2.UseVisualStyleBackColor = True
        btnSerieSimple2.Visible = False
        ' 
        ' btnDatosInvertalos2
        ' 
        btnDatosInvertalos2.AccessibleRole = AccessibleRole.None
        btnDatosInvertalos2.Anchor = AnchorStyles.Top
        btnDatosInvertalos2.FlatAppearance.BorderSize = 0
        btnDatosInvertalos2.FlatStyle = FlatStyle.Flat
        btnDatosInvertalos2.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnDatosInvertalos2.ForeColor = Color.Black
        btnDatosInvertalos2.ImageAlign = ContentAlignment.MiddleLeft
        btnDatosInvertalos2.Location = New Point(1069, 134)
        btnDatosInvertalos2.Name = "btnDatosInvertalos2"
        btnDatosInvertalos2.Size = New Size(142, 49)
        btnDatosInvertalos2.TabIndex = 69
        btnDatosInvertalos2.Text = "Datos agrupados " & vbCrLf & "Intervalos"
        btnDatosInvertalos2.UseVisualStyleBackColor = True
        btnDatosInvertalos2.Visible = False
        ' 
        ' txtFrecuencia
        ' 
        txtFrecuencia.Anchor = AnchorStyles.Top
        txtFrecuencia.Location = New Point(736, 169)
        txtFrecuencia.Multiline = True
        txtFrecuencia.Name = "txtFrecuencia"
        txtFrecuencia.ScrollBars = ScrollBars.Vertical
        txtFrecuencia.Size = New Size(325, 61)
        txtFrecuencia.TabIndex = 70
        txtFrecuencia.Visible = False
        ' 
        ' Label16
        ' 
        Label16.Anchor = AnchorStyles.Top
        Label16.AutoSize = True
        Label16.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label16.Location = New Point(736, 150)
        Label16.Name = "Label16"
        Label16.Size = New Size(166, 17)
        Label16.TabIndex = 71
        Label16.Text = "Ingrese la frecuencia (F)"
        Label16.Visible = False
        ' 
        ' Label17
        ' 
        Label17.Anchor = AnchorStyles.Top
        Label17.AutoSize = True
        Label17.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label17.Location = New Point(736, 59)
        Label17.Name = "Label17"
        Label17.Size = New Size(133, 17)
        Label17.TabIndex = 72
        Label17.Text = "Ingrese la clase (X)"
        Label17.Visible = False
        ' 
        ' btnNuevo2
        ' 
        btnNuevo2.AccessibleRole = AccessibleRole.None
        btnNuevo2.Anchor = AnchorStyles.Top
        btnNuevo2.FlatAppearance.BorderSize = 0
        btnNuevo2.FlatStyle = FlatStyle.Flat
        btnNuevo2.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnNuevo2.ForeColor = Color.Black
        btnNuevo2.ImageAlign = ContentAlignment.MiddleLeft
        btnNuevo2.Location = New Point(1116, 215)
        btnNuevo2.Name = "btnNuevo2"
        btnNuevo2.Size = New Size(74, 29)
        btnNuevo2.TabIndex = 73
        btnNuevo2.Text = "Nuevo "
        btnNuevo2.UseVisualStyleBackColor = True
        btnNuevo2.Visible = False
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top
        Button1.Location = New Point(1009, 386)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 74
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label18
        ' 
        Label18.Anchor = AnchorStyles.Top
        Label18.AutoSize = True
        Label18.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label18.Location = New Point(252, 70)
        Label18.Name = "Label18"
        Label18.Size = New Size(133, 17)
        Label18.TabIndex = 75
        Label18.Text = "Ingrese la clase (X)"
        Label18.Visible = False
        ' 
        ' Label19
        ' 
        Label19.Anchor = AnchorStyles.Top
        Label19.AutoSize = True
        Label19.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label19.Location = New Point(252, 172)
        Label19.Name = "Label19"
        Label19.Size = New Size(194, 17)
        Label19.TabIndex = 76
        Label19.Text = "Ingrese la cantidad de datos:"
        Label19.Visible = False
        ' 
        ' txtCantidadDatos
        ' 
        txtCantidadDatos.Anchor = AnchorStyles.Top
        txtCantidadDatos.Location = New Point(448, 169)
        txtCantidadDatos.Name = "txtCantidadDatos"
        txtCantidadDatos.ScrollBars = ScrollBars.Vertical
        txtCantidadDatos.Size = New Size(65, 23)
        txtCantidadDatos.TabIndex = 77
        txtCantidadDatos.Visible = False
        ' 
        ' Label20
        ' 
        Label20.Anchor = AnchorStyles.Top
        Label20.AutoSize = True
        Label20.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label20.Location = New Point(734, 235)
        Label20.Name = "Label20"
        Label20.Size = New Size(194, 17)
        Label20.TabIndex = 78
        Label20.Text = "Ingrese la cantidad de datos:"
        Label20.Visible = False
        ' 
        ' txtCantidadDatos2
        ' 
        txtCantidadDatos2.Anchor = AnchorStyles.Top
        txtCantidadDatos2.Location = New Point(934, 234)
        txtCantidadDatos2.Name = "txtCantidadDatos2"
        txtCantidadDatos2.ScrollBars = ScrollBars.Vertical
        txtCantidadDatos2.Size = New Size(65, 23)
        txtCantidadDatos2.TabIndex = 79
        txtCantidadDatos2.Visible = False
        ' 
        ' Label21
        ' 
        Label21.Anchor = AnchorStyles.Top
        Label21.AutoSize = True
        Label21.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label21.Location = New Point(782, 375)
        Label21.Name = "Label21"
        Label21.Size = New Size(194, 17)
        Label21.TabIndex = 80
        Label21.Text = "Ingrese la cantidad de datos:"
        ' 
        ' frmMDCentral
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1262, 1012)
        Controls.Add(Label21)
        Controls.Add(txtCantidadDatos2)
        Controls.Add(Label20)
        Controls.Add(txtCantidadDatos)
        Controls.Add(Label19)
        Controls.Add(Label18)
        Controls.Add(Button1)
        Controls.Add(btnNuevo2)
        Controls.Add(Label17)
        Controls.Add(Label16)
        Controls.Add(txtFrecuencia)
        Controls.Add(btnDatosInvertalos2)
        Controls.Add(btnSerieSimple2)
        Controls.Add(Label15)
        Controls.Add(Label14)
        Controls.Add(Label13)
        Controls.Add(btnComentarioDispersion)
        Controls.Add(btnComentarioPosicion)
        Controls.Add(btnComentarioCentral)
        Controls.Add(Label12)
        Controls.Add(txtComentario3)
        Controls.Add(txtComentario2)
        Controls.Add(txtComentario1)
        Controls.Add(txtPersintilCalcular)
        Controls.Add(txtDecilCalcular)
        Controls.Add(txtCuartilCalcular)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(btnCentral)
        Controls.Add(txtDesviacionEstantar)
        Controls.Add(txtDesviacionMedia)
        Controls.Add(txtCuartil)
        Controls.Add(txtDecil)
        Controls.Add(txtModa)
        Controls.Add(txtMediana)
        Controls.Add(txtMedia)
        Controls.Add(btnGrafica)
        Controls.Add(txtPercentil)
        Controls.Add(btnDispersion2)
        Controls.Add(btnPosicion2)
        Controls.Add(btnCentral2)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnDispersion)
        Controls.Add(btnPosicion)
        Controls.Add(dtTabla)
        Controls.Add(btnNuevo)
        Controls.Add(btnSiguiente2)
        Controls.Add(btnInvervalos)
        Controls.Add(btnSimple)
        Controls.Add(btnSiguiente)
        Controls.Add(btnCancelar)
        Controls.Add(txtClase)
        Controls.Add(txtNominal)
        Controls.Add(btnConsolidado)
        Controls.Add(btnNominal)
        Name = "frmMDCentral"
        Text = "Calculos"
        CType(dtTabla, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnNominal As Button
    Friend WithEvents btnConsolidado As Button
    Friend WithEvents txtNominal As TextBox
    Friend WithEvents txtClase As TextBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnSimple As Button
    Friend WithEvents btnInvervalos As Button
    Friend WithEvents btnSiguiente2 As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents dtTabla As DataGridView
    Friend WithEvents btnPosicion As Button
    Friend WithEvents btnDispersion As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnDispersion2 As Button
    Friend WithEvents btnPosicion2 As Button
    Friend WithEvents btnCentral2 As Button
    Friend WithEvents txtPercentil As TextBox
    Friend WithEvents btnGrafica As Button
    Friend WithEvents txtMedia As TextBox
    Friend WithEvents txtMediana As TextBox
    Friend WithEvents txtModa As TextBox
    Friend WithEvents txtDecil As TextBox
    Friend WithEvents txtCuartil As TextBox
    Friend WithEvents txtDesviacionMedia As TextBox
    Friend WithEvents txtDesviacionEstantar As TextBox
    Friend WithEvents btnCentral As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtCuartilCalcular As TextBox
    Friend WithEvents txtDecilCalcular As TextBox
    Friend WithEvents txtPersintilCalcular As TextBox
    Friend WithEvents txtComentario1 As TextBox
    Friend WithEvents txtComentario2 As TextBox
    Friend WithEvents txtComentario3 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents btnComentarioCentral As Button
    Friend WithEvents btnComentarioPosicion As Button
    Friend WithEvents btnComentarioDispersion As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents btnSerieSimple2 As Button
    Friend WithEvents btnDatosInvertalos2 As Button
    Friend WithEvents txtFrecuencia As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents btnNuevo2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents txtCantidadDatos As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtCantidadDatos2 As TextBox
    Friend WithEvents Label21 As Label
End Class
