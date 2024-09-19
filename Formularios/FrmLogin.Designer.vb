<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogin
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
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        LblUsuario = New Label()
        LblContraseña = New Label()
        txtUsuario = New TextBox()
        txtContraseña = New TextBox()
        Panel1 = New Panel()
        Label3 = New Label()
        LbOlvidarContraseña = New LinkLabel()
        LinkLabel1 = New LinkLabel()
        CbRecordar = New CheckBox()
        btnRegistrarse = New Button()
        btnIniciarSesion = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.LOGIN1
        PictureBox1.Location = New Point(414, 25)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(556, 467)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PictureBox2.Image = My.Resources.Resources.logo1
        PictureBox2.Location = New Point(105, 20)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(154, 135)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' LblUsuario
        ' 
        LblUsuario.AutoSize = True
        LblUsuario.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblUsuario.ForeColor = Color.FromArgb(CByte(43), CByte(155), CByte(227))
        LblUsuario.Location = New Point(34, 203)
        LblUsuario.Name = "LblUsuario"
        LblUsuario.Size = New Size(62, 18)
        LblUsuario.TabIndex = 2
        LblUsuario.Text = "Usuario"
        ' 
        ' LblContraseña
        ' 
        LblContraseña.AutoSize = True
        LblContraseña.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblContraseña.ForeColor = Color.FromArgb(CByte(43), CByte(155), CByte(227))
        LblContraseña.Location = New Point(34, 263)
        LblContraseña.Name = "LblContraseña"
        LblContraseña.Size = New Size(93, 18)
        LblContraseña.TabIndex = 3
        LblContraseña.Text = "Contraseña"
        ' 
        ' txtUsuario
        ' 
        txtUsuario.AccessibleDescription = ""
        txtUsuario.BackColor = Color.White
        txtUsuario.ForeColor = Color.FromArgb(CByte(43), CByte(155), CByte(227))
        txtUsuario.Location = New Point(34, 226)
        txtUsuario.Name = "txtUsuario"
        txtUsuario.PlaceholderText = "Ingrese su usuario"
        txtUsuario.Size = New Size(278, 23)
        txtUsuario.TabIndex = 4
        ' 
        ' txtContraseña
        ' 
        txtContraseña.ForeColor = Color.FromArgb(CByte(43), CByte(155), CByte(227))
        txtContraseña.Location = New Point(34, 286)
        txtContraseña.Name = "txtContraseña"
        txtContraseña.PlaceholderText = "Ingrese su contraseña"
        txtContraseña.Size = New Size(278, 23)
        txtContraseña.TabIndex = 5
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(LbOlvidarContraseña)
        Panel1.Controls.Add(LinkLabel1)
        Panel1.Controls.Add(CbRecordar)
        Panel1.Controls.Add(btnRegistrarse)
        Panel1.Controls.Add(btnIniciarSesion)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(txtContraseña)
        Panel1.Controls.Add(LblUsuario)
        Panel1.Controls.Add(LblContraseña)
        Panel1.Controls.Add(txtUsuario)
        Panel1.Location = New Point(29, 25)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(364, 467)
        Panel1.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(43), CByte(155), CByte(227))
        Label3.Location = New Point(120, 172)
        Label3.Name = "Label3"
        Label3.Size = New Size(123, 23)
        Label3.TabIndex = 12
        Label3.Text = "¡Bienvenido!"
        ' 
        ' LbOlvidarContraseña
        ' 
        LbOlvidarContraseña.ActiveLinkColor = Color.DarkTurquoise
        LbOlvidarContraseña.AutoSize = True
        LbOlvidarContraseña.ForeColor = Color.Blue
        LbOlvidarContraseña.LinkColor = Color.FromArgb(CByte(43), CByte(155), CByte(227))
        LbOlvidarContraseña.Location = New Point(34, 331)
        LbOlvidarContraseña.Name = "LbOlvidarContraseña"
        LbOlvidarContraseña.Size = New Size(131, 15)
        LbOlvidarContraseña.TabIndex = 11
        LbOlvidarContraseña.TabStop = True
        LbOlvidarContraseña.Text = "Olvidaste tu contraseña"
        LbOlvidarContraseña.VisitedLinkColor = Color.DarkTurquoise
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.ActiveLinkColor = Color.Blue
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LinkLabel1.Location = New Point(43, 331)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(0, 16)
        LinkLabel1.TabIndex = 10
        ' 
        ' CbRecordar
        ' 
        CbRecordar.AutoSize = True
        CbRecordar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CbRecordar.ForeColor = Color.FromArgb(CByte(43), CByte(155), CByte(227))
        CbRecordar.Location = New Point(34, 359)
        CbRecordar.Name = "CbRecordar"
        CbRecordar.Size = New Size(142, 19)
        CbRecordar.TabIndex = 8
        CbRecordar.Text = "Recordar Contraseña"
        CbRecordar.UseVisualStyleBackColor = True
        ' 
        ' btnRegistrarse
        ' 
        btnRegistrarse.BackColor = Color.DarkTurquoise
        btnRegistrarse.Cursor = Cursors.Hand
        btnRegistrarse.FlatStyle = FlatStyle.Flat
        btnRegistrarse.Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        btnRegistrarse.ForeColor = Color.White
        btnRegistrarse.Location = New Point(198, 401)
        btnRegistrarse.Name = "btnRegistrarse"
        btnRegistrarse.Size = New Size(132, 32)
        btnRegistrarse.TabIndex = 7
        btnRegistrarse.Text = "Registrarse"
        btnRegistrarse.UseVisualStyleBackColor = False
        ' 
        ' btnIniciarSesion
        ' 
        btnIniciarSesion.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnIniciarSesion.BackColor = Color.DarkTurquoise
        btnIniciarSesion.Cursor = Cursors.Hand
        btnIniciarSesion.FlatStyle = FlatStyle.Flat
        btnIniciarSesion.Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        btnIniciarSesion.ForeColor = Color.White
        btnIniciarSesion.Location = New Point(34, 401)
        btnIniciarSesion.Name = "btnIniciarSesion"
        btnIniciarSesion.Size = New Size(132, 32)
        btnIniciarSesion.TabIndex = 6
        btnIniciarSesion.Text = "Iniciar Sesión"
        btnIniciarSesion.UseVisualStyleBackColor = False
        ' 
        ' login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(982, 517)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        Name = "login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LblUsuario As Label
    Friend WithEvents LblContraseña As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CbRecordar As CheckBox
    Friend WithEvents btnRegistrarse As Button
    Friend WithEvents btnIniciarSesion As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LbOlvidarContraseña As LinkLabel
    Friend WithEvents Label3 As Label

End Class
