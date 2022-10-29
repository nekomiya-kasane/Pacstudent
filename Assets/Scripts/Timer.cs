using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    private int hour;
    private int minute;
    private int second;
    private int millisecond;
    private bool started = false;

    private float totalTime = 0;

    public TextMeshProUGUI TimeText;

    public void SetStarted(bool iStart)
    {
        started = iStart;
    }

    // Update is called once per frame
    void Update()
    {
        if (!started)
        {
            return;
        }

        totalTime += Time.deltaTime;
        int intTime = (int)totalTime;
        hour = intTime / 3600;
        minute = intTime % 3600 / 60;
        second = intTime % 3600 % 60;
        TimeText.text = string.Format("{0:D2}:{1:D2}:{2:D2}", hour, minute, second, millisecond);
    }
}
