// See https://aka.ms/new-console-template for more information
using _23解释器模式;

Content content=new Content();
IList<AbstractExpression> list=new List<AbstractExpression>();
list.Add(new TerminalExpression());
list.Add(new NonterminalExpression());
list.Add(new TerminalExpression());
list.Add(new TerminalExpression());
foreach (AbstractExpression exp in list)
{
    exp.Interpret(content);
}
Console.WriteLine("Hello, World!");
