using System.Data;
namespace calculadora
{
    public partial class Form1 : Form
    {
        private string currentCalculation = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button_Click(object sender, EventArgs e)
        {
            currentCalculation += (sender as Button).Text;
            visor.Text = currentCalculation;
        }

        private void equal_Click(object sender, EventArgs e)
        {
            string formattedCalc = currentCalculation.ToString();
            try
            {
                visor.Text = new DataTable().Compute(formattedCalc, null).ToString();
                currentCalculation = visor.Text;
            }
            catch (Exception ex)
            {
                visor.Text = "ERROR";
                currentCalculation = "";
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            visor.Text = "0";
            currentCalculation = "";
        }

        private void deleteAll_Click(object sender, EventArgs e)
        {
            if (currentCalculation.Length > 0)
            {
                currentCalculation = currentCalculation.Remove(currentCalculation.Length - 1, 1);
            }
            visor.Text = currentCalculation;
        }

        private void equal_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
