using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public GameObject camintro;
    public GameObject camPlayer;
    // Start is called before the first frame update
    void Start()
    {
        camPlayer.SetActive(false);
        camintro.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void cameraactivation()
    {
        camPlayer.SetActive(true);
        camintro.SetActive(false);
    }
}
