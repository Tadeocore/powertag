using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLogic : GameManager
{
    public bool fMancha;
    GameManager game;


    void Update()
    {
        fMancha = GetEresMancha();
        if (tag == "PlayerMancha")
        {
            gameObject.SetActive(SetEresMancha(true));
        }   if (tag == "PlayerMancha")
            {
                gameObject.SetActive(SetEresMancha(false));
            }
    }

    private void OnTriggerEnter(Collider other)
    {
        var player1 = GameObject.FindGameObjectWithTag("PlayerMancha");
        var otherPlayer = GameObject.FindGameObjectWithTag("PlayerLibre");

        switch (other.tag)
        {
            case "PlayerLibre":
                otherPlayer.tag = "PlayerMancha";
                
                break;
        }

        /*if (other.tag == "PlayerMancha")
        {
            other.gameObject.SetActive(SetEresMancha(true));
            Player.SetActive(SetEresMancha(false));
        }   if (GetEresMancha())
            {
                other.tag = "PlayerMancha";
            }
            else
            {
                other.tag = "PlayerLibre";
            }*/


    }
}
/*if (tag == "PlayerMancha")
{
    game.SetEresMancha(true);
}
if (game.GetEresMancha())
{
    tag = "PlayerMancha";
}*/