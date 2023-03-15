using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TruckScript : MonoBehaviour
{
    public static TruckScript instance;
    public int truckCollect;
    public bool truckFull;
    public GameObject Coin;
    public Transform CoinSpawner;
  
    void Start()
    {
        instance = this;
       
    }

     void Update()
    {
       if (!truckFull)
       {
       for (int i = 0; i <= truckCollect; i++)
       {
         gameObject.transform.GetChild(truckCollect).GetComponent<MeshRenderer>().enabled = true;
       }
       if (truckCollect >= 6)
       {
         truckFull = true;
       }
       }
       
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && BagScript.instance.collect >= 40)
        {
          truckCollect += 1;
          Instantiate(Coin, CoinSpawner.position, CoinSpawner.rotation);
          BagScript.instance.collect = 0;
          BagScript.instance.full = false;
          
        }
    }
}
