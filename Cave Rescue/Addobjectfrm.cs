using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaveRescue
{
    public partial class Addobjectfrm : Form
    {
        public Addobjectfrm()
        {
            InitializeComponent();
        }

        string Nameofobject = "";
        string Weightingofobject= "";

        private void btn_makenewobject_Click(object sender, EventArgs e)
        {
           

        }

        private void btn_addnameofobject_Click(object sender, EventArgs e)
        {

            txt_nameofobject.Text = Nameofobject;
            txt_weightofobject.Text = Weightingofobject;

        }
    }
}
