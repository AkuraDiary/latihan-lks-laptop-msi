using latihan_smk_nusantara_2017.data;
using latihan_smk_nusantara_2017.data.source.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihan_smk_nusantara_2017.ui.notifier
{
    public static class AdminNotifier
    {
        #region manage student region
        public static List<user> listStudent = new List<user>();
        public static void getAllUserData()
        {
            listStudent.Clear();
            listStudent = Repository.getAllUserData("student");
        }

        public static void addNewUser(user userModel)
        {
            Repository.addUser(userModel);
        }

        public static void removeUser(string userId)
        {
            Repository.removeUser(userId);
        }

        public static void updaetUser(user userModel)
        {
            Repository.updateUser(userModel);
        }
        #endregion
    }
}
