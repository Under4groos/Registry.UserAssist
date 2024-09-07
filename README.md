## Lib: Registry.UserAssist

Выдает список приложений, ссылок и прочего... 

## Regex | Поиск
Поиск приложений с форматом '*.exe' 
```C#
public void CreateFiltersRegexList(string[] pattern)
// Пример:
// rkf.CreateFiltersRegexList(new string[] { ".exe" });
```
#### or 
```C#
public void CreateFiltersRegex(string pattern)
// Пример:
//rkf.CreateFiltersRegex(".exe" );
```

```C#
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
```

### Результат
```log
Guid: W7_1-{CEBFF5CD-ACE2-4F4F-9178-9926F41749EA}
ValueName: "P:\Hfref\HaqreXb\Qbjaybnqf\ehshf-4.5c (1).rkr"
Path: "C:\Users\UnderKo\Downloads\rufus-4.5p (1).exe"

Guid: W7_1-{CEBFF5CD-ACE2-4F4F-9178-9926F41749EA}
ValueName: "{6Q809377-6NS0-444O-8957-N3773S02200R}\JvaqbjfNccf\Zvpebfbsg.Cnvag_11.2406.42.0_k64__8jrxlo3q8oojr\CnvagNcc\zfcnvag.rkr"
Path: "C:\Program Files\WindowsApps\Microsoft.Paint_11.2406.42.0_x64__8wekyb3d8bbwe\PaintApp\mspaint.exe"

Guid: W7_1-{CEBFF5CD-ACE2-4F4F-9178-9926F41749EA}
ValueName: "Fnaqobk.QrsnhygObk.Qyy2P_rkr"
Path: "Sandbox.DefaultBox.Dll2C_exe"

Guid: W7_1-{CEBFF5CD-ACE2-4F4F-9178-9926F41749EA}
ValueName: "Fnaqobk.QrsnhygObk.puebzr_rkr"
Path: "Sandbox.DefaultBox.chrome_exe"

Guid: W7_1-{CEBFF5CD-ACE2-4F4F-9178-9926F41749EA}
ValueName: "{1NP14R77-02R7-4R5Q-O744-2RO1NR5198O7}\JvaqbjfCbjreFuryy\i1.0\cbjrefuryy.rkr"
Path: "C:\Windows\system32\WindowsPowerShell\v1.0\powershell.exe"
```


