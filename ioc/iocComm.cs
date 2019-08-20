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
using IDAO;
namespace ioc
{
   public class iocComm
    {
        public static config_file_first_kindIDAO config_file_first_kindDAO()
        {
            UnityContainer ioc = CreatIoc("containerOne");
            return ioc.Resolve<config_file_first_kindDAO>("config_file_first_kindDAO");
        }
        public static config_file_first_kindIBLL config_file_first_kindBLL()
        {
            UnityContainer ioc = CreatIoc("containerTwo");
            return ioc.Resolve<config_file_first_kindIBLL>("config_file_first_kindBLL");
        }

        private static UnityContainer CreatIoc(string name)
        {
            UnityContainer ioc = new UnityContainer();
            //生成文件(Unity.config)对象
            ExeConfigurationFileMap ecf = new ExeConfigurationFileMap();
            ecf.ExeConfigFilename = @"E:\新建文件夹\UI\Unity.config";
            //生成配置对象
            Configuration cf = ConfigurationManager.OpenMappedExeConfiguration(ecf, ConfigurationUserLevel.None);
            //读取配置对象的unity节点区                                                               
            UnityConfigurationSection ucs = (UnityConfigurationSection)cf.GetSection("unity");
            ioc.LoadConfiguration(ucs, name);
            return ioc;

        }
    }
}
