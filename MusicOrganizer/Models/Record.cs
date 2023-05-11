using System.Collections.Generic;

namespace MusicOrganizer.Models
{
  public class Records
  {
    public string Title { get; set; }
    public string Artist { get; set; }
    private static List<Records> _instances = new List<Records> { };

    public Records(string title, string artist)
    {
      Title = title;
      Artist = artist;
    }

    public Records(string v)
    {
    }

    public static List<Records> GetAll()
    {
      return _instances;
    }
  }
}