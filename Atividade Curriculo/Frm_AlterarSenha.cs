using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_Curriculo
{
    public partial class Frm_AlterarSenha : Form
    {
        public Frm_AlterarSenha()
        {
            InitializeComponent();
        }

        private void chk_mostrarenhanova_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_mostrarenhanova.Checked)
            {
                txt_senhaNova.PasswordChar = '\0';
            }
            else
            {
                txt_senhaNova.PasswordChar = '*';
            }
        }
    }
}
