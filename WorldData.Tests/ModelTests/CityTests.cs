using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using WorldData.Models;

namespace WorldData.Tests
{
  [TestClass]
  public class CityTests
  {
    [TestMethod]
    public void GetCityId_ReturnsCityId_Int()
    {
      City newCity = new City(1, "testName", "testCode", "testDistrict", 2);

      Assert.AreEqual(1, newCity.GetCityId());
    }

    [TestMethod]
    public void GetName_ReturnsCityName_String()
    {
      City newCity = new City(1, "testName", "testCode", "testDistrict", 2);

      Assert.AreEqual("testName", newCity.GetName());
    }

    [TestMethod]
    public void GetCountryCode_ReturnsCountryCode_String()
    {
      City newCity = new City(1, "testName", "testCode", "testDistrict", 2);

      Assert.AreEqual("testCode", newCity.GetCountryCode());
    }


    [TestMethod]
    public void GetDistrict_ReturnsDistrict_String()
    {
      City newCity = new City(1, "testName", "testCode", "testDistrict", 2);

      Assert.AreEqual("testDistrict", newCity.GetDistrict());
    }

    [TestMethod]
    public void GetPopulation_ReturnsPopulation_Int()
    {
      City newCity = new City(1, "testName", "testCode", "testDistrict", 2);

      Assert.AreEqual(2, newCity.GetPopulation());
    }

  }
}
