using System.Collections.Generic;
using System.Linq;
using Sitecore.Diagnostics;
using Sitecore.StringExtensions;

namespace Sitecore.SharedSource.ValueListField.Pipelines.GetLookupSourceValueLists
{
    internal class DelimitedListSource
    {
        [UsedImplicitly]
        public void Process(GetLookupSourceValueListsArgs args)
        {
            Assert.ArgumentNotNull(args, "args");

            if (args.Source.IsNullOrEmpty()) return;

            var values = new List<string>(args.Source.Split('|').Select(x => x.Trim()));
            if (values.Count > 0)
                args.Result.AddRange(values.ToArray());
        }
    }
}
