using String_Calculator_Kata.Exceptions;
using System.Text.RegularExpressions;

namespace String_Calculator_Kata
{
    public class StringCalculator
    {
        private int _calledCount;

        public int Add(string numbers)
        {
            _calledCount++;
            var regexPattern = @"\[(\*+)\]\[(\W+)\]";
            var delimiters = new List<string> { ",", "\n", "/" };

            if (string.IsNullOrEmpty(numbers))
            {
                return 0;
            }

            if (numbers.Length == 1)
                return int.Parse(numbers);

            if (numbers.StartsWith("//"))
            {
                var customLengthMatch = Regex.Match(numbers, regexPattern);
                if (customLengthMatch.Success)
                {
                    var customLengthDelimiter = customLengthMatch.Groups;

                    foreach (var group in customLengthDelimiter.Values.Skip(1))
                    {
                        if (string.IsNullOrEmpty(group.Value)) continue;
                        delimiters.Add(group.Value);
                        numbers = Regex.Replace(numbers, regexPattern, string.Empty);
                    }
                }
                else
                    delimiters.Add(numbers[2].ToString());
            }

            var digits = numbers.Split(delimiters.ToArray(), StringSplitOptions.RemoveEmptyEntries);

            if (digits.Any(digit => int.Parse(digit.ToString()) < 0))
            {
                throw new NegativeNumberException($"negatives not allowed: {string.Join(",", digits)}");
            }

            var result = digits.Select(int.Parse).Where(x => x < 1001).Sum();

            AddOccured?.Invoke(numbers, result);
            return result;
        }

        public int GetCalledCount() => _calledCount;

        public event Action<string, int>? AddOccured;
    }
}
