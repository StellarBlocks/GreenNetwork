/**
 * 
 */
package com.greennetwork.controller;

import java.util.HashMap;
import javax.annotation.Resource;
import javax.servlet.http.HttpServletRequest;

import org.apache.commons.logging.Log;
import org.apache.commons.logging.LogFactory;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;

import com.greennetwork.service.IUserService;




/**
 * @author Administrator
 * @Date 2017��3��19��
 * Description:
 */

@Controller
public class UserController {
	
	private final static Log logger=LogFactory.getLog(UserController.class);
	@Resource
	private IUserService iUserService=null;
	
	//�����¼ҳ��
	@RequestMapping(value="/Login")
	public String Login(){
		logger.info("Login called");
		return "Login";
	}
	
	@RequestMapping(value="/Register")
	public String Register(){
		logger.info("Register Called");
		return "Register";
	}
	
	//��֤��¼��
	@RequestMapping(value="/verify.action")
	public String verifyLogin(HttpServletRequest request){
		HashMap<String, String> hashMap=new HashMap<String, String>();
		hashMap.put("name", request.getParameter("name"));
		hashMap.put("password", request.getParameter("password"));
		String result=iUserService.verifyLogin(hashMap);
		logger.info("��֤���Ϊ"+result);
		
		return "redirect:"+result;
	}
	
}
