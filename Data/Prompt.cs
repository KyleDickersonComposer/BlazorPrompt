public class Prompt
{
    List<string> genres = new List<string>
{
     "orchestral", "dark sci-fi", "retro sci-fi", "fairy music", "arabesque", "americana", "trash beats","fantasy", "sci-fi", "sports", "popsy", "modern fantasy", "postmodern", "dark fantasy", "adventure", "lament", "comedy", "romance", "crime", "horror", "thriller", "family friendly", "western", "stealth", "mystery"
};
    List<string> prompt = new List<string>
{
     "dance", "scherzo", "battle", "explore", "action", "ambient", "ballad", "chase", "love", "uplifting", "inspirational", "quirky", "underwater", "fire", "space", "rain", "volcano", "death", "fear", "legere", "filigre"
};
    public async Task<string> PromptData()
    {

        var rand = new Random();
        string data = $"Write a short piece with the prompt {prompt[rand.Next(0, prompt.Count)]} in the genre {genres[rand.Next(0, genres.Count)]}.";
        await Task.Delay(250);

        return data;
    }
}






