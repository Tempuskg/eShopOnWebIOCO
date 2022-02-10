namespace Microsoft.eShopWeb.Web.Catalog;

public interface ICatalogItemViewModelService
{
    Task UpdateCatalogItem(CatalogItemViewModel viewModel);
}
