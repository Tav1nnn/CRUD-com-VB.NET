<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmWindows
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
        btnNovo = New Button()
        btnExcluir = New Button()
        btnEditar = New Button()
        Exibir = New Button()
        Consultar = New Button()
        grid = New DataGridView()
        boxNome = New TextBox()
        Label2 = New Label()
        boxNumero = New TextBox()
        Label3 = New Label()
        boxIdd = New TextBox()
        Label4 = New Label()
        CType(grid, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnNovo
        ' 
        btnNovo.Location = New Point(13, 151)
        btnNovo.Name = "btnNovo"
        btnNovo.Size = New Size(94, 29)
        btnNovo.TabIndex = 0
        btnNovo.Text = "Novo"
        btnNovo.UseVisualStyleBackColor = True
        ' 
        ' btnExcluir
        ' 
        btnExcluir.Location = New Point(213, 151)
        btnExcluir.Name = "btnExcluir"
        btnExcluir.Size = New Size(94, 29)
        btnExcluir.TabIndex = 1
        btnExcluir.Text = "Excluir"
        btnExcluir.UseVisualStyleBackColor = True
        ' 
        ' btnEditar
        ' 
        btnEditar.Location = New Point(113, 151)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(94, 29)
        btnEditar.TabIndex = 2
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = True
        ' 
        ' Exibir
        ' 
        Exibir.Location = New Point(413, 151)
        Exibir.Name = "Exibir"
        Exibir.Size = New Size(94, 29)
        Exibir.TabIndex = 3
        Exibir.Text = "Exibir"
        Exibir.UseVisualStyleBackColor = True
        ' 
        ' Consultar
        ' 
        Consultar.Location = New Point(313, 151)
        Consultar.Name = "Consultar"
        Consultar.Size = New Size(94, 29)
        Consultar.TabIndex = 4
        Consultar.Text = "Consultar"
        Consultar.UseVisualStyleBackColor = True
        ' 
        ' grid
        ' 
        grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        grid.Location = New Point(12, 196)
        grid.Name = "grid"
        grid.RowHeadersWidth = 51
        grid.RowTemplate.Height = 29
        grid.Size = New Size(706, 199)
        grid.TabIndex = 5
        ' 
        ' boxNome
        ' 
        boxNome.Location = New Point(76, 55)
        boxNome.Name = "boxNome"
        boxNome.Size = New Size(151, 27)
        boxNome.TabIndex = 9
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(17, 58)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 20)
        Label2.TabIndex = 8
        Label2.Text = "Nome:"
        ' 
        ' boxNumero
        ' 
        boxNumero.Location = New Point(76, 96)
        boxNumero.Name = "boxNumero"
        boxNumero.Size = New Size(151, 27)
        boxNumero.TabIndex = 11
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(17, 96)
        Label3.Name = "Label3"
        Label3.Size = New Size(44, 20)
        Label3.TabIndex = 10
        Label3.Text = "Num:"
        ' 
        ' boxIdd
        ' 
        boxIdd.Location = New Point(76, 22)
        boxIdd.Name = "boxIdd"
        boxIdd.Size = New Size(151, 27)
        boxIdd.TabIndex = 13
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(17, 25)
        Label4.Name = "Label4"
        Label4.Size = New Size(25, 20)
        Label4.TabIndex = 12
        Label4.Text = "Id:"
        ' 
        ' FrmWindows
        ' 
        AccessibleName = "frmWindowns"
        AccessibleRole = AccessibleRole.Outline
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonFace
        ClientSize = New Size(730, 407)
        Controls.Add(boxIdd)
        Controls.Add(Label4)
        Controls.Add(boxNumero)
        Controls.Add(Label3)
        Controls.Add(boxNome)
        Controls.Add(Label2)
        Controls.Add(grid)
        Controls.Add(Consultar)
        Controls.Add(Exibir)
        Controls.Add(btnEditar)
        Controls.Add(btnExcluir)
        Controls.Add(btnNovo)
        Name = "FrmWindows"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FrmWindows"
        CType(grid, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnNovo As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents Exibir As Button
    Friend WithEvents Consultar As Button
    Friend WithEvents grid As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents boxId As TextBox
    Friend WithEvents boxNome As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents boxNumero As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents boxIdd As TextBox
    Friend WithEvents Label4 As Label
End Class
