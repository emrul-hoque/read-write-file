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
    }
}