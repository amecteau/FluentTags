using System.Web.Mvc;

namespace FluentTags
{
    public class Tag
    {
        private TagBuilder _localBuilder;

        private Tag(string name) {
            _localBuilder = new TagBuilder(name);
        }
        public Tag BuildAs(string tagname) {  return  new Tag(tagname);  }

        public Tag AddInnerHTML(string innerHTML)
        {
            _localBuilder.InnerHtml = innerHTML;
            return this;
        }

        public Tag MergeAttribute(string attributeName, string attributeValue)
        {
            _localBuilder.MergeAttribute(attributeName, attributeValue);
            return this;
        }
    }
}
