using System;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            LibraryProject();

            //Описать класс Библиотека.
            //Для описания могут понадобиться классы приведённые ниже

            //Автор(2 - 3 основных поля, свойства(сеттеры и геттеры для каждого поля),
            //несколько видов конструкторов, переопределить метод ToString().

            //Издательство(3 - 4 основных поля, свойства(сеттеры и геттеры для каждого поля),
            //несколько видов конструкторов, переопределить метод ToString()).

            //Книга(5 - 6 основных полей, свойства(сеттеры и геттеры для каждого поля),
            //несколько видов конструкторов, переопределить метод ToString()).

            //В классе книга в качестве типов полей для автора и издательства
            //использовать созданные классы.
        }
        static void LibraryProject()
        {
            //Create library
            Library shelf1 = new Library();

            //Create authors
            Author jeromKlapka = new Author("Jerome Klapka Jerome", new DateTime(1859, 8, 2), new DateTime(1927, 6, 16));
            Author gOrwell = new Author("George Orwell", 1903, 1950);
            Author jGreen = new Author("John Green", new DateTime(1977, 8, 24));

            //Create books
            Book alaska = new Book("Looking for Alaska", 2005, jGreen);
            Book threeMen = new Book("Three Men in a Boat", 1889, jeromKlapka);
            Book animalFarm = new Book("Animal Farm", 1994, gOrwell);

            //Add books to library
            shelf1.AddBook(alaska);
            shelf1.AddBook(threeMen);
            shelf1.AddBook(animalFarm);
            //Проверка метода поиска дубликатов
            shelf1.AddBook(threeMen);

            //Вывод наконсоль
            Console.WriteLine(alaska.Info());
            Console.WriteLine(threeMen.Info());
            Console.WriteLine(animalFarm.Info());

            //Поиск книг
            shelf1.BookSearch(shelf1);
        }
    }
}
