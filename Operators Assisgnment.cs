using System;
namespace operator assignment 

public class  Employee
{
	public int Id { get; set; }
	public string fistName { get; set; }
	public string lastName { get; set; }
	//Manager
	public Employee(int id, string fistName, string lastName)
	{
		Id = id;
		fistName = fistName;
		lastName = lastName;
	}
	//Overloading the ==operator 
	public static bool operator ==(Employee emp1, Employee emp2)
	{
		if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
			return ReferenceEquals(emp1, emp2);
		return emp1.Id == emp2.Id;
	}
	// Overloading the != Operator(must be paired with ==)
	public static bool operator !=(Employee emp1, Employee emp2)
	{
		return !(emp1 == emp2);
	}
	// Overriding Equals and GetHashCode for consistency
	public override bool Equals(object obj)
	{
		if (obj is Employee other)
		{
			return this.Id == other.Id:
				retun false;
		}
		public override int GetHashCode()
	{
		return Id.GetHashCode();
	}
	// Display method
	public void Display()
	{
		Console.WriteLine($"ID: {Id}, FirstName:{FrstName}, LastName: {FirstName}");
	}
	class program
	{
		static void Main()
		{
			Employee emp1 = new Employee(1, "henry, Abraham");
			Employee emp2 = new Employee(2, "Adam, William");
			Employee emp3 = new Employee(1, "Henry, Abraham");
			emp1.Display();
			emp2.Display();
			// Comparing employees Using Overloaded Operators
			Console.WriteLine(emp1 == emp2);// False
			Console.WriteLine(emp1 == emp3); // true
	}


	}
}
