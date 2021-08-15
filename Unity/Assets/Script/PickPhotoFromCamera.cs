 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class PickPhotoFromCamera : MonoBehaviour
{
    private string mainurl = "http://kreasaard.atwebpages.com/";
    private string imagesURL = "https://datacontainernew.000webhostapp.com/DSM/upload/";
    private string UploadUrl = "https://datacontainernew.000webhostapp.com/DSM/uploadpic.php";
    private string MakePdfFromServerUrl = "https://datacontainernew.000webhostapp.com/DSM/makepdfpush.php";
    private string ChangeNameFromServerUrl = "https://datacontainernew.000webhostapp.com/DSM/chagefilename.php";
    private string CheckAndGetDownloadLinkFromServerUrl = "https://datacontainernew.000webhostapp.com/DSM/checkifpdfexist.php";
    private string GetAllImagesOfGroup = "https://datacontainernew.000webhostapp.com/DSM/getallphotos.php";
    private string SetImageOrderOnServer = "https://datacontainernew.000webhostapp.com/DSM/setimageorderfromphone.php";
    private string DeleteIamgeFromImageIdUrl = "https://datacontainernew.000webhostapp.com/DSM/ondeleteimagefromphone.php";
    private string RemoveImageFromServerURL = "";

    [Header("Common Content")]
    public GameObject MoveButton;
    public GameObject PickFromCameraButton;
    public GameObject PickFromGalleryButton;

    private string groupId = "";
    private string imageId="";

    List<ImageStore> imageStore = new List<ImageStore>();

    private string m_LocalFileName = "";

    public GameObject ImageGO;
    public Transform ImagePlace;

    private int index;
    public Text ResultText;

    public GameObject CanvasGO;
    public GameObject ScreenShotGO;

    public GameObject FullScreenIamegGO;

    #region Initialization

    void Start()
    {
        firstTimeMove = false;
        ScreenShotGO.SetActive(false);
        //Initialize();
        //CreateAccountIfNotDone();
        //Screenn();
        //test();
    }

    public void GetIDAndShowContent()
    {
        imageStore.Clear();
        GameObject[] go = GameObject.FindGameObjectsWithTag("Image");
        foreach (GameObject g in go)
        {
            Destroy(g);
        }
        index = 0;
        if (saveload.currentgroupId != "")
        {
            //load and show things
            groupId = saveload.currentgroupId;

            if(saveload.havePermission!="1")
            {
                MoveButton.SetActive(true);
                PickFromCameraButton.SetActive(true);
                PickFromGalleryButton.SetActive(true);
            }
            else
            {
                MoveButton.SetActive(false);
                PickFromCameraButton.SetActive(false);
                PickFromGalleryButton.SetActive(false);
            }


            StartCoroutine(GetAllPhotosFromServer());

        }
        else
        {
            //create random group id
            Initialize();
        }
    }


    void Initialize()
    {
        index = 0;
        MoveOrderButton.SetActive(true);
        SaveOrderButton.SetActive(false);
        //check if not sasve ------------------------------TODO
        groupId =UnityEngine.Random.Range(11111, 9999999).ToString();
    }

    #region GetAllPhotosFromServer

    IEnumerator GetAllPhotosFromServer()
    {
        WWWForm form1 = new WWWForm();
        form1.AddField("id", saveload.accountID);
        form1.AddField("groupid", saveload.currentgroupId);
        WWW www = new WWW(GetAllImagesOfGroup, form1);
        yield return www;
        print(www.text);
        if (www.text.Contains("ImageID"))
        {
            string itemsDataString = www.text;
            string[] items = itemsDataString.Split(';');
            int len = items.Length;
            for (int i = 0; i < items.Length - 1; i++)
            {
                string imageid = GetDataValue(items[i], "ImageID:");
                string photopath = GetDataValue(items[i], "FileName:");

                string imageUrl = "https://datacontainernew.000webhostapp.com/DSM/upload/" + photopath;

                print("path="+imageUrl);
                GameObject go = Instantiate(ImageGO);

                go.transform.SetParent(ImagePlace.transform);
                go.transform.position = ImagePlace.position;
                go.transform.localScale = ImagePlace.localScale;
                go.transform.Find("Index").gameObject.GetComponent<Text>().text = index.ToString();
                go.transform.Find("ImageId").gameObject.GetComponent<Text>().text = imageid;
                string t = index.ToString();
                go.transform.Find("CloseButton").gameObject.GetComponent<Button>().onClick.AddListener(() => DeleteImageFromPhoneAndServer(imageid));
                go.GetComponent<Button>().onClick.AddListener(() => OpenImageOnFullScreen(imageid));
                GameObject g = go.transform.Find("Loading").gameObject;
                int indexss=index;
                StartCoroutine(PlaceImageToObject(go.GetComponent<Image>(), imageUrl, 0, g,indexss,imageid));
                index++;
                
            }
            
        }
    }

    IEnumerator PlaceImageToObject(Image go, string URL, int num,GameObject LoadingImageGO,int indexs,string imageids)
    {
        go.sprite = null;
        WWW www = new WWW(URL);
        yield return www;
        LoadingImageGO.SetActive(false);
        imageStore.Add(new ImageStore(indexs, www.texture, imageids));
        go.sprite = Sprite.Create(www.texture, new Rect(0, 0, www.texture.width, www.texture.height), new Vector2(0, 0));
        
    }

    void OpenImageOnFullScreen(string imageid)
    {
        FullScreenIamegGO.SetActive(true);
        FullScreenIamegGO.transform.Find("Image").GetComponent<Image>().sprite = null;
        foreach (ImageStore i in imageStore)
        {
            if (i.ImageID == imageid)
            {
                Texture2D t = i.TextureImage;
                FullScreenIamegGO.transform.Find("Image").GetComponent<Image>().sprite = Sprite.Create(t, new Rect(0, 0, t.width, t.height), new Vector2(0, 0));
                break;
            }
        }
        print("hello world");
    }

    public void OnCloseButtonFullScreenImage()
    {
        FullScreenIamegGO.SetActive(false);
    }

    #endregion

    #endregion

    #region GetPhotoFromGallery

    public void PickFromGalaryButton()
    {
        if (NativeGallery.IsMediaPickerBusy())
            return;

        PickImage(512);
    }

    private void PickImage(int maxSize)
    {
        NativeGallery.Permission permission = NativeGallery.GetImageFromGallery((path) =>
        {
            Debug.Log("Image path: " + path);
            m_LocalFileName = path.ToString();
            int te = UnityEngine.Random.Range(11111, 9999999);
            imageId = te.ToString();

            if (path != null)
            {
                // Create Texture from selected image
                Texture2D texture = NativeGallery.LoadImageAtPath(path, maxSize);
                
                if (texture == null)
                {
                    Debug.Log("Couldn't load texture from " + path);
                    return;
                }

                /*
                // Assign texture to a temporary quad and destroy it after 5 seconds
                GameObject quad = GameObject.CreatePrimitive(PrimitiveType.Quad);
                quad.transform.position = Camera.main.transform.position + Camera.main.transform.forward * 2.5f;
                quad.transform.forward = Camera.main.transform.forward;
                quad.transform.localScale = new Vector3(1f, texture.height / (float)texture.width, 1f);

                

                //Rect rec = new Rect(0, 0, texture.width, texture.height);
                //ProfilePic.GetComponent<Image>().sprite = Sprite.Create(texture, rec, new Vector2(0.5f, 0.5f), 100);

                
                Material material = quad.GetComponent<Renderer>().material;
                if (!material.shader.isSupported) // happens when Standard shader is not included in the build
                    material.shader = Shader.Find("Legacy Shaders/Diffuse");

                material.mainTexture = texture;
                */
                
                ScreenShotGO.SetActive(true);
                Rect rec = new Rect(0, 0, texture.width, texture.height);
                float rangecreator = texture.height / (float)texture.width;
                ScreenShotGO.transform.Find("Image").transform.GetComponent<Image>().rectTransform.localScale = new Vector3(1f, rangecreator, 1f);
                ScreenShotGO.transform.Find("Image").transform.GetComponent<Image>().sprite = Sprite.Create(texture, rec, new Vector2(0.5f, 0.5f), 100);
                ResultText.text += texture.height.ToString();
                StartCoroutine(TakeScreenShot(ScreenShotGO, texture));

                //CanvasGO.SetActive(false);

                //StartCoroutine(TakeScreenShot(CanvasGO, quad, texture));

                //Destroy(quad, 10f);

                //UploadImage(texture);
            }
        }, "Select a PNG image", "image/png", maxSize);

        //Debug.Log("Permission result: " + permission);
    }

    #endregion

    #region Capture Photo And Place

    public void CapturePhoto()
    {
        if (NativeCamera.IsCameraBusy())
            return;
        TakePicture(512);
    }

    
    private void TakePicture(int maxSize)
    {
        NativeCamera.Permission permission = NativeCamera.TakePicture((path) =>
        {
            Debug.Log("Image path: " + path);
            m_LocalFileName = path.ToString();
            int te = UnityEngine.Random.Range(11111, 9999999);
            imageId = te.ToString();

            if (path != null)
            {
                // Create a Texture2D from the captured image
                Texture2D texture = NativeCamera.LoadImageAtPath(path, maxSize);
                

               // EditorUtility.CompressTexture(texture, TextureFormat.RGB24, TextureCompressionQuality.Normal);
                if (texture == null)
                {
                    Debug.Log("Couldn't load texture from " + path);
                    return;
                }

                /*
                // Assign texture to a temporary quad and destroy it after 5 seconds
                GameObject quad = GameObject.CreatePrimitive(PrimitiveType.Quad);
                quad.transform.position = Camera.main.transform.position + Camera.main.transform.forward * 2.5f;
                quad.transform.forward = Camera.main.transform.forward;
                quad.transform.localScale = new Vector3(1f, texture.height / (float)texture.width, 1f);
                

                
                Material material = quad.GetComponent<Renderer>().material;
                if (!material.shader.isSupported) // happens when Standard shader is not included in the build
                    material.shader = Shader.Find("Legacy Shaders/Diffuse");

                material.mainTexture = texture;
                */

                ScreenShotGO.SetActive(true);
                Rect rec = new Rect(0, 0, texture.width, texture.height);
                float rangecreator = texture.height / (float)texture.width;
                ScreenShotGO.transform.Find("Image").transform.GetComponent<Image>().rectTransform.localScale = new Vector3(1f, rangecreator, 1f);
                ScreenShotGO.transform.Find("Image").transform.GetComponent<Image>().sprite = Sprite.Create(texture, rec, new Vector2(0.5f, 0.5f), 100);

                StartCoroutine(TakeScreenShot(ScreenShotGO, texture));


                //CanvasGO.SetActive(false);
                //StartCoroutine(TakeScreenShot(CanvasGO,quad, texture));
                
                // If a procedural texture is not destroyed manually, 
                // it will only be freed after a scene change
                //Destroy(texture, 5f);
                 


                //UploadImage(texture);
            }
        }, maxSize);

        Debug.Log("Permission result: " + permission);
    }

    
    #endregion

    #region OnImagedeleteButtonPressed

    void DeleteImageFromPhoneAndServer(string imageId)
    {
        StartCoroutine(DeleteImageFromPhoneAndServerWait(imageId));
    }

    IEnumerator DeleteImageFromPhoneAndServerWait(string imageId)
    {
        print("ImageId" + imageId);
        WWWForm form1 = new WWWForm();
        form1.AddField("id", saveload.accountID);
        form1.AddField("groupid", groupId);
        form1.AddField("imageid", imageId);
        WWW www = new WWW(DeleteIamgeFromImageIdUrl, form1);
        yield return www;
        print(www.text);
        if (www.text.Contains("success"))
        {
            //TODO Remove from Contentpage
            //remove from list
            for(int i=0;i<imageStore.Count;i++)
            {
                if (imageStore[i].ImageID == imageId)
                {
                    imageStore.RemoveAt(i);
                    print("Removed");
                }
            }
            ShowListData();
        }

    }

    #endregion

    #region Showing List Data

    void ShowListData()
    {
        GameObject[] ggo = GameObject.FindGameObjectsWithTag("Image");
        foreach (GameObject g in ggo)
        {
            Destroy(g);
        }

        //now show the result
        int lengthofList = imageStore.Count;
        for (int i = 0; i < lengthofList; i++)
        {
            foreach (ImageStore img in imageStore)
            {
                if (img.Index == i)
                {
                    GameObject go = Instantiate(ImageGO);

                    go.transform.SetParent(ImagePlace.transform);
                    go.transform.position = ImagePlace.position;
                    go.transform.localScale = ImagePlace.localScale;
                    go.transform.Find("Index").gameObject.GetComponent<Text>().text = i.ToString();
                    go.transform.Find("ImageId").gameObject.GetComponent<Text>().text = img.ImageID;
                    string t = i.ToString();
                    go.transform.Find("CloseButton").gameObject.GetComponent<Button>().onClick.AddListener(() => DeleteImageFromPhoneAndServer(img.ImageID));
                    go.GetComponent<Button>().onClick.AddListener(() => OpenImageOnFullScreen(img.ImageID));
                    go.GetComponent<Image>().sprite = Sprite.Create(img.TextureImage, new Rect(0, 0, img.TextureImage.width, img.TextureImage.height), new Vector2(0, 0));
                    go.transform.Find("Loading").gameObject.SetActive(false);
                   
                }
            }
        }
        print("Loaded Again");
    }

    #endregion

    #region ReOrderThings

    [Header("Reorder List")]
    public GameObject ReorderList;
    public GameObject MoveOrderButton;
    public GameObject SaveOrderButton;
    public GameObject ReorderListContainer;
    private bool firstTimeMove = false;
    public void OnMoveButtonPressed()
    {
        ReorderList.GetComponent<UnityEngine.UI.Extensions.ReorderableList>().enabled = true;

        if (firstTimeMove == true)
        {
            ReorderList.GetComponent<UnityEngine.UI.Extensions.ReorderableList>().ReStart();
            //ReorderListContainer.AddComponent<UnityEngine.UI.Extensions.ReorderableListContent>();
            foreach (Transform child in ImagePlace)
            {
                //child.gameObject.AddComponent<UnityEngine.UI.Extensions.ReorderableListElement>();
                //child.GetComponent<UnityEngine.UI.Extensions.ReorderableListElement>().IsGrabbable = true;
                //child.GetComponent<UnityEngine.UI.Extensions.ReorderableListElement>().IsTransferable = true;
            }
        }
        MoveOrderButton.SetActive(false);
        SaveOrderButton.SetActive(true);
        firstTimeMove = true;
    }

    public void OnSaveButtonPressed()
    {
        ReorderList.GetComponent<UnityEngine.UI.Extensions.ReorderableList>().enabled = false;
        try
        {
           // Destroy(ReorderListContainer.GetComponent<UnityEngine.UI.Extensions.ReorderableListContent>());
        }
        catch (Exception e)
        {
            Debug.LogException(e, this);
        }
        
        foreach (Transform child in ImagePlace)
        {
            Destroy(child.GetComponent<UnityEngine.UI.Extensions.ReorderableListElement>());
            Destroy(child.GetComponent<CanvasGroup>());
            Destroy(child.GetComponent<LayoutElement>());
        }
        MoveOrderButton.SetActive(true);
        SaveOrderButton.SetActive(false);
        CreateAndSendImageOrderToServer();
    }

    public void ChangeOrder()
    {
        StartCoroutine(ChangeOrderWait());
    }
    string strimgorder = "";
    IEnumerator ChangeOrderWait()
    {
        int inde=0;
        yield return new WaitForSeconds(0.5f);
        foreach (Transform child in ImagePlace)
        {
            print(child.transform.name);
            child.transform.Find("Index").GetComponent<Text>().text = inde.ToString();

            //save index to image id in list
            string imgid = child.transform.Find("ImageId").GetComponent<Text>().text;
            foreach(ImageStore img in imageStore)
            {
                if (img.ImageID == imgid)
                {
                    img.Index = inde;
                }
            }
            inde++;
        }
        yield return new WaitForSeconds(0.1f);
        //send data to server
        

        foreach (ImageStore img in imageStore)
        {
            strimgorder += "ImageId:" + img.ImageID + ",ImageOrder:" + img.Index+";"; 
        }
        //TODO
    }
    #endregion

    #region Creating and Sending Image Order To Server

    void CreateAndSendImageOrderToServer()
    {
        if (strimgorder!="")
        StartCoroutine(SaveImageOrderToServerWait());
    }

    IEnumerator SaveImageOrderToServerWait()
    {
        print(groupId);
        WWWForm form1 = new WWWForm();
        form1.AddField("id", saveload.accountID);
        form1.AddField("groupid", groupId);
        form1.AddField("imageorder", strimgorder);
        WWW www = new WWW(SetImageOrderOnServer, form1);
        yield return www;
        print(www.text);
    }
    #endregion

    #region UploadImageToServer

    IEnumerator TakeScreenShot(GameObject go,Texture2D texture)
    {
        yield return new WaitForSeconds(0.7f);
        int width = Screen.width;
        int height = Screen.height;
        Texture2D tex = new Texture2D(width, height, TextureFormat.RGB24, false);
        tex.ReadPixels(new Rect(0, 0, width, height), 0, 0);
        tex.Apply();
        yield return new WaitForSeconds(0.2f);
        go.SetActive(false);
        
       // Destroy(texture);
        UploadImage(tex);
    }

    void UploadImage(Texture2D texture)
    {
        StartCoroutine(NewUploadingMechanicsTroughTexture(texture, m_LocalFileName, UploadUrl));
    }

    IEnumerator NewUploadingMechanicsTroughTexture(Texture2D texture, string localFileName, string uploadURL)
    {
        GameObject go = Instantiate(ImageGO);

        Rect rec = new Rect(0, 0, texture.width, texture.height);
        go.GetComponent<Image>().sprite = Sprite.Create(texture, rec, new Vector2(0.5f, 0.5f), 100);

        go.transform.SetParent(ImagePlace.transform);
        go.transform.position = ImagePlace.position;
        go.transform.localScale = ImagePlace.localScale;
        go.transform.Find("Index").gameObject.GetComponent<Text>().text = index.ToString();
        string t = index.ToString();
        go.transform.Find("CloseButton").gameObject.GetComponent<Button>().onClick.AddListener(() => DeleteImageFromPhoneAndServer(imageId));
        go.GetComponent<Button>().onClick.AddListener(() => OpenImageOnFullScreen(imageId));
        ResultText.text += m_LocalFileName + "||||||";
        imageStore.Add(new ImageStore(index,texture,imageId));
        index++;

        byte[] bytes = texture.EncodeToJPG(); //Can also encode to jpg, just make sure to change the file extensions down below
        //Destroy(texture);
        ResultText.text = "Encoded";
        WWWForm postForm = new WWWForm();
        postForm.AddField("id", saveload.accountID);
        postForm.AddField("groupId", groupId);
        postForm.AddField("imageId", imageId);
        postForm.AddField("imageorder", index);//--------------------------------------TODO Change Order OF Image And Send when we go to make pdf
        postForm.AddBinaryData("theFile", bytes, "screenshot.jpg", "image/jpg");
        WWW upload = new WWW(uploadURL, postForm);
        yield return upload;

        if (upload.error == null)
        {
            Debug.Log("upload done :" + upload.text);
            ResultText.text = "upload done " + upload.text;
            //RefreshImage();
        }
        else
        {
            Debug.Log("Error during upload: " + upload.error);
            ResultText.text = "Error during upload: " + upload.text;
        }

        if (upload.text.Contains("success"))
        {
            //remove loading animation from that image
            //-------------------------------------------TODO
            go.transform.Find("Loading").gameObject.SetActive(false);
        }
    }

    IEnumerator UploadFileCo(Texture2D texture,string localFileName, string uploadURL)
    {
        GameObject go = Instantiate(ImageGO);

        Rect rec = new Rect(0, 0, texture.width, texture.height);
        go.GetComponent<Image>().sprite = Sprite.Create(texture, rec, new Vector2(0.5f, 0.5f), 100);

        go.transform.SetParent(ImagePlace.transform);
        go.transform.position = ImagePlace.position;
        go.transform.localScale = ImagePlace.localScale;
        go.transform.Find("Index").gameObject.GetComponent<Text>().text = index.ToString();
        string t = index.ToString();
        go.transform.Find("CloseButton").gameObject.GetComponent<Button>().onClick.AddListener(() => DeleteImageFromPhoneAndServer(t));
        index++;
        ResultText.text += m_LocalFileName + "||||||";





        WWW localFile = new WWW("file:///" + m_LocalFileName);
        //statusText.text = "file:///" + m_LocalFileName;
        print(m_LocalFileName);
        yield return localFile;
        //statusText.text = statusText.text + "| " + localFile.text;
        if (localFile.error == null)
        {
            Debug.Log("Loaded file successfully");
            //statusText1.text = "Loaded file successfully";
        }
        else
        {
            Debug.Log("Open file error: " + localFile.error);
            //statusText1.text = "Loaded file error: " + localFile.error;
            yield break; // stop the coroutine here
        }
        WWWForm postForm = new WWWForm();
        // version 1
        //postForm.AddBinaryData("theFile",localFile.bytes);
        // version 2
        saveload.Load();
        postForm.AddField("id", saveload.accountID);
        postForm.AddField("groupId", groupId);
        postForm.AddField("imageId", imageId);
        postForm.AddBinaryData("theFile", localFile.bytes, m_LocalFileName, "text/plain");

        print("short out");
        print(m_LocalFileName.LastIndexOf("/"));
        int n = m_LocalFileName.LastIndexOf("/");

        print(m_LocalFileName.Substring(n + 1));
        string fileName = m_LocalFileName.Substring(n + 1);

        WWW upload = new WWW(uploadURL, postForm);
        yield return upload;
        if (upload.error == null)
        {
            Debug.Log("upload done :" + upload.text);
            ResultText.text = "upload done " + upload.text;
            //RefreshImage();
        }
        else
        {
            Debug.Log("Error during upload: " + upload.error);
            ResultText.text = "Error during upload: " + upload.text;
        }

        if (upload.text.Contains("sucess"))
        {
            //remove loading animation from that image
            //-------------------------------------------TODO
            go.transform.Find("Loading").gameObject.SetActive(false);
        }
    }

    #endregion

    #region ConvertToPdf

    [Header("Change Pannel")]
    public GameObject ChangeNamePannel;

    public void ConvertPdfFromServer()
    {
        ChangeNamePannel.SetActive(true);
        StartCoroutine(MakePdfFromServer());
    }

    IEnumerator MakePdfFromServer()
    {
        WWWForm form1 = new WWWForm();
        form1.AddField("id", saveload.accountID);
        form1.AddField("groupId", groupId);
        form1.AddField("filename", m_LocalFileName);
        WWW www = new WWW(MakePdfFromServerUrl, form1);
        yield return www;

        if (www.text.Contains("Success"))
        {
            ResultText.text = "Success";
        }
        else if (www.text.Contains("Failed"))
        {
            ResultText.text="Retry Window Appear:"+www.text;
        }
    }

    #endregion

    #region ChangeNameOfFile

    [Header("Change Name Area")]
    public InputField ChangeNameInputField;
    public GameObject ChangeNameButton;
    public GameObject ChangeNameLoadingButton;

    [Header("Download Pdf Area")]
    public GameObject DownloadPannel;
    public GameObject LoadingIcon;
    public GameObject DownloadButton;

    private string DownloadUrl = "";

    public void ChangeNameFromServer()
    {
        
        string s = ChangeNameInputField.text;
        if (s != "" && s != " ")
        {
            StartCoroutine(ChangeNameDelayServer(s));
            ChangeNameLoadingButton.SetActive(true);
            ChangeNameButton.SetActive(false);
        }
    }

    IEnumerator ChangeNameDelayServer(string name)
    {
        WWWForm form1 = new WWWForm();
        form1.AddField("id", saveload.accountID);
        form1.AddField("groupId", groupId);
        form1.AddField("filename", name);
        WWW www = new WWW(ChangeNameFromServerUrl, form1);
        yield return www;

        if (www.text.Contains("Success"))
        {
            ChangeNamePannel.SetActive(false);
            DownloadPannel.SetActive(true);
            LoadingIcon.SetActive(true);
            DownloadButton.SetActive(false);

            WaitAndDownlaodFromServer();
            ResultText.text = "Wait and download";
        }
        else if (www.text.Contains("Failed"))
        {
            ResultText.text = "failed to changed|" + www.text;
        }
        else
        {
            ResultText.text = "name not changed|" + www.text;
        }
    }

    #endregion

    #region Wait and get download

    public void WaitAndDownlaodFromServer()
    {
        StartCoroutine(GetDownloadLinkFromServer());
    }

    IEnumerator GetDownloadLinkFromServer()
    {
        WWWForm form1 = new WWWForm();
        form1.AddField("id", saveload.accountID);
        form1.AddField("groupId", groupId);
        WWW www = new WWW(CheckAndGetDownloadLinkFromServerUrl, form1);
        yield return www;

        if (www.text.Contains("Link"))
        {
            DownloadUrl = GetDataValue(www.text, "Link:");
            ResultText.text = www.text + "Link got";
            LoadingIcon.SetActive(false);
            DownloadButton.SetActive(true);
        }
        else if (www.text.Contains("Wait"))
        {
            yield return new WaitForSeconds(2);
            ResultText.text = www.text + "dowlaod wait";
            StartCoroutine(GetDownloadLinkFromServer());
        }
        else
        {
            ResultText.text = www.text+"dowlaod error";
        }
    }

    public void OnDownloadThatLink()
    {
        Application.OpenURL(DownloadUrl);
    }

    #endregion

    #region CommonFunction

    void RemoveLoadImages()
    {
        //--------------------Remove-----------
        GameObject[] go = GameObject.FindGameObjectsWithTag("Image");
        foreach (GameObject g in go)
        {
            Destroy(g);
        }

        index = 0;
        
    }

    void SetImageFromPath(string path)
    {
        int maxSize = 64;
        if (path != null)
        {

            Texture2D texture = NativeCamera.LoadImageAtPath(path, maxSize);

            if (texture == null)
            {
                Debug.Log("Couldn't load texture from " + path);
                return;
            }


            GameObject go = Instantiate(ImageGO);

            Rect rec = new Rect(0, 0, texture.width, texture.height);
            go.GetComponent<Image>().sprite = Sprite.Create(texture, rec, new Vector2(0.5f, 0.5f), 100);

            go.transform.SetParent(ImagePlace.transform);
            go.transform.position = ImagePlace.position;
            go.transform.localScale = ImagePlace.localScale;
            go.transform.Find("Index").gameObject.GetComponent<Text>().text = index.ToString();
            string t = index.ToString();
            go.transform.Find("CloseButton").gameObject.GetComponent<Button>().onClick.AddListener(() => DeleteImageFromPhoneAndServer(t));

            //Update List from path if Exist
            int pathIndex = GetIndexFromPathList(path);
            imageStore[pathIndex].TextureImage = texture;
            imageStore[pathIndex].Index = index;

            index++;
        }
    }

    int GetIndexFromPathList(string path)
    {
        int p = 0;
        for (int i = 0; i < imageStore.Count; i++)
        {
            //if (path == imageStore[i].ImagePath)
            //{
            //    p = i;
            //}
        }

        return p;
    }

    string GetDataValue(string data, string index)
    {
        string value = data.Substring(data.IndexOf(index) + index.Length);
        if (value.Contains(","))
            value = value.Remove(value.IndexOf(","));
        return value;
    }

    int RoundUp(int toRound)
    {
        if (toRound % 10 == 0) return toRound;
        return (10 - toRound % 10) + toRound;
    }

    int RoundDown(int toRound)
    {
        return toRound - toRound % 10;
    }

    #endregion
}

/*
   private void RecordVideo()
   {
       NativeCamera.Permission permission = NativeCamera.RecordVideo((path) =>
       {
           Debug.Log("Video path: " + path);
           if (path != null)
           {
               // Play the recorded video
               Handheld.PlayFullScreenMovie("file://" + path);
           }
       });

       Debug.Log("Permission result: " + permission);
   }
    */