namespace Pattern.Visitor.Interfaces
{
    public interface IVisitable
    {
        string Accept(IVisitor visitor);
    }
}
