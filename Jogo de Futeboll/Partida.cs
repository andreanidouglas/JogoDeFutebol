using System;
using System.Collections;
using System.Collections.Generic;

namespace Jogo_de_Futeboll
{
    class Partida
    {
        public Times IniciarPartida(Times timeCasa, Times timeVisitante)
        {
            double CoeficienteJogo = (new Random().NextDouble() * timeCasa.CoeficienteDePartida())-timeVisitante.CoeficienteDePartida();
            int CoeficieteDeSorte = new Random().Next(10);
            if ((CoeficieteDeSorte * CoeficienteJogo) % 3 == 0)
            {
                return timeCasa;
            }
            if ((CoeficieteDeSorte * CoeficienteJogo) % 3 == 1) 
                return timeVisitante;
            return new Times();
        }
        public Times Campeonato(List<Times> times)
        {
            List<Times> TimesB = new List<Times>();
           
            Times TimeVencedor;
            for (int i = times.Count / 2; i < times.Count; i++)
            {
                TimesB.Add(times[i]);
                times.Remove(times[i]);
            }
            for (int i = 0; i < times.Count; i++)
            {
                for (int j = TimesB.Count - 1; j >= 0; j--)
                {
                    TimeVencedor = IniciarPartida(times[i], TimesB[j]);
                    if (TimeVencedor.NomeTime == "")
                    {
                        times[i].NumeroDePontos++;
                        TimesB[j].NumeroDePontos++;
                    }
                    else
                    {
                        TimeVencedor.NumeroDePontos = TimeVencedor.NumeroDePontos+3;
                    }
                }
            }
            TimesB.Sort();
            times.Sort();
            if (times[times.Count - 1].NumeroDePontos > TimesB[TimesB.Count - 1].NumeroDePontos)
            {
                return times[times.Count - 1];
            }
            return TimesB[TimesB.Count - 1];
        }
    }
}
