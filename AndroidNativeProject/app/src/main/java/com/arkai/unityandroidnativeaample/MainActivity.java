package com.arkai.unityandroidnativeaample;

import android.os.Bundle;

import com.unity3d.player.UnityPlayer;
import com.unity3d.player.UnityPlayerActivity;


public class MainActivity extends UnityPlayerActivity
{
    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
    }

    public void SendMessage(String objectName, String methodName, String message)
    {
        try
        {
            UnityPlayer.UnitySendMessage(objectName, methodName, message);
        }
        catch (Exception e)
        {
            e.printStackTrace();
        }
    }
}
