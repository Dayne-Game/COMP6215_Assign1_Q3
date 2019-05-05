using System;
using Assign1_q3.Models;

namespace Assign1_q3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /* PLEASE READ THE README.MD FILE BEFORE YOU USE THIS APPLICATION*/

            Messages messages = new Messages();
            Console.WriteLine(messages.Welcome);
            GameExtended game = new GameExtended();
            //Game game = new Game();
            //game.Load_Game_Settings();

            int inputed_select_case_number = 0;
            bool check_if_inputed_select_case_number_is_valid = false;

            do {
                
                Console.WriteLine(messages.Case_Select);
                Console.Write(">> ");
                int.TryParse(Console.ReadLine(), out inputed_select_case_number);

                if(inputed_select_case_number >= 1 && inputed_select_case_number <= 3) {
                    check_if_inputed_select_case_number_is_valid = true;
                    game.Change_Max_Number_In_Range_Difficulty(inputed_select_case_number);
                    game.Load_Game_Settings();
                } else {
                    Console.WriteLine(messages.Case_Select_Incorrect);
                }

            } while(check_if_inputed_select_case_number_is_valid == false);

            Console.WriteLine(messages.Guess_Number);

            do {

                Console.Write(messages.Enter_Guess);
                int.TryParse(Console.ReadLine(), out int user_input);
                Console.WriteLine(game.Game_Commencing(user_input));

            } while(game.Guess_Database.Count < 3 && !game.Chosen_Number_Guessed);

            int rough_score = game.Guess_Database.Count;

            if(!game.Chosen_Number_Guessed == true) {
                rough_score = 0;
            }

            bool check_name_character_length = false;
            string five_character_name = "";

            do {

                Console.WriteLine(messages.Enter_Name);
                Console.Write(">> ");
                string user_input = Console.ReadLine();

                if(user_input.Length == 5 || user_input.Length < 5 && user_input.Length > 1) {
                    five_character_name = user_input;
                    check_name_character_length = true;
                } else if(user_input.Length == 0) {
                    Console.Clear ();
                    Console.WriteLine (messages.Enter_Name_Incorrect_one);
                } else {
                    Console.Clear ();
                    Console.WriteLine (messages.Enter_Name_Incorrect_two);
                }

            }while(check_name_character_length == false);

            Scoring score = new Scoring();
            score.Five_Character_Name = five_character_name;
            score.Rough_Score_Value = rough_score;
            score.Convert_Rough_Score_Into_True_Score();

            Console.WriteLine(game.Display_All_Guesses_Individual_And_Num_Of_Guesses_Taken());
            Console.WriteLine(score.Display_Five_Character_Name_And_True_Score_From_Score_And_Name_Database());
        }
    }
}
