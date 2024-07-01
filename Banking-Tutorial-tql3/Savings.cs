using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Tutorial_tql3;

public class Savings : Account {

    public decimal IntRate { get; set; } = 0.12m;

    public void CalcAndPayInterest(int NbrOfMonths) {
        decimal Interest = Balance * (IntRate / 12) * NbrOfMonths;
        Deposit(Interest);
    }

    public Savings(string description) : base(description) { 
    }

}
