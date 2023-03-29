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
    public partial class FormInfo : Form
    {
        Player _newPlayer;
        public FormInfo()
        {
            InitializeComponent();
        }

        private void newPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string lastname = tbLastName.Text;
            string studentid = tbStudentID.Text;
            string major = tbMajor.Text;
            string displayname = tbDisplayName.Text;
            string mail = tbMail.Text;
            string phone = tbPhone.Text;
            int iAge = 0;
            try
            {
                string age = tbAge.Text;
                iAge = Int32.Parse(age);
            }
            catch (FormatException ex) 
            {
                MessageBox.Show("ใส่ข้อมูลไม่ถูกต้อง");
                return;
            }

            _newPlayer = new Player(name, lastname, studentid, major, 
                displayname, mail, phone, iAge);

            this.DialogResult = DialogResult.OK;
        }
        public Player getPlayer()
        {
            return _newPlayer;
        }
    }
}
