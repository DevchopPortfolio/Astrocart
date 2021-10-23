using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class trackCreate_page : MonoBehaviour
{
    
    public GameObject linkToPrefab;
    public GameObject tracksContainerLink;
    GameObject lineLink;
    line_page linepageLink;    
    

    
    int gridSize;
    int tilesCount;
    float tileSize;
    
    float trackStartRando;        
    int trackPointsLowest;
    int trackPointsHighest;
    
    float trackRandomness;
    float trackMagnitude;    
    



    void Start()
    {
        
        gridSize = 7;
        tilesCount = (int) Mathf.Pow(gridSize, 2);
        tileSize = 20f; 

        trackStartRando = 0.01f;        
        trackPointsLowest = 3;
        trackPointsHighest = 15;
        
        trackRandomness = 3f;
        trackMagnitude = 4f;
        


        for (int p = 0; p<tilesCount; p++) {

            lineLink = Instantiate(linkToPrefab);            
            lineLink.transform.SetParent(tracksContainerLink.transform);

            linepageLink = lineLink.GetComponent<line_page>();     

            float xCoord = ((p % gridSize) - gridSize/2) * tileSize;
            // xCoord += Random.Range(-tileSize * trackStartRando, tileSize * trackStartRando);
            
            float yCoord = (float) (System.Math.Floor(((p / gridSize) - gridSize/2) * tileSize));            
            yCoord += Random.Range(-tileSize * trackStartRando, tileSize * trackStartRando);

            float rando = (Random.Range(0, 10) * Random.Range(0, 10)) * 0.01f;
            int trackPoints = (int) (Mathf.Lerp(trackPointsLowest, trackPointsHighest, rando));

            for (int i = 0; i<trackPoints; i++) {                                                    
                xCoord += Random.Range(-trackRandomness, trackRandomness) + trackMagnitude;
                yCoord += Random.Range(-trackRandomness, trackRandomness);
                
                Vector2 newCoords = new Vector2(xCoord, yCoord);
                linepageLink.updateLine(newCoords);
            }
        }

    }
    
}
