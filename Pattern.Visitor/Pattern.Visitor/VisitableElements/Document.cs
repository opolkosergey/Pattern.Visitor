using Pattern.Visitor.Interfaces;

namespace Pattern.Visitor.VisitableElements
{
    public class Document : IVisitable
    {
        public string Author { get; set; }

        public string Text { get; set; }

        public string Title { get; set; }

        public string Approver { get; set; }

        public string Accept(IVisitor visitor)
        {
            return visitor.VisitDocument(this);
        }
    }
}
