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
    public class config_file_first_kindDAO : Daobase<config_file_first_kind>, config_file_first_kindIDAO
    {
        public int Add(config_file_first_kindModel item)
        {
            config_file_first_kind ko = new config_file_first_kind(); 
                    ko.Id = item.Id;  
                    ko.first_kind_id = item.first_kind_id;  
                    ko.first_kind_name = item.first_kind_name;  
                    ko.first_kind_salary_id = item.first_kind_salary_id;  
                    ko.first_kind_sale_id = item.first_kind_sale_id; return  Add(ko);
        }

        public List<config_file_first_kindModel> select()
        {
            List<config_file_first_kind> list = SelectAll();
            List<config_file_first_kindModel> li = new List<config_file_first_kindModel>();
            foreach (config_file_first_kind item in list)
            {
                config_file_first_kindModel ko = new config_file_first_kindModel();  
                    ko.Id = item.Id;  
                    ko.first_kind_id = item.first_kind_id;  
                    ko.first_kind_name = item.first_kind_name;  
                    ko.first_kind_salary_id = item.first_kind_salary_id;  
                    ko.first_kind_sale_id = item.first_kind_sale_id;  li.Add(ko);
            }
            return li;
        }

        public int update(config_file_first_kindModel item)
        {
            config_file_first_kind ko = new config_file_first_kind(); 
                    ko.Id = item.Id;  
                    ko.first_kind_id = item.first_kind_id;  
                    ko.first_kind_name = item.first_kind_name;  
                    ko.first_kind_salary_id = item.first_kind_salary_id;  
                    ko.first_kind_sale_id = item.first_kind_sale_id;   return ModifyWithOutproNames(ko);
            }
        public List<config_file_first_kindModel> selectupdate(int id)
        {
            List<config_file_first_kind> list = SeleteBy(e => e.Id == id);


            List<config_file_first_kindModel> li = new List<config_file_first_kindModel>();
            foreach (config_file_first_kind item in list)
            {
                config_file_first_kindModel ko = new config_file_first_kindModel(); 
                    ko.Id = item.Id;  
                    ko.first_kind_id = item.first_kind_id;  
                    ko.first_kind_name = item.first_kind_name;  
                    ko.first_kind_salary_id = item.first_kind_salary_id;  
                    ko.first_kind_sale_id = item.first_kind_sale_id;   li.Add(ko);
            }
            return li;

        }

        public int delete(int id)
        {
            int pd = Del(e => e.Id == id);
            return pd;
        }




    }
}
