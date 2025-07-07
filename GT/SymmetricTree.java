class Node {
    int data;
    Node left;
    Node right;

    Node(int value) {
        this.data = value;
        this.left = null;
        this.right = null;
    }
}

public class SymmetricTree {
    public static boolean isSymmetric(Node left, Node right) {
        if(left == null && right == null) return true;

        if(left == null) return false;
        if(right == null) return false;

        if(left.data == right.data) {
            boolean first = isSymmetric(left.left, right.right);
            boolean second = isSymmetric(left.right, right.left);

            return (first && second);
        }
        return false;
    }



    public static void main(String[] args) {
        Node root = new Node(1);
        Node secondNode = new Node(2);
        Node thirdNode = new Node(2);
        Node fourthNode = new Node(3);
        Node fifthNode = new Node(4);
        Node sixthNode = new Node(4);
        Node seventhNode = new Node(3);

        root.left = secondNode;
        root.right = thirdNode;
        secondNode.left = fourthNode;
        secondNode.right = fifthNode;
        thirdNode.left = sixthNode;
        thirdNode.right = seventhNode;

        if(root == null) {
            System.out.println("Tree is null");   
        }
        else {
            boolean ans = isSymmetric(root.left, root.right);
            System.out.println(ans ? "Tree is Symmetric" : "Tree is not Symmetric");
        }

    }
}
