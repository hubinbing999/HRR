using IDAO;
using MVC_8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model;
using System.Data.Entity;
using System.Runtime.Remoting.Messaging;

namespace DAO
{
    public class config_majorDAO : Daobase<config_major>, config_majorIDAO
    {
        public int Add(config_majorModel item)
        {
            config_major ko = new config_major(); 
                    ko.mak_id = item.mak_id;  
                    ko.major_kind_id = item.major_kind_id;  
                    ko.major_kind_name = item.major_kind_name;  
                    ko.major_id = item.major_id;  
                    ko.major_name = item.major_name;  
                    ko.test_amount = item.test_amount; return  Add(ko);
        }

        public List<config_majorModel> select()
        {
            List<config_major> list = SelectAll();
            List<config_majorModel> li = new List<config_majorModel>();
            foreach (config_major item in list)
            {
                config_majorModel ko = new config_majorModel();  
                    ko.mak_id = item.mak_id;  
                    ko.major_kind_id = item.major_kind_id;  
                    ko.major_kind_name = item.major_kind_name;  
                    ko.major_id = item.major_id;  
                    ko.major_name = item.major_name;  
                    ko.test_amount = item.test_amount;  li.Add(ko);
            }
            return li;
        }

        public int update(config_majorModel item)
        {
            config_major ko = new config_major(); 
                    ko.mak_id = item.mak_id;  
                    ko.major_kind_id = item.major_kind_id;  
                    ko.major_kind_name = item.major_kind_name;  
                    ko.major_id = item.major_id;  
                    ko.major_name = item.major_name;  
                    ko.test_amount = item.test_amount;   return ModifyWithOutproNames(ko);
            }
        public List<config_majorModel> selectupdate(int id)
        {
            List<config_major> list = SeleteBy(e => e.mak_id == id);


            List<config_majorModel> li = new List<config_majorModel>();
            foreach (config_major item in list)
            {
                config_majorModel ko = new config_majorModel(); 
                    ko.mak_id = item.mak_id;  
                    ko.major_kind_id = item.major_kind_id;  
                    ko.major_kind_name = item.major_kind_name;  
                    ko.major_id = item.major_id;  
                    ko.major_name = item.major_name;  
                    ko.test_amount = item.test_amount;   li.Add(ko);
            }
            return li;

        }

        static MyDbContext db = CreateDbContext();
        public int delete(int id)
        {
            config_major us = new config_major();
            //����ǰ̨����id����idƥ��
            us.mak_id = id;
            //��ʼɾ��
            db.Entry<config_major>(us).State = EntityState.Deleted;
            //����            
            return db.SaveChanges();


            // int pd = Del(e => e.id == id);
            // return pd;
        }
        private static MyDbContext CreateDbContext()
        {

            //�ӵ�ǰ������߳�ȡֵ
            db = CallContext.GetData("s") as MyDbContext;
            if (db == null)
            {
                db = new MyDbContext();
                //�������Ķ�����뵱ǰ������߳���
                CallContext.SetData("s", db);
            }
            return db;
        }

        public List<config_majorModel> selectxlk(string id)
        {
            List<config_major> list = SeleteBy(e => e.major_kind_id == id);


            List<config_majorModel> li = new List<config_majorModel>();
            foreach (config_major item in list)
            {
                config_majorModel ko = new config_majorModel();
                ko.mak_id = item.mak_id;
                ko.major_kind_id = item.major_kind_id;
                ko.major_kind_name = item.major_kind_name;
                ko.major_id = item.major_id;
                ko.major_name = item.major_name;
                ko.test_amount = item.test_amount;
                li.Add(ko);
            }
            return li;
        }
    }
}
