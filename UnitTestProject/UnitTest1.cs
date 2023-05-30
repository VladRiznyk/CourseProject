using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using WindowsFormsApp;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Sort()
        {
            // Зчитати початковий список
            JobList jobList = new JobList();
            jobList.ReadFromXML("C:\\UnitTests\\input.xml");
            
            // Сортувати та зберегти результат
            List<Job> newList = jobList.Sort(
                new List<KeyValuePair<int, int>>()
                {
                    new KeyValuePair<int, int>(6, 0), // Зарплата, за зростанням
                    new KeyValuePair<int, int>(0, 1), // ID, за зменшенням
                    new KeyValuePair<int, int>(3, 0) // Регіон, за зростанням
                }
            );

            // Зчитати список
            jobList.ReadFromXML("C:\\UnitTests\\input_sort.xml");

            AssertCustomCollections(jobList.Jobs.ToList(), newList);
        }

        [TestMethod]
        public void Find()
        {
            // Зчитати початковий список
            JobList jobList = new JobList();
            jobList.ReadFromXML("C:\\UnitTests\\input.xml");

            // Виконати пошук та зберегти результат
            List<Job> newList = jobList.Find(
                new KeyValuePair<int, string>(2, "кухар")
            );

            // Зчитати список
            jobList.ReadFromXML("C:\\UnitTests\\input_find.xml");

            AssertCustomCollections(jobList.Jobs.ToList(), newList);
        }

        [TestMethod]
        public void Filter()
        {
            // Зчитати початковий список
            JobList jobList = new JobList();
            jobList.ReadFromXML("C:\\UnitTests\\input.xml");

            // Фільтрувати та зберегти результат
            List<Job> newList = jobList.Filter(
                new KeyValuePair<int, object>(6, new ulong[2] { 8000, 11700 })
            );

            // Зчитати список
            jobList.ReadFromXML("C:\\UnitTests\\input_filter.xml");

            AssertCustomCollections(jobList.Jobs.ToList(), newList);
        }

        private void AssertCustomCollections(List<Job> expected, List<Job> actual)
        {
            Assert.AreEqual(expected.Count, actual.Count);

            for(int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i].ID, actual[i].ID);
                Assert.AreEqual(expected[i].Link, actual[i].Link);
                Assert.AreEqual(expected[i].Name, actual[i].Name);
                Assert.AreEqual(expected[i].Region, actual[i].Region);
                Assert.AreEqual(expected[i].Description, actual[i].Description);
                Assert.AreEqual(expected[i].PublicationDate, actual[i].PublicationDate);
                Assert.AreEqual(expected[i].Salary, actual[i].Salary);
                Assert.AreEqual(expected[i].CompanyName, actual[i].CompanyName);
                Assert.AreEqual(expected[i].ExpirationDate, actual[i].ExpirationDate);
                Assert.AreEqual(expected[i].Type, actual[i].Type);
                Assert.AreEqual(expected[i].Phone, actual[i].Phone);
            }
        }
    }
}