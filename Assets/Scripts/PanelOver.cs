using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PanelOver : PanelBase {
    public Text lb_score, lb_hight_score;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    public void onShow(int score) {
        int hs = PlayerPrefs.GetInt("hightScore", 0);
        lb_score.text = "Score: " + score;
        if (score >= hs) {
            hs = score;
            PlayerPrefs.SetInt("hightScore", hs);
            PlayerPrefs.Save();
        }
        lb_hight_score.text = "Hight Score: " + hs;
        base.onShow();
    }

    public void onClick(string name) {
        switch (name) {
            case "Tryagain":
                uiController.setUI(UIController.STATE_UI.READY);
                uiController.panelPlay.reset();
                break;
            case "Home":
                uiController.setUI(UIController.STATE_UI.HOME);
                break;
        }
    }
}
