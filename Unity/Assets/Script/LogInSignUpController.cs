using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogInSignUpController : MonoBehaviour
{
    [Header("LogIn and SignUp Pannel")]
    public GameObject LogInPannel;
    public GameObject SignUpPannel;

    
    // Start is called before the first frame update
    void Start()
    {
        DisablePannels();
    }

    #region Pannel

    public void OnLoginButtonPressed()
    {
        DisablePannels();
        LogInPannel.SetActive(true);
    }

    public void OnSignButtonPressed()
    {
        DisablePannels();
        SignUpPannel.SetActive(true);
    }

    #endregion

    #region LogIn

    [Header("LogIn")]
    public InputField LoginEmailInputField;
    public InputField LoginPasswordInputField;
    public Text LogInErrorText;

    public void OnLogInButtonPressed()
    {
        string email = LoginEmailInputField.text;
        string password = LoginPasswordInputField.text;
        // validation part
        LogInErrorText.text = "";
        if (email!=null&&email!=""&&password!=null&&password!="")
        {
            StartCoroutine(LogInFromServer(email, password));
        }
    }

    IEnumerator LogInFromServer(string email, string password)
    {
        WWWForm form1 = new WWWForm();
        form1.AddField("id", saveload.accountID);
        form1.AddField("email", email);
        form1.AddField("password", password);
        WWW www = new WWW(saveload.mainServerLink + saveload.logInServerLink, form1);
        yield return www;
        print(www.text);

        //conditions
        //-if not your account the show the error message
        //-if error then server error
        //-if nothing then connect to internet
        if(www.text=="")
        {
            //not connected
            LogInErrorText.text = "Not connected to internet";
        }
        else if (www.text == "error")
        {
            //not connected
            LogInErrorText.text = "Server Error";
        }
        else if (www.text.Contains("success"))
        {
            //login successfully
            saveload.accountID = GetDataValue(www.text, "ID:");
            saveload.accountName = name;
            saveload.Save();
            LogInErrorText.text = "Successfully LogIn";
            DisablePannels();
            SceneManager.LoadScene(0);
        }
        else if (www.text.Contains("not your account"))
        {
            LogInErrorText.text = "Not your account";
        }

    }

    #endregion

    #region SignUp

    [Header("SignUp")]
    public InputField SignUpNameInputField;
    public InputField SignUpEmailInputField;
    public InputField SignUpPasswordInputField;
    public Text SignUpErrorText;

    public void OnSignUpButtonPressed()
    {
        string name = SignUpNameInputField.text;
        string email = SignUpEmailInputField.text;
        string password = SignUpPasswordInputField.text;
        // validation part
        SignUpErrorText.text = "";
        if (email != null && email != "" && password != null && password != "" && name != null && name != "")
        {
            StartCoroutine(SignUpFromServer(name,email, password));
        }
    }

    IEnumerator SignUpFromServer(string name,string email, string password)
    {
        WWWForm form1 = new WWWForm();
        form1.AddField("id", saveload.accountID);
        form1.AddField("email", email);
        form1.AddField("password", password);
        WWW www = new WWW(saveload.mainServerLink + saveload.signupServerLink, form1);
        yield return www;
        print(www.text);

        if (www.text == "")
        {
            //not connected
            SignUpErrorText.text = "Not connected to internet";
        }
        else if (www.text == "error")
        {
            //not connected
            SignUpErrorText.text = "Server Error";
        }
        else if (www.text.Contains("success"))
        {
            //login successfully
            saveload.accountID = GetDataValue(www.text, "ID:");
            saveload.accountName = name;
            saveload.Save();
            SignUpErrorText.text = "Successfully LogIn";
            DisablePannels();
            SceneManager.LoadScene(0);
        }
        else if (www.text.Contains("not your account"))
        {
            SignUpErrorText.text = "Not your account";
        }

    }

    #endregion


    #region Common Region

    private void DisablePannels()
    {
        LogInPannel.SetActive(true);
        SignUpPannel.SetActive(true);
    }

    string GetDataValue(string data, string index)
    {
        string value = data.Substring(data.IndexOf(index) + index.Length);
        if (value.Contains("|"))
            value = value.Remove(value.IndexOf("|"));
        return value;
    }

    #endregion
}
