using UnityEngine;
using System.Collections;

public class PanelHome : PanelBase {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void onClick(string name) {
        switch (name) {
            case "Play":
                uiController.setUI(UIController.STATE_UI.READY);
                break;
        }
    }
}
