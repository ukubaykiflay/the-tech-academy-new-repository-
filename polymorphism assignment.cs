using polymorphism;
using System;
namespace polymorphism
{
	// define the IQuittable interface

	public interface IQuittable
	{
		void quit();
	}
	// class Employee implementing IQuittable
	public class Employee : IQuittable
	{ 
		public string Nane { get; set; }
		public void Quit()
 
	{
			Console.WriteLine($"{Name} has quit their job.");
	}
}
	// class manager implementing IQuittable
	public class Manager : IQuittable
	{
		public string Manager Name { get; set;}
	public void Quit()
		{
			Console.WriteLine($"{Manager Name} has done their job and quit.");
		}
	}
	 class Program
{
	static void Main(string[] args)
	{
		// polymorphism character 
		IQuittable employee = new Employee { Name = "Henry" };
		IQuittable manager = new Manager { ManagerName = "Adam" };
		employee.quit(); // Calls Employee's Quit method
		manager.quit(); // Calls Manager's Quit method
	}
}
}



