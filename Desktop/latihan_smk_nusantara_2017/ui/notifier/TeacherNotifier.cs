using latihan_smk_nusantara_2017.data;
using latihan_smk_nusantara_2017.data.source.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihan_smk_nusantara_2017.ui.notifier
{
    public static class TeacherNotifier
    {
        public static List<header_schedule> teacherSchedules;
        public static List<user> enrolledStudents;
        public static List<user> unEnrolledStudents;

        public static void getTeacherSchedule(string teacher_id)
        {
            
            teacherSchedules = Repository.getTeachingSchedule(teacher_id);
        }

        public static void getEnrolledStudents(int schedule_id)
        {
            
            enrolledStudents = Repository.getEnrolledStudent(schedule_id);
        }

        internal static void getUnEnrolledStudents(int schedule_id)
        {
         
            unEnrolledStudents = Repository.getAllUserData("student");

            foreach (user userItem in enrolledStudents)
            {
                if (unEnrolledStudents.Contains(userItem))
                {
                    unEnrolledStudents.Remove(userItem);
                }
            }
            //unEnrolledStudents.Remove();
        }
    }
}
