//===============================================================
//  Books.java
//
//  Adam Curtis  T00679575
//  COMP 1231    Assignment 3 Question 2
//
//  Takes an input list of books from a text file, and
//  confirms whether or not there are duplicate copies
//  of the same title. If so, the duplicates will be 
//  saved to a separate output file named 'duplicateTitles.out'
//===============================================================

import java.io.*;
import java.util.ArrayList;

public class Books 

{

 public static void main (String[] args) throws IOException
 {

    String booktitle = null;                                    //Creates string for reading
    ArrayList<String> books = new ArrayList<String>();          //titles, and two lists for 
    ArrayList<String> duplicatebooks = new ArrayList<String>(); //storing titles 

    BufferedReader br = null;   //Instantiated, but not assigned to file, so it can still be
    BufferedWriter bw = null;   //closed in finally block, but if the file cannot be found,
                                //program won't terminate unexpectedly
    
    //-------------------------------------------------------------------------------------------                            
    //In order for program to run correctly, user must manually change the save destination of the
    //output file themself, depending on their OS and user permissions
    //-------------------------------------------------------------------------------------------

    try  
    {                                                                           //change directory
        File file = new File("C:/Users/Adam/Desktop/duplicateTitles.out.txt");  //<--HERE

        FileWriter fw = new FileWriter(file);                                   
        bw = new BufferedWriter(fw);        
        br = new BufferedReader(new FileReader("bookTitles.inp.txt"));  //Attempts to read input
                                                            //file. If no file exists, throws 
        while ((booktitle = br.readLine()) != null)         //message associated with IOException
        {
            books.add(booktitle);   //Populates list with all books titles
        }
        
        for (int i = 0; i < books.size(); i++)
        {
            int duplicatecounter = 0;
            booktitle = books.get(i);
            
            for (int j = 0; j < books.size(); j++)
            {
                if (booktitle.compareTo(books.get(j)) == 0)
                {
                    duplicatecounter++;     //Counts how many copies of each book exist. If
                }                           //the counter goes over 1 (if there is more than one
                                            //copy of a book), that title is added to a second list,
            }                               //populated with all duplicate books
        
            if (duplicatecounter > 1)
            {
                duplicatebooks.add(booktitle);
            }
            
        }
    
        for (int i = 0; i < duplicatebooks.size(); i++)
        {
            booktitle = duplicatebooks.get(i);
            int duplicatecounter = 0;

            for (int j = 0; j < duplicatebooks.size(); j++)
            {
                if (booktitle.compareTo(duplicatebooks.get(j)) == 0)
                {
                    duplicatecounter++; //Same logic as first loop used to count duplicate books, 
                }                       //however now if more than one duplicate of a book title is
                                        //found, all other copies are removed, leaving only one
                if (duplicatecounter > 1)
                {
                    duplicatebooks.remove(j);
                }
            }
        }

        for (int i = 0; i < duplicatebooks.size(); i++)
        {
            booktitle = duplicatebooks.get(i);  //Writes each book title from the duplicate book
            bw.write(booktitle + '\n');         //array list to the output file. Also adds '\n', so
            i++;                                //each entry is separated by a newline
        }
        System.out.println("Input book list successfully sorted to output duplicate list.");
        System.out.println("Output file saved to: " + file.toString());
    }

    //If either the input, or output file has any issues, this exception will be thrown, and it will
    //explicitly state the exact problem (will specify the file, and the precise issue)
    catch (FileNotFoundException exception) 
    {
        System.out.println(exception);
        System.out.println("Please confirm you have access to the specified file, and that " + 
        "its name and location are spelled correctly.");
    }
    
    //Closes BufferedReader and BufferedWriter objects in finally clause, so
    //even if the list cannot be accesed, these aren't left open
    finally
    {
        if (br != null)
        {
        br.close(); 
        }           

        if (br != null)
        {
        bw.close();     
        }
    }

 }   
}
