using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatbot
{
    class Program
    {
       //some basic information get from user
        static string name = "You";
        static string? age;

        //output format for chatbot
        static void output(string output)
        {
            //set the color of the output
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Chatbot: " + output);
        }

        //input format for user
        static String input()
        {
            //set the color of the input
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(name + ": ");
            String tmp = Console.ReadLine().Trim().ToLower();
            if(tmp == "quit")   Environment.Exit(0);
            return tmp;
        }

        //narrator format
        static void narrator(string output)
        {
            //set the color of the narrator
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Narrator: " + output);
        }

        //get digits from a string
        static string getDigits(string str)
        {
            StringBuilder digits = new StringBuilder();
            foreach (char c in str)
            {
                if (char.IsDigit(c))    digits.Append(c);
            }   
            return digits.ToString();
        }

        //introduction
        static void introTalk()
        {
            output("Greetings~~~");
            output("I am Chatbot. May I have your name please?");
            name = input();
            output("Nice to meet you " + name + ". That`s a really a nice name~~~");
            output(name + ", how old are you?");

            age = input();
            age = getDigits(age);
            int ageInt = Convert.ToInt32(age);

            //give different feedback according to the age
            if(ageInt > 25)
            {
                String[] feedback25 = 
                { 
                    "Hey, I heard you've crossed the threshold of 25.\n" +
                    "\t So, now you've officially entered the realm of \n" + 
                    "\t 'maturity and charm.' Congratulations!", 
                    "I really admire you because you've survived that \n" + 
                    "\t dreaded 25th birthday. How did you manage it? Did \n" + 
                    "\t you invent the anti-aging elixir?", 
                    "Age is just a number, but you seem to be making \n" + 
                    "\t that number quite fashionable. Every time I see \n " +
                    "\t you, you look more charming and wise than before. \n" +
                    "\t Maybe I should seek your advice on how to stay forever young?" 
                };
                Random random = new Random();
                output(feedback25[random.Next(0, feedback25.Length)]);
            }
            else if(ageInt > 18)
            {
                String[] feedback18 = 
                { 
                    "I heard you've surpassed the legal age of 18 and \n" +
                    "\t now you're a 'legally adventurous' individual. \n" +
                    "\t So, try some daring activities in life!", 
                    "Now that you're in the world of adulthood, you \n " +
                    "\t still possess the energy and carefree attitude \n " + 
                    "\t of a young person. That's amazing! Don't forget \n" + 
                    "\t to share some secrets so us slightly older folks \n" + 
                    "\t can keep up with the pace."
                }; 
                Random random = new Random();
                output(feedback18[random.Next(0, feedback18.Length)]);
            }
            else if(ageInt > 12)
            {
                String[] feedback12 = 
                { 
                    "I heard you've joined the ranks of teenagers, gaining\n" + 
                    "\t more freedom and responsibility. But I bet you \n" +
                    "\t still secretly wish to enjoy the delicious dinners\n" +
                    "\t your parents make for you, right?", 
                    "Now that you've become a young adult, you have more \n" + 
                    "\t autonomy and decision-making power. But don't forget\n" +
                    "\t to give yourself some time to be a kid as well, to \n" +
                    "\t enjoy playfulness and carefree moments.", 
                    "You've reached that mysterious age where you're neither \n" +
                    "\t a child nor an adult. It's like an exploration journey, \n" + 
                    "\t sometimes getting lost, sometimes discovering yourself. \n" +
                    "\t But no matter what, remember to enjoy this special time!" 
                };
                Random random = new Random();
                output(feedback12[random.Next(0, feedback12.Length)]);
            }
            else
            {
                String[] feedback = 
                { 
                    "Hey, young man/young lady, being around you makes me feel\n" +
                    "\t like a kid again. Don't forget to enjoy every day of joy\n" + 
                    "\t and carefree moments because sometimes, when you grow up,\n" +
                    "\t you'll miss this stage!", 
                    "You're a little genius! I heard you're a math whiz at school.\n" +
                    "\t Next time I encounter a difficult problem, I'll come to \n" + 
                    "\t you for help. "
                };
                Random random = new Random();
                output(feedback[random.Next(0, feedback.Length)]);
            }
        }
        
        //user instruction
        static void userInstruction(){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("------------------------- Instruction -------------------------\n" +
                              "\t1. Enter 'quit' to quit the chat.\n" +
                              "\t2. Try to use some keywords for better communication.\n" +
                              "---------------------------------------------------------------\n");
        }

        //Tic-Tac-Toe game
        static char[] board;
        static char player;
        static bool gameOver;
        static Random rnd = new Random();
        static bool isFirst = true;
        static void PrintBoard()
        {
            if(isFirst){
                output("Have you ever heard of Tic-Tac-Toe!");
                String tmp = input().Contains("ye") ? "Great! Let`s play this game now~~~\n\t Watch out baby~~ I am an expert in this field!" : "Don`t worry, you will learn it soon~~~";
                output(tmp);
                Thread.Sleep(120);
                isFirst = false;
                output("Well then, let`s start with the game~~~");
                Thread.Sleep(100);
                narrator("The Game is now beginning...");
                Thread.Sleep(200);
            }else if(gameOver){
                narrator("The Game is over now...");
                Thread.Sleep(200);
            }
            else{
                String[] fb = 
                    { 
                        "It seems like this game has become an unsolvable \n" + 
                        "\t enigma. Maybe it's time to summon a mysterious\n" +
                        "\t master of the board to unravel it!" , 
                        "The situation is getting increasingly complex. \n" + 
                        "\t Are we playing a game of Tic-Tac-Toe or a puzzle \n" +
                        "\t from the Three Kingdoms? I'm starting to wonder!" , 
                        "The current state of this game resembles a face-off\n" +
                        "\t between two goalkeepers. They're not giving each \n" + 
                        "\t other any chance. Looks like we need a sharpshooter \n" +
                        "\t to break this deadlock!" 
                    };
                    Random random = new Random();
                    narrator(fb[random.Next(0, fb.Length)]);
            }

            narrator("-------------");
            narrator($" {board[0]} | {board[1]} | {board[2]} ");
            narrator("-------------");
            narrator($" {board[3]} | {board[4]} | {board[5]} ");
            narrator("-------------");
            narrator($" {board[6]} | {board[7]} | {board[8]} ");
            narrator("-------------");
        }

        static void Play()
        {
            narrator(name + ", enter your choice (1-9) here: ");
            string p = getDigits(input());
            int move;

            if (int.TryParse(p, out move) && move >= 1 && move <= 9 && board[move - 1] != 'X' && board[move - 1] != 'o')
            {
                board[move - 1] = player;
            }
            else
            {
                narrator("Ops! Invalid move. OMG!\n\t You should try again," + name +"!!");
                Play();
            }

            do
            {
                move = rnd.Next(1, 10);
            } while (board[move - 1] == 'X' || board[move - 1] == 'o');

            String[] fb = 
                { 
                    "Gosh....I'm so confused.", 
                    "Oh wait...What's going on?", 
                    "Playing this game with you is such a nightmare.",
                    "Are you an expert in this game?"
                };
                Random random = new Random();
                output(fb[random.Next(0, fb.Length)]);
            
            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(80);
                output(".");
            }
            
            String[] fb2 = 
                { 
                    "Hehe, I'm a genius!", 
                    "You gonna lose! Sweety~~~", 
                    "I'm the best Tic-Tac-Toe player in the world!",
                    "Train more before come back to me!"
                };
                Random random2 = new Random();
                output(fb2[random2.Next(0, fb2.Length)]);

            board[move - 1] = 'o';
        }

        static void CheckGameOver()
        {
            char[] temps = { 'X', 'o' };
            foreach(char temp in temps){
                {
                    if ((board[0] == board[1] && board[1] == board[2] && board[0] == temp)||
                        (board[3] == board[4] && board[4] == board[5] && board[3] == temp)||
                        (board[6] == board[7] && board[7] == board[8] && board[6] == temp)||
                        (board[0] == board[3] && board[3] == board[6] && board[0] == temp)||
                        (board[1] == board[4] && board[4] == board[7] && board[1] == temp)||
                        (board[2] == board[5] && board[5] == board[8] && board[2] == temp)||
                        (board[0] == board[4] && board[4] == board[8] && board[0] == temp)||
                        (board[2] == board[4] && board[4] == board[6] && board[2] == temp))
                    {
                        gameOver = true;
                        if(temp == 'X') narrator(name + " wins!");
                    }else if (board[0] != '1' && board[1] != '2' && board[2] != '3' &&
                                board[3] != '4' && board[4] != '5' && board[5] != '6' &&
                                board[6] != '7' && board[7] != '8' && board[8] != '9')
                            {
                                gameOver = true;
                                narrator("It's a tie! No one wins!");
                            }
                }
            }
        }

        static void ttt(){
            board = new char[9] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            player = 'X';
            gameOver = false;

            while (!gameOver)
            {
                Thread.Sleep(100);
                PrintBoard();
                Play();
                CheckGameOver();
            }

            PrintBoard();

            output("WHAT!!!!!!!");
            Thread.Sleep(200);
            String[] tmp = {
                "I can`t believe it! You beat me! unbelievable!",
                "Hey hey hey, you are cheating! I am the expert in this field!",
                "Am I drunk? How can I lose to you?",
                "I am not in the mood to play with you anymore!"
            };
            output(tmp[rnd.Next(0, tmp.Length)]);

            output("Well, Another game?");
            output(input().Contains("y") ? "How about guess number! I am good at it~~" : "Hey, come on! You gonna play with me anyway!");
        }

        //guess number
        static void guessNum(){
            
        }

        static void Main(string[] args)
        {
            userInstruction();
            introTalk();
            input();
            output("Oh, wait. I am a little bit tired now. Let`s play a game to relax ourselves!");
            Thread.Sleep(80);
            ttt();
            Thread.Sleep(120);
        }
    }
}
