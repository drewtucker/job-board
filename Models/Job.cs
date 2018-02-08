using System.Collections.Generic;
namespace JobBoard.Models
{
   class Job
  {
    private string _title;
    private string _description;
    private static Dictionary<string, string> _contact = new Dictionary<string, string>(){};

    public string GetTitle()
    {
      return _title;
    }

    public void SetTitle(string newTitle)
    {
      _title = newTitle;
    }

    public string GetDescription()
    {
      return _description;
    }

    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }

    public string GetContact()
    {
      return _contact
    }

    public void SetContact(string newContact)
    {
      _contact = newContact;
    }
  }
}
