using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HC128.Desktop
{
    public partial class FrmVistaAvanzada : Form
    {
        FrmHC128 frmHC128;
        string _txtOriginal;
        string _txtEncript;

        public FrmVistaAvanzada(FrmHC128 home, string txtOriginal, string txtEncript)
        {
            frmHC128 = home;
            _txtOriginal = txtOriginal;
            _txtEncript = txtEncript;

            InitializeComponent();

            txtImgOriginal.Text = _txtOriginal;
            txtImgEncript.Text = _txtEncript;
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            frmHC128.Upload(Convert.FromBase64String(_txtEncript));
            Close();
        }
    }
}
