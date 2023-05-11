using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using MusicOrganizer.Models;
using System;

namespace MusicOrganizer.Tests
{
  [TestClass]
  public class RecordsTests
  {

    [TestMethod]
    public void RecordsConstructor_CreatesInstanceOfRecords_Records()
    {
      Records newRecords = new Records("test");
      Assert.AreEqual(typeof(Records), newRecords.GetType());
    }
      
    [TestMethod]
    public void Records_AddArtistToRecord_String()
{
    string artist = "John Lennon";
    string title = "Best Hits";
    Records newRecords = new Records();
    newRecords.AddArtist(artist, title);
    string resultArtist = newRecords.Artist;
    string resultTitle = newRecords.Title;
    Assert.AreEqual(artist, resultArtist);
    Assert.AreEqual(title, resultTitle);
}
    }
  }
