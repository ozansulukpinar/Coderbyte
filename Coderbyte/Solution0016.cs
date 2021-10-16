/*
 Have the function CountingMinutesI(str) take the str parameter
 being passed which will be two times (each properly formatted
 with a colon and am or pm) separated by a hyphen and return
 the total number of minutes between the two times. The time
 will be in a 12 hour clock format. For example: if str is
 9:00am-10:00am then the output should be 60. If str is 
 1:00pm-11:00am the output should be 1320.
*/
using System;

class MainClass {

  public static string CountingMinutesI(string str) {
    // code goes here  
    string[] times = str.Split('-');
    string fromTime = times[0];
    string toTime = times[1];

    int fromMinutes = FindTotalMinutes(fromTime);
    int toMinutes = FindTotalMinutes(toTime);

    if(toMinutes < fromMinutes){
      // add 24 hour
      toMinutes += 1440;
    }

    int totalDifference = toMinutes - fromMinutes;
    string result = totalDifference.ToString();

    return result;
  }

  private static int FindTotalMinutes(string time){
    string[] hourAndMinute = time.Split(':');
    int hour = Int32.Parse(hourAndMinute[0]);
    int minute = Int32.Parse(hourAndMinute[1].Substring(0, 2));
    string amOrPm = hourAndMinute[1].Substring(2, 2);

    int totalMinute = 0;

    if(amOrPm == "am"){
      totalMinute = hour * 60 + minute;
    }
    else{ //pm
      totalMinute = hour * 60 + minute + 720;
    }

    return totalMinute;
  }

  static void Main() {  
    // keep this function call here
    Console.WriteLine(CountingMinutesI(Console.ReadLine()));
  } 

}
