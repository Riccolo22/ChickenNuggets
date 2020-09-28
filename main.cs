using System;
using static System.Console;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    CN(); //initiates the method
  }

  public static void CN (){
    var pos = true;
    Write ("Enter the Number of Nuggets: "); 
    int CNN = Convert.ToInt32(ReadLine()); //takes in the input string and converts it to a integer
    if (CNN < 8){
      WriteLine ("No Possible Combinations");
      CNN = 0;
      pos = false;
    }
    int count20 = 0;
    int count9 = 0;
    int count6 = 0;
    int count4 = 0;
    while (CNN > 0){ // creates a loop which runs until the number of remaining nuggets goes down to 0
        if (CNN >= 29 || CNN == 20){
          CNN -= 20;
          count20 += 1;
        }
        else if (CNN >= 13  && CNN != 14 && CNN != 16|| CNN == 9  ){
          CNN -= 9;
          count9 += 1;
        }
        else if (CNN >= 10 || CNN == 6){
          CNN -= 6;
          count6 += 1;
        }
        else if (CNN >= 8 || CNN == 4){
          CNN -= 4;
          count4 += 1;
        }
        else if (CNN < 8){
          WriteLine ("No Possible Combinations");
          CNN = 0;
          pos = false;
        }
    }
    if (pos == true){
    WriteLine (@"You need:
   {0} boxes of 20
   {1} boxes of 9
   {2} boxes of 6
   {3} boxes of 4", count20 , count9, count6, count4);
    }
  }
}
