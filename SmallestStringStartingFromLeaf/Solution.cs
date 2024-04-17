public class Solution {

    public string SmallestFromLeaf(TreeNode? root) {
        if (root == null) return "";

        if(root.left == null && root.right == null) return root.val.ToString();
        return FindPath(root);
    }

    public string FindPath(TreeNode? root, string currentPath=""){

        if(root == null) return currentPath;

        currentPath= (char)(root.val + 'a') + currentPath;
        if(root.left==null && root.right==null){
           return currentPath;
        }

        if(root.right == null){
            return FindPath(root.left,currentPath);
        }
        if(root.left == null){
            return FindPath(root.right,currentPath);
        }

        string leftPath= FindPath(root.left,currentPath);
        string rightPath= FindPath(root.right,currentPath);

        return leftPath.CompareTo(rightPath) < 0 ? leftPath : rightPath;
    }
}