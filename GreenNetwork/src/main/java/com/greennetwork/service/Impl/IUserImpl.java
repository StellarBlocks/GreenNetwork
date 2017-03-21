/**
 * 
 */
package com.greennetwork.service.Impl;

import java.util.HashMap;

import javax.annotation.Resource;

import org.springframework.stereotype.Service;

import com.greennetwork.dao.UserMapper;
import com.greennetwork.service.IUserService;

/**
 * @author Administrator
 * @Date 2017Äê3ÔÂ21ÈÕ
 * Description:
 */

@Service()
public class IUserImpl implements IUserService {

	/* (non-Javadoc)
	 * @see com.greennet.service.IUserService#verifyLogin(java.util.HashMap)
	 */
	@Resource
	private UserMapper userMapper;
	
	public String verifyLogin(HashMap<String, String> hashMap) {
		// TODO Auto-generated method stub
		
		Integer result=userMapper.verifyLogin(hashMap);
		if(result==null)
			return "Register";
		else if(result==0)
			return "Login";
		else if(result==1)
			return "Success";
		else {
			return "Error";
		}
	}

}
