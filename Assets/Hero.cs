using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    public int badges = 4;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            badges--;
            ClampBadges();
        }
        else if (Input.GetMouseButtonDown(1))
        {
            badges++;
            ClampBadges();
        }
    }

    private void ClampBadges()
    {
        if (badges < 0) badges = 0;
        if (badges > 4) badges = 4;
    }
}
