# IronPDF crash demo

Environment: Windows, Powershell.

Ensure you have .NET runtime 5.0.7 installed, as well as an older runtime, like 5.0.6.

Run:

    dotnet publish -r win-x64 -o dist

Then:

    cd dist
    .\ironpdf-crash.exe

Example output:    

```
OS:     Microsoft Windows NT 10.0.19043.0
.NET:   5.0.7
Iron:   NetStandard2.0 RELEASE a=IronPdf, Version=2021.3.1.0, Culture=neutral, PublicKeyToken=94e1c31412563c75 v=2021.3.1.0
Deploy:
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

Then clean up:

    cd ..
    rm -recurse dist
    dotnet clean

Uncomment in the csproj file:

    <RuntimeFrameworkVersion>5.0.6</RuntimeFrameworkVersion>

Publish again:

    dotnet publish -r win-x64 -o dist

Then:

    cd dist
    .\ironpdf-crash.exe

Example output:

```
OS:     Microsoft Windows NT 10.0.19043.0
.NET:   5.0.6
Iron:   NetStandard2.0 RELEASE a=IronPdf, Version=2021.3.1.0, Culture=neutral, PublicKeyToken=94e1c31412563c75 v=2021.3.1.0
Deploy:
Image width = 595
Image height = 841
```