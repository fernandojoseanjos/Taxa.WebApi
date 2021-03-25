using System.Threading.Tasks;
using Taxa.Application.Dto;

namespace Taxa.Application.UseCases
{
    public interface ITaxaUseCase
    {
        TaxaDto Execute();
    }
}
