namespace SistemaDeCarro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //Método para mostrar os carros quando a segunda ComboBox for clicada
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Array que pega o nome de todos os arquivos (fotos) do diretório
            string[] nomeFotoDosCarros = Directory.GetFiles("C:\\Users\\thiag\\OneDrive\\Documentos\\PROGRAMAÇÃO\\Estudos-de-C#\\SistemaDeCarro\\imgs\\carros");

            //Comando para pegar cada nome de dentro do array nomeFotoDosCarros
            foreach (string img in nomeFotoDosCarros)
            {

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = string.Empty;

            if(comboBox1.Text == "CHEVROLET")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("CELTA");
                comboBox2.Items.Add("EQUINOX");
                comboBox2.Items.Add("ONIX");
            } 
            else if (comboBox1.Text == "VOLKSWAGEN")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("FUSCA");
                comboBox2.Items.Add("NIVUS");
                comboBox2.Items.Add("AMAROK");
            }
            else if (comboBox1.Text == "FIAT")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("CRONOS");
                comboBox2.Items.Add("PULSE");
                comboBox2.Items.Add("PALIO");
            }
            else if (comboBox1.Text == "FORD")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("FUSION");
                comboBox2.Items.Add("KA");
                comboBox2.Items.Add("ECOSPORT");
            }
        }
    }
}
