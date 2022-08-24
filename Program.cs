string myFolderNameWithPath = @"./bin/MyTestFolder";
 var dirInfo = System.IO.Directory.CreateDirectory(myFolderNameWithPath);
Console.WriteLine($"\">>> {dirInfo.FullName}\" has been created.");
System.IO.Directory.CreateDirectory(myFolderNameWithPath);

string fileName = System.IO.Path.GetRandomFileName();
fileName = Guid.NewGuid().ToString() + ".txt";
myFolderNameWithPath = System.IO.Path.Combine(myFolderNameWithPath, fileName);
Console.WriteLine($">>> File \"{fileName}\" will be created in {myFolderNameWithPath}");
Console.WriteLine("Path to my file: {0}\n", myFolderNameWithPath);


if (!System.IO.File.Exists(myFolderNameWithPath))
        {
            using (System.IO.FileStream fs = System.IO.File.Create(myFolderNameWithPath))
            {
                for (byte i = 0; i < 100; i++)
                {
                    string text = "TEST SUCCESSFUL";
                    await File.WriteAllTextAsync(fileName, text);

                  //  fs.WriteByte(i);
                }
            }
        }
        else
        {
            Console.WriteLine("File \"{0}\" already exists.", fileName);
            return;
        }

        // Read and display the data from your file.
        try
        {
            byte[] readBuffer = System.IO.File.ReadAllBytes(myFolderNameWithPath);
            foreach (byte b in readBuffer)
            {
                Console.Write(b + " ");
            }
            Console.WriteLine();
        }
        catch (System.IO.IOException e)
        {
            Console.WriteLine(e.Message);
        }
      



        // Keep the console window open in debug mode.
        System.Console.WriteLine("Press any key to exit.");
        System.Console.ReadKey();
    




