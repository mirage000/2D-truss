using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Truss_2D
{
    public partial class Joint : UserControl
    {
        Form properties_Form = new Form();
        Panel sketch_temp;
        Panel prop_temp;
        public Joint(Panel sketch,Panel properties)
        {
            InitializeComponent();
            sketch_temp = sketch;
            prop_temp = properties;
        }

        private void Joint_MouseClick(object sender, MouseEventArgs e)
        {
            prop_temp.BackColor = Color.Black;
        }

        private void Joint_Load(object sender, EventArgs e)
        {
            
        }
    }
}
