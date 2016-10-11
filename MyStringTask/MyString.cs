using System;

namespace MyStringTask
{
    public class MyString
    {
        private char[] myString;


        public int Length
        {
            get { return myString.Length; }
            private set { }
        }


        public MyString()
        {
            myString = new char[0];
        }


        public MyString(char[] chars)
        {
            myString = chars;
        }


        public static bool operator ==(MyString str1, MyString str2)
        {
            if (str1.Length != str2.Length)
                return false;
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1.myString[i] != str2.myString[i])
                    return false;
            }
            return true;
        }


        public static bool operator !=(MyString str1, MyString str2)
        {
            return !(str1 == str2);
        }


        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            MyString str = obj as MyString;
            if (str == null)
            {
                return false;
            }
            return this == str;
        }


        public override int GetHashCode()
        {
            return myString.GetHashCode() + myString.Length.GetHashCode();
        }


        public bool Equals(MyString str)
        {
            if ((object)str == null)
                return false;
            return this == str;
        }


        public static MyString operator +(MyString str1, MyString str2)
        {
            int length = str1.Length + str2.Length;
            char[] newMyString = new char[length];
            int index = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                newMyString[index] = str1.myString[i];
                index++;
            }
            for (int i = 0; i < str2.Length; i++)
            {
                newMyString[index] = str2.myString[i];
                index++;
            }
            return new MyString(newMyString);
        }


        public static MyString operator +(MyString str1, int intStr)
        {
            MyString str2 = intStr.ToString();
            return str1 + str2;
        }

        public static MyString operator +(int intStr, MyString str2)
        {
            MyString str1 = intStr.ToString();
            return str1 + str2;
        }


        public int FirstIndexOf(char ch)
        {
            for (int i = 0; i < Length; i++)
            {
                if (myString[i] == ch)
                    return i;
            }
            return -1;
        }


        public char this[int index]
        {
            get { return myString[index]; }
        }


        public static char[] ConvertToCharArray(MyString str)
        {
            return str.myString;
        }


        public static MyString ConvertFromCharArray(char[] chArray)
        {
            return new MyString(chArray);
        }


        public override string ToString()
        {
            return new string(myString);
        }


        public static implicit operator MyString(string str)
        {
            return new MyString(str.ToCharArray());
        }


        public static implicit operator MyString(int intStr)
        {
            return new MyString(intStr.ToString().ToCharArray());
        }


        public static explicit operator int (MyString myString)
        {
            int result;
            if (!int.TryParse(myString.ToString(), out result))
                throw new InvalidCastException();
            return result;
        }
    }
}
