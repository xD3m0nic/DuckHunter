using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCamera : MonoBehaviour
{
    WebCamTexture wbCamtexture;

    public string path;
    public RawImage imgDisplayForPhotoSnap;

    // Start is called before the first frame update
    void Start()
    {
        wbCamtexture = new WebCamTexture();
        GetComponent<Renderer>().material.mainTexture = wbCamtexture;
        wbCamtexture.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
