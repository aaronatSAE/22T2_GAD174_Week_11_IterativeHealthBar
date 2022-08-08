using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IterativeBar : MonoBehaviour
{
    [SerializeField] Image[] elements = new Image[4];

    private void UpdateIterativeBar()
    {
        for (int i = 0; i < elements.Length; i++)
        {
            elements[i].gameObject.SetActive(false);
        }
    }
}
