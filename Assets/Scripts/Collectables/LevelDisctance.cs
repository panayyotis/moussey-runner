using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelDisctance : MonoBehaviour
{
    public GameObject disDisplay;
    public GameObject disEndDisplay;
    public int disRun;
    public bool addingDis = false;
    public float disDelay = 0.35f;
    
    void Update()
    {
        if (addingDis == false) 
        {
            addingDis = true;
            StartCoroutine(AddingDis());
        }
    }

    IEnumerator AddingDis()
    {
        disRun += 1;
        disDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = "" +  disRun;
        disEndDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = "" +  disRun;
        yield return new WaitForSeconds(disDelay);
        addingDis = false;
    }
}
