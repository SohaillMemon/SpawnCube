using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseAndResume : MonoBehaviour
{
    bool IsPause = false;

    public void Pause()
    {
        if (IsPause)
        {
            Time.timeScale = 1;
            IsPause = false;
        }
        else
        {
            Time.timeScale = 0;
            IsPause = true;
        }
    }

}
