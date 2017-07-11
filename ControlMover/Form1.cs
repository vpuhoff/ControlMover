using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlMover
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var lb = new Label() { Parent = this, Text = "Move me!" };
            foreach (Control item in this.Controls )
            {
                ControlMover.Add(item);
            }
            
            
        }
    }
}
