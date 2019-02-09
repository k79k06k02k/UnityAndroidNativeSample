package com.arkai.unityandroidnativeaample.plugin;

import android.widget.Toast;
import com.unity3d.player.UnityPlayer;

public class Utility
{
    public void ShowToast(String message)
    {
        Toast.makeText(UnityPlayer.currentActivity.getApplicationContext(), message, Toast.LENGTH_LONG).show();
    }
}
