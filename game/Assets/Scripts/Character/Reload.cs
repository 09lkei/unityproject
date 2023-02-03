using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reload : MonoBehaviour
{
    public Image InnerImage;
    public Attack player;
    private float AttackDelay = player.returnAttackDelay();
    private float CurrentDelay = AttackDelay;


    public void UpdateReload()
    {
        //InnerImage.fillAmount = Mathf.Clamp(player.DelayCurrent / player.AttackDelay, 0, 1f);
    }


    void Start()
    {
        UpdateReload();
    }


    void Update()
    {
        //if (player.canShoot == false)
        //{
        //    DelayCurrent = DelayCurrent - 0.04f;
        //    UpdateReload(DelayCurrent);
        //}
    }
}
