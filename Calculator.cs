using CalculatorApi.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using System;
using System.Threading.Tasks;

namespace CalculatorApi
{
    public class Calculator : IController
    {
        public Task<ApiResponse> SetCalculatedAsync(double valueA, double valueB, Op op)
        {
            return Task.Run(() =>
            {
                var temp = new ApiResponse();
               
                switch (op)
                {
                    case Op.Minus:
                        temp.Result = valueA - valueB;
                        break;
                    case Op.Plus:
                        temp.Result = valueA + valueB;
                        break;
                    case Op.Multiply:
                        temp.Result = valueA * valueB;
                        break;
                    case Op.Divide:
                        temp.Result = valueA / valueB;
                        break;
                        default: throw new ArgumentOutOfRangeException(nameof(op));
                }
                // TODO validate valueB not zero in Divide
                return temp;
            });
        }

       
    }
}
