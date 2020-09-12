using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Net.Mime;

namespace XUnitCumulativePractice
{
    public class Storage
    {
        /*
         * Create a class called “Storage” with the following properties and methods:
            “Contents” (list of Items).
            AddItem() will accept an item and add it to the “Contents” list.
            RemoveItem() will remove the most recent addition to the “Contents” list.
            A default constructor.

         */

        public List<Item> Contents { get; set; }

        public int ItemCount => Contents.Count;

        public Storage()
        {
            Contents= new List<Item>();
        }
        public void AddItem(Item contentItem)
        {
            Contents.Add(contentItem);
        }

        public void RemoveItem()
        {
            Contents.RemoveAt(Contents.Count-1);
        }

    }
}
