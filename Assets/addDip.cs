using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addDip : MonoBehaviour
{
    public GameObject objectToAdd;
    public int foodValue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonPress()
    {
        if (cookManagerGameFlow.currDip != null) {
            Destroy(cookManagerGameFlow.currDip);
        }

        GameObject newObject = Instantiate(objectToAdd, new Vector3(-0.169f,-0.02f,0.253f), Quaternion.identity);
        newObject.SetActive(true); // spawn object above plate 
        cookManagerGameFlow.currDip = newObject;

        gameFlow.plateValue[12] = foodValue;
        Debug.Log("Array Contents: " + string.Join(", ", gameFlow.plateValue));
    }
}
