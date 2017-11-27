using System.Linq;
using Sitecore;
using Sitecore.Data.Managers;
using SitecoreHacker.Foundation.ValueListField.Abstraction;
using SitecoreHacker.Foundation.ValueListField.Data;
using SitecoreHacker.Foundation.ValueListField.Pipelines.GetLookupSourceValueLists;

namespace SitecoreHacker.Foundation.ValueListField.Fields.Datasources
{
    [UsedImplicitly]
    public class Language : IValueList
    {
        public string[] ValueListQuery()
        {
            var langs = LanguageManager.GetLanguages(Context.Database);
            return langs.Select(lang => lang.Name).ToArray();
        }
    }
}
