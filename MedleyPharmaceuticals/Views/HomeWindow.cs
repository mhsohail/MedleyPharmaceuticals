using MedleyPharmaceuticals.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medley.Core.Views
{
    public partial class HomeWindow : Form
    {
        public HomeWindow()
        {
            InitializeComponent();
        }

        private void btnReception_Click(object sender, EventArgs e)
        {
            ReceptionWindow rw = new ReceptionWindow();
            rw.ShowDialog();
        }

        private void HomeWindow_Load(object sender, EventArgs e)
        {
            Button[] buttons = this.Controls.OfType<Button>().Where(c=>c.Name.Contains("Rec")).ToArray();
            //MessageBox.Show(buttons.Length.ToString());
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            new StoreWindow().ShowDialog();
        }
    }
}
