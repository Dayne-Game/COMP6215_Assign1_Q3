using System;
using Assign1_q3.Models;

namespace Assign1_q3
{
    class Program
    {
        static void Main(string[] args)
        {
            string play_again_input = "";
            bool keepgoing = true;

            do
            {
                Messages messages = new Messages();
                Console.WriteLine(messages.Welcome);
                GameExtended game = new GameExtended();

                Console.WriteLine(messages.Case_Select);
                string input = Console.ReadLine();

                do {
                    Console.WriteLine(game.Change_Max_Number_In_Range_Difficulty(input));
                }while(game.Check_Case_Input(input) == false);

                game.Load_Game_Settings();

                do {
                    Console.Write(messages.Enter_Guess);
                    int.TryParse(Console.ReadLine(), out int user_input);
                    Console.WriteLine(game.Game_Commencing(user_input));
                } while(game.Guess_Database.Count < 3 && !game.Chosen_Number_Guessed);

                int rough_score = game.Guess_Database.Count;

                if(!game.Chosen_Number_Guessed == true) {
                    rough_score = 0;
                }

                Scoring score = new Scoring();

                bool check_name_character_length = false;

                do {

                    Console.WriteLine(messages.Enter_Name);
                    Console.Write(">> ");
                    string user_input = Console.ReadLine();

                    if(score.Check_Five_Char_Name(user_input)) {
                        score.Five_Character_Name = user_input;
                        check_name_character_length = true;
                    } else {
                        Console.WriteLine("Your Name is too long, or you didn't enter a name");
                    }

                }while(check_name_character_length == false);

                score.Rough_Score_Value = rough_score;
                score.Convert_Rough_Score_Into_True_Score();
                Console.WriteLine(game.Display_All_Guesses_Individual_And_Num_Of_Guesses_Taken());
                Console.WriteLine(score.Display_Five_Character_Name_And_True_Score_From_Score_And_Name_Database(game.difficulty_level));

                Console.WriteLine("Press Y if you would like to play again");
                play_again_input = Console.ReadLine();
                if(play_again_input == "y" || play_again_input == "Y") {
                    keepgoing = true;
                    Console.Clear();
                } else {
                    keepgoing = false;
                }
            } while(keepgoing == true);
        }
    }
}
