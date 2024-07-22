using System.IO;

namespace FileHandlingWriteDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file1 = @"C:\Users\roshani.poojari\Desktop\Training\FileHandlingWriteDemo\assets\WriteFile.txt";
            string file2 = @"C:\Users\roshani.poojari\Desktop\Training\FileHandlingWriteDemo\assets\write.html";
            Console.WriteLine("Writing to txt file");
            using (StreamWriter writer = new StreamWriter(file1))
            {
                writer.WriteLine("This is first line");
                writer.WriteLine("This is second line");
            }
            Console.WriteLine("Text has been written successfully to txt file");

            Console.WriteLine("Writing to html file");
            using (StreamWriter sw = new StreamWriter(file2, true))
            {
                sw.WriteLine("<!DOCTYPE html>");
                sw.WriteLine("<html>");
                sw.WriteLine("<head>");
                sw.WriteLine("< title > My web page</title>");
                sw.WriteLine("<body>");
                sw.WriteLine("<p>This is my first web page.</p>");
                sw.WriteLine("<p>It contains a<strong> main heading</strong> and <em> paragraph</em>.</p>");
                sw.WriteLine("</body>");
                sw.WriteLine("</html>");
            }
            Console.WriteLine("Text has been written successfully to html file");
        }
    }
}

