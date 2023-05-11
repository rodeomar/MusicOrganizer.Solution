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
    }
  }
