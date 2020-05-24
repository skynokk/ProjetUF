using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelInsert : MonoBehaviour
{
    string URL = "http://localhost/mydb/levelInsert.php";
    public string InputNom, InputCreateur, InputCreation, InputResultat;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            AddLevel (InputNom,InputCreateur,InputCreation,InputResultat);
        }
    }

    public void AddLevel(string nom, string createur, string creation, string resultat){
        WWWForm form = new WWWForm ();
        form.AddField ("addNom", nom);
        form.AddField ("addCreateur", createur);
        form.AddField ("addCreation", creation);
        form.AddField ("addResultat", resultat);

        WWW www = new WWW (URL, form);
    }
}
