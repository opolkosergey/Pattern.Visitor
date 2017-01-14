using Pattern.Visitor.Interfaces;
using Pattern.Visitor.VisitableElements;

namespace Pattern.Visitor.Visitors
{
    public class BeautifulTextVisitor : IVisitor
    {
        public string VisitDocument(Document document)
        {
            return $"This is the document with {nameof(document.Title).ToLower()} \"{document.Title}\". " +
                   $"Details: the {nameof(document.Author).ToLower()} is {document.Author}.";
        }

        public string VisitOrganization(Organization organization)
        {
            return $"This is the organization with {nameof(organization.Name).ToLower()} \"{organization.Name}\".";
        }
    }
}
