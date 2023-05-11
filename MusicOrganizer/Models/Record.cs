using System;
using System.Collections.Generic;

namespace MusicOrganizer.Models
{
  public class Records
  {
    public string Artist { get; private set; }
    public string Title { get; private set; }
    public int Id { get; }
    private static List<Records> _instances = new List<Records> { };

    public Records(string title, string artist)
    {
      Title = title;
      Artist = artist;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Records> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    
  }
}