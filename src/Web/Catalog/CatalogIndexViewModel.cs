using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.eShopWeb.Web.ViewModels;

namespace Microsoft.eShopWeb.Web.Catalog;

public class CatalogIndexViewModel
{
    public List<CatalogItemViewModel> CatalogItems { get; set; }
    public List<SelectListItem> Brands { get; set; }
    public List<SelectListItem> Types { get; set; }
    public int? BrandFilterApplied { get; set; }
    public int? TypesFilterApplied { get; set; }
    public PaginationInfoViewModel PaginationInfo { get; set; }
}
