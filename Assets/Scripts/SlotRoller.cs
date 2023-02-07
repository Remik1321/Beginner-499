using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SlotRoller : MonoBehaviour
{

    public List<Image> images;
    private int listIndex;
    public float RollDelay;

    // event for signalling that roll is done
    public delegate void SlotRollEnd();
    public event SlotRollEnd StopRoll;

    // Start is called before the first frame update
    void Start()
    {
        int loopCount;
        listIndex = 5;
        for(loopCount = 0; loopCount < images.Count; loopCount += 1)
        {
            images[loopCount].enabled = false;
        }
        images[listIndex].enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RollSlots()
    {
        StartCoroutine(RollSlotsLoop(RollDelay));
        /*
        int loopCount;
        listIndex = 2;
        for (loopCount = 0; loopCount < images.Count; loopCount += 1)
        {
            images[loopCount].enabled = false;
        }
        images[listIndex].enabled = true;
        */
    }

    IEnumerator RollSlotsLoop(float delayTime)
    {
        int loopCount;
        int loopLimit = 30 + Random.Range(0, 20 + images.Count);
        Debug.Log("Loop" + loopLimit.ToString() + " Times.");

        for(loopCount = 0; loopCount < loopLimit; loopCount += 1)
        {
            listIndex = loopCount % images.Count;
            if( listIndex == 0 )
            {
                images[7].enabled = false;
            }
            else
            {
                images[listIndex - 1].enabled = false;  
            }
            images[listIndex].enabled = true;
            yield return new WaitForSeconds(delayTime);
        }
        this.StopRoll();
        yield return null;
    }
}
