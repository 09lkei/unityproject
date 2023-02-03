using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reload : MonoBehaviour
{
    public Image InnerImage; //inner image of health bar
    public Attack playerAttack; //script that contains how long the delay is


    float AttackDelay;
    float DelayCurrent;
    float startTime;
    

    void Start()
    {
    }

    void Update()
    {
        if (playerAttack.canShoot == false)
        {
            DelayCurrent = Time.time - startTime; //sets DelayCurrent as how long it has been since starttime has been called
            InnerImage.fillAmount = Mathf.Clamp(DelayCurrent / AttackDelay, 0, 1f);
        }
    }


    public void UpdateReload(float delayTime)
    {
        startTime = Time.time;
        AttackDelay = delayTime;
        DelayCurrent = 0;
    }


}


