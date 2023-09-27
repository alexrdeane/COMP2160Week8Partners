using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Events;

public class Events : MonoBehaviour
{
    public static Events instance;

    public UnityEvent<int> CoinCollect;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(this);
    }

    public void TestInvokeCoin10()
    {
        CoinCollect?.Invoke(10);
    }
}
