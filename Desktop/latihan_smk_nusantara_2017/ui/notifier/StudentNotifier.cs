using latihan_smk_nusantara_2017.data;
using latihan_smk_nusantara_2017.data.source.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihan_smk_nusantara_2017.ui.notifier
{
    public static class StudentNotifier
    {
        public static List<student_multi_schedule> listSchedule;

        public static void getScheduleData(string user_id)
        {
            listSchedule =  Repository.getStudentScheduleData(user_id);
        }
    }
}
