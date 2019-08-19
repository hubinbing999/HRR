using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Model;
using DAO;
using IBLL;

namespace ioc
{
   public class iocComm
    {
        public static StudentDAO StudetDAO()
        {
            UnityContainer ioc = CreatIoc("containerOne");

            return ioc.Resolve<StudentDAO>("StudentDAO");
        }
        public static StudentIBLL StudetIBLL()
        {
            UnityContainer ioc = CreatIoc("containerTwo");

            return ioc.Resolve<StudentIBLL>("StudentBLL");
        }

        private static UnityContainer CreatIoc(string name)
        {
            UnityContainer ioc = new UnityContainer();
            //生成文件(Unity.config)对象
            ExeConfigurationFileMap ecf = new ExeConfigurationFileMap();
            ecf.ExeConfigFilename = @"E:\2345下载\jQuery EasyUI 的使用\MVC\MVC-8\UI\Unity.config";
            //生成配置对象
            Configuration cf = ConfigurationManager.OpenMappedExeConfiguration(ecf, ConfigurationUserLevel.None);
            //读取配置对象的unity节点区
            UnityConfigurationSection ucs = (UnityConfigurationSection)cf.GetSection("unity");
            ioc.LoadConfiguration(ucs, name);
            return ioc;

        }
    }
}
