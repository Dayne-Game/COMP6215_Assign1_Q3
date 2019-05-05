using System.Collections.Generic;

namespace Assign1_q3
{
    interface IGuesses
    {
        List<int> Guess_Database {get; set;}
        bool Check_The_Inputed_Guess_From_The_User(int user_input);
        string Display_All_Guesses_Individual_And_Num_Of_Guesses_Taken();
    }
}