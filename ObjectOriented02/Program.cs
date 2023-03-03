using ObjectOriented02;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Employee1 object information");
        Employee employee1 = new Employee();
        employee1.GetData();
        employee1.PutData();

        Console.WriteLine("Employee2 object information");
        Employee employee2 = new Employee();
        employee2.GetData();
        employee2.PutData();




        //CreateDemoObject();


    }  

    public static void CreateDemoObject()
    {

        //Employee object1;  //this is "class variable" not an object bcz memory is not allocated for this

        Employee object1 = new Employee();   //  "instance of the class & memory is initialized.

        object1.Id = 10;              // Assigning values to properties which are into the Employee class
        object1.Name = "Amit";
        object1.Address = "Pune";

        //now printing the information

        //Console.WriteLine($"Object1 information Id ={object1.Id}");
        Console.WriteLine("Object1 information Id = " + object1.Id); // object name dot member name
        Console.WriteLine("Name = " + object1.Name);
        Console.WriteLine("Address = " + object1.Address);





        Employee object2;          // class variable
        object2 = new Employee();  // class instance

        object2.Id = 20;
        object2.Name = "Sumit";
        object2.Address = "Mumbai";

        Console.WriteLine("Object2 information Id = " + object2.Id);
        Console.WriteLine("Name = " + object2.Name);
        Console.WriteLine("Address = " + object2.Address);



        Employee employee = new Employee();

        Console.WriteLine("Please enter the value for employee Id = ");
        employee.Id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please enter the value for employee Name = ");
        employee.Name = Console.ReadLine();

        Console.WriteLine("Please enter the value for employee Address = ");
        employee.Address = Console.ReadLine();


        Console.WriteLine("Employee information Id = " + employee.Id);
        Console.WriteLine("Name = " + employee.Name);
        Console.WriteLine("Address = " + employee.Address);

    }
}