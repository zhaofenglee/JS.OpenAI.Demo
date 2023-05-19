using JS.OpenAI.Demo.Localization;
using Volo.Abp.AspNetCore.Components;

namespace JS.OpenAI.Demo.Blazor;

public abstract class DemoComponentBase : AbpComponentBase
{
    protected DemoComponentBase()
    {
        LocalizationResource = typeof(DemoResource);
    }
}
