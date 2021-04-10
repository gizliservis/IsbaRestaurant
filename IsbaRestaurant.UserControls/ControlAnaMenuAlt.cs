using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsbaRestaurant.UserControls
{
    public partial class ControlAnaMenuAlt : DevExpress.XtraEditors.XtraUserControl
    {
        public event EventHandler ButonEkle;
        public event EventHandler ButonDuzenle;
        public event EventHandler ButonSil;
        public event EventHandler ButonGuncelle;
        public event EventHandler ButonKapat;
        private Font _buttonFont = new Font("Tahoma", 8, FontStyle.Bold);

        public Font ButtonFont { get 
            {
                return _buttonFont;
            
            } set 
            {
                btnEkle.Font = value;
                btnDuzenle.Font = value;
                btnSil.Font = value;
                btnGuncelle.Font = value;
                btnKapat.Font = value;
                _buttonFont = value;
            } }


        public ControlAnaMenuAlt()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ButonEkle?.Invoke(this, e);

        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            ButonDuzenle?.Invoke(this, e);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            ButonSil?.Invoke(this, e);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            ButonGuncelle?.Invoke(this, e);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            ButonKapat?.Invoke(this, e);
        }
    }
}
