using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    public Button ButtonEnableToggle;
    public Button ButtonToggleText;
    public Button ButtonSlotLever;
    public TextMeshProUGUI Title;
    public TextMeshProUGUI SideText;
    public GameObject SlotWindow1;
    public GameObject SlotWindow2;
    public GameObject SlotWindow3;
    public AudioSource BaseAudio;
    public AudioSource RGBAudio;

    // Start is called before the first frame update
    void Start()
    {
        ButtonToggleText.interactable = false;
        BaseAudio.enabled = true;
        RGBAudio.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ToggleText()
    {
        Debug.Log("Toggle Button Was clicked");
        if (SideText.text.Equals("Welcome to heck"))
        {
            SideText.text = "Welcome to hell";
        }
        else
        {
            SideText.text = "Welcome to heck";
        }
    }

    public void PullSlotLever()
    {
        SlotWindow1.GetComponent<SlotRoller>().RollSlots();
        SlotWindow2.GetComponent<SlotRoller>().RollSlots();
        SlotWindow3.GetComponent<SlotRoller>().RollSlots();
    }

    public void DisableSlotLever()
    {
        // disable the toggle button
        ButtonSlotLever.GetComponent<Button>().interactable = false;
    }

    public void EnableSlotLever()
    {
        // disable the toggle button
        ButtonSlotLever.GetComponent<Button>().interactable = true;
    }

    public void RGBToggleAudio()
    {
        BaseAudio.enabled = false;
        RGBAudio.enabled = true;
    }
}
