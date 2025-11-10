using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControlScript : MonoBehaviour
{
    private float ElapsedTime = 0f;
    public GoalScript red;
    public GoalScript blue;
    public GoalScript green;
    public GoalScript orange;
    public GoalScript Chaos;

    private bool GameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameOver) { ElapsedTime += Time.deltaTime; }
        if (red.IsSolved() && blue.IsSolved() && orange.IsSolved() && green.IsSolved() && Chaos.IsSolved())
        {
            GameOver = true;
        }
    }

    void OnGUI()
    {
        if (GameOver)
        {
            GUI.Box(new Rect(Screen.width / 2 - 100,
            Screen.height / 2 - 50, 200, 75), "Game Over");

            var minutes = Mathf.FloorToInt(ElapsedTime / 60);
            var seconds = Mathf.FloorToInt(ElapsedTime % 60);

            GUI.Label(new Rect(Screen.width / 2 - 30,
            Screen.height / 2 - 30, 120, 50), "Time: " + minutes + ":" + seconds);

            if (GUI.Button(new Rect(Screen.width / 2 - 30,
            Screen.height / 2 - 0, 60, 15), "Restart?"))
            {
                Restart();
            }
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
