using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelDelete : MonoBehaviour
{
    string URL = "http://localhost/mydb/levelDelete.php";
    public string WhereField, WhereCondition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            DeleteLevel (WhereField,WhereCondition);
        }
    }

    public void DeleteLevel(string wF, string wC){
        WWWForm form = new WWWForm ();
        form.AddField ("whereField", wF);
        form.AddField ("whereCondition", wC);

        WWW www = new WWW (URL, form);
    }
}
