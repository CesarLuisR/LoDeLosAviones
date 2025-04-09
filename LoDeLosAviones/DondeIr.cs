using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoDeLosAviones
{
    public partial class DondeIr : Form
    {
        public DondeIr()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // DondeIr
            // 
            ClientSize = new Size(282, 253);
            Name = "DondeIr";
            Load += DondeIr_Load;
            ResumeLayout(false);
        }

        private void DondeIr_Load(object sender, EventArgs e)
        {

        }
    }
}
