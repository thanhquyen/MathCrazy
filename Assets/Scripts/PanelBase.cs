using UnityEngine;
using System.Collections;

public class PanelBase : MonoBehaviour {
    public UIController uiController;
    public bool isShow;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void onShow() {
        isShow = true;
        gameObject.SetActive(true);
    }

    public void onHide() {
        isShow = false;
        gameObject.SetActive(false);
    }
}
