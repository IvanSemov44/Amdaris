
namespace InterpreterDesignPattern
{
    public class SeperatorExpression : AbstractExpression
    {
        public void Evaluate(Context context)
        {

            string expression = context.Expression;
            context.Expression = expression.Replace(" ", "-");
        }
    }
}
