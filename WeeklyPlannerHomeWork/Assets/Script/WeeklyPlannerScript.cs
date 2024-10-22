using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeeklyPlannerScript : MonoBehaviour
{
        public string WeeklyActivities = "monday";
       
    // Start is called before the first frame update
    void Start() {
        WeeklyElseIf();
        WeeklySwitch();
    }

    void WeeklyElseIf (){
        if (WeeklyActivities == "monday") 
        {
            Debug.Log("MondayMoive");
        }
        else if (WeeklyActivities == "tuesday") 
        {
            Debug.Log("School");
        }
       else if (WeeklyActivities == "wednesday") 
       {
            Debug.Log("Dinner");
        }
        else if (WeeklyActivities == "thursday") 
        {
            Debug.Log("PubCrawl");
        }
        else if (WeeklyActivities == "friday") 
        {
            Debug.Log("Drinking");
        }
        else if (WeeklyActivities == "saturday")
        {
            Debug.Log("Sleeping");
        }
        else if (WeeklyActivities == "sunday") 
        {
            Debug.Log("StudyBible");
        }
        else 
        {
            Debug.Log("Bored");
        }
    }
    void WeeklySwitch()
    {
        //using case/string
      switch(WeeklyActivities)
        {
            case "monday":
                Debug.Log("MondayMovie");
                break;
            case "tuesday":
                Debug.Log("School");
                break;
            case "wednesday":
                Debug.Log("Dinner");
                break;
            case "thursday":
                Debug.Log("PubCrawl");
                break;
            case "friday":
                Debug.Log("Drinking");
                break;
            case "saturday":
                Debug.Log("Sleeping");
                break;
            case "sunday":
                Debug.Log("StudyBible");
                break;
        default:
                Debug.Log("Bored");
                break;

        }


    }

}

