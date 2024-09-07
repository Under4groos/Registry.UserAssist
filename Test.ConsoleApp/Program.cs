using Newtonsoft.Json;
using Registry.UserAssist.Helper.Win32;
using Registry.UserAssist.Structs;

OptRot13KnwnFldr _Opt = new OptRot13KnwnFldr()
{
    IsChekedValidPath = false,
    RegexFilters = new string[] { @"\.exe" }
};

using (Rot13KnwnFldr rkf = new Rot13KnwnFldr(_Opt))
{
    rkf.Init();
    foreach (var item in rkf.GetFolders())
    {
        Console.WriteLine(item);
    }
    #region Json
    try
    {
        string _json_str = JsonConvert.SerializeObject(rkf.GetFolders(), Formatting.Indented);
        File.WriteAllText("____filders.json", _json_str);
    }
    catch (Exception)
    { }
    #endregion
};
Console.ReadKey();