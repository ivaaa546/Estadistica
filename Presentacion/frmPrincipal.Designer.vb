<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        PanelCabecera = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        btnRestaurar = New Button()
        BtnMinimizar = New Button()
        btnMaximizar = New Button()
        btnCerrar = New Button()
        tmOcultarMenu = New Timer(components)
        tmMostrarMenu = New Timer(components)
        PanelMenu = New Panel()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        PanelContenedor = New Panel()
        PanelCabecera.SuspendLayout()
        PanelMenu.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelCabecera
        ' 
        PanelCabecera.BackColor = Color.SeaGreen
        PanelCabecera.Controls.Add(Label2)
        PanelCabecera.Controls.Add(Label1)
        PanelCabecera.Controls.Add(btnRestaurar)
        PanelCabecera.Controls.Add(BtnMinimizar)
        PanelCabecera.Controls.Add(btnMaximizar)
        PanelCabecera.Controls.Add(btnCerrar)
        PanelCabecera.Dock = DockStyle.Top
        PanelCabecera.Location = New Point(0, 0)
        PanelCabecera.Name = "PanelCabecera"
        PanelCabecera.Size = New Size(1136, 77)
        PanelCabecera.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(145, 38)
        Label2.Name = "Label2"
        Label2.Size = New Size(916, 34)
        Label2.TabIndex = 8
        Label2.Text = vbCrLf & "Calculadora para: Medidas de tendencia central, Meidad de Posición, Medidas de variabilidad, Regresión lineal simple y Cálculo de probabilidades " & vbCrLf
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(558, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(139, 29)
        Label1.TabIndex = 6
        Label1.Text = "Estadística"
        ' 
        ' btnRestaurar
        ' 
        btnRestaurar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnRestaurar.Cursor = Cursors.Hand
        btnRestaurar.FlatAppearance.BorderSize = 0
        btnRestaurar.FlatAppearance.MouseDownBackColor = Color.Silver
        btnRestaurar.FlatAppearance.MouseOverBackColor = Color.Red
        btnRestaurar.FlatStyle = FlatStyle.Flat
        btnRestaurar.Image = My.Resources.Resources.Icono_Restaurar
        btnRestaurar.Location = New Point(1041, 0)
        btnRestaurar.Name = "btnRestaurar"
        btnRestaurar.Size = New Size(40, 40)
        btnRestaurar.TabIndex = 3
        btnRestaurar.UseVisualStyleBackColor = True
        btnRestaurar.Visible = False
        ' 
        ' BtnMinimizar
        ' 
        BtnMinimizar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        BtnMinimizar.Cursor = Cursors.Hand
        BtnMinimizar.FlatAppearance.BorderSize = 0
        BtnMinimizar.FlatAppearance.MouseDownBackColor = Color.Silver
        BtnMinimizar.FlatAppearance.MouseOverBackColor = Color.Red
        BtnMinimizar.FlatStyle = FlatStyle.Flat
        BtnMinimizar.Image = My.Resources.Resources.Icono_Minimizar
        BtnMinimizar.Location = New Point(995, 0)
        BtnMinimizar.Name = "BtnMinimizar"
        BtnMinimizar.Size = New Size(40, 40)
        BtnMinimizar.TabIndex = 2
        BtnMinimizar.UseVisualStyleBackColor = True
        ' 
        ' btnMaximizar
        ' 
        btnMaximizar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnMaximizar.Cursor = Cursors.Hand
        btnMaximizar.FlatAppearance.BorderSize = 0
        btnMaximizar.FlatAppearance.MouseDownBackColor = Color.Silver
        btnMaximizar.FlatAppearance.MouseOverBackColor = Color.Red
        btnMaximizar.FlatStyle = FlatStyle.Flat
        btnMaximizar.Image = My.Resources.Resources.Icono_Maximizar
        btnMaximizar.Location = New Point(1041, 0)
        btnMaximizar.Name = "btnMaximizar"
        btnMaximizar.Size = New Size(40, 40)
        btnMaximizar.TabIndex = 1
        btnMaximizar.UseVisualStyleBackColor = True
        ' 
        ' btnCerrar
        ' 
        btnCerrar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnCerrar.Cursor = Cursors.Hand
        btnCerrar.FlatAppearance.BorderSize = 0
        btnCerrar.FlatAppearance.MouseDownBackColor = Color.Silver
        btnCerrar.FlatAppearance.MouseOverBackColor = Color.Red
        btnCerrar.FlatStyle = FlatStyle.Flat
        btnCerrar.Image = My.Resources.Resources.Icono_cerrar_FN
        btnCerrar.Location = New Point(1096, 0)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(40, 40)
        btnCerrar.TabIndex = 0
        btnCerrar.UseVisualStyleBackColor = True
        ' 
        ' tmOcultarMenu
        ' 
        ' 
        ' tmMostrarMenu
        ' 
        ' 
        ' PanelMenu
        ' 
        PanelMenu.BackColor = Color.FromArgb(CByte(37), CByte(46), CByte(59))
        PanelMenu.Controls.Add(Button3)
        PanelMenu.Controls.Add(Button2)
        PanelMenu.Controls.Add(Button1)
        PanelMenu.Dock = DockStyle.Left
        PanelMenu.Location = New Point(0, 77)
        PanelMenu.Name = "PanelMenu"
        PanelMenu.Size = New Size(218, 693)
        PanelMenu.TabIndex = 1
        ' 
        ' Button3
        ' 
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.White
        Button3.Image = My.Resources.Resources.statistics_15603448
        Button3.ImageAlign = ContentAlignment.MiddleLeft
        Button3.Location = New Point(0, 342)
        Button3.Name = "Button3"
        Button3.Size = New Size(250, 50)
        Button3.TabIndex = 2
        Button3.Text = "Cálculo de probabilidades"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.White
        Button2.Image = My.Resources.Resources.statistics_12176846
        Button2.ImageAlign = ContentAlignment.MiddleLeft
        Button2.Location = New Point(0, 239)
        Button2.Name = "Button2"
        Button2.Size = New Size(250, 50)
        Button2.TabIndex = 1
        Button2.Text = "Regresión lineal simple"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Image = My.Resources.Resources.dashboard_10445168
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Location = New Point(3, 130)
        Button1.Name = "Button1"
        Button1.Size = New Size(250, 50)
        Button1.TabIndex = 0
        Button1.Text = "Medidas Tendecia: " & vbCrLf & "Central, Dispersión y Posición"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' PanelContenedor
        ' 
        PanelContenedor.Dock = DockStyle.Fill
        PanelContenedor.Location = New Point(218, 77)
        PanelContenedor.Name = "PanelContenedor"
        PanelContenedor.Size = New Size(918, 693)
        PanelContenedor.TabIndex = 2
        ' 
        ' frmPrincipal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1136, 770)
        Controls.Add(PanelContenedor)
        Controls.Add(PanelMenu)
        Controls.Add(PanelCabecera)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmPrincipal"
        Text = "Form1"
        PanelCabecera.ResumeLayout(False)
        PanelCabecera.PerformLayout()
        PanelMenu.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelCabecera As Panel
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnMaximizar As Button
    Friend WithEvents BtnMinimizar As Button
    Friend WithEvents btnRestaurar As Button
    Friend WithEvents tmOcultarMenu As Timer
    Friend WithEvents tmMostrarMenu As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button

End Class
