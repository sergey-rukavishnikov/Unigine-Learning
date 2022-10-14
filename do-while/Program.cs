// See https://aka.ms/new-console-template for more information

namespace do_while // Note: actual namespace depends on the project name.
{
    internal static class Program
    {
        enum BodyParts
        {
            Голова = 0,
            Ноги = 1,
            Тело = 2
        }
        static void Main(string[] args)
        {
            int MansScore = 0, PcScore = 0;
            int Dif;
            Random r = new Random();
            int PcChoiseHit, MansChoiseHit = 0, PcChoiseProtect, MansChoiseProtect = 0;
            
            do
            {
                PcChoiseProtect = r.Next(2);
                Console.WriteLine($"Выберете, что защитить: {(int)BodyParts.Голова} = {BodyParts.Голова}\n" +
                                  $"{(int)BodyParts.Ноги} = {BodyParts.Ноги}\n{(int)BodyParts.Тело} = {BodyParts.Тело}");
                int.TryParse(Console.ReadLine(), out MansChoiseProtect);
                PcChoiseHit = r.Next(2);
                Console.WriteLine($"Выберете, что ударить: {(int)BodyParts.Голова} = {BodyParts.Голова}\n" +
                                  $"{(int)BodyParts.Ноги} = {BodyParts.Ноги}\n{(int)BodyParts.Тело} = {BodyParts.Тело}");
                int.TryParse(Console.ReadLine(), out MansChoiseHit);
                if (MansChoiseProtect != PcChoiseHit)
                {
                    ++PcScore;
                }

                if (MansChoiseHit != PcChoiseProtect)
                {
                    ++MansScore;
                }
                Console.WriteLine($"Счёт: Вы: {MansScore} | ПК: {PcScore}");
                Dif = Math.Abs(MansScore - PcScore);
            }
            while ((MansScore < 5 && PcScore < 5) || Dif < 2) ;

            Console.WriteLine($"Вы {(MansScore > PcScore? "выиграли" : "проиграли")}!");
        }
    }
}

