using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorChangerUC
{
    public partial class UC : UserControl
    {
        public event EventHandler ButtonClick;

        public UC()
        {
            InitializeComponent();
        }

        public void ChangeColor( Color color)
        {
            BackColor = color;
        }

        private void UC_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.ButtonClick != null)
            {
                this.ButtonClick(this, e);
            }

            MessageBox.Show(this.textBox1.Text,"TextBox Content", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
    }
}
