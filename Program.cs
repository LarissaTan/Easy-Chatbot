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
            if(tmp == "quit") {
                output("Bye~~~");
                Environment.Exit(0);
            }  
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
        static bool isPwin = true;
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

            CheckGameOver();

            if (gameOver){
                narrator("The Game is over now...");
            }
            else{
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
                        if(temp == 'o') {
                            isPwin = false;
                            narrator("Chatbot wins!");
                        }
                    }else if ((board[0] != '1' && board[1] != '2' && board[2] != '3' &&
                                board[3] != '4' && board[4] != '5' && board[5] != '6' &&
                                board[6] != '7' && board[7] != '8' && board[8] != '9') && !gameOver){
                                    gameOver = true;
                                    isPwin = false;
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
                if(!gameOver) CheckGameOver();
            }

            PrintBoard();
            if(isPwin){
                output("WHAT!!!!!!!");
                Thread.Sleep(200);
                String[] tmp = {
                    "I can`t believe it! You beat me! unbelievable!",
                    "Hey hey hey, you are cheating! I am the expert in this field!",
                    "Am I drunk? How can I lose to you?",
                    "I am not in the mood to play with you anymore!"
                };
                output(tmp[rnd.Next(0, tmp.Length)]);
            }else{
                String[] tmp = {
                    "Don`t be so sad. It is just a game!",
                    "I am the best! I am the best! I am the best!",
                };
                output(tmp[rnd.Next(0, tmp.Length)]);
            }
 

            output("Well, Another game?");
        }

        //guess number
        static void guessNum(){
            Random random = new Random();
            int target = random.Next(1, 101);
            int attempts = 0;
            bool isCorrect = false;

            narrator("Welcome to the Number Guessing Game!");
            output("Okay~ Now, I'm thinking of a number between 1 and 100.");
            //print a number for every 0.4s
            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(400);
                output(".");
            }
            output("I am done with a number now~ Can you guess it? I will give you 5 chances!");

            while (!isCorrect && attempts < 5)
            {
                narrator("Enter your guess(1-100)");
                string trial = getDigits(input());
                if (int.TryParse(trial, out int guess))
                {
                    attempts++;

                    if (guess < target)
                    {
                        String[] tmp = {
                            "Oh, you are so close! But still too low!",
                            "You are almost there! Try a bigger number!",
                            "Come on! How can I guess a number so small!"
                        };
                        output(tmp[rnd.Next(0, tmp.Length)]);
                    }
                    else if (guess > target)
                    {
                        String[] tmp = {
                            "Great, hahaha! Not that one! Try a smaller number!",
                            "How can you guess such a big number!",
                            "Hey! Hey! You! You! Wanna try a small one?"
                        };
                        output(tmp[rnd.Next(0, tmp.Length)]);
                    }
                    else
                    {
                        narrator($"Congratulations! You guessed it right in {attempts} attempts.");
                        isCorrect = true;
                    }
                }
                else
                {
                    narrator("Invalid input. Please enter a valid number.");
                }
            }

            if(!isCorrect){
               narrator($"Sorry, you failed to guess the number in 5 attempts. The number was {target}."); 
               String[] tmp = {
                "Ops, I forgot to tell you that I am good at guessing number!",
                "Don`t be upset! I only give you 5 chances!",
                "Emmmm, you could do it better for the next time!"
               };
               output(tmp[rnd.Next(0, tmp.Length)]);
            }else{
                String[] tmp = {
                    "How can this happen! You are so lucky!",
                    "Wait, are you a mind reader？",
                    "Are you the roundworm in my stomach?"
                };
                output(tmp[rnd.Next(0, tmp.Length)]);
            }
        }

        static void guessCountry(){
            string[] countries = { "china", "malaysia", "india", "indonesia"};
            Random random = new Random();
            int randomNumber = random.Next(countries.Length);
            string target = countries[randomNumber];
            string guess;
            int attempts = 0;
            bool isCorrect = false;

            string[] china = { "Pro tips! This is an Aisan country.",
                               "Seems like you need some helps. Well, the country has a long history.",
                               "Close! But not that one. One more tip! This country has various delicious cuisine.",
                               "Last chance! Think twice before give me the answer. The country has a large population."};

            string[] malaysia = { "First tip! This country is located in Aisa.",
                               "Nice guess. But remeber this country has vaious culture.",
                               "You are almost there! Keep in mind that this country has a lot of islands.",
                               "Last call! Take southeast Asia into consideration."};

            string[] india = { "To narrow down the range, this is a large country.",
                               "Alright. How about this? This country has a lot of people.",
                               "Wait? What`s wrong with you? Pro tips! This country has a lot of languages.",
                               "Gosh, how can you forget about a country with a lot of religions."};
            
            string[] indonesia = { "Remebered, the country is located in southeast Asia.",
                               "Emmm, actually this country has a lot of islands.",
                               "Hey, don`t give up! This country has a lot of volcanoes.",
                               "Okay, okay, try to come up a country near Malaysia."};

            narrator("Welcome to the Guess the Country Game!");
            output("Okay~ First, I gonna think of a country. Remember, it is a country name, not a city name.");
            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(400);
                output(".");
            }
            output("I am done with a country now~ Can you guess it? I will give you 5 chances!");

            while (!isCorrect && attempts < 5)
            {
                output("Enter your guess(full name and lowercase)");
                guess = input();
                attempts++;

                if (guess.Equals(target, StringComparison.OrdinalIgnoreCase))
                {
                    narrator($"Congratulations! You guessed it right. It's {target}!");
                    isCorrect = true;
                }
                else
                {
                    if(target == "china"){
                        output(china[attempts-1]);
                    }else if(target == "malaysia"){
                        output(malaysia[attempts-1]);
                    }else if(target == "india"){
                        output(india[attempts-1]);
                    }else{
                        output(indonesia[attempts-1]);
                    }
                }
            }

            if(!isCorrect){
               narrator($"Sorry, you failed to guess the country in 5 attempts. The country was {target}."); 
               String[] tmp = {
                "I am a country guesser! How can you beat me!",
                "So show me your talent! Learn more before come to me! Haha!",
                "You should try harder in other games! I am not gonna give you a second chance!"
               };
               output(tmp[rnd.Next(0, tmp.Length)]);
            }else{
                String[] tmp = {
                    "Wow, are you a geography master?",
                    "Well done! You are way more better than I thought!"
                };
                output(tmp[rnd.Next(0, tmp.Length)]);
            }
        }

        static void pickGames(){
            string[] games = { "guess number", "guess country", "tic tac toe"};
            string temp = input();
            if(temp.Contains("number")){
                guessNum();
            }else if(temp.Contains("country")){
                guessCountry();
            }else if(temp.Contains("tic tac toe")){
                ttt();
            }else{
                output("Sorry, I don`t know this game. I only know about guess number, guess country and tic tac toe.");
                pickGames();
            }
        }

        static void Main(string[] args)
        {
            String key;
            userInstruction();
            introTalk();
            input();
            output("Oh, wait. I am a little bit tired now. Let`s play a game to relax ourselves!");
            Thread.Sleep(80);
            ttt();
            Thread.Sleep(120);
            key = input().Contains("y") ? "How about guess number! I am good at it~~" : "Hey, come on! Tell me what you want to play!";
            output(key);
            if(key == "Hey, come on! Tell me what you want to play!") pickGames();
            else guessNum();
            Thread.Sleep(120);
            output("Okay, I am done with guessing number. Seems like you like the guessing. How about guess a country?");
            key = input().Contains("y") ? "Okay, let`s start!" : "So tell me what you want to play!";
            if(key == "So tell me what you want to play!") pickGames();
            else guessCountry();
            
        }
    }
}
