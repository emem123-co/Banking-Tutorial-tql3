using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Tutorial_tql3;

public class Account {

    private static int nextId { get; set; } = 1;

    public int AccountId { get; set; } = 0;
    public string Description { get; set; } = string.Empty;
    public decimal Balance { get; set; } = 0;

    public bool Deposit(decimal Amount) {
        if(Amount <= 0) {
            throw new NonPositiveAmountException();
            /* removing this because we added the exception, so this is no longer needed return false; */
        }
        Balance += Amount;
        return true;
    }

    public bool Withdraw(decimal Amount) {
        if(Amount <= 0) {
            throw new NonPositiveAmountException();
        }
        if(Amount > Balance) {
            Console.WriteLine("Insufficient Funds!");
            return false;
        }
        Balance -= Amount;
        return true;
    }

    public bool Transfer(decimal Amount, Account ax) {
        var success = this.Withdraw(Amount);
        if(success == true) {
            ax.Deposit(Amount); /* do not need to throw an exception here because the Transfer method calls the Deposit/Withdraw methods which throw the exceptions already.*/
        }
        return true;
    }

    public Account(string description) {
        AccountId = nextId++;
        Description = description;
        Balance = 0;
    }
}
