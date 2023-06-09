using Newtonsoft.Json;
using starpatch.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace starpatch
{
    public partial class FrmPrincipal : Form
    {
        private Thread threadProcessar;
        private Thread threadJsonPatch;

        private bool processar = false;
        private bool jsonPatch = false;

        private List<Dados> listaDados = new List<Dados>();

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            dgvDados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvDados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        #region Eventos

        private void btnProcurarCaminho_Click(object sender, EventArgs e)
        {
            txtCaminhoArquivo.Text = string.Empty;

            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();

            txtCaminhoArquivo.Text = fbd.SelectedPath;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void btnJsonPatch_Click(object sender, EventArgs e)
        {
            try
            {
                if (jsonPatch || threadJsonPatch?.ThreadState == System.Threading.ThreadState.Running)
                {
                    threadJsonPatch.Abort();
                }
                else
                {
                    ThreadStart start = new ThreadStart(JsonPatch);
                    threadJsonPatch = new Thread(start);
                    threadJsonPatch.Start();
                }
            }
            catch (Exception ex)
            {
                Log("ERRO", $"Exception {ex}");
                Mensagem.Erro($"ERRO: {ex}");
            }
        }
        private void btnProcessar_Click(object sender, EventArgs e)
        {
            try
            {
                if (processar || threadProcessar?.ThreadState == System.Threading.ThreadState.Running)
                {
                    threadProcessar.Abort();
                }
                else
                {
                    ThreadStart start = new ThreadStart(Processar);
                    threadProcessar = new Thread(start);
                    threadProcessar.Start();
                }
            }
            catch (Exception ex)
            {
                Log("ERRO", $"Exception {ex}");
                Mensagem.Erro($"ERRO: {ex}");
            }
        }

        #endregion

        #region Metodos

        private void AddDados(string caminho, int patch)
        {
            try
            {
                foreach (var item in Directory.GetFiles(caminho, "*.patch", System.IO.SearchOption.AllDirectories))
                {
                    if (!string.IsNullOrEmpty(item))
                    {
                        string nomeArquivo = item.Replace(caminho, "").Replace(".patch", "");

                        var file = listaDados.Find(x => x.Arquivo == nomeArquivo);

                        Dados dados = file ?? new Dados();
                        dados.Erro = false;

                        if (patch == 1)
                            dados.Patch1 = item;
                        else if (patch == 2)
                            dados.Patch2 = item;
                        else if (patch == 3)
                            dados.Patch3 = item;
                        else if (patch == 4)
                            dados.Patch4 = item;
                        else if (patch == 5)
                            dados.Patch5 = item;

                        dados.TotalPatch++;

                        if (file == null)
                        {
                            dados.Arquivo = nomeArquivo;
                            dados.Indice = listaDados.Count + 1;
                            listaDados.Add(dados);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log("ERRO", $"Exception {ex}");
            }
        }
        private bool AplicaJsonPatch(string nomeArquivoOriginal, string arquivoPatch)
        {
            try
            {
                Log("INFO", "---------------------------------------------------------------------------");

                string arquivoOriginal = txtCaminhoArquivo.Text + Sessao.CaminhoStarAlliance + nomeArquivoOriginal;
                string arquivoComPatch = txtCaminhoArquivo.Text + @"Patch\" + Sessao.CaminhoStarAlliance + nomeArquivoOriginal;

                if (!File.Exists(arquivoOriginal))
                {
                    Log("ERRRO", $"ARQUIVO NÃO EXISTE -> {arquivoOriginal}");
                    return false;
                }
                else if (!File.Exists(arquivoPatch))
                {
                    Log("ERRO", $"ARQUIVO NÃO EXISTE -> {arquivoPatch}");
                    return false;
                }

                //se o arquivo ja foi alterado manter o arquivo novo
                if (File.Exists(arquivoComPatch))
                    arquivoOriginal = arquivoComPatch;

                var jsonOriginal = File.ReadAllText(arquivoOriginal);
                var jsonOriginalDeserializeObject = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonOriginal);

                Log("INFO", $"Arquivo Original {arquivoOriginal}");
                //Log("JSON ORIGINAL");
                //Log(JsonConvert.SerializeObject(jsonOriginalDeserializeObject, Formatting.Indented));
                //Log("---------------------------------------------------------------------------");

                var jsonPatch = File.ReadAllText(arquivoPatch);
                var jsonPatchDeserializeObject = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Microsoft.AspNetCore.JsonPatch.Operations.Operation>>(jsonPatch);

                Log("INFO", $"Arquivo Patch {arquivoPatch}");
                //Log("JSON PATCH");
                //Log(JsonConvert.SerializeObject(jsonPatchDeserializeObject, Formatting.Indented));
                //Log("---------------------------------------------------------------------------");

                var patchDocument = new Microsoft.AspNetCore.JsonPatch.JsonPatchDocument(jsonPatchDeserializeObject, new Newtonsoft.Json.Serialization.DefaultContractResolver());
                patchDocument.ApplyTo(jsonOriginalDeserializeObject);

                string jsonFinal = JsonConvert.SerializeObject(jsonOriginalDeserializeObject, Formatting.Indented);

                Log("INFO", $"Arquivo com Patch {arquivoComPatch}");
                //Log("PATCH APLICADO");
                //Log(jsonFinal);
                //Log("---------------------------------------------------------------------------");

                //cria o caminho
                Directory.CreateDirectory(Path.GetDirectoryName(arquivoComPatch));
                //cria o novo arquivo
                File.WriteAllText(arquivoComPatch, jsonFinal);

                Log("INFO", "---------------------------------------------------------------------------");

                return false;
            }
            catch (Exception ex)
            {
                Log("ERRO", $"Exception {ex}");
                return true;
            }
        }
        private void JsonPatch()
        {
            double etapa = 0;
            try
            {
                Log("INFO", "---------------------------------------------------------------------------");
                Log("INFO", "JSON Patch");

                if (!jsonPatch)
                {
                    jsonPatch = true;

                    if (Mensagem.Confirmar("Confirma a execução das alterações?\r\n\r\nEssa ação não pode ser desfeita.", false) == DialogResult.Yes)
                    {
                        pnlCarregando.Invoke(new Action(() => pnlCarregando.Visible = true));
                        pnlCarregando.Invoke(new Action(() => btnJsonPatch.Text = "      Parar"));
                        pnlCarregando.Invoke(new Action(() => btnJsonPatch.Image = global::starpatch.Properties.Resources._32_parar));

                        var listaOrdenada = listaDados.OrderBy(x => x.Indice);
                        int totalLista = listaOrdenada.Count();

                        foreach (var item in listaOrdenada)
                        {
                            lblRodando.Invoke(new Action(() => lblRodando.Text = $"Executando tarefa {item.Indice} / {totalLista}"));
                            lblRodando.Invoke(new Action(() => lblRodando.Refresh()));

                            if (!string.IsNullOrEmpty(item.Patch1))
                                item.Erro = AplicaJsonPatch(item.Arquivo, item.Patch1);
                            if (!string.IsNullOrEmpty(item.Patch2))
                                item.Erro = AplicaJsonPatch(item.Arquivo, item.Patch2);
                            if (!string.IsNullOrEmpty(item.Patch3))
                                item.Erro = AplicaJsonPatch(item.Arquivo, item.Patch3);
                            if (!string.IsNullOrEmpty(item.Patch4))
                                item.Erro = AplicaJsonPatch(item.Arquivo, item.Patch4);
                            if (!string.IsNullOrEmpty(item.Patch5))
                                item.Erro = AplicaJsonPatch(item.Arquivo, item.Patch5);
                        }

                        CarregaDados();

                        Mensagem.Informacao("FIM");
                    }

                    jsonPatch = false;
                }

                Log("INFO", "---------------------------------------------------------------------------");
            }
            catch (Exception ex)
            {
                jsonPatch = false;
                Log("ERRO", $"ERRO: Exception -> {ex}");
            }
            finally
            {
                pnlCarregando.Invoke(new Action(() => pnlCarregando.Visible = false));
                lblRodando.Invoke(new Action(() => lblRodando.Text = ""));
                btnProcessar.Invoke(new Action(() => btnJsonPatch.Text = "      JSON Patch"));
                btnProcessar.Invoke(new Action(() => btnJsonPatch.Image = global::starpatch.Properties.Resources._32_json));
            }
        }
        private void Processar()
        {
            double etapa = 0;
            try
            {
                Log("INFO", "---------------------------------------------------------------------------");
                Log("INFO", "PROCESSAR");

                if (!processar)
                {
                    processar = true;

                    pnlCarregando.Invoke(new Action(() => pnlCarregando.Visible = true));
                    lblRodando.Invoke(new Action(() => lblRodando.Text = "Aguarde analisando os arquivos..."));
                    btnProcessar.Invoke(new Action(() => btnProcessar.Text = "   Parar"));
                    btnProcessar.Invoke(new Action(() => btnProcessar.Image = global::starpatch.Properties.Resources._32_parar));
                    btnJsonPatch.Invoke(new Action(() => btnJsonPatch.Enabled = false));

                    if (string.IsNullOrEmpty(txtCaminhoArquivo.Text))
                    {
                        Mensagem.CampoObrigatorio("Caminho Raiz Mod");
                        Log("ERRO", "Caminho Raiz Mod");
                        return;
                    }

                    DirectoryInfo dirCaminhoRaiz = new DirectoryInfo(txtCaminhoArquivo.Text);
                    if (!dirCaminhoRaiz.Exists)
                    {
                        Mensagem.Erro("Caminho Raiz não foi localizado.");
                        Log("ERRO", "Caminho Raiz não foi localizado.");
                        return;
                    }

                    listaDados = new List<Dados>();

                    DirectoryInfo dirCaminhoStarAlliance = new DirectoryInfo(txtCaminhoArquivo.Text + Sessao.CaminhoStarAlliance);
                    DirectoryInfo dirCaminhoComplemento = new DirectoryInfo(txtCaminhoArquivo.Text + Sessao.CaminhoComplemento);
                    DirectoryInfo dirCaminhoShaders = new DirectoryInfo(txtCaminhoArquivo.Text + Sessao.CaminhoShaders);
                    DirectoryInfo dirCaminhoUpdate = new DirectoryInfo(txtCaminhoArquivo.Text + Sessao.CaminhoUpdate);
                    DirectoryInfo dirCaminhoMaple32 = new DirectoryInfo(txtCaminhoArquivo.Text + Sessao.CaminhoMaple32);


                    if (dirCaminhoStarAlliance.Exists)
                    {
                        AddDados(dirCaminhoStarAlliance.FullName, 1);
                    }
                    if (dirCaminhoComplemento.Exists)
                    {
                        AddDados(dirCaminhoComplemento.FullName, 2);
                    }
                    if (dirCaminhoShaders.Exists)
                    {
                        AddDados(dirCaminhoShaders.FullName, 3);
                    }
                    if (dirCaminhoUpdate.Exists)
                    {
                        AddDados(dirCaminhoUpdate.FullName, 4);
                    }
                    if (dirCaminhoMaple32.Exists)
                    {
                        AddDados(dirCaminhoMaple32.FullName, 5);
                    }

                    processar = false;
                    CarregaDados();
                    Mensagem.Informacao("FIM");
                }

                Log("INFO", "---------------------------------------------------------------------------");
            }
            catch (Exception ex)
            {
                processar = false;
                Log("ERRO", $"ERRO: Exception -> {ex}");
            }
            finally
            {
                btnJsonPatch.Invoke(new Action(() => btnJsonPatch.Enabled = true));
                pnlCarregando.Invoke(new Action(() => pnlCarregando.Visible = false));
                lblRodando.Invoke(new Action(() => lblRodando.Text = ""));
                btnProcessar.Invoke(new Action(() => btnProcessar.Text = "   Processar"));
                btnProcessar.Invoke(new Action(() => btnProcessar.Image = global::starpatch.Properties.Resources._32_fogete));
            }
        }
        private void CarregaDados()
        {
            SortableBindingList<Dados> listaOrdenada = new SortableBindingList<Dados>(listaDados);
            dgvDados.Invoke(new Action(() => dgvDados.DataSource = null));
            dgvDados.Invoke(new Action(() => dgvDados.DataSource = listaOrdenada));

            Log("INFO", $"Tarefas Localizadas: {listaOrdenada.Count()}");
        }

        private void Log(string tipo, string texto)
        {
            try
            {
                string log = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " " + tipo + " " + texto;

                txtLog.Invoke(new Action(() => txtLog.AppendText(log + Environment.NewLine)));
                txtLog.Invoke(new Action(() => txtLog.SelectionStart = txtLog.Text.Length));
                txtLog.Invoke(new Action(() => txtLog.ScrollToCaret()));

                LogArquivo.Gravar(log);
            }
            catch
            {
            }
        }
        #endregion
    }
}
