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
        //set fonts
        sayDialogText.font = alienFont;

        player.timer.AddTime(1); // talking to plants takes time i guess
        flowchart.ExecuteBlock("PlantTalk");

        
    }

    public override void OnTileExit(){
        sayDialogText.font = englishFont;
    }
}
