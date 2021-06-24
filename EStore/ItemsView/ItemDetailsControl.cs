using EStoreBusinessObjects;
using System.Windows.Forms;

namespace EStore_Temp.ItemsView
{
    public partial class ItemDetailsControl : UserControl
    {
        private readonly Item _item;

        public ItemDetailsControl(Item item)
        {
            InitializeComponent();
            this._item = item;
        }
    }
}
