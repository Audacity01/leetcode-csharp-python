class Solution:
    def isValidBST(self, root):
        def check(node, lo=float('-inf'), hi=float('inf')):
            if not node:
                return True
            if node.val <= lo or node.val >= hi:
                return False
            return check(node.left, lo, node.val) and check(node.right, node.val, hi)
        return check(root)
