using System;
using IronPdf;

namespace ironpdf_crash
{
    class Program
    {
        static void Main(string[] args)
        {
            License.LicenseKey = "";

            // IronPdf.Logging.Logger.EnableDebugging = true;
            IronPdf.Logging.Logger.LogFilePath = "Default.log";
            IronPdf.Logging.Logger.LoggingMode = IronPdf.Logging.Logger.LoggingModes.All;
            IronPdf.Logging.Logger.MessageLogged += Console.WriteLine;
            
            Console.WriteLine("OS:     " + Environment.OSVersion);
            Console.WriteLine(".NET:   " + Environment.Version);
            Console.WriteLine("Iron:   " + VersionInfo.IronPdfAssemblyVersion);
            Console.WriteLine("Deploy: " + Installation.ActualDeploymentPath);

            var pdf = new PdfDocument("sample.pdf");
            _ = pdf.ToBitmap();
        }
    }
}
