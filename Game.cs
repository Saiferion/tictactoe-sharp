namespace tictactoe_sharp
{ 

    public class Game
    {

        //Players
        private Player _p1;
        private Player _p2;
        private Player _currentPlayer;

        //Playing Grid
        private Grid _grid;

        //Game assets
        private int _turn;

        //randomize who gets first turn
        private Random _rnd = new Random(); 

        //Determine who gets the first turn
        public void FirstTurn()
        {
            int turn;

            turn = _rnd.Next(1,2);

            if (turn == 1)
                _currentPlayer = _p1;
            else
                _currentPlayer = _p2;
        }

        //Once current player's turn is over, pass turn to the other player
        public void NextTurn()
        {

        }

        public void 

        //



    }



}