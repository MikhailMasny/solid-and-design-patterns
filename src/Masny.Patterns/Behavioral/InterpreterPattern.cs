using System;
using System.Collections;

namespace Masny.Patterns.Behavioral.Interpreter
{
    class Context
    {
    }

    interface IExpression
    {
        void Interpret(Context context);
    }

    class TerminalExpression : IExpression
    {
        public void Interpret(Context context)
        {
            Console.WriteLine($"Called {nameof(TerminalExpression)}.{nameof(Interpret)}()");
        }
    }

    class NonterminalExpression : IExpression
    {
        public void Interpret(Context context)
        {
            Console.WriteLine($"Called {nameof(NonterminalExpression)}.{nameof(Interpret)}()");
        }
    }

    public class InterpreterPattern
    {
        public void Start()
        {
            var context = new Context();

            var list = new ArrayList
            {
                new TerminalExpression(),
                new NonterminalExpression(),
                new TerminalExpression(),
                new TerminalExpression()
            };

            foreach (IExpression exp in list)
            {
                exp.Interpret(context);
            }
        }
    }
}
