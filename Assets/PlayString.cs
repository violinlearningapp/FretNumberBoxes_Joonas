using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayString : MonoBehaviour
{

    public MIDIPlayer Midi = new MIDIPlayer();
    private Color[] _stringColors = { Color.blue, Color.red, Color.green, Color.yellow };

    private MeshRenderer[] _renderers = new MeshRenderer[4];

    private GameObject gText;
    private GameObject dText;
    private GameObject aText;
    private GameObject eText;

    // Use this for initialization   
    void Start()
    {
        // Color the boxes
        GameObject[] strings =
        {
            GameObject.Find("GString"), GameObject.Find("DString"),
            GameObject.Find("AString"), GameObject.Find("EString")
        };
        // Find renderers
        for (int i = 0; i < strings.Length; i++)
        {
            _renderers[i] = strings[i].GetComponent<MeshRenderer>();
        }

        for (int i = 0; i < _renderers.Length; i++)
        {
            _renderers[i].material.color = _stringColors[i];
        }

        gText = GameObject.Find("GText");
        dText = GameObject.Find("DText");
        aText = GameObject.Find("AText");
        eText = GameObject.Find("EText");
        

        /*
         * private readonly string[] _violinFirstPosNotes =
        {
        "G4", "G#4", "A4", "A#4", "B4", "C5", "C#5",    // Each string without the last note that is the same as
        "D5", "D#5", "E5", "F5", "F#5", "G5", "G#5",    // The starting note on the next string
        "A5", "A#5", "B5", "C6", "C#6", "D6", "D#6",
        "E6", "F6", "F#6", "G6", "G#6", "A6", "A#6", "B7"
        };*/
        

    }

    // Update is called once per frame
    void Update()
    {
        int noteNum = Midi.Nuottinumero;

        if (noteNum % 55 < 7)
        {
            gText.GetComponent<TextMesh>().text = ((noteNum % 55) % 7).ToString();
            Debug.Log("Notenum: " + noteNum + " Notenum%: " + noteNum % 55 + " Note%%: " + (noteNum % 55) % 7);
        }
        if (noteNum % 55 > 7 && noteNum % 55 < 14)
        {
            dText.GetComponent<TextMesh>().text = ((noteNum % 55) % 7).ToString();
            Debug.Log("Notenum: " + noteNum + " Notenum%: " + noteNum % 55 + " Note%%: " + (noteNum % 55) % 7);
        }
        if (noteNum % 55 > 14 && noteNum % 55 < 21)
        {
            aText.GetComponent<TextMesh>().text = ((noteNum % 55) % 7).ToString();
            Debug.Log("Notenum: " + noteNum + " Notenum%: " + noteNum % 55 + " Note%%: " + (noteNum % 55) % 7);
        }
        if (noteNum % 55 > 21 && noteNum % 55 < 27)
        {
            eText.GetComponent<TextMesh>().text = ((noteNum % 55) % 7).ToString();
            Debug.Log("Notenum: " + noteNum + " Notenum%: " + noteNum % 55 + " Note%%: " + (noteNum % 55) % 7);
        }
        if (noteNum % 55 > 27)
        {
            eText.GetComponent<TextMesh>().text = "7";
            Debug.Log("Notenum: " + noteNum + " Notenum%: " + noteNum % 55 + " Note%%: " + (noteNum % 55) % 8);
        }
        //else
        //{
        //    gText.GetComponent<TextMesh>().text = "";
        //    dText.GetComponent<TextMesh>().text = "";
        //    aText.GetComponent<TextMesh>().text = "";
        //    eText.GetComponent<TextMesh>().text = "";
        //}
    }
}
