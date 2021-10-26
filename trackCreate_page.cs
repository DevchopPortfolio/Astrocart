using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class trackCreate_page : MonoBehaviour
{
    
    public GameObject linePrefabLink;    
    GameObject lineLink;
    line_page linepageLink;    
    
    public GameObject foodPrefabLink;

    int gridSize = 7;               //each tile gets 1 line
    int tilesCount;                 //total number of tiles
    float tileSize = 20f;           //size of each tile in meters
    
    // float trackStartRandoPos  = 0.1f;   //randomize start pos of track
    int pointsPerTrackLowest = 3;       //smallest tracks have this many points
    int pointsPerTrackHighest = 15;     //largest tracks have this many points
    
    float trackRandomness = 3f;         //randomness of points
    float trackMagnitude = 4f;          //minimum horizontal distance between points
    

    void Start()
    {
                
        tilesCount = (int) Mathf.Pow(gridSize, 2);
        
        for (int p = 0; p<tilesCount; p++) {

            lineLink = Instantiate(linePrefabLink);                        
            linepageLink = lineLink.GetComponent<line_page>();
            
            // determine pos
            float xCoord = ((p % gridSize) - gridSize/2) * tileSize;
            float yCoord = (float) (System.Math.Floor(((p / gridSize) - gridSize/2) * tileSize));
            // yCoord += Random.Range(-tileSize * trackStartRandoPos, tileSize * trackStartRandoPos);

            // determine number of points
            float rando = (Random.Range(0, 10) * Random.Range(0, 10)) * 0.01f;
            int trackPoints = (int) (Mathf.Lerp(pointsPerTrackLowest, pointsPerTrackHighest, rando));

            // generate points
            for (int i = 0; i<trackPoints; i++) {                                                    
             
                xCoord += Random.Range(-trackRandomness, trackRandomness) + trackMagnitude;
                yCoord += Random.Range(-trackRandomness, trackRandomness);
                
                Vector2 newCoords = new Vector2(xCoord, yCoord);
                linepageLink.updateLine(newCoords);

                if (Random.Range(0f, 10f) > 8f) {                    
                    Instantiate(foodPrefabLink, new Vector3 (xCoord, yCoord + 0.6f, 0f), Quaternion.identity);
                }
                
            }
        }
    }    
}
