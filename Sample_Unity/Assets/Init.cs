using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;
using System;
using System.Text;
using anysdk;

public class Init
{
	private static Init _instance;
	private string appKey = "0914CB16-BAEE-790E-808E-3A37B8FFBE3F";
	private string appSecret = "62bee0ddb86bdeccb8acd959765041cc";
	private string privateKey = "96C273AB03E1A798BA1AD0C38004871F";
	
	private string oauthLoginServer = "http://oauth.qudao.info/api/OauthLoginDemo/Login.php";
	
	public static Init getInstance() {
		if( null == _instance ) {
			_instance = new Init();
		}
		return _instance;
	}
	
	Init()
	{
		AnySDK.getInstance ().init (appKey, appSecret, privateKey, oauthLoginServer);


	}
	
	
}
