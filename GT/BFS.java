import java.util.*;

public class BFS {
    public static ArrayList<Integer> bfs(ArrayList<ArrayList<Integer>> adj) {
        boolean[] visited = new boolean[adj.size()];
        ArrayList<Integer> ans = new ArrayList<>();
        Queue<Integer> queue = new LinkedList<>();
        queue.add(0); // Starting BFS from node 0
        visited[0] = true;
        ans.add(0);

        while(!queue.isEmpty()) {
            int node = queue.poll();
            visited[node] = true;

            for(int neighbor : adj.get(node)) {
                if(!visited[neighbor]) {
                    visited[neighbor] = true;
                    queue.add(neighbor);
                    ans.add(neighbor);
                }
            }
        }
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

        ArrayList<Integer> ans = bfs(adj);
        System.out.println("BFS Traversal: ");
        for (int i = 0; i < ans.size(); i++) {
            System.out.print(ans.get(i) + " ");
        }
    }
}
