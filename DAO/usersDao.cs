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
    public class usersDAO : Daobase<users>, usersIDAO
    {
        public int Add(usersModel item)
        {
            users ko = new users(); 
                    ko.u_id = item.u_id;  
                    ko.u_name = item.u_name;  
                    ko.u_true_name = item.u_true_name;  
                    ko.u_password = item.u_password; return  Add(ko);
        }

        public List<usersModel> select()
        {
            List<users> list = SelectAll();
            List<usersModel> li = new List<usersModel>();
            foreach (users item in list)
            {
                usersModel ko = new usersModel();  
                    ko.u_id = item.u_id;  
                    ko.u_name = item.u_name;  
                    ko.u_true_name = item.u_true_name;  
                    ko.u_password = item.u_password;  li.Add(ko);
            }
            return li;
        }

        public int update(usersModel item)
        {
            users ko = new users(); 
                    ko.u_id = item.u_id;  
                    ko.u_name = item.u_name;  
                    ko.u_true_name = item.u_true_name;  
                    ko.u_password = item.u_password;   return ModifyWithOutproNames(ko);
            }
        public List<usersModel> selectupdate(int id)
        {
            List<users> list = SeleteBy(e => e.u_id == id);


            List<usersModel> li = new List<usersModel>();
            foreach (users item in list)
            {
                usersModel ko = new usersModel(); 
                    ko.u_id = item.u_id;  
                    ko.u_name = item.u_name;  
                    ko.u_true_name = item.u_true_name;  
                    ko.u_password = item.u_password;   li.Add(ko);
            }
            return li;

        }

        public int delete(int id)
        {
            int pd = Del(e => e.u_id == id);
            return pd;
        }




    }
}
