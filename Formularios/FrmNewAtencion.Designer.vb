<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNuevaAtencion
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
        GBox = New GroupBox()
        TextBox1 = New TextBox()
        ComboBox2 = New ComboBox()
        CbServicio = New ComboBox()
        TxtPaciente = New TextBox()
        TxtDocumento = New TextBox()
        BtnCancelar = New Button()
        BtnGuardar = New Button()
        BtnConsultar = New Button()
        LblCosto = New Label()
        LblEspecialista = New Label()
        LblServicio = New Label()
        Label2 = New Label()
        LblNroDocumento = New Label()
        GBox.SuspendLayout()
        SuspendLayout()
        ' 
        ' GBox
        ' 
        GBox.BackColor = Color.Transparent
        GBox.Controls.Add(TextBox1)
        GBox.Controls.Add(ComboBox2)
        GBox.Controls.Add(CbServicio)
        GBox.Controls.Add(TxtPaciente)
        GBox.Controls.Add(TxtDocumento)
        GBox.Controls.Add(BtnCancelar)
        GBox.Controls.Add(BtnGuardar)
        GBox.Controls.Add(BtnConsultar)
        GBox.Controls.Add(LblCosto)
        GBox.Controls.Add(LblEspecialista)
        GBox.Controls.Add(LblServicio)
        GBox.Controls.Add(Label2)
        GBox.Controls.Add(LblNroDocumento)
        GBox.Location = New Point(7, 16)
        GBox.Margin = New Padding(3, 4, 3, 4)
        GBox.Name = "GBox"
        GBox.Padding = New Padding(3, 4, 3, 4)
        GBox.Size = New Size(894, 568)
        GBox.TabIndex = 0
        GBox.TabStop = False
        GBox.Text = "Grupo de Nueva Atencion"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(622, 256)
        TextBox1.Margin = New Padding(3, 4, 3, 4)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(217, 27)
        TextBox1.TabIndex = 12
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"Linder Jesus Ramos Suarez", "Siesquen Merino Doris Yubitza", "Marlia Stefany Centurion"})
        ComboBox2.Location = New Point(309, 256)
        ComboBox2.Margin = New Padding(3, 4, 3, 4)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(241, 28)
        ComboBox2.TabIndex = 11
        ' 
        ' CbServicio
        ' 
        CbServicio.FormattingEnabled = True
        CbServicio.Items.AddRange(New Object() {"Medicina General S/ 10.00", "Pediatria S/ 25.00", "Oftalmologia S/15.00"})
        CbServicio.Location = New Point(27, 256)
        CbServicio.Margin = New Padding(3, 4, 3, 4)
        CbServicio.Name = "CbServicio"
        CbServicio.Size = New Size(241, 28)
        CbServicio.TabIndex = 10
        ' 
        ' TxtPaciente
        ' 
        TxtPaciente.Location = New Point(469, 100)
        TxtPaciente.Margin = New Padding(3, 4, 3, 4)
        TxtPaciente.Name = "TxtPaciente"
        TxtPaciente.Size = New Size(370, 27)
        TxtPaciente.TabIndex = 9
        ' 
        ' TxtDocumento
        ' 
        TxtDocumento.Location = New Point(27, 100)
        TxtDocumento.Margin = New Padding(3, 4, 3, 4)
        TxtDocumento.Name = "TxtDocumento"
        TxtDocumento.Size = New Size(387, 27)
        TxtDocumento.TabIndex = 8
        ' 
        ' BtnCancelar
        ' 
        BtnCancelar.Location = New Point(143, 319)
        BtnCancelar.Margin = New Padding(3, 4, 3, 4)
        BtnCancelar.Name = "BtnCancelar"
        BtnCancelar.Size = New Size(86, 31)
        BtnCancelar.TabIndex = 7
        BtnCancelar.Text = "Cancelar"
        BtnCancelar.UseVisualStyleBackColor = True
        ' 
        ' BtnGuardar
        ' 
        BtnGuardar.Location = New Point(27, 319)
        BtnGuardar.Margin = New Padding(3, 4, 3, 4)
        BtnGuardar.Name = "BtnGuardar"
        BtnGuardar.Size = New Size(86, 31)
        BtnGuardar.TabIndex = 6
        BtnGuardar.Text = "Guardar"
        BtnGuardar.UseVisualStyleBackColor = True
        ' 
        ' BtnConsultar
        ' 
        BtnConsultar.Location = New Point(27, 156)
        BtnConsultar.Margin = New Padding(3, 4, 3, 4)
        BtnConsultar.Name = "BtnConsultar"
        BtnConsultar.Size = New Size(86, 31)
        BtnConsultar.TabIndex = 5
        BtnConsultar.Text = "Consultar"
        BtnConsultar.UseVisualStyleBackColor = True
        ' 
        ' LblCosto
        ' 
        LblCosto.AutoSize = True
        LblCosto.Location = New Point(622, 217)
        LblCosto.Name = "LblCosto"
        LblCosto.Size = New Size(47, 20)
        LblCosto.TabIndex = 4
        LblCosto.Text = "Costo"
        ' 
        ' LblEspecialista
        ' 
        LblEspecialista.AutoSize = True
        LblEspecialista.Location = New Point(309, 217)
        LblEspecialista.Name = "LblEspecialista"
        LblEspecialista.Size = New Size(109, 20)
        LblEspecialista.TabIndex = 3
        LblEspecialista.Text = "Especialista (*):"
        ' 
        ' LblServicio
        ' 
        LblServicio.AutoSize = True
        LblServicio.Location = New Point(27, 217)
        LblServicio.Name = "LblServicio"
        LblServicio.Size = New Size(84, 20)
        LblServicio.TabIndex = 2
        LblServicio.Text = "Servicio (*):"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(469, 64)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 20)
        Label2.TabIndex = 1
        Label2.Text = "Paciente (*):"
        ' 
        ' LblNroDocumento
        ' 
        LblNroDocumento.AutoSize = True
        LblNroDocumento.Location = New Point(27, 64)
        LblNroDocumento.Name = "LblNroDocumento"
        LblNroDocumento.Size = New Size(189, 20)
        LblNroDocumento.TabIndex = 0
        LblNroDocumento.Text = "Numero de Documento (*):" & vbCrLf
        ' 
        ' FrmNuevaAtencion
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        BackgroundImage = My.Resources.Resources.fondo_Atencion_01
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(914, 600)
        Controls.Add(GBox)
        Margin = New Padding(3, 4, 3, 4)
        Name = "FrmNuevaAtencion"
        Text = "Nueva Atencion"
        GBox.ResumeLayout(False)
        GBox.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GBox As GroupBox
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnConsultar As Button
    Friend WithEvents LblCosto As Label
    Friend WithEvents LblEspecialista As Label
    Friend WithEvents LblServicio As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LblNroDocumento As Label
    Friend WithEvents CbServicio As ComboBox
    Friend WithEvents TxtPaciente As TextBox
    Friend WithEvents TxtDocumento As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox2 As ComboBox
End Class
