using System.Windows.Forms;
using VirusDetectorJS.Clases.Controladores;

namespace VirusDetectorJS
{
    public partial class FormVentana : Form
    {

        private byte[] v_bytesArchivo = null;
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

            AdminArchivos administrador = new AdminArchivos(explorador.FileName);

            v_bytesArchivo = administrador.LeerBytesArchivo();

            
            

            String cadenaBytes = "";

            for (int i = 0; i < v_bytesArchivo.Length; i++)
            {
                cadenaBytes = cadenaBytes + " " + v_bytesArchivo[i];
            }

            textBoxBytes.Text = cadenaBytes;
            
            
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAnalizar_Click(object sender, EventArgs e)
        {
            //Analizador de archivos
            Analizador analizador = new Analizador();
            analizador.Detectar(v_bytesArchivo);

            labelVirusEncontrados.Visible = true;
            labelVirusEncontrados.Text = "No hay virus";
            
        }

        private void FormVentana_Load(object sender, EventArgs e)
        {

        }
    }
}
