// See https://aka.ms/new-console-template for more information
abstract class Bank{
    public abstract void BankDetails();
    public abstract void Deposit();
    public abstract void Withdrawl();

    public void noofbank(){
          Console.WriteLine("Bank name:HDFC BANK");
    }
    
}
class Project : Bank {
    public override void BankDetails(){
        Console.WriteLine("Bank name: SBI BANK"); 
         Console.WriteLine("Location : Chennai"); 
         Console.WriteLine("Branch : Annanagar"); 
          }
           public override void Deposit() {
            Console.WriteLine("Deposit Money");
             }
             public override void Withdrawl() {
                Console.WriteLine("withdraw Money");
                 }
    }
    class Child {
         static void Main(string[]args){
            Project Mybank = new Project();
             Mybank.Deposit(); 
              Mybank.Withdrawl(); 
               }
    }