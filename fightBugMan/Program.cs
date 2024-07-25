using System.Data;
using System.Security.Cryptography;

namespace pract322 {
    internal class Program {
        static void Main(string[] args) {
            BattleSim();
        }//END MAIN
        static void BattleSim() {
            bool isDead = false;
            bool gameOver = false;
            bool turn2 = false;
            bool frog = false;
            bool guard = false;
            int health = 10;
            int playerHealth = 15;
            
            Random rng = new Random();
            int randomNumber = 0;

            while (gameOver != true) {
                guard = false;
                turn2 = false;
                if (playerHealth <= 0) {
                    gameOver = true;
                }
                if (frog == true) {
                    Console.WriteLine("MIGHT OF THE FROG.");
                
                    health--;
                }
                Console.WriteLine($"BUGMAN: {health}/10");
                Console.WriteLine("\t\t 7  7");
                Console.WriteLine("\t\t [`']");
                Console.WriteLine("\t\t{/--\\{");
                Console.WriteLine("\t\t |--|");
                Console.WriteLine("\t\t {  {");
                Console.WriteLine("\t1. ATTACK\t2. SPELL\n\t3. ITEM\t\t4. GUARD\n");
                Console.WriteLine($"\tHEALTH: {playerHealth}/15");
                char input = Console.ReadKey(true).KeyChar;
                if (input == '1') {
                    randomNumber = rng.Next(1,10);
                    if (randomNumber >3) {
                    randomNumber = rng.Next(1,4);
                        Console.WriteLine($"ATTACKED BUGMAN FOR {randomNumber} DAMAGE!!");
                        health -= randomNumber;
                        Console.ReadKey(true);
                        Console.Clear();
                        turn2 = true;
                    } else {
                        Console.WriteLine("MISSED");
                        Console.ReadKey(true);
                        Console.Clear();
                        turn2 = true;
                    }
                } else if (input == '2') {
                    Console.Clear();
                    Console.WriteLine($"BUGMAN: {health}/10");
                    Console.WriteLine("\t\t 7  7");
                    Console.WriteLine("\t\t [`']");
                    Console.WriteLine("\t\t{/--\\{");
                    Console.WriteLine("\t\t |--|");
                    Console.WriteLine("\t\t {  {");
                    Console.WriteLine("\t1. HEAL\t2. MAGMA PLUME");
                    Console.WriteLine($"\tHEALTH: {playerHealth}/15");
                    input = Console.ReadKey(true).KeyChar;
                    if (input == '1'){
                        randomNumber = rng.Next(1,4);
                        playerHealth += randomNumber;
                        turn2 = true;
                    } else if (input == '2') {
                        randomNumber = rng.Next(1,6);
                        if(randomNumber >= 4){
                            Console.WriteLine("MELTED FOR 6 DAMAGE!!!");
                            health -= 6;
                            Console.ReadKey(true);
                            turn2 = true;
                        } else {
                            Console.WriteLine("MAJOR MISS!!");
                            Console.ReadKey(true);
                            turn2 = true;
                        }//END ELSE
                    }//END ELSE IF
                } if (input == '3') {
                    Console.Clear();
                    Console.WriteLine($"BUGMAN: {health}/10");
                    Console.WriteLine("\t\t 7  7");
                    Console.WriteLine("\t\t [`']");
                    Console.WriteLine("\t\t{/--\\{");
                    Console.WriteLine("\t\t |--|");
                    Console.WriteLine("\t\t {  {");
                    Console.WriteLine("\t1. H POTION\t2. FROG");
                    Console.WriteLine($"\tHEALTH: {playerHealth}/15");
                    input = Console.ReadKey(true).KeyChar;
                    if (input == '1') {
                        playerHealth += 2;
                        turn2 = true;
                    } else if (input == '2') {
                        frog = true;
                        Console.WriteLine("YOU LET OUT A FROG!!");
                        turn2 = true;
                    }
                }//END IN 3
                if (input == '4') {
                    guard = true;
                    turn2 = true;
                }//END IN 4
                    if (health <= 0) {
                        isDead = true;
                    gameOver = true;
                    Console.Clear();
                    Console.WriteLine("\n\n\n");
                    Console.WriteLine("\t   ##@p89");
                    Console.WriteLine("\t__07oo7}]]#__");
                    Console.WriteLine("\n\tBUGMAN IS DEAD!!");
                }else if (turn2 == true) {
                        Console.Clear();
                        Console.WriteLine($"BUGMAN: {health}/10");
                        Console.WriteLine("\t\t 7  7");
                        Console.WriteLine("\t\t [`']");
                        Console.WriteLine("\t\t{/--\\{");
                        Console.WriteLine("\t\t |--|");
                        Console.WriteLine("\t\t {  {");
                        
                        Console.WriteLine($"\n\tHEALTH: {playerHealth}/15");

                        randomNumber = rng.Next(1,2);
                        if (randomNumber == 1) {
                        randomNumber = rng.Next(5);
                        if (randomNumber > 2) {
                            if (guard == true) {
                                randomNumber -= 2;
                                Console.WriteLine("#GUARDING#");
                            }
                            playerHealth -= randomNumber;
                            Console.WriteLine("BAAAAHHH IM THE EVIL BUG MAN BAHH!!!");
                            Console.WriteLine($"YOU WERE HIT FOR {randomNumber} DAMAGE!!");
                        } else {
                            Console.WriteLine("BUGMAN MISSED!!");
                        }
                        } else if (randomNumber == 2) {
                        randomNumber = rng.Next(1,4);
                        health += randomNumber;
                        Console.WriteLine($"OH NO!! BUGMAN HEALED FOR {randomNumber}HP!");
                        }
                    Console.ReadKey(true);
                    Console.Clear();
                }//END ELSE IF
            }//END WHILE
            if (gameOver == true) {
                if (isDead != true) {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("\t\t 7  7");
                    Console.WriteLine("\t\t [|o|]");
                    Console.WriteLine("\t\t{/---\\{");
                    Console.WriteLine("\t\t |---|");
                    Console.WriteLine("\t\t {  {");
                    Console.WriteLine("BAHAHA I KNEW ID WIN IM BUGMAN.");
                    Thread.Sleep(3200);
                    Console.Clear();
                    Console.WriteLine("GAME OVER.");
                } else {
                    
                    Console.WriteLine("\n\n\tYOU ARE WINNER");
                }
            }
        }//END SIM





