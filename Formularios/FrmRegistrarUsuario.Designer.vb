<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegistrarUsuario
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
        CbRol = New ComboBox()
        LblNombres = New Label()
        LblApellidoPaterno = New Label()
        txtNombre = New TextBox()
        txtApellidoPaterno = New TextBox()
        LblApellidoMaterno = New Label()
        LblDni = New Label()
        LblFechaNac = New Label()
        LblUsuario = New Label()
        LblConfirmarContraseña = New Label()
        LblContraseña = New Label()
        txtApellidoMaterno = New TextBox()
        txtUsuario = New TextBox()
        txtContraseña = New TextBox()
        txtConfirmarContraseña = New TextBox()
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        DateTimePicker1 = New DateTimePicker()
        txtDni = New TextBox()
        Panel2 = New Panel()
        Button1 = New Button()
        Label9 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' CbRol
        ' 
        CbRol.FormattingEnabled = True
        CbRol.Items.AddRange(New Object() {"Administrador", "Medico", "Secretario"})
        CbRol.Location = New Point(26, 13)
        CbRol.Name = "CbRol"
        CbRol.Size = New Size(139, 23)
        CbRol.TabIndex = 1
        ' 
        ' LblNombres
        ' 
        LblNombres.AutoSize = True
        LblNombres.Location = New Point(26, 50)
        LblNombres.Name = "LblNombres"
        LblNombres.Size = New Size(56, 15)
        LblNombres.TabIndex = 2
        LblNombres.Text = "Nombres"
        ' 
        ' LblApellidoPaterno
        ' 
        LblApellidoPaterno.AutoSize = True
        LblApellidoPaterno.Location = New Point(26, 99)
        LblApellidoPaterno.Name = "LblApellidoPaterno"
        LblApellidoPaterno.Size = New Size(95, 15)
        LblApellidoPaterno.TabIndex = 3
        LblApellidoPaterno.Text = "Apellido Paterno"
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(27, 68)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(265, 23)
        txtNombre.TabIndex = 4
        ' 
        ' txtApellidoPaterno
        ' 
        txtApellidoPaterno.Location = New Point(27, 117)
        txtApellidoPaterno.Name = "txtApellidoPaterno"
        txtApellidoPaterno.Size = New Size(265, 23)
        txtApellidoPaterno.TabIndex = 5
        ' 
        ' LblApellidoMaterno
        ' 
        LblApellidoMaterno.AutoSize = True
        LblApellidoMaterno.Location = New Point(27, 156)
        LblApellidoMaterno.Name = "LblApellidoMaterno"
        LblApellidoMaterno.Size = New Size(99, 15)
        LblApellidoMaterno.TabIndex = 6
        LblApellidoMaterno.Text = "Apellido Materno"
        ' 
        ' LblDni
        ' 
        LblDni.AutoSize = True
        LblDni.Location = New Point(27, 212)
        LblDni.Name = "LblDni"
        LblDni.Size = New Size(25, 15)
        LblDni.TabIndex = 7
        LblDni.Text = "Dni"
        ' 
        ' LblFechaNac
        ' 
        LblFechaNac.AutoSize = True
        LblFechaNac.Location = New Point(26, 263)
        LblFechaNac.Name = "LblFechaNac"
        LblFechaNac.Size = New Size(119, 15)
        LblFechaNac.TabIndex = 8
        LblFechaNac.Text = "Fecha de Nacimiento"
        ' 
        ' LblUsuario
        ' 
        LblUsuario.AutoSize = True
        LblUsuario.Location = New Point(27, 50)
        LblUsuario.Name = "LblUsuario"
        LblUsuario.Size = New Size(110, 15)
        LblUsuario.TabIndex = 9
        LblUsuario.Text = "Nombre de Usuario"
        ' 
        ' LblConfirmarContraseña
        ' 
        LblConfirmarContraseña.AutoSize = True
        LblConfirmarContraseña.Location = New Point(27, 156)
        LblConfirmarContraseña.Name = "LblConfirmarContraseña"
        LblConfirmarContraseña.Size = New Size(124, 15)
        LblConfirmarContraseña.TabIndex = 10
        LblConfirmarContraseña.Text = "Confirmar Contraseña"
        ' 
        ' LblContraseña
        ' 
        LblContraseña.AutoSize = True
        LblContraseña.Location = New Point(27, 99)
        LblContraseña.Name = "LblContraseña"
        LblContraseña.Size = New Size(67, 15)
        LblContraseña.TabIndex = 11
        LblContraseña.Text = "Contraseña"
        ' 
        ' txtApellidoMaterno
        ' 
        txtApellidoMaterno.Location = New Point(27, 174)
        txtApellidoMaterno.Name = "txtApellidoMaterno"
        txtApellidoMaterno.Size = New Size(265, 23)
        txtApellidoMaterno.TabIndex = 12
        ' 
        ' txtUsuario
        ' 
        txtUsuario.Location = New Point(27, 68)
        txtUsuario.Name = "txtUsuario"
        txtUsuario.Size = New Size(265, 23)
        txtUsuario.TabIndex = 13
        ' 
        ' txtContraseña
        ' 
        txtContraseña.Location = New Point(27, 117)
        txtContraseña.Name = "txtContraseña"
        txtContraseña.Size = New Size(265, 23)
        txtContraseña.TabIndex = 14
        ' 
        ' txtConfirmarContraseña
        ' 
        txtConfirmarContraseña.Location = New Point(27, 174)
        txtConfirmarContraseña.Name = "txtConfirmarContraseña"
        txtConfirmarContraseña.Size = New Size(265, 23)
        txtConfirmarContraseña.TabIndex = 15
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.logo1
        PictureBox1.Location = New Point(285, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(116, 103)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 16
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(DateTimePicker1)
        Panel1.Controls.Add(txtDni)
        Panel1.Controls.Add(LblApellidoMaterno)
        Panel1.Controls.Add(CbRol)
        Panel1.Controls.Add(LblNombres)
        Panel1.Controls.Add(LblFechaNac)
        Panel1.Controls.Add(LblApellidoPaterno)
        Panel1.Controls.Add(txtNombre)
        Panel1.Controls.Add(txtApellidoPaterno)
        Panel1.Controls.Add(LblDni)
        Panel1.Controls.Add(txtApellidoMaterno)
        Panel1.Location = New Point(34, 160)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(314, 318)
        Panel1.TabIndex = 17
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(26, 281)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(265, 23)
        DateTimePicker1.TabIndex = 16
        ' 
        ' txtDni
        ' 
        txtDni.Location = New Point(27, 230)
        txtDni.Name = "txtDni"
        txtDni.Size = New Size(265, 23)
        txtDni.TabIndex = 13
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(txtUsuario)
        Panel2.Controls.Add(txtContraseña)
        Panel2.Controls.Add(LblConfirmarContraseña)
        Panel2.Controls.Add(LblContraseña)
        Panel2.Controls.Add(txtConfirmarContraseña)
        Panel2.Controls.Add(LblUsuario)
        Panel2.Location = New Point(354, 160)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(325, 318)
        Panel2.TabIndex = 18
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DarkTurquoise
        Button1.Cursor = Cursors.Hand
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(258, 484)
        Button1.Name = "Button1"
        Button1.Size = New Size(176, 31)
        Button1.TabIndex = 19
        Button1.Text = "Registrar"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.FromArgb(CByte(43), CByte(155), CByte(227))
        Label9.Location = New Point(235, 118)
        Label9.Name = "Label9"
        Label9.Size = New Size(223, 23)
        Label9.TabIndex = 20
        Label9.Text = "Registrar nuevo usuario"
        ' 
        ' FrmRegistrarUsuario
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(708, 527)
        Controls.Add(Label9)
        Controls.Add(Button1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        Name = "FrmRegistrarUsuario"
        StartPosition = FormStartPosition.CenterScreen
        Text = "RegistrarUsuario"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents CbRol As ComboBox
    Friend WithEvents LblNombres As Label
    Friend WithEvents LblApellidoPaterno As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellidoPaterno As TextBox
    Friend WithEvents LblApellidoMaterno As Label
    Friend WithEvents LblDni As Label
    Friend WithEvents LblFechaNac As Label
    Friend WithEvents LblUsuario As Label
    Friend WithEvents LblConfirmarContraseña As Label
    Friend WithEvents LblContraseña As Label
    Friend WithEvents txtApellidoMaterno As TextBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents txtConfirmarContraseña As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtDni As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
