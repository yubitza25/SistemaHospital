<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPrincipal
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
        GroupBox1 = New GroupBox()
        BtnCancelar = New Button()
        ComboBox1 = New ComboBox()
        BtnRegistrar = New Button()
        LblDoc = New Label()
        TxtTelefono = New TextBox()
        LblTelefono = New Label()
        MtbHora = New MaskedTextBox()
        LblHora = New Label()
        MonthCalendar1 = New MonthCalendar()
        LblFecha = New Label()
        CbEspecialidad = New ComboBox()
        LblEspecialidad = New Label()
        TxtDni = New TextBox()
        LblDni = New Label()
        TxtApellidos = New TextBox()
        LblApellidos = New Label()
        TxtNombre = New TextBox()
        LblNombre = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.Controls.Add(BtnCancelar)
        GroupBox1.Controls.Add(ComboBox1)
        GroupBox1.Controls.Add(BtnRegistrar)
        GroupBox1.Controls.Add(LblDoc)
        GroupBox1.Controls.Add(TxtTelefono)
        GroupBox1.Controls.Add(LblTelefono)
        GroupBox1.Controls.Add(MtbHora)
        GroupBox1.Controls.Add(LblHora)
        GroupBox1.Controls.Add(MonthCalendar1)
        GroupBox1.Controls.Add(LblFecha)
        GroupBox1.Controls.Add(CbEspecialidad)
        GroupBox1.Controls.Add(LblEspecialidad)
        GroupBox1.Controls.Add(TxtDni)
        GroupBox1.Controls.Add(LblDni)
        GroupBox1.Controls.Add(TxtApellidos)
        GroupBox1.Controls.Add(LblApellidos)
        GroupBox1.Controls.Add(TxtNombre)
        GroupBox1.Controls.Add(LblNombre)
        GroupBox1.Location = New Point(24, 16)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.Size = New Size(714, 804)
        GroupBox1.TabIndex = 11
        GroupBox1.TabStop = False
        ' 
        ' BtnCancelar
        ' 
        BtnCancelar.Font = New Font("Segoe UI", 10F)
        BtnCancelar.Location = New Point(593, 751)
        BtnCancelar.Margin = New Padding(3, 4, 3, 4)
        BtnCancelar.Name = "BtnCancelar"
        BtnCancelar.Size = New Size(86, 36)
        BtnCancelar.TabIndex = 14
        BtnCancelar.Text = "Cancelar"
        BtnCancelar.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = SystemColors.MenuBar
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(423, 325)
        ComboBox1.Margin = New Padding(3, 4, 3, 4)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(255, 28)
        ComboBox1.TabIndex = 23
        ' 
        ' BtnRegistrar
        ' 
        BtnRegistrar.BackColor = Color.White
        BtnRegistrar.Font = New Font("Segoe UI", 10F)
        BtnRegistrar.Location = New Point(45, 751)
        BtnRegistrar.Margin = New Padding(3, 4, 3, 4)
        BtnRegistrar.Name = "BtnRegistrar"
        BtnRegistrar.Size = New Size(86, 40)
        BtnRegistrar.TabIndex = 13
        BtnRegistrar.Text = "Registrar"
        BtnRegistrar.UseVisualStyleBackColor = False
        ' 
        ' LblDoc
        ' 
        LblDoc.AutoSize = True
        LblDoc.BackColor = Color.Transparent
        LblDoc.Location = New Point(424, 301)
        LblDoc.Name = "LblDoc"
        LblDoc.Size = New Size(58, 20)
        LblDoc.TabIndex = 22
        LblDoc.Text = "Doctor:"
        ' 
        ' TxtTelefono
        ' 
        TxtTelefono.BackColor = SystemColors.MenuBar
        TxtTelefono.ForeColor = SystemColors.ButtonShadow
        TxtTelefono.Location = New Point(422, 181)
        TxtTelefono.Margin = New Padding(3, 4, 3, 4)
        TxtTelefono.Name = "TxtTelefono"
        TxtTelefono.PlaceholderText = "Ingrese número de teléfono"
        TxtTelefono.Size = New Size(255, 27)
        TxtTelefono.TabIndex = 21
        ' 
        ' LblTelefono
        ' 
        LblTelefono.AutoSize = True
        LblTelefono.BackColor = Color.Transparent
        LblTelefono.Location = New Point(423, 157)
        LblTelefono.Name = "LblTelefono"
        LblTelefono.Size = New Size(70, 20)
        LblTelefono.TabIndex = 20
        LblTelefono.Text = "Teléfono:"
        ' 
        ' MtbHora
        ' 
        MtbHora.BackColor = SystemColors.MenuBar
        MtbHora.Location = New Point(255, 653)
        MtbHora.Margin = New Padding(3, 4, 3, 4)
        MtbHora.Mask = "00:00"
        MtbHora.Name = "MtbHora"
        MtbHora.Size = New Size(44, 27)
        MtbHora.TabIndex = 19
        MtbHora.ValidatingType = GetType(Date)
        ' 
        ' LblHora
        ' 
        LblHora.AutoSize = True
        LblHora.BackColor = Color.Transparent
        LblHora.Location = New Point(183, 664)
        LblHora.Name = "LblHora"
        LblHora.Size = New Size(45, 20)
        LblHora.TabIndex = 18
        LblHora.Text = "Hora:"
        ' 
        ' MonthCalendar1
        ' 
        MonthCalendar1.BackColor = SystemColors.MenuBar
        MonthCalendar1.Location = New Point(255, 417)
        MonthCalendar1.Margin = New Padding(10, 12, 10, 12)
        MonthCalendar1.Name = "MonthCalendar1"
        MonthCalendar1.TabIndex = 17
        ' 
        ' LblFecha
        ' 
        LblFecha.AutoSize = True
        LblFecha.BackColor = Color.Transparent
        LblFecha.Location = New Point(183, 417)
        LblFecha.Name = "LblFecha"
        LblFecha.Size = New Size(50, 20)
        LblFecha.TabIndex = 16
        LblFecha.Text = "Fecha:"
        ' 
        ' CbEspecialidad
        ' 
        CbEspecialidad.BackColor = SystemColors.MenuBar
        CbEspecialidad.FormattingEnabled = True
        CbEspecialidad.Location = New Point(43, 325)
        CbEspecialidad.Margin = New Padding(3, 4, 3, 4)
        CbEspecialidad.Name = "CbEspecialidad"
        CbEspecialidad.Size = New Size(255, 28)
        CbEspecialidad.TabIndex = 15
        ' 
        ' LblEspecialidad
        ' 
        LblEspecialidad.AutoSize = True
        LblEspecialidad.BackColor = Color.Transparent
        LblEspecialidad.Location = New Point(45, 301)
        LblEspecialidad.Name = "LblEspecialidad"
        LblEspecialidad.Size = New Size(96, 20)
        LblEspecialidad.TabIndex = 14
        LblEspecialidad.Text = "Especialidad:"
        ' 
        ' TxtDni
        ' 
        TxtDni.BackColor = SystemColors.MenuBar
        TxtDni.ForeColor = SystemColors.ButtonShadow
        TxtDni.Location = New Point(45, 185)
        TxtDni.Margin = New Padding(3, 4, 3, 4)
        TxtDni.Name = "TxtDni"
        TxtDni.PlaceholderText = "Ingrese número de Dni"
        TxtDni.Size = New Size(255, 27)
        TxtDni.TabIndex = 13
        ' 
        ' LblDni
        ' 
        LblDni.AutoSize = True
        LblDni.BackColor = Color.Transparent
        LblDni.Location = New Point(48, 161)
        LblDni.Name = "LblDni"
        LblDni.Size = New Size(38, 20)
        LblDni.TabIndex = 12
        LblDni.Text = "DNI:"
        ' 
        ' TxtApellidos
        ' 
        TxtApellidos.BackColor = SystemColors.MenuBar
        TxtApellidos.ForeColor = SystemColors.ButtonShadow
        TxtApellidos.Location = New Point(423, 79)
        TxtApellidos.Margin = New Padding(3, 4, 3, 4)
        TxtApellidos.Name = "TxtApellidos"
        TxtApellidos.PlaceholderText = "Ingrese Apellidos"
        TxtApellidos.Size = New Size(255, 27)
        TxtApellidos.TabIndex = 11
        ' 
        ' LblApellidos
        ' 
        LblApellidos.AutoSize = True
        LblApellidos.BackColor = Color.Transparent
        LblApellidos.Location = New Point(426, 53)
        LblApellidos.Name = "LblApellidos"
        LblApellidos.Size = New Size(75, 20)
        LblApellidos.TabIndex = 10
        LblApellidos.Text = "Apellidos:"
        ' 
        ' TxtNombre
        ' 
        TxtNombre.BackColor = SystemColors.MenuBar
        TxtNombre.ForeColor = SystemColors.ButtonShadow
        TxtNombre.Location = New Point(45, 80)
        TxtNombre.Margin = New Padding(3, 4, 3, 4)
        TxtNombre.Name = "TxtNombre"
        TxtNombre.PlaceholderText = "Ingrese nombre"
        TxtNombre.Size = New Size(255, 27)
        TxtNombre.TabIndex = 9
        ' 
        ' LblNombre
        ' 
        LblNombre.AutoSize = True
        LblNombre.BackColor = Color.Transparent
        LblNombre.Location = New Point(48, 57)
        LblNombre.Name = "LblNombre"
        LblNombre.Size = New Size(67, 20)
        LblNombre.TabIndex = 8
        LblNombre.Text = "Nombre:"
        ' 
        ' FrmPrincipal
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        BackgroundImage = My.Resources.Resources.marcAgua
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(752, 819)
        Controls.Add(GroupBox1)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Margin = New Padding(3, 4, 3, 4)
        Name = "FrmPrincipal"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Registrar Cita Médica"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CbEspecialidad As ComboBox
    Friend WithEvents LblEspecialidad As Label
    Friend WithEvents TxtDni As TextBox
    Friend WithEvents LblDni As Label
    Friend WithEvents TxtApellidos As TextBox
    Friend WithEvents LblApellidos As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents LblNombre As Label
    Friend WithEvents BtnRegistrar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents MtbHora As MaskedTextBox
    Friend WithEvents LblHora As Label
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents LblFecha As Label
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents LblTelefono As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents LblDoc As Label

End Class
