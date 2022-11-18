using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;
 
public class TextInstructions : MonoBehaviour 
{
    public TMP_Text instructionsText;
    public Image grey;
    public TMP_Text continueText;
 
     // Use this for initialization
    void Start()
        {
            instructionsText.text = "Please help... I am dying... I am 239 years old and I have been practicing witchcraft my whole life...";
            Time.timeScale = 0;
            grey.enabled = true;
        }
        
    void Update () {
        {
            if(Input.anyKeyDown)
            {
                instructionsText.text = "I need to collect all the potions to become young again... Can you help me?";
                continueText.enabled = true;
            }
        }
         {
            if(Input.GetKeyDown("space"))
            {
                Time.timeScale = 1;
                Destroy(gameObject);
                grey.enabled = false;
            }
        }
        }
}