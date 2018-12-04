using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using WorldData.Models;

namespace WorldData.Tests
{
  [TestClass]
  public class CountryTests
  {
    [TestMethod]
    public void GetCode_ReturnsCityCode_String()
    {
      Country newCountry = new Country("testCode", "testName", "testContinent");

      Assert.AreEqual("testCode", newCountry.GetCode());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      Country newCountry = new Country("testCode", "testName", "testContinent");

      Assert.AreEqual("testName", newCountry.GetName());
    }


    [TestMethod]
    public void GetContinent_ReturnsContinent_String()
    {
      Country newCountry = new Country("testCode", "testName", "testContinent");

      Assert.AreEqual("testContinent", newCountry.GetContinent());
    }

    [TestMethod]
    public void GetAllCities_ReturnsCities_CityList()
    {
      Country newCountry = new Country("testCode", "testName", "testContinent");
      List<City> expectedListOfCities = new List<City>{};

      List<City> allCities = newCountry.GetAllCities();

      CollectionAssert.AreEqual(expectedListOfCities, allCities);
    }

    [TestMethod]
    public void AddCity_AssociatesCityWithCountry_CityList()
    {
      City newCity = new City(3, "Mexico", "MEX", "sample district", 9);
      List<City> cityList =new List<City> { newCity };
      Country newCountry = new Country("MEX", "Mexico", "North America");
      newCountry.AddCity(newCity);

      List<City> allCities = newCountry.GetAllCities();

      CollectionAssert.AreEqual(cityList, allCities);
    }

  }
}
