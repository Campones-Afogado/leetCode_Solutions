# Add Two Numbers

A clean C# implementation for LeetCode Problem 2: Add Two Numbers.
This solution adds two numbers represented by linked lists and returns the result as a new linked list.

## What this project does

- Reads two non-empty linked lists where each node stores a single digit.
- Adds the two numbers digit by digit from least significant to most significant.
- Handles carry values correctly across all nodes.
- Returns the sum as a newly built linked list.

## Key ideas

- Traverse both linked lists in parallel.
- Add corresponding digits plus any carry from the previous step.
- Use a dummy head node to simplify list construction.
- Append the final carry as a new node if needed.

## Concepts practiced

- Linked list traversal
- Dummy node technique
- Carry propagation
- Iterative pointer manipulation

## Complexity

- Time complexity: `O(max(m, n))`
- Space complexity: `O(max(m, n))`

## Why this is useful

This project is a good exercise for practicing linked list algorithms, handling edge cases, and understanding how to implement elementary arithmetic with data structures.

## Example

Input:
- `l1 = [2,4,3]`
- `l2 = [5,6,4]`

Output:
- `[7,0,8]`  (because 342 + 465 = 807)
