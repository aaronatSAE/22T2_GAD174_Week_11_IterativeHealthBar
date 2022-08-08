using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    public int badges = 4;

    public void ClampBadges()
    {
        if (badges < 0) badges = 0;
        if (badges > 4) badges = 4;
    }
}
