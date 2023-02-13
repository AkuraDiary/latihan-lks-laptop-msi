using latihan_smk_nusantara_2017.data.source.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace latihan_smk_nusantara_2017.data
{
    public static class Repository
    {
        
        public static db_sekolahEntities db = new db_sekolahEntities();

        #region auth region
        public static user loggedInUser = null;
        public static void doLogin(string username, string password)
        {
            loggedInUser = db.users.Where(user => user.username.Equals(username) && user.password.Equals(password)).FirstOrDefault();

        }

        public static void doLogout()
        {
            loggedInUser = null;
        }
        #endregion


        #region universal


        #endregion

        #region admin regions

        public static List<header_schedule> getAllHeaderSchedule()
        {
            return db.header_schedule.ToList();
        }

        public static void removeSchedule(int schedule_id)
        {
            try
            {
                header_schedule entry = db.header_schedule.Find(schedule_id);
                if (entry != null)
                {
                    db.Entry(entry).State = System.Data.EntityState.Deleted;
                    db.SaveChanges();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void updateSchedule(header_schedule scheduleModel)
        {
            try
            {
                
                header_schedule model = db.header_schedule.Find(scheduleModel.schedule_id);
                
                
                

                model.teacher_id = scheduleModel.teacher_id;
                model.subject_id = scheduleModel.subject_id;
                model.class_id = scheduleModel.class_id;
                
                

                db.Entry(model).State = System.Data.EntityState.Modified;
                

                db.SaveChanges();
               
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void addNewSchedule(header_schedule scheduleModel)
        {
            try
            {
                db.header_schedule.Add(scheduleModel);
                db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
        #region manage user region

        public static List<user> getAllUserData(string filter= "")
        {
            if (filter.Equals("student")) {
                return db.users.Where(model => model.role_id == 3).ToList();
            }
            else if (filter.Equals("teacher"))
            {
                return db.users.Where(model => model.role_id == 2).ToList();
            }
            else if (filter.Equals("admin"))
            {
                return db.users.Where(model => model.role_id == 1).ToList();
            }
            else
            {
                return db.users.ToList();
            }
            
        }

        public static void addUser(user model)
        {
            try
            {
                db.users.Add(model);
                db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void removeUser(string id)
        {
            try
            {
                user entry = db.users.Find(id);
                if (entry != null)
                {
                    db.Entry(entry).State = System.Data.EntityState.Deleted;
                    db.SaveChanges();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void updateUser(user userModel)
        {
            try
            {

                user model = db.users.Find(userModel.user_id);
                
                model.address = userModel.address;
                model.name= userModel.name;
                model.gender = userModel.gender;
                model.date_of_birth = userModel.date_of_birth;
                model.no_hp = userModel.no_hp;

                
                db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }


        #endregion

        #endregion

        #region studentRegion
        public static List<student_multi_schedule> getStudentScheduleData(string user_id)
        {
            return db.student_multi_schedule.Where(item => item.student_id.Equals(user_id)).ToList();
        }

        #endregion student region

        #region teacher region

        public static List<header_schedule> getTeachingSchedule(string user_id)
        {
            return db.header_schedule.Where(item => item.teacher_id.Equals(user_id)).ToList();
        }

        public static List<user> getEnrolledStudent(int schedule_id) { 
            List<user> students = new List<user>();

            List<student_multi_schedule> listSchedule = db.student_multi_schedule.Where(item => item.schedule_id.Equals(schedule_id)).ToList();

            foreach (student_multi_schedule item in listSchedule)
            {
                user enrolled_student = db.users.Find(item.student_id);
                students.Add(enrolled_student);
            }
            return students;
        }

       

        #endregion
    }
}
