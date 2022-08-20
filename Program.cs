string myFolderNameWithPath = @"./bin/MyFolder";
 var dirInfo = System.IO.Directory.CreateDirectory(myFolderNameWithPath);
Console.WriteLine($"\"{dirInfo.FullName}\" has been created.");

string fileName = System.IO.Path.GetRandomFileName();
Console.WriteLine($"File \"{fileName}\" will be created in {myFolderNameWithPath}");



