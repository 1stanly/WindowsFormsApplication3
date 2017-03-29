using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    class Library
    {
        static public List<Book> listBooks = new List<Book>();
        static public List<Journal> listJournals = new List<Journal>();
        //static public List<Newspaper > listNewspaper = new List<Newspaper >();

        public void CreateLibraryBooks()
        {
            listBooks.Add(new Book() { nameAuthor = "Mikhail Bulgakov", nameBook = "Master i Margo", yearOfPublishing = 1891, numberOfPages = 1000 });
            listBooks.Add(new Book() { nameAuthor = "Lev Tolstoi", nameBook = "Mertvye Dushi", yearOfPublishing = 1865, numberOfPages = 835 });
            listBooks.Add(new Book() { nameAuthor = "Nikolai Gogol ", nameBook = "Mertvye Dushi", yearOfPublishing = 1842, numberOfPages = 933 });
            listBooks.Add(new Book() { nameAuthor = "Alexander Pushki ", nameBook = "Evgenyi Onegin", yearOfPublishing = 1825, numberOfPages = 1114 });
            listBooks.Add(new Book() { nameAuthor = "Anton Chekhov ", nameBook = "Palata №6", yearOfPublishing = 1892, numberOfPages = 753 });
        }
        public void CreateLibraryJournals()
        {
            listJournals.Add(new Journal() { nameJournal = "Cosmopolitan", numberEditionJournals = "№ 147", numberOfPagesJournals = 25 });
            listJournals.Add(new Journal() { nameJournal = "Vogue", numberEditionJournals = "№ 45", numberOfPagesJournals = 63 });
            listJournals.Add(new Journal() { nameJournal = "GQ ", numberEditionJournals = "№ 96", numberOfPagesJournals = 15 });
            listJournals.Add(new Journal() { nameJournal = "Vanity Fair ", numberEditionJournals = "№ 521", numberOfPagesJournals = 42 });
            listJournals.Add(new Journal() { nameJournal = "Marie Claire ", numberEditionJournals = "№ 313", numberOfPagesJournals = 28 });
        }
        //public void CreateLibraryNewspaper()
        //{
        //    listNewspaper.Add(new Newspaper() { nameNewspaper = "The New Yourk Times", ratingNewspaper="65 %", numberOfPagesNewspaper=42 });
        //    listNewspaper.Add(new Newspaper() { nameNewspaper = "The Wall Street Journal", ratingNewspaper = "48 %", numberOfPagesNewspaper = 53 });
        //    listNewspaper.Add(new Newspaper() { nameNewspaper = "Los Angeles Times", ratingNewspaper = "39 %", numberOfPagesNewspaper = 37 });
        //}
    }
}
