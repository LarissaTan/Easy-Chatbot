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
            return Console.ReadLine().Trim().ToLower();
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

        static void Main(string[] args)
        {
            introTalk();
        }
    }
}
