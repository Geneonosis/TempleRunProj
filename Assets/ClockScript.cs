using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ClockScript : MonoBehaviour
{
    private TextMeshProUGUI _clockTMProComponent;
    private int _minutes;
    private float _seconds;
    private float _tenthASecond;
    [SerializeField] private float _timeLimit = 30;
    // Start is called before the first frame update

    void Start()
    {
        _clockTMProComponent = gameObject.GetComponent<TextMeshProUGUI>();
        _minutes = 0;
        _seconds = 0;
        _tenthASecond = 0;
    }

    // Update is called once per frame
    void Update()
    {

        _seconds = _timeLimit - (Time.time % _timeLimit);

        _clockTMProComponent.SetText(_seconds.ToString("0:00.<size=45>00</size>"));
        //_clockTMProComponent.SetSecondClockText(Time.time);
        
    }
}
