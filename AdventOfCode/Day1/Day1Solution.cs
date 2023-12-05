using System.Text.RegularExpressions;

namespace AdventOfCode.Day1
{
    internal class Day1Solution
    {
        private readonly Dictionary<string, int> numToValue = new Dictionary<string, int>()
        {
            ["one"] = 1,
            ["two"] = 2,
            ["three"] = 3,
            ["four"] = 4,
            ["five"] = 5,
            ["six"] = 6,
            ["seven"] = 7,
            ["eight"] = 8,
            ["nine"] = 9,
            ["zero"] = 0,
        };

        private readonly string regexPattern = @"(?:\d|one|two|three|four|five|six|seven|eight|nine|zero)";


        public int Solve()
        {
            var textFilePath = Path.Combine(Environment.CurrentDirectory, "Day1", "Day1.txt");
            string inputFile = File.ReadAllText(textFilePath);
            var total = 0;
            foreach (var line in inputFile.Split("\r\n"))
            {
                var forwards = Rewrite(line);
                var backwards = RewriteBackwards(line);
                total += int.Parse($"{forwards}{backwards}");
            }
            return total;
        }

        private string RewriteBackwards(string line)
        {
            var match = Regex.Match(line, regexPattern, RegexOptions.RightToLeft);
            return match.Value switch
            {
                "one" => "1",
                "two" => "2",
                "three" => "3",
                "four" => "4",
                "five" => "5",
                "six" => "6",
                "seven" => "7",
                "eight" => "8",
                "nine" => "9",
                "zero" => "0",
                var d => d,
            };
        }

        private string Rewrite(string line)
        {
            var match = Regex.Match(line, regexPattern);
            return match.Value switch
            {
                "one" => "1",
                "two" => "2",
                "three" => "3",
                "four" => "4",
                "five" => "5",
                "six" => "6",
                "seven" => "7",
                "eight" => "8",
                "nine" => "9",
                "zero" => "0",
                var d => d,
            };
        }
    }
}
