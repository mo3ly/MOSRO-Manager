using MOSROManager.Model;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MOSROManager
{
    class Common
    {
        public static ConfigController ConfigController = new ConfigController();
        public static Config Config = null;
        public static DashboardForm Dashboard;
        public static SQL SqlConnection;
        public static int alertTop;
        public static DialogResult dialogResult;
        public static string dialogInputResult;
        public static Dictionary<string, string> ItemNameDictionary = new Dictionary<string, string>();
        public static SMCController SMCController = null;

        // Client
        public static SRClient SRClient;
    }
}
