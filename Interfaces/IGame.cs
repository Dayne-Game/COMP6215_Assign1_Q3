using System.Collections.Generic;

namespace Assign1_q3
{
    interface IGame
    {
        int Chosen_Number {get; set;}
        bool Chosen_Number_Guessed {get; set;}
        int max_Number_In_Range_For_Chosen_Number {get; set;}
        void Load_Game_Settings();
        string Game_Commencing(int user_input);
    }
}