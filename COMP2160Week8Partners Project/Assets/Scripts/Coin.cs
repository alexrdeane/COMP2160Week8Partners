using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private int coinValue;

    public void OnCoinCollect()
    {
        //Events.CoinCollect.Invoke(coinValue);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            OnCoinCollect();
            Destroy(this.gameObject);
        }
    }
}
