namespace AiFirstPouriaAhmadi
{
    public class logic
    {
        public CarState CarState { get; set; }
        public int PathForWalking { get; set; } = 0;

        public bool Walking(CarState state)
        {
            if (PathForWalking >= 10)
            {
                Console.WriteLine("you are in end place ");
                return false;
            }
            switch (state)
            {
                case CarState.NotExist:
                    PathForWalking += 2;
                    if (PathForWalking > 10) PathForWalking = 10;
                    Console.WriteLine($"two step next you are have {10 - PathForWalking} step");
                    break;
                case CarState.Far:
                    PathForWalking += 1;
                    if (PathForWalking > 10) PathForWalking = 10;
                    Console.WriteLine($"one step next you are have {10 - PathForWalking} step");
                    break;
                case CarState.Close:
                    if (PathForWalking < 0)
                        Console.WriteLine("You are in start place");
                    else
                    {
                        PathForWalking -= 1;
                        if (PathForWalking < 0) PathForWalking = 0;
                        Console.WriteLine($"one step back you are have {10 - PathForWalking} step");
                    }
                    break;
                case CarState.SoClose:
                    if (PathForWalking < 0)
                        Console.WriteLine("You are in start place");
                    else
                    {
                        PathForWalking -= 2;
                        if (PathForWalking < 0) PathForWalking = 0;
                        Console.WriteLine($"two step back you are have {10 - PathForWalking} step");
                    }
                    break;
            }

            if (PathForWalking >= 10)
            {
                Console.WriteLine("you are in end place ");
                return false;
            }

            return true;
        }

    }

    public enum CarState
    {
        Start,
        Close,
        SoClose,
        Far,
        NotExist

    }
}