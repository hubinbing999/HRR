<%@ page language="java" import="java.util.*" pageEncoding="UTF-8"%>
<%@taglib uri="/struts-tags" prefix="s"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">




<html>
	<head>
		<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
		<link rel="stylesheet" href="${applicationScope.proPath }/css/table.css" type="text/css" />
		<title>无标题文档</title>
 
	</head>

	<body>
	<form action="salaryStandardAction!downloadSalaryStandard" method="post">
	<table width="100%" >
		  <tr>
		    <td colspan="2"> 
		    <font color="#0000CC">您正在做的业务是：人力资源--薪酬标准管理--薪酬标准打印 </font></td>
		  </tr>
		  <tr>
		  
		  
		  <s:if test="#session.flag==true">
    <td width="49%"> 打印成功</td>
    <td width="51%" align="right">
			<input type="button" 
			class="BUTTON_STYLE1" 
			onclick="javascript:window.location='${applicationScope.proPath }/salaryCriterion/salaryCriterionAction!salarystandardChangeListByPage?page.startPage=0';" 
			value="返回" />
		</td>
		</s:if>
		<s:else>
		 <td width="49%"> 打印失败,可能是您的操作有误！!</td>
    <td width="51%" align="right">
			<input type="button" class="BUTTON_STYLE1" onclick="javascript:window.history.back();" value="返回">
		</td>
		</s:else>
		
		
		    </tr>
	</table>
	</form>
	</body>
</html>

