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
    public partial class Form1 : Form
    {
        internal static List<Times> timesList = new List<Times>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddTime form = new frmAddTime();
            form.Show();
        }
        internal static void addTime(Times time)
        {
            timesList.Add(time);
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Partida novoCampeonato = new Partida();
            Times campeao = novoCampeonato.Campeonato(timesList);
            MessageBox.Show("O time campeão foi: " + campeao.NomeTime);
        }
    }
}
