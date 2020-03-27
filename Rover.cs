using System;
namespace RobotRovers
{
    public class Rover
    {
        public Heading Heading { get; set; } = Heading.N;

        public Location Location { get; set; } = new Location { X = 0, Y = 0 };

        public Rover(int X, int Y, Heading heading)
        {
            Location.X = X;
            Location.Y = Y;
            Heading = heading;
        }

        public void Move()
        {
            switch (Heading)
            {
                case Heading.N:
                    Location.Y += 1;
                    break;
                case Heading.S:
                    Location.Y -= 1;
                    break;
                case Heading.E:
                    Location.X += 1;
                    break;
                case Heading.W:
                    Location.X -= 1;
                    break;
            }
        }

        public void RotateL()
        {
            switch (Heading)
            {
                case Heading.N:
                    Heading = Heading.W;
                    break;
                case Heading.S:
                    Heading = Heading.E;
                    break;
                case Heading.E:
                    Heading = Heading.N;
                    break;
                case Heading.W:
                    Heading = Heading.S;
                    break;
            }
        }

        public void RotateR()
        {
            switch (Heading)
            {
                case Heading.N:
                    Heading = Heading.E;
                    break;
                case Heading.S:
                    Heading = Heading.W;
                    break;
                case Heading.E:
                    Heading = Heading.S;
                    break;
                case Heading.W:
                    Heading = Heading.N;
                    break;
            }
        }

        public void ExecuteCommand(string roverCommands)
        {
            char[] roverCommandsChars = roverCommands.ToCharArray();

            foreach (char c in roverCommandsChars)
            {
                switch (c)
                {
                    case 'M':
                        this.Move();
                        break;
                    case 'L':
                        this.RotateL();
                        break;
                    case 'R':
                        this.RotateR();
                        break;
                }
            }
        }

        public void Output()
        {
            Console.WriteLine($"{this.Location.X} {this.Location.Y} {this.Heading}");
        }

    }
}