using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class Author
    {
        public string Name { get; set; }
        public DateTime Birth { get; set; }
        public DateTime? Death { get; set; }
        
        //Простейшие вычисляемые поля
        public int Age { 
            get
            {
                if (Death != null)
                {
                    return (int)(((DateTime)Death - Birth).TotalDays) / 365;
                }
                else
                {
                    return (int)((DateTime.Today - Birth).TotalDays) / 365;
                }
            } 
        }
        public bool IsAlive { 
            get
            {
                return Death == null;
            } 
        }

        //Конструкторы
        public Author(string name, DateTime birth)
        {
            Name = name;
            Birth = birth;
        }

        public Author(string name, DateTime birth, DateTime? death)
        {
            Name = name;
            Birth = birth;
            Death = death;
        }

        //Когда годы жизни хотим передать целыми числами
        public Author(string name, int birth, int death)
        {
            Name = name;
            Birth = new DateTime(birth, 1, 1);
            Death = new DateTime(death, 1, 1);
        }
    }
}
