using IDAO;
using MVC_8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model;
using System.Runtime.Remoting.Messaging;
using System.Data.Entity;

namespace DAO
{
    public class config_public_charDAO : Daobase<config_public_char>, config_public_charIDAO
    {
        public int Add(config_public_charModel item)
        {
            config_public_char ko = new config_public_char(); 
                    ko.id = item.id;  
                    ko.attribute_kind = item.attribute_kind;  
                    ko.attribute_name = item.attribute_name; return  Add(ko);
        }

        public List<config_public_charModel> select()
        {
            List<config_public_char> list = SelectAll();
            List<config_public_charModel> li = new List<config_public_charModel>();
            foreach (config_public_char item in list)
            {
                config_public_charModel ko = new config_public_charModel();  
                    ko.id = item.id;  
                    ko.attribute_kind = item.attribute_kind;  
                    ko.attribute_name = item.attribute_name;  li.Add(ko);
            }
            return li;
        }

        public int update(config_public_charModel item)
        {
            config_public_char ko = new config_public_char(); 
                    ko.id = item.id;  
                    ko.attribute_kind = item.attribute_kind;  
                    ko.attribute_name = item.attribute_name;   return ModifyWithOutproNames(ko);
            }
        public List<config_public_charModel> selectupdate(int id)
        {
            List<config_public_char> list = SeleteBy(e => e.id == id);


            List<config_public_charModel> li = new List<config_public_charModel>();
            foreach (config_public_char item in list)
            {
                config_public_charModel ko = new config_public_charModel(); 
                    ko.id = item.id;  
                    ko.attribute_kind = item.attribute_kind;  
                    ko.attribute_name = item.attribute_name;   li.Add(ko);
            }
            return li;

        }
        static MyDbContext db = CreateDbContext();
        public int delete(int id)
        {
        config_public_char us = new config_public_char();
            //����ǰ̨����id����idƥ��
            us.id = id;//(��������id����ƥ��)
            //����ǰ̨����id����idƥ��
            //us.id = id;
            ////��ʼɾ��
            //db.Entry<config_public_char>(us).State =EntityState.Deleted;
            ////����            
            //return db.SaveChanges(); 
           int pd = Del(e => e.id == id,us);
           return pd;
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
        public List<config_public_charModel> SelectByKind(config_public_charModel cm)
        {

            List<config_public_char> list = SeleteBy(e => e.attribute_kind.Equals(cm.attribute_kind));
            List<config_public_charModel> list2 = new List<config_public_charModel>();
            foreach (config_public_char item in list)
            {
                config_public_charModel cpc = new config_public_charModel()
                {
                    id = item.id,
                    attribute_kind = item.attribute_kind,
                    attribute_name = item.attribute_name
                };
                list2.Add(cpc);
            }
            return list2;
        }



    }
}
