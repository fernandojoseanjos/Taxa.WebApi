namespace Taxa.Application.Dto
{
   public class TaxaDto
    {
        private decimal taxaJuros;
        public decimal TaxaJuros
        {
            get { return taxaJuros; }
            set { taxaJuros = value; }
        }

        public TaxaDto()
        {
            this.taxaJuros = 0.01M;
        }
    }
}
