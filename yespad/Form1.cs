using System.Windows.Forms;

namespace yespad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // créer fichier et y insérer le contenu souhaité

            FileStream fs = new FileStream("test.pg3", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            string s = "Fichier texte";
            sw.WriteLine(s);
            s = "Seconde ligne";
            sw.WriteLine(s);
            s = "Ligne no 3...";
            sw.Write(s);
            s = " suite de la ligne 3";
            sw.WriteLine(s);
            sw.Close();
            fs.Close();

        }

        private void btnCharger_Click(object sender, EventArgs e)
        {
            // charge le fichier et montre son contenu dans le RichTextbox

            FileStream fs = new FileStream("test.pg3", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string s = sr.ReadToEnd();
            sr.Close();
            fs.Close();
            txtTexte.Text = s;

            txtNom.Text = "test";
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            // Enregistre le contenu de la boîte de texte

            FileStream fs = new FileStream("Test.pg3", FileMode.Create, FileAccess.Write);

            StreamWriter sw = new StreamWriter(fs);

            string contenutxtbox = txtTexte.Text;

            sw.WriteLine(contenutxtbox);

            sw.Close();
            fs.Close();
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            // Efface le contenu de la boîte de texte

            txtTexte.Clear();
        }

        private void btnTerminer_Click(object sender, EventArgs e)
        {
            // Ferme l'application

            Close();
        }
    }
}