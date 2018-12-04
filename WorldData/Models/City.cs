using System.Collections.Generic;
using MySql.Data.MySqlClient;
namespace WorldData.Models
{
  public class City
  {
    private int _cityId;
    private string _name;
    private string _countryCode;
    private string _district;
    private int _population;


    public City(int cityId, string name, string countryCode, string district, int population)
    {
      _cityId = cityId;
      _name = name;
      _countryCode = countryCode;
      _district = district;
      _population = population;
    }

    public int GetCityId()
    {
      return _cityId;
    }

    public string GetName()
    {
      return _name;
    }

    public string GetCountryCode()
    {
      return _countryCode;
    }

    public string GetDistrict()
    {
      return _district;
    }

    public int GetPopulation()
    {
      return _population;
    }

    public static List<City> GetAll()
    {
      List<City> allCities = new List<City> {};
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"SELECT * FROM city;";
      MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;

      while(rdr.Read())
      {
        int cityId = rdr.GetInt32(0);
        string name = rdr.GetString(1);
        string countryCode = rdr.GetString(2);
        string district = rdr.GetString(3);
        int population = rdr.GetInt32(4);
        City newCity = new City(cityId, name, countryCode, district, population);
        allCities.Add(newCity);
      }

      conn.Close();

      if (conn!= null)
      {
        conn.Dispose();
      }
      return allCities;
    }

  }
}
