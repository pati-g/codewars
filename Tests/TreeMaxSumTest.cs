using CodeWars;

namespace CodeWarsTests
{
    public class TreeMaxSumTest
    {
        [Fact]
        public void MaxSumInPerfectTree()
        {
            TreeNode tree = new TreeNode(10);
            tree.left = new TreeNode(2);
            tree.right = new TreeNode(10);
            tree.left.left = new TreeNode(20);
            tree.left.right = new TreeNode(1);
            tree.right.right = new TreeNode(25);
            tree.right.right.left = new TreeNode(3);
            tree.right.right.right = new TreeNode(4);
            Assert.Equal(49, FunWithTrees.MaxSum(tree));
        }
    }
}
