using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reload : MonoBehaviour
{
    public Image InnerImage;
    public Attack player;
    float AttackDelay;
    float DelayCurrent;
    float startTime;
    

    void Start()
    {
        AttackDelay = player.returnAttackDelay();
        DelayCurrent = 0;
    }

    void Update()
    {
    }


    public void UpdateReload()
    {
        startTime = Time.time;
        Debug.Log("HI");
        while (player.canShoot == false)
        {
            
            DelayCurrent = DelayCurrent + (startTime - Time.time);
            InnerImage.fillAmount = Mathf.Clamp(DelayCurrent / AttackDelay, 0, 1f);
        }
        
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



