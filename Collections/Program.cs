using System;
using System.Collections.Generic;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static void First()
        {

            LinkedList<string> books = new LinkedList<string>();//",  }
            books.AddFirst("1984");
            books.AddAfter(books.First, "War and peace");
            string[] more = new string[2];
            more[0] = "And Quiet Flows the Don";
            more[1] = "Winnie the Pooh";

            books.Last.Le// в общем, я хотел узнать длину название последней книги, чтобы потом из массива book выбрать не нарушающую упорядоченность, и добавить после последней.
                         //Может я не правильно понял смысл задачи, но тем не менее, я не понимаю почему тут не работает индексирование как в односвязаном списке, ведь разница у них
                         //в том что дву-ый держит информацию о следующем и предыдущим элементом, а все остальное у них схожее.
                         //я пытался что-то найти в интернете, нашел только что применяют foreach, значит, он индексируемый, но почему у меня не получается написать 
            //int max = books[books.Count-1].Lenght или что-то вроде, я не понимаю. 

        }
    }
}
