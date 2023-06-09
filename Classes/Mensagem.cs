using System.Windows.Forms;

namespace starpatch.Classes
{
    public static class Mensagem
    {
        public static string Sistema = "Star Patch";


        public static DialogResult ConfirmacaoFechamentoJanela(bool lbnYesDefault)
        {
            DialogResult confirm =
                lbnYesDefault ? MessageBox.Show("Confirma o fechamento da janela?", Sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                : MessageBox.Show("Confirma o fechamento da janela?", Sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            return confirm;
        }

        public static DialogResult Confirmar(string mensagem, bool lbnYesDefault)
        {
            DialogResult confirm =
                lbnYesDefault ? MessageBox.Show(mensagem, Sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                : MessageBox.Show(mensagem, Sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            return confirm;
        }

        public static void Atencao(string mensagem)
        {
            MessageBox.Show(mensagem, Sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void Informacao(string mensagem)
        {
            MessageBox.Show(mensagem, Sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Erro(string mensagem)
        {
            MessageBox.Show(mensagem, Sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void CampoObrigatorio(string nomeCampo)
        {
            MessageBox.Show(nomeCampo + " é de preenchimento obrigatório.", Sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

    }
}
