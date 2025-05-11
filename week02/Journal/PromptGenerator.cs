public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "What was the best part of your day?",
        "What are you grateful for today?",
        "What is something you learned today?",
        "What is a challenge you faced today?",
        "What is something that made you smile today?",
        "What is a goal you want to achieve this week?",
        "Who did you interact with today?",
        "Where did you go today?",
        "What is something you want to remember about today?",
        "Who is someone you admire and why?",
        "What was in the news today?",
        "What is something you wish you could change about today?",
        "What is something you are looking forward to?",
    };

    public string GetRandomPrompt()
    {
        // Generate a random number between 0 and the number of prompts
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        // Return the prompt at that index
        return _prompts[index];               
    }
}