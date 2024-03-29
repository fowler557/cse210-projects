public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, List<Word> words)
    {
        _reference = reference;
        _words = words;
    }

    public void DisplayScripture()
    {
        Console.WriteLine(_reference.GetReference());
        foreach (Word word in _words)
        {
            Console.Write(word.GetWord() + " ");
        }
    }

    public bool AllWordsHidden()
{
    foreach (Word word in _words)
    {
        if (!word.GetWord().Contains("_"))
        {
            return false;
        }
    }
    return true;
}

    public void HideRandomWords(int count)
{
    List<Word> visibleWords = new List<Word>();
    foreach (Word word in _words)
    {
        if (!word.GetWord().Contains("_"))
        {
            visibleWords.Add(word);
        }
    }

    Random random = new Random();
    while (count > 0 && visibleWords.Count > 0)
    {
        int randomIndex = random.Next(visibleWords.Count);
        visibleWords[randomIndex].HideWord();
        visibleWords.RemoveAt(randomIndex);
        count--;
    }
}
}