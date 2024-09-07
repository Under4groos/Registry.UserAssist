using Registry.UserAssist.Enums;

namespace Registry.UserAssist.Structs
{
    public struct GuidFolder
    {
        public EnGuidsFolders Guid;
        public string GuidStr;
        public string Path;
        public string ValueName;

        public override string ToString()
        {
            return $"Guid: {Guid.GetData()}\nValueName: \"{ValueName}\"\nPath: \"{Path}\"\n";
        }
    }
}
