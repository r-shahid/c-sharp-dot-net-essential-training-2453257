// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Using Timeout settings for RegEx in .NET
using System.Text.RegularExpressions;
using System.Diagnostics; //gives access to stopwatch class

// const string thestr = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

// // Use a Stopwatch to show elapsed time
// Stopwatch sw;

// // TODO: Use a Timeout value when executing RegEx to guard against bad input
// const int MAX_REGEX_TIME = 1000;
// TimeSpan timeout = TimeSpan.FromMilliseconds(MAX_REGEX_TIME);


// // Run the expression and output the result
// try {
//     sw = Stopwatch.StartNew();
//     // Regex CapWords = new Regex(@"(a+a+)+b", RegexOptions.None);
//     Regex CapWords = new Regex(@"(a+a+)+b", RegexOptions.None, timeout); //added timeout. need to catch the exception
//     MatchCollection mc = CapWords.Matches(thestr);
//     sw.Stop();
//     Console.WriteLine($"Found {mc.Count} matches in {sw.Elapsed} time:");
//     foreach (Match match in mc) {
//         Console.WriteLine($"'{match.Value}' found at position {match.Index}");
//     }
// }
// // catch (Exception e) {
// //     Console.WriteLine(e);
// // }
// catch (RegexMatchTimeoutException e) {
//     Console.WriteLine($"Regex took too long to execute! {e.MatchTimeout}");
// }


// //initially finds 0 matches after a little while.
// //we will add the time out

string test_str = "12/25/2030";
// string not_date = "Juneuary 2";
Regex isDate = new Regex(@"[0-9]{2}\/[0-9]{2}\/[0-9]{4}");
if (isDate.IsMatch(test_str)) //check if the string is a date )
{
    List<string> month = new List<string>();
    for (int i = 0; i < test_str.IndexOf("/"); i++)
    {
        string m = test_str[i].ToString();
        month.Add(m);
    }
    string MM = String.Concat(month);
    List<string> day = new List<string>();
    for (int i = test_str.IndexOf("/") + 1; i < test_str.LastIndexOf("/"); i++)
    {
        string d = test_str[i].ToString();
        day.Add(d);
    }
    string DD = String.Concat(day);
    List<string> year = new List<string>();
    for (int i = test_str.LastIndexOf("/") + 1; i < test_str.Length; i++)
    {
        string y = test_str[i].ToString();
        year.Add(y);
    }
    string YYYY = String.Concat(year);
    Console.WriteLine($"{MM}-{DD}-{YYYY}");
}

// Regex isDate = new Regex(@"[0-9]{2}\/[0-9]{2}\/[0-9]{4}"); //check if the string is a date 
// Console.WriteLine($"{isDate.IsMatch(not_date)}");
// pull the digits before the first slash
// Console.WriteLine(test_str.IndexOf("/"));
// string[] month = {};
// List<string> month = new List<string>();
// for (int i = 0; i < test_str.IndexOf("/"); i++)
// {
//     string m = test_str[i].ToString();
//     month.Add(m);
// }
// Console.WriteLine(String.Concat(month));
// string MM = String.Concat(month);
// // pull the digits in between the slashes
// // Console.WriteLine(test_str.LastIndexOf("/"));
// List<string> day = new List<string>();
// for (int i = test_str.IndexOf("/")+1; i < test_str.LastIndexOf("/"); i++)
// {
//     string d = test_str[i].ToString();
//     day.Add(d);
// }
// Console.WriteLine(String.Concat(day));
// string DD = String.Concat(day);
// //pull the digits after the last slash
// List<string> year = new List<string>();
// for (int i = test_str.LastIndexOf("/") + 1; i < test_str.Length; i++)
// {
//     string y = test_str[i].ToString();
//     year.Add(y);
// }
// // Console.WriteLine(String.Concat(year));
// string YYYY = String.Concat(year);

//need to return 2030-12-25
// Console.WriteLine($"{MM}-{DD}-{YYYY}");