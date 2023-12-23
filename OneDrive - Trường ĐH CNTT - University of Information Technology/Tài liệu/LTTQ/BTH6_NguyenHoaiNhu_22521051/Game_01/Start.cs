using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_01
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void button_HuongDan_Click(object sender, EventArgs e)
        {
            Intro intro = new Intro();
            intro.ShowDialog();
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            this.Hide();
            Game1 game1 = new Game1();
            game1.ShowDialog();
            this.Close();

        }
    }
}
