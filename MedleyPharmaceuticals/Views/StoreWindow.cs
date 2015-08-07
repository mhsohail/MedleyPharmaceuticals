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
    public partial class StoreWindow : Form
    {
        MedleyContext MedleyDB = new MedleyContext();
        int page = 1;
        int perPage = 10;

        public StoreWindow()
        {
            InitializeComponent();
        }

        private void receivedGoodBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void StoreWindow_Load(object sender, EventArgs e)
        {
            // Call the Load method to get the data for the given DbSet  
            // from the database.  
            // The data is materialized as entities. The entities are managed by  
            // the DbContext instance.  
            // Load is an extension method on IQueryable,  
            // defined in the System.Data.Entity namespace. 
            // This method enumerates the results of the query,  
            // similar to ToList but without creating a list. 
            // When used with Linq to Entities this method  
            // creates entity objects and adds them to the context. 
            //MedleyDB.ReceivedGoods.Load();
            
            // Bind the categoryBindingSource.DataSource to  
            // all the Unchanged, Modified and Added Category objects that  
            // are currently tracked by the DbContext. 
            // Note that we need to call ToBindingList() on the  
            // ObservableCollection<TEntity> returned by 
            // the DbSet.Local property to get the BindingList<T> 
            // in order to facilitate two-way binding in WinForms. 
            
            //this.receivedGoodBindingSource.DataSource = MedleyDB.ReceivedGoods.Local.ToBindingList();
            
        }
        
        private void btnStoredProducts_Click(object sender, EventArgs e)
        {
            StoreItemsCount frmStoreItemsCount = new StoreItemsCount();
            frmStoreItemsCount.ShowDialog();
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

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void btnDeliveredProducts_Click(object sender, EventArgs e)
        {
            //MedleyDB.ReceivedGoods.Load();
            //this.receivedGoodBindingSource.DataSource = MedleyDB.ReceivedGoods.Local.ToBindingList().Where(d => d.DeliveredToStore.Equals(true));
        }

        private void btnNondeliveredProducts_Click(object sender, EventArgs e)
        {
            //MedleyDB.ReceivedGoods.Load();
            //this.receivedGoodBindingSource.DataSource = MedleyDB.ReceivedGoods.Local.ToBindingList().Where(d => d.DeliveredToStore.Equals(false));
        }
    }
}
