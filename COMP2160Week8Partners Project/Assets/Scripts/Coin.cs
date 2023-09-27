using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class Coin : MonoBehaviour
{
    [SerializeField] private int coinValue;
    [SerializeField] private Events Event;


    private void Awake()
    {
        Event = GameObject.Find("GameManager").GetComponent<Events>();
    }
    public void OnCoinCollect()
    {
        Event.CoinCollect.Invoke(coinValue);
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
