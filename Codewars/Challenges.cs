namespace Codewars
{
    public class Challenges
    {
        // This project contains my solutions for codewars.com coding challenges. I will include the challenge text above every solution.
        // I will also include the highest rated solution from codewars.com as a comment below my solution.

        // Move the first letter of each word to the end of it, then add "ay" to the end of the word. Leave punctuation marks untouched.
        public static string PigIt(string input)
        {
            var result = String.Empty;
            var inputArray = input.Split(' ');
            foreach (var str in inputArray)
            {
                if (str.All(char.IsLetter))
                {
                    result += $"{str.Substring(1, str.Length - 1)}{str[0]}ay ";
                }
                else
                {
                    result += $"{str} ";
                }
            }
            result = result.TrimEnd(' ');
            return result;

            //  return string.Join(" ", str.Split(' ').Select(w => w.Any(char.IsPunctuation) ? w : w.Substring(1) + w[0] + "ay"));
        }
    }
}
