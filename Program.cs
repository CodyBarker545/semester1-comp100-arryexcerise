namespace ArrayExercise01_SEC404
{
    internal class Program
    {
        static char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
        static int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37 };
        static int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20};
        static string[] poem = { "Mary", "had", "a", "little", "lamb" };
        static string[] obama = { "Barack", "Hussein", "Obama" };

        static void Main(string[] args)
        {
            //exercise 01
            Console.WriteLine("-----------");
            Console.WriteLine("EXERCISE 01");
            Console.WriteLine("-----------");

            foreach (string s in obama)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine();

            //exercise 02
            Console.WriteLine("-----------");
            Console.WriteLine("EXERCISE 02");
            Console.WriteLine("-----------");

            for (int index = poem.Length-1; index >= 0; index--)
            {
                Console.Write($"{poem[index]} ");
            }

            Console.WriteLine();

            //exercise 03
            Console.WriteLine("-----------");
            Console.WriteLine("EXERCISE 03");
            Console.WriteLine("-----------");

            int sum = 0;

            for(int x = 0; x < primes.Length; x++)
            {
                sum = sum + primes[x];

            }
            Console.WriteLine(sum);

            //exercise 04
            Console.WriteLine("-----------");
            Console.WriteLine("EXERCISE 04");
            Console.WriteLine("-----------");

            float amountDouble = 0;
            Console.WriteLine(primes.Length);
            for (int i = 0; i < primes.Length; i++)
            {
                amountDouble = primes[i] * 2;
                Console.Write($"{amountDouble} ");
            }
        }
    }
}