using System;

namespace RobotRovers
{
    public class UserInputManager
    {
        public int[] GetTopRightCoords()
        {

            string topRightCornerCoordsStr = Console.ReadLine();

            string[] coords = topRightCornerCoordsStr.Split(' ');

            if (coords.Length != 2)
            {
                return new int[] { 0, 0 };
            }

            if (!Int32.TryParse(coords[0], out int xCoord))
            {
                return new int[] { 0, 0 };
            }

            if (!Int32.TryParse(coords[1], out int yCoord))
            {
                return new int[] { 0, 0 };
            }

            return new int[] { xCoord, yCoord };
        }

        public Rover GetRover()
        {

            string roverStr = Console.ReadLine();

            string[] roverData = roverStr.Split(' ');

            if (roverData.Length != 3)
            {
                return null;
            }

            if (!Int32.TryParse(roverData[0], out int xRoverData))
            {
                return null;
            }

            if (!Int32.TryParse(roverData[1], out int yRoverData))
            {
                return null;
            }

            if (!Enum.TryParse(roverData[2], true, out Heading headingRoverData))
            {
                return null;
            }

            return new Rover(xRoverData, yRoverData, headingRoverData);
        }

        public string GetCommand()
        {
            string command = Console.ReadLine();
            return command;
        }
    }
}
