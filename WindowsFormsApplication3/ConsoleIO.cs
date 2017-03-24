using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    class ConsoleIO
    {
        public void ShowBooks()
        {
            foreach (Book n in Library.listBooks)
            {
                Console.WriteLine("Author :{0}\nName Book :{1}\nYear Of Publishing :{2}\nNumber Of Pages :{3}\n", n.nameAuthor, n.nameBook, n.yearOfPublishing, n.numberOfPages);
            }
        }
        public void ShowJournal()
        {
            foreach (Journal n in Library.listJournals)
            {
                Console.WriteLine("Journal :{0}\nNumber Edition Journals :{1}\nNumber Of Pages Journals :{2}\n", n.nameJournal, n.numberEditionJournals, n.numberOfPagesJournals);
            }
        }
        public void PrintCategoryBooks()
        {
            Console.WriteLine("\tBOOKS");
        }
        public void PrintCategoryJournal()
        {
            Console.WriteLine("\tJOURNALS");
        }
        public void ReadLine()
        {
            Console.ReadLine();
        }
    }
}
