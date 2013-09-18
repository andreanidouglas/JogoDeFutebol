using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_de_Futeboll
{
    public partial class frmAddTime : Form
    {
        public frmAddTime()
        {
            InitializeComponent();
        }
        public bool finishSucessfull = false;
        internal Times time = new Times();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            try
            {
                time.NomeTime = tdbtNome.Text;
                time.forcaAtaque = Convert.ToInt32(tdbtAtaque.Text);
                time.forcaDefesa = Convert.ToInt32(tdbtDefesa.Text);
                Form1.addTime(time);
                MessageBox.Show("Time Adcionado com sucesso", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                finishSucessfull = true;
                this.Close();
            }
            catch (Exception wee)
            {
                MessageBox.Show("Erro na entrada de valores!\n" + wee.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
