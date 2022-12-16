using Dill;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using Model.Enames;
using System;

namespace BooksUnitTest
{
    [TestClass]
    public class UnitTest1
    {
       
        [TestMethod]
        public void TestRemoveBook()
        {
            Book book = new Book("eeeee", "hjhj", 45, 5, "adfd",BookGenre.Comedy,DateTime.Now,3);
            DataService.Instance.Items.Add(book);
            DataService.Instance.RemoveItem(book);
            Assert.IsTrue(DataService.Instance.Items.Count == 8);
        }
        [TestMethod]
        public void TestInNewBook()
        {
            DataService.Instance.AddItem(new Book("eeeee", "hjhj", 45, 5, "hjh", BookGenre.Action, DateTime.Now));
            Assert.IsTrue(DataService.Instance.Items.Count == 7);
        }
        [TestMethod]
        public void TestRemoveJournal()
        {
            Journal journal = new Journal("eeeee", "hjhj", 45, 5, JournalGenres.Fashion, JournalFrquequency.Daily);
            DataService.Instance.Items.Add(journal);
            DataService.Instance.RemoveItem(journal);
            Assert.IsTrue(DataService.Instance.Items.Count == 6);
        }
        [TestMethod]
        public void TestInNewJournal()
        {
            DataService.Instance.AddItem(new Journal("eeeee", "hjhj", 45, 5,JournalGenres.Fashion,JournalFrquequency.Daily));
            Assert.IsTrue(DataService.Instance.Items.Count == 7);
        }
        [TestMethod]
        public void TestGetAll()
        {
            Assert.IsTrue(DataService.Instance.Items.Count == 6);
        }

    }
}
