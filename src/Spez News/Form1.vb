Imports System.Drawing.Text

Public Class Form1

    'Dim font1 As PrivateFontCollection = New PrivateFontCollection
    Dim selectedtab As Integer = 0
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Private Const WM_NCHITTEST As Integer = 132
    Private Const HTCLIENT As Integer = 1
    Private Const HTCAPTION As Integer = 2
    Private m_aeroEnabled As Boolean
    Private Const CS_DROPSHADOW As Integer = 131072
    Private Const WM_NCPAINT As Integer = 133
    Private Const WM_ACTIVATEAPP As Integer = 28

    <System.Runtime.InteropServices.DllImport("dwmapi.dll")>
    Public Shared Function DwmExtendFrameIntoClientArea(ByVal hWnd As IntPtr, ByRef pMarInset As MARGINS) As Integer
    End Function

    <System.Runtime.InteropServices.DllImport("dwmapi.dll")>
    Public Shared Function DwmSetWindowAttribute(ByVal hwnd As IntPtr, ByVal attr As Integer, ByRef attrValue As Integer, ByVal attrSize As Integer) As Integer
    End Function

    <System.Runtime.InteropServices.DllImport("dwmapi.dll")>
    Public Shared Function DwmIsCompositionEnabled(ByRef pfEnabled As Integer) As Integer
    End Function

    <System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Shared Function CreateRoundRectRgn(ByVal nLeftRect As Integer, ByVal nTopRect As Integer, ByVal nRightRect As Integer, ByVal nBottomRect As Integer, ByVal nWidthEllipse As Integer, ByVal nHeightEllipse As Integer) As IntPtr
    End Function

    Public Structure MARGINS

        Public leftWidth As Integer

        Public rightWidth As Integer

        Public topHeight As Integer

        Public bottomHeight As Integer
    End Structure

    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            m_aeroEnabled = CheckAeroEnabled()
            Dim cp As CreateParams = MyBase.CreateParams
            If Not m_aeroEnabled Then cp.ClassStyle = cp.ClassStyle Or CS_DROPSHADOW
            Return cp
        End Get
    End Property

    Private Function CheckAeroEnabled() As Boolean
        If Environment.OSVersion.Version.Major >= 6 Then
            Dim enabled As Integer = 0
            DwmIsCompositionEnabled(enabled)
            Return If((enabled = 1), True, False)
        End If

        Return False
    End Function

    Protected Overrides Sub WndProc(ByRef m As Message)
        Select Case m.Msg
            Case WM_NCPAINT
                If m_aeroEnabled Then
                    Dim v = 2
                    DwmSetWindowAttribute(Me.Handle, 2, v, 4)
                    Dim margins As MARGINS = New MARGINS() With {.bottomHeight = 1, .leftWidth = 0, .rightWidth = 0, .topHeight = 0}
                    DwmExtendFrameIntoClientArea(Me.Handle, margins)
                End If

            Case Else
        End Select

        MyBase.WndProc(m)
        If m.Msg = WM_NCHITTEST AndAlso CInt(m.Result) = HTCLIENT Then m.Result = CType(HTCAPTION, IntPtr)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WebBrowser1.Navigate(Application.StartupPath & "\data\feed.html")
    End Sub

    Private Sub Panel3_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles UpR.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Me.Size = New Size(Me.Size.Width, Me.Size.Height + (Me.Location.Y - MousePosition.Y))
            Me.Location = New Point(Me.Location.X, MousePosition.Y)
        End If
    End Sub

    Private Sub Panel5_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DownR.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Me.Size = New Size(Me.Size.Width, MousePosition.Y - Me.Location.Y)
        End If
    End Sub

    Private Sub Panel2_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LeftR.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Me.Size = New Size(Me.Size.Width + (Me.Location.X - MousePosition.X), Me.Size.Height)
            Me.Location = New Point(MousePosition.X, Me.Location.Y)
        End If
    End Sub

    Private Sub Panel4_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles RightR.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Me.Size = New Size(MousePosition.X - Me.Location.X, Me.Size.Height)
        End If
    End Sub

    Private Sub Close_Button_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Close_Button.MouseHover
        Close_Button.BackgroundImage = My.Resources.close_hover
    End Sub

    Private Sub Close_Button_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Close_Button.MouseLeave
        Close_Button.BackgroundImage = My.Resources.close
    End Sub

    Private Sub Minimize_Button_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Minimaze_Button.MouseHover
        Minimaze_Button.BackgroundImage = My.Resources.minimize_hover
    End Sub

    Private Sub Minimize_Button_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Minimaze_Button.MouseLeave
        Minimaze_Button.BackgroundImage = My.Resources.minimize
    End Sub

    Private Sub Maximize_Button_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Maximaze_Button.MouseHover
        Maximaze_Button.BackgroundImage = My.Resources.fullscreen_hover
    End Sub

    Private Sub Maximize_Button_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Maximaze_Button.MouseLeave
        Maximaze_Button.BackgroundImage = My.Resources.fullscreen
    End Sub

    Private Sub Panel1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown, Label1.MouseDown
        drag = True
        mousex = System.Windows.Forms.Cursor.Position.X - Me.Left
        mousey = System.Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Panel1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove, Label1.MouseMove
        If drag Then
            Me.Top = System.Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = System.Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Panel1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseUp, Label1.MouseUp
        drag = False
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Close_Button.Click
        Me.Close()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Minimaze_Button.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Maximaze_Button.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub Panel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel1.DoubleClick, Label1.DoubleClick
        Maximaze_Button.PerformClick()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If selectedtab = 0 Then
            WebBrowser1.Show()
            Tab0Button.BackColor = Color.DodgerBlue
            Tab0ButtonPic.BackColor = Color.DodgerBlue
            Tab0ButtonPic.BackgroundImage = My.Resources.rss_active
            Tab0Button.ForeColor = Color.White

            'ListView1.Hide()
            Tab1Button.BackColor = Color.Transparent
            Tab1ButtonPic.BackColor = Color.Transparent
            Tab1ButtonPic.BackgroundImage = My.Resources.list_nonactive
            Tab1Button.ForeColor = Color.Black

            'SettingsPanel.Hide()
            Tab2Button.BackColor = Color.Transparent
            Tab2ButtonPic.BackColor = Color.Transparent
            Tab2ButtonPic.BackgroundImage = My.Resources.settings_nonactive
            Tab2Button.ForeColor = Color.Black

        End If
        If selectedtab = 1 Then
            WebBrowser1.Hide()
            Tab0Button.BackColor = Color.Transparent
            Tab0ButtonPic.BackColor = Color.Transparent
            Tab0ButtonPic.BackgroundImage = My.Resources.rss_nonactive
            Tab0Button.ForeColor = Color.Black

            'ListView1.Show()
            Tab1Button.BackColor = Color.DodgerBlue
            Tab1ButtonPic.BackColor = Color.DodgerBlue
            Tab1ButtonPic.BackgroundImage = My.Resources.list_active
            Tab1Button.ForeColor = Color.White

            'SettingsPanel.Hide()
            Tab2Button.BackColor = Color.Transparent
            Tab2ButtonPic.BackColor = Color.Transparent
            Tab2ButtonPic.BackgroundImage = My.Resources.settings_nonactive
            Tab2Button.ForeColor = Color.Black

        End If
        If selectedtab = 2 Then
            WebBrowser1.Hide()
            Tab0Button.BackColor = Color.Transparent
            Tab0ButtonPic.BackColor = Color.Transparent
            Tab0ButtonPic.BackgroundImage = My.Resources.rss_nonactive
            Tab0Button.ForeColor = Color.Black

            'ListView1.Hide()
            Tab1Button.BackColor = Color.Transparent
            Tab1ButtonPic.BackColor = Color.Transparent
            Tab1ButtonPic.BackgroundImage = My.Resources.list_nonactive
            Tab1Button.ForeColor = Color.Black

            'SettingsPanel.Show()
            Tab2Button.BackColor = Color.DodgerBlue
            Tab2ButtonPic.BackColor = Color.DodgerBlue
            Tab2ButtonPic.BackgroundImage = My.Resources.settings_active
            Tab2Button.ForeColor = Color.White
        End If
    End Sub

    Private Sub Tab0Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tab0Button.Click
        Timer1.Enabled = True
        selectedtab = 0
    End Sub

    Private Sub Tab1Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tab1Button.Click
        Timer1.Enabled = True
        selectedtab = 1
    End Sub

    Private Sub Tab2Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tab2Button.Click
        Timer1.Enabled = True
        selectedtab = 2
    End Sub

    Private Sub Tab0Button_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tab0Button.MouseHover
        Timer1.Enabled = False
        Tab0ButtonPic.BackColor = Color.LightSkyBlue
        Tab0Button.BackColor = Color.LightSkyBlue
    End Sub

    Private Sub Tab1Button_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tab1Button.MouseHover
        Timer1.Enabled = False
        Tab1ButtonPic.BackColor = Color.LightSkyBlue
        Tab1Button.BackColor = Color.LightSkyBlue
    End Sub

    Private Sub Tab2Button_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tab2Button.MouseHover
        Timer1.Enabled = False
        Tab2ButtonPic.BackColor = Color.LightSkyBlue
    End Sub

    Private Sub Tab0Button_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tab0Button.MouseLeave
        Timer1.Enabled = True
    End Sub
End Class
