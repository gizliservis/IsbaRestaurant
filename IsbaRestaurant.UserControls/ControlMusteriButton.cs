using DevExpress.XtraEditors;
using IsbaRestaurant.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsbaRestaurant.UserControls
{
    public class ControlMusteriButton : SimpleButton
    {
        private MusteriTip musteriTip;

        public Guid MusteriId { get; set; }
        public string Adi { get; set; }
        public string Soyadı { get; set; }
        public MusteriTip MusteriTip
        {
            get
            {
                return musteriTip;
            }
            set
            {
                switch (value)
                {
                    case MusteriTip.Platin:
                        Appearance.BackColor = Color.LightPink;
                        break;
                    case MusteriTip.Gold:
                        Appearance.BackColor = Color.Gold;
                        break;
                    case MusteriTip.Silver:
                        Appearance.BackColor = Color.Silver;
                        break;
                    default:
                        break;
                }
            }
        }
        public void Clear()
        {
            Text = "Müşteri Secilmedi";
            MusteriId = Guid.Empty;
            Adi = null;
            Soyadı = null;
        }
    }
}
