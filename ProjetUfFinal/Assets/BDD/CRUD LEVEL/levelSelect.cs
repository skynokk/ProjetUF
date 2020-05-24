using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelSelect : MonoBehaviour
{
    string URL = "http://localhost/mydb/levelSelect.php";
    public string [] levelData;
    
    // Start is called before the first frame update
    IEnumerator Start()
    {
        WWW level = new WWW (URL);
        yield return level;
        string levelDataString = level.text;
        levelData = levelDataString.Split (';');
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
