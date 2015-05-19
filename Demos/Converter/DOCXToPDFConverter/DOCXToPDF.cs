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
            Gnostice.Documents.Framework.ActivateLicense("716E-5C8A-A157-DC33-3A20-5703-4792-B2C4-F393-B1E4-236D-2A56");
            DocumentConverter converter = new DocumentConverter();
            converter.ConvertToFile(@".\..\..\..\Samples\DifferentAlignments.docx", @".\..\..\..\Samples\Converted\DifferentAlignments.pdf");
        }
    }
}
