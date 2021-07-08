using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomePageData : MonoBehaviour
{
    public string UserID;
    public string FileName;
    public string GroupId;
    public string Date;
    public string Pdfcode;
    public string Permission;
    public string DownloadLink;

    public HomePageData(string userid, string filename, string groupid, string date, string pdfcode,string permission, string downloadlink)
    {
        UserID = userid;
        FileName = filename;
        GroupId = groupid;
        Date = date;
        Pdfcode = pdfcode;
        Permission = permission;
        DownloadLink = downloadlink;
    }
}
