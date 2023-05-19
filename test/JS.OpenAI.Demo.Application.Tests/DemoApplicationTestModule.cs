using Volo.Abp.Modularity;

namespace JS.OpenAI.Demo;

[DependsOn(
    typeof(DemoApplicationModule),
    typeof(DemoDomainTestModule)
    )]
public class DemoApplicationTestModule : AbpModule
{

}
