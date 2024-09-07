using Newtonsoft.Json;
using Registry.UserAssist.Helper.Win32;
using (Rot13KnwnFldr rkf = new Rot13KnwnFldr())
{
    rkf.CreateFiltersRegexList(new string[] { ".exe" });
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
    #region print enum values
    //foreach (EnGuidsFolders item in Enum.GetValues(typeof(EnGuidsFolders)))
    //{
    //    Console.WriteLine($"{item} | {item.GetStringValue()}");
    //}
    #endregion

};
Console.ReadKey();