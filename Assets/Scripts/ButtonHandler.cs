using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour
{
    public Main main;
    public SlotRoller slot;
    public Button ButtonEnableToggle;
    public Button ButtonToggleText;
    public Button ButtonPullLever;
    public Button ButtonRGBBackground;
    private static Color orange = new Color(1.0f, 0.64f, 0.0f);
    private static Color purple = new Color(0.58f, 0.0f, 0.83f);

    // Start is called before the first frame update
    void Start()
    {
        ButtonEnableToggle.onClick.AddListener(EnableOnCLick);
        ButtonToggleText.onClick.AddListener(ToggleText);
        ButtonRGBBackground.onClick.AddListener(RGB);
    }

    void EnableOnCLick()
    {
        Debug.Log("enable button was clikced");

        ButtonToggleText.interactable = !(ButtonToggleText.interactable);
    }

    public void ToggleText()
    {
        main.ToggleText();
    }

    public void RollSlots()
    {
        main.PullSlotLever();
        main.DisableSlotLever();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void RGB()
    {
        main.SideText.text = "Welcome To Hell";
        ButtonEnableToggle.interactable = false;
        ButtonRGBBackground.interactable = false;
        ButtonToggleText.interactable = false;
        StartCoroutine(RGBLoop());
        main.RGBToggleAudio();
    }

    public IEnumerator RGBLoop()
    {
        while (true)
        {
            Camera.main.backgroundColor = purple;
            yield return new WaitForSeconds(0.3f);

            Camera.main.backgroundColor = Color.blue;
            yield return new WaitForSeconds(0.3f);

            Camera.main.backgroundColor = Color.cyan;
            yield return new WaitForSeconds(0.3f);

            Camera.main.backgroundColor = Color.green;
            yield return new WaitForSeconds(0.3f);

            Camera.main.backgroundColor = Color.yellow;
            yield return new WaitForSeconds(0.3f);

            Camera.main.backgroundColor = orange;
            yield return new WaitForSeconds(0.3f);

            Camera.main.backgroundColor = Color.red;
            yield return new WaitForSeconds(0.3f);

            Camera.main.backgroundColor = Color.magenta;
            yield return new WaitForSeconds(0.3f);
        }
    }
}
