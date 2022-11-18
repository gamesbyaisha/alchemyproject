using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;
 
public class TextInstructions : MonoBehaviour 
{
    public TMP_Text instructionsText;
    public Image grey;
 
     // Use this for initialization
    void Start()
        {
            instructionsText.text = "Please help... I am dying";
            Time.timeScale = 0;
            grey.enabled = true;
        }
        
    void Update () {
        {
            if(Input.anyKeyDown)
            {
                instructionsText.text = "I need to collect all the potions to become young again... Can you help me? Press space";
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