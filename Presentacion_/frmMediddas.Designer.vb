﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMediddas
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
        txtNominal = New TextBox()
        Label18 = New Label()
        Label19 = New Label()
        txtCantidadDatos = New TextBox()
        btnSimple = New Button()
        btnInvervalos = New Button()
        btnSiguiente = New Button()
        btnCancelar = New Button()
        dtTabla = New DataGridView()
        btnCentral = New Button()
        btnComentarioCentral = New Button()
        txtModa = New TextBox()
        txtMediana = New TextBox()
        txtMedia = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Label12 = New Label()
        txtComentario3 = New TextBox()
        txtComentario2 = New TextBox()
        txtComentario1 = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtCuartil = New TextBox()
        txtDecil = New TextBox()
        txtPercentil = New TextBox()
        btnComentarioPosicion = New Button()
        Label9 = New Label()
        txtCuartilCalcular = New TextBox()
        Label11 = New Label()
        txtDecilCalcular = New TextBox()
        Label10 = New Label()
        txtPersintilCalcular = New TextBox()
        Label7 = New Label()
        Label8 = New Label()
        txtDesviacionMedia = New TextBox()
        txtDesviacionEstantar = New TextBox()
        btnComentarioDispersion = New Button()
        btnPosicion = New Button()
        btnDispersion = New Button()
        btnNuevo = New Button()
        btnRregresar = New Button()
        btnLimpiar = New Button()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        btnGrafica1 = New Button()
        btnGrafica2 = New Button()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        lbGrafica = New Label()
        CType(dtTabla, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtNominal
        ' 
        txtNominal.Anchor = AnchorStyles.Top
        txtNominal.Location = New Point(284, 36)
        txtNominal.Multiline = True
        txtNominal.Name = "txtNominal"
        txtNominal.ScrollBars = ScrollBars.Vertical
        txtNominal.Size = New Size(360, 69)
        txtNominal.TabIndex = 6
        ' 
        ' Label18
        ' 
        Label18.Anchor = AnchorStyles.Top
        Label18.AutoSize = True
        Label18.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label18.Location = New Point(284, 4)
        Label18.Name = "Label18"
        Label18.Size = New Size(133, 17)
        Label18.TabIndex = 76
        Label18.Text = "Ingrese la clase (X)"
        ' 
        ' Label19
        ' 
        Label19.Anchor = AnchorStyles.Top
        Label19.AutoSize = True
        Label19.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label19.Location = New Point(284, 117)
        Label19.Name = "Label19"
        Label19.Size = New Size(194, 17)
        Label19.TabIndex = 77
        Label19.Text = "Ingrese la cantidad de datos:"
        ' 
        ' txtCantidadDatos
        ' 
        txtCantidadDatos.Anchor = AnchorStyles.Top
        txtCantidadDatos.Location = New Point(484, 111)
        txtCantidadDatos.Name = "txtCantidadDatos"
        txtCantidadDatos.ScrollBars = ScrollBars.Vertical
        txtCantidadDatos.Size = New Size(65, 23)
        txtCantidadDatos.TabIndex = 78
        ' 
        ' btnSimple
        ' 
        btnSimple.Anchor = AnchorStyles.Top
        btnSimple.FlatAppearance.BorderSize = 0
        btnSimple.FlatStyle = FlatStyle.Flat
        btnSimple.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSimple.ForeColor = Color.Black
        btnSimple.ImageAlign = ContentAlignment.MiddleLeft
        btnSimple.Location = New Point(892, 5)
        btnSimple.Name = "btnSimple"
        btnSimple.Size = New Size(158, 44)
        btnSimple.TabIndex = 79
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
        btnInvervalos.Location = New Point(1076, 5)
        btnInvervalos.Name = "btnInvervalos"
        btnInvervalos.Size = New Size(158, 44)
        btnInvervalos.TabIndex = 80
        btnInvervalos.Text = "Datos Agrupados Intervalos"
        btnInvervalos.UseVisualStyleBackColor = True
        btnInvervalos.Visible = False
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
        btnSiguiente.Location = New Point(390, 151)
        btnSiguiente.Name = "btnSiguiente"
        btnSiguiente.Size = New Size(88, 27)
        btnSiguiente.TabIndex = 81
        btnSiguiente.Text = "Siguiente"
        btnSiguiente.UseVisualStyleBackColor = True
        ' 
        ' btnCancelar
        ' 
        btnCancelar.AccessibleRole = AccessibleRole.None
        btnCancelar.Anchor = AnchorStyles.Top
        btnCancelar.FlatAppearance.BorderSize = 0
        btnCancelar.FlatStyle = FlatStyle.Flat
        btnCancelar.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCancelar.ForeColor = Color.Black
        btnCancelar.ImageAlign = ContentAlignment.MiddleLeft
        btnCancelar.Location = New Point(1280, 20)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(90, 29)
        btnCancelar.TabIndex = 82
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        btnCancelar.Visible = False
        ' 
        ' dtTabla
        ' 
        dtTabla.Anchor = AnchorStyles.Top
        dtTabla.BackgroundColor = Color.White
        dtTabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtTabla.GridColor = Color.Black
        dtTabla.Location = New Point(950, 55)
        dtTabla.Name = "dtTabla"
        dtTabla.Size = New Size(330, 259)
        dtTabla.TabIndex = 83
        dtTabla.Visible = False
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
        btnCentral.Location = New Point(683, 369)
        btnCentral.Name = "btnCentral"
        btnCentral.Size = New Size(168, 49)
        btnCentral.TabIndex = 84
        btnCentral.Text = "Tendecia Central"
        btnCentral.UseVisualStyleBackColor = True
        btnCentral.Visible = False
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
        btnComentarioCentral.Location = New Point(641, 552)
        btnComentarioCentral.Name = "btnComentarioCentral"
        btnComentarioCentral.Size = New Size(169, 29)
        btnComentarioCentral.TabIndex = 91
        btnComentarioCentral.Text = "Generar Comentario "
        btnComentarioCentral.UseVisualStyleBackColor = True
        btnComentarioCentral.Visible = False
        ' 
        ' txtModa
        ' 
        txtModa.Anchor = AnchorStyles.Top
        txtModa.Enabled = False
        txtModa.Location = New Point(703, 522)
        txtModa.Multiline = True
        txtModa.Name = "txtModa"
        txtModa.Size = New Size(107, 23)
        txtModa.TabIndex = 90
        txtModa.Visible = False
        ' 
        ' txtMediana
        ' 
        txtMediana.Anchor = AnchorStyles.Top
        txtMediana.Enabled = False
        txtMediana.Location = New Point(703, 474)
        txtMediana.Multiline = True
        txtMediana.Name = "txtMediana"
        txtMediana.Size = New Size(107, 23)
        txtMediana.TabIndex = 89
        txtMediana.Visible = False
        ' 
        ' txtMedia
        ' 
        txtMedia.Anchor = AnchorStyles.Top
        txtMedia.Enabled = False
        txtMedia.Location = New Point(703, 424)
        txtMedia.Multiline = True
        txtMedia.Name = "txtMedia"
        txtMedia.Size = New Size(107, 23)
        txtMedia.TabIndex = 88
        txtMedia.Visible = False
        txtMedia.WordWrap = False
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(641, 523)
        Label3.Name = "Label3"
        Label3.Size = New Size(47, 17)
        Label3.TabIndex = 87
        Label3.Text = "Moda:"
        Label3.Visible = False
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(625, 473)
        Label2.Name = "Label2"
        Label2.Size = New Size(66, 17)
        Label2.TabIndex = 86
        Label2.Text = "Mediana:"
        Label2.Visible = False
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(641, 425)
        Label1.Name = "Label1"
        Label1.Size = New Size(50, 17)
        Label1.TabIndex = 85
        Label1.Text = "Media:"
        Label1.Visible = False
        ' 
        ' Label12
        ' 
        Label12.Anchor = AnchorStyles.Top
        Label12.AutoSize = True
        Label12.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(775, 607)
        Label12.Name = "Label12"
        Label12.Size = New Size(172, 17)
        Label12.TabIndex = 95
        Label12.Text = "Interpretación resultados:"
        Label12.Visible = False
        ' 
        ' txtComentario3
        ' 
        txtComentario3.Anchor = AnchorStyles.Top
        txtComentario3.Enabled = False
        txtComentario3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtComentario3.Location = New Point(775, 729)
        txtComentario3.Multiline = True
        txtComentario3.Name = "txtComentario3"
        txtComentario3.Size = New Size(583, 35)
        txtComentario3.TabIndex = 94
        txtComentario3.Visible = False
        ' 
        ' txtComentario2
        ' 
        txtComentario2.Anchor = AnchorStyles.Top
        txtComentario2.Enabled = False
        txtComentario2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtComentario2.Location = New Point(775, 678)
        txtComentario2.Multiline = True
        txtComentario2.Name = "txtComentario2"
        txtComentario2.Size = New Size(583, 35)
        txtComentario2.TabIndex = 93
        txtComentario2.Visible = False
        ' 
        ' txtComentario1
        ' 
        txtComentario1.Anchor = AnchorStyles.Top
        txtComentario1.Enabled = False
        txtComentario1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtComentario1.Location = New Point(775, 627)
        txtComentario1.Multiline = True
        txtComentario1.Name = "txtComentario1"
        txtComentario1.Size = New Size(583, 35)
        txtComentario1.TabIndex = 92
        txtComentario1.Visible = False
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(851, 424)
        Label4.Name = "Label4"
        Label4.Size = New Size(54, 17)
        Label4.TabIndex = 101
        Label4.Text = "Cuartil:"
        Label4.Visible = False
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(860, 474)
        Label5.Name = "Label5"
        Label5.Size = New Size(45, 17)
        Label5.TabIndex = 102
        Label5.Text = "Decil:"
        Label5.Visible = False
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top
        Label6.AutoSize = True
        Label6.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(828, 528)
        Label6.Name = "Label6"
        Label6.Size = New Size(77, 17)
        Label6.TabIndex = 103
        Label6.Text = "Percenctil:"
        Label6.Visible = False
        ' 
        ' txtCuartil
        ' 
        txtCuartil.Anchor = AnchorStyles.Top
        txtCuartil.Enabled = False
        txtCuartil.Location = New Point(911, 423)
        txtCuartil.Multiline = True
        txtCuartil.Name = "txtCuartil"
        txtCuartil.Size = New Size(88, 23)
        txtCuartil.TabIndex = 104
        txtCuartil.Visible = False
        ' 
        ' txtDecil
        ' 
        txtDecil.Anchor = AnchorStyles.Top
        txtDecil.Enabled = False
        txtDecil.Location = New Point(911, 473)
        txtDecil.Multiline = True
        txtDecil.Name = "txtDecil"
        txtDecil.Size = New Size(88, 23)
        txtDecil.TabIndex = 105
        txtDecil.Visible = False
        ' 
        ' txtPercentil
        ' 
        txtPercentil.Anchor = AnchorStyles.Top
        txtPercentil.Enabled = False
        txtPercentil.Location = New Point(911, 523)
        txtPercentil.Multiline = True
        txtPercentil.Name = "txtPercentil"
        txtPercentil.Size = New Size(88, 23)
        txtPercentil.TabIndex = 106
        txtPercentil.Visible = False
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
        btnComentarioPosicion.Location = New Point(944, 552)
        btnComentarioPosicion.Name = "btnComentarioPosicion"
        btnComentarioPosicion.Size = New Size(185, 29)
        btnComentarioPosicion.TabIndex = 107
        btnComentarioPosicion.Text = "Generar Comentario"
        btnComentarioPosicion.UseVisualStyleBackColor = True
        btnComentarioPosicion.Visible = False
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top
        Label9.AutoSize = True
        Label9.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(1012, 425)
        Label9.Name = "Label9"
        Label9.Size = New Size(124, 17)
        Label9.TabIndex = 108
        Label9.Text = "Cuartil a Calcular:"
        Label9.Visible = False
        ' 
        ' txtCuartilCalcular
        ' 
        txtCuartilCalcular.Anchor = AnchorStyles.Top
        txtCuartilCalcular.Location = New Point(1150, 424)
        txtCuartilCalcular.Multiline = True
        txtCuartilCalcular.Name = "txtCuartilCalcular"
        txtCuartilCalcular.Size = New Size(62, 23)
        txtCuartilCalcular.TabIndex = 109
        txtCuartilCalcular.Visible = False
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.Top
        Label11.AutoSize = True
        Label11.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(1014, 473)
        Label11.Name = "Label11"
        Label11.Size = New Size(115, 17)
        Label11.TabIndex = 110
        Label11.Text = "Decil a Calcular:"
        Label11.Visible = False
        ' 
        ' txtDecilCalcular
        ' 
        txtDecilCalcular.Anchor = AnchorStyles.Top
        txtDecilCalcular.Location = New Point(1150, 474)
        txtDecilCalcular.Multiline = True
        txtDecilCalcular.Name = "txtDecilCalcular"
        txtDecilCalcular.Size = New Size(62, 23)
        txtDecilCalcular.TabIndex = 111
        txtDecilCalcular.Visible = False
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Top
        Label10.AutoSize = True
        Label10.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(1005, 532)
        Label10.Name = "Label10"
        Label10.Size = New Size(139, 17)
        Label10.TabIndex = 112
        Label10.Text = "Persentil a Calcular:"
        Label10.Visible = False
        ' 
        ' txtPersintilCalcular
        ' 
        txtPersintilCalcular.Anchor = AnchorStyles.Top
        txtPersintilCalcular.Location = New Point(1150, 528)
        txtPersintilCalcular.Multiline = True
        txtPersintilCalcular.Name = "txtPersintilCalcular"
        txtPersintilCalcular.Size = New Size(62, 23)
        txtPersintilCalcular.TabIndex = 113
        txtPersintilCalcular.Visible = False
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top
        Label7.AutoSize = True
        Label7.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(1239, 430)
        Label7.Name = "Label7"
        Label7.Size = New Size(126, 17)
        Label7.TabIndex = 115
        Label7.Text = "Desviación Media:"
        Label7.Visible = False
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top
        Label8.AutoSize = True
        Label8.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(1218, 475)
        Label8.Name = "Label8"
        Label8.Size = New Size(147, 17)
        Label8.TabIndex = 116
        Label8.Text = "Desviación Estandar:"
        Label8.Visible = False
        ' 
        ' txtDesviacionMedia
        ' 
        txtDesviacionMedia.Anchor = AnchorStyles.Top
        txtDesviacionMedia.Enabled = False
        txtDesviacionMedia.Location = New Point(1376, 429)
        txtDesviacionMedia.Multiline = True
        txtDesviacionMedia.Name = "txtDesviacionMedia"
        txtDesviacionMedia.Size = New Size(88, 23)
        txtDesviacionMedia.TabIndex = 117
        txtDesviacionMedia.Visible = False
        ' 
        ' txtDesviacionEstantar
        ' 
        txtDesviacionEstantar.Anchor = AnchorStyles.Top
        txtDesviacionEstantar.Enabled = False
        txtDesviacionEstantar.Location = New Point(1376, 474)
        txtDesviacionEstantar.Multiline = True
        txtDesviacionEstantar.Name = "txtDesviacionEstantar"
        txtDesviacionEstantar.Size = New Size(88, 23)
        txtDesviacionEstantar.TabIndex = 118
        txtDesviacionEstantar.Visible = False
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
        btnComentarioDispersion.Location = New Point(1239, 552)
        btnComentarioDispersion.Name = "btnComentarioDispersion"
        btnComentarioDispersion.Size = New Size(200, 29)
        btnComentarioDispersion.TabIndex = 119
        btnComentarioDispersion.Text = "Generar Comentario"
        btnComentarioDispersion.UseVisualStyleBackColor = True
        btnComentarioDispersion.Visible = False
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
        btnPosicion.Location = New Point(961, 368)
        btnPosicion.Name = "btnPosicion"
        btnPosicion.Size = New Size(168, 49)
        btnPosicion.TabIndex = 120
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
        btnDispersion.Location = New Point(1239, 374)
        btnDispersion.Name = "btnDispersion"
        btnDispersion.Size = New Size(185, 49)
        btnDispersion.TabIndex = 121
        btnDispersion.Text = "Medidas de Dispersión"
        btnDispersion.UseVisualStyleBackColor = True
        btnDispersion.Visible = False
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
        btnNuevo.Location = New Point(828, 307)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(74, 29)
        btnNuevo.TabIndex = 122
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = True
        btnNuevo.Visible = False
        ' 
        ' btnRregresar
        ' 
        btnRregresar.AccessibleRole = AccessibleRole.None
        btnRregresar.Anchor = AnchorStyles.Top
        btnRregresar.FlatAppearance.BorderSize = 0
        btnRregresar.FlatStyle = FlatStyle.Flat
        btnRregresar.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRregresar.ForeColor = Color.Black
        btnRregresar.ImageAlign = ContentAlignment.MiddleLeft
        btnRregresar.Location = New Point(650, 75)
        btnRregresar.Name = "btnRregresar"
        btnRregresar.Size = New Size(89, 29)
        btnRregresar.TabIndex = 123
        btnRregresar.Text = "Rregresar"
        btnRregresar.UseVisualStyleBackColor = True
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.AccessibleRole = AccessibleRole.None
        btnLimpiar.Anchor = AnchorStyles.Top
        btnLimpiar.FlatAppearance.BorderSize = 0
        btnLimpiar.FlatStyle = FlatStyle.Flat
        btnLimpiar.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLimpiar.ForeColor = Color.Black
        btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft
        btnLimpiar.Location = New Point(650, 40)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(69, 29)
        btnLimpiar.TabIndex = 124
        btnLimpiar.Text = "Limpiar"
        btnLimpiar.UseVisualStyleBackColor = True
        ' 
        ' btnGrafica1
        ' 
        btnGrafica1.AccessibleRole = AccessibleRole.None
        btnGrafica1.Anchor = AnchorStyles.Top
        btnGrafica1.FlatAppearance.BorderSize = 0
        btnGrafica1.FlatStyle = FlatStyle.Flat
        btnGrafica1.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnGrafica1.ForeColor = Color.Black
        btnGrafica1.ImageAlign = ContentAlignment.MiddleLeft
        btnGrafica1.Location = New Point(966, 339)
        btnGrafica1.Name = "btnGrafica1"
        btnGrafica1.Size = New Size(157, 29)
        btnGrafica1.TabIndex = 125
        btnGrafica1.Text = "Generar Grafica"
        btnGrafica1.UseVisualStyleBackColor = True
        btnGrafica1.Visible = False
        ' 
        ' btnGrafica2
        ' 
        btnGrafica2.AccessibleRole = AccessibleRole.None
        btnGrafica2.Anchor = AnchorStyles.Top
        btnGrafica2.FlatAppearance.BorderSize = 0
        btnGrafica2.FlatStyle = FlatStyle.Flat
        btnGrafica2.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnGrafica2.ForeColor = Color.Black
        btnGrafica2.ImageAlign = ContentAlignment.MiddleLeft
        btnGrafica2.Location = New Point(1135, 339)
        btnGrafica2.Name = "btnGrafica2"
        btnGrafica2.Size = New Size(157, 29)
        btnGrafica2.TabIndex = 126
        btnGrafica2.Text = "Generar Grafica"
        btnGrafica2.UseVisualStyleBackColor = True
        btnGrafica2.Visible = False
        ' 
        ' Panel1
        ' 
        Panel1.AutoScroll = True
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(12, 251)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(566, 430)
        Panel1.TabIndex = 128
        Panel1.Visible = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(3, 8)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1051, 422)
        PictureBox1.TabIndex = 127
        PictureBox1.TabStop = False
        ' 
        ' lbGrafica
        ' 
        lbGrafica.Anchor = AnchorStyles.Top
        lbGrafica.AutoSize = True
        lbGrafica.Font = New Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbGrafica.Location = New Point(226, 208)
        lbGrafica.Name = "lbGrafica"
        lbGrafica.Size = New Size(95, 29)
        lbGrafica.TabIndex = 129
        lbGrafica.Text = "Gráfica"
        lbGrafica.Visible = False
        ' 
        ' frmMediddas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1482, 801)
        Controls.Add(lbGrafica)
        Controls.Add(Panel1)
        Controls.Add(btnGrafica2)
        Controls.Add(btnGrafica1)
        Controls.Add(btnLimpiar)
        Controls.Add(btnRregresar)
        Controls.Add(btnNuevo)
        Controls.Add(btnDispersion)
        Controls.Add(btnPosicion)
        Controls.Add(btnComentarioDispersion)
        Controls.Add(txtDesviacionEstantar)
        Controls.Add(txtDesviacionMedia)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(txtPersintilCalcular)
        Controls.Add(Label10)
        Controls.Add(txtDecilCalcular)
        Controls.Add(Label11)
        Controls.Add(txtCuartilCalcular)
        Controls.Add(Label9)
        Controls.Add(btnComentarioPosicion)
        Controls.Add(txtPercentil)
        Controls.Add(txtDecil)
        Controls.Add(txtCuartil)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label12)
        Controls.Add(txtComentario3)
        Controls.Add(txtComentario2)
        Controls.Add(txtComentario1)
        Controls.Add(btnComentarioCentral)
        Controls.Add(txtModa)
        Controls.Add(txtMediana)
        Controls.Add(txtMedia)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnCentral)
        Controls.Add(dtTabla)
        Controls.Add(btnCancelar)
        Controls.Add(btnSiguiente)
        Controls.Add(btnInvervalos)
        Controls.Add(btnSimple)
        Controls.Add(txtCantidadDatos)
        Controls.Add(Label19)
        Controls.Add(Label18)
        Controls.Add(txtNominal)
        Name = "frmMediddas"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmMediddas"
        CType(dtTabla, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNominal As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents txtCantidadDatos As TextBox
    Friend WithEvents btnSimple As Button
    Friend WithEvents btnInvervalos As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents dtTabla As DataGridView
    Friend WithEvents btnCentral As Button
    Friend WithEvents btnComentarioCentral As Button
    Friend WithEvents txtModa As TextBox
    Friend WithEvents txtMediana As TextBox
    Friend WithEvents txtMedia As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtComentario3 As TextBox
    Friend WithEvents txtComentario2 As TextBox
    Friend WithEvents txtComentario1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCuartil As TextBox
    Friend WithEvents txtDecil As TextBox
    Friend WithEvents txtPercentil As TextBox
    Friend WithEvents btnComentarioPosicion As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCuartilCalcular As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtDecilCalcular As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtPersintilCalcular As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtDesviacionMedia As TextBox
    Friend WithEvents txtDesviacionEstantar As TextBox
    Friend WithEvents btnComentarioDispersion As Button
    Friend WithEvents btnPosicion As Button
    Friend WithEvents btnDispersion As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnRregresar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnGrafica1 As Button
    Friend WithEvents btnGrafica2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbGrafica As Label
End Class
