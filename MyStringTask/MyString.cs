namespace MyStringTask
{
    public class MyString
    {
        private char[] myString;
        private int length;


        public int Length
        {
            get
            {
                return length;
            }
            private set { }
        }


        public MyString()
        {
            myString = new char[0];
            length = 0;
        }


        public MyString(char[] chars)
        {
            myString = chars;
            length = myString.Length;
        }


        public static bool operator ==(MyString str1, MyString str2)
        {
            if (str1.length != str2.length)
                return false;
            for (int i = 0; i < str1.length; i++)
            {
                if (str1.myString[i] != str2.myString[i])
                    return false;
            }
            return true;
        }


        public static bool operator !=(MyString str1, MyString str2)
        {
            if (str1.length != str2.length)
                return true;
            for (int i = 0; i < str1.length; i++)
            {
                if (str1.myString[i] != str2.myString[i])
                    return true;
            }
            return false;
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
            return myString.GetHashCode() + length.GetHashCode();
        }


        public bool Equals(MyString str)
        {
            if ((object)str == null)
                return false;
            return this == str;
        }


        public static MyString operator +(MyString str1, MyString str2)
        {
            int length = str1.length + str2.length;
            char[] newMyString = new char[length];
            int index = 0;
            for (int i = 0; i < str1.length; i++)
            {
                newMyString[index] = str1.myString[i];
                index++;
            }
            for (int i = 0; i < str2.length; i++)
            {
                newMyString[index] = str2.myString[i];
                index++;
            }
            return new MyString(newMyString);
        }


        public int IndexOf(char ch)
        {
            for (int i = 0; i < length; i++)
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
    }
}
