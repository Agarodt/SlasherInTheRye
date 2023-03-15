using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StatisticScript : MonoBehaviour
{
    public static StatisticScript instance;
    public int money;
    public int moneyGoal = 90;
    public GameObject Good;
    public bool win;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()

    {    if (!BagScript.instance.full)
         {
         GetComponent<Text>().text = "In Bag: " + BagScript.instance.collect.ToString() + "/40"+
         "\nMoney: " + money.ToString() + " $" +
         "\nGoal " + moneyGoal.ToString() + "$";
         GetComponent<Text>().color = Color.green;
         }
         if (BagScript.instance.full)
         {
         GetComponent<Text>().text = "Full!\nGo to truck";
         GetComponent<Text>().color = Color.magenta;
         }

         if (TruckScript.instance.truckFull)
         {  if (!win)
            {
            Good.SetActive(true);
            StartCoroutine(NewLevel());
            win = false;
            
           }
        }

   

     
}

     IEnumerator NewLevel()
        {
            yield return new WaitForSeconds(5f);
            SceneManager.LoadScene(0);
        }
}
