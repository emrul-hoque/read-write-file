// This is the folder/dir location/path:
string myFolderNameWithPath = @"./MyTestFolder";
var dirInfo = System.IO.Directory.CreateDirectory(myFolderNameWithPath);
Console.WriteLine($">>> {dirInfo.FullName}\" has been created.");

// This is the file name
string fileName = System.IO.Path.GetRandomFileName() + ".txt";

// This basically combines myFolderNameWithPath("./MyTestFolder") and fileName ("MyTextFile2.txt") to "./MyTestFolder/MyTextFile2.txt"
var myFileNameWithPath = System.IO.Path.Combine(myFolderNameWithPath, fileName);
Console.WriteLine($">>> This file \"{myFileNameWithPath}\" will be created");

if (!System.IO.File.Exists(myFileNameWithPath))
{
    // If you want to write the "text" to your file, then you can either pick OPTION 1 or 2:
    string text = "TEST SUCCESSFUL";

    // OPTION #1:
    File.WriteAllText(myFileNameWithPath, text);

    // OPTION #2:
    /*using (System.IO.FileStream fs = System.IO.File.Create(myFileNameWithPath))
    {
        // fs.Close();
         using (TextWriter tw = new StreamWriter(fs))
        {
            tw.WriteLine(text);
        }
    } */
}
else
{
    Console.WriteLine("File \"{0}\" already exists.", fileName);
    return;
}

// Keep the console window open in debug mode.
System.Console.WriteLine("Press any key to exit.");
System.Console.ReadKey();





