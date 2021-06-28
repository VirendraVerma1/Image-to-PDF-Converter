using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class MainController : MonoBehaviour
{
    private string CreateAccountUrl = "https://datacontainernew.000webhostapp.com/DSM/createaccount.php";
    private string GetAllPdfUrl = "https://datacontainernew.000webhostapp.com/DSM/getmypdf.php";
    private string DeleteEveryFileDetails = "https://datacontainernew.000webhostapp.com/DSM/onpdfdeletewithimagesfromphone.php";
    private string AttachPDF = "https://datacontainernew.000webhostapp.com/DSM/onpdfdeletewithimagesfromphone.php";

    List<HomePageData> homepagedata = new List<HomePageData>();
    public GameObject HomePage;
    public GameObject PdfContentPage;

    void Awake()
    {
        saveload.Load();
    }

    void Start()
    {
        SharePannel.SetActive(false);
        HomePage.SetActive(true);
        PdfContentPage.SetActive(false);
        saveload.currentgroupId = "";
        CreateAccountIfNotDone();
        
    }

    void CreateAccountIfNotDone()
    {
        saveload.accountID = "1";//--------------------------------------TODO Remove it
        if (saveload.accountID == "")
        {
            StartCoroutine(CreateAccount());
        }
        else
        {
            print(saveload.accountID);
            GetAllPdf();
        }
    }

    IEnumerator CreateAccount()
    {
        string name =UnityEngine.Random.Range(11111, 9999999).ToString();
        WWWForm form1 = new WWWForm();
        form1.AddField("name", name);
        WWW www = new WWW(CreateAccountUrl, form1);
        yield return www;
        print(www.text);
        if (www.text.Contains("ID"))
        {
            saveload.accountID = GetDataValue(www.text, "ID:");
            saveload.accountName = name;
            saveload.Save();
            print(saveload.accountID);
            GetAllPdf();
        }
    }

    #region Get all pdf

    [Header("Get all pdf")]
    public GameObject HomeContentBox;
    public Transform PlaceContenthome;

    private string dowloadLink;
    List<GameObject> optionBox = new List<GameObject>();

    void GetAllPdf()
    {
        GameObject[] go = GameObject.FindGameObjectsWithTag("Box");
        foreach (GameObject g in go)
        {
            Destroy(g);
        }
        StartCoroutine(GetAllPdfServer());
    }

    IEnumerator GetAllPdfServer()
    {
        WWWForm form1 = new WWWForm();
        form1.AddField("id", saveload.accountID);
        WWW www = new WWW(GetAllPdfUrl, form1);
        yield return www;
        print(www.text);
        optionBox.Clear();
        if (www.text.Contains("ID"))
        {
            string itemsDataString = www.text;
            string[] items = itemsDataString.Split(';');
            int len = items.Length;

            for (int i = 0; i < items.Length - 1; i++)
            {
                string userid = GetDataValue(items[i], "UserID:");
                string name = GetDataValue(items[i], "FileName:");
                string date = GetDataValue(items[i], "Date:");
                string groupid = GetDataValue(items[i], "GroupID:");
                string pdfcode = GetDataValue(items[i], "PDFCode:");

                string download = "https://datacontainernew.000webhostapp.com/" + userid + "/" + groupid + "/" + name + ".pdf";

                homepagedata.Add(new HomePageData(userid, name, groupid, date, pdfcode, download));

                GameObject go = Instantiate(HomeContentBox);
                go.transform.SetParent(PlaceContenthome.transform);
                go.transform.localScale = Vector3.one;
                go.transform.Find("PdfName").GetComponent<Text>().text = name;
                go.transform.Find("Detail").GetComponent<Text>().text = date;
                go.transform.Find("Info").GetComponent<Text>().text = groupid;
                go.transform.Find("MenuBar").transform.Find("ShareButton").GetComponent<Button>().onClick.AddListener(() => OnLinkPDFSharableButtonPressed(groupid));
                go.transform.Find("MenuBar").transform.Find("ShareButton").GetComponent<Button>().onClick.AddListener(() => OnShareLinkButtonPressed(groupid));
                go.transform.Find("MenuBar").transform.Find("DownloadButton").GetComponent<Button>().onClick.AddListener(() => OnDownloadButtonPressed(groupid));
                go.transform.Find("MenuBar").transform.Find("DeleteButton").GetComponent<Button>().onClick.AddListener(() => OnDeleteButtonPressed(groupid));
                go.GetComponent<Button>().onClick.AddListener(() => OpenPdfPages(groupid));
                int n = i;
                go.transform.Find("MenuButton").transform.GetComponent<Button>().onClick.AddListener(() => OnFileMenuButtonPressed(n));
                optionBox.Add(go.transform.Find("MenuBar").gameObject);
                go.transform.Find("MenuBar").gameObject.SetActive(false);
            }
        }
    }

    //---------------------------------------------------------on menu open close
    void OnFileMenuButtonPressed(int groupid)
    {
        if(optionBox[groupid].gameObject.active)
            optionBox[groupid].gameObject.SetActive(false);
        else
            optionBox[groupid].gameObject.SetActive(true);
    }

    //----------------------------------------------------------Ondelete button function
    public void OnDeleteButtonPressed(string groupid)
    {
        StartCoroutine(DeletePdfFromGroupId(groupid));
    }

    IEnumerator DeletePdfFromGroupId(string groupId)
    {
        WWWForm form1 = new WWWForm();
        form1.AddField("id", saveload.accountID);
        form1.AddField("groupid", groupId);
        WWW www = new WWW(DeleteEveryFileDetails, form1);
        yield return www;

        if (www.text.Contains("success"))
        {
            //remove the pdf from home pannel 
            GameObject[] go = GameObject.FindGameObjectsWithTag("Box");
            foreach (GameObject g in go)
            {
                if (g.transform.Find("Info").GetComponent<Text>().text.ToString() == groupId)
                {
                    Destroy(g);
                }
                
            }
        }
        
    }

    //----------------------------------------------------------On share button function
    public void OnShareLinkButtonPressed(string groupid)
    {
        //fetch link from list
        string filename="";
        string sharePdfKey = "";
        foreach (HomePageData g in homepagedata)
        {
            if (g.GroupId == groupid)
            {
                dowloadLink = g.DownloadLink;
                filename=g.FileName;
                sharePdfKey = g.Pdfcode;
            }
        }

        //show share file

        ShareFile(dowloadLink, filename, sharePdfKey);
    }

    //--------------------------------------------------------on link Button function
    public void OnLinkPDFSharableButtonPressed(string groupid)
    {
        //fetch link from list
        string filename = "";
        string sharePdfKey = "";
        foreach (HomePageData g in homepagedata)
        {
            if (g.GroupId == groupid)
            {
                dowloadLink = g.DownloadLink;
                filename = g.FileName;
                sharePdfKey = g.Pdfcode;
            }
        }

        //show share file
        //TODO on Link button pressed update share link to 1 and show msg pop up next time update to 0
        
    }

    //----------------------------------------------------------On Download button function
    public void OnDownloadButtonPressed(string groupid)
    {
        foreach (HomePageData g in homepagedata)
        {
            if (g.GroupId == groupid)
            {
                dowloadLink = g.DownloadLink;
                break;
            }
        }
        Application.OpenURL(dowloadLink);
    }


    //----------------------------------------------------------On Open PDF button function
    public void OpenPdfPages(string groupid)
    {
        HomePage.SetActive(false);
        PdfContentPage.SetActive(true);
        if (groupid != "")
        {
            saveload.currentgroupId = groupid;
            gameObject.GetComponent<PickPhotoFromCamera>().GetIDAndShowContent();
        }
        else
        {
            saveload.currentgroupId = "";
            gameObject.GetComponent<PickPhotoFromCamera>().GetIDAndShowContent();
        }
    }

    #endregion

    #region Show Share of file

    [Header("Share File")]
    public GameObject SharePannel;
    public Text FileNameText;
    public InputField shareinputfield;
    public InputField shareKeyInputField;

    void ShareFile(string link,string filename, string sharekey)
    {
        FileNameText.text = filename;
        SharePannel.SetActive(true);
        shareinputfield.text = link;
        shareKeyInputField.text = sharekey;
    }

    public void OnCloseShareButtonPressed()
    {
        SharePannel.SetActive(false);
    }

    #endregion

    #region Add, Attach PDF

    [Header("Attach PDF")]
    public InputField KeyCodeInputField;
    public Text ErrorTextAttachPDF;

    void OnAddOrAttachPDFButtonPressed()
    {
        string code=KeyCodeInputField.text;
        if (code != null && code != "")
        {
            StartCoroutine(AddAttachedPDF(code));
        }
        else
        {
            ErrorTextAttachPDF.text = "Error : enter pdf code";
        }
    }

    IEnumerator AddAttachedPDF(string pdfcode)
    {
        WWWForm form1 = new WWWForm();
        form1.AddField("pdfcode", pdfcode);
        WWW www = new WWW(GetAllPdfUrl, form1);
        yield return www;
        print(www.text);
        optionBox.Clear();
        if (www.text.Contains("ID"))
        {

        }

    }

    #endregion

    public void OnContentBackButtonPressed()
    {
        SceneManager.LoadScene(0);
        HomePage.SetActive(true);
        PdfContentPage.SetActive(false);
    }

    string GetDataValue(string data, string index)
    {
        string value = data.Substring(data.IndexOf(index) + index.Length);
        if (value.Contains("|"))
            value = value.Remove(value.IndexOf("|"));
        return value;
    }


    public GameObject DownloadPannel;
    public GameObject FileNamePannel;
    public void closeButtonpannel()
    {
        FileNamePannel.SetActive(false);
        DownloadPannel.SetActive(false);
    }
}
