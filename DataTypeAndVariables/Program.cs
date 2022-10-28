using System;

namespace DataTypeAndVariables
{
    public class Program
    {
      public static void Main(string[] args)
      {
          Console.WriteLine("Hello World!");

          byte myByte = 235;
          sbyte mySbyte = -113;
          int myInt = 3450;
          uint myUint = 3803320;
          short myShort = -3892;
          ushort myUShort = 5;
          float myFloat = 5.4f;
          double myDouble = 96.45;
          char myCharacter = 'a';
          bool myBool = true;
          string myText = "Hello World";
          string numText = Convert.ToString(25);
      }

      public static int Text2Num(string numText)
      {
        throw new NotImplementedException();
      }
    }
}
