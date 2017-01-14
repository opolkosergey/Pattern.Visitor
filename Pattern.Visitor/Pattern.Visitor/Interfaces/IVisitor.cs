using Pattern.Visitor.VisitableElements;

namespace Pattern.Visitor.Interfaces
{
    public interface IVisitor
    {
        string VisitDocument(Document document);
        string VisitOrganization(Organization organization);
    }
}
