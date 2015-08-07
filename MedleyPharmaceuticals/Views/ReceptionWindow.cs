using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using Medley.DAL.Contexts;

namespace Medley.UI.Views
{
    public partial class ReceptionWindow : Form
    {
        
        MedleyContext MedleyDB = new MedleyContext();
        int page = 1;
        int perPage = 10;

        public ReceptionWindow()
        {
            InitializeComponent();
        }

        private void HomeWindow_Load(object sender, EventArgs e)
        {
            //new MedleyDBInitializer().Truncate();
            //if (MedleyDB.ReceivedGoods.ToList().Count == 0)
            {
                //new MedleyDBInitializer().Initialize();
            }
            
            // Load is an extension method on IQueryable,  
            // defined in the System.Data.Entity namespace. 
            // This method enumerates the results of the query,  
            // similar to ToList but without creating a list. 
            // When used with Linq to Entities this method  
            // creates entity objects and adds them to the context. 
            //if (MedleyDB.RawProduct.ToList().Count > 0)
            {
                //MedleyDB.ReceivedGoods.Load();
                // After the data is loaded call the DbSet<T>.Local property  
                // to use the DbSet<T> as a binding source. 
                //this.cmpReceivedGoodBindingSource.DataSource = MedleyDB.ReceivedGoods.Local.ToBindingList().Skip((page - 1) * perPage).Take(perPage);
                //this.cmpReceivedGoodBindingSource.DataSource = MedleyDB.ReceivedGoods.Local.ToBindingList();
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.MedleyDB.SaveChanges();
                this.receivedGoodDataGridView.Refresh();

                MessageBox.Show("Data saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void receivedGoodBindingSource_CurrentChanged(object sender, EventArgs e)
        {
        
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
        
        }

        private void receivedGoodBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.MedleyDB.SaveChanges();
                this.receivedGoodDataGridView.Refresh();

                MessageBox.Show("Data saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bindingNavigatorDeleteItem_Click_1(object sender, EventArgs e)
        {
            deleteCurrentRecord();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            
        }

        private void deleteCurrentRecord()
        {
            if(MessageBox.Show("Do you want to delete the record?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // in order to delete from database, remove via the binding component
                this.cmpReceivedGoodBindingSource.RemoveCurrent();
                MedleyDB.SaveChanges();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteCurrentRecord();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //if (page < (Math.Ceiling(MedleyDB.ReceivedGoods.Local.Count / (Double)perPage)))
            {
                page += 1;
            }
            //this.cmpReceivedGoodBindingSource.DataSource = MedleyDB.ReceivedGoods.Local.ToBindingList().Skip((page - 1) * perPage).Take(perPage);
            //this.receivedGoodDataGridView.Refresh();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (page > 1)
            {
                page -= 1;
            }

            //this.cmpReceivedGoodBindingSource.DataSource = MedleyDB.ReceivedGoods.Local.ToBindingList().Skip((page - 1) * perPage).Take(perPage);
            //this.receivedGoodDataGridView.Refresh();
        }

    }
}
