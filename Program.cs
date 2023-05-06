﻿using System;
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
        static void PrintBoard()
        {
            Console.WriteLine("-------------");
            Console.WriteLine($" {board[0]} | {board[1]} | {board[2]} ");
            Console.WriteLine("-------------");
            Console.WriteLine($" {board[3]} | {board[4]} | {board[5]} ");
            Console.WriteLine("-------------");
            Console.WriteLine($" {board[6]} | {board[7]} | {board[8]} ");
            Console.WriteLine("-------------");
        }

        static void Play()
        {
            output(name + " enter your choice (1-9) here: ");
            string p = getDigits(input());
            int move;

            if (int.TryParse(p, out move) && move >= 1 && move <= 9 && board[move - 1] != 'X' && board[move - 1] != 'o')
            {
                board[move - 1] = player;
            }
            else
            {
                Console.WriteLine("Invalid move. Please try again.");
                Play();
            }

            do
            {
                move = rnd.Next(1, 10);
            } while (board[move - 1] == 'X' || board[move - 1] == 'o');

            board[move - 1] = 'o';
        }

        static void CheckGameOver()
        {
            if ((board[0] == board[1] && board[1] == board[2] && board[0] == 'X')||
                (board[3] == board[4] && board[4] == board[5] && board[3] == 'X')||
                (board[6] == board[7] && board[7] == board[8] && board[6] == 'X')||
                (board[0] == board[3] && board[3] == board[6] && board[0] == 'X')||
                (board[1] == board[4] && board[4] == board[7] && board[1] == 'X')||
                (board[2] == board[5] && board[5] == board[8] && board[2] == 'X')||
                (board[0] == board[4] && board[4] == board[8] && board[0] == 'X')||
                (board[2] == board[4] && board[4] == board[6] && board[2] == 'X'))
            {
                gameOver = true;
                output(name + " wins!");
            }
            else if((board[0] == board[1] && board[1] == board[2] && board[0] == 'o')||
                    (board[3] == board[4] && board[4] == board[5] && board[3] == 'o')||
                    (board[6] == board[7] && board[7] == board[8] && board[6] == 'o')||
                    (board[0] == board[3] && board[3] == board[6] && board[0] == 'o')||
                    (board[1] == board[4] && board[4] == board[7] && board[1] == 'o')||
                    (board[2] == board[5] && board[5] == board[8] && board[2] == 'o')||
                    (board[0] == board[4] && board[4] == board[8] && board[0] == 'o')||
                    (board[2] == board[4] && board[4] == board[6] && board[2] == 'o'))
            {
                gameOver = true;
            }
        }

        static void ttt(){
            board = new char[9] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            player = 'X';
            gameOver = false;

            while (!gameOver)
            {
                PrintBoard();
                Play();
                CheckGameOver();
            }

            PrintBoard();

        }

        static void Main(string[] args)
        {
            userInstruction();
            introTalk();
            ttt();
        }
    }
}
