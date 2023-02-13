using latihan_smk_nusantara_2017.data;
using latihan_smk_nusantara_2017.data.source.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace latihan_smk_nusantara_2017.ui.notifier
{
    public static class AdminNotifier
    {
        #region manage user region
        public static List<user> listStudent = new List<user>();
        public static List<user> listTeacher = new List<user>();
        public static void getAllUserData()
        {
            listStudent.Clear();
            listStudent = Repository.getAllUserData("student");
            listTeacher = Repository.getAllUserData("teacher");
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

        #region manage schedule

        public static List<header_schedule> listSchedule = new List<header_schedule>();
        public static void getAllSchedule()
        {
            listSchedule = Repository.getAllHeaderSchedule();
        }

        internal static void addNewSchedule(header_schedule scheduleModel)
        {
            Repository.addNewSchedule(scheduleModel);
        }

        internal static void updateSchedule(header_schedule scheduleModel)
        {
            Repository.updateSchedule(scheduleModel);
            
        }

        internal static void removeSchedule(int schedule_id)
        {
            Repository.removeSchedule(schedule_id);
        }
        #endregion
    }
}
