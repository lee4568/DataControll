using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text.RegularExpressions;
using System.Text;

public class TestCSV : MonoBehaviour {

    public string csvFileName;
    

    public GameObject unitPrefab;

	void Start ()
    {
       
        List<Dictionary<string, object>> data = CSVReader.Read(csvFileName);
        //for (int i = 0; i < data.Count; i++)
        //{
        //   Debug.Log(i + "번의 ::: " + "종족은 ::: " + data[i]["종족"] + " ::: 이름은 ::: "+ data[i]["유닛이름"] + " ::: " +" HP::: "+ data[i]["체력"]);
        //}

        for (int i = 0; i < data.Count; i++)
        {
            GameObject unitOBJ = Instantiate(unitPrefab) as GameObject;
            UnitSc unitDetail = unitOBJ.GetComponent<UnitSc>();
            switch (data[i]["종족"].ToString())
            {
                case "프로토스":
                    unitDetail.unitTribe = UnitSc.UNITTRIBE.PROTOSS;
                    break;
                case "저그":
                    unitDetail.unitTribe = UnitSc.UNITTRIBE.ZERG;
                    break;
                case "테란":
                    unitDetail.unitTribe = UnitSc.UNITTRIBE.TERRAN;
                    break;
            }
            unitDetail.unitName = data[i]["유닛이름"].ToString();
            unitDetail.Hp = int.Parse(data[i]["체력"].ToString());
            unitDetail.Mp = int.Parse(data[i]["마나"].ToString());
            unitDetail.Atk = int.Parse(data[i]["공격력"].ToString());
            unitDetail.Def = int.Parse(data[i]["방어력"].ToString());
            unitDetail.Shd = int.Parse(data[i]["쉴드"].ToString());
            unitDetail.unitAsp = float.Parse(data[i]["공격속도"].ToString());
            unitDetail.unitMsp = float.Parse(data[i]["이동속도"].ToString());
           unitDetail.unitRange = float.Parse(data[i]["사거리"].ToString());
         }
    }
}
