using Registry.UserAssist.Helper.Win32;

//using Registry.UserAssist.Helper.Win32
using (Rot13KnwnFldr rkf = new Rot13KnwnFldr())
{



    rkf.Checked();


    #region print enum values
    //foreach (EnGuidsFolders item in Enum.GetValues(typeof(EnGuidsFolders)))
    //{
    //    Console.WriteLine($"{item} | {item.GetStringValue()}");     
    //} 
    #endregion

};
Console.ReadKey();