using Mutexes;

class Program
{
    static void Main(string[] args)
    {
        Reporter reporter = new Reporter();
        reporter.Start();
    }
}
