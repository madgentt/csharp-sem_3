using System;
using System.Collections.Generic;
using System.Text;

namespace pr_6
{
  public class Magazine
  {
    private string _name;
    private Frequency _frequency;
    private DateTime _datetime;
    private int _num;
    private List<Article> _articles ;
    
   public Magazine(string name, Frequency frequency, DateTime datetime, int num)
    {
      _name = name;
      _frequency = frequency;
      _datetime = datetime;
      _num = num;
      _articles = new List<Article>();
    }

    public Magazine()
    {
      _name = "name";
      _frequency = Frequency.Monthly ;
      _datetime = DateTime.Now;
      _num = 2222;
      _articles = new List<Article>();
    }

    public string Mag_Name
    {
      get => _name;
      set => _name = value;
    }

    public Frequency Frequency
    {
      get => _frequency;
      set => _frequency = value;
    }

    public DateTime DateTime
    {
      get => _datetime;
      set => _datetime = value;
    }

    public int num
    {
      get => _num;
      set => _num = value;
    }

    private List<Article> Articles
    {
      get => _articles ;
      set => _articles = value;
    }


  }
}
