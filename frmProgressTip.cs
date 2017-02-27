using System.Windows.Forms;

namespace eBookRelease
{
    public partial class frmProgressTip : Form
    {
        private static frmProgressTip instance = null;

        private  frmProgressTip()
        {
            InitializeComponent();
        }

        public static frmProgressTip GetInstance()
        {
            if(instance==null)
            {
                instance = new frmProgressTip();
            }              
            return instance;
        }
    }
}
