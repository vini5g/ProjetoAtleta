using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAtleta
{
    public partial class frmIMC : Form
    {
        public frmIMC()
        {
            InitializeComponent();
        }

        Atleta objAtleta = new Atleta();

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool err = false;
            try
            {
                objAtleta.Nome = txtNome.Text;
                objAtleta.Idade = int.Parse(txtIdade.Text);
                objAtleta.Peso = double.Parse(txtPeso.Text.Replace(".", ","));
                objAtleta.Altura = double.Parse(txtAltura.Text.Replace(".", ","));
            }
            catch (FormatException erro)
            {
                err = true;
                MessageBox.Show("Erro na execução do fromulário. Preenchimento do formulário inválido! " + erro.GetType());
            }
            catch (Exception erro)
            {
                err = true;
                MessageBox.Show(erro.Message);
            }
            finally
            {
                if (err != true)
                {
                    MessageBox.Show("Dados do atleta " + objAtleta.Nome + " salvos com sucesso!!!");
                    btnCalcular.Enabled = true;
                }
                else
                {
                    btnCalcular.Enabled = false;
                }
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            lblUsuario.Text = objAtleta.Nome;
            txtIMC.Text = objAtleta.CalculaIMC().ToString("0.00");
            btnCalcular.Enabled = false;
            limpar();
        }

        public void limpar()
        {
            txtNome.Text = "";
            txtIdade.Text = "";
            txtAltura.Text = "";
            txtPeso.Text = "";
            txtNome.Focus();
        }
    }
}
