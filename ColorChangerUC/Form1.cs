using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorChangerUC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            uc1.ChangeColor(Color.Gray);
            uc1.ButtonClick += new EventHandler(UC_ButtonClick);
        }

        protected void UC_ButtonClick(object sender, EventArgs e)
        {
            
        }
    }
}
