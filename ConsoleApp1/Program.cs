//bool isAlive = true;
//isAlive = 16 > 6;
//isAlive = 16 < 6;
//isAlive = 16 != 6;
//isAlive = 16 == 6;

//     string name = Console.ReadLine();;


// if (name == "Lazar") ;
// {
//     Console.WriteLine("välkomen!");
// }
// else if (name == "HUbert");
// {
//     Console.WriteLine("lite välkomen!");
// }
// else
// {
//      Console.WriteLine("Viktor har en liten Snopp"); 
// }







// Console.ReadLine();

using System.Net.WebSockets;
using System.Security.Claims;

Console.WriteLine("Börja spelet med att välja din karaktär Tjocka Caspian-samlla Viktor");
string name = Console.ReadLine();
if (name == "Tjocka Caspian")
{


    Console.WriteLine("Du har valt den Tjocka Caspian");
    Console.WriteLine("Tjocka Caspians styrker är:\n Super snabb på att äta:\n kiddnappar äldre kvinnor:\n är en fullis");

    Console.WriteLine("Välj ditt vapen:\n Vita pulvret:\n Flasköppnare ");
    string wepond = Console.ReadLine();
    if (wepond == "Vita pulvret")
    {
        Console.WriteLine("Tjocka Caspian jobbade på en club. Sen gick han till tåan för att dra en lina och plötligt sniffa han in för mycket av det vita pulvret och fick överdoss");
    }
    else if (wepond == "Flasköppnare")
    {
        Console.WriteLine("Tjocka Caspian hade sin lilla flasköppnare han sprang efter en äldre kvinna som han vill kiddnappa men han snubla på ett bannanskal och fick hans lilla flasköppnare rak in hjärtat. ");
    }
    else
    {
        Console.WriteLine("VA. Fattar inte vad du skriver");
    }
}
Console.ReadLine();