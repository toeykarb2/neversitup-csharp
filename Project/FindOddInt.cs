
class FindOddInt
{
    public static int FindValue(int[] args){
   
        if(args.Length <= 1){
            return args[0];
        }
    int[] dist = args.Distinct().ToArray();
    
    
    for (int i = 0; i < dist.Length; i++)
    {
        int counter = 0;
        for (int x = 0; x < args.Length; x++)
        {
            if(args[x] == dist[i]){
                counter++;
            }
        }
        if(counter % 2 != 0){
            return dist[i];
        }
    }
    return 0;

    }

  
}