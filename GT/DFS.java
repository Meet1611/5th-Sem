
import java.util.ArrayList;
import java.util.Scanner;

public class DFS {
    public static void dfsRec(ArrayList<ArrayList<Integer>> adj, boolean[] visited, int node, ArrayList<Integer> ans) {
        visited[node] = true;
        ans.add(node);

        for(int i: adj.get(node)) {
            if(!visited[i]) {
                dfsRec(adj, visited, i, ans);
            }
        }
    }

    public static ArrayList<Integer> dfs(ArrayList<ArrayList<Integer>> adj) {
        boolean[] visited = new boolean[adj.size()];
        ArrayList<Integer> ans = new ArrayList<>();
        
        dfsRec(adj, visited, 0, ans);
        
        return ans;
    }

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.println("Enter number of Vertices : ");
        int V = sc.nextInt();
        
        ArrayList<ArrayList<Integer>> adj = new ArrayList<>();
        for(int i = 0; i < V; i++) {
            adj.add(new ArrayList<>());
        }

        System.out.println("Enter number of edges : ");
        int E = sc.nextInt();

        int[][] edges = new int[E][2];
        System.out.println("Enter Edges : ");
        for(int i = 0; i < E; i++) {
            System.out.println("Enter " + (i + 1) + " edge : ");
            int x = sc.nextInt();
            int y = sc.nextInt();
            edges[i][0] = x;
            edges[i][1] = y;
            adj.get(x).add(y);
            adj.get(y).add(x);
        }


        ArrayList<Integer> ans = dfs(adj);
        System.out.println("DFS Traversal: ");
        for (int i = 0; i < ans.size(); i++) {
            System.out.print(ans.get(i) + " ");
        }
    }
}
