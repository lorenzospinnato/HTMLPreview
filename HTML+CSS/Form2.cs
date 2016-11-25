using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTML_CSS
{
    public partial class Form2 : Form
    {

        public static string filehtml;
        public bool cssexist = false;
        public static string filecss;
        public static string dir;
        public static string dircss;
        public Form2()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Al click del pulsante viene creata la cartella nel percorso indicato
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (!System.IO.Directory.Exists(@"C:\htmlpreview")) //Si controlla l'esistenza della cartella all'interno della partizione C:\
            {
                System.IO.Directory.CreateDirectory(@"C:\htmlpreview"); //In caso contrario viene creata
            }
            filecss = textBox2.Text;
            dircss = @"C:\htmlpreview\" + filecss + ".css";

            
            if (textBox2.Text != "") //Viene creato il file .css
            {
                using (System.IO.File.Create(dircss)) { };
            }
            else
            {
                MessageBox.Show("Il file .css non verrà creato");
            }
            filehtml = textBox1.Text;
            dir = @"C:\htmlpreview\" + filehtml + ".html";

            if (textBox1.Text != "") //Viene creato il file.html
            {
                using (System.IO.File.Create(dir)) { };
                this.Hide();
            }
            else
            {
                MessageBox.Show("Inserisci il nome del file");
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
