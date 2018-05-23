using System;
namespace test
{
    public struct Books
    {
        private string title;
        private string author;
        private string subject;
        private int book_id;

        public void getValues(string t, string a, string s, int id)
        {
            title = t;
            author = a;
            subject = s;
            book_id = id;
        }

        public void display()
        {
            Console.WriteLine("Title   : {0}", title);
            Console.WriteLine("Author  : {0}", author);
            Console.WriteLine("Subject : {0}", subject);
            Console.WriteLine("Book_id : {0}\n", book_id);
        }
    };
}
