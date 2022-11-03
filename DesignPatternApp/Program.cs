// See https://aka.ms/new-console-template for more information
using DesignPatternApp;
using FactoryPattern;
using Momento.Undo;
using SingletonPriciple;
using StatePattern;
using StatePattern.Tool;
using TemplateMethodPattern;
using Canvas = StatePattern.Tool.Canvas;

public class program
{
    static TableServers host1List = TableServers.GetTableServers();
    static TableServers host2List = TableServers.GetTableServers();
    public static void Main(string[] args)
    {
        //send email to employee
        //IEmail email = new OutlookEmail();
        //Employee emp = new Employee(100, "Ola", email);
        //emp.salary = 1000000;
        //emp.NotifyEmployee();

        //email = new WebServiceEmail();
        //Employee emp2 = new Employee(200, "BOla", email);
        //emp2.salary = 1000000;
        //emp2.NotifyEmployee();

        //Factory Pattern test B4
        Console.WriteLine("Enter first number");
        string input = Console.ReadLine();
        double num1, num2;
        bool result = Double.TryParse(input, out num1);
        if (!result)
        {
            Console.WriteLine("Please enter a number");
            return;
        }
        Console.WriteLine("Enter second number");
        result = Double.TryParse(Console.ReadLine(), out num2);
        if (!result)
        {
            Console.WriteLine("Please enter a number");
            return;
        }
        
        //Factory Pattern test After application
        Console.WriteLine("Enter Add, Subtract or Divide");
        CalculateFactory factory = new CalculateFactory();
        ICalculate cal = factory.GetCalculation(Console.ReadLine());
        cal.Calculate(num1, num2);
        //var editor = new Editor();
        //var history = new History();

        //editor.setContent("a");
        //history.Push(editor.createState());

        //editor.setContent("b");
        //history.Push(editor.createState());

        //editor.setContent("c");
        //editor.Restore(history.Pop());
        //editor.Restore(history.Pop());

        //Console.WriteLine(editor.getContent());

        //var canvas = new Canvas();
        //canvas.SetCurrentTool(new SelectionTool());
        //canvas.MouseDown();
        //canvas.MouseUp();



        //for (int i= 0; i < 10; i++)
        //{
        //    Host1GetNextServer();
        //    Host2GetNextServer();
        //}

        //Template Pattern method
        DataProcessor data = new ExcelFile();
        data.ReadProcessAndSave();

        
    }
    private static void Host1GetNextServer()
    {
        Console.WriteLine("Next Server for Host 1 is :" + host1List.GetNextServer());

    }
    private static void Host2GetNextServer()
    {
        Console.WriteLine("Next Server for Host 2 is :" + host2List.GetNextServer());
    }
}
