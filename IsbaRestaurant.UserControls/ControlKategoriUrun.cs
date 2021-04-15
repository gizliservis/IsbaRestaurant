using DevExpress.XtraEditors;
using IsbaRestaurant.Entities.Tables;
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
    public partial class ControlKategoriUrun : DevExpress.XtraEditors.XtraUserControl
    {
        public EventHandler ButtonClick;
        public ControlKategoriUrun()
        {
            InitializeComponent();

        }
        public Guid Id { get; set; }
        public Image UrunImage
        {
            get { return picFoto.Image; }
            set { picFoto.Image = value; }

        }
        public string UrunAdi
        {
            get { return groupBase.Text; }
            set { groupBase.Text = value; }
        }
       
        public IEnumerable<Porsiyon> Porsiyonlar { get; set; }
        public IEnumerable<EkMalzeme> EkMalzemeler { get; set; }
        private void GroupBase_Click(object sender, EventArgs e)
        {
            ButtonClick(this, e);
        }

        private void PicFoto_Click(object sender, EventArgs e)
        {
            ButtonClick(this, e);
        }

       
    }
}
