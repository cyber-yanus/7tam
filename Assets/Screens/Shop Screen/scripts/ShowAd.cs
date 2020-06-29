using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class ShowAd : MonoBehaviour
{
#if UNITY_ANDROID || UNITY_IOS
    public static int countPress = 0;

    void Start()
    {
        if (Advertisement.isSupported)
        {
            Advertisement.Initialize(""); //ID here
        }
    }

    public static void AdShow(int showEvery)
    {
        countPress += 1;

        if (countPress % showEvery == 0 && Advertisement.IsReady())
        {
            Advertisement.Show();
        }
    }

    public static bool AdShow()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show();
            return true;
        }
        else
        {
            return false;
        }
    }
#endif
}
