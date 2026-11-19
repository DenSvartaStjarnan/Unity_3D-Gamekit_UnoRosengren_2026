using System;
using FMODUnity;
using FMOD.Studio;
using UnityEngine;

public class WS2 : MonoBehaviour
{
    public enum ElementalPower
    {
        None,
        Fire,
        Ice,
        Lightning,
        Earth
    }
    
    [System.Serializable]
    public struct CharacterInformation
    {
        public string name;
        public ElementalPower elementalPower;
        public float speed;
        public int health;
        public bool canFly;
        public int damagePower;
    }

    public ElementalPower naturKraft;
    public CharacterInformation[] characterInformation;

    public int[] highScores;
    
    public EventInstance eventInstance;
    public EventReference eventRef;
    
    private void Start()
    {
        eventInstance = RuntimeManager.CreateInstance(eventRef);
        
        eventInstance.start();

        eventInstance.getPlaybackState(out PLAYBACK_STATE state);
        Debug.Log(state);
        
        //PLAYBACK_STATE.STOPPED

        foreach (CharacterInformation score in characterInformation)
        {
            Debug.Log(score.name);
        }

        foreach (CharacterInformation score in characterInformation)
        {
            switch (score.name)
            {
                case "Link":
                    Debug.Log("Hiyaa");
                    break;
                case "Samus":
                    Debug.Log("...");
                    break;
                case "Mario":
                    Debug.Log("Wahoo");
                    break;
                default:
                    Debug.Log("Nåt är fel...");
                    break;
            }
        }

        switch (naturKraft)
        {
            case ElementalPower.Fire:
                // Run this code
                Debug.Log("Fire");
                if (true == false)
                {
                    Debug.Log("IMPOSSIBLE");
                }
                break; 
            case ElementalPower.Ice:
                Debug.Log("Ice");
                break;
            case ElementalPower.Lightning:
                Debug.Log("Lightning");
                break;
            case ElementalPower.Earth:
                Debug.Log("Earth");
                break;
            case ElementalPower.None:
                Debug.Log("None");
                break;
        }
        
        Debug.Log(naturKraft);
        
        Debug.Log(characterInformation[0].name);
        
        Debug.Log(highScores[2]);
    }
    
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("I'm" + other.name + "and I entered" + other.name);
        }
        
    }
}
