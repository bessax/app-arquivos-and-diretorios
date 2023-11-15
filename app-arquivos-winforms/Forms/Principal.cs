using app_arquivos_winforms.Forms;

namespace app_arquivos_winforms
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void pETToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cadastro = new FormCadastro();
            cadastro.Show();

        }

        private void lISTAGEMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormListagem().Show();
        }
    }
}