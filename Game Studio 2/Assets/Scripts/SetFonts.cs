using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetFonts : MonoBehaviour
{
    public Font alienFont;
    public Font englishFont;

    public Text sayDialogText;

    void SwitchFont(){
        if(gameObject.tag == "SentientPlant"){
            sayDialogText.font = alienFont;
        } else {
            sayDialogText.font = englishFont;
        }
    }

}
