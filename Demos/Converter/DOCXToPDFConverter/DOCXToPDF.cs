using Gnostice.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOCXToPDFConverter
{
    class DOCXToPDF
    {
        static void Main(string[] args)
        {
            //Activate license
            Gnostice.Documents.Framework.ActivateLicense("A635-604D-F82A-680E-A31A-7FEE-F0F9-2EE2");

            //Create DocumentConverter instance
            DocumentConverter converter = new DocumentConverter();

            converter.ConvertToFile(@".\..\..\..\Samples\DifferentAlignments.docx", 
@".\..\..\..\Samples\Converted\DifferentAlignments.pdf");
        }
    }
}
