using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{
    class Program
    {

        static int[] batman = new int[8]; 
        static int[] spiderman = new int[8]; 
        static int lilyage = 0, toyprice = 0;
        static float machineprice = 0F;
        static int orders, perorderprice;
        static void Main(string[] args)
        {
            /*LilyTask();*/
            /*PassorFail();*/
            /*ForLoop();*/
            /*WhileLoop();*/
            /*DoWhile();*/
            /*LargestNumber();*/
            /*Addingtwonumbers();*/
            /*Filehandling();*/
            /*Writingintofile();*/
            /*Pizzadelivery();*/
        }

        static void Pizzadelivery()
        {
            for(int q=0;q<8;q++)
            {
                batman[q] = q + 5;
                spiderman[q] = q + 4;
            }
            Console.Write("Enter the number of orders: ");
            orders = int.Parse(Console.ReadLine());
            Console.Write("Enter the price per order: ");
            perorderprice = int.Parse(Console.ReadLine());
            Writeorder(orders,perorderprice);
            pizzacalculation(orders, perorderprice);
            Console.ReadKey();

        }


        static void pizzacalculation(int order,int price)
        {
            int batcount = 0,spcount=0;
            for(int u=0;u<8;u++)
            {
                if(price>batman[u])
                {
                    batcount++;
                }
                if(price>spiderman[u])
                {
                    spcount++;
                }
            }
            if(batcount>order|| batcount == order)
            {
                Console.WriteLine("Batman  ");
            }
            if (spcount > order || spcount == order)
            {
                Console.WriteLine("Spiderman  ");
            }
        }


        static void  readpizza()
        {
            string path = "C:\\2nd Semester\\Assignment\\OOP\\Week 1\\Lab 01\\Task1\\pizza.txt";
            if(File.Exists(path))
            {
                string record;
                StreamReader filevariable = new StreamReader(path, true);
                while ((record = filevariable.ReadLine())!=null)
                {
                    Processrecord(record);
               
                }
                filevariable.Close();
            }
            
        }

        static void Processrecord(string record)
        {
            int[] readed = new int[record.Length];
            for (int y = 0; y < record.Length; y++)
            {
                if (record[y] == '[')
                {
                    for(int u=y+1;u<record.Length;u++)
                    {
                        readed[y] = record[u];
                    }
                }
                else
                {
                    continue;
                }
            }
        }



        static void Writeorder(int order,int pricepo)
        {
            string path = "C:\\2nd Semester\\Assignment\\OOP\\Week 1\\Lab 01\\Task1\\pizza.txt";
            if (File.Exists(path))
            {
                StreamWriter filevariable = new StreamWriter(path, true);
                filevariable.WriteLine(order+" "+pricepo);
                filevariable.Flush();
                filevariable.Close();
            }

        }


        static void Write(string name)
        {
            string path = "C:\\2nd Semester\\Assignment\\OOP\\Week 1\\Lab 01\\Task1\\textfile.txt";
            if (File.Exists(path))
            {
                StreamWriter filevariable = new StreamWriter(path, true);
                filevariable.WriteLine(name);
                filevariable.Flush();
                filevariable.Close();
            }
            
        }


       




        static void Writingintofile()
        {
            string path = "C:\\2nd Semester\\Assignment\\OOP\\Week 1\\Lab 01\\Task1\\Task1\\";
            StreamWriter filevariable = new StreamWriter(path, true);
            filevariable.WriteLine("Hello Oggy");
            filevariable.Flush();
            filevariable.Close();
        }


        static void Filehandling()
        {

            string path = "C:\\2nd Semester\\Assignment\\OOP\\Week 1\\Lab 01\\Task1\\Task1\\textfile.txt";
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    Console.WriteLine(record);
                }
                fileVariable.Close();
            }
            else
            {
                Console.WriteLine("Not Exsists");
            }
            Console.Read();
        }
        static void Addingtwonumbers()
        {
            int num1, num2;
            Console.Write("Enter 1st number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter 2nd number: ");
            num2 = int.Parse(Console.ReadLine());
            int result = Add(num1, num2);
            Console.WriteLine("The Sum is: {0}", result);
            Console.Read();
        }
        static int Add(int n1, int n2)
        {
            return n1 + n2;
        }

        static void LargestNumber()
        {
            int[] numbers = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter the number {0}: ", i);
                numbers[i] = int.Parse(Console.ReadLine());

            }

            int largest = -1;
            for (int i = 0; i < 3; i++)
            {
                if (numbers[i] > largest)
                {
                    largest = numbers[i];
                }

            }
            Console.WriteLine("Largest is {0}: ", largest);
            Console.Read();
        }

        static void DoWhile()
        {
            int num, sum = 0;
            do
            {
                Console.Write("Enter number: ");
                num = int.Parse(Console.ReadLine());
                sum = sum + num;
            }
            while (num != -1);
            sum = sum + 1;
            Console.WriteLine("The total sum is {0}", sum);
            Console.Read();
        }
        static void WhileLoop()
        {
            int num, sum = 0;
            Console.Write("Enter Number: ");
            num = int.Parse(Console.ReadLine());
            while (num != -1)
            {
                sum = sum + num;
                Console.Write("Enter number: ");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The total sum is {0}", sum);
            Console.Read();
        }


        static void ForLoop()
        {
            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("Welcome Oggy.");
            }
            Console.Read();
        }

        static void PassorFail()
        {
            string input;
            float marks;
            Console.Write("Enter marks: ");
            marks = int.Parse(Console.ReadLine());
            if (marks > 50)
            {
                Console.WriteLine("You are passed.");
            }
            else
            {
                Console.WriteLine("You are failed.");
            }
            Console.Read();
        }

        static void LilyTask()
        {
            int temp = 0;

            Console.WriteLine("Enter the age of Lily: ");
            lilyage = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the price of one toy: ");
            toyprice = int.Parse(Console.ReadLine());
            Console.Write("Enter the price of Washing Machine: ");
            machineprice = float.Parse(Console.ReadLine());
            float birthdayamount = Agecalculation(lilyage);
            if (birthdayamount > machineprice)
            {
                Console.Write("Yes!");
                temp = (int)(birthdayamount - machineprice);
                Console.WriteLine(temp);
            }
            else if (birthdayamount < machineprice)
            {
                Console.Write("No!");
                temp = (int)(machineprice - birthdayamount);
                Console.Write(temp);
            }
            Console.Read();
        }
        static int Agecalculation(int age)
        {
            int evenamount = 0, toynumber = 0, var = 0, count = 0;

            for (int y = 0; y < age; y++)
            {
                if (y % 2 == 0)
                {
                    evenamount = evenamount + 10;
                    var = evenamount + var;
                    count++;

                }
                else if (y % 2 != 0)
                {
                    toynumber++;
                }
            }
            var = var - count;
            int birthdayamount = Calculation(var, toynumber);
            return birthdayamount;

        }
        static int Calculation(int amount, int toys)
        {
            int totalamount = 0, toyamount = 0;
            toyamount = toys * toyprice;
            totalamount = toyamount + amount;
            return totalamount;
        }
    }
}













