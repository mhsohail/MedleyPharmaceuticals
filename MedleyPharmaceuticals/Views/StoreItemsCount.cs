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

namespace MedleyPharmaceuticals.Views
{
    public partial class StoreItemsCount : Form
    {
        MedleyModelContainer MedleyDB = new MedleyModelContainer();
        int page = 1;
        int perPage = 10;

        public StoreItemsCount()
        {
            InitializeComponent();
        }

        private void StoreItemsCount_Load(object sender, EventArgs e)
        {
        //    MedleyDB.ReceivedGoods.Load();
            
        //    // populate the combo box with item names from database
        //    var list2 = MedleyDB.ReceivedGoods.Select(m => m.MaterialName).Distinct();
        //    foreach (var item in list2)
        //    {
        //        comboBox1.Items.Add(item.ToString());
        //    }

        //    var list = MedleyDB.ReceivedGoods.Where(a => a.DeliveredToStore.Equals(true)).GroupBy(a => a.MaterialName).Select(obj => new
        //    {
        //        MaterialName = obj.Key,
        //        Count = obj.Count(),
        //        CountNumberOfCartons = obj.Sum(i => i.NoOfCartons),
        //        Average = obj.Average(i => i.NoOfCartons)
        //    });
            
        //    foreach (var a in list) {
        //        DataGridViewRow dgvRow = new DataGridViewRow();
        //        dgvRow.CreateCells(dataGridView1);
        //        dgvRow.Cells[0].Value = a.MaterialName;
        //        dgvRow.Cells[1].Value = a.Count;
        //        dgvRow.Cells[2].Value = a.CountNumberOfCartons;
        //        this.dataGridView1.Rows.Add(dgvRow);
        //    }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        //    // clear the previous rows and columns in order to show the newly fetched data
        //    dataGridView1.Rows.Clear();
        //    //dataGridView1.Columns.Clear();

        //    if (((ComboBox)sender).SelectedItem.ToString().Equals("Any") || ((ComboBox)sender).SelectedItem.ToString().Equals(string.Empty))
        //    {
        //        var list = MedleyDB.ReceivedGoods.Where(a => a.DeliveredToStore.Equals(true)).GroupBy(a => a.MaterialName).Select(obj => new
        //        {
        //            MaterialName = obj.Key,
        //            Count = obj.Count(),
        //            CountNumberOfCartons = obj.Sum(i => i.NoOfCartons),
        //            Average = obj.Average(i => i.NoOfCartons)
        //        });
        //        foreach (var a in list)
        //        {
        //            DataGridViewRow dgvRow = new DataGridViewRow();
        //            dgvRow.CreateCells(dataGridView1);
        //            dgvRow.Cells[0].Value = a.MaterialName;
        //            dgvRow.Cells[1].Value = a.Count;
        //            dgvRow.Cells[2].Value = a.CountNumberOfCartons;
        //            this.dataGridView1.Rows.Add(dgvRow);
        //        }
        //    }
        //    else
        //    {
        //        //var list = MedleyDB.ReceivedGoods.Where(b => b.MaterialName.Equals(((ComboBox)sender).SelectedItem.ToString())).AsQueryable().GroupBy(a => a.MaterialName);

        //        var list = MedleyDB.ReceivedGoods.Where(a => a.DeliveredToStore.Equals(true) && a.MaterialName.Equals(((ComboBox)sender).SelectedItem.ToString())).GroupBy(a => a.MaterialName).Select(obj => new
        //        {
        //            MaterialName = obj.Key,
        //            Count = obj.Count(),
        //            CountNumberOfCartons = obj.Sum(i => i.NoOfCartons),
        //            Average = obj.Average(i => i.NoOfCartons)
        //        });
        //        //populateDGV(list);
        //        foreach (var a in list)
        //        {
        //            DataGridViewRow dgvRow = new DataGridViewRow();
        //            dgvRow.CreateCells(dataGridView1);
        //            dgvRow.Cells[0].Value = a.MaterialName;
        //            dgvRow.Cells[1].Value = a.Count;
        //            dgvRow.Cells[2].Value = a.CountNumberOfCartons;
        //            this.dataGridView1.Rows.Add(dgvRow);
        //        }
        //    }
            
        }

        private void populateDGV(object list)
        {
            MessageBox.Show(list.GetType().ToString());
            //foreach (var a in list.GetType)
            { }
           // MessageBox.Show(list.ToString());
        }

    }
}
