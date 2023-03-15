using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RyeScript : MonoBehaviour
{
    public bool mowDown;
    public bool startMow;
    public bool grow;
    public GameObject RyeTop;
    

    void Start()
    {
        RyeTop = this.gameObject.transform.GetChild(1).gameObject;

    }

    void Update()
    {
        if (!mowDown)
        {
           
            RyeTop.SetActive(true);
            gameObject.tag = "Rye";
        }
        if (mowDown && !startMow)
        {
            
            StartCoroutine(Mowing());
            startMow = true;
            
        }
      
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && !BagScript.instance.full)
        {
        if (!mowDown)
        {
        mowDown = true;
        
        }
        
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player" && !grow)
        {
      
        mowDown = false;
        startMow = false;
        
        
        }
    }

    IEnumerator Mowing()
    {
     yield return new WaitForSeconds(1.9f);
     if (mowDown)
     {
     RyeTop.SetActive(false);
     gameObject.tag = "Untagged";
     grow = true;
     StartCoroutine(Grow());
     BagScript.instance.collect += 5;
     }
    }

    IEnumerator Grow()
    {
        yield return new WaitForSeconds(75f);
        mowDown = false;
        startMow = false;
        grow = false;

    
    }
}
