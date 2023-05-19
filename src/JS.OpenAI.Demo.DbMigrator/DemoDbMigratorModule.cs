using JS.OpenAI.Demo.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace JS.OpenAI.Demo.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(DemoEntityFrameworkCoreModule),
    typeof(DemoApplicationContractsModule)
    )]
public class DemoDbMigratorModule : AbpModule
{

}
