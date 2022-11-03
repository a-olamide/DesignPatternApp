namespace FactoryPattern
{
    public interface ICalculate
    {
        void Calculate(double a, double b);
    }
    public class Divide : ICalculate
    {
        public void Calculate(double a, double b)
        {
            Console.WriteLine("a/b is {0}", a / b);
        }
    }

    

    public class Add : ICalculate
    {
        public void Calculate(double a, double b)
        {
            Console.WriteLine("a+b is {0}", a + b);
        }
    }

    public class Subtract : ICalculate
    {
        public void Calculate(double a, double b)
        {
            Console.WriteLine("a-b is {0}", a - b);
        }
    }

    public class CalculateFactory
    {
        public ICalculate GetCalculation(string type)
        {
            ICalculate calculation = null;
            if(type.ToLower().Equals("add"))
            {
                calculation = new Add();
            }
            else if (type.ToLower().Equals("subtract"))
            {
                calculation = new Subtract();
            }
            else if (type.ToLower().Equals("divide"))
            {
                calculation = new Divide();
            }
            else
            {
                Console.WriteLine("We don't have this function");
            }
            return calculation;
        }
    }

}