using UnityEngine;
using FMODUnity;
using FMOD.Studio;

public class MusicTrigger : MonoBehaviour
{
    
    public EventInstance eventInstance;
    public EventReference eventReference;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        eventInstance = RuntimeManager.CreateInstance(eventReference);
        eventInstance.start();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    
    private void OnTriggerEnter(Collider other)
    {
        
        RuntimeManager.PlayOneShotAttached(eventReference, gameObject);
        
        eventInstance.getPaused(out bool isPaused);
            
        Debug.Log("Paused is: " + isPaused);
        
        eventInstance.getPlaybackState(out PLAYBACK_STATE state);

        switch (state)
        {
            case PLAYBACK_STATE.PLAYING:
                break;
            case PLAYBACK_STATE.STARTING:
                break;
            case PLAYBACK_STATE.SUSTAINING:
                break;
            case PLAYBACK_STATE.STOPPING:
                break;
            case PLAYBACK_STATE.STOPPED:
                break;
        }
    }
}
