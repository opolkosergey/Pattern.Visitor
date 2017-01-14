using Pattern.Visitor.Interfaces;

namespace Pattern.Visitor.VisitableElements
{
    public class Organization : IVisitable
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public string Accept(IVisitor visitor)
        {
            return visitor.VisitOrganization(this);
        }
    }
}
