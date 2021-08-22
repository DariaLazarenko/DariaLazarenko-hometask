using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class Book
    {
        public string Title {get; set; }
        public int Year { get; set; }
        public Author[] Authors { get; set; }
        //public PublishingHouse PublishingHouse { get; set; }

        // Разные виды конструкторов

        public Book(string title, int year)
        {
            Title = title;
            Year = year;
        }

        public Book(string title)
        {
            Title = title;
        }

        public Book(string title, int year, Author author)
        {
            Title = title;
            Year = year;
            //Инициализируем массив авторв на 1 элемент
            Authors = new Author[1];
            //Заполняем первый элемент массива
            Authors[0] = author;
            //PublishingHouse = publishingHouse;
        }

        public Book(string title, int year, params Author[] authors)
        {
            Title = title; 
            Year = year;
            Authors = authors;
            //PublishingHouse = publishingHouse;
        }

        //Далее пишем метод вывода информации о книге(пока без издательства)

        public string Info()
        {
            string info =
                $"Title: {Title};\n" +
                $"Year: {Year};\n";

            //Заполнение авторов уже требует условий

            if (Authors != null)
            {
                if (Authors.Length == 1)
                {
                    info += $"Author: {Authors[0].Name};\n";
                }
                else
                {
                    string authors = "Authors:";

                    for (int i = 0; i < Authors.Length; i++)
                    {
                        authors += Authors[i].Name;

                        if (i == Authors.Length - 1)
                        {
                            authors += ";\n";
                        }
                        else
                        {
                            authors += ", ";
                        }
                    }

                    info += authors;
                }
            }

            //if (PublishingHouse != null)
            //{
            //    string publishingHouse =
            //        $"Publishing house info:\n " +
            //        $"Title: {PublishingHouse.Name}\n" +
            //        $"Country: {PublishingHouse.Country}\n" +
            //        $"City: {PublishingHouse.City};";

            //    info += publishingHouse;
            //}

            return info;
        }
    }
}
