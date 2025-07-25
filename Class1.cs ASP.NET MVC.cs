

using system;
using system. Ling;
using system, Web.Mvc;
using Car_ Insurance. Models;

namespace Car_ Insurance.Controllers
{
	public class InsureeController : controller
{
    private InsuranceEntities db = new InsuranceEntities();
    // Get: Insuree
    public ActionResult Index()
    {
        retun view(db.Insurees.ToList());
    }
    // Post : Calculate Quote[HttpPost]
    public ActionResult CalculateQuote(int id)
    {
        var insuree = db.Insurees.find(id);
        if (insuree == null)
        {
            return HttpNotFound();
        }
        // Bass monthly total
        decimal monthlyTotal = 50;
        // Calculate age
        int age = DateTime.Now.Year - insuree.DateOfBirth.Year;
        if (insuree.DateOfBirth > DateTime.Now.AddYears(-age)) age--;
        // Add to monthly total based on age
        if (age <= 18)
        {
            monthlyTotal += 100;
        }
        else if (age >= 19 && age <= 25)
        {
            monthlyTotal += 50;
        }
        else if (age >= 26)
        {
            monthlyTotal += 25;
        }
        // Add to monthly total based on car year
        if (insuree.CarYear < 2000)
        {
            monthlyTotal += 25;
        }
        else if (insuree.CarYear > 2015)
        {
            monthlyTotal += 25;
        }
        // Add to monthly total based on car make 
        if (insuree.CarMake.Equals("Porsche, StringComparison.OrdinalIgnoreCase"))
        {
            monthlyTotal += 25;
        }
        // save the calculated quote
        insuree.Quote = monthlyTotal;
        db.saveChanges();
        return redirectToAction("Index");
    }
}
}

            
        }





            ;
        }
    }
}

            
            




        
        
   
        
        
    }

}
}

}

	






