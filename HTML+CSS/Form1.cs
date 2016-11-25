using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HTML_CSS
    
{
    
    public partial class Form1 : Form
    {
        
        System.IO.StreamWriter file;
        string dir;
        string dircss;
        public Form1()
        {
            InitializeComponent();
            new Form2().ShowDialog();
        }
        /// <summary>
        /// Al caricamento della form viene eseguito un controllo sui file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            if (!System.IO.Directory.Exists(@"C:\htmlpreview")) //Si controlla l'esistenza della cartella all'interno della partizione C:\
            {
                System.IO.Directory.CreateDirectory(@"C:\htmlpreview"); //In caso contrario viene creata
            }
            this.dir = Form2.dir;
            this.dircss = Form2.dircss;
        }
        /// <summary>
        /// Al cambiamento della richboxtext1 viene effettuato un salvataggio automatico del file .html
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void richTextBox1_TextChanged(object sender, EventArgs e) 
        {
            System.IO.File.WriteAllText(dir, string.Empty);
            file = new System.IO.StreamWriter(dir);
            file.WriteLine("<html><link href=\"" + dircss + "\" rel=\"stylesheet\" type=\"text/css\">" + richTextBox1.Text + "</html>");
            file.Close();
            webBrowser1.Navigate(dir);
        }
        /// <summary>
        /// Al cambiamento della richboxtext2 viene effettuato un salvataggio automatico del file .css
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void richTextBox2_TextChanged(object sender, EventArgs e) 
        {
            System.IO.File.WriteAllText(dircss, string.Empty);
            file = new System.IO.StreamWriter(dircss);
            file.WriteLine(richTextBox2.Text);
            file.Close();
            webBrowser1.Navigate(dir);
        }
    }
}
