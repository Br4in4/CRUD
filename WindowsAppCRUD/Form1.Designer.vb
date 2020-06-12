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
        Me.LblID = New System.Windows.Forms.Label()
        Me.LblNome = New System.Windows.Forms.Label()
        Me.LblUtilizador = New System.Windows.Forms.Label()
        Me.LblSenha = New System.Windows.Forms.Label()
        Me.LblNivel = New System.Windows.Forms.Label()
        Me.TxtNome = New System.Windows.Forms.TextBox()
        Me.TxtUtilizador = New System.Windows.Forms.TextBox()
        Me.TxtSenha = New System.Windows.Forms.TextBox()
        Me.CbNivel = New System.Windows.Forms.ComboBox()
        Me.BtnCreate = New System.Windows.Forms.Button()
        Me.BtnReload = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.DgLista = New System.Windows.Forms.DataGridView()
        CType(Me.DgLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblID
        '
        Me.LblID.AutoSize = True
        Me.LblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblID.Location = New System.Drawing.Point(139, 35)
        Me.LblID.Name = "LblID"
        Me.LblID.Size = New System.Drawing.Size(35, 20)
        Me.LblID.TabIndex = 0
        Me.LblID.Text = "ID -"
        '
        'LblNome
        '
        Me.LblNome.AutoSize = True
        Me.LblNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNome.Location = New System.Drawing.Point(115, 64)
        Me.LblNome.Name = "LblNome"
        Me.LblNome.Size = New System.Drawing.Size(59, 20)
        Me.LblNome.TabIndex = 1
        Me.LblNome.Text = "Nome :"
        '
        'LblUtilizador
        '
        Me.LblUtilizador.AutoSize = True
        Me.LblUtilizador.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUtilizador.Location = New System.Drawing.Point(91, 102)
        Me.LblUtilizador.Name = "LblUtilizador"
        Me.LblUtilizador.Size = New System.Drawing.Size(83, 20)
        Me.LblUtilizador.TabIndex = 2
        Me.LblUtilizador.Text = "Utilizador :"
        '
        'LblSenha
        '
        Me.LblSenha.AutoSize = True
        Me.LblSenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSenha.Location = New System.Drawing.Point(110, 136)
        Me.LblSenha.Name = "LblSenha"
        Me.LblSenha.Size = New System.Drawing.Size(64, 20)
        Me.LblSenha.TabIndex = 3
        Me.LblSenha.Text = "Senha :"
        '
        'LblNivel
        '
        Me.LblNivel.AutoSize = True
        Me.LblNivel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNivel.Location = New System.Drawing.Point(45, 171)
        Me.LblNivel.Name = "LblNivel"
        Me.LblNivel.Size = New System.Drawing.Size(129, 20)
        Me.LblNivel.TabIndex = 4
        Me.LblNivel.Text = "Nível de Acesso :"
        '
        'TxtNome
        '
        Me.TxtNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNome.Location = New System.Drawing.Point(180, 61)
        Me.TxtNome.Name = "TxtNome"
        Me.TxtNome.Size = New System.Drawing.Size(317, 26)
        Me.TxtNome.TabIndex = 5
        '
        'TxtUtilizador
        '
        Me.TxtUtilizador.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUtilizador.Location = New System.Drawing.Point(180, 102)
        Me.TxtUtilizador.Name = "TxtUtilizador"
        Me.TxtUtilizador.Size = New System.Drawing.Size(317, 26)
        Me.TxtUtilizador.TabIndex = 6
        '
        'TxtSenha
        '
        Me.TxtSenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSenha.Location = New System.Drawing.Point(180, 136)
        Me.TxtSenha.Name = "TxtSenha"
        Me.TxtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.TxtSenha.Size = New System.Drawing.Size(317, 26)
        Me.TxtSenha.TabIndex = 7
        '
        'CbNivel
        '
        Me.CbNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbNivel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbNivel.FormattingEnabled = True
        Me.CbNivel.Items.AddRange(New Object() {"Equipa ", "Administrador"})
        Me.CbNivel.Location = New System.Drawing.Point(180, 168)
        Me.CbNivel.Name = "CbNivel"
        Me.CbNivel.Size = New System.Drawing.Size(317, 28)
        Me.CbNivel.TabIndex = 8
        '
        'BtnCreate
        '
        Me.BtnCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCreate.Location = New System.Drawing.Point(544, 66)
        Me.BtnCreate.Name = "BtnCreate"
        Me.BtnCreate.Size = New System.Drawing.Size(85, 26)
        Me.BtnCreate.TabIndex = 9
        Me.BtnCreate.Text = "Create"
        Me.BtnCreate.UseVisualStyleBackColor = True
        '
        'BtnReload
        '
        Me.BtnReload.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReload.Location = New System.Drawing.Point(544, 98)
        Me.BtnReload.Name = "BtnReload"
        Me.BtnReload.Size = New System.Drawing.Size(85, 26)
        Me.BtnReload.TabIndex = 10
        Me.BtnReload.Text = "Reload"
        Me.BtnReload.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdate.Location = New System.Drawing.Point(544, 130)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(85, 26)
        Me.BtnUpdate.TabIndex = 11
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.Location = New System.Drawing.Point(544, 162)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(85, 26)
        Me.BtnDelete.TabIndex = 12
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'DgLista
        '
        Me.DgLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgLista.Location = New System.Drawing.Point(49, 216)
        Me.DgLista.Name = "DgLista"
        Me.DgLista.Size = New System.Drawing.Size(580, 167)
        Me.DgLista.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 407)
        Me.Controls.Add(Me.DgLista)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnReload)
        Me.Controls.Add(Me.BtnCreate)
        Me.Controls.Add(Me.CbNivel)
        Me.Controls.Add(Me.TxtSenha)
        Me.Controls.Add(Me.TxtUtilizador)
        Me.Controls.Add(Me.TxtNome)
        Me.Controls.Add(Me.LblNivel)
        Me.Controls.Add(Me.LblSenha)
        Me.Controls.Add(Me.LblUtilizador)
        Me.Controls.Add(Me.LblNome)
        Me.Controls.Add(Me.LblID)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DgLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblID As Label
    Friend WithEvents LblNome As Label
    Friend WithEvents LblUtilizador As Label
    Friend WithEvents LblSenha As Label
    Friend WithEvents LblNivel As Label
    Friend WithEvents TxtNome As TextBox
    Friend WithEvents TxtUtilizador As TextBox
    Friend WithEvents TxtSenha As TextBox
    Friend WithEvents CbNivel As ComboBox
    Friend WithEvents BtnCreate As Button
    Friend WithEvents BtnReload As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents DgLista As DataGridView
End Class
