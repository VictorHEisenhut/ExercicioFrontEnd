using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Student
    {
        public string First { get; set; }
        public string Last { get; set; }
        public int ID { get; set; }
        public bool Aprovado { get; set; }
        public List<int> Scores;

        // Create a data source by using a collection initializer.
        public static List<Student> students = new()
        {
            new Student {Aprovado = false, First = "Svetlana", Last = "Omelchenko", ID = 111, Scores = new List<int> { 97, 92, 81, 60 } },
            new Student {Aprovado = false, First = "Claire", Last = "O'Donnell", ID = 112, Scores = new List<int> { 75, 84, 91, 39 } },
            new Student {Aprovado = false, First = "Sven", Last = "Mortensen", ID = 113, Scores = new List<int> { 88, 94, 65, 91 } },
            new Student {Aprovado = false, First = "Cesar", Last = "Garcia", ID = 114, Scores = new List<int> { 97, 89, 85, 82 } },
            new Student {Aprovado = false, First = "Debra", Last = "Garcia", ID = 115, Scores = new List<int> { 35, 72, 91, 70 } },
            new Student {Aprovado = false, First = "Fadi", Last = "Fakhouri", ID = 116, Scores = new List<int> { 99, 86, 90, 94 } },
            new Student {Aprovado = false, First = "Hanying", Last = "Feng", ID = 117, Scores = new List<int> { 93, 92, 80, 87 } },
            new Student {Aprovado = false, First = "Hugo", Last = "Garcia", ID = 118, Scores = new List<int> { 92, 90, 83, 78 } },
            new Student {Aprovado = false, First = "Lance", Last = "Tucker", ID = 119, Scores = new List<int> { 100, 79, 88, 92 } },
            new Student {Aprovado = false, First = "Terry", Last = "Adams", ID = 120, Scores = new List<int> { 99, 82, 81, 79 } },
            new Student {Aprovado = false, First = "Eugene", Last = "Zabokritski", ID = 121, Scores = new List<int> { 96, 85, 91, 0 } },
            new Student {Aprovado = false, First = "Michael", Last = "Tucker", ID = 122, Scores = new List<int> { 94, 92, 91, 91 } }
        };

        public override string ToString()
        {
            return $"{First} - {this.Scores.Average()} - {Aprovado}";
        }
    }

}
