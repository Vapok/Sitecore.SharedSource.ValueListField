using System.Linq;
using Sitecore;
using Sitecore.Configuration;
using Sitecore.Data;
using SitecoreHacker.Foundation.ValueListField.Pipelines.GetLookupSourceValueLists;

namespace SitecoreHacker.Foundation.ValueListField.Fields.Datasources
{
    [UsedImplicitly]
    public class Databases : IValueList
    {
        public string[] ValueListQuery()
        {
            return (from databaseName in Factory.GetDatabaseNames() let db = Database.GetDatabase(databaseName) where db.HasContentItem select databaseName).ToArray();
        }
    }
}
