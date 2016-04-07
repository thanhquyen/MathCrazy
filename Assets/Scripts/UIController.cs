using UnityEngine;
using System.Collections;

public class UIController : MonoBehaviour {
    public enum STATE_UI {
        HOME = 0,
        READY = 1,
        PLAY = 2,
        OVER = 3
    };
    STATE_UI _state;
    public PanelHome panelHome;
    public PanelReady panelReady;
    public PanelPlay panelPlay;
    public PanelOver panelOver;
    // Use this for initialization
    void Start() {
        home();
    }

    // Update is called once per frame
    void Update() {

    }

    public void setUI(STATE_UI state) {
        _state = state;
        switch (state) {
            case STATE_UI.HOME:
                home();
                break;
            case STATE_UI.READY:
                ready();
                break;
            case STATE_UI.PLAY:
                play();
                break;
            case STATE_UI.OVER:
                over(0);
                break;
        }
    }

    public void setUI(STATE_UI state, int score) {
        _state = state;
        switch (state) {
            case STATE_UI.HOME:
                home();
                break;
            case STATE_UI.READY:
                ready();
                break;
            case STATE_UI.PLAY:
                play();
                break;
            case STATE_UI.OVER:
                over(score);
                break;
        }
    }

    public STATE_UI getState() {
        return _state;
    }

    void disAll() {
        panelHome.onHide();
        panelReady.onHide();
        panelPlay.onHide();
        panelOver.onHide();
    }

    void home() {
        disAll();
        panelHome.onShow();
    }
    void ready() {
        disAll();
        panelReady.onShow();
    }
    void play() {
        disAll();
        panelPlay.onShow();
        panelPlay.reset();
    }
    void over(int score) {
        disAll();
        panelOver.onShow(score);
    }
}
