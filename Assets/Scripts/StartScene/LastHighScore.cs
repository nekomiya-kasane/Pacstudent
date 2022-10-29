using TMPro;
using UnityEngine;

public class LastHighScore : MonoBehaviour
{
    // Start is called before the first frame update

    public TextMeshProUGUI highestScore, lastTime;
    void Start()
    {
        var last_time = PlayerPrefs.GetString("LastTime");
        last_time = last_time == "" ? "00:00:00" : last_time;
        var last_score = PlayerPrefs.GetInt("LastScore");
#if !RELEASE
        Debug.Log("Last Highest Score: " + last_score);
        Debug.Log("Last Time: " + last_time);
#endif
        highestScore.text = last_score.ToString();
        lastTime.text = last_time;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
