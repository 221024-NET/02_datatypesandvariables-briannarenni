using System;

namespace DataTypeAndVariables
{
    public class Program {
      public static void Main(string[] args) {
          byte myByte = 235;
          Console.WriteLine(myByte);
          Console.WriteLine("\n");

          sbyte mySbyte = -113;
          Console.WriteLine(mySbyte);
          Console.WriteLine("\n");

          int myInt = 3450;
          Console.WriteLine(myInt);
          Console.WriteLine("\n");

          uint myUint = 3803320;
          Console.WriteLine(myUint);
          Console.WriteLine("\n");

          short myShort = -3892;
          Console.WriteLine(myShort);
          Console.WriteLine("\n");

          ushort myUShort = 5;
          Console.WriteLine(myUShort);
          Console.WriteLine("\n");

          float myFloat = 5.4f;
          Console.WriteLine(myFloat);
          Console.WriteLine("\n");

          double myDouble = 96.45;
          Console.WriteLine(myDouble);
          Console.WriteLine("\n");

          char myCharacter = 'a';
          Console.WriteLine(myCharacter);
          Console.WriteLine("\n");

          bool myBool = true;
          Console.WriteLine(myBool);
          Console.WriteLine("\n");

          string myText = "Hello World";
          Console.WriteLine(myText);
          Console.WriteLine("\n");

          string text = "I control text.";
          string numText = "25";
          Console.WriteLine(text);
          Console.WriteLine("\n");
          Console.WriteLine(Text2Num(numText));

      }
       public static int Text2Num(string numText) {
        int result;
        bool success = int.TryParse(numText, out result);
        return result;
        throw new NotImplementedException();
      }
    }
}
