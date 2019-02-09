using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndroidNativeSample : MonoBehaviour
{

    public void OnCallActivityFuncButtonClick()
    {
        AndroidJavaClass unity = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject unityActivity = unity.GetStatic<AndroidJavaObject>("currentActivity");

        unityActivity.Call("SendMessage", "AndroidNativeReceive", "Receiver", "Hello World!");
    }

    public void OnCallClassFuncButtonClick()
    {
        AndroidJavaObject utility = new AndroidJavaObject("com.arkai.unityandroidnativeaample.plugin.Utility");
        utility.Call("ShowToast", "Hello World!");
    }

}
