using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagScript : MonoBehaviour
{
    public static BagScript instance;
    public int collect;
    public bool full;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
       if (!full)
       {
       for (int i = 0; i <= collect; i++)
       {
         gameObject.transform.GetChild(collect / 4).GetComponent<MeshRenderer>().enabled = true;
       }
       
       }

       if (collect >= 40)
       {
         full = true;
       }

       if (collect == 0)
       {
        for (int i = 0; i <= 9; i++ )
       {
         gameObject.transform.GetChild(i + 1).GetComponent<MeshRenderer>().enabled = false;
         

       }
       }
    }
}
