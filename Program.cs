// See https://aka.ms/new-console-template for more information
abstract class Hospital{
    public abstract void HospitalDetails();
    public abstract void PatientDetails();
}
class Details : Hospital{
    public override void HospitalDetails()
    {
        Console.WriteLine("Hospital name:kk hospital");
        Console.WriteLine("hospital location:thanjavur");
    }

  

    public override void PatientDetails(){
        Console.WriteLine("patient name:Abirami");
        Console.WriteLine("patient contactno:1234567891");
    }
}

  
class Implementation{
    public static void Main(string[] args){
        Details Ref=new Details();
        Ref.HospitalDetails();
        Ref.PatientDetails();
    }
}