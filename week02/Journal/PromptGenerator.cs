using System;

public class PromptGenerator
{
    public List<string> _prompt = new List<string>();

    // adding prompt to the list
    public PromptGenerator() //method adding prompt to the _prompt list
    {
        _prompt.Add("What was the best part of your day?");
        _prompt.Add("What challenge did you face today and how did you deal with it?");
        _prompt.Add("What is something new you learned or realized today?");
        _prompt.Add("How did you show kindness to someone today?");
        _prompt.Add("What are you grateful for today?");
        _prompt.Add("Describe a moment that made you smile today.");
        _prompt.Add("If you could relive one moment from today, what would it be and why?");
    }

    public string GetRandomPrompt()//randomly generating prompte to user
    {
        Random randomPrompt = new Random();
        int indexrandPrompt = randomPrompt.Next(_prompt.Count); //used _prompt.Count so it could i dentify number of i tems in the list and index them
        return _prompt[indexrandPrompt];// this returns a prompt based on a random index generated
    }

}