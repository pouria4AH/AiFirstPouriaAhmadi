using AiFirstPouriaAhmadi;

logic newLogic = new logic();
CarState carState = CarState.Start;
bool key = true;
while (key)
{
    Console.WriteLine("chose car state \n\n");
    Console.WriteLine("S for so close \n");
    Console.WriteLine("C for close \n");
    Console.WriteLine("F for Far \n");
    Console.WriteLine("N so NotExist \n");
    string res = Console.ReadLine();

    switch (res.ToLower())
    {
        case "s":
            carState = CarState.SoClose;
            break;
        case "c":
            carState = CarState.Close;
            break;
        case "f":
            carState = CarState.Far;
            break;
        case "n":
            carState = CarState.NotExist;
            break;
    }
    key = newLogic.Walking(carState);
}