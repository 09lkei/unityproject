using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reload : MonoBehaviour
{
    public image InnerImage;
    public Attack player;
    private float DelayCurrent = player.AttackDelay;


    public void UpdateReload()
    {
        InnerImage.fillAmount = Mathf.Clamp(player.DelayCurrent / player.AttackDelay, 0, 1f);
    }



    void Start()
    {
        UpdateReload();
    }


    void Update()
    {
        if (player.canShoot == false)
        {
            DelayCurrent = DelayCurrent - 0.04f;
            UpdateReload(DelayCurrent);
        }
    }
}
