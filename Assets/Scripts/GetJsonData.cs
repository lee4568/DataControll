using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MiniJSON;

public class GetJsonData : MonoBehaviour {

    public TextAsset jsonData;
    public Dictionary<string, object> UnitData;
    public GameObject Unit;

	void Start ()
   {
        //    string unitData = Json.Serialize(jsonData);
        //    Debug.Log(unitData);
        var dict = Json.Deserialize(jsonData.ToString()) as Dictionary<string, object>; 
        List<object> unitInfo = dict["UnitInfo"] as List<object>;
        for (int i = 0; i < unitInfo.Count; i++)
        {
            Dictionary<string, object> unitData = unitInfo[i] as Dictionary<string, object>;
            GameObject UnitOBJ = Instantiate(Unit) as GameObject;

            UnitOBJ.GetComponent<UnitSc>().unitName = unitData["이름"].ToString();
            UnitOBJ.GetComponent<UnitSc>().Hp = int.Parse(unitData["체력"].ToString());
            UnitOBJ.GetComponent<UnitSc>().Mp = int.Parse(unitData["마나"].ToString());
            UnitOBJ.GetComponent<UnitSc>().Atk = int.Parse(unitData["공격력"].ToString());
        }

    }
	 
}
