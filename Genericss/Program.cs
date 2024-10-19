using System.Globalization;

namespace Genericss
{

    class Books
    {
        public string Title { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }

      

        public int Year { get; set; }
        public LinkedList<Books> list = new LinkedList<Books>();
        public Books() { }
        public Books(string title, string name, string genre, int year, LinkedList<Books> l) { 
        Title = title;
            Name = name;
            Genre = genre;
            Year = year;
        
            list = l;

        
        }
        public void Add(LinkedList<Books> list, Books book)
        {
            list.AddFirst(book);
        }

        public void Print(LinkedList<Books> l)
        {
            foreach (Books book in l)
                Console.WriteLine($"Title: {book.Title}, Name: {book.Name}, Genre: {book.Genre}, Year: {book.Year}");
        }
        public void Remov(LinkedList<Books> list, Books book)
        {
            list.Remove(book);
        }
        public void ChangeInfo(LinkedList<Books> l, Books book)
        {
            book.Title = Convert.ToString(Console.ReadLine());
            book.Name = Convert.ToString(Console.ReadLine());
            book.Genre = Convert.ToString(Console.ReadLine());
            book.Year = Convert.ToInt32(Console.ReadLine());
            l.AddLast(book);

        }
        public void First(LinkedList<Books> l, Books books) { 
        
        l.AddFirst(books);

        }
        public void Last(LinkedList<Books> l, Books books)
        {
            l.AddLast(books);
        }
        public void RemoveeFirst(LinkedList<Books> l)
        {
            l.RemoveFirst();
        }
        public void RemoveeLast(LinkedList<Books> l)
        {
            l.RemoveLast();
        }
    }
    class Translate
    {
        Dictionary<string, string> words = new Dictionary<string, string>()
        {
            {"Желтый-НаФранцузком",  "Yellow"}, {"Синий-НаФранцузком", "Blue"}, {"Красный-НаФранцузком", "Red"}
        };


        public void addTranslate(string word, string translate)
        {
            if (!words.ContainsKey(word))
            {
                words.Add(word, translate);
            }


            foreach (KeyValuePair<string, string> pair in words)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }


        public void removeWord(string word)
        {
            if (words.ContainsKey(word))
            {
                words.Remove(word);
            }


            foreach (KeyValuePair<string, string> pair in words)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }


        public void removeTranslate(string word)
        {
            if (words.Remove(word))
            {
                Console.WriteLine($"Removed {word}.");
            }


            foreach (KeyValuePair<string, string> pair in words)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }


        public void changeTranslate(string key, string newTranslate)
        {
            if (words.ContainsKey(key))
            {
                words[key] = newTranslate;
            }


            foreach (KeyValuePair<string, string> pair in words)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }


        public void searchTranslate(string key)
        {
            if (words.TryGetValue(key, out string value))
            {
                Console.WriteLine($"{key}: {value}");
            }

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //N1
            
            LinkedList<Books> l = new LinkedList<Books>();
            Books book = new Books();
            Books book1 = new Books("Prince", "Sam", "Adventure", 1990, l);
            Books book2 = new Books("Princess", "John", "Drama", 2809, l);
            book.Add(l, book1);
            book.Add(l, book2);
           
            book.Print(l);
            book.ChangeInfo(l, book1);
            book.Print(l);

            //N2
            Translate obj = new Translate();
            obj.addTranslate("Фиолетовый-НаФранцузком", "Purple");
            obj.removeTranslate("Красный-НаФранцузком");
            obj.changeTranslate("Синий-НаФранцузком", "White");
            obj.searchTranslate("Желтый-НаФранцузком");

            
        }
    }
}
