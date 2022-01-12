using System;
using System.Collections.Generic;
using LearnFacade.Classes;
using Xunit;
using Shouldly;
using Xunit.Sdk;

namespace LearnFacade.Test
{
    public class GameNextWordTest
    {
        [Fact]
        public void Word1_Word2_Of_Player1_Player2_ShouldNotBe_Null()
        {
            //Arrange
            Player1 player1 = new Player1();
            Player2 player2 = new Player2();
            
            //Action
           
            //Assert
            player1.word1.ShouldNotBeNullOrEmpty("");
            player1.word2.ShouldNotBeNullOrEmpty("");
            player2.word1.ShouldNotBeNullOrEmpty("");
            player2.word2.ShouldNotBeNullOrEmpty("");

        }
        [Fact]
        public void First_Or_Last_Of_Word1_Of_Player1_Equal_to_Space_ShouldContain_Player1_WrongInput()
        {
            //Arrange
            Player1 player1 = new Player1();
            Player2 player2 = new Player2();
            
            //Action
            player1.word1="hello ";
            player2.word1="oil";
            player1.word2 ="lol";
            player2.word2 = "live";
            
            GameNextWord gameNextWord = new GameNextWord(player1, player2);
            var scoreOfTheGame = "Because wrong input Round 1: Player 1 lose";
            
            //Assert
           gameNextWord.Operation().ShouldContain(scoreOfTheGame);

        }
        
        [Fact]
        public void First_Or_Last_Of_Word1_Of_Player2_Equal_to_Space_ShouldContain_Player2_WrongInput()
        {
            //Arrange
            Player1 player1 = new Player1();
            Player2 player2 = new Player2();
            
            //Action
            player1.word1="king";
            player2.word1="goal ";
            player1.word2 ="lol";
            player2.word2 = "live";
            
            GameNextWord gameNextWord = new GameNextWord(player1, player2);
            var scoreOfTheGame = "Because wrong input Round 1: Player 2 lose";
            
            //Assert
            gameNextWord.Operation().ShouldContain(scoreOfTheGame);

        }
        [Fact]
        public void First_Or_Last_Of_Word2_Of_Player1_Equal_to_Space_ShouldContain_Player1_WrongInput()
        {
            //Arrange
            Player1 player1 = new Player1();
            Player2 player2 = new Player2();
            
            //Action
            player1.word1="king";
            player2.word1="oil";
            player1.word2 =" live";
            player2.word2 = "eye";
            
            GameNextWord gameNextWord = new GameNextWord(player1, player2);
            var scoreOfTheGame = "Because wrong input Round 2: Player 1 lose";
            
            //Assert
            gameNextWord.Operation().ShouldContain(scoreOfTheGame);

        }
        [Fact]
        public void First_Or_Last_Of_Word2_Of_Player2_Equal_to_Space_ShouldContain_Player2_WrongInput()
        {
            //Arrange
            Player1 player1 = new Player1();
            Player2 player2 = new Player2();
            
            //Action
            player1.word1="king";
            player2.word1="oil";
            player1.word2 ="live";
            player2.word2 = " eye";
            
            GameNextWord gameNextWord = new GameNextWord(player1, player2);
            var scoreOfTheGame = "Because wrong input Round 2: Player 2 lose";
            
            //Assert
            gameNextWord.Operation().ShouldContain(scoreOfTheGame);

        }
        [Fact]
        public void Player1_Lose_Round2_in_GameNextWord()
        {
            //Arrange
            Player1 player1 = new Player1();
            Player2 player2 = new Player2();

            //Action
            player1.word1 = "king";
            player2.word1="goal";
            player1.word2 ="oliva";
            player2.word2 = "alive";
            GameNextWord gameNextWord = new GameNextWord(player1, player2);
            var scoreOfTheGame = "Round 2: Player 1 lose";


            //Assert
            gameNextWord.Operation().ShouldMatch(scoreOfTheGame);
        }
        [Fact]
        public void Player2_Lose_Round1_in_GameNextWord()
        {
            //Arrange
            Player1 player1 = new Player1();
            Player2 player2 = new Player2();

            //Action
            player1.word1 = "king";
            player2.word1="oil";
            player1.word2 ="lol";
            player2.word2 = "live";
            GameNextWord gameNextWord = new GameNextWord(player1, player2);
            var scoreOfTheGame = "Round 1: Player 2 lose";


            //Assert
            gameNextWord.Operation().ShouldMatch(scoreOfTheGame);
        }
        [Fact]
        public void Player2_Lose_Round2_in_GameNextWord()
        {
            //Arrange
            Player1 player1 = new Player1();
            Player2 player2 = new Player2();

            //Action
            player1.word1 = "king";
            player2.word1="go";
            player1.word2 ="oil";
            player2.word2 = "eat";
            GameNextWord gameNextWord = new GameNextWord(player1, player2);
            var scoreOfTheGame = "Round 2: Player 2 lose";

            //Assert
            gameNextWord.Operation().ShouldMatch(scoreOfTheGame);
        }
        [Fact]
        public void Score_Of_The_Game_Is_Draw_in_GameNextWord()
        {
            //Arrange
            Player1 player1 = new Player1();
            Player2 player2 = new Player2();

            //Action
            player1.word1 = "king";
            player2.word1="goal";
            player1.word2 ="live";
            player2.word2 = "evil";
            GameNextWord gameNextWord = new GameNextWord(player1, player2); 
            var scoreOfTheGame = "The game is ended in a draw";

            //Assert
            gameNextWord.Operation().ShouldMatch(scoreOfTheGame);
        }
    }
}