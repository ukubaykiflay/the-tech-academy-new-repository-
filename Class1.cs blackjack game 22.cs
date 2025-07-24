
using system 

namespace Blackjack Game
{
	public TwentyOne card
{

    public string Suit { get; set; }
public string Rank { get; set; }
public int valu { get; set; }
}
public class Deck
{
    private List<Card> cards = new List<Card>();
    private Random random = new Random();
    public Deck()
    {
        string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
        string[] ranks = {"2, "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace"};

                int[] values = {2,3,4,5,6,7,8,9,10,11,};
        for (int i = 0; i < suits.Length; i++)
        {
            for (int j = 0; j < ranks.Length; j++)
            {
                cards.Add(new Card { suits = suits[i], Rnk = ranks[j], value = values[j] });
            }

            public card DrawCard()
    {
        int index = random.Next(cards.Count);
        cards card = cards{ index}
        ;
        cards.RemovedAt(index);
        return card;

        a, the line int playscore is an integer variable named playerScore to store the player's score in the TwentyOne game.
            this line ensures that the player's Score is calculateed as the highest valide score( less than 22)
            example:
        if the playerResults is [18, 20, 25, 22]:
            where(x => x > 22) filters the list to[18, 20].
            Max() selects the highest value, which is 20.
            playerScore will be 20.
   b, while (player.isActivelyplaying && player.Blance > 0)
        {
            // Calculate the player's score
            int playerScore = playerResults.Where(x => x <= 21).DefaultsIfEmpty(0).Max();
            // check if the player has busted 
            if (playerResults.Any(x => x > 21))
            {
                Console.WriteLine("You busted! Better luck next time.");
                playerScore.balance -= betAmout;//Deduct the amount break;
            }
            // Game logic for player's turn
            Console.WriteLine($" your current score is : {playerScore}");
            consoleWriteLine("do you want to hit or stand?(h/s");
            string choice = Console.ReadLine();
            if (choice.ToLower() == "h")
            {
                // Add a new card to the playre's hand 
                playerResults.Add(Deck.DrawCard());
            }
            else if (choice.ToLower() == "s")
                break;
        }
   else
        {
            console.WriteLine("Invalid choice.please enter 'h' or 's'.");
        }
    }
}

            
            




        
        )
   
  
  
    }

}
}

}
