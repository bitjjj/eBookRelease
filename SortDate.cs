using System;
using System.Collections.Generic;

namespace eBookRelease
{
    /// <summary>
    /// 根据出版日期进行排序
    /// </summary>
    public class SortDate : IComparer<NodeBookMap>
    {
        public int Compare(NodeBookMap map1, NodeBookMap map2)
        {
            if (map1 == null)
            {
                if (map2 == null)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                if (map2 == null)
                {
                    return 1;
                }
                else
                {
                    DateTime date1 = DateTime.Parse(map1.NodeBook.Date);
                    DateTime date2 = DateTime.Parse(map2.NodeBook.Date);
                    int retval = date1.CompareTo(date2);
                    return retval;
                }
            }

        }
    }
}
