# Matrix---Diagonal-Traverse

https://leetcode.com/problems/diagonal-traverse/discuss/203060/Java-Solution-with-Clear-Explanation

 //Idea is the following
        //notice all values in the same diagonal share the same sum value of x index + y index
        //direction of going up right or going down left depends whether the index sum is even or odd
        //for each even or odd diagonal, there are three cases:
        // 1. there is room to go that direction 
        // 2. there is no row space to go further but there is col space 
        // 3. there is no col space to go further but there is row space
