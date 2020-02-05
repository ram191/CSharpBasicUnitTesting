using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpBasicUnitTesting
{
    public class Class1
    {
        public int LetterCount(string str)
        {
            return str.Length;
        }

        public char GradeConvert(int grade)
        {
            if (grade > 90)
            {
                return 'A';
            }
            else if (grade >= 80 && grade <= 89)
            {
                return 'B';
            }
            else if (grade >= 70 && grade <= 79)
            {
                return 'C';
            }
            else if (grade >= 60 && grade <= 69)
            {
                return 'C';
            }
            else
            {
                return 'E';
            }
        }

        public string IsOddOrEven(int num)
        {
            if(num % 2 == 0)
            {
                return "GENAP";
            }
            else
            {
                return "GANJIL";
            }
        }

        public string IsLeapYear(int year)
        {
            if(DateTime.IsLeapYear(year) == true)
            {
                return "Kabisat";
            }
            else
            {
                return "Bukan Kabisat";
            }
        }

        public string FilmRating(int age)
        {
            if(age >= 21)
            {
                return "DEWASA";
            }
            else if(age >= 13)
            {
                return "REMAJA";
            }
            else if(age >= 9)
            {
                return "BIMBINGAN ORANG TUA";
            }
            else
            {
                return "SEMUA USIA";
            }
        }

        public List<int> GenerateNum(int num1, int num2)
        {
            List<int> numbers = new List<int>();

            for (int x=num1; x<=num2; x++)
            {
                numbers.Add(x);
            }
            return numbers;
        }

        public List<int> GenerateOdds()
        {
            List<int> oddNumbers = new List<int>();
            for(int x = 1; x<=100; x++)
            {
                if(x % 2 != 0)
                {
                    oddNumbers.Add(x);
                }
            }
            return oddNumbers;
        }

        public List<string> OddEvenMultipliedBy()
        {
            List<string> loop = new List<string>();

            for(int x=1; x<=1000; x++)
            {
                if(x % 2 != 0 && x % 5 == 0)
                {
                    loop.Add($"{x}. Ganjil Kelipatan Lima");
                }
                else if(x % 2 == 0 && x % 5 == 0)
                {
                    loop.Add($"{x}. Genap Kelipatan Lima");
                }
                else if(x % 2 == 0)
                {
                    loop.Add($"{x}. Genap");
                }
                else if(x % 2 != 0)
                {
                    loop.Add($"{x}. Ganjil");
                }
                else
                {
                    loop.Add($"{x}");
                }
            }

            return loop;
        }

        public string ReverseSentence(string sen)
        {
            List<string> result = sen.Split(' ').ToList();

            result.Reverse();

            string result2 = String.Join(' ', result);
            return result2;
        }

        public string[] AddRemove(string[] words, string a, string b)
        {
            List<string> items = words.ToList();
            items.Insert(0, b);
            items.Add(a);
            string[] newArr = items.ToArray();
            return newArr;
        }


    }
}
