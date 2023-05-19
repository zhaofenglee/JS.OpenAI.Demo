using JS.OpenAI.Demo.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace JS.OpenAI.Demo;

[DependsOn(
    typeof(DemoEntityFrameworkCoreTestModule)
    )]
public class DemoDomainTestModule : AbpModule
{

}
