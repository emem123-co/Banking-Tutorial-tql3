namespace Banking_Tutorial_tql3;

internal class Program {

    static void Main(string[] args) {

        var a1 = new Savings("Savings1");
        var a2 = new Savings("Savings2");

        Console.WriteLine($"Balance is {a1.Balance:C}");
        a1.Deposit(500);
        Console.WriteLine($"Balance is {a1.Balance:C}");
        a1.Withdraw(230);
        Console.WriteLine($"Balance is {a1.Balance:C}");
        
        try /* how to handle exceptions. using a try catch block. best practice to place try catch blocks as close to the exception trigger as possible*/
        {
        a1.Withdraw(300);
        Console.WriteLine($"Balance is {a1.Balance:C}");
        a1.Deposit(-200);
        Console.WriteLine($"Balance is {a1.Balance:C}");
        } catch(InsufficientFundsException ex)
            {
            Console.WriteLine($"Balance is {ex.Balance}, Amount is {ex.Amount}. Insufficient Funds!");
            }
          catch(NonPositiveAmountException ex)
            {
            Console.WriteLine("Non positive amount error!");
            }
          catch(Exception)
            {
            Console.WriteLine("An exception has occured!");
            }
        

        a1.Transfer(100, a2); /* do not need a try catch here because the Transfer method calls the deposit/withdraw methods which throw the exceptions already.*/

        a2.Transfer(50, a1);

        Console.WriteLine($"Balance is {a1.Balance:C}");
        a1.CalcAndPayInterest(1);
        Console.WriteLine($"Balance is {a1.Balance:C}");

    }
}
