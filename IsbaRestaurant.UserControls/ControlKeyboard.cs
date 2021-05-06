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
    public partial class ControlKeyboard : DevExpress.XtraEditors.XtraUserControl
    {
        public ControlKeyboard()
        {
            InitializeComponent();
        }

        private void KeybordButtonClick(object sender, EventArgs e)
        {
            KeybordButton button = (KeybordButton)sender;
            SendKeys.Send(button.Text);
        }

        private void keyEsc_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{ESC}");
        }

        private void keyBackSpace_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{BACKSPACE}");
        }

        private void keyTab_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{TAB}");
        }

        private void keyEnter_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{ENTER}");
        }

        private void keyYukariOk_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{UP}");
        }

        private void keyAsagiOk_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{DOWN}");
        }

        private void keySolOk_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{LEFT}");
        }

        private void keySagOk_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{RIGHT}");
        }

        private void keyDel_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{DEL}");
        }
    }
}
