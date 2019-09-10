using YangWei.BookStore.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace YangWei.BookStore
{
    [DependsOn(
        typeof(BookStoreEntityFrameworkCoreTestModule)
        )]
    public class BookStoreDomainTestModule : AbpModule
    {

    }
}