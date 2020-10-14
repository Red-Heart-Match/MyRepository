using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CycNumExpress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void change(object sender, EventArgs e)
        {
            //有参构造实现
            //CircleNum circNum = new CircleNum(cirNumTBox.Text);
            //fracTBox.Text = circNum.Fraction;

            //无参构造实现
            CircleNum circNum = new CircleNum();
            circNum.CircNum = cirNumTBox.Text;
            fracTBox.Text = circNum.ChangeToFraction();

        }
    }
}
