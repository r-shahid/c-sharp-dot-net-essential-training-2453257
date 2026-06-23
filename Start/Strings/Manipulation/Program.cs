// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for manipulating string content

string str1 = "The quick brown fox jumps over the lazy dog.";
string str2 = "bThis is a string";
string str3 = "THIS is a STRING";
string[] strs = {"one", "two", "three", "four"};

// TODO: Length of a string 
// Console.WriteLine(str1.Length);


// TODO: Access individual characters
// Console.WriteLine(str1[14]);

// TODO: Iterate over a string like any other sequence of values
// foreach (char ch in str1)
// {
//     Console.Write(ch);
//     if (ch == 'b')
//     {
//         Console.WriteLine();
//         break;
//     }
// }

// TODO: String Concatenation         
// string outstr;
// outstr = String.Concat(strs);
// Console.WriteLine($"{String.Concat(strs)}");


// TODO: Joining strings together with Join
// outstr = String.Join('.', strs);
// Console.WriteLine(String.Join('.', strs));
// outstr = String.Join("---", strs);
// Console.WriteLine(outstr);

// TODO: String Comparison

// Equals just returns a regular Boolean
// bool isEqual = str2.Equals(str3);
// Console.WriteLine($"{isEqual}"); //false

// Compare will perform an ordinal comparison and return:
// < 0 : first string comes before second in sort order
// 0 : first and second strings are same position in sort order
// > 0 : first string comes after the second in sort order
// int result =  String.Compare(str2, "This is a string");
// Console.WriteLine($"{result}");


// // TODO: Replacing content
// string outstr = str1.Replace("fox", "cat");
// Console.WriteLine(str1.Replace("fox", "fish"));

// DateTime date = new DateTime(2020, 4, 20);

// string dateyear = date.ToString("yyyy");

// Console.WriteLine(dateyear);

// using System.Net.WebSockets;

string FormatDateTime(DateTime the_date) {
        // Your code goes here
        string dateYear = the_date.ToString("yyyy");
        string dateMonth = the_date.ToString("MM");
        string dateDay = the_date.ToString("dd");

        Console.WriteLine($"{dateYear}, {dateMonth[1].ToString()}, {dateDay[1].ToString()}");

        if (dateMonth[0].ToString() == "0")
        {
            dateMonth = dateMonth[1].ToString();
        }
        if (dateDay[0].ToString() == "0")
        {
            dateDay = dateDay[1].ToString();
        }
        
        return $"{dateYear}--{dateMonth}--{dateDay}";
    }

DateTime test_date = new DateTime(2030, 4, 1);
// Console.WriteLine(FormatDateTime(test_date));