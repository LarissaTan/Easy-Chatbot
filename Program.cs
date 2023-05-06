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
            return Console.ReadLine();
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
            int ageInt = Convert.ToInt32(age);

            //give different feedback according to the age
            if(ageInt > 25)
            {
                String[] feedback25 = 
                { 
                    "Hey, I heard you've crossed the threshold of 25. So, now you've officially entered the realm of 'maturity and charm.' Congratulations!", 
                    "I really admire you because you've survived that dreaded 25th birthday. How did you manage it? Did you invent the anti-aging elixir?", 
                    "Age is just a number, but you seem to be making that number quite fashionable. Every time I see you, you look more charming and wise than before. Maybe I should seek your advice on how to stay forever young?" 
                };
                Random random = new Random();
                output(feedback25[random.Next(0, feedback25.Length)]);
            }
            else if(ageInt > 18)
            {
                String[] feedback18 = 
                { 
                    "I heard you've surpassed the legal age of 18 and now you're a 'legally adventurous' individual. So, try some daring activities in life!", 
                    "Now that you're in the world of adulthood, you still possess the energy and carefree attitude of a young person. That's amazing! Don't forget to share some secrets so us slightly older folks can keep up with the pace."
                };
                Random random = new Random();
                output(feedback18[random.Next(0, feedback18.Length)]);
            }
            else if(ageInt > 12)
            {
                String[] feedback12 = 
                { 
                    "I heard you've joined the ranks of teenagers, gaining more freedom and responsibility. But I bet you still secretly wish to enjoy the delicious dinners your parents make for you, right?", 
                    "Now that you've become a young adult, you have more autonomy and decision-making power. But don't forget to give yourself some time to be a kid as well, to enjoy playfulness and carefree moments.", 
                    "You've reached that mysterious age where you're neither a child nor an adult. It's like an exploration journey, sometimes getting lost, sometimes discovering yourself. But no matter what, remember to enjoy this special time!" 
                };
                Random random = new Random();
                output(feedback12[random.Next(0, feedback12.Length)]);
            }
            else
            {
                String[] feedback = 
                { 
                    " ", 
                    " ", 
                    " " 
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
