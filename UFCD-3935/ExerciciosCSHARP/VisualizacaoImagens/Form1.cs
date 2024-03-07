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

namespace VisualizacaoImagens
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            DirectoryInfo dirImagens = new DirectoryInfo("C:\\Users\\Breno Lucena\\OneDrive\\Documentos\\workspace\\.NET - C#\\UFCD-3935\\ExerciciosCSHARP\\VisualizacaoImagens\\pictures");
            FileInfo[] ficheiros;
            ficheiros = dirImagens.GetFiles();
            int numFicheiros;
            numFicheiros = ficheiros.Length;
            numericUpDown1.Minimum = 1;
            numericUpDown1.Maximum = numFicheiros;
            int numFichEscolhido;
            numFichEscolhido = (int)numericUpDown1.Value - 1;
            string caminhoFichEscolhido;
            caminhoFichEscolhido = ficheiros[numFichEscolhido].FullName;
            pictureBox1.BackgroundImage = Image.FromFile(caminhoFichEscolhido);
            toolTip1.SetToolTip(pictureBox1, caminhoFichEscolhido);
        }
    }
}
