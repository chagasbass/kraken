using System;

namespace KRAKEN.Core.ValidacoesDeDominio.Testes.EntidadesDeTeste
{
    /// <summary>
    /// Entidade para testes unitarios
    /// </summary>
    public class EntidadeDeTiposTeste
    {
        public bool BoolProp { get; set; }
        public decimal DecimalProp { get; set; }
        public double DoubleProp { get; set; }
        public float FloatProp { get; set; }
        public int IntProp { get; set; }
        public long LongProp { get; set; }
        public object ObjetoProp { get; set; }
        public string StringProp { get; set; }
        public DateTime DateTimeProp { get; set; }
        public DateTime? NullableDateTimeProp { get; set; }
        public Guid GuidProp { get; set; }
        public TimeSpan TimeSpanProp { get; set; }
        public int? NullableIntProp { get; set; }
        public decimal? NullableDecimalProp { get; set; }
        public double? NullableDoubleProp { get; set; }
        public float? NullableFloatProp  { get; set; }
        public long? NullableLongProp { get; set; }

        public EntidadeDeTiposTeste()
        {

        }
    }
}
