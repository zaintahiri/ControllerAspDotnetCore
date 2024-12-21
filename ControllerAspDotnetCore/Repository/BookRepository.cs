using ControllerAspDotnetCore.Models;

namespace ControllerAspDotnetCore.Repository
{
    public class BookRepository
    {

        public List<Book> GetAllBooks()
        {
            return DataList().ToList();
        }
        public Book GetBooks(int id) 
        {
            return DataList().Where(x => x.Id==id).FirstOrDefault();
            
        }

        public List<Book> GetBooksById(string bookTitle, string bookAuthor)
        {
            return DataList()
                .Where(x => x.BookTitle.Contains(bookTitle) && x.BookAuthor.Contains(bookAuthor))
                .ToList();

        }

        public List<Book> DataList()
        {
            return new List<Book>()
            {
                new Book(){Id=101,BookTitle="Java",BookAuthor="zain",price=3090},
                new Book(){Id=102,BookTitle="C#",BookAuthor="Ajmal",price=300},
                new Book(){Id=103,BookTitle="Asp.Net",BookAuthor="Adeel",price=3300},
                new Book(){Id=104,BookTitle="Android",BookAuthor="Naeem",price=3000},
                new Book(){Id=105,BookTitle="Kotlin",BookAuthor="Usman",price=3200},
                new Book(){Id=106,BookTitle="SQL-SERVER",BookAuthor="zain",price=3100},
                new Book(){Id=107,BookTitle="VB",BookAuthor="Kareem Bux",price=3500}
            };
        
        }
    }
}
