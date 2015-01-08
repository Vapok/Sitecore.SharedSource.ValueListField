using System.Linq;
using Sitecore.SharedSource.ValueListField.Pipelines.GetLookupSourceValueLists;
using Sitecore.Sites;

namespace Sitecore.SharedSource.ValueListField.Fields.Datasources
{
    [UsedImplicitly]
    internal class Inherits : IValueList
    {
        public string[] ValueListQuery()
        {
            return SiteManager.Provider.GetSites().Select(site => site.Name).ToArray();
        }
    }
}
