using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MiniJSON;
using UnityEngine.UI;

public class GetUserData : MonoBehaviour {

    public TextAsset userData;
    public Text[] text;
    int Win = 0;
    int Lose = 0;

    void Start ()
    {
        var dict = Json.Deserialize(userData.ToString()) as Dictionary<string, object>; 
        Win = int.Parse(dict["win"].ToString());
        Lose = int.Parse(dict["lose"].ToString());
        float percent = (float)Win / ((float)Win + (float)Lose)*100;

        text[0].text = ("ID : " + dict["userID"]).ToString();
        text[1].text = ("닉네임 : " + dict["username"]).ToString();
        text[2].text = ("승리 : " + dict["win"]).ToString();
        text[3].text = ("패배 : " + dict["lose"]).ToString();
        text[4].text = (dict["lastedconnect"]).ToString();
        text[5].text = ("승률 : " + (float)percent).ToString();

    }


    void Update ()
    {

    }
}
