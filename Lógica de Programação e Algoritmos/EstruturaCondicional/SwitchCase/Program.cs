string number;
string day;

Console.WriteLine("Informe o dia da semana: ");
number = Console.ReadLine();

switch (number)
{
    case "1":
        day = "domingo";
        break;
    case "2":
        day = "segunda-feira";
        break;
    case "3":
        day = "terça-feira";
        break;
    case "4":
        day = "quarta-feira";
        break;
    case "5":
        day = "quinta-feira";
        break;
    case "6":
        day = "sexta-feira";
        break;
    case "7":
        day = "sábado";
        break;                           
    default:
        day = "inválido!";
        break;
}

Console.WriteLine("Dia da semana: " + day);