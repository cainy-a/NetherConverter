using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetherConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OverworldXtext_TextChanged(object sender, EventArgs e)
        {
            if (OverworldXtext.Text != "")
            {
                NetherXout.Text = (System.Convert.ToDouble(OverworldXtext.Text) / 8).ToString();
            }
        }

        private void OverworldYtext_TextChanged(object sender, EventArgs e)
        {
            if (OverworldYtext.Text != "")
            {
                NetherYout.Text = System.Convert.ToDouble(OverworldYtext.Text).ToString();
            }
        }

        private void OverworldZtext_TextChanged(object sender, EventArgs e)
        {
            if (OverworldZtext.Text != "")
            {
                NetherZout.Text = (System.Convert.ToDouble(OverworldZtext.Text) / 8).ToString();
            }
        }

        private void NetherXtext_TextChanged(object sender, EventArgs e)
        {
            if (NetherXtext.Text != "")
            {
                OverworldXout.Text = (System.Convert.ToDouble(NetherXtext.Text) * 8).ToString();
            }
        }

        private void NetherYtext_TextChanged(object sender, EventArgs e)
        {
            if (NetherYtext.Text != "")
            {
                OverworldYout.Text = System.Convert.ToDouble(NetherYtext.Text).ToString();
            }
        }

        private void NetherZtext_TextChanged(object sender, EventArgs e)
        {
            if (NetherZtext.Text != "")
            {
                OverworldZout.Text = (System.Convert.ToDouble(NetherZtext.Text) * 8).ToString();
            }
        }
    }
}
