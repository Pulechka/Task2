using System;

namespace MyStringTask
{
    class Program
    {
        static void Main(string[] args)
        {
            MyString str1 = new MyString(new char[] {'H','e','l','l','o' });
            Console.WriteLine("str1 = " + str1);
            MyString str2 = new MyString(new char[] { 'H', 'e', 'l', 'l', 'o' });
            Console.WriteLine("str2 = " + str2);
            MyString str3 = new MyString(new char[] { 'h', 'e', 'l', 'l', 'o' });
            Console.WriteLine("str3 = " + str3);
            MyString str4 = new MyString(new char[] {',',' ','w','o','r','l','d' });
            Console.WriteLine("str4 = " + str4);
            Console.WriteLine();

            Console.WriteLine("str1==str2 is " + (str1 == str2));
            Console.WriteLine("str1!=str2 is " + (str1 != str2));
            Console.WriteLine("str1.Equals(str2) is " + str1.Equals(str2));
            Console.WriteLine();

            Console.WriteLine("str2==str3 is " + (str2 == str3));
            Console.WriteLine("str2!=str3 is " + (str2 != str3));
            Console.WriteLine("str2.Equals(str3) is " + str2.Equals(str3));
            Console.WriteLine();

            Console.WriteLine("str1+str4 = " + str1 + str4);
            Console.WriteLine();

            Console.WriteLine("Index of 'l' in str1 is " + str1.IndexOf('l'));
            Console.WriteLine();

            MyString str5 = str1 + str2;
            char[] chArray = MyString.ConvertToCharArray(str5);

            str5 = MyString.ConvertFromCharArray(chArray);
            Console.WriteLine(str5);
        }
    }
}
