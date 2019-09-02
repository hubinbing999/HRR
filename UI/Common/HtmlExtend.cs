using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Common
{
   
        public static class HtmlExtend
        {
            //创建静态类 返回类型 MvcHtmlString 参数 HtmlHelper
            public static MvcHtmlString HtmlSubmit(this HtmlHelper hp)
            {
                //放入标签
                string s ="<img src=@ViewData['ttt'] style='width: 120px; height: 150px; '  />";
                //对字符串转化
                return MvcHtmlString.Create(s);
            }
        }
    
}