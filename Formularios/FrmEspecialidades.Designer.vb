<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEspecialidades
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
        GroupBox1 = New GroupBox()
        DataGridView1 = New DataGridView()
        Col1 = New DataGridViewTextBoxColumn()
        Col2 = New DataGridViewTextBoxColumn()
        Col3 = New DataGridViewTextBoxColumn()
        Col4 = New DataGridViewTextBoxColumn()
        Col5 = New DataGridViewTextBoxColumn()
        Col6 = New DataGridViewTextBoxColumn()
        BtnBus = New Button()
        TxtBus = New TextBox()
        BtnAgregar = New Button()
        LblEspecialidad = New Label()
        GroupBox1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.Controls.Add(DataGridView1)
        GroupBox1.Controls.Add(BtnBus)
        GroupBox1.Controls.Add(TxtBus)
        GroupBox1.Controls.Add(BtnAgregar)
        GroupBox1.Controls.Add(LblEspecialidad)
        GroupBox1.Location = New Point(2, 16)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.Size = New Size(765, 555)
        GroupBox1.TabIndex = 21
        GroupBox1.TabStop = False
        GroupBox1.Text = "Lista Especialidades"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Col1, Col2, Col3, Col4, Col5, Col6})
        DataGridView1.Location = New Point(13, 212)
        DataGridView1.Margin = New Padding(3, 4, 3, 4)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(737, 183)
        DataGridView1.TabIndex = 44
        ' 
        ' Col1
        ' 
        Col1.HeaderText = "ID"
        Col1.MinimumWidth = 6
        Col1.Name = "Col1"
        Col1.Width = 125
        ' 
        ' Col2
        ' 
        Col2.HeaderText = "Especialidad"
        Col2.MinimumWidth = 6
        Col2.Name = "Col2"
        Col2.Width = 125
        ' 
        ' Col3
        ' 
        Col3.HeaderText = "Doctor"
        Col3.MinimumWidth = 6
        Col3.Name = "Col3"
        Col3.Width = 125
        ' 
        ' Col4
        ' 
        Col4.HeaderText = "Sala"
        Col4.MinimumWidth = 6
        Col4.Name = "Col4"
        Col4.Width = 125
        ' 
        ' Col5
        ' 
        Col5.HeaderText = "Modificar "
        Col5.MinimumWidth = 6
        Col5.Name = "Col5"
        Col5.Width = 125
        ' 
        ' Col6
        ' 
        Col6.HeaderText = "Eliminar"
        Col6.MinimumWidth = 6
        Col6.Name = "Col6"
        Col6.Width = 125
        ' 
        ' BtnBus
        ' 
        BtnBus.Location = New Point(581, 87)
        BtnBus.Margin = New Padding(3, 4, 3, 4)
        BtnBus.Name = "BtnBus"
        BtnBus.Size = New Size(86, 31)
        BtnBus.TabIndex = 43
        BtnBus.Text = "Buscar"
        BtnBus.UseVisualStyleBackColor = True
        ' 
        ' TxtBus
        ' 
        TxtBus.Location = New Point(307, 87)
        TxtBus.Margin = New Padding(3, 4, 3, 4)
        TxtBus.Name = "TxtBus"
        TxtBus.PlaceholderText = "Ingrese especialidad"
        TxtBus.Size = New Size(266, 27)
        TxtBus.TabIndex = 42
        TxtBus.TextAlign = HorizontalAlignment.Center
        ' 
        ' BtnAgregar
        ' 
        BtnAgregar.Location = New Point(21, 84)
        BtnAgregar.Margin = New Padding(3, 4, 3, 4)
        BtnAgregar.Name = "BtnAgregar"
        BtnAgregar.Size = New Size(165, 31)
        BtnAgregar.TabIndex = 22
        BtnAgregar.Text = "Agregar Especialidad"
        BtnAgregar.UseVisualStyleBackColor = True
        ' 
        ' LblEspecialidad
        ' 
        LblEspecialidad.AutoSize = True
        LblEspecialidad.Location = New Point(66, 95)
        LblEspecialidad.Name = "LblEspecialidad"
        LblEspecialidad.Size = New Size(0, 20)
        LblEspecialidad.TabIndex = 21
        ' 
        ' FrmEspecialidades
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.citamedic
        ClientSize = New Size(762, 600)
        Controls.Add(GroupBox1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "FrmEspecialidades"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Especialidades"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents LblEspecialidad As Label
    Friend WithEvents TxtBus As TextBox
    Friend WithEvents BtnBus As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Col1 As DataGridViewTextBoxColumn
    Friend WithEvents Col2 As DataGridViewTextBoxColumn
    Friend WithEvents Col3 As DataGridViewTextBoxColumn
    Friend WithEvents Col4 As DataGridViewTextBoxColumn
    Friend WithEvents Col5 As DataGridViewTextBoxColumn
    Friend WithEvents Col6 As DataGridViewTextBoxColumn
End Class
