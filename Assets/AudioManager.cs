using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private AudioSource track01, track02;
    //public AudioClip storm;
    //public AudioClip night;

    public AudioClip defaultAmbience;

    //float defaultVolume = 1f;
    //float transitionTime = 0.5f;

    //bool isPlayingTrack01;
    bool isPlayingStorm;

    public static AudioManager instance;

    private void Awake(){
        if (instance == null)
            instance = this;
    }

    private void Start(){
        //isPlayingTrack01 = true;
        isPlayingStorm = false;
        track01 = gameObject.AddComponent<AudioSource>();
        track01.loop = true;
        track02 = gameObject.AddComponent<AudioSource>();
        track02.loop = true;

        PlayStorm();
    }

    public void PlayCalm(AudioClip newClip){
        if (isPlayingStorm){
            StopAllCoroutines();
            StartCoroutine(FadeTrackToCalm(newClip));
            isPlayingStorm = false;
        }
    }

    public void PlayStorm(){
        if(!isPlayingStorm){
            StopAllCoroutines();
            StartCoroutine(FadeTrackToStorm(defaultAmbience));
            isPlayingStorm = true;
        }
    }

    private IEnumerator FadeTrackToCalm(AudioClip newClip){
        float timeToFade = 1f;
        float timeElapsed = 0;

        track02.clip = newClip;
        track02.Play();

        while(timeElapsed < timeToFade){
            track02.volume = Mathf.Lerp(0, 1, timeElapsed / timeToFade);
            track01.volume = Mathf.Lerp(1, 0, timeElapsed / timeToFade);
            timeElapsed += Time.deltaTime;
            yield return null;
        }
        track01.Stop();
    }

    private IEnumerator FadeTrackToStorm(AudioClip newClip){
        float timeToFade = 1f;
        float timeElapsed = 0;

        track01.clip = newClip;
        track01.Play();

        while(timeElapsed < timeToFade){
            track01.volume = Mathf.Lerp(0, 1, timeElapsed / timeToFade);
            track02.volume = Mathf.Lerp(1, 0, timeElapsed / timeToFade);
            timeElapsed += Time.deltaTime;
            yield return null;
        }
        track02.Stop();
    }
/*
    public void SwapTrack(AudioClip newClip){
        if (isPlayingTrack01){
            track02.clip = newClip;
            track02.Play();
            track01.Stop();
        }
        else{
            track01.clip = newClip;
            track01.Play();
            track02.Stop();
        }

        isPlayingTrack01 = !isPlayingTrack01;
    }

    public void ReturnToDefault(){
        SwapTrack(defaultAmbience);
    }
*/

/*
    private void Start(){
        isPlayingStorm = false;
        aS1 = gameObject.AddComponent<AudioSource>();
        aS2 = gameObject.AddComponent<AudioSource>();

        aS1.clip = storm;
        aS2.clip = night;

        PlayStormMusic();
    }

    public void PlayCalmMusic(){
        if(isPlayingStorm){
            Debug.Log("1111play calm");
            MixSources(aS1, aS2);
            isPlayingStorm = false;
        }
    }

    public void PlayStormMusic(){
        if(!isPlayingStorm){
            Debug.Log("2222play storm");
            MixSources(aS2, aS1);
            isPlayingStorm = true;
        }
    }

    IEnumerator MixSources(AudioSource nowPlaying, AudioSource target){
        float percentage = 0;
        if(nowPlaying.isPlaying == true){
            while (nowPlaying.volume > 0){
                nowPlaying.volume = Mathf.Lerp(defaultVolume, 0, percentage);
                percentage += Time.deltaTime / transitionTime;
                yield return null;
            }
            nowPlaying.Pause();
        }
        if (target.isPlaying == false){
            Debug.Log("In MixSource play target");
            target.Play();
        }
        target.UnPause();
        percentage = 0;

        while(target.volume < defaultVolume){
            target.volume = Mathf.Lerp(0, defaultVolume, percentage);
            percentage += Time.deltaTime / transitionTime;
            yield return null;
        }
    }*/
}
