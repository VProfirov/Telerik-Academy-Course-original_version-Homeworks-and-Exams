namespace IO.Text
{
    class CharReaders
    {
        static void CR()
        {
            int codeRead = 0;
            do
            {
                codeRead = Console.Read();
                Console.WriteLine($"code: {codeRead} => char: {(char)codeRead}");
            } while (codeRead != 10);
        }
    }
}