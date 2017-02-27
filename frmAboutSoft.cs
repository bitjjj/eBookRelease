using System;
using System.Windows.Forms;

namespace eBookRelease
{
    public partial class frmAboutSoft : Form
    {
        private static frmAboutSoft instance = null;
        
        private frmAboutSoft()
        {
            InitializeComponent();
        }

        public static frmAboutSoft GetInstance()
        {
            if(instance==null)
            {
                instance=new frmAboutSoft();
            }
            return instance;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
