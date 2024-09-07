using Registry.UserAssist.Enums;
using System.Runtime.InteropServices;
using System.Text;

namespace Registry.UserAssist.Helper
{
    public static class DllImportWinApi
    {
        public const string SHELL = "shell32.dll";


        [DllImport(SHELL, SetLastError = true, EntryPoint = "SHGetSpecialFolderPathW", CharSet = CharSet.Unicode)]
        public static extern int SHGetSpecialFolderPath(IntPtr hwndOwner, StringBuilder buffer, Csidl nFolder, bool fCreate);



        [DllImport(SHELL, CharSet = CharSet.Unicode)]
        public static extern void SHGetKnownFolderPath([MarshalAs(UnmanagedType.LPStruct)] Guid rfid, int dwFlags, nint hToken, out nint ppwszPath);
    }
}
