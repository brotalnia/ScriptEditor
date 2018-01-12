using System;
using System.Windows.Forms;

namespace ScriptEditor
{
    class MixedListSorter : System.Collections.IComparer
    {
        public int Column = 0;
        public System.Windows.Forms.SortOrder Order = SortOrder.Ascending;
        public int Compare(object x, object y) // IComparer Member
        {
            if (!(x is ListViewItem))
                return (0);
            if (!(y is ListViewItem))
                return (0);

            ListViewItem l1 = (ListViewItem)x;
            ListViewItem l2 = (ListViewItem)y;

            int intValue1;

            if (Int32.TryParse(l1.SubItems[Column].Text, out intValue1))
            {
                int intValue2;
                Int32.TryParse(l2.SubItems[Column].Text, out intValue2);

                if (Order == SortOrder.Ascending)
                {
                    return intValue1.CompareTo(intValue2);
                }
                else
                {
                    return intValue2.CompareTo(intValue1);
                }
            }
            else
            {
                string str1 = l1.SubItems[Column].Text;
                string str2 = l2.SubItems[Column].Text;

                if (Order == SortOrder.Ascending)
                {
                    return str1.CompareTo(str2);
                }
                else
                {
                    return str2.CompareTo(str1);
                }
            }
        }
    }
}
