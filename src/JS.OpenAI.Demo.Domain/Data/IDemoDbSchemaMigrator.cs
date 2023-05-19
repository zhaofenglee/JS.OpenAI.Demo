using System.Threading.Tasks;

namespace JS.OpenAI.Demo.Data;

public interface IDemoDbSchemaMigrator
{
    Task MigrateAsync();
}
