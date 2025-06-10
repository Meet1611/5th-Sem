
import java.util.*;

class Adjcency {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        System.out.println("Enter number of Vertices : ");
        int V = sc.nextInt();
        
        System.out.println("Enter number of edges : ");
        int E = sc.nextInt();
        
        int adj[][] = new int[E][2];
        
        System.out.println("Enter Edges : ");
        for(int i = 0; i < E; i++) {
            System.out.println("Enter " + (i + 1) + " edge : ");
            int x = sc.nextInt();
            int y = sc.nextInt();
            adj[i][0] = x;
            adj[i][1] = y;
        }
        
        List<List<Integer>> edges = new ArrayList<>(V);
        for(int i = 0; i < V; i++) {
            edges.add(new ArrayList<>());
        }
        
        for(int[] edge: adj) {
            int s = edge[0];
            int d = edge[1];
            edges.get(s).add(d);
        }
        
        for(int i = 0; i < edges.size(); i++) {
            System.out.print(i + " -> ");
            for(int j: edges.get(i)) {
                System.out.print(j + " ");
            }
            System.out.println();
        }
        
        // for(int i = 0; i < adj.length; i++) {
        //     for(int j = 0; j < adj[0].length; j++) {
        //         System.out.print(adj[i][j] + " ");
        //     }
        //     System.out.println();
        // }
        sc.close();
    }
}