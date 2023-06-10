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

        private Caminho caminho;

        private readonly string Config = $@"{Environment.CurrentDirectory}\config.json";
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

            caminho = new Caminho();

            if (File.Exists(Config))
            {
                var jsoConfig = File.ReadAllText(Config);
                caminho = Newtonsoft.Json.JsonConvert.DeserializeObject<Caminho>(jsoConfig);

                if (caminho != null)
                {
                    try
                    {
                        txtPastaMod.Text = ValidaBarra(caminho.CaminhoMod);
                        txtPastaSaida.Text = ValidaBarra(caminho.CaminhoSaida);
                        txtPath01.Text = ValidaBarra(caminho?.CaminhoPatch[0]);
                        txtPath02.Text = ValidaBarra(caminho?.CaminhoPatch[1]);
                        txtPath03.Text = ValidaBarra(caminho?.CaminhoPatch[2]);
                        txtPath04.Text = ValidaBarra(caminho?.CaminhoPatch[3]);
                        txtPath05.Text = ValidaBarra(caminho?.CaminhoPatch[4]);
                        txtPath06.Text = ValidaBarra(caminho?.CaminhoPatch[5]);
                        txtPath08.Text = ValidaBarra(caminho?.CaminhoPatch[7]);
                        txtPath09.Text = ValidaBarra(caminho?.CaminhoPatch[8]);
                        txtPath10.Text = ValidaBarra(caminho?.CaminhoPatch[9]);
                    }
                    catch
                    {
                    }
                }
            }
        }

        #region Eventos

        private void btnPastaMod_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();

            if (((System.Windows.Forms.Control)sender).Name == btnPastaMod.Name)
                txtPastaMod.Text = fbd.SelectedPath;
            else if (((System.Windows.Forms.Control)sender).Name == btnPastaSaida.Name)
                txtPastaSaida.Text = fbd.SelectedPath;
            else if (((System.Windows.Forms.Control)sender).Name == btnPath01.Name)
                txtPath01.Text = fbd.SelectedPath;
            else if (((System.Windows.Forms.Control)sender).Name == btnPath02.Name)
                txtPath02.Text = fbd.SelectedPath;
            else if (((System.Windows.Forms.Control)sender).Name == btnPath03.Name)
                txtPath03.Text = fbd.SelectedPath;
            else if (((System.Windows.Forms.Control)sender).Name == btnPath04.Name)
                txtPath04.Text = fbd.SelectedPath;
            else if (((System.Windows.Forms.Control)sender).Name == btnPath05.Name)
                txtPath05.Text = fbd.SelectedPath;
            else if (((System.Windows.Forms.Control)sender).Name == btnPath06.Name)
                txtPath06.Text = fbd.SelectedPath;
            else if (((System.Windows.Forms.Control)sender).Name == btnPath07.Name)
                txtPath07.Text = fbd.SelectedPath;
            else if (((System.Windows.Forms.Control)sender).Name == btnPath08.Name)
                txtPath08.Text = fbd.SelectedPath;
            else if (((System.Windows.Forms.Control)sender).Name == btnPath09.Name)
                txtPath09.Text = fbd.SelectedPath;
            else if (((System.Windows.Forms.Control)sender).Name == btnPath10.Name)
                txtPath10.Text = fbd.SelectedPath;

            GravarConfig();
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

        private string ValidaBarra(string texto)
        {
            if (string.IsNullOrEmpty(texto.Trim()))
                return string.Empty;
            else if (texto.Trim().EndsWith(@"\"))
                return texto.Trim();
            else
                return texto.Trim() + @"\";
        }
        private void GravarConfig()
        {
            caminho = new Caminho();
            caminho.CaminhoMod = ValidaBarra(txtPastaMod.Text);
            caminho.CaminhoSaida = ValidaBarra(txtPastaSaida.Text);
            caminho.CaminhoPatch = new List<string>();
            caminho.CaminhoPatch.Add(ValidaBarra(txtPath01.Text));
            caminho.CaminhoPatch.Add(ValidaBarra(txtPath02.Text));
            caminho.CaminhoPatch.Add(ValidaBarra(txtPath03.Text));
            caminho.CaminhoPatch.Add(ValidaBarra(txtPath04.Text));
            caminho.CaminhoPatch.Add(ValidaBarra(txtPath05.Text));
            caminho.CaminhoPatch.Add(ValidaBarra(txtPath06.Text));
            caminho.CaminhoPatch.Add(ValidaBarra(txtPath07.Text));
            caminho.CaminhoPatch.Add(ValidaBarra(txtPath08.Text));
            caminho.CaminhoPatch.Add(ValidaBarra(txtPath09.Text));
            caminho.CaminhoPatch.Add(ValidaBarra(txtPath10.Text));

            //cria o novo arquivo
            string jsonFinal = JsonConvert.SerializeObject(caminho, Formatting.Indented);
            File.WriteAllText(Config, jsonFinal);
        }

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
                            dados.Patch01 = item;
                        else if (patch == 2)
                            dados.Patch02 = item;
                        else if (patch == 3)
                            dados.Patch03 = item;
                        else if (patch == 4)
                            dados.Patch04 = item;
                        else if (patch == 5)
                            dados.Patch05 = item;
                        else if (patch == 6)
                            dados.Patch06 = item;
                        else if (patch == 7)
                            dados.Patch07 = item;
                        else if (patch == 8)
                            dados.Patch08 = item;
                        else if (patch == 9)
                            dados.Patch08 = item;
                        else if (patch == 10)
                            dados.Patch10 = item;

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

                string arquivoOriginal = ValidaBarra(caminho?.CaminhoPatch[0]) + nomeArquivoOriginal;
                string arquivoComPatch = caminho.CaminhoSaida + nomeArquivoOriginal;

                if (!File.Exists(arquivoOriginal))
                {
                    Log("ERRO", $"ARQUIVO NÃO EXISTE -> {arquivoOriginal}");
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
                        int totalLista = listaOrdenada.Sum(x => x.TotalPatch);
                        int indice = 1;

                        foreach (var item in listaOrdenada)
                        {
                            try
                            {
                                if (!string.IsNullOrEmpty(item.Patch01))
                                {
                                    item.Erro = AplicaJsonPatch(item.Arquivo, item.Patch01);
                                    lblRodando.Invoke(new Action(() => lblRodando.Text = $"Executando tarefa {indice++} / {totalLista}"));
                                    lblRodando.Invoke(new Action(() => lblRodando.Refresh()));
                                }
                                if (!string.IsNullOrEmpty(item.Patch02))
                                {
                                    item.Erro = AplicaJsonPatch(item.Arquivo, item.Patch02);
                                    lblRodando.Invoke(new Action(() => lblRodando.Text = $"Executando tarefa {indice++} / {totalLista}"));
                                    lblRodando.Invoke(new Action(() => lblRodando.Refresh()));
                                }
                                if (!string.IsNullOrEmpty(item.Patch03))
                                {
                                    item.Erro = AplicaJsonPatch(item.Arquivo, item.Patch03);
                                    lblRodando.Invoke(new Action(() => lblRodando.Text = $"Executando tarefa {indice++} / {totalLista}"));
                                    lblRodando.Invoke(new Action(() => lblRodando.Refresh()));
                                }
                                if (!string.IsNullOrEmpty(item.Patch04))
                                {
                                    item.Erro = AplicaJsonPatch(item.Arquivo, item.Patch04);
                                    lblRodando.Invoke(new Action(() => lblRodando.Text = $"Executando tarefa {indice++} / {totalLista}"));
                                    lblRodando.Invoke(new Action(() => lblRodando.Refresh()));
                                }
                                if (!string.IsNullOrEmpty(item.Patch05))
                                {
                                    item.Erro = AplicaJsonPatch(item.Arquivo, item.Patch05);
                                    lblRodando.Invoke(new Action(() => lblRodando.Text = $"Executando tarefa {indice++} / {totalLista}"));
                                    lblRodando.Invoke(new Action(() => lblRodando.Refresh()));
                                }
                                if (!string.IsNullOrEmpty(item.Patch06))
                                {
                                    item.Erro = AplicaJsonPatch(item.Arquivo, item.Patch06);
                                    lblRodando.Invoke(new Action(() => lblRodando.Text = $"Executando tarefa {indice++} / {totalLista}"));
                                    lblRodando.Invoke(new Action(() => lblRodando.Refresh()));
                                }
                                if (!string.IsNullOrEmpty(item.Patch07))
                                {
                                    item.Erro = AplicaJsonPatch(item.Arquivo, item.Patch07);
                                    lblRodando.Invoke(new Action(() => lblRodando.Text = $"Executando tarefa {indice++} / {totalLista}"));
                                    lblRodando.Invoke(new Action(() => lblRodando.Refresh()));
                                }
                                if (!string.IsNullOrEmpty(item.Patch08))
                                {
                                    item.Erro = AplicaJsonPatch(item.Arquivo, item.Patch08);
                                    lblRodando.Invoke(new Action(() => lblRodando.Text = $"Executando tarefa {indice++} / {totalLista}"));
                                    lblRodando.Invoke(new Action(() => lblRodando.Refresh()));
                                }
                                if (!string.IsNullOrEmpty(item.Patch09))
                                {
                                    item.Erro = AplicaJsonPatch(item.Arquivo, item.Patch09);
                                    lblRodando.Invoke(new Action(() => lblRodando.Text = $"Executando tarefa {indice++} / {totalLista}"));
                                    lblRodando.Invoke(new Action(() => lblRodando.Refresh()));
                                }
                                if (!string.IsNullOrEmpty(item.Patch10))
                                {
                                    item.Erro = AplicaJsonPatch(item.Arquivo, item.Patch10);
                                    lblRodando.Invoke(new Action(() => lblRodando.Text = $"Executando tarefa {indice++} / {totalLista}"));
                                    lblRodando.Invoke(new Action(() => lblRodando.Refresh()));
                                }
                            }
                            catch (Exception ex)
                            {
                                Log("ERRO", $"ERRO: Exception -> {ex}");
                            }

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
                lblTotal.Invoke(new Action(() => lblTotal.Text = "Total Patch: 0"));
                GravarConfig();

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

                    if (string.IsNullOrEmpty(caminho.CaminhoMod))
                    {
                        Mensagem.CampoObrigatorio("Caminho Raiz Mod");
                        Log("ERRO", "Caminho Raiz Mod");
                        return;
                    }

                    DirectoryInfo dirCaminhoRaiz = new DirectoryInfo(caminho.CaminhoMod);
                    if (!dirCaminhoRaiz.Exists)
                    {
                        Mensagem.Erro("Caminho Raiz não foi localizado.");
                        Log("ERRO", "Caminho Raiz não foi localizado.");
                        return;
                    }

                    listaDados = new List<Dados>();
                    int caminhoPatch = 1;

                    foreach (string item in caminho?.CaminhoPatch)
                    {
                        if (!string.IsNullOrEmpty(item))
                        {
                            DirectoryInfo dirCaminho = new DirectoryInfo(item);

                            if (dirCaminho.Exists)
                                AddDados(dirCaminho.FullName, caminhoPatch++);
                        }
                    }

                    processar = false;
                    CarregaDados();
                    lblTotal.Invoke(new Action(() => lblTotal.Text = $"Total Patch:{listaDados.Sum(x => x.TotalPatch)}"));
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
