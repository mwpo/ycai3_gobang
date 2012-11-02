using Microsoft.VisualStudio.TestTools.UnitTesting;
using GoBangGame;

namespace TestGobang
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class GoBangTest
    {
        [TestMethod]
        public void TestEmptyBoard()
        {
            var board = new GoBangBoard(8, 8);
            
            for(int i=0; i<8; ++i)
                for(int j=0; j<8; ++j)
                {
                    Assert.IsTrue(board[i, j] == GoBangBoard.GridStatus.Empty);
                }
        }
    }

    
}
