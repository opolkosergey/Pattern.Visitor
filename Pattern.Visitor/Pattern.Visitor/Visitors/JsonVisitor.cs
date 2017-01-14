using Newtonsoft.Json;
using Pattern.Visitor.Interfaces;
using Pattern.Visitor.VisitableElements;

namespace Pattern.Visitor.Visitors
{
    public class JsonVisitor : IVisitor
    {
        public string VisitDocument(Document document)
        {
            return Json(document);
        }

        public string VisitOrganization(Organization organization)
        {
            return Json(organization);
        }

        private string Json(object item)
        {
            return JsonConvert.SerializeObject(item);
        }
    }
}
