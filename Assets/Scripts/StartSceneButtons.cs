using UnityEngine;
using UnityEngine.UI;

public class StartSceneButtons : MonoBehaviour
{
    public Button LevelOneButton, LevelTwoButton;

    public Animator EnterGameFades;

    public void StartLevelOneGame()
    {
#if !RELEASE
        Debug.Log("[Event] Click Level 1 Button.");
#endif
        EnterGameFades.SetTrigger("EnterGame");
    }

    public void StartTwoOneGame()
    {
#if !RELEASE
        Debug.Log("[Event] Click Level 2 Button.");
#endif
    }
}
