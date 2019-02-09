using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndroidNativeReceive : MonoBehaviour 
{
    public void Receiver(string message) 
    {
        Debug.LogError("Receive Message: " + message);
    }
}
