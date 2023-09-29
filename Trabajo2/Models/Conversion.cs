namespace Trabajo2.Models
{
    public class Conversion
    {
        public decimal PesoMx { get; } = 18;
        public decimal PesoAm { get; set; }
        public decimal Resultado { get; set; }
        public TipoDeConversion TipoConversion { get; set; }
    }
}

