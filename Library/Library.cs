using System;

namespace Library
{
    class Library
    {
        //Создаем поле-ссылку на массив книг
        private Book[] books;

        //Два варианта конструктора
        public Library()
        {
            //Объявляем/создаем массив на 0 элементов
            //Далее в методе расширяем и заполняем
            books = new Book[0];
        }

        public Library(Book[] books)
        {
            this.books = books;
        }

        public void AddBook(Book book)
        {
            if (book != null)
            {
                //Проверка дубликатов 
                if (SearchForDuplicates(books, book) is true)
                {
                    Array.Resize(ref books, books.Length + 1);
                    books[books.Length - 1] = book;
                } 
            }
        }

        //Метод поиска книг

        public bool BookSearch(Library shelf)
        {
            if (shelf != null)
            {
                Console.WriteLine("Enter book`s title in English:");
                string str = Console.ReadLine();
                Book book1 = new Book(str);

                for (int i = 0; i < shelf.books.Length; i++)
                {
                    if (book1.Title.ToUpper() == shelf.books[i].Title.ToUpper())
                    {
                        book1 = shelf.books[i];
                        Console.WriteLine(book1.Info());
                        return true;
                    }
                    else
                    {
                        i++;
                    }
                }
                Console.WriteLine("No book with entered name");
                return false;
            }
            else
            {
                Console.WriteLine("Library object is empty");
                return false;
            }
        }

        //Метод поиска дубликатов

        private bool SearchForDuplicates(Book[] books, Book book)
        {
            for (int i = 0; i < books.Length;)
            {
                if (book == books[i])
                {
                    return false;
                }
                else
                {
                    i++;
                }
            }

            return true;
        }
    }
}
