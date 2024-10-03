using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_ar_condicionado
{
    public partial class frm_cadastro_busca : Form
    {
        public frm_cadastro_busca()
        {
            InitializeComponent();
        }

       //------------------------------------------------------------//
       //focus

        private void txb_nome_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                maskedTextBox_telefone.Focus();
            }
        }

        private void maskedTextBox_telefone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                maskedTextBox_cpf.Focus();
            }
        }

        private void maskedTextBox_cpf_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txb_gmail.Focus();
            }
        }

        private void txb_gmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                maskedTextBox_cep.Focus();
            }
        }

        private void maskedTextBox_cep_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                txb_rua.Focus();
            }
        }

        private void txb_rua_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                maskedTextBox_numero.Focus();
            }
        }

        private void maskedTextBox_numero_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                txb_bairro.Focus();
            }
        }

        private void txb_bairro_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                txb_cidade.Focus();
            }
        }

        private void txb_cidade_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button2_Click(sender, e);
            }
        }
        //--------------------------------------------------------------------//


        private void button2_Click(object sender, EventArgs e)
        {
           if((txb_nome.Text=="") || (comboBox_tipo.Text=="") || (maskedTextBox_numero.Text == "" ) 
              || (maskedTextBox_telefone.Text=="") || (maskedTextBox_cpf.Text=="") || (txb_gmail.Text=="") 
              || (txb_rua.Text=="") || (txb_bairro.Text == "")|| (txb_cidade.Text== "")) 
           {                             
                MessageBox.Show("algum campo necessario esta vazio","erro",MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
           else
           {
                MessageBox.Show("Cadastro bem sucedido", "cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txb_bairro.Clear();
            txb_cidade.Clear();
            txb_nome.Clear();
            txb_gmail.Clear();
            txb_rua.Clear();
            txb_cidade.Clear();
            txb_complemento.Clear();
            txb_bairro.Clear();
            maskedTextBox_cep.Clear();
            maskedTextBox_telefone.Clear();
            maskedTextBox_cpf.Clear();
            maskedTextBox_numero.Clear();
            comboBox_tipo = null;
                
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                string cep = maskedTextBox_cep.Text;
                string xml = "https://viacep.com.br/ws/" + cep + "/xml/";
                // Criar um dataset para enviar e receber os dados
                DataSet dados = new DataSet();

                // ler o xml
                dados.ReadXml(xml);

                txb_rua.Text = dados.Tables[0].Rows[0]["logradouro"].ToString();
                txb_bairro.Text = dados.Tables[0].Rows[0]["bairro"].ToString();
                txb_cidade.Text = dados.Tables[0].Rows[0]["localidade"].ToString();
               
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_dastro_busca_Load(object sender, EventArgs e)
        {

        }
    }
}
