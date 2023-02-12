using latihan_smk_nusantara_2017.data.source.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        #region manage user region
        
        public static List<user> getAllUserData(string filter= "")
        {
            if (filter.Equals("student")) {
                return db.users.Where(student => student.role_id == 3).ToList();
            }
            else if (filter.Equals("teacher"))
            {
                return db.users.Where(student => student.role_id == 2).ToList();
            }
            else if (filter.Equals("admin"))
            {
                return db.users.Where(student => student.role_id == 1).ToList();
            }
            else
            {
                return db.users.ToList();
            }
            
        }

        public static void addUser(user studentModel)
        {
            try
            {
                db.users.Add(studentModel);
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

        public static void updateUser(user studentModel)
        {
            try
            {

                user model = db.users.Find(studentModel.user_id);
                
                model.address = studentModel.address;
                model.name= studentModel.name;
                model.gender = studentModel.gender;
                model.date_of_birth = studentModel.date_of_birth;
                model.no_hp = studentModel.no_hp;

                
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


    }
}
