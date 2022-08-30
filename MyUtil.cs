namespace Demo
{
    public static class MyUtil
    {
        public static void CreateFolder(string myFolderNameWithPath)
        {
            // This is the folder/dir location/path:            
            var dirInfo = System.IO.Directory.CreateDirectory(myFolderNameWithPath);
            Console.WriteLine($">>> This folder {dirInfo.FullName}\" has been created.");
        }

        public static void CreateFile(string myFileNameWithPath, string content)
        {
            if (!File.Exists(myFileNameWithPath))
            {
                File.WriteAllText(myFileNameWithPath, content);
            }
            else
            {
                Console.WriteLine($">>> Program failed. Reason: \"{myFileNameWithPath}\" already exits.");
            }
        }

        public static void ReadAFolderContent(string myFolderNameWithPath)
        {
            string[] files = Directory.GetFiles(myFolderNameWithPath);

            Console.WriteLine("The folder " + myFolderNameWithPath + " now has the following files - "
            + Environment.NewLine);

            for (var i = 0; i < files.Length; i++)
            {
                Console.WriteLine(">>> " + i + "- " + files[i] + Environment.NewLine);

            }
        }

        public static void ReadAFile(string myFileNameWithPath)
        {
            // Read file using StreamReader.Reads file line by line
            using (StreamReader file = new StreamReader(myFileNameWithPath))
            {
                int counter = 0;
                string? ln;

                while ((ln = file.ReadLine()) != null)
                {
                    Console.WriteLine(ln);
                    counter++;
                }

                file.Close();
                Console.WriteLine("File has " + counter + " lines.");
            }
        }

        public static void DeleteAFile(string myFileNameWithPath, string myFolderNameWithPath)
        {
            if (System.IO.File.Exists(myFileNameWithPath))
            {
                string[] files = Directory.GetFiles(myFolderNameWithPath);

                StreamReader sr = new StreamReader(myFolderNameWithPath);

                for (var i = 0; i < files.Length; i++)
                {
                    Console.WriteLine(">>> " + i + "- " + files[i] + Environment.NewLine);
                    Console.WriteLine("Enter the number of the file that you want to delete:");
                    string line = sr.ReadLine();

                    while ((line = files[i]) != null)

                    {
                        System.IO.File.Delete(myFileNameWithPath);

                    }

                }

                /*
                string LocToDeleteFile = @"E:\C-sharp-IO\testDuplicate.txt";

                //check if file exists before deleting it
                if(File.Exists(LocToDeleteFile))
                {
                  //call File.Delete with location of file
                  File.Delete(LocToDeleteFile );
                */


                /*
                try
                {
                    System.IO.File.Delete(myFileNameWithPath);
                }
                catch (System.IO.IOException e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
                */
            }

        }
    }
}


