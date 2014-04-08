using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpTibiaProxy.Domain
{
    public class ClientVersion
    {
        public static readonly ClientVersion Version961 = new ClientVersion { Number = 961, FileVersion = "9.6.1.0", OtbmVersion = 2, OtbMajorVersion = 3, OtbMinorVersion = 41 };
        public static readonly ClientVersion Version963 = new ClientVersion { Number = 963, FileVersion = "9.6.3.0", OtbmVersion = 2, OtbMajorVersion = 3, OtbMinorVersion = 42 };
        public static readonly ClientVersion Version970 = new ClientVersion { Number = 970, FileVersion = "9.7.0.0", OtbmVersion = 2, OtbMajorVersion = 3, OtbMinorVersion = 43 };
        public static readonly ClientVersion Version981 = new ClientVersion { Number = 981, FileVersion = "9.8.1.0", OtbmVersion = 2, OtbMajorVersion = 3, OtbMinorVersion = 45 };
        public static readonly ClientVersion Version986 = new ClientVersion { Number = 986, FileVersion = "9.8.6.0", OtbmVersion = 2, OtbMajorVersion = 3, OtbMinorVersion = 49 };
        public static readonly ClientVersion Version1010 = new ClientVersion { Number = 1010, FileVersion = "10.1.0.0", OtbmVersion = 2, OtbMajorVersion = 3, OtbMinorVersion = 50 };
        public static readonly ClientVersion Version1011 = new ClientVersion { Number = 1011, FileVersion = "10.1.1.0", OtbmVersion = 2, OtbMajorVersion = 3, OtbMinorVersion = 50 };
        public static readonly ClientVersion Version1012 = new ClientVersion { Number = 1012, FileVersion = "10.1.2.0", OtbmVersion = 2, OtbMajorVersion = 3, OtbMinorVersion = 50 };
        public static readonly ClientVersion Version1013 = new ClientVersion { Number = 1013, FileVersion = "10.1.3.0", OtbmVersion = 2, OtbMajorVersion = 3, OtbMinorVersion = 50 };
        public static readonly ClientVersion Version1020 = new ClientVersion { Number = 1020, FileVersion = "10.2.0.0", OtbmVersion = 2, OtbMajorVersion = 3, OtbMinorVersion = 50 };
        public static readonly ClientVersion Version1030 = new ClientVersion { Number = 1030, FileVersion = "10.3.0.0", OtbmVersion = 2, OtbMajorVersion = 3, OtbMinorVersion = 50 };
        public static readonly ClientVersion Version1031 = new ClientVersion { Number = 1031, FileVersion = "10.3.1.0", OtbmVersion = 2, OtbMajorVersion = 3, OtbMinorVersion = 50 };
        public static readonly ClientVersion Version1032 = new ClientVersion { Number = 1032, FileVersion = "10.3.2.0", OtbmVersion = 2, OtbMajorVersion = 3, OtbMinorVersion = 50 };
        public static readonly ClientVersion Version1033 = new ClientVersion { Number = 1033, FileVersion = "10.3.3.0", OtbmVersion = 2, OtbMajorVersion = 3, OtbMinorVersion = 50 };
        public static readonly ClientVersion Version1034 = new ClientVersion { Number = 1034, FileVersion = "10.3.4.0", OtbmVersion = 2, OtbMajorVersion = 3, OtbMinorVersion = 50 };
        public static readonly ClientVersion Version1035 = new ClientVersion { Number = 1035, FileVersion = "10.3.5.0", OtbmVersion = 2, OtbMajorVersion = 3, OtbMinorVersion = 50 };
        public static readonly ClientVersion Version1038 = new ClientVersion { Number = 1038, FileVersion = "10.3.8.0", OtbmVersion = 2, OtbMajorVersion = 3, OtbMinorVersion = 50 };
        public static readonly ClientVersion Current = Version1038;

        public int Number { get; private set; }
        public string FileVersion { get; private set; }
        public uint OtbmVersion { get; private set; }
        public uint OtbMajorVersion { get; private set; }
        public uint OtbMinorVersion { get; private set; }

        private ClientVersion() { }

        public static ClientVersion GetFromFileVersion(string fileVersion)
        {
            switch (fileVersion)
            {
                case "9.6.1.0": return Version961;
                case "9.6.3.0": return Version963;
                case "9.7.0.0": return Version970;
                case "9.8.1.0": return Version981;
                case "9.8.6.0": return Version986;
                case "10.1.0.0": return Version1010;
                case "10.1.1.0": return Version1011;
                case "10.1.2.0": return Version1012;
                case "10.1.3.0": return Version1013;
                case "10.2.0.0": return Version1020;
                case "10.3.0.0": return Version1030;
                case "10.3.1.0": return Version1031;
                case "10.3.2.0": return Version1032;
                case "10.3.3.0": return Version1033;
                case "10.3.4.0": return Version1034;
                case "10.3.5.0": return Version1035;
                case "10.3.8.0": return Version1038;
                default: return null;
            }
        }

        public override bool Equals(object obj)
        {
            var other = obj as ClientVersion;
            return other != null && other.Number == Number;
        }

        public override int GetHashCode()
        {
            return Number ^ 31;
        }
    }
}
