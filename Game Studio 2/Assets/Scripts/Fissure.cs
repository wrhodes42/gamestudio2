using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fissure : Tile
{
    public List<GameObject> allFissures = new List<GameObject>();

    public bool teleported = false;

    public override void OnTileEnter()
    {
        player.timer.AddTime(1); // falling takes time i guess

        StartCoroutine(FissureWarp());
    }

    public override void OnTileExit()
    {
        teleported = false;
    }

    IEnumerator FissureWarp(){
        yield return new WaitForSeconds(0.5f);

        if(teleported == false){

            //get array of fissures on map, convert to list
            GameObject[] fissuresArray = GameObject.FindGameObjectsWithTag("Fissure");

            for (int i = 0; i < fissuresArray.Length; i++)
            {
                allFissures.Add(fissuresArray[i]);
            }

            //remove self from list
            allFissures.Remove(gameObject);

            //pick a random fissure from the set
            GameObject selectedFissure = allFissures[Random.Range(0, allFissures.Count)];

            player.playerPos = selectedFissure.GetComponent<Fissure>().coord;

            teleported = true;
            allFissures.Clear();
        }
    }
}
