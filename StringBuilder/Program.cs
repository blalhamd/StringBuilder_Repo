using System;
using System.Reflection;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {

        
        StringBuilder sb = new StringBuilder();
        
        Console.WriteLine(sb.ToString()); // null
        Console.WriteLine(sb.Length);     //0
        Console.WriteLine(sb.Capacity);   // 16(default)
        Console.WriteLine(sb.MaxCapacity); 

        sb.Append("Computer");

        Console.WriteLine(sb.ToString()); // computer
        Console.WriteLine(sb.Length);     //8
        Console.WriteLine(sb.Capacity);   // 16(default)
        Console.WriteLine(sb.MaxCapacity); 

        sb.Append(" science ");

        Console.WriteLine(sb.ToString()); // computer science
        Console.WriteLine(sb.Length);     // 17
        Console.WriteLine(sb.Capacity);   // 32(default)
        Console.WriteLine(sb.MaxCapacity); 



        StringBuilder stringBuilder = new StringBuilder(); // free constrcutor
        StringBuilder stringBuilder1= new StringBuilder("Information technology"); // string value
        StringBuilder stringBuilder2=new StringBuilder("Bilal",20); // string value,capacity
        StringBuilder stringBuilder3 = new StringBuilder(0, 44); // capacity,MaxCapacity
        StringBuilder stringBuilder4 = new StringBuilder("hello the world",6, 9, 17);

        stringBuilder.Append("amira");
        stringBuilder.Append(" abd el aziez",5,13);
        
        
        // there alot of methods belong stringBuilder ,you can go to definiion and discover it.






        Console.ReadKey();
    }
}

/*
 StringBuilder is a class in C# that is used when you want to modify a string without creating a new object.
 It can boost performance when concatenating many strings together in a loop1.

 StringBuilder performs faster than string when appending multiple string values.
 It is recommended to use StringBuilder when you need to append more than three or four strings2.

 You can use the Append() method to add or append strings to the StringBuilder object.
 Use the ToString() method to retrieve a string from the StringBuilder object

 -----------------------------------string VS stringBuilder---------------------------------
 -----------------------------------                       ---------------------------------
 The main difference between string and StringBuilder is that string is immutable,
 meaning that once it is created, it cannot be modified.
 Any operation that appears to modify a string actually creates a new string object1.

 On the other hand, StringBuilder is mutable, meaning that it can be modified without creating a new object2.

 In general, if you are concatenating a small number of strings together, using string is fine.
 However, if you are concatenating many strings together or doing so in a loop,
 using StringBuilder can be much more efficient.

 string and stringBuilder both reference type and array of characters.

 How string and stringBuilder store in memory?
 string and stringBuilde store in memory as array of characters.

 Note..when you create stringBuilder object ...capacity default is 16...if you add 16 or 17 letter to stringBuilder object
 by append method,capacity default will increase to doubles, what happen under the hood to stringBuilder object?
 in starting I was have array of characters contains 16 letter and when I used append, in this moment(تم انشاء) new array has 16 letter another
 and this new array will also refers to stringBuilder object like old array..so don't think when you use append will add on old array..No
 will (يتم انشاء) a new array refers on the same stringBuilder object.
 
 */