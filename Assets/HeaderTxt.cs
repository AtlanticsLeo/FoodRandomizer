using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeaderTxt : MonoBehaviour
{
    public Text header;
    public Text foodTxt;
    List<String> foodList = new List<String>();
    int foodindex;

    private void Awake()
    {
        Chinese();
    }
    public void Chinese()
    {
        header.text = "Chinese";
        foodList.Clear();
        foodList.Add("Fried Kuey Teow");
        foodList.Add("Pork Mee");
        foodList.Add("Curry Mee");
        foodList.Add("Wanton Mee");
        foodList.Add("Soup Mee");
        foodList.Add("Char Siew Rice");
        foodList.Add("Chicken Rice");
        foodList.Add("Economic Rice");
        foodList.Add("Dumpling Mee");
        foodList.Add("Fried Rice");
    }
    public void FastFood()
    {
        header.text = "FastFood";
        foodList.Clear();
        foodList.Add("Spicy Chicken McDexule");
        foodList.Add("Grilled Chicken Burger");
        foodList.Add("KFC Fried Chicken");
        foodList.Add("Popcorn Chicken");
        foodList.Add("Korean Freid Chicken");
        foodList.Add("Big Mac/Whopper");
        foodList.Add("Filet-O-Fish");
        foodList.Add("Looots of Fries");
        foodList.Add("Pizza");
        foodList.Add("Subway");
    }
    public void Japanese()
    {
        header.text = "Japanese";
        foodList.Clear();
        foodList.Add("Ramen");
        foodList.Add("Soba");
        foodList.Add("Sushi");
        foodList.Add("Donburi");
        foodList.Add("Gyoza");
        foodList.Add("Teppanyaki");
        foodList.Add("Takoyaki");
        foodList.Add("Yakimono");
        foodList.Add("Bento");
        foodList.Add("Udon");
    }
    public void Beverage()
    {
        header.text = "Beverage";
        foodList.Clear();
        foodList.Add("Espresso");
        foodList.Add("Mocha");
        foodList.Add("Latte");
        foodList.Add("Green Tea Latte");
        foodList.Add("Cuppucino");
        foodList.Add("Cham");
        foodList.Add("Teh");
        foodList.Add("Teh O");
        foodList.Add("Chocolate Drink");
        foodList.Add("White Coffee");
    }
    public void Dessert()
    {
        header.text = "Dessert";
        foodList.Clear();
        foodList.Add("Kit-Kat");
        foodList.Add("Oreo");
        foodList.Add("Mint Chocolate");
        foodList.Add("Matcha");
        foodList.Add("Popsicle");
        foodList.Add("Coconut");
        foodList.Add("Ice-cream Sandwich");
        foodList.Add("Sundae");
        foodList.Add("Gelato");
        foodList.Add("Chocolate");
    }
    public void All()
    {
        header.text = "All";
        foodList.Clear();
        foodList.Add("Kit-Kat");
        foodList.Add("Oreo");
        foodList.Add("Mint Chocolate");
        foodList.Add("Matcha");
        foodList.Add("Popsicle");
        foodList.Add("Coconut");
        foodList.Add("Ice-cream Sandwich");
        foodList.Add("Sundae");
        foodList.Add("Gelato");
        foodList.Add("Chocolate");
        foodList.Add("Espresso");
        foodList.Add("Mocha");
        foodList.Add("Latte");
        foodList.Add("Green Tea Latte");
        foodList.Add("Cuppucino");
        foodList.Add("Cham");
        foodList.Add("Teh");
        foodList.Add("Teh O");
        foodList.Add("Chocolate Drink");
        foodList.Add("White Coffee");
        foodList.Add("Espresso");
        foodList.Add("Mocha");
        foodList.Add("Latte");
        foodList.Add("Green Tea Latte");
        foodList.Add("Cuppucino");
        foodList.Add("Cham");
        foodList.Add("Teh");
        foodList.Add("Teh O");
        foodList.Add("Chocolate Drink");
        foodList.Add("White Coffee");
        foodList.Add("Ramen");
        foodList.Add("Soba");
        foodList.Add("Sushi");
        foodList.Add("Donburi");
        foodList.Add("Gyoza");
        foodList.Add("Teppanyaki");
        foodList.Add("Takoyaki");
        foodList.Add("Yakimono");
        foodList.Add("Bento");
        foodList.Add("Udon");
        foodList.Add("Spicy Chicken McDexule");
        foodList.Add("Grilled Chicken Burger");
        foodList.Add("KFC Fried Chicken");
        foodList.Add("Popcorn Chicken");
        foodList.Add("Korean Freid Chicken");
        foodList.Add("Big Mac/Whopper");
        foodList.Add("Filet-O-Fish");
        foodList.Add("Looots of Fries");
        foodList.Add("Pizza");
        foodList.Add("Subway");
        foodList.Add("Fried Kuey Teow");
        foodList.Add("Pork Mee");
        foodList.Add("Curry Mee");
        foodList.Add("Wanton Mee");
        foodList.Add("Soup Mee");
        foodList.Add("Char Siew Rice");
        foodList.Add("Chicken Rice");
        foodList.Add("Economic Rice");
        foodList.Add("Dumpling Mee");
        foodList.Add("Fried Rice");
    }

    public void RandomFood()
    {
        var random = new System.Random();
        foodindex = random.Next(foodList.Count);
        Debug.Log(foodList[foodindex]);
        StartCoroutine(GameManager.Instance.Roll());
        StartCoroutine(Wait());
    }

    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(1);
        foodTxt.text = foodList[foodindex];
    }
}
