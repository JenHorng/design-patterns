using System;

namespace DesignPatternSamples.Application.DTO
{
    [Serializable]

    public class pontosCarteira
    {
        public DateTime DataOcorrencia { get; set; }
        public string Descricao { get; set; }
        public double ValorMulta { get; set; }
        public int Pontos { get; set; }
    }

}