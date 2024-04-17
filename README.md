# Intuition
The problem requires finding the lexicographically smallest string that starts at a leaf node and ends at the root of a binary tree. To achieve this, we can perform a depth-first search (DFS) traversal of the tree, constructing the string along the way from the leaf to the root.

# Approach
1. Implement a DFS traversal function that takes a node and the current string formed so far.
   
3. At each node, append the character represented by the node's value to the current string.
   
3. If the node is a leaf (i.e., it has no children), return the current string.

4. If the node has both left and right children, recursively call the DFS function for both children, and return the lexicographically smaller string among the results.

5. If the node has only one child (left or right), recursively call the DFS function for that child.

6. Finally, return the lexicographically smallest string obtained from the DFS traversal.

# Complexity
- Time complexity: The DFS traversal visits each node once, resulting in a time complexity of O(n), where n is the number of nodes in the binary tree.

- Space complexity: The space complexity is also O(n) due to the recursive calls on the call stack and the space required to store the current string during traversal.
__________________________________________________________________________________________
# Create a new console project
dotnet new console -n SmallestStringStartingFromLeaf

# Run the project
dotnet run
