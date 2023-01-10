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
    public partial class Frm_Busca : Form
    {
        List<List<string>> _listaBUsca = new List<List<string>>();
        public string IdSelect { get; set; }

        public Frm_Busca(List<List<string>> listBusca)
        {
            _listaBUsca = listBusca;

            InitializeComponent();
            this.Text = "Busca";
            Tls_Principal.Items[0].ToolTipText = "Salvar Currículo";
            Tls_Principal.Items[1].ToolTipText = "Fechar";
            PrencherLista();
        }

        private void PrencherLista()
        {
            Lst_Busca.Items.Clear();

            for (int i = 0; i <= _listaBUsca.Count -1; i++)
            {
                Lst_Busca.Items.Add(_listaBUsca[i][0]);
            }

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            IdSelect = _listaBUsca[Lst_Busca.SelectedIndex][0];
            this.Close();
            

        }

        private void Tls_Principal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
