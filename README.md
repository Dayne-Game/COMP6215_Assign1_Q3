# COMP. 6215 Assignment 01 - Question 03 Console #

## How to change Between the Standard and the Extended Version of the game.

### **Note:** The class are self explanitory. ``` GameExtended ``` = Extended Version, ``` Game ``` = Standard Version. The current Program.cs file is laid out for Extended Version. 

## Change to from The Extended Version to the Standard Version

Currently ``` Game game = new Game(); ``` on ``` Line: 16 ``` and ``` game.Load_Game_Settings(); ``` on ``` Line: 17``` is commented out. Un-comment both of these lines.

Than comment out ``` GameExtended game = new GameExtended(); ``` on ``` Line: 15 ```

Now the last thing to do is comment out ``` Line: 19``` to ``` Line: 36 ```. (From ``` int inputed_select_case_number = 0; ``` to ``` } while(check_if_inputed_select_case_number_is_valid == false); ```)

### Broken Down Version:
 - Uncomment ```Line: 16``` and ```Line: 17```
 - Comment out ```Line: 15```
 - Comment out ```Line: 19``` to ```Line: 36```

### The reason for this is to get rid of the do while loop that controls the User Experiance for the use of the ``` Change_Max_Number_In_Range_Difficulty(); ``` Method from the ```GameExtended``` class.

## Change from the Standard Version to the Extended Version

Comment out ``` Game game = new Game(); ``` on ``` Line: 16 ``` and ``` game.Load_Game_Settings(); ``` on ``` Line: 17```

Than un-comment ``` GameExtended game = new GameExtended(); ``` on ``` Line: 15 ```

Finally uncomment ```Line: 19``` to ```Line: 36``` (From: ``` int inputed_select_case_number = 0; ``` to ``` } while(check_if_inputed_select_case_number_is_valid == false); ```)

### Broken Down Version:
 - Comment ```Line: 16``` and ```Line: 17```
 - Un-comment out ```Line: 15```
 - Un-comment out ```Line: 19``` to ```Line: 36```

## Thank you for Reading!
