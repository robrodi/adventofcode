
using System;

namespace AdventOfCode {

    class SplashScreen {

        public static void Show() {

            var color = Console.ForegroundColor;
            Write(ConsoleColor.Yellow, "\n  __   ____  _  _  ____  __ _  ____     __  ____     ___  __  ____  ____         \n / _\\ (    \\/");
            Write(ConsoleColor.Yellow, " )( \\(  __)(  ( \\(_  _)   /  \\(  __)   / __)/  \\(    \\(  __)        \n/    \\ ) D (\\ \\/ / ) _");
            Write(ConsoleColor.Yellow, ") /    /  )(    (  O )) _)   ( (__(  O )) D ( ) _)         \n\\_/\\_/(____/ \\__/ (____)\\_)__) (__)");
            Write(ConsoleColor.Yellow, "    \\__/(__)     \\___)\\__/(____/(____)  2017\n\n           ");
            Write(ConsoleColor.Gray, ".-----------------------------------------------.       \n           |                              ");
            Write(ConsoleColor.Gray, "                 |  ");
            Write(ConsoleColor.DarkGray, "25\n           ");
            Write(ConsoleColor.Gray, "|                                               |  ");
            Write(ConsoleColor.DarkGray, "24\n           ");
            Write(ConsoleColor.Gray, "|         ");
            Write(ConsoleColor.Yellow, "*                                     ");
            Write(ConsoleColor.Gray, "|  ");
            Write(ConsoleColor.DarkGray, "23\n           ");
            Write(ConsoleColor.Gray, "| ");
            Write(ConsoleColor.Yellow, "*");
            Write(ConsoleColor.DarkGray, "──");
            Write(ConsoleColor.Red, "[─]");
            Write(ConsoleColor.DarkGray, "─┐└───────┐                             ");
            Write(ConsoleColor.Gray, "|  ");
            Write(ConsoleColor.DarkGray, "22 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.Gray, "| ");
            Write(ConsoleColor.DarkGray, "├───");
            Write(ConsoleColor.Yellow, "*  ");
            Write(ConsoleColor.DarkGray, "└────────┘                             ");
            Write(ConsoleColor.Gray, "|  ");
            Write(ConsoleColor.DarkGray, "21 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.Gray, "| ");
            Write(ConsoleColor.DarkGray, "└o");
            Write(ConsoleColor.Yellow, "*");
            Write(ConsoleColor.DarkGray, "┐└┐                                        ");
            Write(ConsoleColor.Gray, "|  ");
            Write(ConsoleColor.DarkGray, "20 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.Gray, "| ");
            Write(ConsoleColor.DarkGray, "┌─┘└─┘       ┌──");
            Write(ConsoleColor.Magenta, "oTo");
            Write(ConsoleColor.DarkGray, "───");
            Write(ConsoleColor.Yellow, "*                       ");
            Write(ConsoleColor.Gray, "|  ");
            Write(ConsoleColor.DarkGray, "19 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.Gray, "| ");
            Write(ConsoleColor.DarkGray, "└────────────┴o");
            Write(ConsoleColor.Yellow, "*");
            Write(ConsoleColor.DarkGray, "──────┘                       ");
            Write(ConsoleColor.Gray, "|  ");
            Write(ConsoleColor.DarkGray, "18 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.Gray, "| ");
            Write(ConsoleColor.DarkGray, "┌──────────────┘┌────────────────────");
            Write(ConsoleColor.Yellow, "*        ");
            Write(ConsoleColor.Gray, "|  ");
            Write(ConsoleColor.DarkGray, "17 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.Gray, "| ");
            Write(ConsoleColor.DarkGray, "└───────────────┘");
            Write(ConsoleColor.Yellow, "*");
            Write(ConsoleColor.DarkGray, "─────");
            Write(ConsoleColor.DarkCyan, "┤|├");
            Write(ConsoleColor.DarkGray, "───────────┘        ");
            Write(ConsoleColor.Gray, "|  ");
            Write(ConsoleColor.DarkGray, "16 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.Gray, "| ");
            Write(ConsoleColor.DarkGray, "o──");
            Write(ConsoleColor.Yellow, "*");
            Write(ConsoleColor.DarkGray, "─────────────┘                            ");
            Write(ConsoleColor.Gray, "|  ");
            Write(ConsoleColor.DarkGray, "15 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.Gray, "| ");
            Write(ConsoleColor.DarkGray, "┌──┘┌──────");
            Write(ConsoleColor.Cyan, "┤[]├");
            Write(ConsoleColor.DarkGray, "─────────");
            Write(ConsoleColor.Yellow, "*                     ");
            Write(ConsoleColor.Gray, "|  ");
            Write(ConsoleColor.DarkGray, "14 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.Gray, "| ");
            Write(ConsoleColor.DarkGray, "└───┴o");
            Write(ConsoleColor.Yellow, "*");
            Write(ConsoleColor.DarkGray, "──────────");
            Write(ConsoleColor.Green, "|(");
            Write(ConsoleColor.DarkGray, "─────┘                     ");
            Write(ConsoleColor.Gray, "|  ");
            Write(ConsoleColor.DarkGray, "13 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.Gray, "| ");
            Write(ConsoleColor.DarkGray, "┌─────┘┌───────");
            Write(ConsoleColor.Yellow, "*                              ");
            Write(ConsoleColor.Gray, "|  ");
            Write(ConsoleColor.DarkGray, "12 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.Gray, "| ");
            Write(ConsoleColor.DarkGray, "└──────┴──o");
            Write(ConsoleColor.Yellow, "*");
            Write(ConsoleColor.DarkGray, "───┘                              ");
            Write(ConsoleColor.Gray, "|  ");
            Write(ConsoleColor.DarkGray, "11 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.Gray, "| ");
            Write(ConsoleColor.Yellow, "*");
            Write(ConsoleColor.DarkGray, "───┬┴┴┴┬─┐└┐                                 ");
            Write(ConsoleColor.Gray, "|  ");
            Write(ConsoleColor.DarkGray, "10 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.Gray, "| ");
            Write(ConsoleColor.DarkGray, "└───┤   ├");
            Write(ConsoleColor.Yellow, "*");
            Write(ConsoleColor.DarkGray, "└─┘                                 ");
            Write(ConsoleColor.Gray, "|  ");
            Write(ConsoleColor.DarkGray, " 9 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.Gray, "| ");
            Write(ConsoleColor.Yellow, "*");
            Write(ConsoleColor.DarkGray, "───┤   ├┘                                    ");
            Write(ConsoleColor.Gray, "|  ");
            Write(ConsoleColor.DarkGray, " 8 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.Gray, "| ");
            Write(ConsoleColor.DarkGray, "└───┤   ├─");
            Write(ConsoleColor.Yellow, "*                                   ");
            Write(ConsoleColor.Gray, "|  ");
            Write(ConsoleColor.DarkGray, " 7 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.Gray, "| ");
            Write(ConsoleColor.DarkGray, "┌───┴┬┬┬┴─┘          ┌─────────────");
            Write(ConsoleColor.Cyan, "┤[]├");
            Write(ConsoleColor.DarkGray, "─────");
            Write(ConsoleColor.Yellow, "* ");
            Write(ConsoleColor.Gray, "|  ");
            Write(ConsoleColor.DarkGray, " 6 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.Gray, "| ");
            Write(ConsoleColor.DarkGray, "└────┐               └──┐┌─┬────┬────o");
            Write(ConsoleColor.Yellow, "*");
            Write(ConsoleColor.DarkGray, "─────┘ ");
            Write(ConsoleColor.Gray, "|  ");
            Write(ConsoleColor.DarkGray, " 5 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.Gray, "| ");
            Write(ConsoleColor.DarkGray, "┌────┘                  │=┌┘o───┘");
            Write(ConsoleColor.Yellow, "*");
            Write(ConsoleColor.DarkGray, "───┐└─────┐ ");
            Write(ConsoleColor.Gray, "|  ");
            Write(ConsoleColor.DarkGray, " 4 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.Gray, "| ");
            Write(ConsoleColor.DarkGray, "└┬──────");
            Write(ConsoleColor.Magenta, "oTo");
            Write(ConsoleColor.DarkGray, "─────────────┴─┘");
            Write(ConsoleColor.Yellow, "*");
            Write(ConsoleColor.DarkGray, "─────┘o──┴──────┤ ");
            Write(ConsoleColor.Gray, "|  ");
            Write(ConsoleColor.DarkGray, " 3 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.Gray, "| ");
            Write(ConsoleColor.DarkGray, "V│V");
            Write(ConsoleColor.Yellow, "*");
            Write(ConsoleColor.DarkGray, "───");
            Write(ConsoleColor.Cyan, "┤[]├");
            Write(ConsoleColor.DarkGray, "─");
            Write(ConsoleColor.Cyan, "┤[]├");
            Write(ConsoleColor.DarkGray, "──────");
            Write(ConsoleColor.White, "∧∧∧");
            Write(ConsoleColor.DarkGray, "─┐└─────────────┐┌─┘ ");
            Write(ConsoleColor.Gray, "|  ");
            Write(ConsoleColor.DarkGray, " 2 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.Gray, "| ");
            Write(ConsoleColor.DarkGray, "└┴┘└───────");
            Write(ConsoleColor.Green, "|(");
            Write(ConsoleColor.DarkGray, "─────────");
            Write(ConsoleColor.Yellow, "*");
            Write(ConsoleColor.DarkGray, "o──┴───");
            Write(ConsoleColor.Red, "[─]");
            Write(ConsoleColor.DarkGray, "────────┘└─o ");
            Write(ConsoleColor.Gray, "|  ");
            Write(ConsoleColor.DarkGray, " 1 ");
            Write(ConsoleColor.Yellow, "**\n           ");
            Write(ConsoleColor.Gray, "'-----------------------------------------------'       \n           \n");
            
            Console.ForegroundColor = color;
            Console.WriteLine();
        }

       private static void Write(ConsoleColor color, string text){
           Console.ForegroundColor = color;
           Console.Write(text);
       }
    }
}