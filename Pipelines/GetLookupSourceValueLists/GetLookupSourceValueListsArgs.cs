using System.Collections.Specialized;
using Sitecore.Pipelines;

namespace Sitecore.SharedSource.ValueListField.Pipelines.GetLookupSourceValueLists
{
    public class GetLookupSourceValueListsArgs : PipelineArgs
    {
        public StringCollection Result { get; } = new StringCollection();

        public string Source { get; set; }
    }
}
