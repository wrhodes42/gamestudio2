using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class SentientPlant : Tile
{
    public Flowchart flowchart;

    public Font alienFont;
    public Font englishFont;

    public Text sayDialogText;

    public override void OnTileEnter()
    {
        
        player.timer.AddTime(1); // talking to plants takes time i guess
        if (flowchart.GetBooleanVariable("isTranslatorMade") == false) {
            //set fonts
            sayDialogText.font = alienFont;
        } else
        {
            sayDialogText.font = englishFont;
        }

        if (flowchart.GetBooleanVariable("isTranslatorMade") == false && flowchart.GetBooleanVariable("plantVisited") == false)
        {
            flowchart.ExecuteBlock("PlantTalk");
            sayDialogText.font = englishFont;
            flowchart.ExecuteBlock("PlantTalkDebrief");
        }
        if (flowchart.GetBooleanVariable("plantVisited") == false)
        {

        }

    }

    public override void OnTileExit(){
        sayDialogText.font = englishFont;
    }
}
