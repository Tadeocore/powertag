using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamesettinfs : MonoBehaviour
{

    public int targetFramerate = 60;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = targetFramerate;
    }
}
