<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnAbreArquivo = New System.Windows.Forms.Button()
        Me.TxtNomePlanilha = New System.Windows.Forms.TextBox()
        Me.BtnExibirPlanilha = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        resources.ApplyResources(Me.DataGridView1, "DataGridView1")
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        '
        'BtnAbreArquivo
        '
        resources.ApplyResources(Me.BtnAbreArquivo, "BtnAbreArquivo")
        Me.BtnAbreArquivo.Name = "BtnAbreArquivo"
        Me.BtnAbreArquivo.UseVisualStyleBackColor = True
        '
        'TxtNomePlanilha
        '
        resources.ApplyResources(Me.TxtNomePlanilha, "TxtNomePlanilha")
        Me.TxtNomePlanilha.Name = "TxtNomePlanilha"
        '
        'BtnExibirPlanilha
        '
        resources.ApplyResources(Me.BtnExibirPlanilha, "BtnExibirPlanilha")
        Me.BtnExibirPlanilha.Name = "BtnExibirPlanilha"
        Me.BtnExibirPlanilha.UseVisualStyleBackColor = True
        '
        'FrmMain
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BtnExibirPlanilha)
        Me.Controls.Add(Me.TxtNomePlanilha)
        Me.Controls.Add(Me.BtnAbreArquivo)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmMain"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnAbreArquivo As Button
    Friend WithEvents TxtNomePlanilha As TextBox
    Friend WithEvents BtnExibirPlanilha As Button
End Class
