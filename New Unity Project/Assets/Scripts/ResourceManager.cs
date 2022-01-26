using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// Made by Haley Vlahos
public class ResourceManager : MonoBehaviour
{
    // Seeds
    public static int carrotSeeds = 1;
    public static int cornSeeds = 1;
    public static int pumpkinSeeds = 1;
    public static int radishSeeds = 1;
    public static int tomatoSeeds = 1;
    private static List<int> seeds = new List<int>{carrotSeeds, cornSeeds, pumpkinSeeds, radishSeeds, tomatoSeeds };

    // Crops
    public static int carrots = 0;
    public static int corn = 0;
    public static int pumpkins = 0;
    public static int radishs = 0;
    public static int tomatos = 0;
    private static List<int> crops = new List<int> {carrots, corn, pumpkins, radishs, tomatos};

    // Animal Products - bacon, eggs, feathers, milk, wool
    public static int bacon = 0;
    public static int eggs = 0;
    public static int feathers = 0;
    public static int milk = 0;
    public static int wool = 0;
    private static List<int> animalProds = new List<int> {bacon, eggs, feathers, milk, wool};

    [SerializeField] private List<TextMeshProUGUI> counters = new List<TextMeshProUGUI>();
    private static List<int> displayRsrc = new List<int> {carrots, corn, pumpkins, radishs, tomatos, bacon, eggs, feathers, milk, wool};

    // For game startup, sets all resources to 0 unless it is a seed, in which you are given 1
    public static void setupResources()
    {
        foreach(int i in seeds) {
            seeds[i] = 1;
        }

        foreach (int i in crops) {
            crops[i] = 0;
        }

        foreach (int i in animalProds) {
            animalProds[i] = 0;
        }
    }

    // Updates each of the text counters to match the variables, both lists are in alphabetical order
    private void Update()
    {
        foreach(int i in displayRsrc) {
            counters[i].text = displayRsrc[i].ToString();
        }
    }

}