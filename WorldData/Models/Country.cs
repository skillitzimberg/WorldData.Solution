using System.Collections.Generic;
using MySql.Data.MySqlClient;
namespace WorldData.Models
{
public class Country
{
  private static List<Country> _allCountries = new List<Country>{};
  private string _code;
  private string _name;
  private string _continent;
  private List<City> _cities;

  public Country(string code, string name, string continent)
  {
    _code = code;
    _name = name;
    _continent = continent;
    _allCountries.Add(this);
    _cities = new List<City>{};
  }

  public string GetCode()
  {
    return _code;
  }

  public string GetName()
  {
    return _name;
  }
  public string GetContinent()
  {
    return _continent;
  }

  public Country Find(string code)
  {
    return _allCountries[code];
  }

  public void AddCity(City city)
  {
    _cities.Add(city);
  }

  public List<City> GetAllCities()
  {
    return _cities;
  }

  public static List<Country> GetAll()
  {
    List<Country> allCountries = new List<Country> {};
    MySqlConnection conn = DB.Connection();
    conn.Open();
    MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
    cmd.CommandText = @"SELECT * FROM country;";
    MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;

    while(rdr.Read())
    {
      string countryCode = rdr.GetString(0);
      string countryName = rdr.GetString(1);
      string countryContinent = rdr.GetString(2);
      Country newCountry = new Country(countryCode, countryName, countryContinent);
      allCountries.Add(newCountry);
    }

    conn.Close();

    if (conn!= null)
    {
      conn.Dispose();
    }
    return allCountries;
  }

}

}
