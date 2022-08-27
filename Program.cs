// This is the folder/dir location/path:
string myFolderNameWithPath = @"./MyTestFolder";
var dirInfo = System.IO.Directory.CreateDirectory(myFolderNameWithPath);
Console.WriteLine();
Console.WriteLine($"This folder {dirInfo.FullName}\" has been created.");

// This is the file name
string fileName = System.IO.Path.GetRandomFileName() + ".txt";
string textFile = "TextFile.txt";

// This basically combines myFolderNameWithPath("./MyTestFolder") and fileName ("MyTextFile2.txt") to "./MyTestFolder/MyTextFile2.txt"
var myFileNameWithPath = System.IO.Path.Combine(myFolderNameWithPath, fileName);
var myTextFile = System.IO.Path.Combine(myFolderNameWithPath, textFile);
Console.WriteLine();
Console.WriteLine("Files " + fileName + " and " + textFile + " has been created in " + myFolderNameWithPath);
Console.WriteLine();

if (!System.IO.File.Exists(myFileNameWithPath) && !System.IO.File.Exists(myTextFile))
{
    string text = "When he hears the fire alarm; " + System.Environment.NewLine
                  + "Sam is always cool and calm.";

    File.WriteAllText(myFileNameWithPath, text);
    File.WriteAllText(myTextFile, text);

    string[] files = Directory.GetFiles(myFolderNameWithPath);

    Console.WriteLine("The folder " + myFolderNameWithPath + " now has the following files - "
    + System.Environment.NewLine);

    for (var i = 0; i < files.Length; i++)

        Console.WriteLine(files[i] + System.Environment.NewLine);
}
else
{

    Console.WriteLine("Program failed. Try again");

}











