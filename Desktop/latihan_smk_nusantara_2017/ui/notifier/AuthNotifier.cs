using latihan_smk_nusantara_2017.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace latihan_smk_nusantara_2017.ui.notifier
{
    public static class AuthNotifier
    {

        public static void doLogin(string username, string password)
        {
            Repository.doLogin(username, password);
        }
        public static void doLogout()
        {
            Repository.doLogout();
    
        }


    }
}
