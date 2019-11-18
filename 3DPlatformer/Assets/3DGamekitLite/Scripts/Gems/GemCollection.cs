using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemCollection : MonoBehaviour
{ 
    public Text gemCountText;
    public int gemCount;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //display the amount of gems that the player has
        gemCountText.text = gemCount.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        //value = 1
        if (other.tag == "RedGem")
        {
            gemCount += 1;
            Destroy(other.gameObject);
        }
        //value  = 2
        if (other.tag == "GreenGem")
        {
            gemCount += 2;
            Destroy(other.gameObject);
        }
        //value = 5
        if (other.tag == "PurpleGem")
        {
            gemCount += 5;
            Destroy(other.gameObject);
        }
        //value = 10
        if (other.tag == "YellowGem")
        {
            gemCount += 10;
            Destroy(other.gameObject);
        }

    }

}
