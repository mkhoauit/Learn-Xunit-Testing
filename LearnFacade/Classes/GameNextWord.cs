using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnFacade.Classes
{
    public class GameNextWord
    {
        protected Player1 _player1;

        protected Player2 _player2;

        public GameNextWord(Player1 player1, Player2 player2 )
        {
            this._player1 = player1;
            this._player2 = player2;
        }

        // The Facade's methods are convenient shortcuts to the sophisticated
        // functionality of the subsystems. However, clients get only to a
        // fraction of a subsystem's capabilities.
        public string Operation()
        {
            string result = "GameNextWord start: Player1 -> Player 2\n";
            var checkLastChar = " ";
            var checkFirstChar = " ";
            result += $"Player 1: {this._player1.Word1()}";
            checkFirstChar = _player1.Word1().Substring(0,1);
            checkLastChar =  _player1.Word1().Substring(_player1.Word1().Length - 1); 
            
            if (checkFirstChar==" "||checkLastChar==" "||_player1.Word1()=="")
            {
                result += "\n";
                result += "Because wrong input Round 1: Player 1 lose";
            }
            else
            {
                if (_player2.Word1().Substring(0, 1) == " " || _player2.Word1().Substring(_player2.Word1().Length - 1) == " " ||
                    _player2.Word1() == "")
                {
                    result += "\n";
                    result += "Because wrong input Round 1: Player 2 lose";
                }
                else
                {

                    if (_player1.WordN().Substring(0, 1) == " " || _player1.WordN().Substring(_player1.WordN().Length - 1) == " " ||
                        _player1.WordN() == "")
                    {
                        result += "\n";
                        result += "Because wrong input Round 2: Player 1 lose";
                    }
                    else
                    {

                        if (_player2.WordZ().Substring(0, 1) == " " || _player2.WordZ().Substring(_player2.WordZ().Length - 1) == " " ||
                            _player2.WordZ() == "")
                        {
                            result += "\n";
                            result += "Because wrong input Round 2: Player 2 lose";
                        }

                        else
                        {
                            result += "\n";
                            result += $"  Continue with alphabet: {checkLastChar} \n";

                            result += $"Player 2: {this._player2.Word1()}";
                            checkFirstChar = _player2.Word1().Substring(0, 1);

                            if (checkFirstChar != checkLastChar)
                            {
                                result += "\n";
                                result += $"Round 1: Player 2 lose";
                            }
                            else
                            {
                                result += "\n";
                                result +=
                                    $"  Continue with alphabet: {_player2.Word1()[_player2.Word1().Length - 1]} \n";
                                checkLastChar = _player2.Word1().Substring(_player2.Word1().Length - 1);

                                result += $"Player 1: {this._player1.WordN()}";
                                checkFirstChar = _player1.WordN().Substring(0, 1);

                                if (checkLastChar != checkFirstChar)
                                {
                                    result += "\n";
                                    //throw new Exception(message: "Round 2: Player 1 lose");
                                    result += $"Round 2: Player 1 lose";
                                }
                                else
                                {
                                    result += "\n";
                                    result +=
                                        $"  Continue with alphabet: {_player1.WordN()[_player1.WordN().Length - 1]}    \n";
                                    checkLastChar = _player1.WordN().Substring(_player1.WordN().Length - 1);

                                    result += $"Player 2: {this._player2.WordZ()}";
                                    checkFirstChar = _player2.WordZ().Substring(0, 1);

                                    if (checkLastChar != checkFirstChar)
                                    {
                                        result += "\n";
                                        //throw new Exception(message: "Round 2: Player 2 lose");
                                        result += $"Round 2: Player 2 lose";
                                    }

                                    result += "\n";
                                    result += $"The game is ended in a draw";
                                }
                            }
                        }
                    }
                }
            }

            return result;
        }
    }
}
