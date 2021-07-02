using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EnumItem[] ei = (EnumItem[])Enum.GetValues(typeof(EnumItem));

            foreach (EnumItem eitem in ei)
            {
                cboxItem.Items.Add(eitem.ToString());
            }

            foreach (EnumRate eitem in (EnumRate[])Enum.GetValues(typeof(EnumRate)))
            {
                cboxRate.Items.Add(eitem.ToString());
            }


        }
    }
}
