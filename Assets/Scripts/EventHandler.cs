using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class EventHandler : MonoBehaviour
{
    public SlotRoller slotRoller1;
    public SlotRoller slotRoller2;
    public SlotRoller slotRoller3;
    public GameObject main;

    private bool lock1;
    private bool lock2;

    // Start is called before the first frame update
    void Start()
    {
        lock1 = true;
        lock2 = true;

        // first roller window
        GameObject window1 = GameObject.Find("SlotWindow1");
        slotRoller1 = window1.GetComponent<SlotRoller>();
        slotRoller1.StopRoll += HandleStopRoll;

        // second roller window
        GameObject window2 = GameObject.Find("SlotWindow2");
        slotRoller2 = window2.GetComponent<SlotRoller>();
        slotRoller2.StopRoll += HandleStopRoll;

        // third roller window
        GameObject window3 = GameObject.Find("SlotWindow3");
        slotRoller3 = window3.GetComponent<SlotRoller>();
        slotRoller3.StopRoll += HandleStopRoll;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void HandleStopRoll()
    {
        if (lock1)
        {
            lock1 = false;
        }
        else if (lock2)
        {
            lock2 = false;
        }
        else
        {
            lock1 = true;
            lock2 = true;
            main.GetComponent<Main>().EnableSlotLever();
        }
    }
}
