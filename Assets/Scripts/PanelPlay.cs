using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PanelPlay : PanelBase {
    public Text text_que, text_ans, lb_score;
    public Image timeImg;
    bool flag;

    float time, timeMax = 1f;
    int score = 0;
    // Use this for initialization
    void Start() {
        //reset();
    }

    // Update is called once per frame
    void Update() {
        if (uiController.getState() == UIController.STATE_UI.PLAY) {
            time -= Time.deltaTime;
            setTime(time);
            if (time < 0) {
                uiController.setUI(UIController.STATE_UI.OVER, score);
            }
        }
        if (Input.GetKeyDown(KeyCode.A)) {
            answerTrue();
        }
        if (Input.GetKeyDown(KeyCode.S)) {
            answerFalse();
        }
    }

    void autoQuetion() {
        time = timeMax;
        int num1 = Random.Range(1, 10);
        int num2 = Random.Range(1, 10);
        int da = 0;

        int r = Random.Range(0, 3);
        string phep = "";
        switch (r) {
            case 0://+
                phep = "+";
                da = num1 + num2;
                break;
            case 1://-
                phep = "-";
                da = num1 - num2;
                break;
            case 2://*
                phep = "*";
                da = num1 * num2;
                break;
                //case 3://:
                //    phep = ":";
                //    da = num1/num2;
                //   break;
        }

        text_que.text = num1 + phep + num2;

        if (Random.Range(1, 9) <= 5) {
            flag = true;
        } else {
            int da2 = Random.Range(da - 5, da + 5);
            //Debug.Log(">>>>>>>> " + da2);
            flag = false;
            if (da2 == da) {
                flag = true;
            }
            da = da2;
        }

        text_ans.text = "= " + da;
        //Debug.Log(flag + "   " + num1 + phep + num2 + " ---- " + da);
    }

    public void answerTrue() {
        if (flag == true) {
            autoQuetion();
            score++;
            setScore(score);
        } else {
            uiController.setUI(UIController.STATE_UI.OVER, score);
            //Debug.Log("========== answerTrue");
        }
    }
    public void answerFalse() {
        if (flag == false) {
            autoQuetion();
            score++;
            setScore(score);
        } else {
            uiController.setUI(UIController.STATE_UI.OVER, score);
            //Debug.Log("************ answerTrue");
        }
    }

    void setScore(int s) {
        lb_score.text = "" + s;
    }

    public void reset() {
        time = timeMax;
        score = 0;
        autoQuetion();
        setScore(score);
    }

    void setTime(float time) {
        timeImg.rectTransform.localScale = new Vector3(time / timeMax, 1, 1);
    }
}
