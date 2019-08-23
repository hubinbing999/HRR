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

        public static usersIDAO usersDAO()
        {
            UnityContainer ioc = CreatIoc("containerOne");
            return ioc.Resolve<usersDAO>("usersDAO");
        }
        public static usersIBLL usersBLL()
        {
            UnityContainer ioc = CreatIoc("containerTwo");

            return ioc.Resolve<usersIBLL>("usersBLL");
        }
        //config_major_kind
        public static config_major_kindIDAO config_major_kindDAO()
        {
            UnityContainer ioc = CreatIoc("containerOne");
            return ioc.Resolve<config_major_kindDAO>("config_major_kindDAO");
        }
        public static config_major_kindIBLL config_major_kindBLL()
        {
            UnityContainer ioc = CreatIoc("containerTwo");

            return ioc.Resolve<config_major_kindIBLL>("config_major_kindBLL");
        }

        //config_major

        public static config_majorIDAO config_majorDAO()
        {
            UnityContainer ioc = CreatIoc("containerOne");
            return ioc.Resolve<config_majorDAO>("config_majorDAO");
        }
        public static config_majorIBLL config_majorBLL()
        {
            UnityContainer ioc = CreatIoc("containerTwo");

            return ioc.Resolve<config_majorIBLL>("config_majorBLL");
        }
        //config_public_char

        public static config_public_charIDAO config_public_charDAO()
        {
            UnityContainer ioc = CreatIoc("containerOne");
            return ioc.Resolve<config_public_charDAO>("config_public_charDAO");
        }
        public static config_public_charIBLL config_public_charBLL()
        {
            UnityContainer ioc = CreatIoc("containerTwo");

            return ioc.Resolve<config_public_charIBLL>("config_public_charBLL");
        }
        private static UnityContainer CreatIoc(string name)
        {
            UnityContainer ioc = new UnityContainer();
            //生成文件(Unity.config)对象
            ExeConfigurationFileMap ecf = new ExeConfigurationFileMap();
            ecf.ExeConfigFilename = @"D:\Source\Repos\823HRR\UI\Unity.config";
            //生成配置对象
            Configuration cf = ConfigurationManager.OpenMappedExeConfiguration(ecf, ConfigurationUserLevel.None);
            //读取配置对象的unity节点区                                                               
            UnityConfigurationSection ucs = (UnityConfigurationSection)cf.GetSection("unity");
            ioc.LoadConfiguration(ucs, name);
            return ioc;

        }
    }
}
