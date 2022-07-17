using System;
using System.Threading;
using System.Collections.Generic;
using System.IO;

namespace fileh
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string path = @"E:\Filedemo";
            //string[] dirt=Directory.GetFiles(path,"*",SearchOption.AllDirectories);

            //foreach(string dir in dirt)
            //{
            //    //Console.WriteLine(Path.GetFileNameWithoutExtension(dir));
            //    var info=new FileInfo(dir);
            //    Console.WriteLine($"{Path.GetFileName(dir)}  size : {info.Length} Bytes");
            //}



            //bool demo=Directory.Exists(path2);

            //    if (demo)
            //    {
            //        Console.WriteLine("The folder is already esixts");
            //    }
            //    else
            //    {
            //        Console.WriteLine("The folder does not exits");
            //        Console.WriteLine("Press Y to create onre\npress N exist");
            //        string n=Console.ReadLine();
            //        Console.Beep();    
            //        if(n=="y")
            //        {

            //            Directory.CreateDirectory(path2);
            //            Console.WriteLine("Folder Has Created sucssesfully..");
            //        }
            //        else
            //        {
            //            return;
            //        }



            //    }


            //string[] a=Directory.GetFiles(path);
            //string path2 = @"E:\Filedemo\koustav\";

            //foreach(string s in a)
            //{
            //    Console.WriteLine(s);
            //    File.Move(s,$"{path2} {Path.GetFileNameWithoutExtension(s)}",true);
            //}

            string invalid = "\t\t\t\tInvalid Selection Try Again..........";
            string exit = "\t\t\t\tExsiting Program..........";
            //string drive1 = @"E:\";
            //string drive2= @"D:\";
            

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t\t\twelcome user to file system");
            lvl3:
            Console.WriteLine("\t\t\t\t Select The disered drive");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\t\t\t\t      D .Drive (D)");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\t\t\t\t      E .Drive (E)");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t\t\t      Z .Exit PROGRAM");
            string Dselection=Console.ReadLine();
            Console.Beep();
            Console.Clear();
            if(Dselection=="d" || Dselection=="D")
            {
            lvl:
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("\n\t\t\t\tEnter the folder name you want to create : ");
                string fold = Console.ReadLine();
                Console.Beep();

                string path = @"D:\" + fold;

                bool foldexist = Directory.Exists(path);

                if (foldexist)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\t\t\t\tThe folder is already exist try again it using a new name");
                    goto lvl;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Directory.CreateDirectory(path);
                    Console.WriteLine($"\t\t\t\tyou have suscessfully created {Path.GetFileName(path)} folder!!!!");
                    lvl4:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\t\t\t\tC.create (TXT) fIle");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("\t\t\t\tE. (Exit) I Am Done");
                    string choice = Console.ReadLine();
                    Console.Beep();
                    Console.Clear();
                    if(choice =="c"||choice=="C")
                    {
                        lvl6:
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("\n\t\t\t\tEnter The File Name You Wnat To Create (With extinsion) : ");
                        string file = Console.ReadLine();
                        Console.Beep();
                        string f = path + @"\" + file;
                        File.Create(f).Close();
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine($"\t\t\t\t{file} Has Been Created....");
                        Thread.Sleep(1000);
                        Console.Clear();
                        lvl10:
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("\t\t\t\tC. Create another ?");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\t\t\t\tA. Putting Text Inside The File (Append) ?");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("\t\t\t\tO. Putting Text Inside The File (Overide) ?");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\t\t\t\tD. Delete The File ?");
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("\t\t\t\tE. Exit ?");
                        string ch= Console.ReadLine();
                        Console.Beep();
                        Console.Clear();
                        
                        if(ch =="C"|| ch=="c")
                        {
                            goto lvl6;
                        }
                        if (ch == "e" || ch == "E")
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\t\t\t\tBye....");
                            Thread.Sleep(1000);
                            return;
                        }
                        if(ch == "o" || ch == "O")
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("\t\t\t\tEnter The File Name (With Extinsion)......");
                            string na= Console.ReadLine();
                            Console.Beep();
                            string fa= path + @"\" + na;


                            if (File.Exists(fa))
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("\n\t\t\t\tYour messege : ");
                                string msg = Console.ReadLine();
                                Console.Beep();
                                File.WriteAllText(fa, msg);
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("\t\t\t\tM.Main Menu");
                                Console.WriteLine("\t\t\t\tS.Menu List");
                                Console.WriteLine("\t\t\t\tE.Exit");
                                string sk= Console.ReadLine();
                                Console.Beep();
                                if(sk=="m"||sk=="M")
                                {
                                    goto lvl3;
                                }
                                if(sk=="S"||sk=="s")
                                {
                                    goto lvl10;
                                }
                                if(sk=="e"||sk=="E")
                                {
                                    Console.ReadKey();
                                    Console.Clear();
                                    return;
                                }
                               
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("\t\t\t\tOoops No Such Exist....");
                                return;
                            }
                            



                        }

                        if (ch == "A" || ch == "a")
                        {
                            
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("\t\t\t\tEnter The File Name (With Extinsion)......");
                            string na = Console.ReadLine();
                            Console.Beep();
                            string fa = path + @"\" + na;


                            if (File.Exists(fa))
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("\n\t\t\t\tYour messege : ");
                                string msg = Console.ReadLine();
                                Console.Beep();
                                File.AppendAllText(fa, msg);
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("\t\t\t\tM.Main Menu");
                                Console.WriteLine("\t\t\t\tS.Menu List");
                                Console.WriteLine("\t\t\t\tE.Exit");
                                string sk = Console.ReadLine();
                                Console.Beep();
                                if (sk == "m" || sk == "M")
                                {
                                    goto lvl3;
                                }
                                if (sk == "S" || sk == "s")
                                {
                                    goto lvl10;
                                }
                                if (sk == "e" || sk == "E")
                                {
                                    Console.ReadKey();
                                    Console.Clear();
                                    return;
                                }

                            }
                            else
                            {
                                Console.WriteLine("\t\t\t\toops No Such Exsits......");
                                Thread.Sleep(2000);          
                                Console.WriteLine("\t\t\t\tM.Main Menu");
                                Console.WriteLine("\t\t\t\tS.Menu List");
                                Console.WriteLine("\t\t\t\tE.Exit");
                                string t = Console.ReadLine();
                 
                                if (t == "m" || t == "M")
                                {
                                    goto lvl3;
                                }
                                if (t == "S" || t == "s")
                                {
                                    goto lvl10;
                                }
                                if (t == "e" || t == "E")
                                {
                                    Console.ReadKey();
                                    Console.Clear();
                                    return;
                                }
                            }




                        }
                        if(ch == "D" || ch == "d")
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            lvl11:
                            Console.WriteLine("\t\t\t\tEnter The File Name (With Extinsion)......");
                            string na = Console.ReadLine();
                            Console.Beep();
                            string fa = path + @"\" + na;
                            if (File.Exists(fa))
                            {
                                File.Delete(fa);
                                Console.WriteLine("\t\t\t\tThe File has been Deleted Sucsessfully....");
                                Thread.Sleep(1000);
                                Console.Clear();
                              
                                Console.WriteLine("\t\t\t\tM.Main Menu");
                                Console.WriteLine("\t\t\t\tS.Menu List");
                                Console.WriteLine("\t\t\t\tE.Exit");
                                string t = Console.ReadLine();
                            
                                if (t == "m" || t == "M")
                                {
                                    goto lvl3;
                                }
                                if (t == "S" || t == "s")
                                {
                                    goto lvl10;
                                }
                                if (t == "e" || t == "E")
                                {
                                    Console.ReadKey();
                                    Console.Clear();
                                    return;
                                }
                            }
                            else
                            {
                                Console.WriteLine("\t\t\t\toops No Such Exsits......");
                                Thread.Sleep(1000);
                                Console.Clear();
                                Console.WriteLine("\t\t\t\tT.Try Again?");
                                Console.WriteLine("\t\t\t\tM.Main Menu");
                                Console.WriteLine("\t\t\t\tS.Menu List");
                                Console.WriteLine("\t\t\t\tE.Exit");
                                string t = Console.ReadLine();
                                if (t =="t" || t =="T")
                                {
                                    goto lvl11;
                                }
                                if (t == "m" || t == "M")
                                {
                                    goto lvl6;
                                }
                                if (t == "S" || t == "s")
                                {
                                    goto lvl10;
                                }
                                if (t == "e" || t == "E")
                                {
                                    Console.ReadKey();
                                    Console.Clear();
                                    return;
                                }
                            }
                        }

                    }
                    if (choice == "e" || choice == "E")
                    {
                        Console.ForegroundColor= ConsoleColor.DarkCyan;
                        Console.WriteLine("\t\t\t\tSee ya...");
                        Thread.Sleep(1000);
                        return;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\t\t\t\tInvaild Choice Try Again");
                        Thread.Sleep(2000);
                        Console.Clear();
                        goto lvl4;
                        
                    }


                }

            }
            if (Dselection == "e" || Dselection == "E")
            {
            lvl:
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("\n\t\t\t\tEnter the folder name you want to create : ");
                string fold = Console.ReadLine();
                Console.Beep();

                string path = @"E:\" + fold;

                bool foldexist = Directory.Exists(path);

                if (foldexist)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\t\t\t\tThe folder is already exist try again it using a new name");
                    goto lvl;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Directory.CreateDirectory(path);
                    Console.WriteLine($"\t\t\t\tyou have suscessfully created {Path.GetFileName(path)} folder!!!!");
                lvl4:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\t\t\t\tC.create (TXT) fIle");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("\t\t\t\tE. (Exit) I Am Done");
                    string choice = Console.ReadLine();
                    Console.Beep();
                    Console.Clear();
                    if (choice == "c" || choice == "C")
                    {
                    lvl6:
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("\n\t\t\t\tEnter The File Name You Wnat To Create (With extinsion) : ");
                        string file = Console.ReadLine();
                        Console.Beep();
                        string f = path + @"\" + file;
                        File.Create(f).Close();
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine($"\t\t\t\t{file} Has Been Created....");
                        Thread.Sleep(1000);
                        Console.Clear();
                    lvl10:
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("\t\t\t\tC. Create another ?");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\t\t\t\tA. Putting Text Inside The File (Append) ?");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("\t\t\t\tO. Putting Text Inside The File (Overide) ?");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\t\t\t\tD. Delete The File ?");
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("\t\t\t\tE. Exit ?");
                        string ch = Console.ReadLine();
                        Console.Beep();
                        Console.Clear();

                        if (ch == "C" || ch == "c")
                        {
                            goto lvl6;
                        }
                        if (ch == "e" || ch == "E")
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\t\t\t\tBye....");
                            Thread.Sleep(1000);
                            return;
                        }
                        if (ch == "o" || ch == "O")
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("\t\t\t\tEnter The File Name (With Extinsion)......");
                            string na = Console.ReadLine();
                            Console.Beep();
                            string fa = path + @"\" + na;


                            if (File.Exists(fa))
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("\n\t\t\t\tYour messege : ");
                                string msg = Console.ReadLine();
                                Console.Beep();
                                File.WriteAllText(fa, msg);
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("\t\t\t\tM.Main Menu");
                                Console.WriteLine("\t\t\t\tS.Menu List");
                                Console.WriteLine("\t\t\t\tE.Exit");
                                string sk = Console.ReadLine();
                                Console.Beep();
                                if (sk == "m" || sk == "M")
                                {
                                    goto lvl3;
                                }
                                if (sk == "S" || sk == "s")
                                {
                                    goto lvl10;
                                }
                                if (sk == "e" || sk == "E")
                                {
                                    Console.ReadKey();
                                    Console.Clear();
                                    return;
                                }

                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("\t\t\t\tOoops No Such Exist....");
                                return;
                            }




                        }

                        if (ch == "A" || ch == "a")
                        {

                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("\t\t\t\tEnter The File Name (With Extinsion)......");
                            string na = Console.ReadLine();
                            Console.Beep();
                            string fa = path + @"\" + na;


                            if (File.Exists(fa))
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("\n\t\t\t\tYour messege : ");
                                string msg = Console.ReadLine();
                                Console.Beep();
                                File.AppendAllText(fa, msg);
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("\t\t\t\tM.Main Menu");
                                Console.WriteLine("\t\t\t\tS.Menu List");
                                Console.WriteLine("\t\t\t\tE.Exit");
                                string sk = Console.ReadLine();
                                Console.Beep();
                                if (sk == "m" || sk == "M")
                                {
                                    goto lvl3;
                                }
                                if (sk == "S" || sk == "s")
                                {
                                    goto lvl10;
                                }
                                if (sk == "e" || sk == "E")
                                {
                                    Console.ReadKey();
                                    Console.Clear();
                                    return;
                                }

                            }
                            else
                            {
                                Console.WriteLine("\t\t\t\toops No Such Exsits......");
                                Thread.Sleep(2000);
                                Console.WriteLine("\t\t\t\tM.Main Menu");
                                Console.WriteLine("\t\t\t\tS.Menu List");
                                Console.WriteLine("\t\t\t\tE.Exit");
                                string t = Console.ReadLine();

                                if (t == "m" || t == "M")
                                {
                                    goto lvl3;
                                }
                                if (t == "S" || t == "s")
                                {
                                    goto lvl10;
                                }
                                if (t == "e" || t == "E")
                                {
                                    Console.ReadKey();
                                    Console.Clear();
                                    return;
                                }
                            }




                        }
                        if (ch == "D" || ch == "d")
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                        lvl11:
                            Console.WriteLine("\t\t\t\tEnter The File Name (With Extinsion)......");
                            string na = Console.ReadLine();
                            Console.Beep();
                            string fa = path + @"\" + na;
                            if (File.Exists(fa))
                            {
                                File.Delete(fa);
                                Console.WriteLine("\t\t\t\tThe File has been Deleted Sucsessfully....");
                                Thread.Sleep(1000);
                                Console.Clear();

                                Console.WriteLine("\t\t\t\tM.Main Menu");
                                Console.WriteLine("\t\t\t\tS.Menu List");
                                Console.WriteLine("\t\t\t\tE.Exit");
                                string t = Console.ReadLine();

                                if (t == "m" || t == "M")
                                {
                                    goto lvl3;
                                }
                                if (t == "S" || t == "s")
                                {
                                    goto lvl10;
                                }
                                if (t == "e" || t == "E")
                                {
                                    Console.ReadKey();
                                    Console.Clear();
                                    return;
                                }
                            }
                            else
                            {
                                Console.WriteLine("\t\t\t\toops No Such Exsits......");
                                Thread.Sleep(1000);
                                Console.Clear();
                                Console.WriteLine("\t\t\t\tT.Try Again?");
                                Console.WriteLine("\t\t\t\tM.Main Menu");
                                Console.WriteLine("\t\t\t\tS.Menu List");
                                Console.WriteLine("\t\t\t\tE.Exit");
                                string t = Console.ReadLine();
                                if (t == "t" || t == "T")
                                {
                                    goto lvl11;
                                }
                                if (t == "m" || t == "M")
                                {
                                    goto lvl3;
                                }
                                if (t == "S" || t == "s")
                                {
                                    goto lvl10;
                                }
                                if (t == "e" || t == "E")
                                {
                                    Console.ReadKey();
                                    Console.Clear();
                                    return;
                                }
                            }
                        }

                    }
                    if (choice == "e" || choice == "E")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("\t\t\t\tSee ya...");
                        Thread.Sleep(1000);
                        return;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\t\t\t\tInvaild Choice Try Again");
                        Thread.Sleep(2000);
                        Console.Clear();
                        goto lvl4;

                    }


                }
            }
            if(Dselection=="z"||Dselection=="Z")
            {
                Console.Clear();
                
                for(int i=0;i<exit.Length;i++)
                {
                    
                    Console.Write(exit[i]);
                    Thread.Sleep(100);
                }
            }
            else
            {
                for(int i = 0; i < invalid.Length; i++)
                {
                    Console.Write(invalid[i]);
                    Thread.Sleep(100);
                }
                Console.Clear();
                goto lvl3;                
            }
        //lvl:
        //    Console.Write("\n\t\t\t\tEnter the folder name you want to create : ");
        //    string fold=Console.ReadLine();
        //    Console.Beep();

        //    string path = @"E:\"+fold;

        //    bool foldexist=Directory.Exists(path);
            
        //    if (foldexist)
        //    {
        //        Console.ForegroundColor = ConsoleColor.DarkRed;
        //        Console.WriteLine("\t\t\t\tThe folder is already exist try again it using a new name");
        //        goto lvl;
        //    }
        //    else 
        //    {
        //        Console.ForegroundColor = ConsoleColor.DarkGreen;

        //        Directory.CreateDirectory(path);
        //        Console.WriteLine($"\t\t\t\tyou have suscessfully created {Path.GetFileName(path)} folder!!!!");
        //    }









        }

    }
}
