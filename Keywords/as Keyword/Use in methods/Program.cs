

class Program
{
    static void Main()
    {
        void Speak(object obj)
        {
            string s = obj as string;

            if (s != null)
            {
                Console.WriteLine("You sain: " + s);
            }
            else
            {
                Console.WriteLine("Not a string.");
            }

        }

        Speak("Hi there");
        Speak(123);
    }
}
