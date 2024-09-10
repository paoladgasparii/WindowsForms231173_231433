using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms231173_231433
{
    public partial class Mercado : Form
    {
        double total;
        
        public Mercado()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void btninserir_Click(object sender, EventArgs e)
        {

            dgvprodutos.Rows.Add(txtproduto.Text, txtquantidade.Text, txtvalor.Text);

            total += double.Parse(txtquantidade.Text) * double.Parse(txtvalor.Text);
            lbltotal.Text = total.ToString("C");

            txtproduto.Clear();
            txtquantidade.Clear();
            txtvalor.Clear();

            MessageBox.Show("Produto Incluido com sucesso", "Inclusão",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
            lblvenda.Text = dgvprodutos.RowCount.ToString();

            

        }

        private void btnremover_Click(object sender, EventArgs e)
        {
            if (dgvprodutos.RowCount > 0)
            {
                total -= double.Parse(dgvprodutos.CurrentRow.Cells[1].Value.ToString()) * double.Parse(dgvprodutos.CurrentRow.Cells[2].Value.ToString());
                dgvprodutos.Rows.RemoveAt(dgvprodutos.CurrentRow.Index);

                MessageBox.Show("Produto Excluído com sucesso", "Exclusão",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               
                lblvenda.Text = dgvprodutos.RowCount.ToString();       
                lbltotal.Text = total.ToString("C");
            }
        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            if (txtalterar.Text != "")
            {
                total += (double.Parse(txtalterar.Text) - double.Parse(dgvprodutos.CurrentRow.Cells[1].Value.ToString()))  * double.Parse(dgvprodutos.CurrentRow.Cells[2].Value.ToString());
                dgvprodutos.CurrentRow.Cells[1].Value = txtalterar.Text;
                
                MessageBox.Show("Quantidade Alterada com sucesso", "Alterada",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               
            }
            txtalterar.Clear();
            lbltotal.Text = total.ToString("C");
        }

        private void txtalterar_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvprodutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvprodutos.RowCount > 0)
            { 
                txtalterar.Text = dgvprodutos.CurrentRow.Cells[1].Value.ToString();
                
            }

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (dgvprodutos.RowCount > 0)
            {
                dgvprodutos.Rows.Clear();

                MessageBox.Show("Venda Cancelada com sucesso", "Cancelamento",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                lblvenda.Text = dgvprodutos.RowCount.ToString();

                total = 0;
                lbltotal.Text = total.ToString("C");
            }

        }

        private void btnfinalizar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btngravar_Click(object sender, EventArgs e)
        {
            if (dgvprodutos.RowCount > 0)
            {
                dgvprodutos.Rows.Clear();

                MessageBox.Show("Venda Gravada com sucesso", "Gravação",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);;

            }
        }

        private void Mercado_Load(object sender, EventArgs e)
        {
            
        }

        private void lbltotal_Click(object sender, EventArgs e)
        {
            lbltotal.Text = total.ToString("C");
        }
    }
}
