using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace GraphicDeviceKit
{
    class ToolBoxItem : ICloneable
    {

        public string Header
        {
            get { return mHeader; }
        }

        public ObservableCollection<ToolBoxItem> Items
        {
            get
            {
                if (mItems == null)
                    mItems = new ObservableCollection<ToolBoxItem>();
                return mItems;
            }
        }
        private string mHeader = string.Empty;
        private ObservableCollection<ToolBoxItem> mItems = null;
        public ToolBoxItem(string _hrader)
        {
            mHeader = _hrader;
        }
        public object Clone()
        {
            ToolBoxItem dataItem = new ToolBoxItem(mHeader);
            foreach (ToolBoxItem item in Items)
                dataItem.Items.Add((ToolBoxItem)item.Clone());
            return dataItem;
        }
    }
    class ToolBox
    {
        private static ToolBox mInstance = new ToolBox();

        public static ToolBox Instance
        {
            get { return mInstance; }
        }

        private ObservableCollection<ToolBoxItem> GenerateTreeViewItems()
        {
            ObservableCollection<ToolBoxItem> items = new ObservableCollection<ToolBoxItem>();

            return items;
        }

        private ObservableCollection<ToolBoxItem> GenerateListItems()
        {
            ObservableCollection<ToolBoxItem> items = new ObservableCollection<ToolBoxItem>();
            return items;
        }

        public ObservableCollection<ToolBoxItem> TreeViewItems
        {
            get
            {
                if (mTreeViewItems == null)
                    mTreeViewItems = GenerateTreeViewItems();
                return mTreeViewItems;
            }
        }

        public ObservableCollection<ToolBoxItem> ListBoxItems
        {
            get
            {
                if (mListBoxItems == null)
                    mListBoxItems = GenerateListItems();
                return mListBoxItems;
            }
        }

        private ObservableCollection<ToolBoxItem> mTreeViewItems = null;
        private ObservableCollection<ToolBoxItem> mListBoxItems = null;
    }
}
