using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reload : MonoBehaviour
{
    public Image InnerImage;
    public Attack player;
    float AttackDelay = 0;
    float DelayCurrent = 0;
    

    void Start()
    {
        float AttackDelay = player.returnAttackDelay();
        float DelayCurrent = AttackDelay;
        UpdateReload();
    }

    void Update()
    {

    }

    public void UpdateReload()
    {
        InnerImage.fillAmount = Mathf.Clamp(DelayCurrent / AttackDelay, 0, 1f);
    }




}



    //void Update()
    //{
    //    if (player.canShoot == false)
    //    {
    //        DelayCurrent = DelayCurrent - 0.04f;
    //        UpdateReload(DelayCurrent);
    //    }
    //}



