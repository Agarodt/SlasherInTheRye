using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
       transform.Rotate(0f,10f,0f);
       transform.position = Vector3.MoveTowards(
       transform.position,
       new Vector3(PlayerController.instance.transform.position.x,PlayerController.instance.transform.position.y,PlayerController.instance.transform.position.z), Time.deltaTime * 10);
      
    }

   void OnTriggerEnter(Collider other)
   {
    if (other.tag == "Player")
    {
        StatisticScript.instance.money += 15;
        Destroy(gameObject);

    }
   }
}
