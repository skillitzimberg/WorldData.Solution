using System.Collections.Generic;

namespace WorldData.Models
{
  public class Language
  {
    private string _code;
    private string _language;
    private bool _isOfficial;

    public Language(string code, string language, bool isOfficial)
    {
      _code = code;
      _language = language;
      _isOfficial = isOfficial;
    }

    public string GetCode()
    {
      return _code;
    }

    public string GetLanguage()
    {
      return _language;
    }

    public bool IsOfficial()
    {
      return _isOfficial;
    }

  }
}
