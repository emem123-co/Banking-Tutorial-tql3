using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Tutorial_tql3;
public class InsufficientFundsException : Exception
{

    //properties to hold more data within the exception
    public decimal Balance {get; set;} 
    public decimal Amount {get; set;}

    // 3 constructors in every exception
    public InsufficientFundsException() : base() {} //default constructor
    public InsufficientFundsException(string message) : base(message) {} //constructor that takes a string
    public InsufficientFundsException(string message, Exception exception) : base(message, exception) {}} //constructor that takes a string AND a base


