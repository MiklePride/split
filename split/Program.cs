class program
{
    static void Main(string[] args)
    {
        string text = "Чем больше женщину мы любим, тем больше меньше мы чем тем. В.Кличко";
        string[] arrayText = text.Split(' ');

        Console.WriteLine(text);

        foreach (string word in arrayText)
        {
            Console.WriteLine(word);
        }
    }
}