﻿internal class Program  {
   private static void Main(string[] args){
        //[0,1,2,3,4,3,4]
        TreeNode root = new TreeNode(0);
        root.left = new TreeNode(1);
        root.right = new TreeNode(2);
        root.left.left = new TreeNode(3);
        root.left.right = new TreeNode(4);
        root.right.left = new TreeNode(3);
        root.right.right = new TreeNode(4);
        Solution sol = new Solution();
        System.Console.WriteLine(sol.SmallestFromLeaf(root));
    }
}