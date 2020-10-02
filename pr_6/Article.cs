using pr_06;
using System;
using System.Collections.Generic;
using System.Text;

namespace pr_6
{
  class Article
  {
    public string Name { get; set; }
    public double Rating { get; set; }
    public Person PersonI { get; set; }
    public Article(string name, double rating, Person personI)
    {
      Name = name;
      Rating = rating;
      PersonI = personI;
    }

    public Article()
    {
      Name = "ArticleName";
      Rating = 5.0;
      PersonI.Name = "a";
      PersonI.Surname = "a";
      PersonI.BirthDate = DateTime.Now;

    }
    public override string ToString()
    {
      return Name + ": " + Rating + " " + PersonI.Name + " " + PersonI.Surname + " " + PersonI.BirthDate.ToString("dd/MM/yyyy");
    }



  }
}
