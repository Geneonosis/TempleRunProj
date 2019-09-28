using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ClockScript : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _clockTMProSeconds;
    [SerializeField] private TextMeshProUGUI _clockTMProMilliSeconds;
    [SerializeField] private GameObject _messagePanel;
    [SerializeField] private GameObject _messagePanelText;
    private int _minutes;
    private int _seconds;
    private float _tenthASecond;
    [SerializeField] private float _timeLimit = 30;
    // Start is called before the first frame update

    [SerializeField] private TextMeshProUGUI levelText;
    public int levelNumber = 1;
    private bool key = false;
    void Start()
    {
        //_clockTMProSeconds = gameObject.GetComponent<TextMeshProUGUI>();
        _minutes = 0;
        _seconds = 0;
        _tenthASecond = 0;
        levelText.SetText(levelNumber.ToString("Level: 00"));
    }

    // Update is called once per frame
    void Update()
    {

        _seconds = (int)(_timeLimit - (Time.timeSinceLevelLoad % _timeLimit));
        _tenthASecond = ((_timeLimit - (Time.timeSinceLevelLoad % _timeLimit)) * 100) % 99;
        _clockTMProSeconds.SetText(_seconds.ToString("00"));
        _clockTMProMilliSeconds.SetText(_tenthASecond.ToString("00"));

        if ((int)_seconds == 0 && key == false)
        {
            key = true;
            levelNumber++;
            levelText.SetText(levelNumber.ToString("Level: 00"));
            //TODO: show some sort of invasive indication
            StartCoroutine(messageForUser());

        }

        if ((int)_seconds == 1)
        {
            key = false;
        }

        //_clockTMProComponent.SetSecondClockText(Time.time);
    }


    public IEnumerator messageForUser()
    {
        _messagePanelText.GetComponent<TextMeshProUGUI>().SetText(levelNumber.ToString("Level: 00"));
        _messagePanel.SetActive(true);
        yield return new WaitForSeconds(3);
        _messagePanel.SetActive(false);
        //_messagePanel.GetComponent<Animation>().Play();
    }
}
