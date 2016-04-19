using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PanelReady : PanelBase {
    public Text time_count;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (isStart) {
            if (Input.GetMouseButtonDown(0)) {
                uiController.setUI(UIController.STATE_UI.PLAY);
                isStart = false;
                base.onHide();
            }
        }
    }

    public new void onShow() {
        base.onShow();
        StartCoroutine(countTime());
    }
    bool isStart = false;
    IEnumerator countTime() {
        time_count.text = "3";
        yield return new WaitForSeconds(1);
        time_count.text = "2";
        yield return new WaitForSeconds(1);
        time_count.text = "1";
        yield return new WaitForSeconds(1);
        time_count.text = "Tap to start!";
        isStart = true;
    }
}
