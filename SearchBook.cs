using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace eBookRelease
{
   /// <summary>
   /// 提供查找方法接口
   /// </summary>
    public class SearchBook
    {
        /// <summary>
        /// 错误日志
        /// </summary>
        private TraceLog errLog = TraceLog.GetInstance();
        
        /// <summary>
        /// 符合要求的书籍列表信息
        /// </summary>
        List<NodeBookMap> resultBook = new List<NodeBookMap>();  

        /// <summary>
        /// 根据查找条件进行查找符合条件的书籍
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public  List<NodeBookMap> Search(SearchCondition condition)
        {
            SearchBookName(condition.KeyWord,condition.SearchRange,condition.Path);
            SearchBookISBN(condition.KeyWord,condition.SearchRange);
            SearchBookAuthor(condition.KeyWord, condition.SearchRange);
            SearchBookPress(condition.KeyWord, condition.SearchRange);
            SearchBookDescription(condition.KeyWord, condition.SearchRange);
            if(condition.IsFilterDate)
            {
                SearchPressDate(condition.PressDateFrom, condition.PressDateTo);
            }
            if(condition.IsFilterFileType)
            {
                SearchFileType(condition.Exts);
            }
            if(condition.IsFilterPrice)
            {
                SearchPrice(condition.PriceFrom, condition.PriceTo);
            }
            return resultBook;
        }

        #region 过滤必填查找选项
        /// <summary>
        /// 根据关键字和书名进行过滤
        /// </summary>
        /// <param name="keyWord"></param>
        /// <param name="ranges"></param>
        /// <param name="node"></param>
        private void SearchBookName(string keyWord,IList ranges,TreeNode node)
        {
            try
            {
                List<TreeNode> leafNodes = new List<TreeNode>();
                List<TreeNode> parentNodes = new List<TreeNode>();
                FormUtil.AnalyseCurNode(node, ref leafNodes, ref parentNodes);
                if (leafNodes.Count != 0)
                {
                    foreach (TreeNode leafNode in leafNodes)
                    {
                       
                        if (!ranges.Contains(SearchRangeIndex.NAME) 
                            || leafNode.Text.IndexOf(keyWord) != -1)
                        {
                            resultBook.Add(new NodeBookMap(leafNode, new Book(FormUtil.CreateBookNode(leafNode))));
                        }
                    }
                }
                if (parentNodes.Count != 0)
                {
                    foreach (TreeNode parentNode in parentNodes)
                    {
                        SearchBookName(keyWord,ranges,parentNode);
                    }
                }
            }
            catch (Exception e)
            {
                errLog.WriteError(e);
                MessageBox.Show(Constants.UNKNOWERROR,
                     Constants.ERRORTIP, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 根据ISBN信息进行过滤
        /// </summary>
        /// <param name="keyWord"></param>
        /// <param name="ranges"></param>
        private void SearchBookISBN(string keyWord, IList ranges)
        {
            if (ranges.Contains(SearchRangeIndex.ISBN) && resultBook.Count != 0)
            {
                int count = resultBook.Count;
                for (int i = 0; i < count; i++)
                {
                    if (resultBook[i].NodeBook.ISBN == "" 
                        || resultBook[i].NodeBook.ISBN.IndexOf(keyWord) == -1)
                    {
                        resultBook.RemoveAt(i);
                        i--;
                        count--;
                    }
                }
            }
        }

        private void SearchBookAuthor(string keyWord, IList ranges)
        {
            if (ranges.Contains(SearchRangeIndex.AUTHOR) && resultBook.Count != 0)
            {
                int count = resultBook.Count;
                for (int i = 0; i < count; i++)
                {
                    if (resultBook[i].NodeBook.Author == "" 
                        || resultBook[i].NodeBook.Author.IndexOf(keyWord) == -1)
                    {
                        resultBook.RemoveAt(i);
                        i--;
                        count--;
                    }
                }
            }
        }

        private void SearchBookPress(string keyWord, IList ranges)
        {
            if (ranges.Contains(SearchRangeIndex.PRESS) && resultBook.Count != 0)
            {
                int count = resultBook.Count;
                for (int i = 0; i < count; i++)
                {
                    if (resultBook[i].NodeBook.Press == "" 
                        || resultBook[i].NodeBook.Press.IndexOf(keyWord) == -1)
                    {
                        resultBook.RemoveAt(i);
                        i--;
                        count--;
                    }
                }
            }
        }

        private void SearchBookDescription(string keyWord, IList ranges)
        {
            if (ranges.Contains(SearchRangeIndex.DESCRIPTION) && resultBook.Count != 0)
            {
                int count = resultBook.Count;
                for (int i = 0; i < count; i++)
                {
                    if (resultBook[i].NodeBook.Description == "" 
                        || resultBook[i].NodeBook.Description.IndexOf(keyWord) == -1)
                    {
                        resultBook.RemoveAt(i);
                        i--;
                        count--;
                    }
                }
            }
        }
        #endregion

        #region 过滤选添查找选项
        /// <summary>
        /// 根据出版日期进行过滤
        /// </summary>
        /// <param name="dateFrom"></param>
        /// <param name="dateTo"></param>
        private void SearchPressDate(DateTime dateFrom,DateTime dateTo)
        {
            int count = resultBook.Count;
            for (int i = 0; i < count; i++)
            {
                if (resultBook[i].NodeBook.Date == ""
                    || !CheckPressDate(DateTime.Parse(resultBook[i].NodeBook.Date),dateFrom,dateTo))
                {
                    resultBook.RemoveAt(i);
                    i--;
                    count--;
                }
            }
        }

        private static bool CheckPressDate(DateTime pressDate, DateTime dateFrom, DateTime dateTo)
        {
            TimeSpan ts1 = pressDate - dateFrom;
            TimeSpan ts2 = dateTo - pressDate;
            return (ts1.Ticks >= 0 && ts2.Ticks >= 0);
        }

        private void SearchFileType(IList exts)
        {
            int count = resultBook.Count;
            for (int i = 0; i < count; i++)
            {
                if (!CheckFileType(exts, resultBook[i].Node.Tag.ToString()))
                {
                    resultBook.RemoveAt(i);
                    i--;
                    count--;
                }
            }
        }

        private static bool CheckFileType(IList fileTypes, string path)
        {
            string ext = "*"+Path.GetExtension(path);
            return fileTypes.Contains(ext);
        }

        private void SearchPrice(string priceFrom,string priceTo)
        {
            int count = resultBook.Count;
            for (int i = 0; i < count; i++)
            {
                if (resultBook[i].NodeBook.Price == ""
                    || !CheckPrice(priceFrom, priceTo, resultBook[i].NodeBook.Price))
                {
                    resultBook.RemoveAt(i);
                    i--;
                    count--;
                }
            }
        }

        private static bool CheckPrice(string pLow, string pHigh, string price)
        {
            double low = double.Parse(pLow);
            double high = double.Parse(pHigh);
            double cur = double.Parse(price);
            return cur >= low && cur <= high;
        }
        #endregion

    }
}
