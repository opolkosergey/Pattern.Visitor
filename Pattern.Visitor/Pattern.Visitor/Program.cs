using System;
using Pattern.Visitor.VisitableElements;
using Pattern.Visitor.Visitors;

namespace Pattern.Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            var organization = new Organization
            {
                Name = "Microsoft"
            };

            var document = new Document
            {
                Title = "Agenda on 2017 year",
                Author = "B. Gates"
            };

            var jsonVisitor = new JsonVisitor();
            var beautifulTextVisitor = new BeautifulTextVisitor();

            Console.WriteLine(document.Accept(jsonVisitor));
            Console.WriteLine(document.Accept(beautifulTextVisitor));

            Console.WriteLine(organization.Accept(jsonVisitor));
            Console.WriteLine(organization.Accept(beautifulTextVisitor));

            Console.ReadKey();
        }
    }
}
