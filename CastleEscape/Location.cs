using System;
using System.Collections.Generic;

namespace CastleEscape
{
    class Location
    {
        public static void Look()
        {

            if (Player.PlayerLocation == 'S')
            {
                SouthLook();
            }
            else if (Player.PlayerLocation == 'N')
            {
                NorthLook();
            }
            else if (Player.PlayerLocation == 'E')
            {
                EastLook();
            }
            else if (Player.PlayerLocation == 'W')
            {
                WestLook();
            }
        }

        public static void SouthLook()
        {
            Program.TypeLine("You see the ");
            MenuText.ChangeTextColor("BED", ConsoleColor.Red);
            Program.TypeLine(" you woke up on.\n");
        }
        public static void NorthLook()
        {
            Program.TypeLine("You see an ancient, mysterious ");
            MenuText.ChangeTextColor("MIRROR", ConsoleColor.Red);
            Program.TypeLine(" with runes etched across both sides.\n");
        }
        public static void EastLook()
        {
            Program.TypeLine("You see a modest wooden writing ");
            MenuText.ChangeTextColor("DESK", ConsoleColor.Red);
            Program.TypeLine(", with an open ");
            MenuText.ChangeTextColor("BOOK", ConsoleColor.Red);
            Program.TypeLine(" sitting on top.\n");
        }
        public static void WestLook()
        {
            Program.TypeLine("You see a small ");
            MenuText.ChangeTextColor("WINDOW", ConsoleColor.Red);
            Program.TypeLine(" that is far too narrow to climb out of.\n");
        }

        public static void UseItem(string useCommand)
        {
            if (useCommand == "USE COMPASS")
            {
                Program.TypeLine("There are four sides to this room. \nTo the North, a ");
                MenuText.ChangeTextColor("MIRROR", ConsoleColor.Red);
                Program.TypeLine(".\nTo the East, ");
                MenuText.ChangeTextColor("DESK", ConsoleColor.Red);
                Program.TypeLine(".\nTo the South, a ");
                MenuText.ChangeTextColor("BED", ConsoleColor.Red);
                Program.TypeLine(".\nTo the West, a ");
                MenuText.ChangeTextColor("WINDOW", ConsoleColor.Red);
                Program.TypeLine(".\n");
            }
            if (Player.PlayerLocation == 'S')
            {
                SouthUseItem(useCommand);
            }
            else if (Player.PlayerLocation == 'N')
            {
                NorthUseItem(useCommand);
            }
            else if (Player.PlayerLocation == 'E')
            {
                EastUseItem(useCommand);
            }
            else if (Player.PlayerLocation == 'W')
            {
                WestUseItem(useCommand);
            }
        }

        public static void SouthUseItem(string useCommand)
        {
                if (useCommand == "USE KEY" && Player.CheckInventory("KEY"))
                {
                    Program.TypeLine("You are south and you have a key and you used a key");
                }
                else if (useCommand == "USE KEY" && !Player.CheckInventory("KEY"))
                {
                    Program.TypeLine("You dont have a key");
                }
                else if (useCommand == "USE BED" && !Player.CheckInventory("KEY"))
                {
                    Program.TypeLine("You climb into the rough bed and notice something inside the pillow... A ");
                    MenuText.ChangeTextColor("KEY", ConsoleColor.Red);
                    Program.TypeLine("? You put it in your bag.\n");
                    Player.inventory.Add("KEY");
                }
                else if (useCommand == "USE BED" && Player.CheckInventory("KEY"))
                {
                    Program.TypeLine("You climb into the rough bed, and remember finding the ");
                    MenuText.ChangeTextColor("KEY", ConsoleColor.Red);
                    Program.TypeLine(" inside the pillow. There's nothing else to find here.\n");
                }  
                else 
                {
                    Program.TypeLine($"{useCommand} is not a proper command. Type ");
                    MenuText.ChangeTextColor("\"HELP\"", ConsoleColor.Yellow);
                    Program.TypeLine(" for assitance with the USE command.\n");
                }  
        }
        public static void NorthUseItem(string useCommand)
        {
                if (useCommand == "USE KEY" && Player.CheckInventory("KEY"))
                {
                    Program.TypeLine("You havent found a reason to use a key here.");
                }
                else if (useCommand == "USE KEY" && !Player.CheckInventory("KEY"))
                {
                    Program.TypeLine("You dont have a key");
                }
                else if (useCommand == "USE MIRROR")
                {
                    Program.TypeLine("You look at the ");
                    MenuText.ChangeTextColor("MIRROR", ConsoleColor.Red);
                    Program.TypeLine(" and instead of seeing your reflection, you see a ");
                    MenuText.ChangeTextColor("STRANGE MAN", ConsoleColor.Cyan);
                    Program.TypeLine(" motioning to the Runes on either side. \nPerhaps if you could decipher them, you could learn more about the Man trapped in the mirror?");
                }
                else if (useCommand == "USE MAGIC BOOK" && Player.CheckInventory("MAGIC BOOK"))
                {
                    Program.TypeLine("You crack open the musty tome, and immediately the runes on the ");
                    MenuText.ChangeTextColor("MIRROR", ConsoleColor.Red);
                    Program.TypeLine(" begin to ");
                    MenuText.ChangeTextColor("glow", ConsoleColor.Cyan);
                    Program.TypeLine(". \nThe ");
                    MenuText.ChangeTextColor("STRANGE MAN", ConsoleColor.Cyan);
                    Program.TypeLine(" in the ");
                    MenuText.ChangeTextColor("MIRROR", ConsoleColor.Red);
                    Program.TypeLine(" begins to laugh. \nThere is a flash of light. When you open your eyes, everything around you is dark. \nBefore you, you see the ");
                    MenuText.ChangeTextColor("STRANGE MAN", ConsoleColor.Cyan);
                    Program.TypeLine(" standing in the tower you were trapped in. \nHe continues to laugh, silently, as he picks up a ");
                    MenuText.ChangeTextColor("STONE", ConsoleColor.Red);
                    Program.TypeLine(" and throws it at you. \nYour view shatters, and everything goes black. \n GAME OVER");
                    Player.IsPlaying = false;
                }
                else 
                {
                    Program.TypeLine($"{useCommand} is not a proper command. Type ");
                    MenuText.ChangeTextColor("\"HELP\"", ConsoleColor.Yellow);
                    Program.TypeLine(" for assitance with the USE command.\n");
                }  
        }

