namespace Demo
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var myFolderNameWithPath = "./MyTestFolder";
            MyUtil.CreateFolder(myFolderNameWithPath);

            // This is the file name
            string fileName = Path.GetRandomFileName() + ".txt";
            string textFile = "TextFile.txt";

            // This basically combines myFolderNameWithPath("./MyTestFolder") and fileName ("MyTextFile2.txt") to "./MyTestFolder/MyTextFile2.txt"
            var myFileNameWithPath = Path.Combine(myFolderNameWithPath, fileName);
            var myTextFile = Path.Combine(myFolderNameWithPath, textFile);
            Console.WriteLine();
            Console.WriteLine("Files " + fileName + " and " + textFile + " has been created in " + myFolderNameWithPath);
            Console.WriteLine();

            var myContent = "Here's my content. Today is: " + DateTime.Now;

            MyUtil.CreateFile(myFileNameWithPath, myContent);
            MyUtil.CreateFile(myTextFile, myContent);
            MyUtil.ReadAFolderContent(myFolderNameWithPath);
            MyUtil.ReadAFile(myTextFile);          
        }
    }   
}