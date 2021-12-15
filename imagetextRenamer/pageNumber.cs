using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imagetextRenamer
{
    public partial class pageNumber : Form
    {
        private Form1 _parent { get; set; }

        public pageNumber(Form1 parent)
        {
            _parent = parent;
            InitializeComponent();
            numericUpDown1.Text = parent.specifyPagenumber.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _parent.specifyPagenumber= (int)numericUpDown1.Value;
            this.Close();
        }
    }
}
