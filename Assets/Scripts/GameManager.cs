using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool eresMancha;
    public bool GetEresMancha()
    {
        return eresMancha;
    }
    public bool SetEresMancha(bool M)
    {
        eresMancha = M;
        return eresMancha;
    }

    private void Awake()
    {
        if (gameObject.tag == "PlayerMancha")
        {
            eresMancha = true;
        }
        if (gameObject.tag == "PlayerLibre")
        {
            eresMancha = false;
        }
    }


}