        static void BoolPractice() {
            bool isPressed = false;
            while (isPressed != true) {
                Console.WriteLine("enter key");
                char symbol = Console.ReadKey(true).KeyChar;

                isPressed = symbol == 'd' || symbol == 'D';
            }
            Console.WriteLine("bahhh");
        }//END BOOL PRACT
        #region HELPER FUNCTIONS
        static void Fancify(string text) {

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("**##=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=##**");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\t--->>\\{text}/<<---");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("**##=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=##**");

            Console.ResetColor();

        }//END FANCIFY
        static string Prompt(string request) {
            //Variables
            string userInput = "";

            //Request Information From User
            Console.Write(request);

            //Receive Response
            userInput = Console.ReadLine();

            return userInput;

        }//END PROMPT HELPER
        static int PromptInt(string request) {

            int userInput = 0;
            bool isValid = false;

            Console.Write(request);
            isValid = int.TryParse(Console.ReadLine(), out userInput);

            while (isValid == false) {

                Console.WriteLine("ERROR: NO REAL NUMBER");
                Console.Write(request);
                isValid = int.TryParse(Console.ReadLine(), out userInput);
            }//END WHILE

            return userInput;

        }//END PROMPT TRY INT
        static double PromptDouble(string request) {

            double userInput = 0;
            bool isValid = false;

            Console.Write(request);
            isValid = double.TryParse(Console.ReadLine(), out userInput);

            while (isValid == false) {

                Console.WriteLine("ERROR: NO REAL NUMBER");
                Console.Write(request);
                isValid = double.TryParse(Console.ReadLine(), out userInput);
            }

            return userInput;

        }//END PROMPT DOUBLE
        #endregion
    }//END CLASS
}//END NAMESPACE
