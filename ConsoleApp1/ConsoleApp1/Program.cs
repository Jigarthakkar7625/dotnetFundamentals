using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {

            clsUser clsUser = new clsUser("jigar"); //Instance //Object
            clsUser.Name = "jigar"; ///Set
            clsUser.Id = 1;
            clsUser.Username = "jigar@123";

            clsUser = null;
            clsUser.Name = null;
            clsUser.Name.ToString(); // clsUser.Name >> Null >> Error
            Convert.ToString(clsUser.Name); //
//                                            //
//boxing and unboxing

            GC.Collect();

            clsUser clsUser1 = new clsUser("Nikunj"); //Instance

            clsUser clsUser2 = new clsUser("Abhisek"); //Instance


            //clsUser clsUser1 = new clsUser();

            //clsUser clsUser1 = new clsUser();

            //FileInfo fileinfo = new FileInfo("D:\\Jigar FrontEnd\\ReactJS\\jigar.txt");
            //fileinfo.Delete();

            FileStream fileStream = new FileStream("D:\\Jigar FrontEnd\\ReactJS\\jigar.txt", FileMode.Open, FileAccess.Write);



            fileStream.WriteByte(Byte.MinValue);

            //StreamWriter streamWriter = fileinfo.CreateText();
            //streamWriter.Write("Jigar Thakkar 1234 abhisek and manthan");
            //streamWriter.Close();

            //StreamReader streamReader = fileinfo.OpenText();
            //string readingLine = streamReader.ReadLine();  

            DirectoryInfo directoryInfo = new DirectoryInfo("D:\\Jigar FrontEnd\\ReactJS\\Manthan_Abhi");

            if (!directoryInfo.Exists)
            {
                directoryInfo.Delete();
            }

            //while (streamReader.ReadLine())
            //{

            //}


            //fileinfo.Create();

            FileInfo fileinfo1 = new FileInfo("D:\\Jigar FrontEnd\\ReactJS\\jigar1.txt");
            //fileinfo1.Create();
            //bin

            // collection of multiple value >> 

            //string[] vs = new string[2];

            //object[] a =  new object[2];
            //a[0] = "jigar";
            //a[1] = 2;

            //FuncationNameCallArray("jigar",1,true,"Abisek"); //


            //vs[0] = 1;
            //vs[1] = 2;
            //vs[2] = 3;
            //vs[3] = 4;
            //Console.WriteLine(vs);

            //Array >>>

            /// Multi dim
            /// Jugged array
            /// 

            // int[,] vs1 = new int[1, 2]; //2D
            // 

            //int[][] vs1 = new int[2][];
            //vs1[0] = new int[10];
            //vs1[1] = new int[10];

            //Program program = new Program(); //New keyword >> instance 

            //int abc = 10;

            //int getValue = FuncationName(abc); //Call by value

            //int callbyRefVar = 50;

            //FuncationNameCallByRef(ref callbyRefVar); //Call by Ref

            //string emailString = "jigar";

            //bool isEmail = Regex.IsMatch(emailString, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);



            //tmpVariabl:
            //    Console.WriteLine("jigar");

            //    if (true)
            //    {
            //        goto tmpVariabl;
            //    }


            //string abc = "jigar$Thakkar$gfdgf$ggdfgg$gfgdfg";

            //var a = abc.Split('$');


            List<string> list = new List<string>();


            //Console.WriteLine(isEmail);
            Console.ReadKey();
            //for (int i = 0; i < list.Count; i++)
            //{
            //    string a = list[i];
            //}

            //foreach (var item in a)
            //{
            //    //string a = item;
            //}


            //Jigar 
        }



        //public static int FuncationName(int param)
        //{

        //    int a = param + 2;

        //    return a;

        //}

        //public static void FuncationNameCallByRef(ref int param)
        //{

        //    param = param + 2;

        //    //return a;

        //}

        public static void FuncationNameCallArray(params object[] items)
        {
            if (true)
            {
                FuncationNameCallArray("1", 2, true);
            }
            //param = param + 2;

            //return a;

        }
    }
}
