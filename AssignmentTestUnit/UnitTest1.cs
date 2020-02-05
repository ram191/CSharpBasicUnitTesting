using NUnit.Framework;
using CSharpBasicUnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace AssignmentTestUnit
{
    public class Tests
    {
        Class1 unitTest;
   
        [SetUp]
        public void Setup()
        {
            unitTest = new Class1();
        }

        [Test]
        public void TestLetterCount()
        {
            var result = unitTest.LetterCount("MAMAMIA");
            Assert.AreEqual(7, result);
        }

        [Test]
        public void TestGradeConvert()
        {
            var result = unitTest.GradeConvert(72);
            Assert.AreEqual('C', result);
        }

        [Test]
        public void TestIsOddOrEven()
        {
            var result = unitTest.IsOddOrEven(20);
            Assert.AreEqual("GENAP", result);
        }

        [Test]
        public void TestIsLeapYear()
        {
            var result = unitTest.IsLeapYear(2020);
            Assert.AreEqual("Kabisat", result);
        }

        [Test]
        public void TestFilmRating()
        {
            var result = unitTest.FilmRating(14);
            Assert.AreEqual("REMAJA", result);
        }

        [Test]
        public void TestGenerateNum()
        {
            List<int> nums = new List<int> { 4, 5, 6, 7, 8 };
            var result = unitTest.GenerateNum(4, 8);
            Assert.AreEqual(nums, result);
        }

        [Test]
        public void TestGenerateOdds()
        {
            List<int> hasil = new List<int> { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
            var hasil2 = unitTest.GenerateOdds();
            var hasil3 = hasil2.Take(10);
            Assert.AreEqual(hasil, hasil3);
        }

        //Belum Selesai
        [Test]
        public void TestOddEvenMultipliedBy()
        {
            List<string> hasil = new List<string>
            {
                "1. Ganjil",
                "2. Genap",
                "3. Ganjil",
                "4. Genap",
                "5. Ganjil Kelipatan Lima",
                "6. Genap",
                "7. Ganjil",
                "8. Genap",
                "9. Ganjil",
                "10. Genap Kelipatan Lima"
            };
            var hasil2 = unitTest.OddEvenMultipliedBy();
            var hasil3 = hasil2.Take(10);
            Assert.AreEqual(hasil, hasil3);
        }

        [Test]
        public void TestReverseSentence()
        {
            string expect = "goreng nasi makan aku";
            var result = unitTest.ReverseSentence("aku makan nasi goreng");
            Assert.AreEqual(expect, result);
        }

        [Test]
        public void TestAddRemove()
        {
            string[] words = new string[] { "Meja", "Buku", "Topi", "Baju", "Kayu" };
            string[] newWords = new string[] { "Handuk", "Meja", "Buku", "Topi", "Baju", "Kayu", "Celana" };
            var result = unitTest.AddRemove(words, "Celana", "Handuk");
            Assert.AreEqual(newWords, result);
        }
    }
}