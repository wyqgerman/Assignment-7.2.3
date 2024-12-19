namespace Assignment_7._2._3
{
    internal class Program
    {
        static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            return String.Concat(s.OrderBy(c => c)) == String.Concat(t.OrderBy(c => c));
        }

        static void Main(string[] args)
        {
            Console.WriteLine(IsAnagram("anagram", "nagaram")); 
            Console.WriteLine(IsAnagram("rat", "car"));         
        }
    }
}
