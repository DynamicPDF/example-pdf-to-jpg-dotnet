using ceTe.DynamicPDF.Rasterizer;
using System;
using System.Text.RegularExpressions;

namespace example_pdf_to_jpg_dotnet
{
    // This example shows how to convert a PDF document to JPEG/JPG.
    // It references the ceTe.DynamicPDF.Rasterizer.NET NuGet package.
    class Program
    {
        // Convert a PDF document to 4 JPEG files (one for each page).
        // Use the ceTe.DynamicPDF.Rasterizer namespace for the PdfRasterizer class.
        static void Main(string[] args)
        {
            // Create a PdfRasterizer object using the source PDF to be converted to JPG image
            PdfRasterizer rasterizer = new PdfRasterizer(GetResourcePath("doc-a.pdf"));

            // Call the Draw method with output image name, image format and the DPI
            rasterizer.Draw("output.jpg", ImageFormat.Jpeg, ImageSize.Dpi72);
        }

        // This is a helper function to get the full path to a file in the Resources folder.
        public static string GetResourcePath(string inputFileName)
        {
            var exePath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase);
            Regex appPathMatcher = new Regex(@"(?<!fil)[A-Za-z]:\\+[\S\s]*?(?=\\+bin)");
            var appRoot = appPathMatcher.Match(exePath).Value;
            return System.IO.Path.Combine(appRoot, "Resources", inputFileName);
        }
    }
}
