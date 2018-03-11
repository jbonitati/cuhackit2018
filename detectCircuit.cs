using UnityEngine;
using Vuforia;
using System;
using System.Collections;

//CircuitElements are stored in an array where adjacent elements are connected
// Elements are only added or removed from this array when a collision is entered or exited

//If the first and last elements in this array are identical, then the circuit is closed

namespace CircuitDetective{

    public static class CircuitArray {  
        ArrayList circuitElements; //a circular array of the elements in the circuit

        void Start(){
            circuitElements = new ArrayList();
        }
        
        public void addElements(GameObject obj1, GameObject obj2){
            //These two elements are touching now,
            // so add them to the array next to each other
        
        }
        
        public void removeElements(GameObject obj1, GameObject obj2){
            //These two elements are no longer touching, 
            // so make sure they are not next to each other in the array
        }
         
        //checks whether there is a closed circuit or not and maybe does something
        public static void detectCircuit(){
           
            //check if first and last elements are identical
            if(elementList[0] == elementList[elementList.count]){
                //We have a circuit!
                print("There is a closed circuit!");
            }else{
                //There is no closed circuit :(
            }
        }

    }

    public class CircuitElement : MonoBehaviour{
       
        void OnTriggerEnter(Collider other)
        {
            CircuitArray.addElements(this, other.GameObject);
            //check for a closed circuitz
            CircuitArray.detectCircuit();
        }

        void OnTriggerExit(Collider other) {
            CircuitArray.addElements(this, other.GameObject);
            //check for a closed circuit        
            CircuitArray.detectCircuit();
        }

    }

}
