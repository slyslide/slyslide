#include <stdio.h>
#include <stdlib.h>

#define MIN_MOVE 0       /* These two constants define the bondaries of an   */
#define MAX_MOVE 2       /* acceptable move within the board dimensions      */

void opening();
int gamestatus();
void drawboard();
void move();
void computermove();
void whowon();

char name[20];
char board[3][3];
int xmove, ymove;

main()
{

  int i, j;                     /* This loop simply populates the game board */
                                /* (the board[][] array) with 'space'        */
  for (i = 0; i < 3; i++) {     /* characters. This way, when these spaces   */
    for (j = 0; j < 3; j++)     /* are replaced with X's and O's, the board  */
        board[i][j] = ' ';      /* doesn't lose its shape */
  }


  opening();

  while (gamestatus() == 0) /*Game will continue as long as there are still  */
        {                   /*available moves to be made                     */
         move();
         drawboard();
         if (gamestatus() == 0)   /* Confirms that the game is still in play */
                {
                 computermove();
                 drawboard();
                }
        }

  if (gamestatus() == 1) /* When a game winning condition is met, this will  */
        {                    /* determine who has won, and close the program */
        whowon();
        printf("Thanks for playing!");
        }
  if (gamestatus() == -1)        /* If the board is full, and nobody has won */
        {
        printf("Sorry %s, the board is full, and nobody connected 3.\n", name);
        printf("Thanks for playing!\n");
        }
}

/*=============================================================================
*       This function simply provides the opening text, which declutters the
*       main function
*============================================================================*/

void opening()
{
printf("\n");
printf("***************************************\n");
printf("\n");
printf("    Tictactoe.c\n");
printf("    COMP 2131\n");
printf("    Adam Curtis\n");
printf("\n");
printf("You will be playing against a computer,\n");
printf("good luck!\n");
printf("***************************************\n");
printf("\n");
printf("What is your first  name?\n");
scanf("%s", name);
printf("Hello %s, lets begin!\n", name);
printf("%s = X and Computer = O\n", name);
drawboard();
}

/*=============================================================================
*       This function checks to see if any of the game ending conditions are
*       met: first, by comparing three positions in a row (to see if they are
*       all the same, and none are null), then it checks if the board is full.
*       If not, it allows the game to continue
*============================================================================*/

int gamestatus()
{
  if (((board[0][0] == board[0][1]) && (board[0][1] == board[0][2])) &&
        board[0][0] != ' ')
        return 1;
  else if (((board[1][0] == board[1][1]) && (board[1][1] == board[1][2])) &&
        board [1][0] != ' ')
        return 1;
  else if (((board[2][0] == board[2][1]) && (board[2][1] == board[2][2])) &&
        board [2][0] != ' ')
        return 1;
  else if (((board[0][0] == board[1][0]) && (board[1][0] == board[2][0])) &&
        board[0][0] != ' ')
        return 1;
  else if (((board[0][1] == board[1][1]) && (board[1][1] == board[2][1])) &&
        board[0][1] != ' ')
        return 1;
  else if (((board[0][2] == board[1][2]) && (board[1][2] == board[2][2])) &&
        board[0][2] != ' ')
        return 1;
  else if (((board[0][0] == board[1][1]) && (board[1][1] == board[2][2])) &&
        board[0][0] != ' ')
        return 1;
  else if (((board[2][0] == board[1][1]) && (board[1][1] == board[0][2]))  &&
        board[2][0] != ' ')
        return 1;
  else
        {
         if (board[0][0] != ' ' && board[1][0] != ' ' &&
         board[2][0] != ' ' && board[0][1] != ' ' && board[1][1] != ' ' &&
         board[2][1] != ' ' && board[0][2] != ' ' && board[1][2] != ' ' &&
         board[2][2] != ' ')
                return -1;
         else
                return 0;
        }
}

/*=============================================================================
*       Creates a visual representation of the gameboard
*=============================================================================*/

void drawboard()
{
  printf("\n");
  printf("Current board:\n");
  printf("\n");
  printf("     |     |     \n");
  printf("  %c  |  %c  |  %c  \n", board[0][0], board[1][0], board[2][0]);
  printf("_____|_____|_____\n");
  printf("     |     |     \n");
  printf("  %c  |  %c  |   %c  \n", board[0][1], board[1][1], board[2][1]);
  printf("_____|_____|_____\n");
  printf("     |     |     \n");
  printf("  %c  |  %c  |   %c  \n", board[0][2], board[1][2], board[2][2]);
  printf("     |     |     \n");

}

/*=============================================================================
*       The function responsible for most player interaction. It takes a user
*       input integer, and: first ensures the value is within acceptable
*       limits, then second makes sure it is not on a space that is already
*       taken. The user is prompted to correct these faults, until both
*       conditions are met, then the move can be enacted
*============================================================================*/

void move()
{
  printf("Input the x and y coordinates of your move:\n");
  printf("X-axis:\t");
  scanf("%d",&xmove);

  while (xmove < MIN_MOVE || xmove > MAX_MOVE) {
        printf("Invalid input, must be between 0-2, re-enter:\n");
        scanf("%d", &xmove);      }

  printf("Y-axis:\t");
  scanf("%d", &ymove);

  while (ymove < MIN_MOVE || ymove > MAX_MOVE)
        {
        printf("Invalid input, must be between 0-2, re-enter:\n");
        scanf("%d", &ymove);
        }

  while (board[xmove][ymove] != ' ')
    {
    printf("This space is already taken, try again.\n");
    printf("X-axis:\t");
    scanf("%d",&xmove);
    while (xmove < MIN_MOVE || xmove > MAX_MOVE)
        {
        printf("Invalid input, must be between 0-2, re-enter:\n");
        scanf("%d", &xmove);
        scanf("%d", &xmove);
        }
    printf("Y-axis:\t");
    scanf("%d", &ymove);
    while (ymove < MIN_MOVE || ymove > MAX_MOVE)
        {
        printf("Invalid input, must be between 0-2, re-enter:\n");
        scanf("%d", &ymove);
        }
    }

  board[xmove][ymove] = 'X';
}

/*=============================================================================
*       This uses the random function from the C library to randomly generate
*       the computer's next move. It will keep attempting to enact a move,
*       until it finds one that is legal (not a space that is already taken)
*============================================================================*/
void computermove()
{
 int cxmove, cymove;
 cxmove = (rand() % (MAX_MOVE + 1));      /* Sets range of moves from 0-2 */
 cymove = (rand() % (MAX_MOVE + 1));

 while (board[cxmove][cymove] != ' ')    /* Confirms that the chosen move is */
        { cxmove = (rand() % (2 + 1));   /* legal. If not, it redraws, until */
          cymove = (rand() % (2 + 1));}  /* it is                            */

 board[cxmove][cymove] = 'O';
}

/*=============================================================================
*       When a winning condition is met, this function is called to determine
*       the winner. Since this will only be called if a winning condition is
*       met, the logic we can apply is very simple. Since the player always
*       goes first, if there is a winning board and the player has more of
*       their markers, they must have won. Otherwise, the computer won
*============================================================================*/

void whowon()
{
 int xcount = 0;
 int ocount = 0;
 int m, n;

 for (m = 0; m <= MAX_MOVE; m++)
    {
    for (n = 0; n <= MAX_MOVE; n++)
        {
        if (board[m][n] == 'X')
            xcount++;
        if (board[m][n] == 'O')
            ocount++;
        }
    }

 if (xcount > ocount)
        printf("Congratulations %s, you win!\n", name);
 else
        printf("Sorry %s, you lose. Better luck next time.\n", name);
}