using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Document doc1 = new Document();
            doc1.Read("myFile");
            doc1.Speak();

            IStorable doc2 = new Document();
            doc2.Write("myFile");
            //doc2.Speak();

            Memo doc3 = new Memo();
            doc3.MemoFrom = "Marcin";
        }
    }
}
