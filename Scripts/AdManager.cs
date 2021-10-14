using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using GoogleMobileAds.Api;
using UnityEngine.SceneManagement;

public class AdManager : MonoBehaviour
{
    string appID = "ca - app - pub - 1108512141621771~4527788575";
    string adUnitId = "ca-app-pub-1108512141621771/4182273834";

    private InterstitialAd inter;

    // Start is called before the first frame update
    void Start()
    {
        MobileAds.Initialize(appID);
        requestRewardBasedVideo();
    }

    public void requestRewardBasedVideo()
    {
        this.inter = new InterstitialAd(adUnitId);
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the interstitial with the request.
        this.inter.LoadAd(request);

        // Called when an ad request has successfully loaded.
        this.inter.OnAdLoaded += HandleOnAdLoaded;
        // Called when an ad request failed to load.
        this.inter.OnAdFailedToLoad += HandleOnAdFailedToLoad;
        // Called when an ad is shown.
        this.inter.OnAdOpening += HandleOnAdOpened;
        // Called when the ad is closed.
        this.inter.OnAdClosed += HandleOnAdClosed;
        // Called when the ad click caused the user to leave the application.
        this.inter.OnAdLeavingApplication += HandleOnAdLeavingApplication;
    }

    public void showRewardBasedVideoAdd()
    {
        if (this.inter.IsLoaded())
        {
            Debug.Log("changa");
            this.inter.Show();
            requestRewardBasedVideo();
        }
    }

    public void HandleOnAdLoaded(object sender, EventArgs args)
    {
    }

    public void HandleOnAdFailedToLoad(object sender, AdFailedToLoadEventArgs args)
    {
        SceneManager.LoadScene(1);
    }

    public void HandleOnAdOpened(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdOpened event received");
    }

    public void HandleOnAdClosed(object sender, EventArgs args)
    {
        SceneManager.LoadScene(1);
    }

    public void HandleOnAdLeavingApplication(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdLeavingApplication event received");
    }

   // The OnAdFailedToLoad event contains special event arguments.It passes an instance of HandleAdFailedToLoadEventArgs with a Message describing the error:

}   
