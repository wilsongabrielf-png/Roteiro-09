using System.Windows.Forms;

namespace Roteiro09
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string email = txtEmail.Text;
            string telefone = txtTelefone.Text;

            MessageBox.Show(
                "Nome: " + nome +
                "\nEmail: " + email +
                "\nTelefone: " + telefone
            );

            if (rbPix.Checked)
            {
                MessageBox.Show("Pagamento via PIX");
            }

            listBox1.Items.Add(txtTarefa.Text);

            listBox1.Items.Remove(listBox1.SelectedItem);

            dataGridView1.Columns.Add("codigo", "Código");
            dataGridView1.Columns.Add("produto", "Produto");
            dataGridView1.Columns.Add("preco", "Preço");
            dataGridView1.Columns.Add("estoque", "Estoque");

            dataGridView1.Rows.Add("1", "Notebook", "3500", "10");
        }
    }
}
