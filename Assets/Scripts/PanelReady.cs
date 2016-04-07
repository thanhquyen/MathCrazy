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

    }

    public new void onShow() {
        base.onShow();
        StartCoroutine(countTime());
    }

    IEnumerator countTime() {
        time_count.text = "3";
        yield return new WaitForSeconds(1);
        time_count.text = "2";
        yield return new WaitForSeconds(1);
        time_count.text = "1";
        yield return new WaitForSeconds(1);
        time_count.text = "Ready!";
        yield return new WaitForSeconds(1);
        base.onHide();
        uiController.setUI(UIController.STATE_UI.PLAY);
    }
}
