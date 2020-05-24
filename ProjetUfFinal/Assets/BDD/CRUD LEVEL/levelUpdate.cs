using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelUpdate : MonoBehaviour
{
    string URL = "http://localhost/mydb/levelUpdate.php";
    public string InputNom, InputCreateur, InputCreation, InputResultat, WhereField, WhereCondition;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            UpdateLevel (InputNom,InputCreateur,InputCreation,InputResultat,WhereField,WhereCondition);
        }
    }

    public void UpdateLevel(string nom, string createur, string creation, string resultat, string wF, string wC){
        WWWForm form = new WWWForm ();
        form.AddField ("editNom", nom);
        form.AddField ("editCreateur", createur);
        form.AddField ("editCreation", creation);
        form.AddField ("editResultat", resultat);

        form.AddField ("whereField", wF);
        form.AddField ("whereCondition", wC);

        WWW www = new WWW (URL, form);
    }
}
