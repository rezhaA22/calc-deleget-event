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
    public partial class Oprasi : Form
    {
        public delegate void btnClik(String hasil);

        public event btnClik proses;


        public Oprasi()
        {
            InitializeComponent();
            list_oprasi.SelectedIndex = 0;
            
        }

      

        private void btn_proses_Click(object sender, EventArgs e)
        {
            String oprasi = list_oprasi.SelectedItem.ToString();
            int nilaiA = Int32.Parse(NilaiA.Text);
            int nilaiB = Int32.Parse(NilaiB.Text);
            int hasil;
            
            switch (oprasi)
            {
                case "tambah":
                    hasil = nilaiA + nilaiB;
                    proses(String.Format("hasil {0}+{1}={2}", nilaiA, nilaiB, hasil));
                    break;
                case "kurang":
                    hasil = nilaiA - nilaiB;
                    proses(String.Format("hasil {0}-{1}={2}", nilaiA, nilaiB, hasil));
                    break;
                case "kali":
                    hasil = nilaiA * nilaiB;
                    proses(String.Format("hasil {0}x{1}={2}", nilaiA, nilaiB, hasil));
                    break;
                case "bagi":
                    hasil = nilaiA / nilaiB;
                    proses(String.Format("hasil {0}:{1}={2}", nilaiA, nilaiB, hasil));
                    break;
            }
        }

        private void Oprasi_Load(object sender, EventArgs e)
        {
           
        }
    }
}
