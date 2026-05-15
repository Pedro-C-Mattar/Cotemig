using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace Prj_OrdemServico
{
    public partial class FrmTecnico : Form
    {
        BLL_Tecnico objBLLTecnico = new BLL_Tecnico();
        BLL_Especialidade objBLLEspecialidade = new BLL_Especialidade();
        DTO_Tecnico objDTOTecnico = new DTO_Tecnico();
        public FrmTecnico()
        {
            InitializeComponent();
        }

        public void Limpar()
        {
            txtid.Clear();            
            txtnome.Clear();            
            cmbEspecialidade.SelectedIndex = -1;
        }

        public void CarregarGrid()
        {
            try
            {
                dtgTecnico.DataSource = objBLLTecnico.ListarTecnicos();
                cmbEspecialidade.DataSource = objBLLEspecialidade.ListarEspecialidades();
                cmbEspecialidade.DisplayMember = "nome_especialidade";
                cmbEspecialidade.ValueMember = "id_especialidade";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtid.Text.Trim() == string.Empty)
                {  
                    objDTOTecnico.Nome = txtnome.Text;
                    objDTOTecnico.Espec_id = Convert.ToInt32(cmbEspecialidade.SelectedValue);

                    objBLLTecnico.InserirTecnico(objDTOTecnico);
                    MessageBox.Show("Tecnico Cadastrado");
                }
                Limpar();
                CarregarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtid.Text.Trim() != string.Empty)
                {
                    objDTOTecnico.Id = int.Parse(txtid.Text);                    
                    objBLLTecnico.ExcluirTecnico(objDTOTecnico.Id);
                    MessageBox.Show("Tecnico Excluido");
                }
                Limpar();
                CarregarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtgUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dtgTecnico.Rows[e.RowIndex].Cells[0].Value.ToString();            
            txtnome.Text = dtgTecnico.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmbEspecialidade.SelectedValue = dtgTecnico.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void dtgTecnico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dtgTecnico.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtnome.Text = dtgTecnico.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmbEspecialidade.SelectedValue = dtgTecnico.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                objBLLTecnico.ListarTecnicos();
                MessageBox.Show("Consulata Realizada");
                Limpar();
                CarregarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtid.Text.Trim() == string.Empty)
                {
                    objDTOTecnico.Id = int.Parse(txtid.Text);
                    objDTOTecnico.Nome = txtnome.Text;
                    objDTOTecnico.Espec_id = Convert.ToInt32(cmbEspecialidade.SelectedValue);

                    objBLLTecnico.AlterarTecnico(objDTOTecnico);
                    MessageBox.Show("Tecnico Alterado");
                }
                Limpar();
                CarregarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
