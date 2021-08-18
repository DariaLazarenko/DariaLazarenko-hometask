using System;
using System.Collections.Generic;
using System.Text;

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

        //Подумать над методом поиска книг

        //public Book BookSearch()
        //{

        //}

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