        public static void WestUseItem(string useCommand)
        {
                if (useCommand == "USE KEY" && Player.CheckInventory("KEY"))
                {
                    Program.TypeLine("You havent found a reason to use a key here.");
                }
                else if (useCommand == "USE KEY" && !Player.CheckInventory("KEY"))
                {
                    Program.TypeLine("You dont have a key");
                }
                else if (useCommand == "USE WINDOW")
                {
                    Program.TypeLine("You look out the small ");
                    MenuText.ChangeTextColor("WINDOW", ConsoleColor.Red);
                    Program.TypeLine(" and gasp! \nThe tower you are in goes down into the clouds. You cannot see the ground below, and start to get the sinking feeling there might be ");
                    MenuText.ChangeTextColor("magic", ConsoleColor.Cyan);
                    Program.TypeLine(" at play here.");
                }
                else 
                {
                    Program.TypeLine($"{useCommand} is not a proper command. Type ");
                    MenuText.ChangeTextColor("\"HELP\"", ConsoleColor.Yellow);
                    Program.TypeLine(" for assitance with the USE command.\n");
                }  
        }
        public static void EastUseItem(string useCommand)
        {
                if (useCommand == "USE KEY" && Player.CheckInventory("KEY"))
                {
                    Program.TypeLine("You havent found a reason to use a key here.");
                }
                else if (useCommand == "USE KEY" && !Player.CheckInventory("KEY"))
                {
                    Program.TypeLine("You dont have a key");
                }
                else if (useCommand == "USE BOOK")
                {
                    Program.TypeLine("You look at the ");
                    MenuText.ChangeTextColor("BOOK", ConsoleColor.Red);
                    Program.TypeLine(" sitting on the ");
                    MenuText.ChangeTextColor("DESK", ConsoleColor.Red);
                    Program.TypeLine(". \nMost of the text is unreadable to you--written in some sort of ancient script. \nAt the bottom of the page, you see these words scrawled in the common tongue:\n");
                    MenuText.ChangeTextColor("\"The creature in the mirror is not to be trusted.\"", ConsoleColor.Cyan);
                }
                else if (useCommand == "USE DESK")
                {
                    Program.TypeLine("You sit at the ");
                    MenuText.ChangeTextColor("DESK", ConsoleColor.Red);
                    Program.TypeLine(" and begin rifling through the drawers. \nYou dont find anything of use--spare parchment and some ink. \n But wait--reaching under the desk, you find a ");
                    MenuText.ChangeTextColor("SECRET COMPARTMENT", ConsoleColor.Red);
                    Program.TypeLine(". \nIt is locked.");
                }
                else if (useCommand == "USE SECRET COMPARTMENT" && Player.CheckInventory("KEY"))
                {
                    Program.TypeLine("You unlock the ");
                    MenuText.ChangeTextColor("SECRET COMPARTMENT", ConsoleColor.Red);
                    Program.TypeLine(" with a *click*. \nInside, you find a ");
                    MenuText.ChangeTextColor("MAGIC BOOK", ConsoleColor.Red);
                    Program.TypeLine(". \nYou take it.");
                    Player.inventory.Add("MAGIC BOOK");
                }
                else if (useCommand == "USE SECRET COMPARTMENT" && !Player.CheckInventory("KEY"))
                {
                    Program.TypeLine("You cannot open the ");
                    MenuText.ChangeTextColor("SECRET COMPARTMENT", ConsoleColor.Red);
                    Program.TypeLine(". \nPerhaps if you had a ");
                    MenuText.ChangeTextColor("KEY", ConsoleColor.Red);
                    Program.TypeLine("?\n");
                }
                else if (useCommand == "USE MAGIC BOOK" && Player.CheckInventory("MAGIC BOOK"))
                {
                    Program.TypeLine("You crack open the musty tome, and immediately the runes on the ");
                    MenuText.ChangeTextColor("MIRROR", ConsoleColor.Red);
                    Program.TypeLine(" begin to ");
                    MenuText.ChangeTextColor("glow", ConsoleColor.Cyan);
                    Program.TypeLine(". \nYou shut the book again. Perhaps if you were closer to the mirror?\n");
                }
                else 
                {
                    Program.TypeLine($"{useCommand} is not a proper command. Type ");
                    MenuText.ChangeTextColor("\"HELP\"", ConsoleColor.Yellow);
                    Program.TypeLine(" for assitance with the USE command.\n");
                }  
        }



        public Location()
        {

        }

    }
}