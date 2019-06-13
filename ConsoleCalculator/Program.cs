using System;
using System.Collections.Generic;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var ui = new UserInterface();
            var service = new CalculateService();
            double result = 0;

            ui.ShowMenuOperator();
            ui.ShowInputNumbers();
            char operators = ui.GetOperator();
            List<double> listNumbers = ui.GetListInputNumbers();
            if(listNumbers.Count < 2)
            {
                ui.Inform("Not enough numbers to calculate!");
            }
            else
            {
                switch (operators)
                {
                    case '+':
                        result = service.Add(listNumbers);
                        ui.ShowResult(result, operators, listNumbers);
                        break;
                    case '-':
                        result = service.Sub(listNumbers);
                        ui.ShowResult(result, operators, listNumbers);
                        break;
                    case '*':
                        result = service.Mul(listNumbers);
                        ui.ShowResult(result, operators, listNumbers);
                        break;
                    case '/':
                        result = service.Div(listNumbers);
                        ui.ShowResult(result, operators, listNumbers);
                        break;
                }
            }
        }
    }
}
