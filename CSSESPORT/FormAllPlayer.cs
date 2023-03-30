using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSSESPORT
{
    public partial class FormAllPlayer : Form
    {
        List<Player> listPlayer = new List<Player>();
        public FormAllPlayer()
        {
            InitializeComponent();

            dataGridView1.DataSource = listPlayer;
        }

        private void newPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInfo formInfo = new FormInfo();
            formInfo.ShowDialog();

            if (formInfo.DialogResult == DialogResult.OK) 
            {
                Player newPlayer = formInfo.getPlayer();
                this.listPlayer.Add(newPlayer);

                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource = listPlayer;
                formInfo.Close();
            }
        }
    }
}
