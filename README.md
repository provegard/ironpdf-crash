# IronPDF crash demo

Example output from `dotnet run`:

```
OS:   Microsoft Windows NT 10.0.19043.0
.NET: 5.0.7
Iron: NetStandard2.0 RELEASE a=IronPdf, Version=2021.3.1.0, Culture=neutral, PublicKeyToken=94e1c31412563c75 v=2021.3.1.0
Fatal error. Internal CLR error. (0x80131506)
   at IronPdf.Pdfium.NativeMethods.FPDFDOC_ExitFormFillEnvironment(IntPtr)
   at IronPdf.Pdfium.PdfFile.Dispose(Boolean)
   at IronPdf.Pdfium.PdfDocument.Dispose(Boolean)
   at IronPdf.Pdfium.PdfDocument.Dispose()
   at IronPdf.Pdfium.PdfiumApi.PdfToImage(System.IO.Stream, System.Nullable`1<Int32>, System.Nullable`1<Int32>, System.String, Double, System.Collections.Generic.IEnumerable`1<Int32> ByRef)
   at IronPdf.PdfDocument.lymdqh(System.Collections.Generic.IEnumerable`1<Int32>, System.Nullable`1<Int32>, System.Nullable`1<Int32>, Int32)
   at IronPdf.PdfDocument.ToBitmap(System.Nullable`1<Int32>, System.Nullable`1<Int32>, System.Collections.Generic.IEnumerable`1<Int32>, Int32)
   at IronPdf.PdfDocument.ToBitmap(Int32)
   at ironpdf_crash.Program.Main(System.String[])
```

## Docker

Build:

    docker build -t ironpdf-crash -f Dockerfile .
    
Run:

    docker run --rm ironpdf-crash
    
Example output:

```
OS:     Unix 5.4.72.2
.NET:   5.0.7
Deploy:
Segmentation fault
```