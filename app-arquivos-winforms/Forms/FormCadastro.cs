using app_arquivos_winforms.Entidades;

namespace app_arquivos_winforms.Forms
{
    public partial class FormCadastro : Form
    {
        private Pet pet;
        public FormCadastro()
        {
            InitializeComponent();
            pet = new Pet();
            txtId.Text = pet.Id;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            pet.Nome = txtNome.Text;
            pet.Raca = txtRaca.Text;
            pet.Idade = int.Parse(txtPeso.Text);
            pet.Peso = double.Parse(txtPeso.Text);
            pet.Porte = cmbPorte.Text;
            pet.DataVacinacao = dateTimePicker1.Value;
            try
            {
                var path = Directory.GetCurrentDirectory();
                StreamWriter streamWriter =
               new StreamWriter(path
               + "\\pet.txt", true);
                streamWriter.WriteLine(pet.ToString());
                streamWriter.Close();
                MessageBox.Show("Pet cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro {ex.Message}", "Erro do Sistema", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Limpartela();
        }

        private void Limpartela()
        {
            txtNome.Text = "";
            txtRaca.Text = "";
            txtPeso.Text = "";
        }
    }
}
