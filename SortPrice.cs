using System.Collections.Generic;

namespace eBookRelease
{
    /// <summary>
    /// 根据价钱排序
    /// </summary>
    public class SortPrice : IComparer<NodeBookMap>
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
                    double price1 = double.Parse(map1.NodeBook.Price);
                    double price2 = double.Parse(map2.NodeBook.Price);
                    int retval = price1.CompareTo(price2);
                    return retval;
                }
            }

        }
    }
}
