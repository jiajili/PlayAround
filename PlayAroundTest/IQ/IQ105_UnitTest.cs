using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using PlayAround.IQ;

namespace PlayAroundTest.IQ
{
    [TestClass]
    public class IQ105_UnitTest
    {
        [TestMethod]
        public void TestCase1()
        {
            int[] preorder = { 10, 8, 6, 9, 22, 11, 33 };
            int[] inorder = { 6, 8, 9, 10, 11, 22, 33 };
            
            IQ_105 test = new IQ_105();
            var treenode = test.BuildTree(preorder, inorder);
            Assert.AreEqual(treenode.val, 10);
            Assert.AreEqual(treenode.left.val, 8);
            Assert.AreEqual(treenode.left.right.val, 9);
            Assert.AreEqual(treenode.right.val, 22);
        }

        [TestMethod]
        public void TestCase2()
        {
            int[] preorder = { 1,2 };
            int[] inorder = { 2,1 };
            IQ_105 test = new IQ_105();
            var treenode = test.BuildTree(preorder, inorder);
            
        }
    }
}
