using System.Xml;

namespace eBookRelease
{
    /// <summary>
    /// Book的实体类
    /// </summary>
    public class Book
    {
        private string name;
        private string isbn;
        private string author;
        private string price;
        private string press;
        private string date;
        private string description;

        public Book()
        {
        }

        /// <summary>
        /// 通过book.xml文件中的一个xmlnode节点实例化Book类
        /// </summary>
        /// <param name="bookNode"></param>
        public Book(XmlNode bookNode)
        {
            if(bookNode!=null)
            {
                Name = bookNode.ChildNodes[BookInfoIndex.NAME].InnerText;
                ISBN = bookNode.ChildNodes[BookInfoIndex.ISBN] == null
                    ? "" : bookNode.ChildNodes[BookInfoIndex.ISBN].InnerText;
                Author = bookNode.ChildNodes[BookInfoIndex.AUTHOR] == null
                    ? "" : bookNode.ChildNodes[BookInfoIndex.AUTHOR].InnerText;
                Price = bookNode.ChildNodes[BookInfoIndex.PRICE] == null
                    ? "" : bookNode.ChildNodes[BookInfoIndex.PRICE].InnerText;
                Press = bookNode.ChildNodes[BookInfoIndex.PRESS] == null
                    ? "" : bookNode.ChildNodes[BookInfoIndex.PRESS].InnerText;
                Date = bookNode.ChildNodes[BookInfoIndex.DATE] == null
                    ? "" : bookNode.ChildNodes[BookInfoIndex.DATE].InnerText;
                Description = bookNode.ChildNodes[BookInfoIndex.DESCRIPTION] == null
                    ? "" : bookNode.ChildNodes[BookInfoIndex.DESCRIPTION].InnerText;
            }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public string Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Press
        {
            get { return press; }
            set { press = value; }
        }

        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
    }
}
