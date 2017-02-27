using System.Collections;
using System.Windows.Forms;

namespace eBookRelease
{
    /// <summary>
    /// ����б��ͷʱ�����б���
    /// </summary>
    class ListViewColumnSorter:IComparer
    {
        private int ColumnToSort;

        public int SortColumn
        {
            get { return ColumnToSort; }
            set { ColumnToSort = value; }
        }

        private SortOrder OrderOfSort;

        public SortOrder Order
        {
            get { return OrderOfSort; }
            set { OrderOfSort = value; }
        }
        private CaseInsensitiveComparer ObjectCompare;
        
        public ListViewColumnSorter()
        {
            ColumnToSort = 0;
            OrderOfSort = SortOrder.None;
            ObjectCompare=new CaseInsensitiveComparer();
        }
        
        int IComparer.Compare(object x,object y)
        {
            int compareResult;
            ListViewItem listviewX = (ListViewItem)x;
            ListViewItem listviewY = (ListViewItem) y;

            compareResult =
                ObjectCompare.Compare(listviewX.SubItems[ColumnToSort].Text, listviewY.SubItems[ColumnToSort].Text);
            if(OrderOfSort==SortOrder.Ascending)
            {
                return compareResult;
            }
            else if (OrderOfSort == SortOrder.Descending)
            {
                return -compareResult;
            }
            else
            {
                return 0;
            }
        }
    }
}
