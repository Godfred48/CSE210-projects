using System;

/*
EXCEEDING REQUIREMENTS:

1. Leveling System:
   - Player levels up every 1000 points.
   - Displays level progression message.

2. Achievement System:
   - Unlocks achievements based on score and goal completion.

3. Random Encouragement Messages:
   - Displays motivational messages when recording events.

These features enhance engagement and gamify the Eternal Quest experience.
*/

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}
