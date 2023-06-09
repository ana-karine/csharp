// https://www.beecrowd.com.br/judge/pt/problems/view/1047

using System; 

class URI {

    static void Main(string[] args) { 

        int totalTime = 0;

        Console.WriteLine("Informe a hora inicial, minuto inicial, hora final e minuto final de um jogo: ");
        string[] numbers = Console.ReadLine().Split(' ');

        /*
            Tempo inicial = 23h5min
            Tempo final = 1h2min
        */

        int startTime = int.Parse(numbers[0]) * 60 + int.Parse(numbers[1]);
        int endTime = int.Parse(numbers[2]) * 60 + int.Parse(numbers[3]);
        
        if (endTime > startTime) {
            totalTime = endTime - startTime;
        } else {
            totalTime = (24 * 60 - startTime) + endTime;
        }

        int timeToHours = totalTime / 60;
        int timeToMinutes = totalTime % 60;

        Console.WriteLine("O JOGO DUROU " + timeToHours + " HORA(S) E " + timeToMinutes + " MINUTO(S)");
    }

}
