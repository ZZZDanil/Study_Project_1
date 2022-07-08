using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class InterstitialAdvertisement : IAdvertisement, IUnityAdsLoadListener, IUnityAdsShowListener
{

    public void ShowAdvertisement(string placementId)
    {
        if (Advertisement.isInitialized)
        {
            Advertisement.Load(placementId, this);
            Advertisement.Show(placementId, this);
        }
    }
    public void OnUnityAdsShowComplete(string placementId, UnityAdsShowCompletionState showCompletionState)
    {
        Debug.Log($"Interstitial ads status: {showCompletionState}");
    }
    public void OnUnityAdsAdLoaded(string placementId){}
    public void OnUnityAdsFailedToLoad(string placementId, UnityAdsLoadError error, string message){}
    public void OnUnityAdsShowClick(string placementId){}
    public void OnUnityAdsShowFailure(string placementId, UnityAdsShowError error, string message){}
    public void OnUnityAdsShowStart(string placementId){}
}
