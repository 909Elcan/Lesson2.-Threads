using System.Diagnostics;

namespace ConsoleApp2
{
    internal class Program
    {
     

        static void WriteFile1()
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = @"C:\Users\Elcan\Music\music1.mp3",
                UseShellExecute = true
            });

   
             Thread.Sleep(500);
            
        }

        static void WriteFile2()
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = @"C:\Users\Elcan\Music\music2.mp3",
                UseShellExecute = true
            });

            Thread.Sleep(500);
           
        }

        static void WriteFile3()
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = @"C:\Users\Elcan\Music\music3.mp3",
                UseShellExecute = true
            });

        
            Thread.Sleep(500);
            
        }

        static void Main(string[] args)
        {
            Thread thread1 = new Thread(WriteFile1);
            Thread thread2 = new Thread(WriteFile2);
            Thread thread3 = new Thread(WriteFile3);

            while (true)
            {
                Console.Clear();

                Console.WriteLine("Go To Files 1");
                Console.WriteLine("Exit 0");

                string command = Console.ReadLine();

                if (command == "1")
                {
                    while (true)
                    {
                        Console.Clear();

                        Console.WriteLine("file 1");
                        Console.WriteLine("file 2");
                        Console.WriteLine("file 3");

                        Console.WriteLine();

                        Console.WriteLine("write no of file start");
                        Console.WriteLine("s-1 for stop");
                        Console.WriteLine("s-2 for stop");
                        Console.WriteLine("s-3 for stop");
                        Console.WriteLine("stopall");
                        Console.WriteLine("exit");

                        command = Console.ReadLine();

                        if (command == "1")
                        {
                            thread1 = new Thread(WriteFile1);
                            thread1.Start();
                        }

                        if (command == "2")
                        {
                           
                            thread2 = new Thread(WriteFile2);
                            thread2.Start();
                        }

                        if (command == "3")
                        {
                          
                            thread3 = new Thread(WriteFile3);
                            thread3.Start();
                        }

                        if (command == "s-1")
                        {
                            thread1.Join();
                        }

                        if (command == "s-2")
                        {
                           
                            thread2.Join();
                        }

                        if (command == "s-3")
                        {
                            
                            thread3.Join();
                        }

                        if (command == "stopall")
                        {
                            thread1.Join();
                            thread2.Join();
                            thread3.Join();

                        }

                        if (command == "exit")
                        {
                           
                            break;
                        }
                    }
                }

                if (command == "0")
                {
                    break;
                }
            }
        }
    }
}