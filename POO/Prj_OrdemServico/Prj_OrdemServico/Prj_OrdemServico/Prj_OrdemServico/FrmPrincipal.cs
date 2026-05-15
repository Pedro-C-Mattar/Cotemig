using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj_OrdemServico
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario tela = new FrmUsuario();  
            tela.ShowDialog();
        }

        private void tecnicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTecnico tela = new FrmTecnico();
            tela.ShowDialog();
        }
    }
}