static string nameOf_buyer(string record)
{
    string namei = "";
    for (int x = 0; x < record.Length; x++)
    {
        if (record[x] != ' ')
        {
            namei = namei + record[x];
        }
        else
        {
            break;
        }
    }
    return namei;
}

static bool order_parsedata(string record, int Number_of_orders, int order_price)
{
    int comma = 1;
    int field = 1;
    string item = "";
    bool start = false;
    bool result = false;
    bool checkComma = false;
    int count = 0;
    for (int x = 0; x < record.Length; x++)
    {
        if (record[x] == ']')
        {
            start = false;
            if (int.Parse(item) >= order_price)
            {
                count = count + 1;
            }
            break;
        }
        if (record[x] == ',')
        {
            comma++;
            int num = int.Parse(item);
            if (num >= order_price)
            {
                count = count + 1;
            }
            item = "";
            checkComma = true;
        }
        if (start == true && comma == field)
        {
            item = item + record[x];
        }
        if (checkComma == true)
        {
            field++;
            checkComma = false;
        }
        if (record[x] == '[')
        {
            start = true;
        }

    }
    if (count >= Number_of_orders)
    {
        result = true;
    }
    return result;
}
static void OrderreadData(string path, int Number_of_orders, int order_price, string[] Free_pizzaTo_name)
{
    int x = 0;
    if (File.Exists(path))
    {
        StreamReader fileVariable = new StreamReader(path);
        string record;
        string namei;
        bool Free_pizza = false;
        while ((record = fileVariable.ReadLine()) != null)
        {
            Free_pizza = order_parsedata(record, Number_of_orders, order_price);
            namei = nameOf_buyer(record);
            if (Free_pizza == true)
            {
                Free_pizzaTo_name[x] = namei;
                x++;
            }
            if (x >= 2)
            {
                break;
            }
        }
        fileVariable.Close();
    }
}
static void Free_pizza_points()
{
    string path = "E:\\OOP lab\\Week 01\\.vs\\orders.txt";
    Console.WriteLine("Enter the minimum numbers of orders: ");
    int Number_of_orders = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter the minimum order prize: ");
    int order_price = int.Parse(Console.ReadLine());
    string[] Free_pizzaTo_name = new string[2];
    OrderreadData(path, Number_of_orders, order_price, Free_pizzaTo_name);
    for (int x = 0; x < 2; x++)
    {
        Console.WriteLine(Free_pizzaTo_name[x]);
    }
    Console.ReadKey();
}









