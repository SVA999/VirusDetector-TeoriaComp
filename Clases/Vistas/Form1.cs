using System.Windows.Forms;

namespace VirusDetectorJS
{
    public partial class FormVentana : Form
    {
        public FormVentana()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Crea Objeto tipo explorador de archivos
            OpenFileDialog explorador = new OpenFileDialog();

            //Abre el explorador
            explorador.ShowDialog();

            //Obtiene el nombre del archivo y Setea la ruta en textBoxRuta
            textBoxRuta.Text = explorador.FileName;

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAnalizar_Click(object sender, EventArgs e)
        {
            //Analizador de archivos
        }
    }
}
