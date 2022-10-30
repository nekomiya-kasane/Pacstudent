using UnityEngine;

public class Tween : MonoBehaviour
{
    public Transform TweenTarget;
    public Vector3 StartPosition;
    public Vector3 EndPosition;
    public float StartTime = 0f;
    public float EndTime = 0f;
    public float Duration = 1f;

    public bool Enabled = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!Enabled)
        {
            return;
        }

        if (Vector3.Distance(TweenTarget.position, EndPosition) > 0.1f)
        {
            float alpha = (Time.time - StartTime) / Duration;
            TweenTarget.position = Vector3.Lerp(StartPosition, EndPosition, alpha);
        }
        else // close after ended.
        {
            TweenTarget.position = EndPosition;
            Enabled = false;
        }
    }

    public void SetTween(Transform iTweenTarget, Vector3 iStartPosition, Vector3 iEndPosition, float iDuration)
    {
        TweenTarget = iTweenTarget;
        StartPosition = iStartPosition;
        EndPosition = iEndPosition;
        Duration = iDuration;
        StartTime = Time.time;

        Enabled = true;
    }
}
