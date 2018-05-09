using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class TimelineController : MonoBehaviour {

	public List<PlayableDirector> Directors;
	public List<TimelineAsset> Timelines;

	public void Play()
	{
		foreach (PlayableDirector pd in Directors) {
			pd.Play ();
		}
	}

	public void PlayFromTimelines(int index)
	{
		TimelineAsset selectedTimeline;
		if (Timelines.Count != index) {
			selectedTimeline = Timelines [Timelines.Count - 1];
		} else {
			selectedTimeline = Timelines [index];
		}

		Directors [0].Play (selectedTimeline);			
	}
}
