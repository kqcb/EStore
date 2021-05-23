using EStoreBusinessObjects;
using FastMember;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EStore.ItemsView
{
    public partial class CartView : MetroFramework.Forms.MetroForm
    {
        private List<Item> _items;
        public CartView(List<Item> items)
        {
            InitializeComponent();
            _items = items;
            Display();
        }

        public DataTable ToDataTable()
        {
            DataTable dataTable = new DataTable();
            var reader = ObjectReader.Create(_items);

            dataTable.Load(reader);

            return dataTable;

        }

        public void Display()
        {
            metroGridSelectedItems.DataSource = ToDataTable();
            
        }
             

    }
}
