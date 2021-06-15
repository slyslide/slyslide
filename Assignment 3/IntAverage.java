//=======================================================
//  IntAverage.java
//
//  Adam Curtis  T00679575
//  COMP 1231    Assignment 3 Question 1
//
//  Takes a series of input integer values, and returns 
//  the running average
//=======================================================

import java.util.Scanner;

public class IntAverage
{
  public static void main (String[] args)
  {
    String numberstring;
    int numberint, runningavg, i;
    numberint = runningavg = i = 0;
    Scanner scan = new Scanner (System.in);
    //Informs user how program runs, and the min/max range of a valid integer
    System.out.println("This program will take your input integer (-2,147,483,648 < int < " 
    + "2,147,483,647), and provide a running average.");
    System.out.print ("Input a valid integer (input 'stop' to quit at anytime): ");
    numberstring = scan.nextLine();

    //Program will continue as long as values other than 'stop' are input, thanks to the catch 
    //and while loop
    while (!numberstring.equals ("stop"))
    {
      try
      {
        numberint = Integer.parseInt(numberstring); //casts input string to int. If invalid, 
        runningavg += numberint;                    //throws exception
        i++; //simply a counter of how many loop iterations, used to calculate average
        System.out.println("The current running average of user inputs: " + (float)runningavg/i);
      }

    //Catch block only has one catch clause, for any input that isn't an integer, or 'stop'  
      catch (NumberFormatException exception)
      {
          System.out.println ("Input integer is too large, or not an integer: " + numberstring);
      }

    System.out.print ("Enter another integer (stop to quit): ");
    numberstring = scan.nextLine();

      
    }

    scan.close();
    System.out.println("Code 'stop' entered, program terminating.");
  }
  
}