using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataLoader : MonoBehaviour {

	public string inputUserName;
	public string inputPassword;

	string LoginURL = "localhost/SeminariosGit2/api_php/public/usuario/authenticate";


	IEnumerator Start(){
		//LoginToDB ();
		WWWForm form = new WWWForm ();
		form.AddField ("email", "xx");
		//form.AddField ("password", inputPassword);

		WWW www = new WWW(LoginURL,form);
		yield return www;
		Debug.Log(www.text);
}

	void Update(){
		
	}


	/*IEnumerator LoginToDB(){
		WWWForm form = new WWWForm ();
		form.AddField ("email", "xx");
		//form.AddField ("password", inputPassword);

		WWW www = new WWW(LoginURL,form);
		yield return www;
		Debug.Log(www.text);
	}*/

}