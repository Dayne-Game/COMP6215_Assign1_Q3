using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Assign1_q3.Models
{
    class Game : IGame, IGuesses {
        public int Chosen_Number {get; set;} // This holds the Chosen Number
        public bool Chosen_Number_Guessed {get; set;} // Tells Whether the Chosen Number has been guessed by the user
        public int max_Number_In_Range_For_Chosen_Number {get; set;} = 5; // This holds the max num in range for the Chosen Number to be picked
        public List<int> Guess_Database {get; set;} // This holds the Guesses in a List. 

        public void Load_Game_Settings() {
            Debug.WriteLine($"Max Range or Difficulty: {max_Number_In_Range_For_Chosen_Number}");
            Random rand = new Random(); // Creates new Random Variable
            Chosen_Number = rand.Next(1, max_Number_In_Range_For_Chosen_Number);
            Guess_Database = new List<int>();
            Debug.WriteLine($"Chosen Number: {Chosen_Number}");
        }

        public bool Check_The_Inputed_Guess_From_The_User(int user_input) {
            Guess_Database.Add(user_input);
            if(user_input == Chosen_Number) {
                Chosen_Number_Guessed = true;
                return true;
            } else {
                return false;
            }
        }

        public string Display_All_Guesses_Individual_And_Num_Of_Guesses_Taken() {
            int Guess_Total = Guess_Database.Count;
            string output = $"Number of Guesses Taken: {Guess_Total} | Individual Guesses:";
            foreach(int guesses in Guess_Database) {
                output += $" {guesses} ";
            }
            return output;
        }

        public string Game_Commencing(int user_input) {
            int Guess_Count = Guess_Database.Count;
            if(Check_The_Inputed_Guess_From_The_User(user_input)) {
                return "Congradulations you won the Game!";
            } else if (Guess_Count < 3) {
                return "Your Guess was Wrong. Try Again";
            } else {
                return $"Sorry you didn't Guess the Correct Number. The correct number was: {Chosen_Number}";
            }
        }
    }
}