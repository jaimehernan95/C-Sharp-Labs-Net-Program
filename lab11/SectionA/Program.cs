using CommonData;
using System;
using System.IO;
using System.Security;

namespace SectionA
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                FileOperations fo = new FileOperations();

                string[] EnteredLines = new string[5];

                Console.WriteLine("Enter Five Lines:");
                for (int i = 0; i < EnteredLines.Length; i++)
                {
                    EnteredLines[i] = Console.ReadLine();
                }

                fo.WriteToFile(EnteredLines);
                fo.ReadFromFile();
            }
            catch(FileNotFoundException)
            {
                Console.WriteLine("File not found");
            }
            catch(DirectoryNotFoundException)
            {
                Console.WriteLine("directory not found");
            }
            catch(DriveNotFoundException)
            {
                Console.WriteLine("Drive not found");
            }
            catch(PathTooLongException)
            {
                Console.WriteLine("File path is too long");
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("Operation Canceled");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Un authorized access to file");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Invalid Path Characters");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("UInvalid colons");
            }
            catch (SecurityException)
            {
                Console.WriteLine("File permission error");
            }


        }
    }
}
