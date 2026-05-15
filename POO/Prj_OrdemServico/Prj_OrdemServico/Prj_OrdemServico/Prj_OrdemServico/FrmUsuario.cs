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
    public partial class FrmUsuario : Form
    {
        BLL_Usuario objBLLUsuario = new BLL_Usuario();
        BLL_Setor objBLLSetor = new BLL_Setor();
        DTO_Usuario objDTOUsuario = new DTO_Usuario();
        public FrmUsuario()
        {
            InitializeComponent();
        }

        public void Limpar()
        {
            txtid.Clear();
            txtemail.Clear();
            txtnome.Clear();
            txttelefone.Clear();
            cmbSetor.SelectedIndex = -1;
        }

        public void CarregarGrid()
        {
            try
            {
                dtgUsuarios.DataSource = objBLLUsuario.ListarUsuarios();
                cmbSetor.DataSource = objBLLSetor.ListarSetores();
                cmbSetor.DisplayMember = "nome_setores";
                cmbSetor.ValueMember = "id_setores";
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
                    objDTOUsuario.Nome = txtnome.Text;  
                    objDTOUsuario.Email = txtemail.Text;
                    objDTOUsuario.Tel = txttelefone.Text;
                    objDTOUsuario.Setor_id = Convert.ToInt32(cmbSetor.SelectedValue);

                    objBLLUsuario.InserirUsuario(objDTOUsuario);
                    MessageBox.Show("Usuario Cadastrado");
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
                    objDTOUsuario.Id = int.Parse(txtid.Text);                    

                    objBLLUsuario.ExcluirUsuario(objDTOUsuario.Id);
                    MessageBox.Show("Usuario Excluido");
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
            txtid.Text = dtgUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString();
            cmbSetor.SelectedValue = dtgUsuarios.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtnome.Text = dtgUsuarios.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtemail.Text = dtgUsuarios.Rows[e.RowIndex].Cells[3].Value.ToString();
            txttelefone.Text = dtgUsuarios.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                objBLLUsuario.ListarUsuarios();
                MessageBox.Show("Consulata Realizada");
                Limpar();
                CarregarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtgUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dtgUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString();
            cmbSetor.SelectedValue = dtgUsuarios.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtnome.Text = dtgUsuarios.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtemail.Text = dtgUsuarios.Rows[e.RowIndex].Cells[3].Value.ToString();
            txttelefone.Text = dtgUsuarios.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtid.Text.Trim() == string.Empty)
                {
                    objDTOUsuario.Id = int.Parse(txtid.Text);
                    objDTOUsuario.Nome = txtnome.Text;
                    objDTOUsuario.Email = txtemail.Text;
                    objDTOUsuario.Tel = txttelefone.Text;
                    objDTOUsuario.Setor_id = Convert.ToInt32(cmbSetor.SelectedValue);

                    objBLLUsuario.AlterarUsuario(objDTOUsuario);
                    MessageBox.Show("Usuario Alterado");
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
