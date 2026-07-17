public abstract class Document
{
    public abstract void Open();
}

public class WordDocument : Document
{
    public override void Open()
    {
        Console.WriteLine("Opening Word Document");
    }
}

public class PdfDocument : Document
{
    public override void Open()
    {
        Console.WriteLine("Opening PDF Document");
    }
}

public class DocumentFactory
{
    public static Document CreateDocument(string type)
    {
        if (type == "Word")
            return new WordDocument();

        return new PdfDocument();
    }
}
