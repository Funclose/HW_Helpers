using HW_Helpers.Models;

namespace HW_Helpers.Service
{
    public class BookService
    {
        private List<Book> books;

        public BookService()
        {
            books = new List<Book>()
            {
                new Book { Id = 1, Title = "1984", Author = "Джордж Оруэлл", Genre = "Антиутопия", Age = 75 },
                new Book { Id = 2, Title = "Убить пересмешника", Author = "Харпер Ли", Genre = "Драма", Age = 63 },
                new Book { Id = 3, Title = "Война и мир", Author = "Лев Толстой", Genre = "Исторический роман", Age = 156 },
                new Book { Id = 4, Title = "Преступление и наказание", Author = "Фёдор Достоевский", Genre = "Психологическая драма", Age = 157 },
                new Book { Id = 5, Title = "Гарри Поттер и философский камень", Author = "Джоан Роулинг", Genre = "Фэнтези", Age = 26 },
                new Book { Id = 6, Title = "Мастер и Маргарита", Author = "Михаил Булгаков", Genre = "Мистика", Age = 83 },
                new Book { Id = 7, Title = "Великий Гэтсби", Author = "Фрэнсис Скотт Фицджеральд", Genre = "Роман", Age = 98 },
                new Book { Id = 8, Title = "О дивный новый мир", Author = "Олдос Хаксли", Genre = "Антиутопия", Age = 92 },
                new Book { Id = 9, Title = "Старик и море", Author = "Эрнест Хемингуэй", Genre = "Повесть", Age = 71 },
                new Book { Id = 10, Title = "Девушка с татуировкой дракона", Author = "Стиг Ларссон", Genre = "Детектив", Age = 18 }
            };

        }
        public IEnumerable<Book> GetAllBooks()
        {
            return books;
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }
    }
}
