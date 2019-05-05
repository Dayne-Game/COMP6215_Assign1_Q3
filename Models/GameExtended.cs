/* This Work is Copyrighted by Dayne Game */
/* If you steal or distributed without permisson (I'm watching you Dylan Nichols) */
/* I will kick your ass. */

namespace Assign1_q3.Models {
       class GameExtended : Game, IRange_Difficulty {
        public void Change_Max_Number_In_Range_Difficulty(int inputed_select_case_number) {
            switch(inputed_select_case_number) {
                case 1: // Easy Difficulty
                {
                    max_Number_In_Range_For_Chosen_Number = 5;
                    break;
                }
                case 2: // Medium Difficulty
                {
                    max_Number_In_Range_For_Chosen_Number = 10;
                    break;
                }
                case 3: // Hard Difficulty
                {
                    max_Number_In_Range_For_Chosen_Number = 20;
                    break;
                }
            }
        }
    }
}