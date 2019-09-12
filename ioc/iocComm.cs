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
        //engage_major_release'
        public static engage_major_releaseIDAO engage_major_releaseDAO()
        {
            UnityContainer ioc = CreatIoc("containerOne");
            return ioc.Resolve<engage_major_releaseDAO>("engage_major_releaseDAO");
        }
        public static engage_major_releaseIBLL engage_major_releaseBLL()
        {
            UnityContainer ioc = CreatIoc("containerTwo");
            return ioc.Resolve<engage_major_releaseIBLL>("engage_major_releaseBLL");
        }

        

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

        public static config_file_second_kindIDAO config_file_second_kindDAO()
        {
            UnityContainer ioc = CreatIoc("containerOne");
            return ioc.Resolve<config_file_second_kindDAO>("config_file_second_kindDAO");
        }
        public static config_file_second_kindIBLL config_file_second_kindBLL()
        {
            UnityContainer ioc = CreatIoc("containerTwo");
            return ioc.Resolve<config_file_second_kindIBLL>("config_file_second_kindBLL");
        }


        public static config_file_third_kindIDAO config_file_third_kindDAO()
        {
            UnityContainer ioc = CreatIoc("containerOne");
            return ioc.Resolve<config_file_third_kindDAO>("config_file_third_kindDAO");
        }
        public static config_file_third_kindIBLL config_file_third_kindBLL()
        {
            UnityContainer ioc = CreatIoc("containerTwo");
            return ioc.Resolve<config_file_third_kindIBLL>("config_file_third_kindBLL");
           
        }
        //human_file_dig
        public static human_file_digIDAO human_file_digDAO()
        {
            UnityContainer ioc = CreatIoc("containerOne");
            return ioc.Resolve<human_file_digDAO>("human_file_digDAO");
        }
        public static human_file_digIBLL human_file_digBLL()
        {
            UnityContainer ioc = CreatIoc("containerTwo");
            return ioc.Resolve<human_file_digIBLL>("human_file_digBLL");

        }
        //human_file
        public static human_fileIDAO human_fileDAO()
        {
            UnityContainer ioc = CreatIoc("containerOne");
            return ioc.Resolve<human_fileDAO>("human_fileDAO");
        }
        public static human_fileIBLL human_fileBLL()
        {
            UnityContainer ioc = CreatIoc("containerTwo");
            return ioc.Resolve<human_fileIBLL>("human_fileBLL");

        }

        public static engage_interviewIDAO engage_interviewDAO()
        {
            UnityContainer ioc = CreatIoc("containerOne");
            return ioc.Resolve<engage_interviewDAO>("engage_interviewDAO");
        }
        public static engage_interviewIBLL engage_interviewBLL()
        {
            UnityContainer ioc = CreatIoc("containerTwo");
            return ioc.Resolve<engage_interviewIBLL>("engage_interviewBLL");

        }
        public static RoleManagerIDAO RoleManagerDAO()
        {
            UnityContainer ioc = CreatIoc("containerOne");
            return ioc.Resolve<RoleManagerDAO>("RoleManagerDAO");
        }
        public static RoleManagerIBLL RoleManagerIBLL()
        {
            UnityContainer ioc = CreatIoc("containerTwo");
            return ioc.Resolve<RoleManagerIBLL>("RoleManagerBLL");

        }


        public static engage_resumeIDAO engage_resumeDAO()
        {
            UnityContainer ioc = CreatIoc("containerOne");
            return ioc.Resolve<engage_resumeDAO>("engage_resumeDAO");
        }
        public static engage_resumeIBLL engage_resumeBLL()
        {
            UnityContainer ioc = CreatIoc("containerTwo");
            return ioc.Resolve<engage_resumeIBLL>("engage_resumeBLL");

        }
        //salary_standard_details
        public static salary_standard_detailsIDAO salary_standard_detailsDAO()
        {
            UnityContainer ioc = CreatIoc("containerOne");
            return ioc.Resolve<salary_standard_detailsDAO>("salary_standard_detailsDAO");
        }
        public static salary_standard_detailsIBLL salary_standard_detailsBLL()
        {
            UnityContainer ioc = CreatIoc("containerTwo");
            return ioc.Resolve<salary_standard_detailsIBLL>("salary_standard_detailsBLL");

        }
        //salary_standard
        public static salary_standardIDAO salary_standardDAO()
        {
            UnityContainer ioc = CreatIoc("containerOne");
            return ioc.Resolve<salary_standardDAO>("salary_standardDAO");
        }
        public static salary_standardIBLL salary_standardBLL()
        {
            UnityContainer ioc = CreatIoc("containerTwo");
            return ioc.Resolve<salary_standardIBLL>("salary_standardBLL");

        }
        //salary_grant_details
        public static salary_grant_detailsIDAO salary_grant_detailsDAO()
        {
            UnityContainer ioc = CreatIoc("containerOne");
            return ioc.Resolve<salary_grant_detailsDAO>("salary_grant_detailsDAO");
        }
        public static salary_grant_detailsIBLL salary_grant_detailsBLL()
        {
            UnityContainer ioc = CreatIoc("containerTwo");
            return ioc.Resolve<salary_grant_detailsIBLL>("salary_grant_detailsBLL");

        }
        //salary_grant
        public static salary_grantIDAO salary_grantDAO()
        {
            UnityContainer ioc = CreatIoc("containerOne");
            return ioc.Resolve<salary_grantDAO>("salary_grantDAO");
        }
        public static salary_grantIBLL salary_grantBLL()
        {
            UnityContainer ioc = CreatIoc("containerTwo");
            return ioc.Resolve<salary_grantIBLL>("salary_grantBLL");

        }

        private static UnityContainer CreatIoc(string name)
        {
            UnityContainer ioc = new UnityContainer();
            //生成文件(Unity.config)对象
            ExeConfigurationFileMap ecf = new ExeConfigurationFileMap();
            ecf.ExeConfigFilename = @"D:\Y2Net\EF项目\UI\Unity.config";
            //生成配置对象
            Configuration cf = ConfigurationManager.OpenMappedExeConfiguration(ecf, ConfigurationUserLevel.None);
            //读取配置对象的unity节点区                                                               
            UnityConfigurationSection ucs = (UnityConfigurationSection)cf.GetSection("unity");
            ioc.LoadConfiguration(ucs, name);
            return ioc;

        }
    }
}
