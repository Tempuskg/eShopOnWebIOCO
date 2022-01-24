using Microsoft.eShopWeb.ApplicationCore.Entities.BasketAggregate;
using Microsoft.eShopWeb.Web.Basket;

namespace Microsoft.eShopWeb.Web.Interfaces;

public interface IBasketViewModelService
{
    Task<BasketViewModel> GetOrCreateBasketForUser(string userName);
    Task<int> CountTotalBasketItems(string username);
    Task<BasketViewModel> Map(ApplicationCore.Entities.BasketAggregate.Basket basket);
}
