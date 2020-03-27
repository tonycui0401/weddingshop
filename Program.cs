using System;
using System.Collections.Generic;

namespace RobotRovers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> commands = new List<string>();

            List<Rover> roverList = new List<Rover>();

            UserInputManager uim = new UserInputManager();

            int[] topRightCorner;

            while (true)
            {
                topRightCorner = uim.GetTopRightCoords();

                if (topRightCorner[0] != 0 && topRightCorner[1] != 0)
                {
                    break;
                }
                Console.WriteLine("User input error, need 2 positive integers" +
                    " seperated by space, they can't be both zero");
            }

            while (true)
            {
                Rover rv = uim.GetRover();

                if (rv != null)
                {
                    roverList.Add(rv);
                    string command = uim.GetCommand();
                    commands.Add(command);
                }
                else
                {
                    if (roverList.Count == 0)
                    {
                        Console.WriteLine("User input error, need 2 positive integers" +
                            " followed by any heading seperated by space, for example, '2 3 N'");
                    }
                    break;
                }
            }

            if (roverList.Count != commands.Count)
            {
                Console.WriteLine("User Input error, different number of rovers and commands");
            }

            int counter = 0;
            foreach (Rover rover in roverList)
            {
                rover.ExecuteCommand(commands[counter]);
                rover.Output();
                counter++;
            }
        }
    }
}
