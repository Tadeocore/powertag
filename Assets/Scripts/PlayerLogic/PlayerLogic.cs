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

    }

    private void OnTriggerEnter(Collider tr)
    {
        if (tr.tag.Equals("PlayerMancha"))
        {
            tr.gameObject.SetActive(SetEresMancha(true));
        }
        if (GetEresMancha())
        {
            tr.tag = "PlayerMancha";
        }

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