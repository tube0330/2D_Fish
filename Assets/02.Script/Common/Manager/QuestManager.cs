using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    [System.Serializable]
    public class QuestData
    {
        public string content;     // 퀘스트 내용
        public int targetCnt;    // 목표 수
        public int curCnt;   // 현재 진행도
    }

    [SerializeField]
    private List<QuestData> questList = new List<QuestData>();

    private Dictionary<Player.LEVEL, QuestData> questDict;

    void Awake()
    {
        QuestContents();
        InitializeDictionary();
    }

    void QuestContents()
    {
        questList = new List<QuestData>()
        {
            new QuestData{ content = "물고기 5마리 잡기", targetCnt = 5, curCnt = 0 },
            new QuestData{ content = "물고기 5마리 잡기", targetCnt = 5, curCnt = 0 },
            new QuestData{ content = "물고기 10마리 잡기", targetCnt = 10, curCnt = 0 },
            new QuestData{ content = "물고기 5마리 잡기", targetCnt = 5, curCnt = 0 },
            new QuestData{ content = "물고기 10마리 잡기", targetCnt = 10, curCnt = 0 },
            new QuestData{ content = "물고기 5마리 잡기", targetCnt = 5, curCnt = 0 },
        };
    }

    void InitializeDictionary()
    {
        questDict = new Dictionary<Player.LEVEL, QuestData>();

        // Player.LEVEL enum 값을 순차적으로 할당
        for (int i = 0; i < questList.Count; i++)
        {
            Player.LEVEL level = (Player.LEVEL)i;
            questDict.Add(level, questList[i]);
        }
    }

    public QuestData GetQuestData(int level)
    {
        Player.LEVEL questLevel = (Player.LEVEL)level;
        
        // Dictionary에 해당 레벨이 없으면 Level1의 퀘스트 반환
        if (!questDict.ContainsKey(questLevel))
            return questDict[Player.LEVEL.Level1];
            
        return questDict[questLevel];
    }

    public void QuestProgress(int level, int value)
    {
        if (questDict.ContainsKey((Player.LEVEL)level))
            questDict[(Player.LEVEL)level].curCnt += value;
    }
}