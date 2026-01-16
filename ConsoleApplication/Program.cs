using System.Collections;
using System.Transactions;
using System.Globalization;

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
            //int[] marks=new int[10];
            //marks[0]=80;
            //marks[1] = 90;
            //marks[2] = 70;
            //marks[3] = 60;
            //marks[4] = 80;
            //marks[5] = 90;
            //marks[6] = 80;
            //marks[7] = 70;
            //marks[8] = 60;
            //marks[9] = 80;
            ////foreach(datatype identifer in collection){ logic }
            //foreach(int mark in marks)
            //{
            //    Console.WriteLine("Marks "+mark);
            //}
            ////Array List//
            ////ClassName ObjectName =new ClassName();
            //// ArrayList Identifier=new ArrayList();
            ////Intialization:
            ////Identifier.Add=value;
            //ArrayList arrayList = new ArrayList();
            //arrayList.Add("Mass");
            //arrayList.Add(123);
            //arrayList.Add('A');
            //arrayList.Add(89.5);
            //for (int i = 0; i < arrayList.Count; i++)
            //{
            //    Console.WriteLine(arrayList[i]);
            //}
            //int[] numbers = { 10, 100, 20, 40, 50 };
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine("Numbers"+number);
            //}
            ////List
            //List<int> empId=new List<int>();
            //empId.Add(10);
            //empId.Add(100);
            //empId.Add(1000);
            //empId.Add(10000);
            //empId.Add(100000);
            //foreach(int id in empId)
            //{
            //    Console.WriteLine("empId"+id);
            //}
            ////HashTable
            //Hashtable hashtable = new Hashtable();
            //hashtable.Add("101", "Mass");
            //hashtable.Add("102", "Mass Systems");
            //hashtable.Add("103", "Mass sys");
            //foreach(var item in hashtable.Keys)
            //{
            //     Console.WriteLine(hashtable[item]);
            //}
            //SortedList sortedlist=new SortedList();
            //sortedlist.Add("1", "A");
            //sortedlist.Add("2", "B");
            //sortedlist.Add("3", "C");
            //sortedlist.Add("4", "D");
            //foreach (var value in sortedlist.Keys)
            //{
            //    Console.WriteLine(sortedlist[value]);
            //}
            //Dictionary<int,string> dictionary = new Dictionary<int,string>();
            //dictionary.Add(101, "hi");
            //dictionary.Add(102, "hii");
            //dictionary.Add(103, "hiii");
            //foreach( var item in dictionary.Keys)
            //{
            //    Console.WriteLine(dictionary[item]);
            //}
            ////stack
            //Stack stack = new Stack();
            //stack.Push("mass");
            //stack.Push("ravi");
            //stack.Push("super");
            //while (stack.Count > 0)
            //{
            //    Console.WriteLine(stack.Pop());
            //}
            ////Queue
            //Queue queue = new Queue();
            //queue.Enqueue("1");
            //queue.Enqueue("2");
            //queue.Enqueue("3");
            //queue.Enqueue("4");
            //queue.Enqueue("5");
            //while(queue.Count > 0)
            //{
            //    Console.WriteLine(queue.Dequeue());
            //}
            //Stack<string> stack2= new Stack<string>();
            //stack2.Push("mass");
            //stack2.Push("man");
            //stack2.Push("marvel");
            //while (stack2.Count > 0)
            //{
            //    Console.WriteLine(stack2.Pop());
            //}
            //Queue<int> queue2 = new Queue<int>();
            //queue2.Enqueue(1);
            //queue2.Enqueue(2);
            //queue2.Enqueue(3);
            //while (queue2.Count > 0)
            //{
            //    Console.WriteLine(queue2.Dequeue());
            //}
            //List<string> fruits=new List<string> { "apple","orange","banana"};
            //try
            //{
            //    string fruit;
            //    fruit = fruits[2];
            //    Console.WriteLine("fruits" + fruit);
            //}
            //catch (ArgumentOutOfRangeException exception)
            //{
            //    Console.WriteLine(exception.Message);
            //}

            //Console.Write("Enter Your Name:");
            //string name=Console.ReadLine();
            //Console.WriteLine("Your name is "+name);
            //Console.WriteLine("Enter your day");
            //string day =Console.ReadLine();
            //day = day.ToLower();
            //switch (day)
            //{
            //    case "monday":
            //        Console.WriteLine("Happy day");
            //        break;
            //    case "tuesday":
            //        Console.WriteLine("warm day");
            //        break;
            //    case "wednesday":
            //        Console.WriteLine("cool day");
            //        break;
            //    case "thursday":
            //        Console.WriteLine("wing day");
            //        break;
            //    case "friday":
            //        Console.WriteLine("cheer day");
            //        break;
            //    case "saturday":
            //        Console.WriteLine("half day");
            //        break;
            //    case "sunday":
            //        Console.WriteLine("jolly day");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid day");
            //        break;
            //}
            //if (day == "monday" || day == "friday"||day == "tuesday" || day == "wednesday"||day == "thursday")
            //{
            //    Console.WriteLine("working da");
            //}
            //else if (day == "saturday")
            //{
            //    Console.WriteLine("Half working day");
            //}
            //else if (day == "sunday")
            //{
            //    Console.WriteLine("Holiday");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid day");
            //}
            //Console.WriteLine("Enter what you want to print:");
            //string message=Console.ReadLine();
            //Console.WriteLine("How many times you want to print your name:");
            //int name = int.Parse(Console.ReadLine());
            //for(int i = 0; i <= name; i++)
            //{
            //    Console.WriteLine(message);
            //}
            //Console.WriteLine("Enter any numbers to print:");
            //int value=Convert.ToInt32(Console.ReadLine());
            //while (value > 0)
            //{
            //    value--;
            //    Console.WriteLine(value);
            //}
            //Console.WriteLine("Enter your password:");
            //string password = Console.ReadLine();
            //while (password != "admin123")
            //{
            //    Console.WriteLine("wrong passwords");
            //    Console.WriteLine("Enter your password:");
            //    password = Console.ReadLine();
            //}
            //Console.WriteLine("Login Successfully");
            //Console.WriteLine("Enter your password:");
            //string password = Console.ReadLine();

            //while (password != "admin123")
            //{
            //    Console.WriteLine("Wrong password");
            //    Console.WriteLine("Enter your password:");
            //    password = Console.ReadLine();   // ⭐ important
            //}

            //Console.WriteLine("Login Successfully");
            //int choice = 0;

            //while (choice != 3)
            //{
            //    Console.WriteLine("1. Say Hello");
            //    Console.WriteLine("2. Say Welcome");
            //    Console.WriteLine("3. Exit");
            //    Console.WriteLine("Enter Your Choice:");

            //    choice = int.Parse(Console.ReadLine());

            //    if (choice == 1)
            //    {
            //        Console.WriteLine("Hello");
            //    }
            //    else if (choice == 2)
            //    {
            //        Console.WriteLine("Welcome");
            //    }
            //    else if (choice == 3)
            //    {
            //        Console.WriteLine("Exit Message");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid message");
            //    }
            //}

            //Console.WriteLine("Successfully Implemented");

            //int age = -10;
            //string result = age > 0 ? "valid" : "Invalid";
            //Console.WriteLine(result);
            //Numeric Formatting//
            //double num = 1234.56789;
            //Console.WriteLine(num);
            //Console.WriteLine(num.ToString("F2"));
            //Console.OutputEncoding = System.Text.Encoding.UTF8;
            //CultureInfo.CurrentCulture = new CultureInfo("en-IN");
            //double amount = 1500;
            //Console.WriteLine(amount.ToString("C"));
            //Console.WriteLine(num.ToString("N"));
            //double percent = 0.75;
            //Console.WriteLine(percent.ToString("P"));
            //Console.WriteLine(num.ToString("0.000"));
            //Console.WriteLine("Enter a number:");
            //string input = Console.ReadLine();

            //int number;

            //if (int.TryParse(input, out number))
            //{
            //    Console.WriteLine("Valid number: " + number);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input");
            //}
            Console.WriteLine("Enter a Number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", num, i, num * i);
            }

        }
    }
}
