using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc_deleget_event
{
    public partial class hasil : Form
    {
        public hasil()
        {
            InitializeComponent();
        }

        public void addHasil(String hasil)
        {
            listHasil.Items.Add(hasil);
        }

        private void hitung_Click(object sender, EventArgs e)
        {
            Oprasi op = new Oprasi();
            op.proses += addHasil;
            op.StartPosition = FormStartPosition.Manual;
            op.Location = new Point(this.Right,100);  
            op.Show(this);
        }

       
    }
}
