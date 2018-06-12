<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Maximaze_Button = New System.Windows.Forms.Button()
        Me.Close_Button = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Minimaze_Button = New System.Windows.Forms.Button()
        Me.LeftR = New System.Windows.Forms.Panel()
        Me.UpR = New System.Windows.Forms.Panel()
        Me.RightR = New System.Windows.Forms.Panel()
        Me.DownR = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Tab2ButtonPic = New System.Windows.Forms.PictureBox()
        Me.Tab2Button = New System.Windows.Forms.Button()
        Me.Tab1ButtonPic = New System.Windows.Forms.PictureBox()
        Me.Tab1Button = New System.Windows.Forms.Button()
        Me.Tab0ButtonPic = New System.Windows.Forms.PictureBox()
        Me.Tab0Button = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.Tab2ButtonPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tab1ButtonPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tab0ButtonPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Maximaze_Button)
        Me.Panel1.Controls.Add(Me.Close_Button)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Minimaze_Button)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(796, 60)
        Me.Panel1.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(106, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(678, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "New and Recent"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PictureBox1.Location = New System.Drawing.Point(99, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1, 28)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Maximaze_Button
        '
        Me.Maximaze_Button.BackgroundImage = Global.Spez_News.My.Resources.Resources.fullscreen
        Me.Maximaze_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Maximaze_Button.FlatAppearance.BorderSize = 0
        Me.Maximaze_Button.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Maximaze_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Maximaze_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Maximaze_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Maximaze_Button.Location = New System.Drawing.Point(64, 20)
        Me.Maximaze_Button.Name = "Maximaze_Button"
        Me.Maximaze_Button.Size = New System.Drawing.Size(20, 20)
        Me.Maximaze_Button.TabIndex = 0
        Me.Maximaze_Button.UseVisualStyleBackColor = True
        '
        'Close_Button
        '
        Me.Close_Button.BackgroundImage = Global.Spez_News.My.Resources.Resources.close
        Me.Close_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Close_Button.FlatAppearance.BorderSize = 0
        Me.Close_Button.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Close_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Close_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Close_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Close_Button.Location = New System.Drawing.Point(12, 21)
        Me.Close_Button.Name = "Close_Button"
        Me.Close_Button.Size = New System.Drawing.Size(20, 20)
        Me.Close_Button.TabIndex = 0
        Me.Close_Button.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(754, 14)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(30, 30)
        Me.Button5.TabIndex = 0
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Minimaze_Button
        '
        Me.Minimaze_Button.BackgroundImage = Global.Spez_News.My.Resources.Resources.minimize
        Me.Minimaze_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Minimaze_Button.FlatAppearance.BorderSize = 0
        Me.Minimaze_Button.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Minimaze_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Minimaze_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Minimaze_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Minimaze_Button.Location = New System.Drawing.Point(38, 21)
        Me.Minimaze_Button.Name = "Minimaze_Button"
        Me.Minimaze_Button.Size = New System.Drawing.Size(20, 20)
        Me.Minimaze_Button.TabIndex = 0
        Me.Minimaze_Button.UseVisualStyleBackColor = True
        '
        'LeftR
        '
        Me.LeftR.BackColor = System.Drawing.Color.Transparent
        Me.LeftR.Cursor = System.Windows.Forms.Cursors.SizeWE
        Me.LeftR.Dock = System.Windows.Forms.DockStyle.Left
        Me.LeftR.Location = New System.Drawing.Point(0, 2)
        Me.LeftR.Name = "LeftR"
        Me.LeftR.Size = New System.Drawing.Size(2, 596)
        Me.LeftR.TabIndex = 17
        '
        'UpR
        '
        Me.UpR.BackColor = System.Drawing.Color.Transparent
        Me.UpR.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.UpR.Dock = System.Windows.Forms.DockStyle.Top
        Me.UpR.Location = New System.Drawing.Point(0, 0)
        Me.UpR.Name = "UpR"
        Me.UpR.Size = New System.Drawing.Size(798, 2)
        Me.UpR.TabIndex = 18
        '
        'RightR
        '
        Me.RightR.BackColor = System.Drawing.Color.Transparent
        Me.RightR.Cursor = System.Windows.Forms.Cursors.SizeWE
        Me.RightR.Dock = System.Windows.Forms.DockStyle.Right
        Me.RightR.Location = New System.Drawing.Point(798, 0)
        Me.RightR.Name = "RightR"
        Me.RightR.Size = New System.Drawing.Size(2, 598)
        Me.RightR.TabIndex = 19
        '
        'DownR
        '
        Me.DownR.BackColor = System.Drawing.Color.Transparent
        Me.DownR.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.DownR.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DownR.Location = New System.Drawing.Point(0, 598)
        Me.DownR.Name = "DownR"
        Me.DownR.Size = New System.Drawing.Size(800, 2)
        Me.DownR.TabIndex = 20
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Tab2ButtonPic)
        Me.Panel2.Controls.Add(Me.Tab2Button)
        Me.Panel2.Controls.Add(Me.Tab1ButtonPic)
        Me.Panel2.Controls.Add(Me.Tab1Button)
        Me.Panel2.Controls.Add(Me.Tab0ButtonPic)
        Me.Panel2.Controls.Add(Me.Tab0Button)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(2, 63)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 535)
        Me.Panel2.TabIndex = 21
        '
        'Tab2ButtonPic
        '
        Me.Tab2ButtonPic.BackColor = System.Drawing.Color.Transparent
        Me.Tab2ButtonPic.BackgroundImage = Global.Spez_News.My.Resources.Resources.settings_nonactive
        Me.Tab2ButtonPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Tab2ButtonPic.Location = New System.Drawing.Point(6, 79)
        Me.Tab2ButtonPic.Name = "Tab2ButtonPic"
        Me.Tab2ButtonPic.Size = New System.Drawing.Size(27, 27)
        Me.Tab2ButtonPic.TabIndex = 27
        Me.Tab2ButtonPic.TabStop = False
        '
        'Tab2Button
        '
        Me.Tab2Button.BackColor = System.Drawing.Color.Transparent
        Me.Tab2Button.FlatAppearance.BorderSize = 0
        Me.Tab2Button.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSkyBlue
        Me.Tab2Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue
        Me.Tab2Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.Tab2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Tab2Button.Location = New System.Drawing.Point(-2, 75)
        Me.Tab2Button.Name = "Tab2Button"
        Me.Tab2Button.Size = New System.Drawing.Size(202, 33)
        Me.Tab2Button.TabIndex = 26
        Me.Tab2Button.Text = "             Settings"
        Me.Tab2Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Tab2Button.UseVisualStyleBackColor = False
        '
        'Tab1ButtonPic
        '
        Me.Tab1ButtonPic.BackColor = System.Drawing.Color.Transparent
        Me.Tab1ButtonPic.BackgroundImage = Global.Spez_News.My.Resources.Resources.list_nonactive
        Me.Tab1ButtonPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Tab1ButtonPic.Location = New System.Drawing.Point(6, 40)
        Me.Tab1ButtonPic.Name = "Tab1ButtonPic"
        Me.Tab1ButtonPic.Size = New System.Drawing.Size(27, 27)
        Me.Tab1ButtonPic.TabIndex = 25
        Me.Tab1ButtonPic.TabStop = False
        '
        'Tab1Button
        '
        Me.Tab1Button.BackColor = System.Drawing.Color.Transparent
        Me.Tab1Button.FlatAppearance.BorderSize = 0
        Me.Tab1Button.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSkyBlue
        Me.Tab1Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue
        Me.Tab1Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.Tab1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Tab1Button.Location = New System.Drawing.Point(-2, 36)
        Me.Tab1Button.Name = "Tab1Button"
        Me.Tab1Button.Size = New System.Drawing.Size(202, 33)
        Me.Tab1Button.TabIndex = 24
        Me.Tab1Button.Text = "             RSS List"
        Me.Tab1Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Tab1Button.UseVisualStyleBackColor = False
        '
        'Tab0ButtonPic
        '
        Me.Tab0ButtonPic.BackColor = System.Drawing.Color.Transparent
        Me.Tab0ButtonPic.BackgroundImage = Global.Spez_News.My.Resources.Resources.rss_nonactive
        Me.Tab0ButtonPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Tab0ButtonPic.Location = New System.Drawing.Point(6, 3)
        Me.Tab0ButtonPic.Name = "Tab0ButtonPic"
        Me.Tab0ButtonPic.Size = New System.Drawing.Size(27, 27)
        Me.Tab0ButtonPic.TabIndex = 23
        Me.Tab0ButtonPic.TabStop = False
        '
        'Tab0Button
        '
        Me.Tab0Button.BackColor = System.Drawing.Color.Transparent
        Me.Tab0Button.FlatAppearance.BorderSize = 0
        Me.Tab0Button.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSkyBlue
        Me.Tab0Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue
        Me.Tab0Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.Tab0Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Tab0Button.Location = New System.Drawing.Point(-2, -1)
        Me.Tab0Button.Name = "Tab0Button"
        Me.Tab0Button.Size = New System.Drawing.Size(202, 33)
        Me.Tab0Button.TabIndex = 23
        Me.Tab0Button.Text = "             Feed"
        Me.Tab0Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Tab0Button.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Location = New System.Drawing.Point(202, 63)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1, 535)
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.DimGray
        Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox3.Location = New System.Drawing.Point(2, 62)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(796, 1)
        Me.PictureBox3.TabIndex = 1
        Me.PictureBox3.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(203, 63)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.Size = New System.Drawing.Size(595, 535)
        Me.WebBrowser1.TabIndex = 22
        Me.WebBrowser1.Url = New System.Uri("", System.UriKind.Relative)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Spez_News.My.Resources.Resources.bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LeftR)
        Me.Controls.Add(Me.UpR)
        Me.Controls.Add(Me.RightR)
        Me.Controls.Add(Me.DownR)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.Tab2ButtonPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tab1ButtonPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tab0ButtonPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Maximaze_Button As System.Windows.Forms.Button
    Friend WithEvents Close_Button As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Minimaze_Button As System.Windows.Forms.Button
    Friend WithEvents LeftR As System.Windows.Forms.Panel
    Friend WithEvents UpR As System.Windows.Forms.Panel
    Friend WithEvents RightR As System.Windows.Forms.Panel
    Friend WithEvents DownR As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Tab0Button As System.Windows.Forms.Button
    Friend WithEvents Tab0ButtonPic As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Tab1ButtonPic As System.Windows.Forms.PictureBox
    Friend WithEvents Tab1Button As System.Windows.Forms.Button
    Friend WithEvents Tab2ButtonPic As System.Windows.Forms.PictureBox
    Friend WithEvents Tab2Button As System.Windows.Forms.Button
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser

End Class
