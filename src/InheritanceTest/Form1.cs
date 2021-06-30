using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InheritanceTest
{
    public partial class Form1 : Form
    {
        COneCycle _cOC;

        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            _cOC = new COneCycle("외발 자전거");
        }

        private void btnOneCycle_Click(object sender, EventArgs e)
        {
            OneCycleDraw();
        }


        /// <summary>
        ///  OneCycle에 대한 위치 그림을 그려준다
        /// </summary>
        private void OneCycleDraw()
        {
            COneCycle cOC = new COneCycle("외발 자전거");
            lblName.Text = cOC.strName;

            Graphics g = pMain.CreateGraphics();
            Pen p = cOC.fPenInfo();

            g.DrawRectangle(p, cOC._rtSquare1);
            g.DrawEllipse(p, cOC._rtCircle1);




        }

        
    }
}
