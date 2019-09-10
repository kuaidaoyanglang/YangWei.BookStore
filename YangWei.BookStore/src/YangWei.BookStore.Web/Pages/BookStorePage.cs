using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using YangWei.BookStore.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace YangWei.BookStore.Web.Pages
{
    /* Inherit your UI Pages from this class. To do that, add this line to your Pages (.cshtml files under the Page folder):
     * @inherits YangWei.BookStore.Web.Pages.BookStorePage
     */
    public abstract class BookStorePage : AbpPage
    {
        [RazorInject]
        public IHtmlLocalizer<BookStoreResource> L { get; set; }
    }
}
