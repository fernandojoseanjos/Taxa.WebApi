using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Taxa.Application.Dto;

namespace Taxa.Application.UseCases
{
    public class TaxaUseCase : ITaxaUseCase
    {
        public TaxaDto Execute()
        {
            var taxa = new TaxaDto();

            return taxa;
        }
    }
}
