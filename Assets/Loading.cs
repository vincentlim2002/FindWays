using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
    public float Timeleft;
    public bool TimerOn = false;

    // Start is called before the first frame update
    void Start()
    {
        TimerOn = true;
        Timeleft = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if(TimerOn){
            if(Timeleft > 0){
                Timeleft -= Time.deltaTime;
                Debug.Log(Timeleft);
            }else {
                TimerOn = false;
                SceneManager.LoadScene(1);
            }
        }
    }
}
