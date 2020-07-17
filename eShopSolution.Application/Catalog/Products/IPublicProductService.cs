using eShopSolution.ViewModels.Catalog.Product;
using eShopSolution.ViewModels.Common;
using System.Threading.Tasks;

namespace eShopSolution.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllbyCategoryId(string languageId, GetPublicProductPagingRequest request);
    }
}