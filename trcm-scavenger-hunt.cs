string[] question = { "What is the example used for \"I\"?", "What does \"Ani-niigaan Inaaging\" mean in English?", "First line in the play", "Where was Treaty No. 3 made?", "What language is \"Ina Maka\" in?", "How many hidden words exist?" };
string[] hint = {
    "Vocabulary", "Treaty ABC's", "The anwser is one word", "The anwser is: Identity",
    "Timeline", "An Explorer’s Guide to Treaties in Manitoba", "Look at the top of the page", "The anwser is: To look to the future",
    "KiniKiniK", "A piece of theatre", "The first line is spoken by Turtle", "The anwser is: We're here to share with you today;",
    "Colouring Book", "Find number 3", "Treaty No. 3 was made at ________ _____", "The anwser is: Harrison Creek",
    "Learning Activities", "Find First Nations' Geographical Terms", "Ina Maka means Mother Earth", "The anwser is: Dakota",
    "Word Search", "Count the number of words", "Enter your anwser with numbers, example: 6", "The anwser is: 12"
};
string[] answer = { "identity", "to look to the future", "we're here to share with you today;", "harrison creek", "dakota", "12" };
string response;

Console.WriteLine("All answers can be found in trcm.ca/for-learners/");
Console.WriteLine("Press ENTER to start.");
Console.ReadLine();

for (int i = 0; i <= 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Clear();
        Console.WriteLine(question[i]);
        if (j > 0)
        {
            Console.WriteLine("Hint: " + hint[i * 4 + j - 1]);
        }
        response = Console.ReadLine();
        response = response.ToLower();
        if (response == answer[i])
        {
            Console.WriteLine("Correct!");
            System.Threading.Thread.Sleep(1500);
            break;
        }
        else
        {
            Console.WriteLine("That is incorrect.");
            System.Threading.Thread.Sleep(1500);
        }
    }
}