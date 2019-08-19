using IDAO;
using MVC_8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model;

namespace DAO
{
    public class StudentDAO : Daobase<Student>, StudentIDAO
    {
        public int Add(StudentModel st)
        {
            Student st1 = new Student();
            st1.Id = st.Id;
            st1.Name = st.Name;
            st1.Sex = st.Sex;
            st1.classsid = st.classsid;
             return  Add(st1);
        }

        public List<StudentModel> select()
        {
            List<Student> list = SelectAll();
            List<StudentModel> li = new List<StudentModel>();
            foreach (Student item in list)
            {
                StudentModel ko = new StudentModel();
                 ko.Name = item.Name;
                 ko.Id = item.Id;
                 ko.Sex=item.Sex;
                ko.classsid=item.classsid;
                li.Add(ko);
            }
            return li;
        }

        public int update(StudentModel st)
        {
            Student st1 = new Student();
            st1.Id = st.Id;
            st1.Name = st.Name;
            st1.Sex = st.Sex;
            st1.classsid = st.classsid;
            string[] s = { "Name" };
            return ModifyWithOutproNames(st1,s);
        }
        public List<StudentModel> selectupdate(int id) {
           List<Student> list= SeleteBy(e => e.Id == id);

           
            List<StudentModel> li = new List<StudentModel>();
            foreach (Student item in list)
            {
                StudentModel ko = new StudentModel();
                ko.Name = item.Name;
                ko.Id = item.Id;
                ko.Sex = item.Sex;
                ko.classsid = item.classsid;
                li.Add(ko);
            }
            return li;
           
        }

        public int delete(int id) {
            int pd = Del(e => e.Id == id);
            return pd;
        }

       


    }
}
