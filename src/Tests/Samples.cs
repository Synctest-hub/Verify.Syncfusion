﻿[TestFixture]
public class Samples
{
    #region VerifyPdf

    [Test]
    public Task VerifyPdf()
    {
        return VerifyFile("sample.pdf");
    }

    #endregion

    [Test]
    public Task VerifyPdfResolution()
    {
        return VerifyFile("sample.pdf")
            .PdfPngDevice(_ => new(){ScaleFactor = 4});
    }

    #region VerifyPdfStream

    [Test]
    public Task VerifyPdfStream()
    {
        return Verify(File.OpenRead("sample.pdf"))
            .UseExtension("pdf");
    }

    #endregion

#if DEBUG

    #region VerifyPowerPoint

    [Test]
    public Task VerifyPowerPoint()
    {
        return VerifyFile("sample.pptx");
    }

    #endregion

    #region VerifyPowerPointStream

    [Test]
    public Task VerifyPowerPointStream()
    {
        return Verify(File.OpenRead("sample.pptx"))
            .UseExtension("pptx");
    }

    #endregion

#endif

    #region VerifyExcel

    [Test]
    public Task VerifyExcel()
    {
        return VerifyFile("sample.xlsx");
    }

    #endregion

    #region VerifyExcelStream

    [Test]
    public Task VerifyExcelStream()
    {
        return Verify(File.OpenRead("sample.xlsx"))
            .UseExtension("xlsx");
    }

    #endregion

    #region VerifyWord

    [Test]
    public Task VerifyWord()
    {
        return VerifyFile("sample.docx");
    }

    #endregion

    #region VerifyWordStream

    [Test]
    public Task VerifyWordStream()
    {
        return Verify(File.OpenRead("sample.docx"))
            .UseExtension("docx");
    }

    #endregion
}