using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SenceLogic : MonoBehaviour {

    public GameObject aircraftCarrierCanvas;
    public GameObject helicopterCanvas;
    public GameObject fighterAircraftCanvas;
    public GameObject tankCanvas;
    public GameObject armouredVehicleCanvas;
    public GameObject wayPoints;

    // Use this for initialization
    void Start () {
	}

    // Update is called once per frame
    void Update () {
	}

    public void ActiveAircraftCarrierCanvas()
    {
        aircraftCarrierCanvas.active = true;
        wayPoints.active = false;
        //SceneManager.LoadScene("MovieScene");
    }

    public void DectiveAircraftCarrierCanvas()
    {
        aircraftCarrierCanvas.active = false;
        wayPoints.active = true;
    }

    public void ActiveHelicopterCanvas()
    {
        helicopterCanvas.active = true;
        wayPoints.active = false;
    }

    public void DeactiveHelicopterCanvas()
    {
        helicopterCanvas.active = false;
        wayPoints.active = true;
    }

    public void ActiveFighterAircraftCanvas()
    {
        fighterAircraftCanvas.active = true;
        wayPoints.active = false;
    }

    public void DeactiveFighterAircraftCanvas()
    {
        fighterAircraftCanvas.active = false;
        wayPoints.active = true;
    }

    public void ActiveTankCanvas()
    {
        tankCanvas.active = true;
        wayPoints.active = false;
    }

    public void DeactiveTankCanvas()
    {
        tankCanvas.active = false;
        wayPoints.active = true;
    }

    public void ActiveArmouredVehicleCanvas()
    {
        armouredVehicleCanvas.active = true;
        wayPoints.active = false;
    }

    public void DeactiveArmouredVehicleCanvas()
    {
        armouredVehicleCanvas.active = false;
        wayPoints.active = true;
    }
}
