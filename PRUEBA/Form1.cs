using PRUEBA.Vista;
using System;
using System.Windows.Forms;

namespace PRUEBA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnArbol_Click(object sender, EventArgs e)
        {
            FrmArbol frmArbol = new FrmArbol();
            frmArbol.Show();
        }

        private void btnGrafo_Click(object sender, EventArgs e)
        {
            FrmGrafo frmGrafo = new FrmGrafo();
            frmGrafo.Show();   
        }
    }
}
