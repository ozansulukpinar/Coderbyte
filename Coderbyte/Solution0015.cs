/*
Have the function CamelCase(str) take the str parameter 
being passed and return it in proper camel case format where
 the first letter of each word is capitalized (excluding the
  first letter). The string will only contain letters and 
  some combination of delimiter punctuation characters 
  separating each word. For example: if str is 
  "BOB loves-coding" then your program should return the 
  string bobLovesCoding.
*/
using System;
using System.Text;
using System.Collections.Generic;

class MainClass {

  public static string CamelCase(string str) {
    // code goes here  
    byte[] ASCIIBytes = Encoding.ASCII.GetBytes(str);
    int length = ASCIIBytes.Length;

    List<byte> newASCIIBytesList = new List<byte>();

    //65-90 A-Z
    //97-122 a-z
    for(int i = 0; i < length; i++){
      bool isItUpperCase = (65 <= ASCIIBytes[i] && ASCIIBytes[i] <= 90);
      bool isItLowerCase = (97 <= ASCIIBytes[i] && ASCIIBytes[i] <= 122);

      if(i == 0){
        if(isItUpperCase){
          newASCIIBytesList.Add((byte)(ASCIIBytes[i] + 32));
        }

        if(isItLowerCase){
          newASCIIBytesList.Add((byte)ASCIIBytes[i]);
        }
      }
      else{ // i > 0
      //< 65
      //90 < < 97
      //122 <
          bool isItNotLetter = (ASCIIBytes[i - 1] < 65) || (90 < ASCIIBytes[i - 1] && ASCIIBytes[i - 1] < 97) || (122 < ASCIIBytes[i - 1]);

          if(isItNotLetter){
                  if(isItUpperCase){
                    newASCIIBytesList.Add((byte)ASCIIBytes[i]);
                  }

                  if(isItLowerCase){
                    newASCIIBytesList.Add((byte)(ASCIIBytes[i] - 32));
                  }
          }
          else{
                  if(isItUpperCase){
                    newASCIIBytesList.Add((byte)(ASCIIBytes[i] + 32));
                  }

                  if(isItLowerCase){
                    newASCIIBytesList.Add((byte)ASCIIBytes[i]);
                  }
          }
      }
    }

    byte[] newASCIIBytes = newASCIIBytesList.ToArray();

    string newStr = Encoding.ASCII.GetString(newASCIIBytes);

    return newStr;
  }

  static void Main() {  
    // keep this function call here
    Console.WriteLine(CamelCase(Console.ReadLine()));
  } 

}
