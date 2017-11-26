using System.Linq;
using Sitecore;
using Sitecore.Sites;
using SitecoreHacker.Foundation.ValueListField.Abstraction;
using SitecoreHacker.Foundation.ValueListField.Data;
using SitecoreHacker.Foundation.ValueListField.Pipelines.GetLookupSourceValueLists;

namespace SitecoreHacker.Foundation.ValueListField.Fields.Datasources
{
    [UsedImplicitly]
    internal class Inherits : IValueList
    {
        public string[] ValueListQuery()
        {
            var sites = SiteManager.GetSites().Select(site => site.Name).ToArray();
            return sites;
        }
    }
}
