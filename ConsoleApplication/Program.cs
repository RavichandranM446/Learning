using System.Collections;
using System.Transactions;

namespace ConsoleApplication
    {
    class Program
{
    static void Main(string[] args)
    {
            //int number;
            //double percentage;
            //string name;
            //char section;

            //number = 22;
            //percentage = 22.1;
            //name = "Mass";
            //section = 'B';

            //Console.WriteLine("Number :" + number);
            //Console.WriteLine("Percentage :" + percentage);
            //Console.WriteLine("Name :" + name);
            //Console.WriteLine("Section :" +section);
            //Console.ReadLine();

            //string firstname;
            //Console.Write("Enter your Name :");
            //firstname = Console.ReadLine();
            //char sec;
            //Console.WriteLine("Enter Your Section :");
            //sec = Convert.ToChar(Console.ReadLine());
            //double per;
            //Console.WriteLine("Enter your percentage");
            //per = Convert.ToDouble(Console.ReadLine());
            //int mark;
            //Console.WriteLine("Enter your Mark:");
            //mark = int.Parse(Console.ReadLine());

            //int mark1, mark2,sum,diff;
            //Console.WriteLine("Enter your mark1");
            //mark1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter your mark2");
            //mark2 = int.Parse(Console.ReadLine());
            //sum=mark1 + mark2;
            //Console.WriteLine(sum);
            //diff=mark1- mark2;
            //Console.WriteLine(diff);
            //Console.WriteLine("Calculator");    
            //Console.ReadLine();

            //int a, b, sum,diff,product,quotient,remainder;
            //Console.WriteLine("Enter the A value");
            //a=int.Parse(Console.ReadLine());
            //Console.WriteLine("The value of A is :" + a);
            //Console.ReadLine();
            //Console.WriteLine("Enter the B value");
            //b = int.Parse(Console.ReadLine());
            //Console.WriteLine("The value of B is :" + b);
            //Console.ReadLine();
            //sum = a + b;
            //diff = a - b;
            //product = a * b;
            //quotient = a / b;
            //remainder = a % b;
            //Console.WriteLine("The Value Of Sum Is : "+sum);
            //Console.WriteLine("The Value Of Diff Is : "+diff);
            //Console.WriteLine("The Value Of Product Is : "+product);
            //Console.WriteLine("The Value Of Quotient Is :"+quotient);
            //Console.WriteLine("The Value Of Remainder Is :"+remainder);
            //Console.WriteLine("The Value Of A is Equal to B :" + (a==b));
            //Console.WriteLine("The Value Of A is Equal to B :" + (a != b));
            //Console.WriteLine("The Value Of A is Equal to B :" + (a > b));
            //Console.WriteLine("The Value Of A is Equal to B :" + (a >= b));
            //Console.WriteLine("The Value Of A is Equal to B :" + (a < b));
            //Console.WriteLine("The Value Of A is Equal to B :" + (a <= b));

            //int vote;
            //Console.WriteLine("Enter Your Age :");
            //vote=int.Parse(Console.ReadLine());
            ////IF Condition
            //if(vote>=18)
            //{
            //    Console.WriteLine("Eligible to vote :" + vote + "Years");
            //}
            //else
            //{
            //    Console.WriteLine("Not Eligible to vote :" + vote + "Years");
            //}
            //double time;

            //Console.Write("Enter Your Time : ");
            //time = Convert.ToDouble(Console.ReadLine());

            //if (time >= 12.00 && time < 16.00)
            //{
            //    Console.WriteLine("Good Afternoon");
            //}
            //else if (time >= 6.00 && time < 12.00)
            //{
            //    Console.WriteLine("Good Morning");
            //}
            //else if (time >= 16.00 && time <= 24.00)
            //{
            //    Console.WriteLine("Good Evening");
            //}
            //else
            //{
            //    Console.WriteLine("Given Value is Wrong");
            //}
            //double number;
            //Console.WriteLine("Enter the number");
            //number=double.Parse(Console.ReadLine());
            //Console.ReadLine();
            //if (number > 0)
            //{
            //    Console.WriteLine("Hence it is an positive number :" + number);
            //}
            //else if (number < 0)
            //{
            //    Console.WriteLine("Hence the given number is negative :" + number);
            //}
            //else
            //{
            //    Console.WriteLine("The given number is equal to zero :" + number);
            //}
            //SWITCH CASE
            //switch(variableName)
            //{
            //case ConstantExpression_1;
            //statements;
            //break;
            //default:
            //statements;
            //break;
            //}
            //int number;
            //Console.WriteLine("Enter the numbers upto 1 to 7");
            //Console.WriteLine("Enter a number:");
            //number=int.Parse(Console.ReadLine());
            //switch (number)
            //{
            //    case 1:
            //        Console.WriteLine("Sunday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 4:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    case 5:
            //        Console.WriteLine("Thursday");
            //        break;
            //    case 6:
            //        Console.WriteLine("Friday");
            //        break;
            //    case 7:
            //        Console.WriteLine("Saturday");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid number");
            //        break;
            //}
            //for loop
            //int number;
            //Console.Write("Enter the number:");
            //number=int.Parse(Console.ReadLine());
            //for (int i = number; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //int number=10;
            //for (int i = number; i >= 1; i--)
            //{
            //    Console.WriteLine(i);
            //}
            //for (int i = 1; i <= 20; i++)
            //{
            //    if (i % 2 != 0) {
            //        Console.WriteLine(i);
            //    }

            //}
            //int sum = 0;
            //for (int i = 0; i <= 10; i++)
            //{
            //       sum =sum+ i; 
            //}
            //Console.WriteLine(sum);
            //int result;
            //Console.WriteLine("Enter the factorial number:");
            //result=Convert.ToInt32(Console.ReadLine());
            //for(int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(result = result * i);
            //}
            //Console.WriteLine("user enters" + result + "factorial number");
            //int input;
            //int sum = 0;
            //Console.WriteLine("Enter a number:");
            //input = int.Parse(Console.ReadLine());
            //for (int i = 0; i <= input; i++)
            //{
            //    Console.WriteLine(sum = sum + i);
            //}
            //Console.WriteLine("1 to n"+sum+"input"+input);
            //int i = 1;
            //while (i<= 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //int i = 1;
            //while (i <= 20)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}
            //int user;
            //int sum = 0;
            //Console.Write("Enter a number 0 to stop :");
            //user=int.Parse(Console.ReadLine());
            //while (user != 0)
            //{
            //    sum = sum + user;
            //    Console.Write("Enter a number 0 to stop :");
            //    user = int.Parse(Console.ReadLine());

            //}
            //Console.WriteLine(sum);
            //int digit;
            //int count = 0;
            //Console.WriteLine("Enter the digits:");
            //digit=int.Parse(Console.ReadLine());
            //while (digit != 0)
            //{
            //    digit = digit / 10;
            //    count++;

            //}
            //Console.WriteLine(count);
            // do-while loop
            //int enter;
            //int sum = 0;
            //Console.WriteLine("Enter the number 0 to stop:");
            //enter=int.Parse(Console.ReadLine());
            //do
            //{
            //    sum = sum + enter;
            //    Console.WriteLine("Enter the number 0 to stop:");
            //    enter = int.Parse(Console.ReadLine());
            //}
            //while (enter != 0);
            //Console.WriteLine(sum);
            //foreach loop
            //int[] marks = { 50, 60, 70 };
            //foreach (int mark in marks)
            //{
            //    Console.WriteLine(mark);
            //}
            //int i,j;
            //for (i = 1; i <= 3; i++)
            //{
            //    for (j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //int i, j;
            //for (i = 3; i >= 1; i--)
            //{
            //    for (j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //int person;
            //Console.WriteLine("Enter any number");
            //person=int.Parse(Console.ReadLine());
            //for (int i = 1; i <= person; i++) {
            //    Console.WriteLine(i);
            //    Console.Write("Loop running number");
            //}
            //for(int i = 1; i <= 5; i++)
            //{
            //   Console.WriteLine(i);
            //}
            //int num;
            //Console.WriteLine("Enter a number:");
            //num=int.Parse(Console.ReadLine());
            //for(int multi=1;multi <= 10; multi++)
            //{
            //    Console.WriteLine(multi*num);
            //}
            //Console.ReadLine();
            //for (int i = 0; i <= 10; i++)
            //{
            //    if (i < 6)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();
            //Array
            // datatype[] identifier = new datatype[];
            //intialization:
            //identifier[index]=value;
            int[] marks=new int[10];
            marks[0]=80;
            marks[1] = 90;
            marks[2] = 70;
            marks[3] = 60;
            marks[4] = 80;
            marks[5] = 90;
            marks[6] = 80;
            marks[7] = 70;
            marks[8] = 60;
            marks[9] = 80;
            //foreach(datatype identifer in collection){ logic }
            foreach(int mark in marks)
            {
                Console.WriteLine("Marks "+mark);
            }
            //Array List//
            //ClassName ObjectName =new ClassName();
            // ArrayList Identifier=new ArrayList();
            //Intialization:
            //Identifier.Add=value;
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Mass");
            arrayList.Add(123);
            arrayList.Add('A');
            arrayList.Add(89.5);
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }
            int[] numbers = { 10, 100, 20, 40, 50 };
            foreach (int number in numbers)
            {
                Console.WriteLine("Numbers"+number);
            }
            //List
            List<int> empId=new List<int>();
            empId.Add(10);
            empId.Add(100);
            empId.Add(1000);
            empId.Add(10000);
            empId.Add(100000);
            foreach(int id in empId)
            {
                Console.WriteLine("empId"+id);
            }
            //HashTable
            Hashtable hashtable = new Hashtable();
            hashtable.Add("101", "Mass");
            hashtable.Add("102", "Mass Systems");
            hashtable.Add("103", "Mass sys");
            foreach(var item in hashtable.Keys)
            {
                 Console.WriteLine(hashtable[item]);
            }
            SortedList sortedlist=new SortedList();
            sortedlist.Add("1", "A");
            sortedlist.Add("2", "B");
            sortedlist.Add("3", "C");
            sortedlist.Add("4", "D");
            foreach (var value in sortedlist.Keys)
            {
                Console.WriteLine(sortedlist[value]);
            }


        }
    }
}
