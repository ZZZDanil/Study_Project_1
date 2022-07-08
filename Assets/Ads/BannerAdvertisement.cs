using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class BannerAdvertisement : IAdvertisement
{
    BannerPosition bannerPosition = BannerPosition.BOTTOM_CENTER;
    public bool isShowing = false;
    public void ShowAdvertisement(string placementId)
    {
        if (Advertisement.isInitialized)
        {
            Advertisement.Banner.SetPosition(bannerPosition);
            Advertisement.Banner.Load(placementId);
            Advertisement.Banner.Show(placementId);

        }
    }
    public void HideAdvertisement()
    {
        Advertisement.Banner.Hide();
    }
}
