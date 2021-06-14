using System;
using IronPdf;

namespace ironpdf_crash
{
    class Program
    {
        static void Main(string[] args)
        {
            License.LicenseKey = "";

            Console.WriteLine("OS:   " + Environment.OSVersion);
            Console.WriteLine(".NET: " + Environment.Version);
            Console.WriteLine("Iron: " + VersionInfo.IronPdfAssemblyVersion);

            var pdf = new PdfDocument("sample.pdf");
            _ = pdf.ToBitmap();
        }
    }
}
