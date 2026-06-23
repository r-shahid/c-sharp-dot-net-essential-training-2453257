/* create a program that summarizes the contents of FileCollection folder

scan the folder and product a report of the folder contents
create results.txt
~~~~ Results ~~~~
Total Files: 12
Excel Count: 4
Word Count: 5
PowerPoint Count: 3
----
Total Size: 2,674,311
Excel Size: 74,262
Word Size: 1,196,567
PowerPoint Size: 1,403,482

count only the office files

*/

const string resultsFile = "results.txt";
// if file doesn't exist make it. if it exists, dont do anything
// if (!File.Exists(resultsFile))
// {
//     using (StreamWriter sw = File.CreateText(resultsFile))
//     {
//         sw.WriteLine("~~~~ Results ~~~~");
//     }
// } else
// {
//     Console.WriteLine("File already exists");
// }
// create the file
// list the files in the other folder
// Console.WriteLine(Directory.GetCurrentDirectory());
string fileCol = @"/Users/rianashahid/Desktop/coding_practice/c_sharp/c-sharp-dot-net-essential-training-2453257/Start/Files/Challenge/FileCollection";
// DirectoryInfo di = new DirectoryInfo(fileCol);
// Console.WriteLine(di.Name);
List<string> thefiles = new List<string>(Directory.EnumerateFileSystemEntries(fileCol));
int fileCount = 0;
int docCount = 0;
int xlCount = 0;
int pptCount = 0;
long docBytes = 0;
long xlBytes = 0;
long pptBytes = 0;


foreach (string dir in thefiles)
{
    FileInfo fileInfo = new FileInfo(dir);
    // Console.WriteLine(dir);
    // if filename ends with any of the office things, then add to the count
    if (dir.EndsWith("docx"))
    {
        fileCount++;
        docCount++;
        docBytes += fileInfo.Length;
    } else if (dir.EndsWith("xlsx"))
    {
        fileCount++;
        xlCount++;
        xlBytes += fileInfo.Length;
    } else if (dir.EndsWith("pptx"))
    {
        fileCount++;
        pptCount++;
        pptBytes += fileInfo.Length;
    }
}
long totalBytes = docBytes+xlBytes+pptBytes;
int totalSize = (int)totalBytes;
// Console.WriteLine(totalSize);
// count the number of files with office file types
// print the results

if (!File.Exists(resultsFile))
{
    using (StreamWriter sw = File.CreateText(resultsFile))
    {
        sw.WriteLine("~~~~ Results ~~~~");
        sw.WriteLine($"Total Files: {fileCount}");
        sw.WriteLine($"Excel Count: {xlCount}");
        sw.WriteLine($"Word Count: {docCount}");
        sw.WriteLine($"Powerpoint Count: {pptCount}");
        sw.WriteLine("----");
        sw.WriteLine($"Total Size: {totalSize:N0}");
        sw.WriteLine($"Excel Size: {xlBytes:N0}");
        sw.WriteLine($"Word Size: {docBytes:N0}");
        sw.WriteLine($"PowerPoint Size: {pptBytes:N0}");

    }
}
else
{
    Console.WriteLine("File already exists");
}