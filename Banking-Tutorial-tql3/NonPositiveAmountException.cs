using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Tutorial_tql3;
internal class NonPositiveAmountException : Exception 
{
    public NonPositiveAmountException() : base() {}
    public NonPositiveAmountException(string message) : base(message) {}
    public NonPositiveAmountException(string message, Exception exception) : base(message, exception) {}
}


