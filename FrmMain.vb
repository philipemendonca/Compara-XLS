Imports System.Data
Imports System.Data.OleDb
Imports System.Security

Public Class FrmMain
    Dim NomeArquivo As String = vbNullString

    Private Sub BtnAbreArquivo_Click(sender As Object, e As EventArgs) Handles BtnAbreArquivo.Click
        Using ofdXSL As New OpenFileDialog
            ofdXSL.Title = "Selecione um arquivo"
            ofdXSL.Filter = "Arquivos do Excel (*.xls;*.xlsx)|*.xls;*.xlsx"
            ofdXSL.Multiselect = False
            ofdXSL.CheckFileExists = True
            ofdXSL.CheckPathExists = True

            If ofdXSL.ShowDialog() = DialogResult.OK Then
                Try
                    NomeArquivo = ofdXSL.FileName

                    Me.Text += " - " & NomeArquivo
                    TxtNomePlanilha.Enabled = True

                Catch ex As Exception
                    TxtNomePlanilha.Enabled = False
                    MsgBox("Erro ao abrir arquivo:" & vbCrLf & ex.Message, vbCritical, "ERRO")
                End Try
            Else
                TxtNomePlanilha.Enabled = False
            End If
        End Using
    End Sub

    Private Sub TxtNomePlanilha_TextChanged(sender As Object, e As EventArgs) Handles TxtNomePlanilha.TextChanged
        If TxtNomePlanilha.Text <> "" Then
            BtnExibirPlanilha.Enabled = True
        Else
            BtnExibirPlanilha.Enabled = False
        End If
    End Sub

    Private Sub BtnExibirPlanilha_Click(sender As Object, e As EventArgs) Handles BtnExibirPlanilha.Click
        Dim conexaoOleDb As OleDbConnection = Nothing
        Dim ds As DataSet
        Dim cmd As OleDbDataAdapter
        Try
            conexaoOleDb = New OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & caminhoArquivoExcel & ";Extended Properties=Excel 8.0;")
            cmd = New OleDbDataAdapter("Select * from [" & nomePlanilhaExcel & "]", conexaoOleDb)
            cmd.TableMappings.Add("Table", "tabelaExcel")
            ds = New DataSet
            cmd.Fill(ds)
            dgvDados.DataSource = ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conexaoOleDb.Close()
        End Try
    End Sub
End Class