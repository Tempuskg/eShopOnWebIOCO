namespace Microsoft.eShopWeb.Web.Basket;

public interface IBasketViewModelService
{
    Task<BasketViewModel> GetOrCreateBasketForUser(string userName);
    Task<int> CountTotalBasketItems(string username);
    Task<BasketViewModel> Map(ApplicationCore.Entities.BasketAggregate.Basket basket);
}
