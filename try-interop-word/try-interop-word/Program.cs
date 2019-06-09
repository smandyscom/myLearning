using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Office.Interop.Word;

namespace try_interop_word
{
    class Program
    {
        static void Main(string[] args)
        {
            //open file
            // Open a doc file.
            Application application = new Application();
            Document document = application.Documents.Open("interop_word_trial1.docx");


            //grab content/page number

            //output
        }
    }
}
