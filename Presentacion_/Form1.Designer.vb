<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Label3 = New Label()
        MenuStrip1 = New MenuStrip()
        OpcionesToolStripMenuItem = New ToolStripMenuItem()
        MedidasTendenciaCentralToolStripMenuItem = New ToolStripMenuItem()
        FormaNominalToolStripMenuItem = New ToolStripMenuItem()
        FormaConsolidadaToolStripMenuItem = New ToolStripMenuItem()
        RegresiónLinealSimpleToolStripMenuItem = New ToolStripMenuItem()
        ProbabilidadesDependientesToolStripMenuItem = New ToolStripMenuItem()
        Panel1 = New Panel()
        MenuStrip1.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(363, 261)
        Label3.Name = "Label3"
        Label3.Size = New Size(587, 42)
        Label3.TabIndex = 6
        Label3.Text = "Calculadora para Medidas de Tedencia Central, medidas de Posición, Varibilidad" & vbCrLf & "                      Regresión Lineal, Calculo de Probabilidades Dependientes."
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.White
        MenuStrip1.Items.AddRange(New ToolStripItem() {OpcionesToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1227, 24)
        MenuStrip1.TabIndex = 7
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' OpcionesToolStripMenuItem
        ' 
        OpcionesToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {MedidasTendenciaCentralToolStripMenuItem, RegresiónLinealSimpleToolStripMenuItem, ProbabilidadesDependientesToolStripMenuItem})
        OpcionesToolStripMenuItem.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        OpcionesToolStripMenuItem.Size = New Size(69, 20)
        OpcionesToolStripMenuItem.Text = "Opciones"
        ' 
        ' MedidasTendenciaCentralToolStripMenuItem
        ' 
        MedidasTendenciaCentralToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {FormaNominalToolStripMenuItem, FormaConsolidadaToolStripMenuItem})
        MedidasTendenciaCentralToolStripMenuItem.Name = "MedidasTendenciaCentralToolStripMenuItem"
        MedidasTendenciaCentralToolStripMenuItem.Size = New Size(335, 22)
        MedidasTendenciaCentralToolStripMenuItem.Text = "Medidas Tendencia Central, Posición, Variabilidad"
        ' 
        ' FormaNominalToolStripMenuItem
        ' 
        FormaNominalToolStripMenuItem.Name = "FormaNominalToolStripMenuItem"
        FormaNominalToolStripMenuItem.Size = New Size(271, 22)
        FormaNominalToolStripMenuItem.Text = "Ingreso De Datos Forma Nominal"
        ' 
        ' FormaConsolidadaToolStripMenuItem
        ' 
        FormaConsolidadaToolStripMenuItem.Name = "FormaConsolidadaToolStripMenuItem"
        FormaConsolidadaToolStripMenuItem.Size = New Size(271, 22)
        FormaConsolidadaToolStripMenuItem.Text = "Ingreso De Datos Forma Consolidada"
        ' 
        ' RegresiónLinealSimpleToolStripMenuItem
        ' 
        RegresiónLinealSimpleToolStripMenuItem.Name = "RegresiónLinealSimpleToolStripMenuItem"
        RegresiónLinealSimpleToolStripMenuItem.Size = New Size(335, 22)
        RegresiónLinealSimpleToolStripMenuItem.Text = "Regresión Lineal Simple"
        ' 
        ' ProbabilidadesDependientesToolStripMenuItem
        ' 
        ProbabilidadesDependientesToolStripMenuItem.Name = "ProbabilidadesDependientesToolStripMenuItem"
        ProbabilidadesDependientesToolStripMenuItem.Size = New Size(335, 22)
        ProbabilidadesDependientesToolStripMenuItem.Text = "Probabilidades Dependientes"
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.BackColor = Color.DarkCyan
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(0, 24)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1227, 557)
        Panel1.TabIndex = 8
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1227, 580)
        Controls.Add(Panel1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MedidasTendenciaCentralToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormaNominalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormaConsolidadaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegresiónLinealSimpleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProbabilidadesDependientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel

End Class
