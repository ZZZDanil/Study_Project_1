using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class TestExampleAds : MonoBehaviour, IUnityAdsInitializationListener
{

    [SerializeField]
    string gameId = "4829703";

    [SerializeField]
    string placementIdInterstitial = "Interstitial_Android";

    [SerializeField]
    string placementIdRewarded = "Rewarded_Android";

    [SerializeField]
    string placementIdBanner = "Banner_Android";

    private BannerAdvertisement bannerAdvertisement = new BannerAdvertisement();

    private void Awake()
    {
        InitAds();
    }

    private void InitAds()
    {
        Advertisement.Initialize(gameId, true, this);
    }

    public void ShowInterstitialAds()
    {
        new InterstitialAdvertisement().ShowAdvertisement(placementIdInterstitial);
    }

    public void ShowRewardedAds()
    {
        new RewardedAdvertisement().ShowAdvertisement(placementIdRewarded);
    }

    public void ShowBannerAds()
    {
        if (!bannerAdvertisement.isShowing)
        {
            Debug.Log("Show banner");
            bannerAdvertisement.ShowAdvertisement(placementIdBanner);
            bannerAdvertisement.isShowing = true;
        }
        else
        {
            Debug.Log("Hide banner");
            bannerAdvertisement.HideAdvertisement();
            bannerAdvertisement.isShowing = false;
        }
    }

    public void OnInitializationComplete(){}
    public void OnInitializationFailed(UnityAdsInitializationError error, string message){}
}
