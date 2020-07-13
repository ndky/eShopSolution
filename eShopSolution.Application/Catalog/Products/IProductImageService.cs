using eShopSolution.ViewModels.Catalog.Product;
using eShopSolution.ViewModels.Common;
using System.Threading.Tasks;

namespace eShopSolution.Application.Catalog.Products
{
    public interface IProductImageService
    {
        Task<int> Create(ProductCreateRequest request);

        Task<int> Update(ProductUpdateRequest request);

        Task<int> Delete(int productId);

        Task<bool> UpdatePrice(int productId, decimal newPrice);

        Task<bool> UpdateStock(int productId, decimal addedQuantity);

        Task AddViewCount(int productId);

        Task<PagedResult<ProductViewModel>> GetAllPaging(GetManageProductPagingRequest request);
    }
}