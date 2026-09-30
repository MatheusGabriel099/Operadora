using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operadora
{
    public partial class frm_principal : Form
    {
        public frm_principal()
        {
            InitializeComponent();
        }

        private void btn_Vivo_CheckedChanged(object sender, EventArgs e)
        {
            //Muda a cor do fundo
            BackColor = Color.DarkViolet;
            //Ativar
            lbl_BemVindo.Enabled = true;
            lbl_Nome.Enabled = true;
            txt_nome.Enabled = true;
            lbl_OperadoraSelecionada.Enabled = true;
            txt_OperadoraSelecionada.Enabled = true;
            lbl_DDD.Enabled = true;
            txt_DDD.Enabled = true;
            lbl_NumeroCelular.Enabled = true;
            txt_NumeroCelular.Enabled = true;
            lbl_ValorRecarga.Enabled = true;
            txt_ValorRecarga.Enabled = true;
            txt_ValorRecarga.Enabled = true;
            btn_RS1.Enabled = true;
            lbl_Validade1.Enabled = true;
            btn_RS2.Enabled = true;
            lbl_Validade2.Enabled = true;
            btn_RS3.Enabled = true;
            lbl_Validade3.Enabled = true;
            btn_RS4.Enabled = true;
            lbl_Validade4.Enabled = true;
            btn_RS5.Enabled = true;
            lbl_Validade5.Enabled = true;
            btn_RS6.Enabled = true;
            lbl_Validade6.Enabled = true;
            btn_RS7.Enabled = true;
            lbl_Validade7.Enabled = true;
            btn_RS8.Enabled = true;
            lbl_Validade8.Enabled = true;
        }

        private void pcb_image_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Oi_CheckedChanged(object sender, EventArgs e)
        {
            //Muda a cor do fundo
            BackColor = Color.DarkOrange;
            //Ativar as propiedades
            lbl_BemVindo.Enabled = true;
            lbl_Nome.Enabled = true;
            txt_nome.Enabled = true;
            lbl_OperadoraSelecionada.Enabled = true;
            txt_OperadoraSelecionada.Enabled = true;
            lbl_DDD.Enabled = true;
            txt_DDD.Enabled = true;
            lbl_NumeroCelular.Enabled = true;
            txt_NumeroCelular.Enabled = true;
            lbl_ValorRecarga.Enabled = true;
            txt_ValorRecarga.Enabled = true;
            lbl_SelecioneValor.Enabled = true;
            btn_RS1.Enabled = true;
            lbl_Validade1.Enabled = true;
            btn_RS2.Enabled = true;
            lbl_Validade2.Enabled = true;
            btn_RS3.Enabled = true;
            lbl_Validade3.Enabled = true;
            btn_RS4.Enabled = true;
            lbl_Validade4.Enabled = true;
            btn_RS5.Enabled = true;
            lbl_Validade5.Enabled = true;
            btn_RS6.Enabled = true;
            lbl_Validade6.Enabled = true;
            btn_RS7.Enabled = true;
            lbl_Validade7.Enabled = true;
            btn_RS8.Enabled = true;
            lbl_Validade8.Enabled = true;
        }

        private void btn_Claro_CheckedChanged(object sender, EventArgs e)
        {
            //Formatação cores
            BackColor = Color.Red;
            //Ativar as propiedades
            lbl_BemVindo.Enabled = true;
            lbl_Nome.Enabled = true;
            txt_nome.Enabled = true;
            lbl_OperadoraSelecionada.Enabled = true;
            txt_OperadoraSelecionada.Enabled = true;
            lbl_DDD.Enabled = true;
            txt_DDD.Enabled = true;
            lbl_NumeroCelular.Enabled = true;
            txt_NumeroCelular.Enabled = true;
            lbl_ValorRecarga.Enabled = true;
            txt_ValorRecarga.Enabled = true;
            lbl_SelecioneValor.Enabled = true;
            btn_RS1.Enabled = true;
            lbl_Validade1.Enabled = true;
            btn_RS2.Enabled = true;
            lbl_Validade1.Enabled = true;
            btn_RS3.Enabled = true;
            lbl_Validade3.Enabled = true;
            btn_RS4.Enabled = true;
            lbl_Validade4.Enabled = true;
            btn_RS5.Enabled = true;
            lbl_Validade5.Enabled = true;
            btn_RS6.Enabled = true;
            lbl_Validade6.Enabled = true;
            btn_RS7.Enabled = true;
            lbl_Validade7.Enabled = true;
            btn_RS8.Enabled = true;
            lbl_Validade8.Enabled = true;
        }

        private void btn_Tim_CheckedChanged(object sender, EventArgs e)
        {
            //Formatação cores
            BackColor = Color.Blue;
            //Ativar as propiedades
            lbl_BemVindo.Enabled = true;
            lbl_Nome.Enabled = true;
            txt_nome.Enabled = true;
            lbl_OperadoraSelecionada.Enabled = true;
            txt_OperadoraSelecionada.Enabled = true;
            lbl_DDD.Enabled = true;
            txt_DDD.Enabled = true;
            lbl_NumeroCelular.Enabled = true;
            txt_NumeroCelular.Enabled = true;
            lbl_ValorRecarga.Enabled = true;
            txt_ValorRecarga.Enabled = true;
            lbl_SelecioneValor.Enabled = true;
            btn_RS1.Enabled = true;
            lbl_Validade1.Enabled = true;
            btn_RS2.Enabled = true;
            lbl_Validade2.Enabled = true;
            btn_RS3.Enabled = true;
            lbl_Validade3.Enabled = true;
            btn_RS4.Enabled = true;
            lbl_Validade4.Enabled = true;
            btn_RS5.Enabled = true;
            lbl_Validade5.Enabled = true;
            btn_RS6.Enabled = true;
            lbl_Validade6.Enabled = true;
            btn_RS7.Enabled = true;
            lbl_Validade7.Enabled = true;
            btn_RS8.Enabled = true;
            lbl_Validade8.Enabled = true;

        }
    }
}
