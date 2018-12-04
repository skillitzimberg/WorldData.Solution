using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using WorldData.Models;

namespace WorldData.Tests
{
  [TestClass]
  public class LanguageTests
  {
    [TestMethod]
    public void GetCode_ReturnsLanguageCode_String()
    {
      Language newLanguage = new Language("testCode", "testLanguage", true);

      Assert.AreEqual("testCode", newLanguage.GetCode());
    }

    [TestMethod]
    public void GetLanguage_ReturnsLanguage_String()
    {
      Language newLanguage = new Language("testCode", "testLanguage", true);

      Assert.AreEqual("testLanguage", newLanguage.GetLanguage());
    }

    [TestMethod]
    public void IsOfficial_ReturnsIsOfficial_Bool()
    {
      Language newLanguage = new Language("testCode", "testLanguage", true);

      Assert.AreEqual(true, newLanguage.IsOfficial());
    }
    
    // public static List<Language> GetAll()
    // {
    //   List<Language> allLanguages = new List<Language> {};
    //   MySqlConnection conn = DB.Connection();
    //   conn.Open();
    //   MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
    //   cmd.CommandText = @"SELECT * FROM items;";
    //   MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
    //
    //   while(rdr.Read())
    //   {
    //     int itemdId = rdr.GetInt32(0);
    //     string itemDescription = rdr.GetString(1);
    //     Language newLanguage = new Language(itemDescription, itemId);
    //     allLanguages.Add(newLanguage);
    //   }
    //
    //   conn.Close();
    //
    //   if (conn!= null)
    //   {
    //     conn.Dispose();
    //   }
    //   return allLanguages;
    // }

  }
}
