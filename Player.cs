namespace tictactoe_sharp
{
    public class Player
    {
        //Player private fields.
        private string? _name;
        private char _symbol;
        private int _gamesplayed;
        private int _wins;
        private int _loses;

        //Player Constructor - Will create a new player from scratch.
        public Player()
        {

        }

        //Set Player Symbol
        public void SetSymbol(char psymbol)
        {
            _symbol = psymbol;
        }

        //Increase number of played games and wins and loses, depending on the game outcome.
        public void UpdateRecord(bool wonmatch)
        {

        }

        //Clear player gaming record
        public void ClearRecord()
        {

        }


    }
}