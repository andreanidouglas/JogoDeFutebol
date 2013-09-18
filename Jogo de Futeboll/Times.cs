using System;

namespace Jogo_de_Futeboll
{
    class Times : IComparable<Times>
    {
        private int intForcaAtaque;

        public int forcaAtaque
        {
            get { return intForcaAtaque; }
            set { intForcaAtaque = value; }
        }
        private int intForcaDefesa;

        public int forcaDefesa
        {
            get { return intForcaDefesa; }
            set { intForcaDefesa = value; }
        }

        private String strNomeTime;

        public String NomeTime
        {
            get { return strNomeTime; }
            set { strNomeTime = value; }
        }
        private int intNumeroDePontos;

        public int NumeroDePontos
        {
            get { return intNumeroDePontos; }
            set { intNumeroDePontos = value; }
        }

        public double CoeficienteDePartida()
        {
            return (intForcaAtaque / 100.0) * (intForcaAtaque / 100.0) + 1;
        }
       
        public int CompareTo(Times obj)
        {
            if (obj == null) return 1;

            Times otherTime = obj as Times;
            if (otherTime != null)
                return this.intNumeroDePontos.CompareTo(otherTime.intNumeroDePontos);
            else
                throw new ArgumentException("Objeto Não é um Time");
        }

    }
}
