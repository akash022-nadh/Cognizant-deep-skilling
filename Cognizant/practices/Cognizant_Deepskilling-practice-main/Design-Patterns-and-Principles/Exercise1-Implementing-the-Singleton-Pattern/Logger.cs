public class Logger
{
    private static Logger? instance;

    private Logger()
    {
    }

    public static Logger GetInstance()
    {
        if (instance == null)
        {
            instance = new Logger();
        }

        return instance;
    }

    public void ShowMessage()
    {
        Console.WriteLine("Logger instance created.");
    }
}
