<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMeddidas2
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
        Label18 = New Label()
        Label19 = New Label()
        txtCantidadDatos = New TextBox()
        btnRregresar = New Button()
        btnSimple = New Button()
        btnInvervalos = New Button()
        dtTabla = New DataGridView()
        btnNuevo = New Button()
        btnCancelar = New Button()
        btnSiguiente = New Button()
        btnCentral = New Button()
        btnPosicion = New Button()
        btnDispersion = New Button()
        txtModa = New TextBox()
        txtMediana = New TextBox()
        txtMedia = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        txtPercentil = New TextBox()
        txtDecil = New TextBox()
        txtCuartil = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        txtPersintilCalcular = New TextBox()
        Label10 = New Label()
        txtDecilCalcular = New TextBox()
        Label11 = New Label()
        txtCuartilCalcular = New TextBox()
        Label9 = New Label()
        Label7 = New Label()
        txtDesviacionMedia = New TextBox()
        Label8 = New Label()
        txtDesviacionEstantar = New TextBox()
        btnComentarioCentral = New Button()
        btnComentarioPosicion = New Button()
        btnComentarioDispersion = New Button()
        Label15 = New Label()
        txtComentario1 = New TextBox()
        txtComentario2 = New TextBox()
        txtComentario3 = New TextBox()
        txtFrecuencia = New TextBox()
        Label16 = New Label()
        txtClase = New TextBox()
        btnLimpiar = New Button()
        lbGrafica = New Label()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        btnGrafica1 = New Button()
        btnGrafica2 = New Button()
        CType(dtTabla, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label18
        ' 
        Label18.Anchor = AnchorStyles.Top
        Label18.AutoSize = True
        Label18.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label18.Location = New Point(48, 34)
        Label18.Name = "Label18"
        Label18.Size = New Size(455, 17)
        Label18.TabIndex = 77
        Label18.Text = "Ingrese la clase (X) (Si es por intervalos separelos por guion y coma)"
        ' 
        ' Label19
        ' 
        Label19.Anchor = AnchorStyles.Top
        Label19.AutoSize = True
        Label19.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label19.Location = New Point(42, 236)
        Label19.Name = "Label19"
        Label19.Size = New Size(194, 17)
        Label19.TabIndex = 79
        Label19.Text = "Ingrese la cantidad de datos:"
        ' 
        ' txtCantidadDatos
        ' 
        txtCantidadDatos.Anchor = AnchorStyles.Top
        txtCantidadDatos.Location = New Point(242, 235)
        txtCantidadDatos.Name = "txtCantidadDatos"
        txtCantidadDatos.ScrollBars = ScrollBars.Vertical
        txtCantidadDatos.Size = New Size(65, 23)
        txtCantidadDatos.TabIndex = 80
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
        btnRregresar.Location = New Point(313, 235)
        btnRregresar.Name = "btnRregresar"
        btnRregresar.Size = New Size(89, 29)
        btnRregresar.TabIndex = 124
        btnRregresar.Text = "Rregresar"
        btnRregresar.UseVisualStyleBackColor = True
        ' 
        ' btnSimple
        ' 
        btnSimple.Anchor = AnchorStyles.Top
        btnSimple.FlatAppearance.BorderSize = 0
        btnSimple.FlatStyle = FlatStyle.Flat
        btnSimple.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSimple.ForeColor = Color.Black
        btnSimple.ImageAlign = ContentAlignment.MiddleLeft
        btnSimple.Location = New Point(706, 9)
        btnSimple.Name = "btnSimple"
        btnSimple.Size = New Size(158, 44)
        btnSimple.TabIndex = 125
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
        btnInvervalos.Location = New Point(878, 9)
        btnInvervalos.Name = "btnInvervalos"
        btnInvervalos.Size = New Size(158, 44)
        btnInvervalos.TabIndex = 126
        btnInvervalos.Text = "Datos Agrupados Intervalos"
        btnInvervalos.UseVisualStyleBackColor = True
        btnInvervalos.Visible = False
        ' 
        ' dtTabla
        ' 
        dtTabla.Anchor = AnchorStyles.Top
        dtTabla.BackgroundColor = Color.White
        dtTabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtTabla.GridColor = Color.Black
        dtTabla.Location = New Point(764, 69)
        dtTabla.Name = "dtTabla"
        dtTabla.Size = New Size(347, 222)
        dtTabla.TabIndex = 127
        dtTabla.Visible = False
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
        btnNuevo.Location = New Point(657, 262)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(74, 29)
        btnNuevo.TabIndex = 128
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = True
        btnNuevo.Visible = False
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
        btnCancelar.Location = New Point(1042, 17)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(90, 29)
        btnCancelar.TabIndex = 129
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        btnCancelar.Visible = False
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
        btnSiguiente.Location = New Point(219, 264)
        btnSiguiente.Name = "btnSiguiente"
        btnSiguiente.Size = New Size(88, 27)
        btnSiguiente.TabIndex = 130
        btnSiguiente.Text = "Siguiente"
        btnSiguiente.UseVisualStyleBackColor = True
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
        btnCentral.Location = New Point(616, 350)
        btnCentral.Name = "btnCentral"
        btnCentral.Size = New Size(168, 49)
        btnCentral.TabIndex = 131
        btnCentral.Text = "Tendecia Central"
        btnCentral.UseVisualStyleBackColor = True
        btnCentral.Visible = False
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
        btnPosicion.Location = New Point(915, 350)
        btnPosicion.Name = "btnPosicion"
        btnPosicion.Size = New Size(168, 49)
        btnPosicion.TabIndex = 132
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
        btnDispersion.Location = New Point(1184, 350)
        btnDispersion.Name = "btnDispersion"
        btnDispersion.Size = New Size(185, 49)
        btnDispersion.TabIndex = 133
        btnDispersion.Text = "Medidas de Dispersión"
        btnDispersion.UseVisualStyleBackColor = True
        btnDispersion.Visible = False
        ' 
        ' txtModa
        ' 
        txtModa.Anchor = AnchorStyles.Top
        txtModa.Enabled = False
        txtModa.Location = New Point(657, 503)
        txtModa.Multiline = True
        txtModa.Name = "txtModa"
        txtModa.Size = New Size(107, 23)
        txtModa.TabIndex = 139
        txtModa.Visible = False
        ' 
        ' txtMediana
        ' 
        txtMediana.Anchor = AnchorStyles.Top
        txtMediana.Enabled = False
        txtMediana.Location = New Point(657, 455)
        txtMediana.Multiline = True
        txtMediana.Name = "txtMediana"
        txtMediana.Size = New Size(107, 23)
        txtMediana.TabIndex = 138
        txtMediana.Visible = False
        ' 
        ' txtMedia
        ' 
        txtMedia.Anchor = AnchorStyles.Top
        txtMedia.Enabled = False
        txtMedia.Location = New Point(657, 405)
        txtMedia.Multiline = True
        txtMedia.Name = "txtMedia"
        txtMedia.Size = New Size(107, 23)
        txtMedia.TabIndex = 137
        txtMedia.Visible = False
        txtMedia.WordWrap = False
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(595, 504)
        Label3.Name = "Label3"
        Label3.Size = New Size(47, 17)
        Label3.TabIndex = 136
        Label3.Text = "Moda:"
        Label3.Visible = False
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(579, 454)
        Label2.Name = "Label2"
        Label2.Size = New Size(66, 17)
        Label2.TabIndex = 135
        Label2.Text = "Mediana:"
        Label2.Visible = False
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(595, 406)
        Label1.Name = "Label1"
        Label1.Size = New Size(50, 17)
        Label1.TabIndex = 134
        Label1.Text = "Media:"
        Label1.Visible = False
        ' 
        ' txtPercentil
        ' 
        txtPercentil.Anchor = AnchorStyles.Top
        txtPercentil.Enabled = False
        txtPercentil.Location = New Point(847, 500)
        txtPercentil.Multiline = True
        txtPercentil.Name = "txtPercentil"
        txtPercentil.Size = New Size(88, 23)
        txtPercentil.TabIndex = 145
        txtPercentil.Visible = False
        ' 
        ' txtDecil
        ' 
        txtDecil.Anchor = AnchorStyles.Top
        txtDecil.Enabled = False
        txtDecil.Location = New Point(847, 450)
        txtDecil.Multiline = True
        txtDecil.Name = "txtDecil"
        txtDecil.Size = New Size(88, 23)
        txtDecil.TabIndex = 144
        txtDecil.Visible = False
        ' 
        ' txtCuartil
        ' 
        txtCuartil.Anchor = AnchorStyles.Top
        txtCuartil.Enabled = False
        txtCuartil.Location = New Point(847, 400)
        txtCuartil.Multiline = True
        txtCuartil.Name = "txtCuartil"
        txtCuartil.Size = New Size(88, 23)
        txtCuartil.TabIndex = 143
        txtCuartil.Visible = False
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top
        Label6.AutoSize = True
        Label6.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(764, 505)
        Label6.Name = "Label6"
        Label6.Size = New Size(77, 17)
        Label6.TabIndex = 142
        Label6.Text = "Percenctil:"
        Label6.Visible = False
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(796, 451)
        Label5.Name = "Label5"
        Label5.Size = New Size(45, 17)
        Label5.TabIndex = 141
        Label5.Text = "Decil:"
        Label5.Visible = False
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(787, 401)
        Label4.Name = "Label4"
        Label4.Size = New Size(54, 17)
        Label4.TabIndex = 140
        Label4.Text = "Cuartil:"
        Label4.Visible = False
        ' 
        ' txtPersintilCalcular
        ' 
        txtPersintilCalcular.Anchor = AnchorStyles.Top
        txtPersintilCalcular.Location = New Point(1104, 493)
        txtPersintilCalcular.Multiline = True
        txtPersintilCalcular.Name = "txtPersintilCalcular"
        txtPersintilCalcular.Size = New Size(62, 23)
        txtPersintilCalcular.TabIndex = 151
        txtPersintilCalcular.Visible = False
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Top
        Label10.AutoSize = True
        Label10.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(959, 497)
        Label10.Name = "Label10"
        Label10.Size = New Size(139, 17)
        Label10.TabIndex = 150
        Label10.Text = "Persentil a Calcular:"
        Label10.Visible = False
        ' 
        ' txtDecilCalcular
        ' 
        txtDecilCalcular.Anchor = AnchorStyles.Top
        txtDecilCalcular.Location = New Point(1104, 439)
        txtDecilCalcular.Multiline = True
        txtDecilCalcular.Name = "txtDecilCalcular"
        txtDecilCalcular.Size = New Size(62, 23)
        txtDecilCalcular.TabIndex = 149
        txtDecilCalcular.Visible = False
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.Top
        Label11.AutoSize = True
        Label11.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(968, 438)
        Label11.Name = "Label11"
        Label11.Size = New Size(115, 17)
        Label11.TabIndex = 148
        Label11.Text = "Decil a Calcular:"
        Label11.Visible = False
        ' 
        ' txtCuartilCalcular
        ' 
        txtCuartilCalcular.Anchor = AnchorStyles.Top
        txtCuartilCalcular.Location = New Point(1104, 399)
        txtCuartilCalcular.Multiline = True
        txtCuartilCalcular.Name = "txtCuartilCalcular"
        txtCuartilCalcular.Size = New Size(62, 23)
        txtCuartilCalcular.TabIndex = 147
        txtCuartilCalcular.Visible = False
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top
        Label9.AutoSize = True
        Label9.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(959, 400)
        Label9.Name = "Label9"
        Label9.Size = New Size(124, 17)
        Label9.TabIndex = 146
        Label9.Text = "Cuartil a Calcular:"
        Label9.Visible = False
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top
        Label7.AutoSize = True
        Label7.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(1211, 411)
        Label7.Name = "Label7"
        Label7.Size = New Size(126, 17)
        Label7.TabIndex = 153
        Label7.Text = "Desviación Media:"
        Label7.Visible = False
        ' 
        ' txtDesviacionMedia
        ' 
        txtDesviacionMedia.Anchor = AnchorStyles.Top
        txtDesviacionMedia.Enabled = False
        txtDesviacionMedia.Location = New Point(1349, 405)
        txtDesviacionMedia.Multiline = True
        txtDesviacionMedia.Name = "txtDesviacionMedia"
        txtDesviacionMedia.Size = New Size(88, 23)
        txtDesviacionMedia.TabIndex = 154
        txtDesviacionMedia.Visible = False
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top
        Label8.AutoSize = True
        Label8.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(1190, 466)
        Label8.Name = "Label8"
        Label8.Size = New Size(147, 17)
        Label8.TabIndex = 155
        Label8.Text = "Desviación Estandar:"
        Label8.Visible = False
        ' 
        ' txtDesviacionEstantar
        ' 
        txtDesviacionEstantar.Anchor = AnchorStyles.Top
        txtDesviacionEstantar.Enabled = False
        txtDesviacionEstantar.Location = New Point(1349, 453)
        txtDesviacionEstantar.Multiline = True
        txtDesviacionEstantar.Name = "txtDesviacionEstantar"
        txtDesviacionEstantar.Size = New Size(88, 23)
        txtDesviacionEstantar.TabIndex = 156
        txtDesviacionEstantar.Visible = False
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
        btnComentarioCentral.Location = New Point(599, 536)
        btnComentarioCentral.Name = "btnComentarioCentral"
        btnComentarioCentral.Size = New Size(169, 29)
        btnComentarioCentral.TabIndex = 163
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
        btnComentarioPosicion.Location = New Point(932, 536)
        btnComentarioPosicion.Name = "btnComentarioPosicion"
        btnComentarioPosicion.Size = New Size(185, 29)
        btnComentarioPosicion.TabIndex = 164
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
        btnComentarioDispersion.Location = New Point(1251, 536)
        btnComentarioDispersion.Name = "btnComentarioDispersion"
        btnComentarioDispersion.Size = New Size(200, 29)
        btnComentarioDispersion.TabIndex = 165
        btnComentarioDispersion.Text = "Generar Comentario"
        btnComentarioDispersion.UseVisualStyleBackColor = True
        btnComentarioDispersion.Visible = False
        ' 
        ' Label15
        ' 
        Label15.Anchor = AnchorStyles.Top
        Label15.AutoSize = True
        Label15.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(768, 595)
        Label15.Name = "Label15"
        Label15.Size = New Size(172, 17)
        Label15.TabIndex = 166
        Label15.Text = "Interpretación resultados:"
        Label15.Visible = False
        ' 
        ' txtComentario1
        ' 
        txtComentario1.Anchor = AnchorStyles.Top
        txtComentario1.Enabled = False
        txtComentario1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtComentario1.Location = New Point(750, 628)
        txtComentario1.Multiline = True
        txtComentario1.Name = "txtComentario1"
        txtComentario1.Size = New Size(583, 35)
        txtComentario1.TabIndex = 167
        txtComentario1.Visible = False
        ' 
        ' txtComentario2
        ' 
        txtComentario2.Anchor = AnchorStyles.Top
        txtComentario2.Enabled = False
        txtComentario2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtComentario2.Location = New Point(750, 679)
        txtComentario2.Multiline = True
        txtComentario2.Name = "txtComentario2"
        txtComentario2.Size = New Size(583, 35)
        txtComentario2.TabIndex = 168
        txtComentario2.Visible = False
        ' 
        ' txtComentario3
        ' 
        txtComentario3.Anchor = AnchorStyles.Top
        txtComentario3.Enabled = False
        txtComentario3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtComentario3.Location = New Point(750, 730)
        txtComentario3.Multiline = True
        txtComentario3.Name = "txtComentario3"
        txtComentario3.Size = New Size(583, 35)
        txtComentario3.TabIndex = 169
        txtComentario3.Visible = False
        ' 
        ' txtFrecuencia
        ' 
        txtFrecuencia.Anchor = AnchorStyles.Top
        txtFrecuencia.Location = New Point(48, 160)
        txtFrecuencia.Multiline = True
        txtFrecuencia.Name = "txtFrecuencia"
        txtFrecuencia.ScrollBars = ScrollBars.Vertical
        txtFrecuencia.Size = New Size(455, 69)
        txtFrecuencia.TabIndex = 170
        ' 
        ' Label16
        ' 
        Label16.Anchor = AnchorStyles.Top
        Label16.AutoSize = True
        Label16.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label16.Location = New Point(59, 140)
        Label16.Name = "Label16"
        Label16.Size = New Size(171, 17)
        Label16.TabIndex = 171
        Label16.Text = "Ingrese la Frecuencia (F)"
        ' 
        ' txtClase
        ' 
        txtClase.Anchor = AnchorStyles.Top
        txtClase.Location = New Point(48, 67)
        txtClase.Multiline = True
        txtClase.Name = "txtClase"
        txtClase.ScrollBars = ScrollBars.Vertical
        txtClase.Size = New Size(455, 69)
        txtClase.TabIndex = 78
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
        btnLimpiar.Location = New Point(399, 236)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(69, 29)
        btnLimpiar.TabIndex = 172
        btnLimpiar.Text = "Limpiar"
        btnLimpiar.UseVisualStyleBackColor = True
        ' 
        ' lbGrafica
        ' 
        lbGrafica.Anchor = AnchorStyles.Top
        lbGrafica.AutoSize = True
        lbGrafica.Font = New Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbGrafica.Location = New Point(181, 301)
        lbGrafica.Name = "lbGrafica"
        lbGrafica.Size = New Size(95, 29)
        lbGrafica.TabIndex = 173
        lbGrafica.Text = "Gráfica"
        lbGrafica.Visible = False
        ' 
        ' Panel1
        ' 
        Panel1.AutoScroll = True
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(12, 335)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(566, 430)
        Panel1.TabIndex = 174
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
        ' btnGrafica1
        ' 
        btnGrafica1.AccessibleRole = AccessibleRole.None
        btnGrafica1.Anchor = AnchorStyles.Top
        btnGrafica1.FlatAppearance.BorderSize = 0
        btnGrafica1.FlatStyle = FlatStyle.Flat
        btnGrafica1.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnGrafica1.ForeColor = Color.Black
        btnGrafica1.ImageAlign = ContentAlignment.MiddleLeft
        btnGrafica1.Location = New Point(768, 301)
        btnGrafica1.Name = "btnGrafica1"
        btnGrafica1.Size = New Size(157, 29)
        btnGrafica1.TabIndex = 175
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
        btnGrafica2.Location = New Point(941, 301)
        btnGrafica2.Name = "btnGrafica2"
        btnGrafica2.Size = New Size(157, 29)
        btnGrafica2.TabIndex = 176
        btnGrafica2.Text = "Generar Grafica"
        btnGrafica2.UseVisualStyleBackColor = True
        btnGrafica2.Visible = False
        ' 
        ' frmMeddidas2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1495, 814)
        Controls.Add(btnGrafica2)
        Controls.Add(btnGrafica1)
        Controls.Add(Panel1)
        Controls.Add(lbGrafica)
        Controls.Add(btnLimpiar)
        Controls.Add(Label16)
        Controls.Add(txtFrecuencia)
        Controls.Add(txtComentario3)
        Controls.Add(txtComentario2)
        Controls.Add(txtComentario1)
        Controls.Add(Label15)
        Controls.Add(btnComentarioDispersion)
        Controls.Add(btnComentarioPosicion)
        Controls.Add(btnComentarioCentral)
        Controls.Add(txtDesviacionEstantar)
        Controls.Add(Label8)
        Controls.Add(txtDesviacionMedia)
        Controls.Add(Label7)
        Controls.Add(txtPersintilCalcular)
        Controls.Add(Label10)
        Controls.Add(txtDecilCalcular)
        Controls.Add(Label11)
        Controls.Add(txtCuartilCalcular)
        Controls.Add(Label9)
        Controls.Add(txtPercentil)
        Controls.Add(txtDecil)
        Controls.Add(txtCuartil)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(txtModa)
        Controls.Add(txtMediana)
        Controls.Add(txtMedia)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnDispersion)
        Controls.Add(btnPosicion)
        Controls.Add(btnCentral)
        Controls.Add(btnSiguiente)
        Controls.Add(btnCancelar)
        Controls.Add(btnNuevo)
        Controls.Add(dtTabla)
        Controls.Add(btnInvervalos)
        Controls.Add(btnSimple)
        Controls.Add(btnRregresar)
        Controls.Add(txtCantidadDatos)
        Controls.Add(Label19)
        Controls.Add(txtClase)
        Controls.Add(Label18)
        Name = "frmMeddidas2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmMeddidas2"
        CType(dtTabla, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents txtCantidadDatos As TextBox
    Friend WithEvents btnRregresar As Button
    Friend WithEvents btnSimple As Button
    Friend WithEvents btnInvervalos As Button
    Friend WithEvents dtTabla As DataGridView
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnCentral As Button
    Friend WithEvents btnPosicion As Button
    Friend WithEvents btnDispersion As Button
    Friend WithEvents txtModa As TextBox
    Friend WithEvents txtMediana As TextBox
    Friend WithEvents txtMedia As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPercentil As TextBox
    Friend WithEvents txtDecil As TextBox
    Friend WithEvents txtCuartil As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPersintilCalcular As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtDecilCalcular As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtCuartilCalcular As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDesviacionMedia As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtDesviacionEstantar As TextBox
    Friend WithEvents btnComentarioCentral As Button
    Friend WithEvents btnComentarioPosicion As Button
    Friend WithEvents btnComentarioDispersion As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents txtComentario1 As TextBox
    Friend WithEvents txtComentario2 As TextBox
    Friend WithEvents txtComentario3 As TextBox
    Friend WithEvents txtFrecuencia As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtClase As TextBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents lbGrafica As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnGrafica1 As Button
    Friend WithEvents btnGrafica2 As Button
End Class
