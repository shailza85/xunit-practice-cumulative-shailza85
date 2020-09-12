using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using XUnitCumulativePractice;
using System.Collections.ObjectModel;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using NuGet.Frameworks;
using System.Drawing;


namespace XUnitCumulativePractice_Tests
{
   public class Storage_Tests
    {

        /*
         * Add a tests file to the XUnit project called Storage_Tests.cs.
            Test the addition of items (Fact):
            (Arrange) Create an Item and an empty Storage. 
            (Act) Add the Item to the Storage using the AddItem() method.
            (Assert) Assert that the list has a count of 1 and the first item is the item that was added.
          */
        [Fact]
        public void Items_Add()
        {
            // Arrange
            Item Pen = new Item();
            Storage storage = new Storage();
            int sizeBefore = storage.ItemCount;//0

            // Act 
            storage.AddItem(Pen);

            // Assert
            // Assert that the first item in the Storage is the Pen
            Assert.Equal(Pen, storage.Contents[sizeBefore]);

            // Assert that the size of the order went up by one.
            Assert.Equal(sizeBefore + 1, storage.ItemCount);//true//1
        }

        /**
         * Test the removal of items (Fact):	
            (Arrange) Create a Storage prepopulated with 5 Items. Create an object reference variable to the last item in the Contents list.
            (Act) Run RemoveItem() on the Storage. 
            (Assert) Assert that the count of the Contents has dropped by 1 (is 4) and that the object reference is no longer in the list.
         */
        [Fact]
        public void RemoveItem_Test()
        {
            // Arrange
            Item Pen1 = new Item() { Name = "Pen1" };
            Item Pen2 = new Item() { Name = "Pen2" };
            Item Pen3 = new Item() { Name = "Pen3" };
            Item Pen4 = new Item() { Name = "Pen4" };
            Item Pen5 = new Item() { Name = "Pen5" };
            Storage myStorage = new Storage();
            myStorage.AddItem(Pen1);
            myStorage.AddItem(Pen2);
            myStorage.AddItem(Pen3);
            myStorage.AddItem(Pen4);
            myStorage.AddItem(Pen5);
            int sizeBefore = myStorage.ItemCount;//5
            // Act 
            myStorage.RemoveItem();
            // Assert
            //Assert that the count of the Contents has dropped by 1(is 4)
            Assert.Equal(sizeBefore - 1, myStorage.ItemCount);//True//4
            // that the object reference is no longer in the list.
            Assert.DoesNotContain(Pen5, myStorage.Contents);
        }
    }
}
