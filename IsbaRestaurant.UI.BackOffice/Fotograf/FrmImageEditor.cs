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

namespace IsbaRestaurant.UI.BackOffice.Fotograf
{
    public partial class FrmImageEditor : DevExpress.XtraEditors.XtraForm
    {
        public Image ReturnedImage;
        public FrmImageEditor()
        {
            InitializeComponent();
        }

        private void FrmImageEditor_Load(object sender, EventArgs e)
        {

        }
    }
}