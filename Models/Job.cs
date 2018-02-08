using System.Collections.Generic;
namespace JobBoard.Models
{
   public class Job
  {
    private string _title;
    private string _description;
    private Contact _contact;
    private static List<Job> _jobInstances = new List<Job> {};

    public Job(string title, string description, Contact contact)
    {
      _title = title;
      _description = description;
      _contact = contact;
    }

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

    public Contact GetContact()
    {
      return _contact;
    }

    public void SaveJob()
    {
      _jobInstances.Add(this);
    }

    public static List<Job> AllJobs()
    {
      return _jobInstances;
    }

  }
}
