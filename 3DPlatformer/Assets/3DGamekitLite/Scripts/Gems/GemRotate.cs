using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemRotate : MonoBehaviour
{
    public GameObject[] redGems;
    public GameObject[] purpleGems;
    public GameObject[] yellowGems;
    public GameObject[] greenGems;
    public int rotateSpeed;

    // Update is called once per frame
    void Update()
    {
        //find all of the gems if any are destroyed then it removes them from the array
        //so there should be no null references
        redGems = GameObject.FindGameObjectsWithTag("RedGem");
        purpleGems = GameObject.FindGameObjectsWithTag("PurpleGem");
        yellowGems = GameObject.FindGameObjectsWithTag("YellowGem");
        greenGems = GameObject.FindGameObjectsWithTag("GreenGem");

        //rotates the gems
        foreach (GameObject go in redGems)
        {
            go.transform.Rotate(Vector3.up * Time.deltaTime * rotateSpeed);
        }
        foreach (GameObject go in purpleGems)
        {
            go.transform.Rotate(Vector3.up * Time.deltaTime * rotateSpeed);
        }
        foreach (GameObject go in yellowGems)
        {
            go.transform.Rotate(Vector3.up * Time.deltaTime * rotateSpeed);
        }
        foreach (GameObject go in greenGems)
        {
            go.transform.Rotate(Vector3.up * Time.deltaTime * rotateSpeed);
        }
    }
}
