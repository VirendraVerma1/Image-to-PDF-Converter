using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageStore 
{
    public int Index;
    public Texture2D TextureImage;
    public string ImageID;

    public ImageStore(int index,Texture2D texture,string imageid)
    {
        Index = index;
        TextureImage = texture;
        ImageID = imageid;
    }
}
