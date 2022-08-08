using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField] private Image[] badgeImages = new Image[4];
    [SerializeField] private Hero hero;

    private void Update()
    {
        // If the player clicks the mouse buttons...
        if (Input.GetMouseButtonDown(0))
        {
            // ...add a badge
            hero.badges++;
            hero.ClampBadges();
        }
        if (Input.GetMouseButtonDown(1))
        {
            // ...remove a badge
            hero.badges--;
            hero.ClampBadges();
        }

        UpdateBadgeUI();
    }

    private void UpdateBadgeUI()
    {
        // Loop through all of our badge images on our UI.
        for (int i = 0; i < badgeImages.Length; i++)
        {
            // Hide them all.
            badgeImages[i].gameObject.SetActive(false);

            // Show a number of them based on "hero.badges" integer.
            if (i < hero.badges) badgeImages[i].gameObject.SetActive(true);
        }
    }
}
