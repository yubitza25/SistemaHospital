<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAtencion
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
        LblAtencion = New Label()
        BtnAtencion = New Button()
        LblBuscar = New Label()
        TxtBuscar = New TextBox()
        GroupBox1 = New GroupBox()
        Btn3 = New Button()
        Btn2 = New Button()
        Btn1 = New Button()
        LblSiguiente = New Label()
        LblAnterior = New Label()
        Label1 = New Label()
        DGVTablaAtencion = New DataGridView()
        Col1 = New DataGridViewTextBoxColumn()
        Col2 = New DataGridViewTextBoxColumn()
        Col3 = New DataGridViewTextBoxColumn()
        Col4 = New DataGridViewTextBoxColumn()
        Col5 = New DataGridViewTextBoxColumn()
        Col6 = New DataGridViewTextBoxColumn()
        Col7 = New DataGridViewTextBoxColumn()
        Col8 = New DataGridViewTextBoxColumn()
        Col9 = New DataGridViewTextBoxColumn()
        GroupBox1.SuspendLayout()
        CType(DGVTablaAtencion, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LblAtencion
        ' 
        LblAtencion.AutoSize = True
        LblAtencion.Location = New Point(32, 55)
        LblAtencion.Name = "LblAtencion"
        LblAtencion.Size = New Size(75, 20)
        LblAtencion.TabIndex = 0
        LblAtencion.Text = "Atencion :"
        ' 
        ' BtnAtencion
        ' 
        BtnAtencion.BackColor = Color.Aqua
        BtnAtencion.Location = New Point(109, 49)
        BtnAtencion.Margin = New Padding(3, 4, 3, 4)
        BtnAtencion.Name = "BtnAtencion"
        BtnAtencion.Size = New Size(139, 31)
        BtnAtencion.TabIndex = 1
        BtnAtencion.Text = "Agregar Atencion"
        BtnAtencion.UseVisualStyleBackColor = False
        ' 
        ' LblBuscar
        ' 
        LblBuscar.AutoSize = True
        LblBuscar.Location = New Point(571, 57)
        LblBuscar.Name = "LblBuscar"
        LblBuscar.Size = New Size(59, 20)
        LblBuscar.TabIndex = 2
        LblBuscar.Text = "Buscar :"
        ' 
        ' TxtBuscar
        ' 
        TxtBuscar.Location = New Point(633, 53)
        TxtBuscar.Margin = New Padding(3, 4, 3, 4)
        TxtBuscar.Name = "TxtBuscar"
        TxtBuscar.Size = New Size(114, 27)
        TxtBuscar.TabIndex = 3
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.Controls.Add(Btn3)
        GroupBox1.Controls.Add(Btn2)
        GroupBox1.Controls.Add(Btn1)
        GroupBox1.Controls.Add(LblSiguiente)
        GroupBox1.Controls.Add(LblAnterior)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(DGVTablaAtencion)
        GroupBox1.Controls.Add(BtnAtencion)
        GroupBox1.Controls.Add(TxtBuscar)
        GroupBox1.Controls.Add(LblAtencion)
        GroupBox1.Controls.Add(LblBuscar)
        GroupBox1.Location = New Point(14, 16)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.Size = New Size(994, 752)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        GroupBox1.Text = "Gbox"
        ' 
        ' Btn3
        ' 
        Btn3.Location = New Point(853, 673)
        Btn3.Margin = New Padding(3, 4, 3, 4)
        Btn3.Name = "Btn3"
        Btn3.Size = New Size(34, 31)
        Btn3.TabIndex = 10
        Btn3.Text = "3"
        Btn3.UseVisualStyleBackColor = True
        ' 
        ' Btn2
        ' 
        Btn2.Location = New Point(811, 673)
        Btn2.Margin = New Padding(3, 4, 3, 4)
        Btn2.Name = "Btn2"
        Btn2.Size = New Size(34, 31)
        Btn2.TabIndex = 9
        Btn2.Text = "2"
        Btn2.UseVisualStyleBackColor = True
        ' 
        ' Btn1
        ' 
        Btn1.Location = New Point(770, 673)
        Btn1.Margin = New Padding(3, 4, 3, 4)
        Btn1.Name = "Btn1"
        Btn1.Size = New Size(34, 31)
        Btn1.TabIndex = 8
        Btn1.Text = "1"
        Btn1.UseVisualStyleBackColor = True
        ' 
        ' LblSiguiente
        ' 
        LblSiguiente.AutoSize = True
        LblSiguiente.Location = New Point(901, 679)
        LblSiguiente.Name = "LblSiguiente"
        LblSiguiente.Size = New Size(71, 20)
        LblSiguiente.TabIndex = 7
        LblSiguiente.Text = "Siguiente"
        ' 
        ' LblAnterior
        ' 
        LblAnterior.AutoSize = True
        LblAnterior.Location = New Point(706, 679)
        LblAnterior.Name = "LblAnterior"
        LblAnterior.Size = New Size(63, 20)
        LblAnterior.TabIndex = 6
        LblAnterior.Text = "Anterior"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(35, 663)
        Label1.Name = "Label1"
        Label1.Size = New Size(186, 20)
        Label1.TabIndex = 5
        Label1.Text = "Mostrando 1 a 15 registros"
        ' 
        ' DGVTablaAtencion
        ' 
        DGVTablaAtencion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVTablaAtencion.Columns.AddRange(New DataGridViewColumn() {Col1, Col2, Col3, Col4, Col5, Col6, Col7, Col8, Col9})
        DGVTablaAtencion.Location = New Point(32, 132)
        DGVTablaAtencion.Margin = New Padding(3, 4, 3, 4)
        DGVTablaAtencion.Name = "DGVTablaAtencion"
        DGVTablaAtencion.RowHeadersWidth = 51
        DGVTablaAtencion.Size = New Size(933, 495)
        DGVTablaAtencion.TabIndex = 4
        ' 
        ' Col1
        ' 
        Col1.HeaderText = "Opciones"
        Col1.MinimumWidth = 6
        Col1.Name = "Col1"
        Col1.Width = 125
        ' 
        ' Col2
        ' 
        Col2.HeaderText = "Fecha"
        Col2.MinimumWidth = 6
        Col2.Name = "Col2"
        Col2.Width = 125
        ' 
        ' Col3
        ' 
        Col3.HeaderText = "Registrador"
        Col3.MinimumWidth = 6
        Col3.Name = "Col3"
        Col3.Width = 125
        ' 
        ' Col4
        ' 
        Col4.HeaderText = "Servicio"
        Col4.MinimumWidth = 6
        Col4.Name = "Col4"
        Col4.Width = 125
        ' 
        ' Col5
        ' 
        Col5.HeaderText = "Especialista (Medico)"
        Col5.MinimumWidth = 6
        Col5.Name = "Col5"
        Col5.Width = 125
        ' 
        ' Col6
        ' 
        Col6.HeaderText = "Paciente"
        Col6.MinimumWidth = 6
        Col6.Name = "Col6"
        Col6.Width = 125
        ' 
        ' Col7
        ' 
        Col7.HeaderText = "DNI"
        Col7.MinimumWidth = 6
        Col7.Name = "Col7"
        Col7.Width = 125
        ' 
        ' Col8
        ' 
        Col8.HeaderText = "Costo"
        Col8.MinimumWidth = 6
        Col8.Name = "Col8"
        Col8.Width = 125
        ' 
        ' Col9
        ' 
        Col9.HeaderText = "Estado"
        Col9.MinimumWidth = 6
        Col9.Name = "Col9"
        Col9.Width = 125
        ' 
        ' FrmPrincipal
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.fondo
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1022, 784)
        Controls.Add(GroupBox1)
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        MinimizeBox = False
        Name = "FrmPrincipal"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sistema de Atencion"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DGVTablaAtencion, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents LblAtencion As Label
    Friend WithEvents BtnAtencion As Button
    Friend WithEvents LblBuscar As Label
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DGVTablaAtencion As DataGridView
    Friend WithEvents Col1 As DataGridViewTextBoxColumn
    Friend WithEvents Col2 As DataGridViewTextBoxColumn
    Friend WithEvents Col3 As DataGridViewTextBoxColumn
    Friend WithEvents Col4 As DataGridViewTextBoxColumn
    Friend WithEvents Col5 As DataGridViewTextBoxColumn
    Friend WithEvents Col6 As DataGridViewTextBoxColumn
    Friend WithEvents Col7 As DataGridViewTextBoxColumn
    Friend WithEvents Col8 As DataGridViewTextBoxColumn
    Friend WithEvents Col9 As DataGridViewTextBoxColumn
    Friend WithEvents Btn2 As Button
    Friend WithEvents Btn1 As Button
    Friend WithEvents LblSiguiente As Label
    Friend WithEvents LblAnterior As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn3 As Button

End Class
