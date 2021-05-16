using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameModManager : MonoBehaviour
{
    public static GameModManager gmm;
    [SerializeField]private GameMod gameMod;
    public GameMod GameMod
    {
        get
        {
            return gameMod;
        }
        set
        {
            if(value != gameMod)
            {
                gameMod = value;
                GameModEvent();
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        gmm = this;
        GameModEvent();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public List<GameModEvent> gameModEvents = new List<GameModEvent>();
    public void GameModEvent()
    {
        foreach (GameModEvent gameModEvent in gameModEvents)
        {
            if (gameModEvent.gameMod == gameMod)
                gameModEvent.tumbler.Flag = true;
            else
                gameModEvent.tumbler.Flag = false;
        }
    }
}
[System.Serializable]public class GameModEvent
{
    public Tumbler tumbler;
    public GameMod gameMod;
}

public enum GameMod
{
    Free,
    Info,
    Camera
}
