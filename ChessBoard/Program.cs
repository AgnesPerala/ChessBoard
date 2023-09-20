using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ChessBoard;

class program
{
    static void Main(string[] argas)
    {
        // code for the special symbols to show in terminal 
        Console.OutputEncoding = Encoding.Unicode;
      
        // let the user write in a number 
        Console.WriteLine("Skriv in en siffra!");
        int dimension = Int32.Parse(Console.ReadLine());

        // declaring two dimentional arrey representing a chessboard
        string[,] ChessBoard = new string[dimension, dimension];

        // letting user decide how the chessbord looks like 
        Console.WriteLine("välj en symbol eller bokstav för svarta rutorna");
        string blackAnswer = Console.ReadLine();

        Console.WriteLine("välj en symbol eller bokstav för vita rutorna");
        string whiteAnswer = Console.ReadLine();


        // declaring variables for the blocks in chessboard 
        string black = blackAnswer;
        string white = whiteAnswer;
        // declaring the chessbords rows and columns
        int row;
        int column;

        // nested loop for the chessborads size to compare white users answer 
        for (row = 0; row < dimension; row++)
        {
            for (column = 0; column < dimension; column++)
            {
                // alternate colur of chessboard using modulus 
                if (row % 2 == 0 && column % 2 == 0)
                {
                    ChessBoard[row, column] = black; 
                }
                else if (row % 2 == 1 && column % 2 == 1)
                {
                    ChessBoard[row, column] = black; 
                }
                else
                {
                    ChessBoard[row, column] = white;
                }
               
            }
        }
        // letting user place a piece on the chessboard 
        Console.WriteLine("hur ska pjäsen se ut");
        string piece = Console.ReadLine();

        Console.WriteLine("vilken rad ska pjäsen stå på välj mellan 0 och " + dimension);
        int rowAnswer = Int32.Parse(Console.ReadLine());

        Console.WriteLine("vilken kolumn ska pjäsen stå på");
        int columnAnswer = Int32.Parse(Console.ReadLine());
        // print out the pice 
        ChessBoard[rowAnswer, columnAnswer] = piece;
        Console.WriteLine(piece);

        // print out chessboard
        for (row = 0; row < dimension; row++)
        {
            for (column = 0; column < dimension; column++)
            {

                Console.Write(ChessBoard[row, column]);

            }
            Console.WriteLine("");
        }

    }

   

    //skrivv in siffra

    //deklarera cjackbrädet



    //skapar chakbrädet 

    //skriv ut chackbrädet 
}




