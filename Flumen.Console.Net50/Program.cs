namespace Flumen.Console.Net50
{
    /// <summary>
    /// Class for verifying netstandard21 support.
    /// </summary>
    internal static class Program
    {
        private static void Main() => 
            System.Console.WriteLine($"{5.Minutes()}");
    }
}
