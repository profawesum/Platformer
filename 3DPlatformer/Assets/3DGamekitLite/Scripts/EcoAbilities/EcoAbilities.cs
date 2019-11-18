using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gamekit3D {

    [SerializeField]
    enum ecoType
    {
        speed,
        fireBall,
        health,
        poweredUp,
        none,
    }

    public class EcoAbilities : MonoBehaviour
    {
         //reference to the player controller script
        [SerializeField] PlayerController playerControl;
        //reference to the player health script
        [SerializeField] Damageable playerDamage;

        public float ecoSpeedBoostSpeed = 14;
        public float ecoSpeedTime = 10;
        public float defaultSpeed = 8;

        public float timer;

        ecoType currentEcoType = ecoType.none;

        private void Update()
        {

            timer -= Time.deltaTime;

            if (timer <= 0) {
                playerControl.maxForwardSpeed = defaultSpeed;
                timer = 0;
            }
            //switch case to see what eco type is being used if any
             switch(currentEcoType)
            {
                case ecoType.speed: {
                        //makes it so the player moves faster for a time
                        playerControl.maxForwardSpeed = ecoSpeedBoostSpeed;
                        timer = ecoSpeedTime;
                        currentEcoType = ecoType.none;
                    }
                    break;
                case ecoType.fireBall:
                    {

                        currentEcoType = ecoType.none;
                    }
                    break;
                case ecoType.health:
                    {
                        if (playerDamage.currentHitPoints < playerDamage.maxHitPoints)
                        {
                            playerDamage.currentHitPoints += 1;
                        }
                        currentEcoType = ecoType.none;
                    }
                    break;
                case ecoType.poweredUp:
                    {

                        currentEcoType = ecoType.none;
                    }
                    break;
                case ecoType.none:
                    {

                    }
                    break;
                default:
                    break;
            }


        }

        //when the player collides with an object that has a trigger collider
        private void OnTriggerEnter(Collider other)
        {
            //sets the value of the enum ecoType based on what the player has collided with
            if (other.tag == "SpeedBoostEco") {
                Debug.Log("SpeedBoost");
                currentEcoType = ecoType.speed;
            }
            if (other.tag == "FireBallEco") {
                currentEcoType = ecoType.fireBall;
            }
            if (other.tag == "HealthEco") {
                currentEcoType = ecoType.health;
            }
            if (other.tag == "PoweredUpEco") {
                currentEcoType = ecoType.poweredUp;
            }
        }








    }
}
