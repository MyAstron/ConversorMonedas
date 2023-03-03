namespace ConversorMonedas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            double ValorQuetzales;
            ValorQuetzales = Double.Parse(udQuetzales.Text);
            Quetzales1.Text = ValorQuetzales.ToString(); Quetzales2.Text = ValorQuetzales.ToString();
            Quetzales3.Text = ValorQuetzales.ToString();

            txtPesosMexicanos.Text = (ValorQuetzales * 2.32).ToString();
            txtDolares.Text = (ValorQuetzales * 0.13).ToString();
            txtEuros.Text = (ValorQuetzales * 0.12).ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}