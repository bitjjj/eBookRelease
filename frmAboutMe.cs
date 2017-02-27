using System;
using System.Windows.Forms;

namespace eBookRelease
{
    public partial class frmAboutMe : Form
    {
        private static frmAboutMe instance = null;
        
        public frmAboutMe()
        {
            InitializeComponent();
        }

        public static frmAboutMe GetInstance()
        {
            if(instance==null)
            {
                instance=new frmAboutMe();
            }
            return instance;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
