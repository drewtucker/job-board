using System.Collections.Generic;
namespace JobBoard.Models
{
   public class Contact
  {
    private string _contactName;
    private string _contactNumber;

    public Contact(string name, string number)
    {
      _contactName = name;
      _contactNumber = number;
    }

    public string GetContactName()
    {
      return _contactName;
    }

    public void SetContactName(string name)
    {
      _contactName = name;
    }

    public string GetContactNumber()
    {
      return _contactNumber;
    }

    public void SetContactNumber(string number)
    {
      _contactNumber = number;
    }
  }
}
