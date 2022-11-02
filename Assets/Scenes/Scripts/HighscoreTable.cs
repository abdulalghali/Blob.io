using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighscoreTable : MonoBehaviour
{
//    private Transform entryContainer;
//    private Transform entryTemplate;
//    private List<HighscoreEntry> highscoreEntryList;
//    private List<Transform> highscoreEntryTransformList;

//    private void Awake()
//    {
//        entryContainer = transform.Find("highscoreEntryContainer");
//        entryTemplate = entryContainer.Find("highscoreEntryTemplate");

//        //this hides the default template
//        entryTemplate.gameObject.SetActive(false);

//        /*highscoreEntryList = new List<HighscoreEntry>()
//        {
//            new HighscoreEntry{ score = 3734, name = "Jimmy" },
//            new HighscoreEntry{ score = 554, name = "kate" },
//            new HighscoreEntry{ score = 5211, name = "Tim" },
//            new HighscoreEntry{ score = 8219, name = "Joe" },
//            new HighscoreEntry{ score = 54, name = "Matt" },
//            new HighscoreEntry{ score = 98633, name = "Leo" },
//            new HighscoreEntry{ score = 54432, name = "Memo" },
//            new HighscoreEntry{ score = 66854, name = "Jack" },
//            new HighscoreEntry{ score = 963154, name = "Mark" },
//        };*/
        
//        string jsonString = PlayerPrefs.GetString("highscoreTable");
//        Highscores highscores = JsonUtility.FromJson<Highscores>(jsonString);
        
//        //This will sort the Masses of the cells in decreasing order
//        for (int i = 0; i < highscoreEntryList.Count; i++)
//        {
//            for (int j = i + 1; j < highscoreEntryList.Count; j++)
//            {
//                if ( highscoreEntryList[j].score > highscoreEntryList[i].score)
//                {
//                    HighscoreEntry temporary = highscoreEntryList[i];
//                    highscoreEntryList[i] = highscoreEntryList[j];
//                    highscoreEntryList[j] = temporary;
//                }
//            }
//        }
        
//        highscoreEntryTransformList = new List<Transform>();
//        foreach (HighscoreEntry highscoreEntry in highscores.highscoreEntryList)
//        {
//            CreateHighscoreEntryTransform(highscoreEntry, entryContainer, highscoreEntryTransformList);
//        }

//    /*    Highscores highscores = new Highscores { highscoreEntryList = highscoreEntryList};
//        string json = JsonUtility.ToJson(highscores);
//        PlayerPrefs.SetString("highscoreTable", json);
//        PlayerPrefs.Save();
//        Debug.Log(PlayerPrefs.GetString("highscoreTable"));
//    */
//    }
//    private void CreateHighscoreEntryTransform(HighscoreEntry highscoreEntry, Transform container, List<Transform> transformList)
//    {
//        float templateHeight = 20f;
//        Transform entryTransform = Instantiate(entryTemplate, container);
//        RectTransform entryRectTransform = entryTransform.GetComponent<RectTransform>();
//        entryRectTransform.anchoredPosition = new Vector2(0, -templateHeight * transformList.Count);
//        entryTransform.gameObject.SetActive(true);

//        int rank = transformList.Count + 1; //because the leaderboard position should start from 1 and not 0
//        string rankString;
//        switch (rank)
//        {
//            default:
//                rankString = rank + "TH"; break; // any number below position 3 will be followed by "TH"
//            case 1: rankString = "1ST"; break;
//            case 2: rankString = "2ND"; break;
//            case 3: rankString = "3RD"; break;
//        }
//        entryTransform.Find("posText").GetComponent<Text>().text = rankString;

//        int score = highscoreEntry.score;
//        entryTransform.Find("scoreText").GetComponent<Text>().text = score.ToString();

//        string name = highscoreEntry.name;
//        entryTransform.Find("nameText").GetComponent<Text>().text = name;

//        transformList.Add(entryTransform);
//    }

//    private class Highscores
//    {
//        public List<HighscoreEntry> highscoreEntryList;
//    }
//    // this will represent a single high score entry
//    [System.Serializable]
//    private class HighscoreEntry
//    {
//        public int score;
//        public string name;
//    }
}
