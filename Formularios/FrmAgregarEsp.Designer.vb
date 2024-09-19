<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAgregarEsp
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
        LblIden = New Label()
        TxtIde = New TextBox()
        LblEspeciali = New Label()
        TxtEspeciali = New TextBox()
        LblDoc = New Label()
        TxtDoc = New TextBox()
        LblSala = New Label()
        TxtSala = New TextBox()
        BtnSeleccionar = New Button()
        BtnSeleSala = New Button()
        BtnGuardar = New Button()
        BtnCancelarEs = New Button()
        SuspendLayout()
        ' 
        ' LblIden
        ' 
        LblIden.AutoSize = True
        LblIden.Location = New Point(153, 53)
        LblIden.Name = "LblIden"
        LblIden.Size = New Size(21, 15)
        LblIden.TabIndex = 0
        LblIden.Text = "ID:"
        ' 
        ' TxtIde
        ' 
        TxtIde.Location = New Point(203, 50)
        TxtIde.Name = "TxtIde"
        TxtIde.Size = New Size(177, 23)
        TxtIde.TabIndex = 1
        ' 
        ' LblEspeciali
        ' 
        LblEspeciali.AutoSize = True
        LblEspeciali.Location = New Point(99, 104)
        LblEspeciali.Name = "LblEspeciali"
        LblEspeciali.Size = New Size(75, 15)
        LblEspeciali.TabIndex = 2
        LblEspeciali.Text = "Especialidad:"
        ' 
        ' TxtEspeciali
        ' 
        TxtEspeciali.Location = New Point(203, 103)
        TxtEspeciali.Name = "TxtEspeciali"
        TxtEspeciali.Size = New Size(177, 23)
        TxtEspeciali.TabIndex = 3
        ' 
        ' LblDoc
        ' 
        LblDoc.AutoSize = True
        LblDoc.Location = New Point(99, 161)
        LblDoc.Name = "LblDoc"
        LblDoc.Size = New Size(46, 15)
        LblDoc.TabIndex = 4
        LblDoc.Text = "Doctor:"
        ' 
        ' TxtDoc
        ' 
        TxtDoc.Location = New Point(203, 157)
        TxtDoc.Name = "TxtDoc"
        TxtDoc.Size = New Size(177, 23)
        TxtDoc.TabIndex = 5
        ' 
        ' LblSala
        ' 
        LblSala.AutoSize = True
        LblSala.Location = New Point(99, 213)
        LblSala.Name = "LblSala"
        LblSala.Size = New Size(31, 15)
        LblSala.TabIndex = 6
        LblSala.Text = "Sala:"
        ' 
        ' TxtSala
        ' 
        TxtSala.Location = New Point(203, 212)
        TxtSala.Name = "TxtSala"
        TxtSala.Size = New Size(177, 23)
        TxtSala.TabIndex = 7
        ' 
        ' BtnSeleccionar
        ' 
        BtnSeleccionar.Location = New Point(398, 157)
        BtnSeleccionar.Name = "BtnSeleccionar"
        BtnSeleccionar.Size = New Size(75, 23)
        BtnSeleccionar.TabIndex = 8
        BtnSeleccionar.Text = "Seleccionar"
        BtnSeleccionar.UseVisualStyleBackColor = True
        ' 
        ' BtnSeleSala
        ' 
        BtnSeleSala.Location = New Point(398, 213)
        BtnSeleSala.Name = "BtnSeleSala"
        BtnSeleSala.Size = New Size(75, 23)
        BtnSeleSala.TabIndex = 9
        BtnSeleSala.Text = "Seleccionar"
        BtnSeleSala.UseVisualStyleBackColor = True
        ' 
        ' BtnGuardar
        ' 
        BtnGuardar.Location = New Point(99, 313)
        BtnGuardar.Name = "BtnGuardar"
        BtnGuardar.Size = New Size(75, 23)
        BtnGuardar.TabIndex = 10
        BtnGuardar.Text = "Guardar"
        BtnGuardar.UseVisualStyleBackColor = True
        ' 
        ' BtnCancelarEs
        ' 
        BtnCancelarEs.Location = New Point(398, 313)
        BtnCancelarEs.Name = "BtnCancelarEs"
        BtnCancelarEs.Size = New Size(75, 23)
        BtnCancelarEs.TabIndex = 11
        BtnCancelarEs.Text = "Cancelar"
        BtnCancelarEs.UseVisualStyleBackColor = True
        ' 
        ' FrmAgregarEsp
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(541, 377)
        Controls.Add(BtnCancelarEs)
        Controls.Add(BtnGuardar)
        Controls.Add(BtnSeleSala)
        Controls.Add(BtnSeleccionar)
        Controls.Add(TxtSala)
        Controls.Add(LblSala)
        Controls.Add(TxtDoc)
        Controls.Add(LblDoc)
        Controls.Add(TxtEspeciali)
        Controls.Add(LblEspeciali)
        Controls.Add(TxtIde)
        Controls.Add(LblIden)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FrmAgregarEsp"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Agregar Especialidad"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LblIden As Label
    Friend WithEvents TxtIde As TextBox
    Friend WithEvents LblEspeciali As Label
    Friend WithEvents TxtEspeciali As TextBox
    Friend WithEvents LblDoc As Label
    Friend WithEvents TxtDoc As TextBox
    Friend WithEvents LblSala As Label
    Friend WithEvents TxtSala As TextBox
    Friend WithEvents BtnSeleccionar As Button
    Friend WithEvents BtnSeleSala As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnCancelarEs As Button
End Class
