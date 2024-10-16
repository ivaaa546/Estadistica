Imports System.Runtime.InteropServices

Public Class frmPrincipal
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub




    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub PanelContenedor_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click
        btnMaximizar.Visible = False
        btnRestaurar.Visible = True
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        btnRestaurar.Visible = False
        btnMaximizar.Visible = True
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub BtnMinimizar_Click(sender As Object, e As EventArgs) Handles BtnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PanelCabecera_Paint(sender As Object, e As PaintEventArgs) Handles PanelCabecera.Paint

    End Sub

    Private Sub PanelCabecera_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelCabecera.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub tmOcultarMenu_Tick(sender As Object, e As EventArgs) Handles tmOcultarMenu.Tick
        If PanelMenu.Width <= 60 Then
            Me.tmOcultarMenu.Enabled = False
        Else
            Me.PanelMenu.Width = PanelMenu.Width - 5
        End If
    End Sub

    Private Sub tmMostrarMenu_Tick(sender As Object, e As EventArgs) Handles tmMostrarMenu.Tick
        If PanelMenu.Width >= 246 Then
            Me.tmMostrarMenu.Enabled = False
        Else
            Me.PanelMenu.Width = PanelMenu.Width + 5
        End If
    End Sub

    Private Sub btnMenu1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AbrirFormEnPanel(ByVal Formhijo As Object)
        If Me.PanelContenedor.Controls.Count > 0 Then Me.PanelContenedor.Controls.RemoveAt(0)
        Dim fh As Form = TryCast(Formhijo, Form)
        fh.TopLevel = False
        fh.FormBorderStyle = FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        Me.PanelContenedor.Controls.Add(fh)
        Me.PanelContenedor.Tag = fh
        fh.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        AbrirFormEnPanel(New frmMDCentral)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        AbrirFormEnPanel(New frmMDCentral)
    End Sub

    Private Sub PanelContenedor_Paint_1(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        If PanelMenu.Width = 246 Then
            tmOcultarMenu.Enabled = True
        ElseIf PanelMenu.Width = 60 Then
            tmMostrarMenu.Enabled = True
        End If
    End Sub

    Private Sub PanelMenu_Paint(sender As Object, e As PaintEventArgs) Handles PanelMenu.Paint

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        AbrirFormEnPanel(New frmCentralDispersionPosicion)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        AbrirFormEnPanel(New frmNominal)
    End Sub
End Class
